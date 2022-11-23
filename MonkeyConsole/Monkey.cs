using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAPI7;

public class Monkey
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Location { get; set; }

    public static IEnumerable<Monkey> SeedMonkeys()
    {
        yield return new Monkey
        {
            Id = 0,
            Name = "Baboon",
            Location = "Africa & Asia"
        };
        var m = new Monkey
        {
            Id = 0,
            Name = """Capuchin "Monkey"!""",
            Location = "South America"
        };

        if (m.Name.Contains("Monkey"))
        {

        }

        if(m.Location.Contains("Africa"))
        {

        }

        yield return m;
    }


    static void Test()
    {
        var raw3 = """
                    <element attr="content">
                      <body>
                        This line is indented by 4 spaces.
                      </body>
                    </element>
                    """;
    }
}
