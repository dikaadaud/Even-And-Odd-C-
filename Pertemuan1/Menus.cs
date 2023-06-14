namespace Pertemuan1
{
    public static class Menus
    {
        public static void mainMenus()
        {
            Console.WriteLine("====================");
            Console.WriteLine("Menu Ganjil Genap");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Cek Ganjil Genap\n2. Print Ganjil/Genap (Dengan Limit)\n3. Exit");
            Console.Write("> ");
            int input = ValidateMenu();
            switch (input)
            {
                case 1:
                    Console.Clear();
                    Menu1();
                    Console.WriteLine();
                    Console.WriteLine();
                    mainMenus();
                    break;
                case 2:
                    Console.Clear();
                    Menu2();
                    Console.WriteLine();
                    Console.WriteLine();
                    mainMenus();
                    break;
                default:
                    Console.WriteLine("Terimakasih Sudah Menggunakan Applikasi ini");
                    Environment.Exit(0);
                    break;
            }
        }
        public static void Menu1()
        {
            Console.Write("Masukan Bilangan Yang Ingin di cek: ");
            PrintEvenOdd();

        }
        public static int ValidateMenu()
        {

            int choose;
            bool isValid = int.TryParse(Console.ReadLine(), out choose);
            if (!isValid || choose < 1 || choose > 3)
            {
                Console.Clear();
                Console.WriteLine("Harus Masukan Angka 1 - 3");
                mainMenus();

            }

            return choose;
        }
        public static int PrintEvenOdd()
        {
            int input;
            bool isValid = int.TryParse(Console.ReadLine(), out input);
            if (!isValid || input >= 1)
            {

                if (input % 2 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("> Genap");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("> Ganjil");
                }

            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.Write("> ");
                PrintEvenOdd();
            }

            return input;

        }
        public static void Menu2()
        {

            Console.WriteLine("Pilih Ganjil/Genap: ");
            Console.Write("> ");
            EvenOddValidation();
        }
        public static void EvenOddValidation()
        {
            string input = Console.ReadLine().ToLower();
            bool isEven = false;
            while (!isEven)
            {
                if (input == "ganjil")
                {
                    Ganjil();
                    isEven = true;
                }
                else if (input == "genap")
                {
                    Genap();
                    isEven = true;
                }
                else
                {
                    Console.WriteLine("Input pilihan tidak valid");
                    Console.Write("> ");
                    input = Console.ReadLine().ToLower();
                }
            }
        }
        public static void Ganjil()
        {
            Console.WriteLine("Masukan limit: ");
            Console.Write("> ");
            int ganjil = int.Parse(Console.ReadLine().ToLower());
            bool isEven = false;
            while (!isEven)
            {
                if (ganjil % 2 != 0 && ganjil > 0)
                {
                    Console.WriteLine();
                    for (int i = 1; i < ganjil; i += 2)
                    {
                        Console.WriteLine($"{i},");
                    }
                    isEven = true;
                }
                else
                {
                    Console.WriteLine("Input pilihan tidak valid");
                    Console.Write("Masukan limit: ");
                    ganjil = int.Parse(Console.ReadLine());
                }
            }

        }
        public static void Genap()
        {
            Console.WriteLine("Masukan limit: ");
            Console.Write("> ");
            int genap = int.Parse(Console.ReadLine().ToLower());
            bool isOdd = false;
            while (!isOdd)
            {
                Console.WriteLine();
                if (genap % 2 == 0 && genap > 0)
                {
                    for (int i = 2; i < genap; i += 2)
                    {
                        Console.WriteLine($"{i},");
                    }
                    isOdd = true;
                }
                else
                {
                    Console.WriteLine("Input pilihan tidak valid");
                    Console.Write("Masukan limit: ");
                    genap = int.Parse(Console.ReadLine());
                }
            }
        }

    }
}
