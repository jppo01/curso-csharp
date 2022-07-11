using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_02
{
    public class Data
    {
        private DateTime _data { get; set; }


        public Data(DateTime data)
        {
            DateTime dataAtual = DateTime.Now;

            if (data.Day == dataAtual.Day && data.Month == dataAtual.Month && data.Year == data.Year)
            {
                _data = data;
            }
            else
            {
                _data = Convert.ToDateTime("01/01/0001");
            }

        }
        public int compare(DateTime data)
        {
            int resultado = 0;

            if (data < DateTime.Now)
            {
                resultado = 1;
            }
            if (data > DateTime.Now)
            {
                resultado = -1;
            }
            if (DateTime.Now.ToString("dd/MM/yyyy") == data.ToString("dd/MM/yyyy"))
            {
                resultado = 0;
            }

            return resultado;
        }
        public int getDia()
        {
            return _data.Day;
        }

        public int getMes()
        {
            return _data.Month;
        }
        public string getMesExtenso()
        {
            //Lembrando que "MM" -> 07, "MMM" -> jul, "MMMM" -> julho;
            return _data.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br"));
        }

        public int getAno()
        {
            return _data.Year;
        }
        public bool isBissexto()
        {
            return DateTime.IsLeapYear(_data.Year);
        }
    }
}