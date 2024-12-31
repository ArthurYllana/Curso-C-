namespace Nullable{
    class Program{
        static void Main(string[] args){
            /*
            Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            System.Console.WriteLine(x.GetValueOrDefault());
            System.Console.WriteLine(y.GetValueOrDefault());

            System.Console.WriteLine(x.HasValue);
            System.Console.WriteLine(y.HasValue);

            if (x.HasValue){
                System.Console.WriteLine(x.Value);
            }
            else{
                System.Console.WriteLine("x is null");
            }

            if (y.HasValue){
                System.Console.WriteLine(y.Value);
            }
            else{
                System.Console.WriteLine("Y is null");
            }
            */

            double? x = null;
            double? y = 10.0;

            double a = x?? 5;
            double b = y?? 5;

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
        }
    }
}
