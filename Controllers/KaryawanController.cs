using DTC_CRUD_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTC_CRUD_MVC.Context;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DTC_CRUD_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KaryawanController : Controller 
    {
        MyContext myContext;

        public KaryawanController(MyContext myContext)
        {
            this.myContext = myContext;
        }
        //READ
        public IActionResult Index()
        {
            
            var data = myContext.Karyawans.Include(x => x.Salary).ToList();

            return View(data);
        }
        


        //CREATE
        //-GET
        public IActionResult Create()
        {
            return View();
            
        }
        //-POST
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Karyawan karyawan)
        {

            

            myContext.Karyawans.Add(karyawan);
            
            var value = myContext.SaveChanges();

            if (value != 0)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(karyawan);
        }

        //UPDATE
        //-GET


        //-POST
        
        public IActionResult Edit(Karyawan karyawan)
        {
            
            var data = myContext.Karyawans.Update(karyawan);
            var value = myContext.SaveChanges();

            if (value != 0)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(data);

        }

        
        //DELETE
        public IActionResult Delete(Karyawan karyawan)
        {

            myContext.Karyawans.Remove(karyawan);
            var value = myContext.SaveChanges();
           
            if (value > 0)
            {
                return RedirectToAction("index");
            }

            return View();
        }
        //-GET
        //-POST

        public IActionResult Details (Karyawan karyawan)
        {
            var data = myContext.Karyawans.Find(karyawan.id);
            return View(data);
        }
    }
}
