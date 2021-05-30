using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//Tod en un array es un objeto, no una variable

namespace ColeccionesArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList palabras = new ArrayList();
            int n = 0;
            int r = 0;

            palabras.AddRange(new string[] { "Hola", "Como", "Estan?" });

            Console.WriteLine("La cantidad de elementos son: {0}", palabras.Count);

            palabras.Add( "Bien , y tu ?");

            /*for (int i = 0; i < palabras.Count; i++)
            {
                Console.WriteLine("{0}", palabras[i]);
            }*/
            foreach (var item in palabras)
            {
                Console.WriteLine(item);
            }

            ArrayList Valores = new ArrayList();
            Valores.Add(1);
            Valores.Add(2);
            Valores.Add(3);

            

            if (Valores.Contains(2))
            {
                Valores.Insert(0, 55);
                for (int i = 0; i < Valores.Count; i++)
                {
                    //Este es un cast para obtener el valor y no el objeto
                    r = (int)Valores[i];
                    if (r == 55)
                    {
                        Valores.Remove(55);
                    }
                    else
                    {
                        Console.WriteLine(r);
                    }
                    
                }
                
            }
            Valores.RemoveAt(1);

            foreach (var item in Valores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("-----");
            Console.ReadKey();
        }
    }
}
