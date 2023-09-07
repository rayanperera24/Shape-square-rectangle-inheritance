//cocse234-031
//B D I R Perera
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_activty_question
{
    class Program
    {
        class shape
        {
            protected string name;
            protected string color;

            public void setname(string nm)
            {
                name = nm;
            }

            public void displayname()
            {
                Console.WriteLine("Shape Name : " + name);
            }

        }

        class rectangle : shape
        {
            protected int length;
            protected int width;
            public void setdata(int L,int w)
            {
                length = L;
                width = w;
            }

            public void display()
            {
                Console.WriteLine("rectangle length : " + length);
                Console.WriteLine("rectangle width : " + width);
            }

            public void calcarea()
            {
                Console.WriteLine("shape area : "+length*width);
            }

        }

        class square : shape
        {
            protected int length;

            public void setlength()
            {
                Console.WriteLine("Enter the length of a square");
                length = Convert.ToInt32((Console.ReadLine()));
            }

            public void calcarea()
            {
                Console.WriteLine("area " + length * length);
            }





        }




        static void Main(string[] args)
        {
            rectangle rec1 = new rectangle();
            rec1.setname("circle");
            rec1.displayname();
            rec1.setdata(10, 2);
            rec1.display();
            rec1.calcarea();


           square sq1 = new square();
           sq1.setlength();
           sq1.calcarea();



            Console.ReadKey();
        }
    }
}
