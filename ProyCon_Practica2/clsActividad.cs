using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyCon_Practica2
{
    class clsActividad : clsEntrada
    {
        private string mvarHora;
        private int mvarDuracion;

        public string MvarHora
        {
            get => mvarHora;
            set => mvarHora = value;
        }

        public int MvarDuracion
        {
            get => mvarDuracion;
            set => mvarDuracion = value;
        }

        public void Agregar(string strTitulo, string strDescripcion, DateTime dtmFecha, string hora, int duracion)
        {
            base.Agregar(TipoEntrada.Actividad, strTitulo, strDescripcion, dtmFecha);
            this.MvarHora = hora;
            this.MvarDuracion = duracion;
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Eliminar()
        {
            throw new NotImplementedException();
        }

        public override string Imprimir()
        {
            var strDatosEntreda = new StringBuilder();
            strDatosEntreda.AppendFormat(base.Imprimir() + $"\r\nHora: {MvarHora}, Duracion: {MvarDuracion}");

            return strDatosEntreda.ToString();
        }
    }
}
