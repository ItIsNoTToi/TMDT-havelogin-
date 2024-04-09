using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMDT1.Data;
using TMDT1.Models;

namespace TMDT1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly SHOPDBContext _context;
        public CartController(SHOPDBContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Carts>> Get()
        {
            return await _context.Carts.ToListAsync();
        }

        [HttpGet("id")]
        [ProducesResponseType(typeof(Carts), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetbyId(int id)
        {
            var Id = await _context.Carts.FirstOrDefaultAsync(c => c.Id == id);
            return  Id == null ? NotFound() : Ok(Id);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Carts carts)
        {
            await _context.Carts.AddAsync(carts);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetbyId), new {id = carts.Id}, carts);
        }

        [HttpPut("id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int Id, Carts carts)
        {
            if (Id != carts.Id) return BadRequest();

            _context.Entry(carts).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpDelete("id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(int Id) {

            var carttodelete = await _context.Carts.FindAsync(Id);
            if(carttodelete == null)
            {
                return NotFound();
            }
            _context.Carts.Remove(carttodelete);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
