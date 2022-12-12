using System.Text;

var inputs = "abaaaaacaaaacccccccccaaaaaaccccccccccccccccccccccccccccccccccaaaaaa\r\nabaaaaacaaaaccccaaaaaaaaaacccccccccccccccccccccccccccccccccccaaaaaa\r\nabaaacccaaaaccccaaaaaaaaaaacccaacccccccccccaacccccccccccccccccaaaaa\r\nabaaaacccaacccccaaaaaaaaaaaaaaaaacccccccccccacccccccccccccccccccaaa\r\nabacaacccccccccccaaaaaaaaaaaaaaaaccccccccccaacccccccccccccccccccaaa\r\nabcccacccccccccccaaaaaaaccaaaaaaaccccccccccclllcccccacccccccccccaac\r\nabccccccccccccccccaaaaaccccccccccccccccccclllllllcccccccccccccccccc\r\nabaaacccccccccccccaaaaaccccccccccccccccaakklllllllcccccccccaacccccc\r\nabaaacccccccccccacccaaaccccccccccccccccakkklpppllllccddaaacaacccccc\r\nabaaacccaaacccccaacaaaccccccccccccccccckkkkpppppllllcddddaaaacccccc\r\nabaacccaaaacccccaaaaaccccccccccccccccckkkkpppppppllmmddddddaaaacccc\r\nabaaaccaaaaccccccaaaaaacaaacccccccccckkkkpppuuuppplmmmmdddddaaacccc\r\nabaaacccaaaccccaaaaaaaacaaaaccccccckkkkkoppuuuuuppqmmmmmmdddddacccc\r\nabcccccccccccccaaaaaaaacaaaacccccjkkkkkooppuuuuuuqqqmmmmmmmddddcccc\r\nabccccccccccccccccaaccccaaaccccjjjjkoooooouuuxuuuqqqqqqmmmmmddecccc\r\nabacaaccccccccccccaacccccccccccjjjjoooooouuuxxxuvvqqqqqqqmmmeeecccc\r\nabaaaacccccccacccaccccccccccccjjjjoootuuuuuuxxxyvvvvvqqqqmmmeeecccc\r\nabaaaaacccccaaacaaacccccccccccjjjoooottuuuuuxxyyvvvvvvvqqmnneeecccc\r\nabaaaaaccaaaaaaaaaaccccccccaccjjjooottttxxxxxxyyyyyyvvvqqnnneeecccc\r\nabaaaccccaaaaaaaaaacccccccaaccjjjoootttxxxxxxxyyyyyyvvqqqnnneeecccc\r\nSbcaaccccaaaaaaaaaaccccaaaaacajjjnnntttxxxxEzzzyyyyvvvrrqnnneeccccc\r\nabcccccccaaaaaaaaaaacccaaaaaaaajjjnnntttxxxxyyyyyvvvvrrrnnneeeccccc\r\nabcccccccaaaaaaaaaaacccccaaaaccjjjnnnnttttxxyyyyywvvrrrnnneeecccccc\r\nabcccccccccaaaaaaccaccccaaaaaccciiinnnnttxxyyyyyyywwrrnnnneeecccccc\r\nabccccccccccccaaacccccccaacaaaccciiinnnttxxyywwyyywwrrnnnffeccccccc\r\nabccccccccccccaaacccccccaccaaaccciiinnnttwwwwwwwwwwwrrrnnfffccccccc\r\nabccccccccccccccccccccccccccccccciiinnnttwwwwsswwwwwrrrnnfffccccccc\r\nabaaaccaaccccccccccccccccccccccccciinnnttswwwssswwwwrrroofffacccccc\r\nabaaccaaaaaacccccccccccccccccaaacciinnntssssssssssrrrrooofffacccccc\r\nabaccccaaaaacccccccaaacccccccaaaaciinnnssssssmmssssrrrooofffacccccc\r\nabaacaaaaaaacccccccaaaaccccccaaaaciiinmmmssmmmmmoosroooooffaaaacccc\r\nabaaaaaaaaaaaccccccaaaaccccccaaacciiimmmmmmmmmmmoooooooofffaaaacccc\r\nabcaaaaaaaaaaccccccaaaaccccccccccccihhmmmmmmmhggoooooooffffaaaccccc\r\nabcccccaaacaccccccccaaccccccccccccchhhhhhhhhhhggggggggggffaaacccccc\r\nabaccccaacccccccccccaaaccccccccccccchhhhhhhhhhgggggggggggcaaacccccc\r\nabaaaccccaccccccccccaaaacccaacccccccchhhhhhhaaaaaggggggcccccccccccc\r\nabaaaccccaaacaaaccccaaaacaaaacccccccccccccccaaaacccccccccccccccaaac\r\nabaacccccaaaaaaaccccaaaaaaaaacccccccccccccccaaacccccccccccccccccaaa\r\nabaaaccccaaaaaaccccaaaaaaaaccccccccccccccccccaacccccccccccccccccaaa\r\nabccccccaaaaaaaaaaaaaaaaaaacccccccccccccccccaaccccccccccccccccaaaaa\r\nabcccccaaaaaaaaaaaaaaaaaaaaacccccccccccccccccccccccccccccccccaaaaaa";

//var inputs = "Sabqponm\r\nabcryxxl\r\naccszExk\r\nacctuvwj\r\nabdefghi";

var map = new Map(inputs);

map.DrawMap();

var pathFinder = new PathFinder(map);

pathFinder.Find();

Console.WriteLine(pathFinder.MinDistance);

internal class Map
{
    internal List<Location> Locations;

    internal Map(string datas)
    {
        Locations = datas.Split("\r\n").SelectMany((line, index) => line.ToCharArray().Select((loc, rowInex) => ParseLocationSignal(loc, rowInex, index))).ToList();
    }

    internal void DrawMap()
    {
        foreach (var Y in Enumerable.Range(0, Locations.Max(l => l.Position.Y) + 1))
        {
            Console.WriteLine(string.Concat(Locations.Where(l => l.Position.Y == Y).OrderBy(l => l.Position.X).Select(l => l.ToString())));
        }
    }

    internal void DrawMap(Location loc)
    {
        Console.Clear();
        var sb = new StringBuilder();
        foreach (var Y in Enumerable.Range(0, Locations.Max(l => l.Position.Y) + 1))
        {
            sb.AppendLine(string.Concat(Locations.Where(l => l.Position.Y == Y).OrderBy(l => l.Position.X).Select(l => l.Equals(loc) ? " " : l.ToString())));
        }
        Console.WriteLine(sb.ToString());
    }

    internal Location GetLocation(Position pos)
        => Locations.First(l => (l.Position.Equals(pos)));

    private Location ParseLocationSignal(char elevation, int X, int Y)
        => elevation switch
        {
            'S' => new StartLocation(new Position(X, Y)),
            'E' => new EndLocation(new Position(X, Y)),
            char c when char.IsLower(c) => new Location((int)c % 32, new Position(X, Y)),
            _ => throw new Exception("on atteint des sommets inconnus")
        };
}

internal class PathFinder
{
    Stack<PathNode> stack = new Stack<PathNode>();

    internal readonly Map Map;
    internal int MinDistance { get; private set; } = int.MaxValue;

    private readonly int RightBoundary;
    private readonly int BottomBoundary;

    internal PathFinder(Map map)
    {
        Map = map;
        RightBoundary = Map.Locations.Max(l => l.Position.X) + 1;
        BottomBoundary = Map.Locations.Max(l => l.Position.Y) + 1;
    }

    internal void Find()
    {
        var startLocation = Map.Locations.OfType<StartLocation>().First();

        var startNode = new PathNode(null, startLocation.Position, 0);

        ExploreMap(startNode, new List<PathNode>() { startNode });
    }

    private void ExploreMap(PathNode currentNode, List<PathNode> alreadyExplored)
    {

        var currentLocation = Map.GetLocation(currentNode.Position);
        Map.DrawMap(currentLocation);

        var toExplore = new List<PathNode>();

        foreach (var position in GetPossiblePositions(currentNode.Position))
        {
            var location = Map.GetLocation(position);
            //|| (currentLocation.ToString() == "o" && location.ToString() == "m")    to hack a bite xD
            if (currentLocation.Elevation == location.Elevation - 1 || currentLocation.Elevation == location.Elevation )
            {
                toExplore.Add(
                        location switch
                        { 
                            EndLocation => new EndNode(currentNode, position, currentNode.Distance + 1),
                            _ => new PathNode(currentNode, position, currentNode.Distance + 1)
                        }
                    );
            }
        }

        if (toExplore.OfType<EndNode>().Count() > 0)
        {
            EndNode end = toExplore.OfType<EndNode>().First();
            MinDistance = MinDistance > end.Distance ? end.Distance : MinDistance;
            Console.WriteLine($"{end.Position} => {MinDistance}");
        }

        toExplore
            .Where(n => !alreadyExplored.Contains(n))
            .Where(n => typeof(EndLocation) != n.GetType())
            .ToList()
            .ForEach(pn => ExploreMap(pn, alreadyExplored.Append(pn).ToList()));

        alreadyExplored.Clear();
    }

    private List<Position> GetPossiblePositions(Position pos)
    {
        var result = new List<Position>();

        if (pos.X - 1 >= 0)
            result.Add(new Position(pos.X - 1, pos.Y));
        if (pos.X + 1 < RightBoundary)
            result.Add(new Position(pos.X + 1, pos.Y));
        if (pos.Y - 1 >= 0)
            result.Add(new Position(pos.X, pos.Y - 1));
        if (pos.Y + 1 < BottomBoundary)
            result.Add(new Position(pos.X, pos.Y + 1));
        return result;
    }

    internal class PathNode
    {
        internal int Distance;
        internal readonly PathNode? Parent;
        internal readonly Position Position;

        internal PathNode(PathNode parent, Position position, int distance)
        {
            Parent = parent;
            Position = position;
            Distance = distance;
        }

        public override bool Equals(object? obj)
        {
            var testOjb = (PathNode)obj;
            return testOjb.Position.X == Position.X && testOjb.Position.Y == Position.Y;
        }
    }

    internal class EndNode : PathNode
    {
        internal EndNode(PathNode parent, Position position, int distance) : base(parent, position, distance)
        {
        }
    }
}

internal class Location
{
    internal readonly int Elevation;
    internal readonly Position Position;
    internal IEnumerable<Location> NextNaviguableLocation;

    internal Location(int elevation, Position position)
    {
        Elevation = elevation;
        Position = position;
    }

    public override string ToString()
    {
        return Char.ToLower(Convert.ToChar(Elevation + 64)).ToString();
    }
}

internal class StartLocation : Location
{ 
    internal StartLocation(Position position) : base(0, position) {}

    public override string ToString()
    {
        return "S";
    }
}

internal class EndLocation : Location
{
    internal EndLocation(Position position) : base(26, position) { }

    public override string ToString()
    {
        return "E";
    }
}

internal class Position
{
    internal int X;
    internal int Y;

    internal Position(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
        => $"[{X} , {Y}]";

    public override bool Equals(object? obj)
    {
        var testOjb = (Position)obj;
        return testOjb.X == X && testOjb.Y == Y;
    }
}

