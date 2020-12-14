using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    public class InitialData
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.Guitars.Any())
            {
                context.Guitars.AddRange(
                    new Guitar
                    {
                        Name = "Jackson RR",
                        Company = "Fokin",
                        Price = 1000
                    },
                    new Guitar
                    {
                        Name = "Fender Squier",
                        Company = "Cyber",
                        Price = 550
                    },
                    new Guitar
                    {
                        Name = "Warvick",
                        Company = "USAGuitars",
                        Price = 1500
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
