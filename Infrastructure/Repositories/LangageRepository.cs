using Domain.Interfaces;
using Domain.Models.DAO.SYS;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories;

public class LangageRepository : ILangageRepository
{
    private readonly AppDbContext _context;

    public LangageRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<SYS_Langage>> GetAllAsync()
    {
        return await _context.SYS_Langage.ToListAsync();
    }

    public async Task<SYS_Langage> GetByIdAsync(int id)
    {
        return await _context.SYS_Langage.FindAsync(id);
    }

    public async Task CreateAsync(SYS_Langage langage)
    {
        _context.SYS_Langage.Add(langage);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(SYS_Langage langage)
    {
        _context.Entry(langage).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var langage = await _context.SYS_Langage.FindAsync(id);
        if (langage != null)
        {
            _context.SYS_Langage.Remove(langage);
            await _context.SaveChangesAsync();
        }
    }
}
