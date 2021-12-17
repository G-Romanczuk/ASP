using System.Linq;

using ASP.Models;

namespace ASP.Models
{
    public interface IStudentRepository
    {
        IQueryable<Student> Students { get; }
    }
}
