using SelfOrderSystem.Models; // カートの商品情報の型を使う 

namespace SelfOrderSystem.Services;

// 注文処理に必要なメソッドを定義 
public interface IOrderService {
    // 注文を確認してDBへ保存する
    Task<PlaceOrderResult> PlaceAsync(
      List<CartItem> cartItems, // Sessionから取得したカート 
      int tableNumber); // 入力されたテーブル番号 
}