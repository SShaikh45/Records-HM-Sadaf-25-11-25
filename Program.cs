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
// Adding fields to the record
        }

        public People(string pname, int page, string pcity, double pheight, string poccupation)
        { 
            name = pname;
            age = page;
            city = pcity;
            height = pheight;
            occupation = poccupation;
            //adding properties to the record?
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
            
            double total_height = 0;
            int total_age = 0;
            string[] total_city = new string[9];
            string[] total_occupation = new string[9];
            //making variables which can be used to add the specific types of input form the user as we go along (the for loop).
            People[] myPeople = new People[9];
            for (int i = 0; i < 9; i ++)
            {
                Console.WriteLine("Enter the credentials for person number " + i);
                Console.WriteLine("Enter the persons name");
                myPeople[i].name = Console.ReadLine();
                Console.WriteLine("Enter the persons age");
                myPeople[i].age = Convert.ToInt32(Console.ReadLine());
                total_age = total_age + myPeople[i].age;
                Console.WriteLine("Enter the person's city");
                myPeople[i].city = Console.ReadLine();
                total_city[i] = myPeople[i].city;
                Console.WriteLine("Enter the persons height");
                myPeople[i].height = Convert.ToDouble(Console.ReadLine());
                total_height = total_height + Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the persons occupation");
                myPeople[i].occupation = Console.ReadLine();
                total_occupation[i]= myPeople[i].occupation;

                //Adds the specific input to each specific variable to get the overall total for each input.
                //Adds the data to each record within the array of records, which has 9 free elements.
                //coukld make the code more efficient by reducing the ampunt of code associated with the total- variables and instead hust output each variable and then add up their total individually.
                //could use a foreach loop next time to use different programming techniques.
            }

            Console.WriteLine("The total height of everyone is: " + total_height);
            Console.WriteLine("The average height of everyone is " + total_height/9);
            Console.WriteLine("The total age of everyone is: " + total_age);
            Console.WriteLine("The average age of everyone is: " + total_age/9);
            Console.WriteLine("The list of everyone's cities are: " + String.Join(" ", total_city));
            Console.WriteLine("The list of everyone's occupations are: "+ String.Join(", ", total_occupation));
            //Outputs the total and average specific inputs.
            //Need to research more on array techniques, such as String.Join(), as it would enable me to manipulate arrays (specifically arrays of strings) better.
            //note to self - Code guides for c# can be found on my own teams chat (to myself).
            
        }

       
    }
}
