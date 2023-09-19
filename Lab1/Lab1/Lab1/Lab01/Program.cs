using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
namespace Lab01;
public class Program
{
    public static void Main()
    {
        try
        {
            AVLTree<Persona> arbolPersonas = new AVLTree<Persona>();
            List<Persona> personas = new List<Persona>();
            string route = @"C:\Users\Monica\Documents\URL\SEXTO CICLO\Estructura de Datos II\ED2\Lab1\Lab1\Lab1\input_lab1.csv";
            if (File.Exists(route))
            {
                string[] FileData = File.ReadAllLines(route);
                foreach (var item in FileData)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        string[] fila = item.Split(";");
                        foreach (var item1 in fila)
                        {
                            Console.WriteLine(item1);
                            Console.WriteLine("");
                        }
                        Persona? persona = JsonSerializer.Deserialize<Persona>(fila[1]);
                        if (fila[0] == "INSERT")
                        {
                            arbolPersonas.Add(persona!, Delegates.NameComparison, Delegates.DPIComparison);
                        }
                        else if (fila[0] == "DELETE")
                        {
                            arbolPersonas.Delete(persona!, Delegates.NameComparison, Delegates.DPIComparison);
                        }
                        else if (fila[0] == "PATCH")
                        {
                            arbolPersonas.Patch(persona!, Delegates.NameComparison, Delegates.DPIComparison);
                        }
                    }                    
                }

                string flag = "";
                do
                {
                    personas.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el nombre de la persona que quiere buscar: ");
                    string? name = Console.ReadLine();
                    Persona temporal = new Persona();
                    temporal.name = name!;
                    arbolPersonas.QueryResults(arbolPersonas.Root!, temporal, Delegates.NameComparison, personas);
                    string line = "";
                    if (personas.Count() == 0)
                    {
                        line = "Sin coincidencias para el nombre " + name;
                        Console.WriteLine(line);
                    }
                    else
                    {
                        foreach (var item in personas)
                        {
                            line += JsonSerializer.Serialize<Persona>(item) + "\n";
                        }
                        line += "Existe un usuario llamado " + name;
                        string output = @"C:\Users\Monica\Documents\URL\SEXTO CICLO\Estructura de Datos II\ED2\Lab1\Lab1\Lab1\input_lab1.csv" + name + ".txt";
                        //File.WriteAllText(output, line);
                        Console.WriteLine(line);
                        Console.WriteLine("");
                    }

                    Console.WriteLine("¿Desea realizar otra búsqueda? Ingrese \'1\' o \'2\' ");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    flag = Console.ReadLine()!;
                } while (flag == "1");                                                
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ha ocurrido un error inesperado");
        }
        Console.ReadKey();
    }
}
