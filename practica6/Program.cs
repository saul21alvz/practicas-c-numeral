// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
 * hacer un programa que lea nombre del alumno, nombre de la materia y 4 calificaciones 
el programa calculara el promedio de la materia y la almacenara en una lista esta accion se repetira hasta que el usuario lo desee.
al finalisal el programa mostrara el promedio de todas las materias
*/
List<List<string>> materias = new List<List<string>>();
bool estado = true;
string n,nm;
double a;

while (estado == true) {
    Console.Write("Escribe el nombre del alumno: ");
    n = Convert.ToString(Console.ReadLine());
    Console.Write("Escribe el nombre de la materia: ");
    nm = Convert.ToString(Console.ReadLine());
    Console.Write("Escribe la calificacion del primer parcial: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Escribe la calificacion del segundo parcial: ");
    a += Convert.ToDouble(Console.ReadLine());
    Console.Write("Escribe la calificacion del tercero parcial: ");
    a += Convert.ToDouble(Console.ReadLine());
    Console.Write("Escribe la calificacion del cuarto parcial: ");
    a += Convert.ToDouble(Console.ReadLine());
    a /= 4;
    Console.WriteLine(a);
    List<string> materia = new List<string>();
    materia.Add(nm );
    materia.Add(a.ToString());

    materias.Add(materia);

    Console.Write("Quieres seguir: "+"si o no:");
    n=Convert.ToString(Console.ReadLine());

    if (n == "n" || n == "no")
    {
        estado = false;
    }
}
foreach (var i in materias)
{
    Console.WriteLine(String.Join(", ",i));
}