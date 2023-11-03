using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
namespace lab2;
public class Program
{
    public static void Main()
    {
        try
        {
            CodificacionAritmetica operando = new CodificacionAritmetica();
            AVLTree<Persona> arbolPersonas = new AVLTree<Persona>();
            string route = @"C:\Users\Monica\Documents\URL\SEXTO CICLO\Estructura de Datos II\ED2\Lab2\input_lab2.csv";

            if (File.Exists(route))
            {
                string[] FileData = File.ReadAllLines(route);
                foreach (var item in FileData)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        string[] fila = item.Split(";");
                        Persona? persona = JsonSerializer.Deserialize<Persona>(fila[1]);
                        List<Dictionary<char, Letra>> lista = new List<Dictionary<char, Letra>>();
                        Array.Sort(persona!.companies, (x, y) => String.Compare(x, y));
                        List<double> codigos = new List<double>();
                        for (int i = 0; i < persona.companies.Length; i++)
                        {
                            Dictionary<char, Letra> dictionario = new Dictionary<char, Letra>();
                            string codigo = persona.dpi + i.ToString();
                            foreach (var c in codigo)
                            {
                                Letra nueva = new Letra();
                                if (!dictionario.TryAdd(c, nueva))
                                {

                                }
                                dictionario[c].frecuencia++;
                            }

                            double inf = 0, sup = 0, p = 0;
                            foreach (var c in dictionario)
                            {
                                p = (double)c.Value.frecuencia / codigo.Length;
                                sup = inf + p;
                                dictionario[c.Key].probabilidad = p;
                                dictionario[c.Key].inferior = inf;
                                dictionario[c.Key].superior = sup;
                                inf = sup;
                            }

                            double newCode = operando.Codificacion(codigo, dictionario);
                            codigos.Add(newCode);
                            lista.Add(dictionario);
                        }
                        foreach (var item1 in fila)
                        {
                            Console.WriteLine(fila[1]);
                            Console.WriteLine("");
                        }
                        persona.dictionaries = lista;
                        persona.codes = codigos;
                        if (fila[0] == "INSERT")
                        {
                            arbolPersonas.Add(persona!, Delegates.DPIComparison);
                        }
                        else if (fila[0] == "DELETE")
                        {
                            arbolPersonas.Delete(persona!, Delegates.DPIComparison);
                        }
                        else if (fila[0] == "PATCH")
                        {
                            arbolPersonas.Patch(persona!, Delegates.DPIComparison);
                        }
                    }
                }
            }

            string flag = "";
            do
            {
                Console.WriteLine("Ingrese el dpi de la persona que quiere buscar: ");
                string? dpi = Console.ReadLine();
                Persona persona1 = new Persona();
                persona1.dpi = dpi!;
                Persona resultado = arbolPersonas.Search(persona1, Delegates.DPIComparison);
                if (resultado != null)
                {
                    string datos = "name: " + resultado.name
                        + "\n" + "dpi: " + resultado.dpi
                        + "\n" + "datebirth: " + resultado.datebirth
                        + "\n" + "address: " + resultado.address
                        + "\n" + "companies: {";

                    for (int i = 0; i < resultado.companies.Length; i++)
                    {
                        datos += "\n" + "  " + resultado.companies[i] + ": " + resultado.codes[i].ToString();
                    }
                    datos += "\n}";
                    Console.WriteLine(datos);
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Escoja la operación que quiere realizar"
                        + "\n" + "1. Codificar DPI"
                        + "\n" + "2 Decodificar DPI"
                        + "\n" + "3. Salir");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            string encodedString = Encode(dpi);

                            static string Encode(string dpi)
                            {
                                StringBuilder encodedString = new StringBuilder();
                                foreach (char c in dpi)
                                {
                                    int charCode = (int)c;
                                    char newChar = (char)(charCode + 1);
                                    encodedString.Append(newChar);
                                }
                                return encodedString.ToString();
                            }
                            Console.WriteLine($"El DPI codificado es: {encodedString}");

                            break;
                        case 2:
                            Console.WriteLine("Ingrese el nombre de la empresa");
                            string empresa = Console.ReadLine()!;
                            if (empresa != null)
                            {
                                int index = Array.BinarySearch(resultado.companies, empresa);
                                if (index < 0)
                                {
                                    throw new Exception("La empresa ingresada no existe");
                                }
                                double code = resultado.codes[index];
                                Dictionary<char, Letra> dic1 = resultado.dictionaries[index];
                                string resul = operando.Decodificacion(code, dic1);
                                Console.WriteLine("El DPI de la persona es: " + resultado.dpi);
                                Console.WriteLine("El DPI decodificado es:" + resul);
                                //File.WriteAllText("respuesta.txt", resul);
                                string nombreArchivo = "DPI Decodificado";
                                StreamWriter sw = new StreamWriter(nombreArchivo);
                                sw.WriteLine(resul);
                                sw.Close();
                            }
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("La opción ingresada no es válida");
                            break;
                    }

                    Console.WriteLine("¿Desea realizar otra búsqueda? Ingrese \'1\' o \'2\' ");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    flag = Console.ReadLine()!;
                }
                
            }while (flag == "1") ;

        }
        catch (Exception e)
        {
            Console.WriteLine("Ha ocurrido un error inesperado");
        }
    }
}
