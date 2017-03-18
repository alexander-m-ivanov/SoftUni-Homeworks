using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDbApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BlogDbContext();
            var p = new Posts()
            {
                Body = "Здравейте, Това ми е първият пост.",
                Title = "Първи пост",
                AuthorID = 3,
                Date = DateTime.Now
            };
            db.Posts.Add(p);
            db.SaveChanges();
        }
    }
}
