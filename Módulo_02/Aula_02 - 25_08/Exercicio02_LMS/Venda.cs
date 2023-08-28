using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_LMS
{
    public class Venda : IData
    {
        public DateTime Data { get; set; }
        public Produto Produto { get; set; }

        public string dataString()
        {
            return $"{Data.ToString("dd/MM/yyyy")}";
        }

        public DateTime getData()
        {
            return Data;
        }

        public void setData(DateTime data)
        {
            Data = data;
        }
    }
}
