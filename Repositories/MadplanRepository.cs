using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories;

public class MadplanRepository : BaseRepository<Madplan>
{
    public Madplan? GetByWeekAndYear(int week, int year)
    {
        var madplan = DbContext.Madplaner
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
        DbContext.SaveChanges();
    }

    public void AddRet(MadplanRet madplanRet)
    {
        // Relation already exists, no need to add it again
        if (DbContext.MadplanRetter.Any(mp => mp.RetId == madplanRet.RetId && mp.MadplanId == madplanRet.MadplanId))
        {
            Console.WriteLine("Relation already exists");
            return;
        }

        DbContext.MadplanRetter.Add(madplanRet);
        DbContext.SaveChanges();
    }

    public void DeleteRet(MadplanRet madplanRet)
    {
        if (DbContext.MadplanRetter.Any(mp => mp.RetId == madplanRet.RetId && mp.MadplanId == madplanRet.MadplanId))
        {
            DbContext.MadplanRetter.Remove(madplanRet);
            DbContext.SaveChanges();
        }
        else {
            Console.WriteLine("No relation found");
        }
    }
}
