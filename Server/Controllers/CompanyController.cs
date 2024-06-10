using Application.Interfaces;
using Domain.Models.DTO.PRO;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompanyController : ControllerBase
{
    private readonly ICompanyServiceAppService _service;

    public CompanyController(ICompanyServiceAppService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PRO_CompanyDTO>>> GetAll()
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PRO_CompanyDTO>> GetById(int id)
    {
        var company = await _service.GetByIdAsync(id);
        if (company == null)
        {
            return NotFound();
        }
        return Ok(company);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] PRO_CompanyDTO company)
    {
        await _service.CreateAsync(company);
        return CreatedAtAction(nameof(GetById), new { id = company.Id }, company);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, [FromBody] PRO_CompanyDTO company)
    {
        if (id != company.Id)
        {
            return BadRequest();
        }
        await _service.UpdateAsync(company);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }
}
