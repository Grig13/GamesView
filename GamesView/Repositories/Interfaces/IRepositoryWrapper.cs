namespace GamesView.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IUserRepository UserRepository { get; }
        IAdminRepository AdminRepository { get; }

        void Save();
    }
}
