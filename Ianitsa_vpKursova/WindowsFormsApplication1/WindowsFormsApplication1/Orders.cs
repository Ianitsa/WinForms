using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class Orders
    {
        string orderNo;
        public string OrderNo
        {
            get { return orderNo; }
            set { orderNo = value; }
        }

        string orderDate;
        public string OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        string sheepedDate;
        public string SheepedDate
        {
            get { return sheepedDate; }
            set { sheepedDate = value; }
        }

        string product;
        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        string quantity;
        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        string price;
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        string sum;
        public string Sum
        {
            get { return sum; }
            set {sum = value; }
        }

    }
}
