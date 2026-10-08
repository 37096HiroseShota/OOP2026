using System.ComponentModel.DataAnnotations;

namespace MvcBasicSample.Models;

public class Product {
    public int Id { get; set; }   // 主キー

    // 商品名を必須の項目として扱う
    [Required]
    public string Name { get; set; } = string.Empty;

    public int Price { get; set; }   // 円単位の価格

    public int Stock { get; set; }

    [Required]
    public string Description { get; set; } = string.Empty;
}