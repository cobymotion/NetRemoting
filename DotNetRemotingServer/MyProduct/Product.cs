using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProduct
{
    [Serializable]
    public class Product
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
    }
}
