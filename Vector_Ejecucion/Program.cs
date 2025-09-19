//Usamos list porque declarar un arreglo en una variable no permite que sea dinamico en c#
List<int> calificaciones = new List<int>();

while (true) 
{
    try
    {
        Console.Write("Ingresa la cantidad de alumnos en el salon: ");
        int cantidad_alumnos = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad_alumnos; i++)
        {
            Console.Write($"Ingresa la calificacion final del alumno {i + 1}: ");
            int calificacion = int.Parse(Console.ReadLine());
            calificaciones.Add(calificacion); 
        }
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Porfavor ingresa un numero valido");
    }
}

Console.Write("Estas fueron las calificaciones recolectadas: ");
foreach (var i in calificaciones)
{

    if (i != calificaciones.Last())
    {
        Console.Write(i + ", ");
    }
    else
    {
        Console.Write(i);
    }
}

Console.ReadKey();


