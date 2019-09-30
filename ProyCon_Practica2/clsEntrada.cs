using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ProyCon_Practica2
{
    public enum TipoEntrada {Actividad, Recordatorio, Reunion }

    abstract class clsEntrada
    {
        private TipoEntrada mvarTipo;
        private string mvarTitulo;
        private string mvarDescripcion;
        private DateTime mvarFecha;

        public TipoEntrada MvarTipo
        {
            get => mvarTipo;
            set => mvarTipo = value;
        }

        public string MvarTitulo
        {
            get => mvarTitulo;
            set => mvarTitulo = value;
        }

        public string MvarDescripcion
        {
            get => mvarDescripcion;
            set => mvarDescripcion = value;
        }

        public DateTime MvarFecha
        {
            get => mvarFecha;
            set => mvarFecha = value;
        }

        public void Agregar(TipoEntrada tpoEntrada, string strTitulo, string strDescripcion, DateTime dtmFecha)
        {
            MvarTipo = tpoEntrada;
            MvarTitulo = strTitulo;
            MvarDescripcion = strDescripcion;
            MvarFecha = dtmFecha;
        }

        public virtual void Editar()
        {
        }

        public virtual void Eliminar()
        {
        }

        public virtual string Imprimir()
        {
            var strDatosEntreda = new StringBuilder();
            strDatosEntreda.AppendFormat($"\nTitulo: {MvarTitulo}, Tipo: {MvarTipo} \r\nDescripcion: {MvarDescripcion}, Fecha: {MvarFecha}");

            return strDatosEntreda.ToString();
        }

    }
}
