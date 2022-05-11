﻿using GamesView.Data;
using GamesView.Repositories.Interfaces;

namespace GamesView.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private GamesViewDbContext _dbContext;
        private IUserRepository   _userRepository;
        private IAdminRepository  _adminRepository;
        private IReviewRepository _reviewRepository;
        private INewsRepository   _newsRepository;

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_dbContext);
                }
                return _userRepository;
            }
        }

        public IAdminRepository AdminRepository
        {
            get
            {
                if (_adminRepository == null)
                {
                    _adminRepository = new AdminRepository(_dbContext);
                }
                return _adminRepository;
            }
        }

       

        public RepositoryWrapper(GamesViewDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
