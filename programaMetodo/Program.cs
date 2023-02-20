namespace programaMetodo
{
    internal class program
    {
        static void main(string[] args)
        {
            int a;
            Console.WriteLine("Escribe un numero");
            a = Convert.ToInt32(Console.ReadLine());
            leer(a);
        }
        static void leer(int a) 
        {
            Console.WriteLine("El cuadrado de {0} es {1} ",a, a * a);
        }
    }
}