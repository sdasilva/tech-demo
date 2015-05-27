using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SecMaster.Models;
using MongoDB.Bson;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SecMaster.Controllers
{
    [Route("api/[controller]")]
    public class SecurityController : Controller
    {
        readonly ISecurityRespository _securityRepository;

        public SecurityController(ISecurityRespository securityRepository)
        {
            _securityRepository = securityRepository;
        }

        [HttpGet]
        public IEnumerable<Security> GetAll()
        {
            var securities = _securityRepository.AllSecurities();
            return securities;
        }

        [HttpGet("{id:length(24)}", Name = "GetByIdRoute")]
        public IActionResult GetById(string id)
        {
            var item = _securityRepository.GetById(new ObjectId(id));
            if (item == null)
            {
                return HttpNotFound();
            }

            return new ObjectResult(item);
        }

        [HttpPost]
        public void CreateSecurity([FromBody]Security security)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                _securityRepository.Add(security);

                string url = Url.RouteUrl("GetByIdRoute", new { id = security.Id.ToString() }, Request.Scheme, Request.Host.ToUriComponent());
                Context.Response.StatusCode = 201;
                Context.Response.Headers["Location"] = url;
            }
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult DeleteSecurity(string id)
        {
            if (_securityRepository.Remove(new ObjectId(id)))
            {
                return new HttpStatusCodeResult(204); // 204 No Content
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}
