using System;
class Program
{
    static void Main()
    {
        string name, job, married, spouseName = "";
        int birthYear, birthMonth, birthDay;
        float height, heightInFeet, weight, weightLbs;

        name = ReadString("Please Enter your Name:");
        birthYear = ReadInt("Please Enter Your Birth Year:");
        birthMonth = ReadInt("Please Enter Your Birth Month (1-12):", 1, 12);
        birthDay = ReadInt("Please Enter Your Birth Day (1-31):", 1, 31);
        job = ReadString("Please Enter Your Job:");
        height = ReadFloat("Please Enter Your Height in CM:");
        weight = ReadFloat("Please Enter Your Weight in KG:");
        married = ReadString("Are You Married? (y-yes, n-no):").ToLower();
        if (married == "y" || married == "yes")
        {
            spouseName = ReadString("Enter Your Spouse Name:");
        }

        // Calculate age using DateTime
        DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
        DateTime today = DateTime.Today;
        int ageYears = today.Year - birthDate.Year;
        int ageMonths = today.Month - birthDate.Month;
        int ageDays = today.Day - birthDate.Day;

        if (ageDays < 0)
        {
            ageMonths--;
            ageDays += DateTime.DaysInMonth(today.Year, today.Month - 1);
        }
        if (ageMonths < 0)
        {
            ageYears--;
            ageMonths += 12;
        }

        // Convert height to feet and weight to pounds
        heightInFeet = height / 30.48f;
        weightLbs = weight * 2.20462262185f;


        // Display information
        Console.WriteLine("\n************** Your Information *************");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {ageYears} Years, {ageMonths} Months, {ageDays} Days");
        Console.WriteLine($"Height: {height} CM / {heightInFeet:F2} FT");
        Console.WriteLine($"Weight: {weight} KG / {weightLbs:F2} LB");
        Console.WriteLine($"Job: {job}");
        Console.WriteLine($"Married: {(married == "y" || married == "yes" ? "Yes, " + spouseName : "No")}");
        Console.WriteLine("*********************************************");


        Console.ReadKey(true);
    }
    // Helper Methods
    static string ReadString(string message)
    {
        string input;
        while (true)
        {
            Console.WriteLine(message);
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                return input;
            Console.WriteLine("** Input Cannot Be Empty **");
        }
    }

    static int ReadInt(string message, int min = int.MinValue, int max = int.MaxValue)
    {
        int value;
        while (true)
        {
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                return value;
            Console.WriteLine($"** Enter a valid number between **");
        }
    }

    static float ReadFloat(string message)
    {
        float value;
        while (true)
        {
            Console.WriteLine(message);
            if (float.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("** Input must be a valid number **");
        }
    }

}
