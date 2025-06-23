namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Comments & Regions
            // sigle line comment
            //int x = 10;
            //int y = 20;
            /*
             * Multiple Line Comment  
             * int x = 12; 
             * int y = 13;
             *
             */


            ///XML Comment
            /// <summary>
            /// Sum Two Integers 
            /// </summary>
            /// <param name="x">  first Number </param>
            /// <param name="y"> Second Number </param>
            /// <returns> Sum of x + y  </returns>
            //static int sum(int x, int y)
            //{

            //    return x + y;

            //}
            #endregion
            #region Naming Conventions
            /*
               *1)Pascal Case [C#]
                    ex: AbdallahSayed
               *2)camelCase [js]
               * ex: abdallahSayed
               * 3)  Kebab-case
               * ex: Abdallah-Sayed
               * 4)  Snake_Case
               * ex: Abdallah_Sayed
             */
            #endregion
            #region Variable Declaration
            // Variable --> camelCase
            // DataType Name Value
            //int myNum = 10;
            //Console.WriteLine(myNum);
            //int myNum1 = 20, myNum2 = 30;
            //Console.WriteLine("Sum = "+ (myNum1 + myNum2));
            //string @class = "Abdol"; 
            //    Console.WriteLine( @class ); 
            #endregion
            #region CTS
            // value type 
            /*
             * retrive faster
             * use struct , enum 
             * primitive
             * stack memory
             * int x = 10 , y = 20
             * x=y -- copy values x,y = 20
             * 
            */
            // Reference Type
            /*
             * retrive slower
             * use class , interface 
             * non-primitive
             * stack to save address , heap to save values
             *  int x = 10 , y = 20 ; 
             *  x = y -- copy address
             */
            #endregion
            #region DataType
            // int  = Int32
            //int myNum = 1; 
            //Int32 myNum2 = 2;
            //Console.WriteLine(myNum);
            //Console.WriteLine(myNum2);
            //short = Int16
            //long  = Int64
            #endregion
            #region Value Type
            // Primitive DataType
            //int x = 10; // C# Keyword [alias]
            //Int32 y = 23; // BCL
            //Single mySingle = 20.1f; // BCL
            //float myFloat = 20.1f; // C# Keyword [alias]
            //int x; // declare Varable [unintialized] allocate 4 byte in stack
            //x = 10; // Assign value in stack
            //Int32 y = 20;
            //Console.WriteLine(x); // 10
            //Console.WriteLine(y); // 20
            //y = x;
            //Console.WriteLine();
            //Console.WriteLine(x); // 10
            //Console.WriteLine(y); // 10

            //x = 30;
            //Console.WriteLine();
            //Console.WriteLine(x); // 30 
            //Console.WriteLine(y); // 10  
            /// why ? copy value not addres

            //string fName = "Abdallah"; // c# keyword
            //String lName = "Sayed"; //BCL
            //Console.Write("My name is : " + fName +" "+ lName);
            //Console.Read();






            #endregion
            #region Reference Type
            //point p1; // allocate 4 byte in stack , 0 byte in heap
            //p1 = new point();
            /**
             * 1) allocate number of byte gor the object needed in heap
             * 2) initialze each filed with the defult value based on DataType
             * 3) call user defined constructor
             * 4) assign object to Reference  
             * 
             */
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);

            //point p2 = new point() { x = 5 ,  y = 10};
            //Console.WriteLine();
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);

            //p1 = p2; // 5 10 , 5 10
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Console.WriteLine();
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);
            //p2.x = 20; 
            //p2.y = 40;
            //Console.WriteLine();
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Console.WriteLine();
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);
            //Why this Result ?  Copy address not value so p1 is unreachable object now
            #endregion
        }
    }
}
