using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Entities.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository _bookRepository)
        {
            this._bookRepository = _bookRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
           var res =  _bookRepository.GetBooks();
            return Ok(res);
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            _bookRepository.CreateBook(book);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _bookRepository.DeleteBook(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Book book)
        {
            _bookRepository.UpdateBook(book);
            return Ok();
        }
    }
}
