using System;

class Program
{
    static void Main()
    {

        string name, job, married;
        int birthyear, birthmonth, birthday, birthyeardate, birthmonthdate, birthdaydate;
        float Height, hieghtinfeet;
        while (true)
        {
            Console.WriteLine("Please Enter your Name :");
            name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name))
            {
                break;
            }
            Console.WriteLine("** Name Cannot Be Empty **");
        }

        while (true)
        {
            Console.WriteLine("please Enter Your BirthYear :");
            if (int.TryParse(Console.ReadLine(), out birthyear))
            {
                break;
            }
            Console.WriteLine("** BirthYear Cannot Be Empty Or String **");
        }

        while (true)
        {
            Console.WriteLine("please Enter Your BirthMonth :");
            if (int.TryParse(Console.ReadLine(), out birthmonth))
            {
                break;
            }
            Console.WriteLine("** BirthMonth Cannot Be Empty Or String **");
        }
        while (true)
        {
            Console.WriteLine("please Enter Your Birth Day :");
            if (int.TryParse(Console.ReadLine(), out birthday))
            {
                break;
            }
            Console.WriteLine("** BirthDay Cannot Be Empty Or String **");
        }
        while (true)
        {
            Console.WriteLine("please Enter Your Job :");
            job = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(job))
            {
                break;
            }
            Console.WriteLine("** Job Cannot Be Empty **");
        }
        while (true)
        {
            Console.WriteLine("please Enter Your Hieght in CM");
            if (float.TryParse(Console.ReadLine(), out Height))
            {
                break;
            }
            Console.WriteLine("** Hieght Cannot Be Empty Or String **");
        }
        while (true)
        {
            Console.WriteLine("Are You Married (y-yes n-no)");
            married = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(married))
            {
                break;
            }
            Console.WriteLine("** Married Cannot Be Empty **");
        }


        birthyeardate = (DateTime.Now.Year - birthyear);
        birthmonthdate = (DateTime.Now.Month - birthmonth);
        birthdaydate = (DateTime.Now.Day - birthday);

        if (birthdaydate < 0)
        {
            birthdaydate = (birthdaydate + 12);
            birthmonthdate = (birthmonthdate - 1);
        }
        if (birthmonthdate < 0)
        {
            birthmonthdate = (birthmonthdate + 12);
            birthyeardate = (birthyeardate - 1);
        }
        hieghtinfeet = (Height / (float)30.48f);

        Console.WriteLine("\n************** Your Information Is *************");
        Console.WriteLine("Name : {0}", name);
        Console.WriteLine("Age : {0}\\{1}\\{2}", birthyeardate, birthmonthdate, birthdaydate);
        Console.WriteLine("Height : {0} CM \\ {1} FT ", Height, hieghtinfeet);
        Console.WriteLine("Job : {0}", job);
        Console.WriteLine("Married : {0}", married == "y" ? "yes" : "no");
        Console.WriteLine("*************************************************");

        Console.ReadKey(true);
    }
}
