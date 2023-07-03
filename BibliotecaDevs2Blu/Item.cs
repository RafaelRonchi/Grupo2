using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDevs2Blu
{
    public  interface I_Item
    {
        int Id { get; set; }
        DateTime DataEntrada { get; set; }
        EnumSituacao Situacao { get; set; }
    }
}
