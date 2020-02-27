using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_TMDT.DAL;
using WebApplication_TMDT.DTO;
using WebApplication_TMDT.DTO.interfaceDTO;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUsers _Users;
        public UsersController(IUsers user)
        {
            _Users = user;
        }

        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var listNV = _Users.getAll();
            return Ok(listNV);
        }

        [Route("Get")]
        [HttpGet]
        public ActionResult Get(string id)
        {
            var user = _Users.Get(id);
            return Ok(user);
        }

        [Route("Add")]
        [HttpPost]
        public ActionResult Add(Users user)
        {
            _Users.Add(user);
            return Ok();
        }

        [Route("Update")]
        [HttpPost]
        public ActionResult Update(Users user)
        {
            _Users.Update(user);
            return Ok();
        }

        [Route("Delete")]
        [HttpPost]
        public ActionResult Delete(string userID)
        {
            _Users.Delete(userID);
            return Ok();
        }

    }
}