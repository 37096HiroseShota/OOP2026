using System.ComponentModel;

namespace Temp01 {
    public class Product {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("商品名")]
        public String Name { get; set; }

        [DisplayName("商品価格")]
        public int Price { get; set; }
    }
}
