// See https://aka.ms/new-console-template for more information
Console.WriteLine("Stack II");

EditorTexto editor = new EditorTexto();

Console.WriteLine("\n Digitando...");

editor.DigitarChar('S');
editor.DigitarChar('t');
editor.DigitarChar('a');
editor.DigitarChar('c');
editor.DigitarChar('q');

Console.WriteLine("\nFazendo o Undo... \n");
editor.Undo();
editor.Undo();

Console.WriteLine("\nRedigitando ... \n");
editor.DigitarChar('c');
editor.DigitarChar('k');


public class EditorTexto
{
    private Stack<char> undoStack = new Stack<char>();
    private string texto = "";

    public void DigitarChar(char c)
    {
        texto += c;
        undoStack.Push(c);
        Console.WriteLine($"Texto : {texto}");
    }

    public void Undo()
    {
        if(undoStack.Count() > 0)
        {
            char ultimoChar = undoStack.Pop();
            texto = texto.Substring(0, texto.Length - 1);
            Console.WriteLine($"Texto : {texto}");
        }
    }
}

