using Microsoft.EntityFrameworkCore;

namespace Lab_APIs.Models
{
    public class LabApiContext: DbContext
    {
        public LabApiContext()
        {

        }

        public LabApiContext(DbContextOptions<LabApiContext> options): base(options)
        {

        }

        
    }
}
