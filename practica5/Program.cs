String n1;
double p1, p2, p3=0;
for (int i = 0; i < 5; i++){
    Console.Write("Escribe el nombre del producto "); 
    n1 = Console.ReadLine();
    Console.Write("Escribe la cantidad del producto "); 
    p1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Escribe el precio del producto "); 
    p2 = Convert.ToDouble(Console.ReadLine());
    p3 += (p1 * p2);
}Console.WriteLine("Total a pagar sin iva {0} iva a pagar {1} total a pagar con iva {2}", p3, p3 * .16, p3 * 1.16);
