namespace vse {
    class programm
    {
        static void Main(string[] args)
        {
            int nomer;
            do {
                Console.WriteLine("1 угадай число");
                Console.WriteLine("2 таблица умножения");
                Console.WriteLine("3 вывод делителей числа");
                Console.WriteLine("4 выйти из программы");
                nomer = Convert.ToInt32(Console.ReadLine());
                if (nomer == 1) {
                    ugaday(args);
                }
                if (nomer == 2)
                {
                    tablica(args);
                }
                if(nomer == 3)
                {
                    deliteli(args);
                }
            }while (nomer < 4);
        }
        
        static void ugaday(object[] args)
        {
            int j;
            Random rnd = new Random();
            j = rnd.Next(101);
            int f;
            Console.WriteLine("Я загадал число от 0 до 100");
            do
            {
                f = Convert.ToInt32(Console.ReadLine());
                if (f>j)
                {
                    Console.WriteLine("моё число меньше");
                }
                if (f<j)
                {
                    Console.WriteLine("моё число больше");
                }
            } while (j != f);

        }

        static void tablica(object[] args)
        {
            int[,] tabl = new int[10 , 10]; 
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    tabl[j, i] = i*j;
                }
                
            }
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("{0,3}" ,tabl[i,j]);
                }
                Console.WriteLine();
            }

        }

        static void deliteli(object[] args)
        {
            int a;
            int lo;
            Console.WriteLine("введите число");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < a+1; i++)
            {
                lo = a % i;
                if (lo == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}