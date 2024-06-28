using System;

class UnitConverter {
    static void Main() {
        Console.WriteLine("Welcome to the Unit Converter!");

        int choice = 0;
        //continue to prompt user for input 
        while(choice != 6) {
            Console.WriteLine("Choose a number from the menu below:");
            //Console.WriteLine();
        
            //the options
            Console.WriteLine("1: Meters to feet");
            Console.WriteLine("2: Kilograms to Pounds");
            Console.WriteLine("3: Inches to centimeters");
            Console.WriteLine("4: Celsius to Fahrenheit");
            Console.WriteLine("5: Gallons to Liters");
            Console.WriteLine("6: Quit");
            Console.WriteLine();
        

            // user input (convert from string to int)
            if (!int.TryParse(Console.ReadLine(), out choice)) {
                Console.WriteLine("Error: Please enter a valid integer choice.");
                Console.WriteLine();
                continue; // restart the loop if input is not a valid integer
            }
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
            else if(choice == 6) {
                Console.WriteLine("Program ended. Have a blessed day!");
            }
            else {
                Console.WriteLine("Error. Choice not within the menu");
                Console.WriteLine();
            }
        }
    }

    //meters to feet
    static void MetersToFeet() {
        double meters;
        while (true) {
            Console.Write("Enter the number of meters: ");
            if (!double.TryParse(Console.ReadLine(), out meters)) {
                Console.WriteLine("Error: Invalid input. Please enter a number.");
                Console.WriteLine();
                continue;
            }
            if (meters <= 0) {
                Console.WriteLine("Error: Meters must be a positive number.");
                Console.WriteLine();
                continue;
            }
            break; // Exit the loop if input is valid
        }

        double feet = meters * 3.28084;
        Console.WriteLine();
        Console.WriteLine($"{meters} meters is {feet} feet.");
        Console.WriteLine();
    }

    // kilograms to pounds
    static void KilogramsToPounds() {
        double kilograms;
        while (true) {
            Console.Write("Enter the number of kilograms: ");
            if (!double.TryParse(Console.ReadLine(), out kilograms)) {
                Console.WriteLine("Error: Invalid input. Please enter a number.");
                Console.WriteLine();
                continue;
            }
            if (kilograms <= 0) {
                Console.WriteLine("Error: Kilograms must be a positive number.");
                Console.WriteLine();
                continue;
            }
            break; // Exit the loop if input is valid
        }

        double pounds = kilograms * 2.20462;
        Console.WriteLine();
        Console.WriteLine($"{kilograms} kilograms is {pounds} pounds.");
        Console.WriteLine();
    }

    // inches to centimeters
    static void InchesToCentimeters() {
        double inches;
        while (true) {
            Console.Write("Enter the number of inches: ");
            if (!double.TryParse(Console.ReadLine(), out inches)) {
                Console.WriteLine("Error: Invalid input. Please enter a number.");
                Console.WriteLine();
                continue;
            }
            if (inches <= 0) {
                Console.WriteLine("Error: Inches must be a positive number.");
                Console.WriteLine();
                continue;
            }
            break; // Exit the loop if input is valid
        }

        double centimeters = inches * 2.54;
        Console.WriteLine();
        Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
        Console.WriteLine();
    }

    // celsius to fahrenheit
    static void CelsiusToFahrenheit() {
        double celsius;
        while (true) {
            Console.Write("Enter the degrees in Celsius: ");
            if (!double.TryParse(Console.ReadLine(), out celsius)) {
                Console.WriteLine("Error: Invalid input. Please enter a number.");
                Console.WriteLine();
                continue;
            }
            // No negative temperature validation as Celsius can be negative
            break; // Exit the loop if input is valid
        }

        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine();
        Console.WriteLine($"{celsius} degrees Celsius is {fahrenheit} degrees Fahrenheit.");
        Console.WriteLine();
    }

    // gallons to liters
    static void GallonsToLiters() {
        double gallons;
        while (true) {
            Console.Write("Enter the number of gallons: ");
            if (!double.TryParse(Console.ReadLine(), out gallons)) {
                Console.WriteLine("Error: Invalid input. Please enter a number.");
                Console.WriteLine();
                continue;
            }
            if (gallons <= 0) {
                Console.WriteLine("Error: Gallons must be a positive number.");
                Console.WriteLine();
                continue;
            }
            break; // Exit the loop if input is valid
        }

        double liters = gallons * 3.78541;
        Console.WriteLine();
        Console.WriteLine($"{gallons} gallons is {liters} liters.");
        Console.WriteLine();
    }
}