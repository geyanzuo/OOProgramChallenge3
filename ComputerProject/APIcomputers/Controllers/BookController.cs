﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIcomputers.Models;
using System.Data.SqlClient;

namespace APIcomputers.Controllers
{
    public class BookController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Book> Get()
        {
            ComputerEntities entities = new ComputerEntities();
            return entities.Books.ToList();
        }

        // GET api/<controller>/5
        public Book Get(int id)
        {
            ComputerEntities computerEntities = new ComputerEntities();

            return computerEntities.Books.FirstOrDefault(b => b.ISBN == id);
        }

        public Book GetNonBorrowed(Borrower staute)
        {
            ComputerEntities computerEntities = new ComputerEntities();

            return computerEntities.Books.FirstOrDefault(b => b.Borrower1 == staute);
        }



        // POST api/<controller>


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