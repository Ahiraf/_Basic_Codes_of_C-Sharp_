using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   //Assemblies Contain related Namespaces


// There are three types of data in C-sharp.

/*1) Value data type : Directly store value in memory. can be both signed and unsigned.Derived from the class System.ValueType
                       Example : short,int,float,double,char,Enumerations,Structures etc . Here Enumerations and 
                       Structures are userdefined, and others are predefined.

 2) Reference data type : Stores memory address of a variable.Does not contain the actual data value.
                          Example : Class,Object,Interface,String. Here, Class and Interface are userdefined and 
                          String and Object are predefined .
                          
 3) Pointer data type : Store memory address of another type. Similar property seen in C.
                        Example : Pointer
*/

namespace DataTypes    //Contains related Classes
{
    class Program          //Camel case is used for variable naming and Pascel case is used for everything else//
    {                      // Camel case = firstNumber  Pascel case= FirstNumber
        static void Main(string[] args)
        {

            int x = 100;   //Like folders, to save data
            int y = x / 2;
            Console.WriteLine(y);
          
            // value = literal
            byte b = 1;
            int i = 100;
            float f = 2.54f; //after assigning  float types literal I have to use f 
            double h = 3.52;
            decimal d = 4.453m; //after assigning decimal types literal I have to use m
            char c = 'm';
            bool l = true;
            Console.WriteLine(b);
            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(h);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(l);
            Console.ReadLine();


        }

    }
}
    /* 2 types of variables : 1) Primitive (Built in )   and   2) Non Primitive (user defined) */
