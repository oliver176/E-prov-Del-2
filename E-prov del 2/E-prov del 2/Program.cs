using System;
using System.Collections.Generic;

namespace E_prov_del_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Car> carList = new List<Car>(); //skapa en lista med bilar

            Console.WriteLine("Hur många bilar ska skapas?");

            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int amountOfCars); //parse en string ut med en int.

            while (!success) // tvinga en int
            {
                if (!success)
                {
                    Console.WriteLine("Write a number!");
                }
                else if (amountOfCars <= 0) //du kommer inte ur loopen om talet inte är högre än 0
                {
                    success = false;
                    Console.WriteLine("Write a number higher than 0!");
                }
                input = Console.ReadLine();
                success = int.TryParse(input, out amountOfCars);
            }
            for (int i = 0; i < amountOfCars; i++)
            {
                int chance;
                chance = Car.generator.Next(1, 3); //slumpa vilken bil som skapas

                if (chance == 1)
                {
                    carList.Add(new CleanCar());
                }
                else if (chance == 2)
                {
                    carList.Add(new ContrabandCar());
                }
            }

            Console.WriteLine("Vilken bil vill du titta på?");

            input = Console.ReadLine();
            success = int.TryParse(input, out int carToInspect); //parse en string ut med en int.
            while (!success) // tvinga en int
            {
                if (!success)
                {
                    Console.WriteLine("Write a number!");
                    if (carToInspect > carList.Count || carToInspect <= 0)
                    {
                        Console.WriteLine("Write a number between 1 and " + carList.Count);
                    }
                    success = false;
                }
                
                input = Console.ReadLine();
                success = int.TryParse(input, out carToInspect);
            }
            if (success) // om input är en int. Dock så kraschar det om input inte ligger inom index för carList
            {
                if (carList[carToInspect].alreadyChecked) //kolla om bilen har blivit examined redan
                {
                    Console.WriteLine("The car has already been examined");
                }
                else if (carList[carToInspect].Examine()) //om sökningen är lyckad
                {
                    Console.WriteLine("You found contraband!");
                }
                else Console.WriteLine("You found nothing!");
            }

            Console.ReadLine();
        }
    }
}