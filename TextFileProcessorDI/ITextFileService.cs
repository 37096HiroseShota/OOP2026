namespace TextFileProcessorDI;

public interface ITextFileService {
    void Initialize(string fileName);
    void Execute(string line);
    void Terminate();
}
