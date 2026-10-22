using TextFileProcessor;

string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\Section04\Program.cs";

TextProcessor.Run<FileProgram>(path);

public class FileProgram : TextProcessor {
    private int _count;
    private string _seachWords = "";

    protected override void Initialize(string fileName) {
        _count = 0;
        Console.Write("カウントしたい単語：");
        _seachWords = Console.ReadLine()!;
    }

    protected override void Execute(string line) {
        _count += line.Split(_seachWords).Length -1;    
    }

    protected override void Terminate() =>
        Console.WriteLine($"「{_seachWords}」は{_count}つ出現します");
}