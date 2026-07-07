using System;
using System.Collections.Generic;
using System.Text;

namespace Temp01 {
    internal class Shop {
        public List<Item> saleItems { get; set; }

        public Shop(string filePath) {
            saleItems = ReadItem(filePath);
        }

        private static IEnumerable<Item> ReadItem(string filePath) {
            var saleItem = new List<Item>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var items = line.Split(',');
                var item = new Item {
                    name = items[0],
                    price = int.Parse(items[1]),
                    stock = int.Parse(items[2]),
                };
                saleItem.Add(item);
            }
            return saleItem;
        }

        public static int Buy(Item item, int quantity) => item.stock - quantity;
    }
}
