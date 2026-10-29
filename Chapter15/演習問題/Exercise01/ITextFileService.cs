namespace Exerceise03;

public interface ITextFileService {
    void Initialize();
    bool Execute(string line);
    void Terminate();
}