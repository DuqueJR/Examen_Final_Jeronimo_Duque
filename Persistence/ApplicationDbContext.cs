using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models;
using Microsoft.EntityFrameworkCore;

namespace FINAL_WEB_JERONIMO_DUQUE_RUIZ.Persistence
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Preguntas> Pregunta { get; set; }
    }
}
