using Database;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories;

public class MadplanRepository : BaseRepository<Madplan>
{
    public MadplanRepository(DatabaseContext dbContext) : base(dbContext)
    {
    }

    public Madplan? GetByWeekAndYear(int week, int year)
    {
        var madplan = _databaseContext.Madplaner
            .Where(m => m.Week == week)
            .Where(m => m.Year == year)
            .Include(m => m.MadplanRetter)
                .ThenInclude(mr => mr.Ret)
                .ThenInclude(r => r.Ingredienser)
                .ThenInclude(i => i.Produkt)
            .FirstOrDefault();
        
        if (madplan != null)
        {
            madplan.MadplanRetter = madplan.MadplanRetter.OrderBy(mr => mr.Order).ToList();
        }
        
        return madplan;
    }

    public void UpdateMadplanRet(MadplanRet madplanRet)
    {
        _databaseContext.SaveChanges();
    }

    public void AddRet(MadplanRet madplanRet)
    {
        // Relation already exists, no need to add it again
        if (_databaseContext.MadplanRetter.Any(mp => mp.RetId == madplanRet.RetId && mp.MadplanId == madplanRet.MadplanId))
        {
            Console.WriteLine("Relation already exists");
            return;
        }

        _databaseContext.MadplanRetter.Add(madplanRet);
        _databaseContext.SaveChanges();
    }

    public void DeleteRet(MadplanRet madplanRet)
    {
        if (_databaseContext.MadplanRetter.Any(mp => mp.RetId == madplanRet.RetId && mp.MadplanId == madplanRet.MadplanId))
        {
            _databaseContext.MadplanRetter.Remove(madplanRet);
            _databaseContext.SaveChanges();
        }
        else {
            Console.WriteLine("No relation found");
        }
    }
}
