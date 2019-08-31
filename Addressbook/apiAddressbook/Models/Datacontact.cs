

namespace apiAddressbook.Models
{
    using System.Data.Entity;

    public class Datacontact:DbContext
    {
        public Datacontact(): base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<apiAddressbook.Models.Book> Books { get; set; }
    }
}