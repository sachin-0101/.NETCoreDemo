using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DNC_Demo_WebAPIBasics.Data;
using DNC_Demo_WebAPIBasics.Models;

namespace DNC_Demo_WebAPIBasics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DNCDbContext _context;

        public ProductsController(DNCDbContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]        
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        // GET: api/Products/5
        //[HttpGet("{id}")]
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            //return product; // This will return the product as JSON by default
            return Ok(product); // This is an alternative way to return the product, explicitly using Ok() for clarity
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

           // _context.Entry(product).State = EntityState.Modified;
           _context.Products.Update(product); // This is an alternative way to update the entity more readable

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.Id }, product); // controller, action, and route values for the resource.
            // The CreatedAtAction method creates a response with a 201 status code
            // and includes a Location header pointing to the newly created resource
            
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
           
            if (product == null)
            {
                return NotFound();
               
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
            //return Ok(product); // This is an alternative way to return the product, explicitly using Ok() for clarity
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
