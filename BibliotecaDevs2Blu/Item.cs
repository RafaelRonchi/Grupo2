using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDevs2Blu
{
    internal  class Item
    {
        public int Id { get; set; }
        public int DataEntrada { get; set; }
        public EnumSituacao Situacao { get; set; }
    }
}
