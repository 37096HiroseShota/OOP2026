namespace DistanceConverter;

internal class ConverterFactory {
    //あらかじめインスタンスを生成し、配列に入れておく
#pragma warning disable IDE0300 // コレクションの初期化を簡略化します
    private readonly static ConverterBase[] _convertBases = {
#pragma warning restore IDE0300 // コレクションの初期化を簡略化します
        new MeterConverter(),
        new FeetConverter(),
        new YardConverter(),
        new InchConverter(),
        new MileConverter(),
        new KilometreConverter(),
    };

    public static ConverterBase? GetInstance(string name) =>
        _convertBases.FirstOrDefault(x => x.IsMyUnit(name));
}