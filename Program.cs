namespace GestorTareas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoPorHoras empleado = new EmpleadoPorHoras("Fran", "IT", 150000, 20, 500);

            // Verificamos la herencia y el método sobrescrito
            Console.WriteLine($"Nombre: {empleado.Nombre}");           // Heredado
            Console.WriteLine($"Departamento: {empleado.Departamento}"); // Heredado
            Console.WriteLine($"Salario calculado: {empleado.ObtenerSalario()}"); // Propio (20 * 500)

            Console.ReadLine(); // Para que la consola no se cierre sola

            //Hacer el ejercicio 2 del Modulo 2 del dia 3 USARIO -> ADMINISTRADOR

            var empleados = new List<Empleado>
            {
                new Empleado("Fran",  150000,"IT"),
                new Comercial("Raul",10000, "Ventas", 10),
                new Desarrollador("Andrea",250000, "IT", 5)
            };

            foreach(var empl in empleados)
            {
                Console.WriteLine("Nombre:" +  empl.Nombre);           
                // Heredado
               // Console.WriteLine("Departamento: {empl.Departamento}"); // Heredado
               // Console.WriteLine("Salario calculado: {empl.CalcularBonificacion()}"); // Propio (20 * 500)
            }
        }
    }
}