
using System;
using System.Collections.Generic;
using bookapi.Models;
using libraryapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace libraryapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        
        private readonly BookService _service;
        public BookController(BookService service){
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
            try
            {
                return Ok(_service.Get());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetById(string id)
        {
            try
            {
                return Ok(_service.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Book> Create([FromBody] Book newBook)
        {
            try
            {
                return Ok(_service.Create(newBook));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Book> Delete(string id)
        {
            try
            {
                return Ok(_service.Delete(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Book> Edit([FromBody] Book editCat, string id){
            try
            {
                return Ok(_service.Edit(editCat, id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


    }


}
