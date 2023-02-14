/*Hacer un programa que lea nombre, correo, materia, calificacion y estatus de un alumno 
 el programa se repetira hasta que el usuario lo quiera

 Una vez introducido los datos el programa mostrara el nombre, correo y estatus de los alumnos acticvo
y adema la cantidad de alumnos inactivos. para finalizar mostrara el alumno con mayor calificacion */
using System.ComponentModel;
List<List<string>> men = new List<List<string>>();
string p = "s";
string nm,co,ma,ess , nmm="";
int a,may=0, con=0;
bool es;
while (p == "s") {
    Console.Write("Escribe el nombre del alumno ");
    nm = Console.ReadLine();
    Console.Write("Escribe el correo del alumno ");
    co = Console.ReadLine();
    Console.Write("Escribe la materia ");
    ma = Console.ReadLine();
    Console.Write("Escribe la calificacion ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Escribe el estatus del alumno 'activos = t o inactivos = f': ");
    ess= Console.ReadLine();
    List<string> me = new List<string>();
    if (ess == "t")    {
        es= true;
        me.Add(nm);
        me.Add(co);
        me.Add("Actico");
    }
    else{
        es= false;
        con++;
    }
    if (may < a)    {
        nmm = nm;
        may = a;
    }
    men.Add(me);
    Console.Write("Quieres agregar otro alumno? 's = si' ");
    p = Console.ReadLine();
}
Console.WriteLine("Alumnos activos ");
foreach (var i in men){
    Console.WriteLine(String.Join(", ", i));
}
Console.WriteLine("El que tiene mayor calificacion es {0}",nmm);
Console.WriteLine("Cantidad de alumnos inacticos {0}", con);
