using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.DAL;
using WebApplication_TMDT.DTO.interfaceDTO;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DTO
{
    public class UsersDTO : IUsers
    {
        private IRepository _repository;
        private IUnitOfWork _unitOfWork;

        public UsersDTO(IRepository repository,IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Users user)
        {
            _repository.Add(user);
            _unitOfWork.SaveChages();
        }

        public IEnumerable<Models.Users> getAll()
        {
            return _repository.GetAll<Models.Users>();
        }

        public void Update(Users user)
        {
            _repository.Update(user);
            _unitOfWork.SaveChages();
        }

        public void Delete(string ID)
        {
            _repository.Delete<Users>(ID);
            _unitOfWork.SaveChages();
        }
        public Users Get(string id)
        {
            var user = _repository.Get<Models.Users>(id);
            return user;
        }
    }
}
