using System;
namespace GestorTareas
{
    public abstract class Tarea
    {
        public Guid id { get; }
        public string Titulo { get; }
        public string Descripcion { get; }
        public DateTime FechaCreacion { get; }
        public DateTime FechaLimite { get; }
        public PrioridadTarea Prioridad { get; }

        private EstadoTarea _estado;
        public EstadoTarea Estado => _estado;
        private string _motivoCancelacion;

        protected Tarea(string titulo, DateTime fechaLimite,
            PrioridadTarea prioridad, string descripcion = null)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentException("El titulo es obligatorio");
            if (fechaLimite.Date < DateTime.Today)
                throw new ArgumentException(
                    "La fecha limite no puede ser anterior a hoy");

            Id = Guid.NewGuid();
            Titulo = titulo.Trim();
            Descripcion = descripcion ?.Trim() ?? string.Empty();
            FechaCreacion = DateTime.Now;
            FechaLimite = fechaLimite.Date;
            Prioridad = prioridad;
            _estado = EstadoTarea.Pendiente;
        }

        public bool Iniciar()
        {
            if (_estado != EstadoTarea.Pendiente) return false;
            _estado = EstadoTarea.EnProgreso;
            return true;
        }

        public bool Completar()
        {
            if (_estado == EstadoTarea.Completada ||
                _estado == EstadoTarea.Cancelada) return false;
            _estado = EstadoTarea.Completada;
            return true;

        }

        public bool Cancelar(string motivo)
        {
            if (_estado == EstadoTarea.Cancelada) return false;
            _estado = EstadoTarea.Cancelada;
            _motivoCancelacion = motivo ?? "Sin especificar";
            return true;
        }
        //Definir que clase de tareas vamos a utilizar, eso dijo el profesor
        public abstract string ObtenerResumen();
        //Hecho hasta la diapositiva 40, terminar en casa
    }
}
