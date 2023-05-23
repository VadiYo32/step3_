using System;
using System.Linq;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
 

public class rule3
{
    public static void Main()
    {
        int[] array = { 88,44,55,66,22,12,55,7,4,484,3959,3684, };//para que esto funcione solo se tienen que cambiar los valores de este array por el que nos de con el paso anterior 
 
        Array.Sort(array);//este acomodo de forma acendente los numeros en el array

        int sum = array.Sum();//este paso hace la suma de todas los elementos de el array 

        foreach (int i in array)
        {

            Console.WriteLine(i);

        }

            Console.WriteLine(sum);
    }
    
    
}

