using System;

class RandomPromptGenerator
{
    public List<string> promptList;

    public RandomPromptGenerator(List<string> promptList)
    {
        this.promptList = promptList;
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(promptList.Count);
        return promptList[index];
    }
}