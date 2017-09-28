using Microsoft.EntityFrameworkCore;

using HCRUDEasy.Domain.Person.Candidate;
using HCRUDEasy.Domain.Bank;
using HCRUDEasy.Domain;

namespace HCRUDEasy.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {

       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        DbSet<Candidate> Candidate { set; get; }
        DbSet<BankInformation> BankInformation { set; get; }

    }

}