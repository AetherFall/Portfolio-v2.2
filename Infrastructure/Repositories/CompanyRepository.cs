using Domain.Interfaces;
using Domain.Models.DAO.PRO;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CompanyRepository : ICompanyRepository
{
    private readonly AppDbContext _context;

    public CompanyRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<PRO_Company?>> GetAllAsync()
    {
        return await _context.PRO_Company.ToListAsync();
    }

    public async Task<PRO_Company?> GetByIdAsync(int id)
    {
        return await _context.PRO_Company.FindAsync(id);
    }

    public async Task CreateAsync(PRO_Company? company)
    {
        _context.PRO_Company.Add(company);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PRO_Company company)
    {
        _context.Entry(company).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var company = await _context.PRO_Company.FindAsync(id);
        if (company != null)
        {
            _context.PRO_Company.Remove(company);
            await _context.SaveChangesAsync();
        }
    }
}
