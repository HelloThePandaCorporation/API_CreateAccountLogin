using DTS_API.Context;
using DTS_API.Models;
using DTS_API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTS_API.Repositories.Data
{
    public class LateRepository : ILateRepository
    {
        MyContext myContext;

        public LateRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public int Delete(int id)
        {
            var data = myContext.Lates.Find(id);
            myContext.Lates.Remove(data);
            var result = myContext.SaveChanges();
            return result;
        }

        public List<Late> Get()
        {
            var data = myContext.Lates.ToList();
            return data;
        }

        public Late Get(int id)
        {
            var data = myContext.Lates.Find(id);
            return data;
        }

        public int Post(Late late)
        {
            var data = myContext.Lates.Add(late);
            var result = myContext.SaveChanges();
            return result;
        }

        public int Put(Late late)
        {
            var data = myContext.Lates.Find(late.id);
            data.id = late.id;
            myContext.Lates.Update(data);
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
