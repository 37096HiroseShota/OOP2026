using System;
using System.Collections.Generic;
using System.Text;

namespace Temp01 {
    internal class Shop {
        public List<Item> SaleItems { get; }

        public Shop(string filePath) {
            SaleItems = ReadItem(filePath);
        }

        private List<Item> ReadItem(string filePath) {
            var saleItem = new List<Item>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var items = line.Split(',');
                var item = new Item {
                    Name = items[0],
                    Price = int.Parse(items[1]),
                    Stock = int.Parse(items[2]),
                };
                saleItem.Add(item);
            }
            return saleItem;
        }

        public bool Buy(Item item, int quantity) {
            if (item.Stock < quantity)
                return false;

            item.Stock -= quantity;
            return true;
        }
    }
}
