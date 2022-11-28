using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Model
    {
        [Key]
        public int ModelId { get; set; }

        public string ModelName { get; set; }

        public DateTime ModelDate { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
