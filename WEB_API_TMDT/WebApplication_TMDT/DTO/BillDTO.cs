using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.DAL;
using WebApplication_TMDT.DTO.interfaceDTO;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DTO
{
    public class BillDTO : IBill
    {
        private IRepository _IRepository;
        private IUnitOfWork _IUnitOfWork;

        public BillDTO(IRepository repository, IUnitOfWork unitOfWork)
        {
            _IRepository = repository;
            _IUnitOfWork = unitOfWork;
        }
        public void Add(Bill bill)
        {
            _IRepository.Add(bill);
            _IUnitOfWork.SaveChages();
        }

        public void Delete(string id)
        {
            _IRepository.Delete<Bill>(id);
            _IUnitOfWork.SaveChages();
        }

        public Bill Get(string id)
        {
            return _IRepository.Get<Bill>(id);
        }

        public IEnumerable<Bill> getAll()
        {
            return _IRepository.GetAll<Bill>();
        }

        public void Update(Bill bill)
        {
            _IRepository.Update(bill);
            _IUnitOfWork.SaveChages();
        }
    }
}
