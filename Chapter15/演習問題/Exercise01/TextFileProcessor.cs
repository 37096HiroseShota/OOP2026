namespace Exerceise03;

internal class TextFileProcessor {
    private ITextFileService _service;

    public TextFileProcessor(ITextFileService service) {
        _service = service;
    }

    public void Run(string filename) {
        _service.Initialize();
        var lines = File.ReadLines(filename);
        foreach (var line in lines) {
            if (!_service.Execute(line)) {
                break;
            }
        }
        _service.Terminate();
    }
}