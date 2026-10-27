namespace DistanceConverter;

public class DistanceConverter {
    public ConverterBase From {  get; init; }
    public ConverterBase To { get; init; }

    //コンストラクタ
#pragma warning disable IDE0290 // プライマリ コンストラクターの使用
    public DistanceConverter(ConverterBase from, ConverterBase to) {
        From = from;
        To = to;
    }
#pragma warning restore IDE0290 // プライマリ コンストラクターの使用

    public double Convert(double value) {
        var meter = From.ToMeter(value);   //変換元の単位からメートルへ変換
        return To.FromMeter(meter);        //メートルから変換先の単位へ変換
    }
}