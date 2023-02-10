// See https://aka.ms/new-console-template for more information
/*Hacer un programa que lea nombre edad , y sexo de 5 personas
 El programa mostrara en panatalla los siguientes reusltados, promedio de edades de mujeres,
cual es el hombre mayor y menor de edad y cual de las mujeres son menores de edad .*/


List<string> mmen= new List<string>();
List<string> men = new List<string>();
List<string> en = new List<string>();

string a,s,e,mh,nh;
int d=0,cn=0,f=0,m=0,n=0,h=1;
double q;

for (int i = 0; i < 5; i++)
{
    Console.Write("Escribe el nombre ");
    a = Console.ReadLine();
    Console.Write("Escribe el sexo ´h o m´: ");
    s = Console.ReadLine();
    Console.Write("Escribe la edad ");
    e = Console.ReadLine();
    f = Convert.ToInt32(e);
    
    if (s == "m")
    {
        d += Convert.ToInt32(e);
        cn++;
        if (f < 18)
        {
            mmen.Add(a);
        }
    }
    else
    {
        if (h==1) 
        {
            m = f;
            n = f;
            mh = a;
            nh = a;
            h--;
        }
        else
        {
            if (f > m)
            {
                n = f;
                nh = a;
                men.Insert(0,nh);
            }
            else
            {
                m = f;
                mh = a;
                en.Insert(0, mh);
            }
        }


    }
    /*if (i == 4) 
    {
        men.Add(nh);    
    }*/

}

Console.WriteLine("El promedio de la edad de las mujeres es de {0}", d / cn);

Console.Write("El mayor es");
foreach (var i in men)
{
    Console.WriteLine(String.Join(", ", i));
}

Console.WriteLine("El menor es ");
foreach (var i in en)
{
    Console.WriteLine(String.Join(", ", i));
}

Console.Write("Mujeres menores ");
foreach (var i in mmen)
{
    Console.WriteLine(String.Join(", ", i));
}
