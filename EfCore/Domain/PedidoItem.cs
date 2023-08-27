using System.ComponentModel.DataAnnotations.Schema;

namespace EfCore.Domain
{
    [Table("PedidoItem")]
    public class PedidoItem
    {
        public int Id {get; set;}
        public int PedidoId {get; set;}
        public Pedido Pedido {get; set;}
        public int ProdutoId {get; set;}
        public Produto Produto {get; set;}
        public decimal Quantidade {get; set;}
        public decimal Valor {get; set;}
        public decimal Desconto {get; set;}
    }
}