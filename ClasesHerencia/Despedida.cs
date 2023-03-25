using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    internal class Despedida : Usuario
    {
        /// <summary>
        /// Sueldo del docente modificado
        /// </summary>
        public decimal Sueldo { get; set; }

        public override string ToString()
        {
            return $"Cuenta: {Cuenta} | Pass: {Password} | Nombre: {Nombre} | Sueldo: {Sueldo}";
        }
    }
}
