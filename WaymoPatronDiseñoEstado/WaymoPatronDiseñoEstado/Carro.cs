using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class Carro
    {
        private IEstadoCarro estado;
        public void SetEstado(IEstadoCarro estado)
        {
            this.estado = estado;
        }
        public void Manejar(Form1 form)
        {
            estado.Manejar(this, form);
        }
    }
}
