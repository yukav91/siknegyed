using System;

namespace test1
{
    class Class1
    {
        [STAThread]
        public static void Main(string[] args)
        {
            int x, y;
            Console.Write("Melyik síknegyedben van a pont?\nKérlek, add meg a pont koordinátáit\nx: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            y = Convert.ToInt32(Console.ReadLine());
            if ((x == 0) && (y == 0))
            {
                Console.WriteLine("Az origón helyezkedik el");
            }
            else if ((x == 0) || (y == 0))
            {
                if (x == 0) Console.WriteLine("Az y tengelyen helyezkedik el");
                else Console.WriteLine("Az x tengelyen helyezkedik el");
            }
            else if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Első síknegyedben van");
                }
                else Console.WriteLine("Második síknegyedben van");
            }
            else if (y < 0)
            {
                Console.WriteLine("Harmadik síknegyedben van");
            }
            else Console.WriteLine("Negyedik síknegyedben van");
        }
    }
}
