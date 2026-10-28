namespace DistanceConverter;

internal class ConverterFactory {
    //あらかじめインスタンスを生成し、配列に入れておく
    private readonly static ConverterBase[] _convertBases = {
        new MeterConverter(),
        new FeetConverter(),
        new YardConverter(),
        new InchConverter(),
        new MileConverter(),
        new KilometreConverter(),
    };

    public static ConverterBase? GetInstance(string name) => _convertBases.FirstOrDefault(x => x.IsMyUnit(name));
}