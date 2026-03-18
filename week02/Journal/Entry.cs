public class Entry 
{
    //attributes
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string prompt, string text)
    {
        _date = date;
        _promptText = prompt;
        _entryText = text;
    }  

    //function
    public void Display()
    {
        //print the entry
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();  
    }
    public string ToFileFormat()
    {
        return ($"{_date}|{_promptText}|{_entryText}");
    }
}