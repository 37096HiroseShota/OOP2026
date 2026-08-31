using Microsoft.Data.Sqlite;

namespace SQLiteProductSample;

// Prosuctテーブルに対するDB操作をまとめたクラス
// CRUD (Create / Read / Update / Delete) を担当する
public class ProductRepository {
    public List<Product> GetAll() {
        var products = new List<Product>();

        using var connectioin = Database.GetConnection();
        connectioin.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connectioin.CreateCommand();

        command.CommandText =
        """
        SELECT Id, Name, Price
        FROM Products
        ORDER BY Id;
        """;

        //SELECTを実行し、複数行の検索結果を読み取る
        using var reader = command.ExecuteReader();

        while (reader.Read()) {
            products.Add(new Product {
                Id = reader.GetInt32(0), //0列目: Id
                Name = reader.GetString(1), //1列目: Name
                Price = reader.GetInt32(2) //2列目: Price
            });
        }

        return products;
    }

    public void Add(string name, int price) {
        using var connection = Database.GetConnection();
        connection.Open();


        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();

        command.CommandText =
        """
        INSERT INTO Products (Name, Price)
        VALUES ($name, $price);
        """;

        command.Parameters.AddWithValue("$name", name);
        command.Parameters.AddWithValue("$price", price);

        //結果行を返さないSQLを実行する
        command.ExecuteNonQuery();
    }

    public void Update(Product product) {
        using var connection = Database.GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText =
        """
        UPDATE Products
        SET Name = $name,
            Price = $price
        WHERE Id = $id;
        """;

        command.Parameters.AddWithValue("$name", product.Name);
        command.Parameters.AddWithValue("$price", product.Price);
        command.Parameters.AddWithValue("$Id", product.Id);

        command.ExecuteNonQuery();
    }
}
