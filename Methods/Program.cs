namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            try
            {
                var num = int.Parse("abc");
            }
            catch (System.Exception)
            {

                System.Console.WriteLine("Conversion failed");
            }


            var result = int.TryParse("abc", out number);

            if (result)
                System.Console.WriteLine(number);

            else
                System.Console.WriteLine("Conversion failed");
                
        }

        static void UseParams()
        {

            var calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(1,2));
            System.Console.WriteLine(calculator.Add(1,2,3,4,5));
            System.Console.WriteLine(calculator.Add(1,2,3,4,5,6,7,8,9,10));
            System.Console.WriteLine(calculator.Add(new int []{1,2,3,4,5,6,7,8}));
            
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);


                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            }
            catch (System.Exception)
            {

                System.Console.WriteLine("UNEXPECTED ERROR");
            }
        }
    }
}
