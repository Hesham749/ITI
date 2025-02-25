using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Core.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required, StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public virtual IEnumerable<Book> Books { get; set; }
    }
}
