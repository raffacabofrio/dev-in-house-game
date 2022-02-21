public class BattleStoryTeller {
    private static readonly ConsoleColor BackgroundColor = ConsoleColor.Black; 
    private static readonly ConsoleColor ForegroundColor  = ConsoleColor.Red; 
    private static readonly string Narrador = "[Batalha]: ";
    public static void Speak(string texto, int time = 1000){
        Console.BackgroundColor = BackgroundColor;
        Console.ForegroundColor = ForegroundColor;
        Console.WriteLine(Narrador + texto);
        Thread.Sleep(time);
    Console.ForegroundColor  = ConsoleColor.White; 
        
    }
}
public class FlowStoryTeller {
    private static readonly ConsoleColor BackgroundColor = ConsoleColor.Black; 
    private static readonly ConsoleColor ForegroundColor  = ConsoleColor.Yellow; 
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