using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_LMS
{
    public interface IData
    {
        void setData(DateTime data);
        DateTime getData();
        string dataString();
    }
}
