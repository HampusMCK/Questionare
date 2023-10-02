
Player p = new();

Question q1 = new();

q1.Text = "1+4";
q1.alternatives = new List<string>() { "5", "3", "1" };
q1.CorrectAnswer = 0;

Question q2 = new()
{
    Text = "2-1",
    alternatives = new List<string>() { "3", "5", "1" },
    CorrectAnswer = 2,
};

int guessTry = 0;

while (guessTry < 2)
{
    if (q1.Ask())
    {
        p.Score++;
    }
    else
    {
        guessTry++;
    }
    if (q2.Ask())
    {
        p.Score++;
    }
    else
    {
        guessTry++;
    }
    Console.WriteLine("Congratulations, you passed all questions!!");
}
Console.WriteLine("Sorry, but you did not pass :(");

Console.ReadLine();