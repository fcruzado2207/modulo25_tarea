using System;
using System.Collections.Generic;
using System.Text;

namespace T19
{
    public static class Lista
    {
        public static T[] Append<T>(this T[] array, T item)
        {
            if (array == null)
            {
                return new T[] { item };
            }

            T[] result = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }

            result[array.Length] = item;
            return result;
        }
    }
    public class Example
    {

        public List<double> papi = new List<double>();
        public void Main(double nombre)
        { 
            double item = nombre;
            papi.Add(item);         
            
        }
        
    }
}
 