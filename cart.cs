using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart
{
    public class cart
    {
        public List<Item> items;

        public cart()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            var existingItem = items.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.quantity += item.quantity;
            }
            else
            {
                items.Add(item);
            }
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.Price * item.quantity;
            }
            return total;
        }
    }
}