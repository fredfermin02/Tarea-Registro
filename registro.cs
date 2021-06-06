using System;
using System.IO;
using System.Text;
namespace Rggistro
{
  class Class1
  {
    public static void Main(string[] args)
    {

      StreamWriter sw = new StreamWriter("/Users/frederickfermin/Desktop/TareaRegistro/registro.txt", true);

      Console.Write("Ingrese su cedula: ");
      string vCedula = Console.ReadLine();

      Console.Write("Ingrese su nombre: ");
      string vNombre = Console.ReadLine();

      Console.Write("Ingrese su apellido: ");
      string vApellido = Console.ReadLine();

      Console.Write("Ingrese su edad: ");
      int vEdad = int.Parse(Console.ReadLine());

      Console.Write("Desea guardar los datos (Y/N): ");
      string vEleccion = Console.ReadLine();

      if (vEleccion == "Y") {
        sw.WriteLine("{0},{1},{2},{3}",vCedula,vNombre,vApellido,vEdad);
      }

      sw.Close();
    }
  }
}
