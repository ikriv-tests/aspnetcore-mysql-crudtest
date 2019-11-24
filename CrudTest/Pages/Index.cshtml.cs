using CrudTest.Db;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace CrudTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CrudTestDbContext _dbContext;

        public User[] Users { get; private set; }

        public IndexModel(CrudTestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            Users = _dbContext.Users.ToArray();
        }
    }
}
