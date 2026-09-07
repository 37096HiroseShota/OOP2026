using System.Drawing.Imaging;
using System.Globalization;

namespace CarReportSystem {
    public class CarReportRepository {
        public List<CarReport> GetAll() {
            var carReports = new List<CarReport>();

            using var connectioin = Database.GetConnection();

            connectioin.Open();

            using var command = connectioin.CreateCommand();

            command.CommandText =
            """
        　　SELECT Id, Date, Author, Maker, CarName, Report, Picture
        　　FROM CarReports
        　　ORDER BY Id;
        　　""";

            using var reader = command.ExecuteReader();

            while (reader.Read()) {
                carReports.Add(new CarReport {
                    Id = reader.GetInt32(0),
                    Date = DateTime.ParseExact(
                        reader.GetString(1),
                        "yyy-MM-dd",
                        CultureInfo.InvariantCulture),

                    Author = reader.GetString(2),
                    Maker = (CarReport.MakerGroup)reader.GetInt32(3),
                    CarName = reader.GetString(4),
                    Report = reader.GetString(5),
                    Picture = reader.Get(6)
                });
            }

            return carReports;
        }

        public int Add(DateTime date, string author, CarReport.MakerGroup maker, string carname, string report, Image picture) {
            using var connection = Database.GetConnection();

            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText =
            """
            INSERT INTO CarReports
            (Date, Author, Maker, CarName, Report, Picture)
            VALUES ($date, $author, $maker, $carName, $report, $picture);

            SELECT last_insert_rowid();
            """
            ;

            command.Parameters.AddWithValue("$date", date);
            command.Parameters.AddWithValue("$author", author);
            command.Parameters.AddWithValue("$maker", maker);
            command.Parameters.AddWithValue("$carname", carname);
            command.Parameters.AddWithValue("$report", report);
            command.Parameters.AddWithValue("$picture", picture);

            var result = command.ExecuteScalar();

            if (result is null)
                throw new InvalidOperationException("登録したカーレポートのIDを取得できませんでした。");

            return Convert.ToInt32((long)result);
        }

        public void Update(CarReport carReport) {
            using var connection = Database.GetConnection();

            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText =
            """
            UPDATE CarReports
            SET Date = $date, Author = $author, Maker = $maker,
                CarName = $carName, Report = $report, Picture = $picture
            WHERE Id = $id;
            """;
            command.Parameters.AddWithValue("$date", carReport.Date);
            command.Parameters.AddWithValue("$author", carReport.Author);
            command.Parameters.AddWithValue("$maker", carReport.Maker);
            command.Parameters.AddWithValue("$carname", carReport.CarName);
            command.Parameters.AddWithValue("$report", carReport.Report);
            command.Parameters.AddWithValue("$picture", carReport.Picture);

            command.ExecuteNonQuery();
        }

        public void Delete(int id) {
            using var connection = Database.GetConnection();

            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText =
            """
            DELETE FROM CarReports
            WHERE Id = $id;
            """;

            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        // ImageをSQLiteへ保存できるbyte[]へ変換する
        private static byte[]? ImageToBytes(Image? image) {
            if (image is null) return null;

            using var stream = new MemoryStream();
            // DBへはPNG形式で保存
            image.Save(stream, ImageFormat.Png);
            return stream.ToArray();
        }

        // SQLiteのBLOB（byte[]）をImageへ変換する
        private static Image BytesToImage(byte[] data) {
            using var stream = new MemoryStream(data);
            using var image = Image.FromStream(stream);
            // MemoryStream破棄後も利用できるようBitmapとしてコピーする。
            return new Bitmap(image);
        }
    }
}