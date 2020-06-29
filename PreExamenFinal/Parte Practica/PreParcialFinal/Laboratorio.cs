using System;

namespace DefaultNamespace
{
    public class Laboratorio : Evaluacion
    {
        private String tipo;

        public Laboratorio(int porcentaje, string nombre, string tipo) : base(porcentaje, nombre)
        {
            this.tipo = tipo;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(tipo)}: {tipo}";
        }
    }
}