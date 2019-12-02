using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIcomputers.Models;

namespace APIcomputers.Controllers
{
    public class AuthorController : ApiController
    {
        

        // GET api/<controller>
        public IEnumerable<Author> Get()
        {
            ComputerEntities entities = new ComputerEntities();
            return entities.Authors.ToList();
        }

        // GET api/<controller>/5
        public Author Get(int id)
        {
            ComputerEntities computerEntities = new ComputerEntities();
            
            return computerEntities.Authors.FirstOrDefault(a => a.id == id);
            
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