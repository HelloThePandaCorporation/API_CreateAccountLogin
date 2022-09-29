using DTS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTS_API.Repositories.Interface
{
    public interface ILateRepository
    {
        List<Late> Get();
        Late Get(int id);
        int Post(Late late);
        int Put(Late late);
        int Delete(int id);
    }
}
