using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace LojaDinossauro
{
    public class Produto
    {
        public long cod;
        public string nome;
        public double preco;
        public string descricao;
        public List<Enum> tipo = new List<Enum>();
        public Image img;
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
        Carnivoro,
        Bipede,
        Quadrupede,
        Espinhos,
        Aquatico,
        Voador
    }
}
