
using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public Produto()
        {   
        }
        public Produto(int id, string nome, float preco, int quantidade, DateTime datacompra, string unidadevenda)  
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Datacompra = datacompra;
            UnidadeVenda = unidadevenda;
        }
        public string? Nome { get; set; }
        public float? Preco {  get; set; }
        public int? Quantidade { get; set; }
        public DateTime? Datacompra { get; set; }
        public string? UnidadeVenda { get; set; }
        public object Grupo { get; set; }
    }
}
