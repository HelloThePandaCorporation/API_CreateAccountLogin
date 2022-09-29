using DTS_API.Context;
using DTS_API.Models;
using DTS_API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTS_API.Repositories.Data
{
    public class SalaryRepository : ISalaryRepository
    {
        MyContext myContext;

        public SalaryRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public int Delete(int id)
        {
            var data = myContext.Salaries.Find(id);
            myContext.Salaries.Remove(data);
            var result = myContext.SaveChanges();
            return result;
        }

        public List<Salary> Get()
        {
            var data = myContext.Salaries.ToList();
            return data;
        }

        public Salary Get(int id)
        {
            var data = myContext.Salaries.Find(id);
            return data;
        }

        public int Post(Salary salary)
        {
            var data = myContext.Salaries.Add(salary);
            var result = myContext.SaveChanges();
            return result;
        }

        public int Put(Salary salary)
        {
            var data = myContext.Salaries.Find(salary.SalaryId);
            data.SalaryId = salary.SalaryId;
            myContext.Salaries.Update(data);
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
