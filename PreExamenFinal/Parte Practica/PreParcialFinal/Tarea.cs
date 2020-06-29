using System;

namespace DefaultNamespace
{
    public class Tarea : Evaluacion
    {
        private DateTime fechaEntrega { get; }

        public Tarea(int porcentaje, string nombre, DateTime fechaEntrega) : base(porcentaje, nombre)
        {
            this.fechaEntrega = fechaEntrega;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(fechaEntrega)}: {fechaEntrega.ToShortDateString()}";
        }
    }
}