namespace PokeSim.Core.Models;

public class Stat
{
    public required int BaseVal { get; set; }
    public int CurrentVal { get; set; }

    public Stat(int baseVal)
    {
        BaseVal = baseVal;
        CurrentVal = baseVal;
    }
}