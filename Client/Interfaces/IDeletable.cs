namespace Eternar.Core
{
    public interface IDeletable : IExistable
    {
        bool Delete();
    }
}