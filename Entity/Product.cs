using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        [Key]
        public int CarId { get; set; }

        public int CarQuantity { get; set; }

        public int CarPrice { get; set; }

        public int CarLuggage { get; set; }

        public string CarName { get; set; }

        public Model models { get; set; }

       

        public ICollection<Category> Categories { get; set; }
    }
}
