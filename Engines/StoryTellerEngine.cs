public class StoryTellerEngine{
    private ConsoleColor BackgroundColor;
    private ConsoleColor ForegroundColor;
    private readonly int time = 500;

    public string Narrador { get; set; }

    public StoryTellerEngine(ConsoleColor backgroundColor, ConsoleColor foregroundColor, string narrador)
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
public class BattleStoryTeller : StoryTellerEngine
{
    public BattleStoryTeller() : base(ConsoleColor.Black, ConsoleColor.Red, "[Batalha]: ") { }

}
public class FlowStoryTeller : StoryTellerEngine
{
    public FlowStoryTeller() : base(ConsoleColor.Black, ConsoleColor.Yellow, "[Narrador]: ") { }

}
public class GameStoryTeller : StoryTellerEngine
{
    public GameStoryTeller() : base(ConsoleColor.Black, ConsoleColor.Blue, "[Game]: ") { }

}

public class MonsterStoryTeller : StoryTellerEngine
{
    public MonsterStoryTeller() : base(ConsoleColor.Black, ConsoleColor.Green, "[monstro]: ") { }

}