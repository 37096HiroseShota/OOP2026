namespace TextFileProcessorDI;

internal class LineCounterService : ITextFileService {
    private int _count = 0;

    public void Initialize(string fileName) => _count = 0;

    public void Execute(string line) => _count++;

    public void Terminate() => Console.WriteLine("{0} 行", _count);
}