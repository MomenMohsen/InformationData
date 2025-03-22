using System;
class Program
{
    static void Main()
    {
        string name, job, married, worhname = "";
        int birthyear, birthmonth, birthday, birthyeardate, birthmonthdate, birthdaydate;
        float Height, hieghtinfeet, weight, weightlbs;
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
            Console.WriteLine("please Enter Your Weight in KG");
            if (float.TryParse(Console.ReadLine(), out weight))
            {
                break;
            }
            Console.WriteLine("** Weight Cannot Be Empty Or String **");
        }
        while (true)
        {
            Console.WriteLine("Are You Married (y-yes n-no)");
            married = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(married))
            {
                break;
            }
            else
            {
                Console.WriteLine("** Married Cannot Be Empty **");
            }
        }
        while (married == "y" || married == "yes")
        {
            Console.WriteLine("Enter Your Wife/Husband name");
            worhname = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(worhname))
            {
                break;
            }
            Console.WriteLine("** Wife/Husband Cannot Be Empty **");


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
        weightlbs = (weight * (float)2.20462262185f);

        Console.WriteLine("\n************** Your Information Is *************");
        Console.WriteLine("Name : {0}", name);
        Console.WriteLine("Age : {0}\\{1}\\{2}", birthyeardate, birthmonthdate, birthdaydate);
        Console.WriteLine("Height : {0} CM \\ {1} FT ", Height, hieghtinfeet);
        Console.WriteLine("Weight : {0} KG \\ {1} LB", weight, weightlbs);
        Console.WriteLine("Job : {0}", job);
        if (married == "y" || married == "yes")
        {
            Console.WriteLine("Married : Yes {0}", worhname);
        }
        else
        {
            Console.WriteLine("Married : No ");
        }

        Console.WriteLine("*************************************************");

        Console.ReadKey(true);
    }
}
