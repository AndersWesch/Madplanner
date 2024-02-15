using Models;
using Repositories;

namespace ActionHandlers;

public class MadplanHandler
{
    private readonly RetRepository Repository;

    public MadplanHandler()
    {
        Repository = new RetRepository();
    }

    public List<Ret> GetMadplan()
    {
        var retter = new List<Ret> {
            Repository.GetRandomRet(),
            Repository.GetRandomRet(),
            Repository.GetRandomRet(),
            Repository.GetRandomRet(),
            Repository.GetRandomRet()
        };

        return retter;
    }

    public List<Ret> Switch(List<Ret> retter, int switchIndex)
    {
        var newRet = Repository.GetRandomRet();
        
        // Check if the newRet is already in the list
        while (retter.Any(ret => ret.Id == newRet.Id))
        {
            newRet = Repository.GetRandomRet();
        }

        retter[switchIndex] = newRet;

        return retter;
    }
}
