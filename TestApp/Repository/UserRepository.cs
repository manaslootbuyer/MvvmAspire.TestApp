using System;
using System.Linq;
using MarcelloDB.Collections;
using TestApp.Models;
using TestApp.Repository.Interfaces;

namespace TestApp.Repository
{
    public class UserRepository : BaseNoSqlRepository, IUserRepository
    {
        private Collection<UserModel, Guid> _collection;

        public UserRepository()
        {
            _collection = InitalizeCollection<UserModel, Guid>(p => p.UserId, "user");
        }

        public UserModel Get()
        {
            return _collection.All.FirstOrDefault();
        }

        public void Add(UserModel model)
        {
            _collection.Persist(model);
        }

        public void Delete()
        {
            _collection.Destroy(_collection.All.FirstOrDefault().UserId);
        }
    }
}