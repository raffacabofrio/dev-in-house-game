public class StoryTeller{
    public string Narrador;
    public ConsoleColor BackgroundColor;
    public ConsoleColor ForegroundColor;
    public readonly int time = 500;
    public StoryTeller(ConsoleColor backgroundColor, ConsoleColor foregroundColor, string narrador)
    {
        BackgroundColor = backgroundColor;
        ForegroundColor = foregroundColor;
        Narrador = narrador;
    }

    public void Speak(string texto)
    {

        Thread.Sleep(time);
        
        Build();
        Console.WriteLine(Narrador + texto);
        Destroy();

        Thread.Sleep(time);
        
    }
    public void Build(){
        Console.BackgroundColor = BackgroundColor;
        Console.ForegroundColor = ForegroundColor;
    }
    public void Destroy()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }

}
public class BattleStoryTeller : StoryTeller
{
    public BattleStoryTeller() : base(ConsoleColor.Black, ConsoleColor.Red, "[Batalha]: ") { }

}
public class FlowStoryTeller : StoryTeller
{
    public FlowStoryTeller() : base(ConsoleColor.Black, ConsoleColor.Yellow, "[Narrador]: ") { }

}
public class GameStoryTeller : StoryTeller
{
    public GameStoryTeller() : base(ConsoleColor.Black, ConsoleColor.Blue, "[Game]: ") { }

}