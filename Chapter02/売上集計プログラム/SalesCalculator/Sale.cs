namespace SalesCalculator;

//売り上げクラス
public class Sale {
    //店舗名
    public String ShopName { get; set; } = string.Empty;
    //商品カテゴリー
    public String ProductCategory { get; set; } = string.Empty;
    //売上高
    public int Amount { get; set; }
}
