using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> verses = new List<string>
        {
            "And behold, I am the alight and the life of the world;",
            "and I have drunk out of that bitter cup which the Father hath given me,",
            "and have glorified the Father in taking upon me the sins of the world,",
            "in the which I have suffered the dwill of the Father in all things from the beginning.",

            "And it came to pass that when Jesus had spoken these words the whole multitude afell to the earth;",
            "for they remembered it had been prophesied among them",
            "that Christ should show himself unto them after his ascension into heaven."
        };

        Scripture scrip = new Scripture(verses);
        scrip.Display();

        Random rnd = new Random();
        int length = scrip.GetWordsCount();
        int count = 0;

        Console.WriteLine("");
        Console.WriteLine("Press Enter to hide words, or type quit");


        while (count < length)
        {
            string response = Console.ReadLine();

            if (response == "quit")
            {
                count = length;
            }
            else
            {

                int remaining = length - count;
                int counter = Math.Min(3, remaining);

                // Go through each verse in the list of verses
                foreach (Verse verse in scrip.Verses)
                {
                    int verseRemaining = verse.GetLength() - verse.HiddenWordsCount();

                    if (verseRemaining >= counter)
                    {
                        int verseCounter = 0;
                        while (verseCounter < counter)
                        {
                            int index = rnd.Next(0, verse.GetLength());
                            Word word = verse.Words[index];
                            if (char.IsLetter(word._text[0]) && !word.IsHidden())
                            {
                                word._hidden = true;
                                count++;
                                verseCounter++;
                            }
                        }
                    }
                }

                scrip.Display();

                if (count == length)
                {
                    Console.WriteLine("All words have been replaced.");
                    break;
                }
            }
        }

    }
}
