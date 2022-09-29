using DTS_API.Context;
using DTS_API.Models;
using DTS_API.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LateController : ControllerBase
    {
        LateRepository lateRepository;

        public LateController(LateRepository lateRepository)
        {
            this.lateRepository = lateRepository;
        }

        //READ
        [HttpGet]
        public IActionResult Get()
        {
            var data = lateRepository.Get();
            if (data == null)
            {
                return Ok(new
                {
                    message = "Sukses mengambil data",
                    StatusCode = 200,
                    data = "null"
                });
            }
            return Ok(new
            {
                message = "Sukses Mengambil data",
                statusCode = 200,
                data = data
            });
        }
        //UPDATE
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = lateRepository.Get(id);
            if (data == null)
            {
                return Ok(new
                {
                    message = "Sukses mengambil data",
                    StatusCode = 200,
                    data = "null"
                });
            }
            return Ok(new
            {
                message = "Sukses Mengambil data",
                statusCode = 200,
                data = data
            });
        }
        [HttpPut]
        public IActionResult Put(Late late)
        {
            var result = lateRepository.Put(late);
            if (result > 0)
            {
                return Ok(new
                {
                    StatusCode = 200,
                    message = "berhasil mengubah data"
                });
            }
            return BadRequest(new
            {
                StatusCode = 200,
                message = "gagal mengubah data"
            });
        }
        //CREATE
        [HttpPost]

        public IActionResult Post(Late late)
        {
            var result = lateRepository.Post(late);
            if (result > 0)
            {
                return Ok(new
                {
                    StatusCode = 200,
                    message = "berhasil menambah data"
                });
            }
            return BadRequest(new
            {
                StatusCode = 200,
                message = "gagal menambah data"
            });
        }
        //DELETE
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var result = lateRepository.Delete(id);
            if (result > 0)
            {
                return Ok(new
                {
                    StatusCode = 200,
                    message = "berhasil menghapus data"
                });
            }
            return BadRequest(new
            {
                StatusCode = 200,
                message = "gagal menhapus data"
            });

        }
    }
}
