using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_TMDT.DTO.interfaceDTO;

namespace WebApplication_TMDT.Controllers
{
    [Route("api/Bill")]
    [ApiController]
    public class BillController : ControllerBase
    {
        IBill _IBill;
        public BillController(IBill Bill)
        {
            _IBill = Bill;
        }
        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var listBill = _IBill.getAll();
            return Ok(listBill);
        }
    }
}