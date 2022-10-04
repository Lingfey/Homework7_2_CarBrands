using System;
using System.Text.RegularExpressions;

namespace Homework7_2_CarBrands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] carOwners = new string[3, 4];
            string fullName, carBrand, plateNumber, releaseYear;
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + 1 + ". ");
                do
                {
                    Console.WriteLine("Enter the car owner's full name (E.g.:" +
                        "John Doe).");
                    fullName = Console.ReadLine();
                    if (!Regex.IsMatch(fullName, @"^[A-Z][a-z]+ [A-Z][a-z]+$"))
                    {
                        Console.WriteLine("Wrong name format");
                    }
                }
                while (!Regex.IsMatch(fullName, @"^[A-Z][a-z]+ [A-Z][a-z]+$"));
                carOwners[i, 0] = fullName;
                do
                {
                    Console.WriteLine("Enter the car brand.");
                    carBrand = Console.ReadLine();
                    if (!Regex.IsMatch(carBrand, @"^[A-Z][a-z]+$"))
                    {
                        Console.WriteLine("Wrong brand format");
                    }
                }
                while (!Regex.IsMatch(carBrand, @"^[A-Z][a-z]+$"));
                carOwners[i, 1] = carBrand;
                do
                {
                    Console.WriteLine("Enter the plate number (E.g.: AA 0000 AA)");
                    plateNumber = Console.ReadLine();
                    if (!Regex.IsMatch(plateNumber, @"^[A-Z]+ \d+ [A-Z]+$"))
                    {
                        Console.WriteLine("Wrong plate format");
                    }
                }
                while (!Regex.IsMatch(plateNumber, @"^[A-Z]{2} \d{4} [A-Z]{2}$"));
                carOwners[i, 2] = plateNumber;
                do
                {
                    Console.WriteLine("Enter the release year");
                    releaseYear = Console.ReadLine();
                    if (!Regex.IsMatch(releaseYear, @"^[1-2]\d{3}$") || Convert.ToInt32(releaseYear) < 1930 ||
                        Convert.ToInt32(releaseYear) > 2022)
                    {
                        Console.WriteLine("Wrong date format");
                    }
                }
                while (!Regex.IsMatch(releaseYear, @"^[1-2]\d{3}$") || Convert.ToInt32(releaseYear) < 1932 ||
                Convert.ToInt32(releaseYear) > 2022);
                carOwners[i, 3] = releaseYear;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + 1 + ". ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t\t", carOwners[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}