using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_LMS
{
    public class Produto : IData
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime DataDeValidade { get; set; }

        public void setData(DateTime data)
        {
            DataDeValidade = data.AddDays(100);
        }

        public DateTime getData()
        {
            return DataDeValidade;
        }

        public string dataString()
        {
            return $"{DataDeValidade.ToString("dd/MM/yyyy")}";
        }
    }
}
