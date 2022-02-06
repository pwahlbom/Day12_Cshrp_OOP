using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Cshrp_OOP
{
    class MyClass
    {
        public int MyProperty { get; set; }
        private int myVar;

        public int MyProperty2
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
    public class Customer
    {
        //public void MethodName(params int[] Values)
        //{
        //    //StringBuilder sb = new StringBuilder();
        //    var MyVar = 0;
        //    foreach (int Value in Values)
        //    {
        //        MyVar = MyVar + Value;
        //        //sb.AppendFormat(string.Format("{0} ", name));
        //    }
        //    return MyVar;
        //    //string wholeName = sb.ToString();
        //    //Console.WriteLine(wholeName);
        //    //Console.ReadLine();
        //}


        public MethodName(params int[] ArrayName)
        {
            var MyVar = 0;
            foreach (int Value in ArrayName)
            {
                MyVar = MyVar + Value;
            }
            return MyVar;
        }


    }

    public class Product
    {
        //local properties
        public string Name { get; set; }



        //breaking open the get/set is commonly done when validaion is required
        public decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    //throw an error of invalid data
                    throw new ArgumentOutOfRangeException("value", "Price can not be less than zero");
                    //optionally set a default value
                    _price = 10m;
                }
                _price = value;
            }
        }

        //methods
        public decimal CalculateTax()
        {
            //0.08 needs to be cast as a decimal to avoid compile error
            return 0.08m * _price;
        }

        public decimal CalculateTotal(decimal tax, decimal discount)
        {
            return Price + (Price * tax) - (Price * discount);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {



            var Customer1 = new Customer();
            Customer1.MethodName("Billy", "Bob", "Thronton", "III");

            var product1 = new Product
            {
                Name = "Phone",
                Price = 329.99m
            };

            var product2 = new Product
            {

                Name = "Laptop",
                Price = 599.99m
            };


            var product3 = new Product();
            product3.Name = "Camera";
            product3.Price = -2.49m;
            product3.Price = 0m;
            Console.ReadLine();

            Console.WriteLine(String.Format("{0}: {1:c} + {2:c}", product1.Name, product1.Price, product1.CalculateTax()));
            Console.WriteLine(String.Format("{0}: {1:c} + {2:c}", product2.Name, product2.Price, product2.CalculateTax()));
            Console.WriteLine(String.Format("{0}: {1:c} + {2:c}", product3.Name, product3.Price, product3.CalculateTax()));
            Console.ReadLine();

            Console.WriteLine(String.Format("{0}: {1:c} / {2:c}", product1.Name, product1.Price, product1.CalculateTotal(.08m, .5m)));
            Console.ReadLine();

            Console.WriteLine(String.Format("{0}: {1:c} / {2:c}", product1.Name, product1.Price, product1.CalculateTotal(.08m, .5m)));
            Console.ReadLine();
        }
    }
}
