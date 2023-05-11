using ClassTest.App.Extensions;
using System;
using System.Text;

List<Person> people = SeedData.Load();

/// <summary>
/// Prueba de distintos metodos para mostrar la misma información
/// El orden de las pruebas no indica cual es la mejor
/// Solo lo hice asi por qué asi me vinieron a la mente
/// </summary>
/// 
Functions.PrintMsg("Prueba del Maestro",(25));


// StringBuilder and for
var sb = new StringBuilder();

for (int i = 0; i < people.Count; i++)
{
    if (people[i] is not null)
    {
        sb.AppendLine($"Hello #{i + 1}, {people[i]}");
    }
} 

Console.WriteLine(sb.ToString());


Functions.SeparatorColor(25);

int c = 0;

// foreach
foreach (var person in people)
    Console.WriteLine($"Hello #{++c} - {person}");

Functions.SeparatorColor(25);

c = 0;

// ForEach
people.ForEach(p => Console.WriteLine($"Hello #{++c} - {p}"));

Functions.SeparatorColor(25);
people.ForEach(p => Console.WriteLine($"Hello #{++c} - {p.Upper()}"));



