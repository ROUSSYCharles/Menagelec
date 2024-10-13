using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagelec.Entities
{
    public class OrderRow : AbstractEntity<OrderRow>
    {
        private Order? _order;
        private Product? _product;
        private int? _quantity;

        public OrderRow(Order? order, Product? product, int? quantity)
        {
            this._order = order;
            this._product = product;
            this._quantity = quantity;
        }

        public Order? getOrder() { return this._order; }
        public OrderRow setOrder(Order order)
        {
            this._order = order;
            return this;
        }

        public Product? getProduct() { return this._product; }
        public OrderRow setProduct(Product product)
        {
            this._product = product;
            return this;
        }

        public int? getQuantity() { return this._quantity; }
        public OrderRow setQuantity(int quantity)
        {
            this._quantity = quantity;
            return this;
        }
    }
}