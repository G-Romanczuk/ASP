using System.Linq;

namespace ASP.Models
{
    public class EFStudentRepository : IStudentRepository
    {
        private ApplicationDbContext _applicationDbContext;

        public EFStudentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IQueryable<Student> Students => _applicationDbContext.Students;
    }
}
