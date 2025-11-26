namespace Records_HM_Sadaf_25_11_25
{
    internal class Program
    {
        struct People
        {
            public string name;
            public int age;
            public string city;
            public double height;
            public string occupation;

        }

        public People(string pname, int page, string pcity, double pheight, string poccupation)
        { 
            name = pname;
            age = page;
            city = pcity;
            height = pheight;
            occupation = poccupation;
        }
        static void Main(string[] args)
        {
            People p;
            p.name = "Sadaf";
            p.age = 16;
            p.city = "London";
            p.height = 6.2;
            p.occupation = "Student";
             People people2 = new People("Daniel", 12, "Swansea", 12.5, "Student");
        //makes a new people variable using the new keyword
            People[] myPeople = new People[9];
            for (int i = 0; i < 9; i ++)
            {
                Console.WriteLine("Enter the credentials for person number " + i);
                Console.WriteLine("Enter the persons name");
                myPeople[i].name = Console.ReadLine();
                Console.WriteLine("Enter the persons age");
                myPeople[i].age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the persons city");
                myPeople[i].city = Console.ReadLine();
                Console.WriteLine("Enter the persons height");
                myPeople[i].height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the persons occupation");
                myPeople[i].occupation = Console.ReadLine();
                
            }
        }

       
    }
}
