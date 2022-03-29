using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public LibroController(AplicationDbContext context)
        {
            _context = context; 
        }
        // GET: api/<LibroController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listLibro = await _context.Libro.ToListAsync();
                return Ok(listLibro);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        // POST api/<LibroController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Libro libro)
        {
            try
            {
                _context.Add(libro);
                await _context.SaveChangesAsync();
                return Ok(libro);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<LibroController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Libro libro)
        {
            try
            {
                if (id != libro.Id) {
                    return NotFound();
                }
                _context.Update(libro);
                await _context.SaveChangesAsync();
                return Ok(new { message ="el libro  fue actualizado con exito" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<LibroController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var libro = await _context.Libro.FindAsync(id);

                if (libro == null) 
                {
                    return NotFound();
                }

                _context.Libro.Remove(libro);
                await _context.SaveChangesAsync();
                return Ok(new { message = "el libro fue eliminado con exito" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
