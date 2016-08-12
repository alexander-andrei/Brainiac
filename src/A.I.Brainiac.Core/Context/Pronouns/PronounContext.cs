using A.I.Brainiac.Core.Models.Pronouns.Personal;
using Microsoft.EntityFrameworkCore;

namespace A.I.Brainiac.Core.Context.Pronouns
{
    public class PronounContext : DbContext
    {
        public PronounContext(DbContextOptions<PronounContext> options) : base(options)
        {
        }

        public DbSet<PersonalPronounModel> Personal { get; set; }
    }
}
