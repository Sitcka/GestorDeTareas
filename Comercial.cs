using System;

namespace GestorTareas
{
    public class Comercial: Empleado
    {
       public int VentasCerradas { get; set; }
        //Constructor
        public Comercial(
            string nombre, 
            double salarioBase, 
            string departamento, 
            int ventasCerradas) : base(nombre, salarioBase, departamento)
        {
            VentasCerradas = ventasCerradas;
        }
        public override decimal CalcularBonificacion()
        {
            decimal bonificacionPorVentas = (decimal) SalarioBase * 0.02m* VentasCerradas;
            return base.CalcularBonificacion() + bonificacionPorVentas;
        }
    }
}