// See https://aka.ms/new-console-template for more information
using Batch1_DET_2022;

public class MyClass
{
    //  enum Grade { Pass = 60, Distinction = 85 };
    /// <summary>
    /// method that returns Grade based on the mark
    /// </summary>
    /// <param name="mark">mark as the input</param>
    /// <returns></returns>
    // public static string GetGrade(int mark) //IN parameter

    //{
    //    if (mark >= (int)Grade.Distinction)
    //        return "Distinction";
    //    else if (mark >= (int)Grade.Pass)
    //        return "PASS";
    //    else
    //        return "FAIL";
    //}
    // public static void Main()
    // {

    //{


    //    #region "inheritance"



    //    //        try
    //    //        {
    //    //            Emp m = new Manager(4671, "Karthika", new DateOnly(2005, 5, 10), "techtrng", 10);  //default constructor
    //    //                                                                                               // Console.WriteLine(m.Print());

    //    //            Emp m1 = new Manager(2345, "Jeeva", new DateOnly(2010, 1, 14), "PEMS", 450);
    //    //            // Console.WriteLine(m1.Print());  //base class ref can point to derived object

    //    //            Emp e1 = new Emp(1, "Jiyana", new DateOnly(2020, 1, 5));
    //    //            //Console.WriteLine(e1.Print());

    //    //            Console.WriteLine("enter empid b.w 1001 - 25000");
    //    //            int id = Convert.ToInt32(Console.ReadLine());
    //    //            if (id < 1001 || id > 25000)
    //    //                throw new InvalidEmpIdException("Entered empid is not in the range...");

    //    //            Console.WriteLine("enter emp name");
    //    //            string name = Console.ReadLine();

    //    //            Console.WriteLine("enter doj");
    //    //            DateOnly doj = DateOnly.Parse(Console.ReadLine());

    //    //            Emp e2 = new(id, name, doj);


    //    //            List<Emp> list = new List<Emp>();
    //    //            list.Add(m);
    //    //            list.Add(m1);
    //    //            list.Add(e1);
    //    //            foreach (Emp x in list)
    //    //                Console.WriteLine(x.Print());
    //    //        }
    //    //        catch (InvalidEmpIdException e)
    //    //        {
    //    //            Console.WriteLine(e.Message);
    //    //        }
    //    //        catch (Exception e)
    //    //        { }



    //    //}

    //    #endregion

    //    #region "containment"
    //    CompanyManager m = new CompanyManager { Name = "Balaji", Surname = "R", phone = "987654321" };
    //    CompanyDetails company = new CompanyDetails { Name = "SSL", Address = "Global City",Manager=m,phone="98764567",
    //    website="sonata-software.com"};

    //    Console.WriteLine(company.print());

    //    #endregion

    //public static void Main()
    //{
    //    List<Animal> sound = new List<Animal>();
    //    sound.Add(new Dog());
    //    sound.Add(new Cat());

    //    foreach (Animal a in sound)
    //        Console.WriteLine(a.MakeSounds());
    //}

    //        try
    //        {

    //            Console.WriteLine("enter age b.w 0-100");
    //            int age = Convert.ToInt32(Console.ReadLine());
    //            if (age > 100)
    //                throw new InvalidAgeException("Entered age is invalid...");


    //        }
    //        catch (InvalidAgeException e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }
    //        catch (Exception e)
    //        { }
    //    }
    //}

    public static Student Student { get; private set; }

    public static void Main()
    {
        ScienceStudent Student = new ScienceStudent { regno = 12, Name = "vinay" };
        ScienceStudent sciencesubject = new ScienceStudent { physics = 54, chemistry = 75, maths = 45 };
        CommerceStudent Commercessubject = new CommerceStudent { economices = 44, accounts = 82, banking = 44 };

        Console.WriteLine(sciencesubject.GetAvgMarks());
        Console.WriteLine(Commercessubject.GetAvgMarks());
    }
}




