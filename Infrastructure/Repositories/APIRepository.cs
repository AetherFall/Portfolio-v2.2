using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Domain.Models.DAO.SYS;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class APIRepository : IAPIRepository
{
    private readonly AppDbContext _context;

    public APIRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<SYS_API?>> GetAllAsync()
    {
        return await _context.SYS_API.ToListAsync();
    }

    public async Task<SYS_API?> GetByIdAsync(int id)
    {
        return await _context.SYS_API.FindAsync(id);
    }

    public async Task CreateAsync(SYS_API? api)
    {
        _context.SYS_API.Add(api);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(SYS_API api)
    {
        _context.Entry(api).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var api = await _context.SYS_API.FindAsync(id);
        if (api != null)
        {
            _context.SYS_API.Remove(api);
            await _context.SaveChangesAsync();
        }
    }
}
