using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyCon_Practica2
{
    class clsRecordatorio : clsEntrada
    {
        private string mvarFrecuencia;

        public string MvarFrecuencia
        {
            get => mvarFrecuencia;
            set => mvarFrecuencia = value;
        }

        public void Agregar(string strTitulo, string strDescripcion, DateTime dtmFecha, string strFrecuncia)
        {
            base.Agregar(TipoEntrada.Recordatorio, strTitulo, strDescripcion, dtmFecha);
            mvarFrecuencia = strFrecuncia;            
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
            strDatosEntreda.AppendFormat(base.Imprimir() + $"\r\nFrecuencia: {MvarFrecuencia}");

            return strDatosEntreda.ToString();
        }
    }
}
