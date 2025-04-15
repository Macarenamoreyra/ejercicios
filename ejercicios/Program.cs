string nombre;
int IngresosPorPantalla = 0;
int sumadenotas = 0;


do
{
    Console.WriteLine("Ingrese un nombre:");
    nombre = Console.ReadLine();

    if (nombre == "")
    {
        Console.WriteLine(" Por favor ingrese un nombre");
    }

} while (nombre == "");


Console.WriteLine("¿Cuántas calificaciones tiene?");
IngresosPorPantalla = int.Parse(Console.ReadLine());

if (IngresosPorPantalla < 1 || IngresosPorPantalla > 5)
{
    Console.WriteLine(" La cantidad debe estar entre 1 y 5.");
    return;
}

for (int i = 1; i <= IngresosPorPantalla; i++)
{
    int nota;

    do
    {
        Console.Write("Ingrese la calificación " + i + " (entre 1 y 10): ");
        nota = int.Parse(Console.ReadLine());

        if (nota < 0 || nota > 11)
        {
            Console.WriteLine(" La calificación debe estar entre 1 y 10.");
        }

    } while (nota < 0 || nota > 10);

    sumadenotas += nota;
}

int promedio = 0;
 promedio = sumadenotas / IngresosPorPantalla;

Console.WriteLine("estimad@ " + nombre +" , su promedio es: " + promedio);


if (promedio < 6)
{
    Console.WriteLine(" Reprobado ");
}
 else if (promedio >= 6||promedio <= 7)
{
    Console.WriteLine(" Regular");
}
else if (promedio < 7||promedio <=9)
{
    Console.WriteLine(" Bueno");
}
else if (promedio >= 9)
{
    Console.WriteLine("Excelente");
}

