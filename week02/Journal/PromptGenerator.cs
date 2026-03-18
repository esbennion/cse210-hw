using System.ComponentModel;
using System.Runtime.CompilerServices;

public class PromptGenerator
{
    //attribute 
    List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the most important part of my day?",
        "How did I see the hand of the LOrd in my life today?",
        "What was I proud that I accomplished today?",
        "If I could redo anything over again today what would it be?"
    };

    //method
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}