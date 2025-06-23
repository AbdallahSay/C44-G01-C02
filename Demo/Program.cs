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

        }
    }
}
