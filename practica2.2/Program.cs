// See https://aka.ms/new-console-template for more information


using System.Text;

Console.Write("Escribe una cadena ");
string a = Console.ReadLine();
byte[] arr = Encoding.ASCII.GetBytes(a);
int ce = 0,cl=0,cn=0;
foreach(byte b in arr)
{
    //Console.WriteLine(" {0} = {1}", b, (char)b);
    if ((char)b == 32)//contador espacio
    {
        ce++;
    }
    if ((char)b >= 49 && (char)b <=57)//contador numeros
    {
        cn++;
    }
    if ((char)b >= 65 && (char)b <= 90 || (char)b >= 97 && (char)b <= 122)//contador letras
    {
        cl++;
    }
}

Console.WriteLine("cantidad de espacios {0}, cantidad de numeros {1}, cantidad de letras {2}",ce,cn,cl);