using System.ComponentModel.DataAnnotations.Schema;
using EfCore.ValueObjects;
namespace EfCore.Domain
{
    [Table("Pedidos")]
    public class Pedido
    {
        public int Id {get; set;}
        public int ClientId {get; set;}
        public Cliente Cliente {get; set;}
        public DateTime IniciadoEm {get; set;}
        public DateTime FinalizadoEm {get; set;}
        public TipoFrete TipoFrete {get; set;}
        public StatusPedido Status {get; set;}
        public ICollection<PedidoItem> Itens {get; set;}
    }   
}