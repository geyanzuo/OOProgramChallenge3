using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIcomputers.Models;

namespace APIcomputers.Controllers
{
    public class BorrowerController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Borrower> Get()
        {
            ComputerEntities entities = new ComputerEntities();
            return entities.Borrowers.ToList();
        }

        // GET api/<controller>/5
        public Borrower Get(int id)
        {
            ComputerEntities computerEntities = new ComputerEntities();
           
            return computerEntities.Borrowers.FirstOrDefault(bo => bo.id == id);
          
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}