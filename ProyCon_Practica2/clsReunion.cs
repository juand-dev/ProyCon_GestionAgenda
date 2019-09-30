using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyCon_Practica2
{
    class clsReunion : clsEntrada
    {
        private string mvarLugar;
        private string mvarHoraInicio;
        private string mvarHoraFin;

        public string MvarLugar
        {
            get => mvarLugar;
            set => mvarLugar = value;
        }

        public string MvarHoraInicio
        {
            get => mvarHoraInicio;
            set => mvarHoraInicio = value;
        }

        public string MvarHoraFin
        {
            get => mvarHoraFin;
            set => mvarHoraFin = value;
        }

        public void Agregar(string strTitulo, string strDescripcion, DateTime dtmFecha, string lugar, string horaInicio, string horaFin)
        {
            base.Agregar(TipoEntrada.Reunion, strTitulo, strDescripcion, dtmFecha);
            this.MvarLugar = lugar;
            this.MvarHoraInicio = horaInicio;
            this.mvarHoraFin = horaFin;
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
            strDatosEntreda.AppendFormat(base.Imprimir() + $"\r\nLugar: {MvarLugar}, Hora Inicio: {MvarHoraInicio}, Hora Fin: {MvarHoraFin}");

            return strDatosEntreda.ToString();
        }
    }
}
