using System;

namespace GestorTareas
{
    public class Desarrollador : Empleado
    {
        const int BONIFICACION_POR_CERTIFICACION = 500;
        public int Certificaciones { get; set; }
        //Constructor
        public Desarrollador(
            string nombre,
            double salarioBase,
            string departamento,
            int certificaciones) : base(nombre, salarioBase, departamento)
        {
            Certificaciones = certificaciones;
        }
        public override decimal CalcularBonificacion()
            //No hay que usar numeros magicos, hay que usar constantes
        {
            return base.CalcularBonificacion() * (500 * Certificaciones);
        }
    }
}