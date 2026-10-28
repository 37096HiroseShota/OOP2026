namespace Exerceise03;

internal class TextFileProcessor {
    private ITextFileService _service;

    public TextFileProcessor(ITextFileService service) {
        _service = service;
    }

    public void Run(string filename) {
        var lines = File.ReadLines(filename);

        foreach (var line in lines.Take(20)) {
            _service.Execute(line);
        }
    }
}
