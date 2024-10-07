using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagelec.Entities
{
    public class Order : AbstractEntity
    {
        private readonly int _id;
        private DateTime _date;
        private List<OrderRow> _orderRows = new List<OrderRow>();
        private bool _isPayed;
        private bool _isExpedited;
        private Client _client;
       

        public int getId() { return this._id; }
       

        public List<OrderRow> getOrderRows() { return this._orderRows; }
        public Order addOrderRow(OrderRow orderRow)
        {
            this._orderRows.Add(orderRow);
            return this;
        }
        public Order setOrderRows(List<OrderRow> orderRows)
        {
            this._orderRows = orderRows;
            return this;
        }

        public bool isPayed() { return this._isPayed; }
        public Order setIsPayed(bool isPayed)
        {
            this._isPayed = isPayed;
            return this;
        }

        public bool isExpedited() { return this._isExpedited; }
        public Order setIsExpedited(bool isExpedited)
        {
            this._isExpedited = isExpedited;
            return this;
        }

        public Client getClient() { return this._client; }
        public Order setClient(Client client)
        {
            this._client = client;
            return this;
        }
    }
}