using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
public class Journal
{
    //attribute
    public List<Entry> _entries = new List<Entry>();
    
    //behaviors
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        //loop through _entires and call display on each one
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        //write each entry to the file
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ToFileFormat());
        }
    }
    public void LoadFromFile(string file)
    {
        //current list, read file, entries
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            
            string _date = parts [0];
            string _promptText = parts [1];
            string _text = parts[2];

            Entry entry = new Entry(_date, _promptText,_text);
            _entries.Add(entry);
        }
    }
    
}