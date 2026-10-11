namespace PokeSim.Core.Models;

public class Pokemon
{
    public string Name { get; }

    public List<Move> Moves { get; }

    public Ability? Ability { get; set; } = null;

    public Item? Item { get; set; } = null;

    public required Stats Stats { get; set; }

    public Pokemon(
        string name,
        List<Move> moves,
        Stats stats
    )
    {
        Name = name;
        Moves = moves;
        Stats = stats;
    }
}