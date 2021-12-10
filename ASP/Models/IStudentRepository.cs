using System.Linq;

using EPaczucha.Models;

namespace EPaczucha.Models
{
    public interface IStudentRepository
    {
        IQueryable<Student> Students { get; }
    }
}
