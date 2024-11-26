﻿
using IFSPStore.Domain.Base;
using System.Text.Json.Serialization;

namespace IFSPStore.Domain.Entities
{
    public class Venda : BaseEntity<int>
    {
        public Venda()  
        { 
            Items = new List<VendaItem>();
        }
        public Venda(int id, DateTime data, float valorTotal, Usuario? usuario, Cliente? cliente, List<VendaItem> items) : base(id)
        {
            Data = data;
            ValorTotal = valorTotal;
            Usuario = usuario;
            Cliente = cliente;
            Items = items;
           
        }
        public DateTime Data {  get; set; }
        public float ValorTotal { get; set; }
        public Usuario? Usuario { get; set; }
        public Cliente? Cliente { get; set; }
        public virtual List<VendaItem> Items { get; set; }
    }
    public class VendaItem : BaseEntity<int>
    {
        public VendaItem()
        {
        }
        public VendaItem(int id, Produto? produto, int quantidade, float valorUnitario, float valortotal, Venda? venda) : base(id)
        {
            
            Produto = produto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            ValorTotal = valortotal;
            Venda = venda;

        }
        public Produto? Produto { get; set; }
        public int Quantidade {  get; set; }
        public float ValorUnitario { get; set; }
        public float ValorTotal { get; set; }
        [JsonIgnore]
        public virtual Venda? Venda {  get; set; }

    }

}
