namespace PokeSim.Core.Models;

public class Stats
{
    public required Stat HP { get; set; }
    public required Stat Attack { get; set; }
    public required Stat Defense { get; set; }
    public required Stat SpecialAttack { get; set; }
    public required Stat SpecialDefense { get; set; }
    public required Stat Speed { get; set; }
}