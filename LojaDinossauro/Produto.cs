using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDinossauro
{
    public class Produto
    {
        public Produto(bool produtoOuBrinquedo)
        {
            if (produtoOuBrinquedo)
            {
                tipo = new TipoDinossauroEnum();
            }
            else
            {
                tipo = new TipoBrinquedoEnum();
            }
        }

        public long cod;
        public string imgPath;
        public string nome;
        public double preco;
        public object tipo;
    }

    public enum TipoBrinquedoEnum
    {
        Roupa,
        Matar,
        Biscoito
    }

    public enum TipoDinossauroEnum
    {
        Herbivoro,
        Carnivoro
    }

}
