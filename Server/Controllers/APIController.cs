using Application.Interfaces;
using Domain.Models.DTO.SYS;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class APIController : ControllerBase
{
    private readonly IAPIServiceAppService _service;

    public APIController(IAPIServiceAppService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SYS_APIDTO>>> GetAll()
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SYS_APIDTO>> GetById(int id)
    {
        var api = await _service.GetByIdAsync(id);
        if (api == null)
        {
            return NotFound();
        }
        return Ok(api);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] SYS_APIDTO api)
    {
        await _service.CreateAsync(api);
        return CreatedAtAction(nameof(GetById), new { id = api.Id }, api);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, [FromBody] SYS_APIDTO api)
    {
        if (id != api.Id)
        {
            return BadRequest();
        }
        await _service.UpdateAsync(api);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }
}
