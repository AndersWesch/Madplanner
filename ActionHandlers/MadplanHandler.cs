using System.Globalization;
using Models;
using Repositories;

namespace ActionHandlers;

public class MadplanHandler
{
    private readonly RetRepository retRepository;
    private readonly MadplanRepository madplanRepository;

    public MadplanHandler()
    {
        retRepository = new RetRepository();
        madplanRepository = new MadplanRepository();
    }

    public Madplan GetCurrentMadplan()
    {
        int week = GetWeekNumber();
        int year = DateTime.Now.Year;
        
        var currentMadplan = madplanRepository.GetByWeekAndYear(week, year);

        if (currentMadplan == null)
        {
            currentMadplan = CreateMadplan(week, year);
        }

        return currentMadplan;
    }

    public Madplan GetMadplan(int? week, int? year)
    {
        if (week == null) 
        {
            week = GetWeekNumber();
            year = DateTime.Now.Year;
        }

        var currentMadplan = madplanRepository.GetByWeekAndYear((int)week, (int)year);

        if (currentMadplan == null)
        {
            currentMadplan = CreateMadplan((int)week, (int)year);
        }

        return currentMadplan;
    }

    public List<Madplan> GetAllMadplaner()
    {
        return madplanRepository.GetAll();
    }

    public Madplan Switch(Madplan madplan, MadplanRet madplanRet)
    {
        var newRet = retRepository.GetRandomRet();
        var retIds = madplan.MadplanRetter.Select(mr => mr.RetId).ToList();

        // Check if the newRet is already in the list
        while (retIds.Any(retId => retId == newRet.Id))
        {
            newRet = retRepository.GetRandomRet();
        }

        var newMadplanRet = new MadplanRet {
            MadplanId = madplan.Id,
            RetId = newRet.Id,
            Order = madplanRet.Order
        };

        // Delete old relation
        madplanRepository.DeleteRet(madplanRet);
        
        // Create a new relation
        madplanRepository.AddRet(newMadplanRet);

        // Fetch a new instance of madplan
        madplan = madplanRepository.GetByWeekAndYear(madplan.Week, madplan.Year);

        return madplan;
    }

    private Madplan CreateMadplan(int week, int year)
    {
        var madplan = new Madplan {
            Week = week,
            Year = year
        };

        madplan = madplanRepository.Create(madplan);

        for (var i = 0; i < 5; i++)
        {
            var ret = retRepository.GetRandomRet();

            var madplanRet = new MadplanRet {
                MadplanId = madplan.Id,
                RetId = ret.Id,
                Order = i+1
            };

            madplanRepository.AddRet(madplanRet);
        }

        return madplan;
    }

    private int GetWeekNumber()
    {
        DateTime date = DateTime.Now;
        CultureInfo cultureInfo = CultureInfo.CurrentCulture;
        Calendar calendar = cultureInfo.Calendar;

        return calendar.GetWeekOfYear(date, cultureInfo.DateTimeFormat.CalendarWeekRule, cultureInfo.DateTimeFormat.FirstDayOfWeek);
    }
}
