public class StoryTeller(){

    public string Narrador;

    public StoryTeller(ConsoleColor BackgroundColor, ConsoleColor ForegroundColor, string narrador){

         Console.BackgroundColor = BackgroundColor;
         Console.ForegroundColor = ForegroundColor;
         Narrador = narrador;
    }

    public void Speak((string texto){
        Console.WriteLine(Narrador + texto);
        this.Destroy()
    }

    public void Destroy(){
        Thread.Sleep(time);
        Console.ForegroundColor  = ConsoleColor.White; 
    }

}
public class BattleStoryTeller : StoryTeller {
    public BattleStoryTeller(): base(ConsoleColor.Black, ConsoleColor.Red, "[Batalha]: "){}
}
public class FlowStoryTeller {
     ConsoleColor.Black
     ConsoleColor.Yellow

    private static readonly string Narrador = "[Narrador]: ";

    public static void Speak(string texto, int time = 1000){
        Console.BackgroundColor = BackgroundColor;
        Console.ForegroundColor = ForegroundColor;
        Console.WriteLine(Narrador + texto);
        Thread.Sleep(time);
        Console.ForegroundColor  = ConsoleColor.White; 
        
    }
}
public class GameStoryTeller {
    private static readonly ConsoleColor BackgroundColor = ConsoleColor.Black; 
    private static readonly ConsoleColor ForegroundColor  = ConsoleColor.Blue; 
    private static readonly string Narrador = "[Game]: ";
    public static void Speak(string texto, int time = 1000){
        Console.BackgroundColor = BackgroundColor;
        Console.ForegroundColor = ForegroundColor;
        Console.WriteLine(Narrador + texto);
        Thread.Sleep(time);
        Console.ForegroundColor  = ConsoleColor.White; 
        
    }
}