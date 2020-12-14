using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    public class Guitar
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Company { get; set; }
        
        public int Price { get; set; }

    }
}
