using Application.Interfaces;
using Domain.Models.DTO.INT;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompetenceCategoryController : ControllerBase
{
    private readonly ICompetenceCategoryAppService _appService;

    public CompetenceCategoryController(ICompetenceCategoryAppService appService)
    {
        _appService = appService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<INT_CompetenceCategoryDTO>>> GetAll()
    {
        return Ok(await _appService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<INT_CompetenceCategoryDTO>> GetById(int id)
    {
        var category = await _appService.GetByIdAsync(id);
        if (category == null)
        {
            return NotFound();
        }
        return Ok(category);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] INT_CompetenceCategoryDTO dto)
    {
        await _appService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, [FromBody] INT_CompetenceCategoryDTO dto)
    {
        if (id != dto.Id)
        {
            return BadRequest();
        }
        await _appService.UpdateAsync(dto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _appService.DeleteAsync(id);
        return NoContent();
    }
}

