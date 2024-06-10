using Domain.Interfaces.Repositories;
using Domain.Models.DAO.INT;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CompetenceCategoryRepository : ICompetenceCategoryRepository
{
    private readonly AppDbContext _context;

    public CompetenceCategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<INT_CompetenceCategory?>> GetAllAsync()
    {
        return await _context.INT_CompetenceCategory.ToListAsync();
    }

    public async Task<INT_CompetenceCategory?> GetByIdAsync(int id)
    {
        return await _context.INT_CompetenceCategory.FindAsync(id);
    }

    public async Task CreateAsync(INT_CompetenceCategory? category)
    {
        _context.INT_CompetenceCategory.Add(category);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(INT_CompetenceCategory category)
    {
        _context.Entry(category).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var category = await _context.INT_CompetenceCategory.FindAsync(id);
        if (category != null)
        {
            _context.INT_CompetenceCategory.Remove(category);
            await _context.SaveChangesAsync();
        }
    }

    public async Task AddAsync(INT_CompetenceCategory category)
    {
        _context.INT_CompetenceCategory.Add(category);
        await _context.SaveChangesAsync();
    }
}
