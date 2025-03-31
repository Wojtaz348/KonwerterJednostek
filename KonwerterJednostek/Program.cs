using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Wybierz jednostkę do konwersji:");
            Console.WriteLine("1. Mile na Kilometry");
            Console.WriteLine("2. Kilometry na Mile");
            Console.WriteLine("3. Celsjusz na Fahrenheit");
            Console.WriteLine("4. Fahrenheit na Celsjusz");
            Console.WriteLine("5. Gramy na Kilogramy");
            Console.WriteLine("6. Kilogramy na Gramy");
            Console.WriteLine("0. Zakończ");
            Console.Write("\nWybierz opcję (0-6): ");


            string wybor = Console.ReadLine();


            if (wybor == "0")
            {
                break;
            }

            double liczba;
            double wynik;

            switch (wybor)
            {
                case "1":
                    Console.Write("\nPodaj wartość w milach: ");
                    if (double.TryParse(Console.ReadLine(), out liczba))
                    {
                        wynik = MileNaKilometry(liczba);
                        Console.WriteLine($"{liczba} mil to {wynik} kilometrów.");
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna wartość!");
                    }
                    break;

                case "2":
                    Console.Write("\nPodaj wartość w kilometrach: ");
                    if (double.TryParse(Console.ReadLine(), out liczba))
                    {
                        wynik = KilometryNaMile(liczba);
                        Console.WriteLine($"{liczba} kilometrów to {wynik} mil.");
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna wartość!");
                    }
                    break;

                case "3":
                    Console.Write("\nPodaj wartość w Celsjuszach: ");
                    if (double.TryParse(Console.ReadLine(), out liczba))
                    {
                        wynik = CelsjuszNaFahrenheit(liczba);
                        Console.WriteLine($"{liczba}°C to {wynik}°F.");
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna wartość!");
                    }
                    break;

                case "4":
                    Console.Write("\nPodaj wartość w Fahrenheitach: ");
                    if (double.TryParse(Console.ReadLine(), out liczba))
                    {
                        wynik = FahrenheitNaCelsjusz(liczba);
                        Console.WriteLine($"{liczba}°F to {wynik}°C.");
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna wartość!");
                    }
                    break;

                case "5":
                    Console.Write("\nPodaj wartość w gramach: ");
                    if (double.TryParse(Console.ReadLine(), out liczba))
                    {
                        wynik = GramyNaKilogramy(liczba);
                        Console.WriteLine($"{liczba} gramów to {wynik} kilogramów.");
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna wartość!");
                    }
                    break;

                case "6":
                    Console.Write("\nPodaj wartość w kilogramach: ");
                    if (double.TryParse(Console.ReadLine(), out liczba))
                    {
                        wynik = KilogramyNaGramy(liczba);
                        Console.WriteLine($"{liczba} kilogramów to {wynik} gramów.");
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna wartość!");
                    }
                    break;

                default:
                    Console.WriteLine("\nNiepoprawna opcja, spróbuj ponownie.");
                    break;
            }


            Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();
        }
    }

    private static double FahrenheitNaCelsjusz(double liczba)
    {
        return (liczba - 32) * 5 / 9;
    }

    private static double GramyNaKilogramy(double liczba)
    {
        return liczba / 1000;
    }

    private static double KilogramyNaGramy(double liczba)
    {
        return liczba * 1000;
    }

    private static double CelsjuszNaFahrenheit(double liczba)
    {
        return (liczba * 9 / 5) + 32;
    }


    static double MileNaKilometry(double mile)
    {
        return mile * 1.60934;
    }


    static double KilometryNaMile(double kilometry)
    {
        return kilometry / 1.60934;
    }
}

