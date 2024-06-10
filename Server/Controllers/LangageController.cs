using Application.Interfaces;
using Domain.Models.DTO.SYS;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LangageController : ControllerBase
{
    private readonly ILangageServiceAppService _service;

    public LangageController(ILangageServiceAppService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SYS_LangageDTO>>> GetAll()
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SYS_LangageDTO>> GetById(int id)
    {
        var langage = await _service.GetByIdAsync(id);
        return Ok(langage);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] SYS_LangageDTO langage)
    {
        await _service.CreateAsync(langage);
        return CreatedAtAction(nameof(GetById), new { id = langage.Id }, langage);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, [FromBody] SYS_LangageDTO langage)
    {
        if (id != langage.Id)
        {
            return BadRequest();
        }
        await _service.UpdateAsync(langage);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }
}
