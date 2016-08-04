using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Class vs Instance*/

namespace hackerranktest4
{

     
    class Person
    {
        public int age;

        public Person(int initialAge)
        {
            if (initialAge > 0)
            {
                this.age = initialAge;
            }

            else
            {   //set the age to zero because a negative age was entered
                Console.WriteLine("Age is not valid, setting age to 0");
                this.age = 0;
            }

        }

        public void amIOld()
        {
            if (age >=0 && age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager."); 
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are old."); 
            }

        }

        public void yearPasses()
        {
           // age++;
            this.age++;
        }


       
        
        static void Main(string[] args)
        {

            Console.Write("Please, enter the number of people: ");
            int T = int.Parse(Console.In.ReadLine());

            Console.WriteLine("For each person, enter his/her age: ");
            for (int i = 0; i < T; i++) 
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                 p.amIOld();
               
                for (int j = 0; j < 3; j++) 
                {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();

               
            }
    
            Console.ReadKey();  // allows the console to wait until the user presses a key.



        }

        
    }

    
}
