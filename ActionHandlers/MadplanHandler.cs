using System.Globalization;
using Models;
using Repositories;

namespace ActionHandlers;

public class MadplanHandler
{
    private readonly RetRepository _retRepository;
    private readonly MadplanRepository _madplanRepository;

    public MadplanHandler(RetRepository retRepository, MadplanRepository madplanRepository)
    {
        _retRepository = retRepository;
        _madplanRepository = madplanRepository;
    }

    public Madplan GetCurrentMadplan()
    {
        int week = GetWeekNumber();
        int year = DateTime.Now.Year;
        
        var currentMadplan = _madplanRepository.GetByWeekAndYear(week, year);

        if (currentMadplan == null)
        {
            currentMadplan = CreateMadplanByWeekAndYear(week, year);
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

        var currentMadplan = _madplanRepository.GetByWeekAndYear((int)week, (int)year);

        if (currentMadplan == null)
        {
            currentMadplan = CreateMadplanByWeekAndYear((int)week, (int)year);
        }

        return currentMadplan;
    }

    public List<Madplan> GetAllMadplaner()
    {
        return _madplanRepository.GetAll().OrderByDescending(mp => mp.Week).ToList();
    }

    public Madplan Switch(Madplan madplan, MadplanRet madplanRet)
    {
        var currentRetter = madplan.MadplanRetter.Select(mr => mr.Ret).ToList();
        var newRet = _retRepository.GetRandomRet(currentRetter);

        var newMadplanRet = new MadplanRet {
            MadplanId = madplan.Id,
            RetId = newRet.Id,
            Order = madplanRet.Order
        };

        // Delete old relation
        _madplanRepository.DeleteRet(madplanRet);
        
        // Create a new relation
        _madplanRepository.AddRet(newMadplanRet);

        // Fetch a new instance of madplan
        madplan = _madplanRepository.GetByWeekAndYear(madplan.Week, madplan.Year);

        return madplan;
    }

    public void DeleteMadplan(Madplan madplan)
    {
        _madplanRepository.Delete(madplan);
    }

    public Madplan UpdateMadplan(Madplan madplan)
    {
        return _madplanRepository.Update(madplan);
    }

    public Madplan CreateMadplan()
    {
        var currentMadplaner = _madplanRepository.GetAll();
        var latestMadplan = currentMadplaner.OrderByDescending(m => m.Week).First();

        var newMadplan = CreateMadplanByWeekAndYear(latestMadplan.Week+1, latestMadplan.Year);

        return newMadplan;
    }

    public void UpdateMadplanRet(MadplanRet madplanRet)
    {
        _madplanRepository.UpdateMadplanRet(madplanRet);
    }

    private Madplan CreateMadplanByWeekAndYear(int week, int year)
    {
        // TODO make sure to switch year if week doesn't exist
        var madplan = new Madplan {
            Week = week,
            Year = year
        };

        madplan = _madplanRepository.Create(madplan);

        // TODO make sure to use the correct week and year on year change
        var previousMadplan = _madplanRepository.GetByWeekAndYear(week-1, year);

        // TODO Where not removed
        var previousRetter = previousMadplan.MadplanRetter.Select(mr => mr.Ret).ToList();

        double totalPrice = 0;
        double totalCalories = 0;

        for (var i = 0; i < 5; i++)
        {
            var ret = _retRepository.GetRandomRet(previousRetter);

            var madplanRet = new MadplanRet {
                MadplanId = madplan.Id,
                RetId = ret.Id,
                Order = i+1
            };

            if (ret.Price != null)
            {
                totalPrice += (double)ret.Price;
            }

            if (ret.Calories != null)
            {
                totalCalories += (double)ret.Calories;
            }
            
            _madplanRepository.AddRet(madplanRet);
        }

        madplan.Price = Math.Round(totalPrice, 2);
        madplan.Calories = Math.Round(totalCalories, 2);
        madplan = _madplanRepository.Update(madplan);

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
