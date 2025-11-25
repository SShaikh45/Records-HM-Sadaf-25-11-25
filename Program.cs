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
        }

        People people2 = new People("Daniel", 12, "Swansea", 12.5, "Student");
    }
}
