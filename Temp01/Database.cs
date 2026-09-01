using Microsoft.Data.Sqlite;

namespace SQLiteProductSample;

//SQLiteデータベースへの接続と初期化を担当するクラス
public static class Database {
    //DBファイルの保存場所
    private static readonly string DatabasePath =
        Path.Combine(AppContext.BaseDirectory, "Users.db");

    //SQLiteへ接続するための接続文字列
    private static readonly string ConnectionString =
        $"Data Source={DatabasePath}";

    //DBファイルの保存場所を外部から確認するための読み取り専用プロパティ
    public static string FilePath => DatabasePath;

    //新しいSQLiteConnectionを生成して返す
    public static SqliteConnection GetConnection() {
        return new SqliteConnection(ConnectionString);
    }

    //DBの初期化処理
    public static void Initialize() {
        //接続オブジェクトを生成する。
        using var connection = GetConnection();

        //DBを開く
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();

        command.CommandText =
        """
        CREATE TABLE IF NOT EXISTS Users (
            UserId    INTEGER PRIMARY KEY AUTOINCREMENT,
            UserName  TEXT NOT NULL
        );
        """;

        command.ExecuteNonQuery();
    }
}
