using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIcomputers.Models
{
    public class Commands
    {
        public IQueryable<Author> GetAuthors()
        {
            ComputerEntities entities = new ComputerEntities();
            return entities.Authors;
        }

        public IQueryable<Author> GetAuthors(int ID)
        {
            ComputerEntities entities = new ComputerEntities();
            return entities.Authors.Where(a => a.id == ID).Select(e => e);
        }
    }
}