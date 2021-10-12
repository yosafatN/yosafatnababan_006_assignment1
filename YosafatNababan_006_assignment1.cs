using System;

public class main
{
    public static void Main()
    {
        string menu;
        bool isExit = false;

        do
        {
            Console.Clear();
            Console.WriteLine(" Nama          : Yosafat Nababan");
            Console.WriteLine(" Nomor Peserta : FSDO001ONL006");
            Console.WriteLine(" Alamat        : Surabaya");

            Console.WriteLine("\n ============== Menu ==============");
            Console.WriteLine(" [1] Segitiga Alfabet (Soal 1)");
            Console.WriteLine(" [2] Segitiga Angka (Soal 2)");
            Console.WriteLine(" [3] Faktorial (Soal 3)");
            Console.WriteLine(" [4] Balik Angka (Soal 4)");
            Console.WriteLine(" [5] Convert Angka (Soal 5)");
            Console.WriteLine(" [6] Cek Palindrome (Soal tambahan)");
            Console.WriteLine(" [7] Tentang Saya");
            Console.WriteLine(" [0] Keluar");
            Console.Write(" => ");
            menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    menu1();
                    break;
                case "2":
                    menu2();
                    break;
                case "3":
                    menu3();
                    break;
                case "4":
                    menu4();
                    break;
                case "5":
                    menu5();
                    break;
                case "6":
                    menu6();
                    break;
                case "7":
                    menuAboutMe();
                    break;
                case "0":
                    isExit = true;
                    break;
                default:
                    Console.Write("\n Pilihan tidak tersedia!");
                    Console.ReadLine();
                    break;
            }
        } while (!isExit);
    }

    static bool isNumber(string number)
    {
        int x;
        return !int.TryParse(number, out x);
    }
    static void menu1()
    {
        int range;
        string temp;
        bool isValid = true;

        string[] abc = {
            "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
        };

        do
        {
            Console.Clear();
            Console.WriteLine("\n =========== Segitiga Alfabet ===========");
            Console.WriteLine(" Enter the range [1 ~ 26]");
            Console.Write(" => ");
            temp = Console.ReadLine();

            if (isNumber(temp))
            {
                isValid = false;
                Console.WriteLine("\n Please enter numbers only");
                Console.ReadLine();
            }
            else if (int.Parse(temp) < 1 || int.Parse(temp) > 26)
            {
                isValid = false;
                Console.WriteLine("\n The range of numbers is 1 to 26");
                Console.ReadLine();
            }
            else
            {
                isValid = true;
            }
        } while (!isValid);

        range = int.Parse(temp);
        Console.Write("\n");

        for (int i = 1; i <= range; i++)
        {
            for (int j = 1; j <= range - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write(abc[k - 1]);
            }
            for (int l = i - 1; l >= 1; l--)
            {
                Console.Write(abc[l - 1]);
            }
            Console.Write("\n");
        }
        Console.ReadLine();
    }

    static void menu2()
    {
        int range;
        string temp;
        bool isValid = true;

        do
        {
            Console.Clear();
            Console.WriteLine("\n =========== Segitiga Angka ===========");
            Console.WriteLine(" Enter the range [1 ~ 9]");
            Console.Write(" => ");
            temp = Console.ReadLine();

            if (isNumber(temp))
            {
                isValid = false;
                Console.WriteLine("\n Please enter numbers only");
                Console.ReadLine();
            }
            else if (int.Parse(temp) < 1 || int.Parse(temp) > 9)
            {
                isValid = false;
                Console.WriteLine("\n The range of numbers is 1 to 9");
                Console.ReadLine();
            }
            else
            {
                isValid = true;
            }
        } while (!isValid);

        range = int.Parse(temp);
        Console.Write("\n");

        for (int i = 1; i <= range; i++)
        {
            for (int j = 1; j <= range - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write(k);
            }
            for (int l = i - 1; l >= 1; l--)
            {
                Console.Write(l);
            }
            Console.Write("\n");
        }
        Console.ReadLine();
    }

    static void menu3()
    {
        int number;
        int factorial = 1;
        string temp;
        bool isValid = true;

        do
        {
            Console.Clear();
            Console.WriteLine("\n =========== Faktorial ===========");
            Console.WriteLine(" Enter any Number");
            Console.Write(" => ");
            temp = Console.ReadLine();

            if (isNumber(temp))
            {
                isValid = false;
                Console.WriteLine("\n Please enter numbers only");
                Console.ReadLine();
            }
            else
            {
                isValid = true;
            }
        } while (!isValid);

        number = int.Parse(temp);
        Console.Write("\n");

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.Write($" Factorial of {number} is: {factorial}");
        Console.ReadLine();
    }

    static void menu4()
    {
        string before;
        string after = "";

        Console.Clear();
        Console.WriteLine("\n =========== Balik Angka ===========");
        Console.WriteLine(" Enter any Word and Numbers");
        Console.Write(" => ");
        before = Console.ReadLine();
        Console.Write("\n");

        for (int i = before.Length - 1; i > -1; i--)
        {
            after += before[i];
        }

        Console.Write($" Reversed Word and Numbers: {after}");
        Console.ReadLine();
    }

    static void menu5()
    {
        string number;
        string[] stringNumber = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string result;
        string temp;
        bool isValid = true;

        do
        {
            Console.Clear();
            Console.WriteLine("\n =========== Convert Angka ===========");
            Console.WriteLine(" Enter any Number");
            Console.Write(" => ");
            temp = Console.ReadLine();

            if (isNumber(temp))
            {
                isValid = false;
                Console.WriteLine("\n Please enter numbers only");
                Console.ReadLine();
            }
            else
            {
                isValid = true;
            }
        } while (!isValid);
        number = temp;

        for (int i = 0; i < number.Length; i++)
        {
            result = stringNumber[Convert.ToInt32(Char.GetNumericValue(number[i]))];
            Console.Write($" {result}");
        }
        Console.ReadLine();
    }

    static void menu6()
    {
        string word = "";
        bool result = true;
        int wordLength;

        Console.Clear();
        Console.WriteLine("\n =========== Cek Palindrome ===========");
        Console.WriteLine(" Enter any Word to check if the word is palindrome");
        Console.Write(" => ");
        word = Console.ReadLine();

        wordLength = word.Length;

        for (int i = 0; i < wordLength / 2; i++)
        {
            if (char.ToUpperInvariant(word[i]) != char.ToUpperInvariant(word[wordLength - i - 1]))
            {
                result = false;
            }
        }

        Console.WriteLine($"\n Is the word '{word}' a palindrome?");
        Console.WriteLine($" => {result.ToString().ToUpper()}");
        Console.ReadLine();
    }

    static void menuAboutMe()
    {
        Console.Clear();
        Console.WriteLine(" ========================= Tentang Saya =========================");
        Console.WriteLine(" Nama            : Yosafat Nababan");
        Console.WriteLine(" Nomor Peserta   : FSDO001ONL006");
        Console.WriteLine(" Alamat Sekarang : Surabaya");
        Console.WriteLine(" Asal            : Lahat, Sumatera Selatan");
        Console.WriteLine(" \n====================== Riwayat Pendidikan ======================");
        Console.WriteLine(" SMA             : Xaverius 1 Palembang");
        Console.WriteLine(" Kuliah          : Universitas Atma Jaya Yogyakarta (Informatika)");
        Console.ReadLine();
    }
}