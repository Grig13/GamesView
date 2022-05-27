namespace GamesView.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        INewsRepository NewsRepository { get; }
        IReviewRepository ReviewRepository { get; }
        void Save();
    }
}
