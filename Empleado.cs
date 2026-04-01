using System;

namespace GestorTareas
{
    public class Empleado
    {
        // 1. Propiedades automáticas (Nivel de clase, NO dentro de métodos)
        public string Nombre { get; set; }
        public string Departamento { get; set; }

        // 2. Campo protegido para que las clases hijas lo vean
        protected double _salarioBase;

        // 3. Propiedad con lógica (get/set) para el campo protegido
        public double SalarioBase
        {
            get { return _salarioBase; }
            set { _salarioBase = value; }
        }

        // 4. Constructor de la clase
        public Empleado(string nombre, double salarioBase, string departamento)
        {
            Nombre = nombre;
            _salarioBase = salarioBase;
            Departamento = departamento;
        }

        // 5. Método para obtener salario (marcado como 'virtual' para poder sobreescribirlo)
        public virtual double ObtenerSalario() => _salarioBase;

        public virtual decimal CalcularBonificacion()
        {
            return (decimal)SalarioBase * 0.05m;
        }
    }
}