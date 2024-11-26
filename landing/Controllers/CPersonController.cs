using landing.Data;
using landing.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace landing.Controllers
{
    public class CPersonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CPersonController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Person/Create

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return Ok(new { success = true });
            }

            var errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage));
            return BadRequest(new { success = false, errors });
        }

    }
}
