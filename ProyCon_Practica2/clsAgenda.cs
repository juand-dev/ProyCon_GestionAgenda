using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyCon_Practica2
{
    class clsAgenda
    {
        private string mvarDueño;
        private int mvarAño;
        private List<clsEntrada> lstEntradas = new List<clsEntrada>();
       

        public clsAgenda() { }

        public clsAgenda(string mvarDueño, int mvarAño)
        {
            this.mvarDueño = mvarDueño;
            this.mvarAño = mvarAño;
        }

        public string MvarDueño
        {
            get => mvarDueño;
            set => mvarDueño = value;
        }

        public int MvarAño
        {
            get => mvarAño;
            set => mvarAño = value;
        }

        public List<clsEntrada> LstEntradas
        {
            get => lstEntradas;
            set => lstEntradas = value;
        }

        public void Agregar(string strDueño, int intAño, List<clsEntrada> lstEntradas)
        {
            MvarDueño = strDueño;
            MvarAño = intAño;
            LstEntradas = lstEntradas;
        }

        public string Mostrar(DateTime dtmFechaInicio, DateTime dtmFechaFin)
        {
            StringBuilder strCadena = new StringBuilder();

            strCadena.AppendFormat($"\nDueño: {MvarDueño} \nAño: {MvarAño} \r\n");

            foreach (clsEntrada item in LstEntradas)
            {
                if (item.MvarFecha > dtmFechaInicio && item.MvarFecha < dtmFechaFin)
                {
                    strCadena.AppendFormat($"\nDatos de Entrada: {item.Imprimir()}\n");
                }
            }
            return strCadena.ToString();
        }
    }
}
