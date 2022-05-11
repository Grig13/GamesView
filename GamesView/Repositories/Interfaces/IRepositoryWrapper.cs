namespace GamesView.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IUserRepository UserRepository { get; }
        IAdminRepository AdminRepository { get; }
        INewsRepository NewsRepository { get; }
        IReviewRepository ReviewRepository { get; }
        void Save();
    }
}
