using DTS_API.Context;
using DTS_API.Models;
using DTS_API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTS_API.Repositories.Data
{
    public class KaryawanRepository : IKaryawanRepository
    {
        MyContext myContext;

        public KaryawanRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public int Delete(int id)
        {
            var data = myContext.Karyawans.Find(id);
            myContext.Karyawans.Remove(data);
            var result = myContext.SaveChanges();
            return result;
        }

        public List<Karyawan> Get()
        {
            var data = myContext.Karyawans.ToList();
            return data;
        }

        public Karyawan Get(int id)
        {
            var data = myContext.Karyawans.Find(id);
            return data;
        }

        public int Post(Karyawan karyawan)
        {
            var data = myContext.Karyawans.Add(karyawan);
            var result = myContext.SaveChanges();
            return result;
        }

        

        public int Put(Karyawan karyawan)
        {
            var data = myContext.Karyawans.Find(karyawan.id);
            data.name = karyawan.name;
            myContext.Karyawans.Update(data);
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
