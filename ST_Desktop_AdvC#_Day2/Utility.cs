using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Desktop_AdvC__Day2
{
    internal class Utility
    {

        public static double GetDiscount(List<Product> products, Func<double,double> getDiscountPercentage)
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.Price;
            }

            double discountPercentage= getDiscountPercentage(totalPrice);

            double discount = totalPrice * discountPercentage / 100;

            return discount;

        }

        public static double GetDiscountPercentage(double totalPrice)
        {
            double discountPercentage = 0;
            if (totalPrice < 2000)
            {
                Console.WriteLine("discount 10%");
                discountPercentage = 10;
            }
            else if (totalPrice < 8000)
            {
                Console.WriteLine("discount 25%");
                discountPercentage = 25;
            }
            else if (totalPrice < 10000)
            {
                Console.WriteLine("discount 50%");
                discountPercentage = 50;
            }

            return discountPercentage;
        }
    }
}
