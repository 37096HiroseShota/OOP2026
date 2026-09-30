var builder = WebApplication.CreateBuilder(args);

// ControllerとViewを使うMVCの機能を登録する
builder.Services.AddControllersWithViews();

var app = builder.Build();   // 登録した設定から実行用のアプリを作成

// 開発環境以外で使うエラー画面とHTTPSの設定
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();   // HTTPからHTTPSへ転送
app.UseStaticFiles();        // wwwrootにあるCSSやJavaScriptなどを配信
app.UseRouting();            // URLとControllerのActionを対応付ける
app.UseAuthorization();      // 設定されているアクセス許可を確認

// URLをControllerとActionに対応付ける
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();                   // Webサーバーを起動して要求の受信を開始
