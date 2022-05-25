using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace LojaDinossauro
{
    // TODO: Melhorar Produto
    public class Produto
    {
        public long cod;
        public string nome;
        public double preco;
        public string descricao;
        public List<Enum> tipo = new List<Enum>();

        /*public Enum tipo
        {
            get
            {
                foreach (var tipo in tipoPrivate)
                    return this.tipo = tipo;

                return null;
            }

            set
            {
                tipoPrivate.Add(value);
            }
        }*/

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

    [Flags]
    public enum TipoProdutoEnum
    {
        Herbivoro = 1,
        Carnivoro = 2,
        Bipede = 4,
        Quadrupede = 8,
        Espinhos = 16,
        Aquatico = 32,
        Voador = 64,

        Roupa = 128,
        Matar = 256,
        Biscoito = 512
    }
}
