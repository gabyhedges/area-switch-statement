namespace AreaSwitchStatement//names the program and allows for classes to be used

{

    //our includes/usings/importing of libraries

    using System;

    using System.Collections.Generic;

    using System.Drawing;

    using System.Linq;

    using System.Text;

    using System.Threading.Tasks;//imports libraries

    using System.Xml.Serialization;





    internal class Program//gives the program a class

    {

        static void Main(string[] args)//main function. entrypoint of program

        {
            //initialising variables
            string userChoice;

            float length;

            float width;

            float rectangleArea;

            float radius;

            float circleArea;

            float height;

            float baseOfTriangle;

            float triangleArea;

            float cubeArea;

            float side;



            Console.WriteLine("Please enter your choice");//prompt to user

            Console.WriteLine("Choices are:-");//prompt to user

            Console.WriteLine("rectangle, circle, triangle, cube");//prompt to user

            userChoice = Console.ReadLine();//accepts input and stores in a variable





            switch (userChoice)//switch statement (condition)



            {

                case "rectangle"://case one





                    Console.WriteLine("Enter the length in cms");//prompt to user

                    length = float.Parse(Console.ReadLine());//accepts user input. changes to a float from string and stores in variable

                    Console.WriteLine("Enter the width in cms");//prompt to user

                    width = float.Parse(Console.ReadLine());//accepts user input. changes to a float from string and stores in variable

                    rectangleArea = length * width;//calculation

                    Console.WriteLine("The area of the rectangle is " + rectangleArea + " square units");//prints message and result

                    break;//exits the switch



                case "circle"://case two



                    Console.WriteLine("Enter the radius in cms");//prompt to user

                    radius = float.Parse(Console.ReadLine());//accepts user input. changes to a float from string and stores in variable

                    circleArea = (float)(3.14 * radius * radius);//calculation

                    Console.WriteLine("The area of the circle is " + circleArea + " units");//prints message and result

                    break;//exits the switch statement







                case "triangle"://case three



                    Console.WriteLine("Enter the height in cms");//prompt to user

                    height = float.Parse(Console.ReadLine());//accepts user input. changes to a float from string and stores in variable

                    Console.WriteLine("Enter the base in cms");//prompt to user

                    baseOfTriangle = float.Parse(Console.ReadLine());//accepts user input. changes to a float from string and stores in variable

                    triangleArea = (float)(0.5 * height * baseOfTriangle);//calculation

                    Console.WriteLine("The area of the circle is " + triangleArea + " units");//prints message and result

                    break;//exits the switch statement



                case "cube"://case four



                    Console.WriteLine("Enter the side in cms");//prompt to user

                    side = float.Parse(Console.ReadLine());//accepts user input. changes to a float from string and stores in variable

                    cubeArea = (float)(6 * side * side);//calculation

                    Console.WriteLine("The area of the cube is " + cubeArea + " units");//prints message and result

                    break;//exits the program



                default://in the event no other cases are met



                    Console.WriteLine("Invalid choice");//prints to the screen

                    break;//exits the program



            }

            Console.ReadLine();//prevents the console window from closing until a key is hit



        }



    }



}