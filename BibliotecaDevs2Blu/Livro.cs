using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDevs2Blu
{
    public class Livro : I_Item
    {
        public int Id { get; set; }
        public int DataEntrada { get; set; }
        public EnumSituacao Situacao { get; set; }
        public string Titulo { get; set; }
        public int NumeroPaginas { get; set; }
        public DateTime DataLancamento { get; set; }


        public Livro(string titulo)
        {
            Titulo = titulo;
        }
    }
}
