using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDinossauro
{
    class Pedido
    {
        public long cod;
        public List<Produto> produtos;
    }

    public static class Global
    {
        public static List<Produto> produtos;
    }
}
