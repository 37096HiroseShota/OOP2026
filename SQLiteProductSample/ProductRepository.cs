using Microsoft.Data.Sqlite;

namespace SQLiteProductSample;

public class ProductRepository {
    public List<Product> GetAll() {
        var products = new List<Product>();

        using var connectioin = Database.GetConnection();
        connectioin.Open();

        using var command = connectioin.CreateCommand();
        command.CommandText =
        """
        SELECT id, Name, Price
        FROM Products
        ORDER BY Id;
        """;

        using var reader = command.ExecuteReader();

        while (reader.Read()) {
            products.Add(new Product {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Price = reader.GetInt32(2)
            });
        }

        return products;
    }
}


