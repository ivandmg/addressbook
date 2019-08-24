

namespace Addressbook.Models
{
    using System.Data.Entity;
    public class DataContact:DbContext
    {

        public DataContact():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<Addressbook.Models.Book> Books { get; set; }
    }
}