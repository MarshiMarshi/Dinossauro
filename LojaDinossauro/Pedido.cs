using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDinossauro
{
    class Pedido
    {
        public Pedido(Produto produto)
        {
            this.produtos.Add(produto);
        }

        public long cod;
        public double preco;
        public List<Produto> produtos = new List<Produto>();
    }

    public static class Global
    {
        public static List<Produto> produtos = new List<Produto>();
    }
}
