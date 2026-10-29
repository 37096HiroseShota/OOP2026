using Exerceise03;

internal class Take20Processor : ITextFileService {
    private int _count;

    public void Initialize() {
        _count = 0;
    }

    public bool Execute(string line) {
        if (_count < 20) {
            Console.WriteLine(line);
        }
        _count++;

        return (_count <= 20);
    }

    public void Terminate() {
    }
}