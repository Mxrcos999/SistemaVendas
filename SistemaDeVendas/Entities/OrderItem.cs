using projetoVendas.data;
using projetoVendas.views;
using System;
using System.ComponentModel.DataAnnotations;

namespace Order
{
    public class OrderItem : EntityBase
    {
        public Product Product { get; private set; }
        public int Quantity { get; private set; }

        public decimal UnitaryValue { get; set; }
        public decimal TotalValue => Quantity * UnitaryValue;

        public OrderItem(int quantity)
        {
         //   Product = product;

            if (quantity <= 0)
                throw new OrderException("Quantidade inválida. Informe uma quantidade igual ou superior a um.");


          //  Quantity = quantity;
            base.DateHourRegister = DateTime.Now;
          //  product.RemoveAvailableQuantity(quantity);
            var teste = new Frm_CadastrarVenda();
          //  teste.recebevalor(TotalValue);
        }
        public void recebeDado(decimal valorUnitario, int id, int idprodut, int quantidade)
        {
            UnitaryValue = valorUnitario;
            Quantity = quantidade;
            var cadastra = new SQLServerClass();
            cadastra.SQLCommandInsert($"INSERT INTO Vendas(idCliente, idProduto, QuantidadeProduto, ValorTotal) VALUES({id}, {idprodut}, {quantidade}, {TotalValue})");


        }
    }
}
