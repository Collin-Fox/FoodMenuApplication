using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodTestOne
{
    internal class food
    {

        public food(string storeId, string name, string price, string img)
        {
            this.storeId = storeId;
            this.name = name;
            this.price = price;
            this.img = img;
        }

        public string storeId { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string img { get; set; }


    }
}
