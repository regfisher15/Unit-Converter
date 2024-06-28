using System;

class UnitConverter {
    static void Main() {
        Console.WriteLine("Welcome to the Unit Converter!");
        Console.WriteLine("Choose a number from the menu below:");

        //blank line
        Console.WriteLine();

        //the options
        Console.WriteLine("1: Meters to feet");
        Console.WriteLine("2: Kilograms to Pounds");
        Console.WriteLine("3: Inches to centimeters");
        Console.WriteLine("4: Celsius to Fahrenheit");
        Console.WriteLine("5: Gallons to Liters");
        Console.WriteLine();

        //user input (also convert from string to int)
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if(choice == 1) {
            MetersToFeet();
        }
        else if(choice == 2) {
            KilogramsToPounds();
        }
        else if(choice == 3) {
            InchesToCentimeters();
        }
        else if(choice == 4) {
            CelsiusToFahrenheit();
        }
        else if(choice == 5) {
            GallonsToLiters();
        }
    }

    //meters to feet
    static void MetersToFeet() {
        Console.WriteLine("Enter the number of miles:");
        double meters = double.Parse(Console.ReadLine());
        double feet = meters * 3.28084;
        Console.WriteLine();
        Console.WriteLine($"{meters} meters is {feet} feet.");
    }

    //kilograms to pounds
    static void KilogramsToPounds() {
        Console.WriteLine("Enter the number of kilograms:");
        double kilograms = double.Parse(Console.ReadLine());
        double pounds = kilograms * 2.20462;
        Console.WriteLine();
        Console.WriteLine($"{kilograms} kilograms is {pounds} pounds.");
    }

    //inches to centimeters
    static void InchesToCentimeters() {
        Console.WriteLine("Enter the number of inches:");
        double inches = double.Parse(Console.ReadLine());
        double centimeters = inches * 2.54;
        Console.WriteLine();
        Console.WriteLine($"{inches} inches is {centimeters} centiimeters.");
    }

    //celsius to fahrenheit
    static void CelsiusToFahrenheit() {
        Console.WriteLine("Enter the degrees in Celsius:");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine();
        Console.WriteLine($"{celsius} degrees celsius is {fahrenheit} degrees fahrenheit.");
    }

    //gallons to liters
    static void GallonsToLiters() {
        Console.WriteLine("Enter the number of gallons:");
        double gallons = double.Parse(Console.ReadLine());
        double liters = gallons * 3.78541;
        Console.WriteLine();
        Console.WriteLine($"{gallons} gallons is {liters} liters.");
    }
}