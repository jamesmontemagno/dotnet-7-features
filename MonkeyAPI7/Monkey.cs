using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAPI7;

public class Monkey
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Location { get; set; }

    public static IEnumerable<Monkey> SeedMonkeys()
    {
        yield return new Monkey
        {
            Id = 0,
            Location = "Africa & Asia"
        };
        var m = new Monkey
        {
            Id = 0,
            Name = "Capuchin \"Monkey\"",
        };

        if(m.Name.Contains("Monkey"))
        {

        }

        yield return m;
    }
}
