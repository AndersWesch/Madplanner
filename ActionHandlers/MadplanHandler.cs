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
}