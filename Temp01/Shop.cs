using System;
using System.Collections.Generic;
using System.Text;

namespace Temp01 {
    internal class Shop {
        public IEnumerable<Item> _items {  get; set; }

        public Shop(string filePath) {
            _items = ReadItem(filePath);
        }

        private static IEnumerable<Item> ReadItem(string filePath) {
            var saleItem = new List<Item>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var saleItems = line.Split(',');
                var item = new Item {
                    name = saleItems[0],
                    price = int.Parse(saleItems[1]),
                    stock = int.Parse(saleItems[2]),
                };
                saleItem.Add(item);
            }
            return saleItem;
        }

        public static int Buy(Item item, int buyAmount) => item.stock - buyAmount;
    }
}
