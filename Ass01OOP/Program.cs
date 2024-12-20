namespace Ass01OOP
{
    #region Enum and Struct
    #region 1- Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum
    //enum WeekDays
    //{
    //    Monday, Tuesday, Wednesday, Friday, Saturday, Sunday
    //}
    #endregion

    #region 2- Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
    //struct Person
    //{
    //    public int Age { get; set; }
    //    public string Name { get; set; }

    //    public Person(string name, int age)
    //    {
    //        Age = age;
    //        Name = name;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Name: {Name}, Age: {Age}";
    //    }
    //}
    #endregion

    #region 3- Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
    //enum Season
    //{
    //    Spring, Summer, Autumn, Winter
    //}
    #endregion

    #region 4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum
    //[Flags]
    //enum Permissions : byte
    //{
    //    Read = 1, Write = 2, Delete = 4, Execute = 8
    //}
    #endregion

    #region 5-  Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
    //[Flags]
    //enum Colors
    //{
    //    Red, Green, Blue
    //}
    #endregion

    #region 6- Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
    //struct Point
    //{
    //    public double X { get; set; }
    //    public double Y { get; set; }

    //    public Point(double x, double y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public double Distance(Point p)
    //    {
    //        double dx = p.X - X;
    //        double dy = p.Y - Y;
    //        return  Math.Sqrt( dx * dx + dy * dy);
    //    }
    //}
    #endregion

    #region 7- Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person
    //struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Person(string name, int age)
    //    {
    //       Name = name;
    //        Age = age;
    //    }
    //}
    #endregion

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:
            //Console.WriteLine("Days of the week:");

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Q2:
            //Person[] person = new Person[3];
            //person[0] = new Person("Abdelfatah", 20);
            //person[1] = new Person("Arafa", 30);
            //person[2] = new Person("Ali", 27);

            //foreach (Person p in person)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Q3:
            //Console.Write("Enter The Mounth: ");
            //string month = Console.ReadLine();
            //switch (month)
            //{
            //    case "March":
            //    case "April":
            //    case "May":
            //        Console.WriteLine(Season.Spring);
            //        break;

            //    case "June":
            //    case "July":
            //    case "August":
            //        Console.WriteLine(Season.Summer);
            //        break;

            //    case "September":
            //    case "October":
            //    case "November ":
            //        Console.WriteLine(Season.Autumn);
            //        break;

            //    case "December":
            //    case "January":
            //    case "February":
            //        Console.WriteLine(Season.Winter);
            //        break;

            //    default:
            //        Console.WriteLine("Invaild");
            //        break;
            //}
            #endregion

            #region Q4: 
            //Permissions permissions = Permissions.Read;
            //permissions |= Permissions.Write; 
            //permissions |= Permissions.Delete;
            //Console.WriteLine($"Permissions: {permissions}\n");
            //if ((permissions & Permissions.Read) == Permissions.Read)
            //{
            //    permissions ^= Permissions.Read;
            //}
            //Console.WriteLine($"Permissions After Remove: {permissions}\n");
            //permissions ^= Permissions.Execute;
            //Console.WriteLine($"Permissions After Add: {permissions}\n");
            #endregion

            #region Q5:
            //Console.Write("Enter A Coolor Name: ");
            //string str = Console.ReadLine();
            //if (Enum.TryParse(str, true, out Colors color))
            //    Console.WriteLine($"{color} Is A Primary Color.");

            //else
            //    Console.WriteLine($"{str} Is Not A Primary Color");

            #endregion

            #region Q6:
            //Console.WriteLine("Enter The Coordinates Of The First Point (X Y):");
            //string[] point1Input = Console.ReadLine().Split(' ');
            //double d01 = double.Parse(point1Input[0]);
            //double d02 = double.Parse(point1Input[1]);
            //Point point1 = new Point(d01, d02);
            //Console.WriteLine("Enter The Coordinates Of The Second Point (X Y):");
            //string[] point2Input = Console.ReadLine().Split(' ');
            //double d11 = double.Parse(point2Input[0]);
            //double d12 = double.Parse(point2Input[1]);
            //Point point2 = new Point(d11, d12);

            //double distance = point1.Distance(point2);

            //Console.WriteLine($"The Distance Between The Two Points Is: {distance:F2}");
            #endregion

            #region Q7:
            //Person[] person = new Person[3];

            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"Enter Details For Person: {i + 1}");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age = int.Parse(Console.ReadLine());
            //    person[i] = new Person(name, age);
            //}
            //Person oldPerson = person[0];
            //foreach (Person p in person)
            //{
            //    if(p.Age > oldPerson.Age )
            //      oldPerson = p;
            //}
            //Console.WriteLine($"The Oldest Person Is {oldPerson.Name} with {oldPerson.Age} years.");
            #endregion
        }
    }
}
