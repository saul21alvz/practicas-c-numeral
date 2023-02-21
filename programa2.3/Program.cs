/* hacer un programa que lea sexo nombre y edad de tres personas.
el programa creara metodos para validar nombre, sexo y edad,
una vez validados se meteran los datos en un archivo */

using System.Text;

namespace programa12
{
    internal class program
    {
        static void Main (string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                string n, s, e;
                n = Nombre();
                s = Sexo();
                e = Edad();
                StreamWriter fichero;
                string nombre = "programa12.txt";
                string dato = "";

                try
                {
                    fichero = File.AppendText(nombre);//crea el archivo o lo reutiliza
                    dato = "Nombre:  " + n.ToString() + " \n" +
                        "Sexo: " + s.ToString() + "\n" +
                        "Edad: " + e.ToString();
                    Console.WriteLine(dato);
                    fichero.WriteLine(dato);
                    fichero.Close();//cierra el archivo
                }
                catch (Exception msg) // Si no se puede leer mostramos el error
                {
                    Console.WriteLine("No se encuentra el archivo " + msg);
                }
            }

        }
        static string Sexo()    
        {
            bool b = true;
            string d="";
            while (b==true)
            {
                Console.WriteLine("Escribe el genero 'h' o 'm' ");
                d = Console.ReadLine();
                if (d == "h" || d == "m")
                {
                    b= false;
                }
                else
                {
                    Console.WriteLine("El dato que introdujo no esta entre los parametros ");
                    b = true;
                }
            }
            return d;
        }

        static string Nombre()
        {
            bool c = true;
            string no = "";
            byte[] arr = Encoding.ASCII.GetBytes(no);
            int ce = 0, cl = 0;
            while (c==true)
            {
                ce = 0;
                cl = 0;
                Console.WriteLine("Escribe el nombre ");
                no = Console.ReadLine();
                arr = Encoding.ASCII.GetBytes(no);                
                foreach (byte b in arr)
                {
                    //Console.WriteLine(" {0} = {1}", b, (char)b);
                    if ((char)b == 32)//contador espacio
                    {
                        ce++;
                    }
                    if ((char)b >= 65 && (char)b <= 90 || (char)b >= 97 && (char)b <= 122)//contador letras
                    {
                        cl++;
                    }
                }
                if (no.Length == ce + cl)
                {
                    c = false;
                }
                else
                {
                    Console.WriteLine("El nombre tiene un caracter no valido");
                    c = true;
                }
            }
            return no;
        }

        static string Edad()
        {
            bool v = true;
            string num = "";
            int f;
            while (v==true)
            {
                Console.WriteLine("Escribe la edad ");
                num = Console.ReadLine();
                if (int.TryParse(num, out f))
                {
                    v = false;
                }
                else
                {
                    Console.WriteLine("La edad tiene un caracter no valido");
                    v = true;
                }
            }
            return num;
        }
    }


}