namespace ST_Desktop_AdvC__Day2
{

    public delegate bool FilterDel<DT>(DT param);

    public delegate Dt GenricDel<Dt>(Dt param);
    public delegate Dt2 GenricDel<Dt1, Dt2>(Dt1 param);

    public delegate Dt2 GenricDel2<Dt1, Dt2>(Dt1 param, Dt2 parem);

    public delegate Dt2 GenricDel3<in Dt1, out Dt2>(Dt1 param, Dt1 parem);
    internal class Program
    {
        static void Main(string[] args)
        {
            //FilterDel<int> delInt = (input) => input > 10;

            //FilterDel<string> delString = (input) => input.StartsWith('a');

            //GenricDel3<double, int> math = (num1, num2) => (int)(num1 + num2);

            //Console.WriteLine(math(2.3, 5.3));


            //isPositive(3);

            //isNegative(-2);


            //FilterDel<int> del1 = isPositive;

            //del1(5);

            //del1 = isNegative;

            //del1(-30);


            //del1 = isNegative;
            //del1 += isPositive;

            //Console.WriteLine("Multicast");
            //var result = del1(4);
            //Console.WriteLine(result);


            //del1 -= isPositive;
            //del1 -= isNegative;
            //Console.WriteLine("Multicast");
            //result = del1(4);
            //Console.WriteLine(result);


            //// Built in delegates

            //// Predict
            //// With one generic input and bool return type
            //Predicate<int> predicate = isPositive;

            //Predicate<string> predicateString = StartsWithA;

            ////Action
            //// one upto 16 input
            //// void return type
            //Action<string> action = (str) => Console.WriteLine(str);
            //Action<string, int> actionString = (str, num) => Console.WriteLine(str + num);

            //var action6 = (string str) => Console.WriteLine(str);


            ////Func

            //Func<int, int> func1 = (x) => x++;

            //Func<string, string, int> func2 = (str1, str2) =>
            //{
            //    int result = str1.Length + str2.Length;
            //    return result;
            //};




            List<Product> products = new List<Product>()
            {
                new Product(){Id=1,Name="car",Price=100},
                new Product(){Id=2,Name="phone",Price=500},
                new Product(){Id=3,Name="pen",Price=100}
            };
            double discount = Utility.GetDiscount(products,Utility.GetDiscountPercentage);

            Console.WriteLine(discount);

            discount = Utility.GetDiscount(products, (price) =>
            {
                if(price < 500)
                {
                    Console.WriteLine("no discount");
                    return 0;
                }else if(price < 1000)
                {
                    Console.WriteLine("discount 5%");
                    return 5;
                }else if(price < 5000)
                {
                    Console.WriteLine("discount 20%");
                    return 20;
                }
                else
                {
                    return 70;
                }

            });
        }

        static bool isPositive(int num)
        {
            Console.WriteLine("isPositive");
            return num > 0;
        }
        static bool isNegative(int num)
        {
            Console.WriteLine("isNegative");
            return num < 0;
        }

        static bool StartsWithA(string str)
        {
            Console.WriteLine("StartsWithA");
            return str.StartsWith("A");
        }
    }
}