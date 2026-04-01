using System;
namespace GestorTareas
{
    public class EmpleadoPorHoras : Empleado
    {
        //Virtual permite sobreescribir, con el metodo abstracto no se puede y obliga a usar el metodo igual
        public int HorasTrabajadas { get; set; }
        public double TarifaHora { get; set; }

        // El constructor debe pasar datos al padre usando ': base'
        public EmpleadoPorHoras(string nombre, string departamento, double salarioBase, int horas, double tarifa)
            : base(nombre, salarioBase, departamento)
        {
            HorasTrabajadas = horas;
            TarifaHora = tarifa;
        }

        // Sobreescribimos el método del padre
        public override double ObtenerSalario() => HorasTrabajadas * TarifaHora;
    }
}




