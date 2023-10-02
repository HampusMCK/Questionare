class Question
{
    public string Text;
    public List<string> alternatives;
    public int CorrectAnswer;

    public bool Ask()
    {
        Console.Clear();
        // Ställ frågan
        Console.WriteLine(Text);
        //Visa alternativen (foreach)
        int i = 1;
        string answer;
        int guess;
        foreach (string alternatives in alternatives)
        {
            Console.WriteLine($"{i}. {alternatives}");
            i++;
        }

        // Läs in ett svar
        Console.WriteLine("write your guess (1, 2 or 3)");
        answer = Console.ReadLine();
        int.TryParse(answer, out guess);
        guess--;

        // Om svaret är rätt, returnera true
        if (guess == CorrectAnswer)
        {
            Console.WriteLine("Correct!");
            return true;
        }
        else
        {
            Console.WriteLine("Wrong!");
            return false;
        }
    }
}