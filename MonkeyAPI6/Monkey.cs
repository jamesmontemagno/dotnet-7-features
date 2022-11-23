using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAPI6;

public class Monkey
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Location { get; set; }

    public static IEnumerable<Monkey> SeedMonkeys()
    {
        yield return new Monkey
        {
            Id = 0,
            Name = "Baboon",
            Location = "Africa & Asia"
        };
        yield return new Monkey
        {
            Id = 0,
            Name = "Capuchin \"Monkey\"",
        };
    }
}
