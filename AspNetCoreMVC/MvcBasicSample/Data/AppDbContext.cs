using Microsoft.EntityFrameworkCore;   // EF Coreを使用
using MvcBasicSample.Models;           // Productを使用

namespace MvcBasicSample.Data;

// EF Coreを使ってデータベースへ接続するクラス
public class AppDbContext : DbContext {

    //Program.csで登録した接続設定を受け取る
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) {              //受け取った設定を親クラスへ　渡す
    }

    // ProductsテーブルをProduct型として問い合わせるためのプロパティ
    public DbSet<Product> Products => Set<Product>();
}
