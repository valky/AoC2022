using System.Text;

var inputs = "abaaaaacaaaacccccccccaaaaaaccccccccccccccccccccccccccccccccccaaaaaa\r\nabaaaaacaaaaccccaaaaaaaaaacccccccccccccccccccccccccccccccccccaaaaaa\r\nabaaacccaaaaccccaaaaaaaaaaacccaacccccccccccaacccccccccccccccccaaaaa\r\nabaaaacccaacccccaaaaaaaaaaaaaaaaacccccccccccacccccccccccccccccccaaa\r\nabacaacccccccccccaaaaaaaaaaaaaaaaccccccccccaacccccccccccccccccccaaa\r\nabcccacccccccccccaaaaaaaccaaaaaaaccccccccccclllcccccacccccccccccaac\r\nabccccccccccccccccaaaaaccccccccccccccccccclllllllcccccccccccccccccc\r\nabaaacccccccccccccaaaaaccccccccccccccccaakklllllllcccccccccaacccccc\r\nabaaacccccccccccacccaaaccccccccccccccccakkklpppllllccddaaacaacccccc\r\nabaaacccaaacccccaacaaaccccccccccccccccckkkkpppppllllcddddaaaacccccc\r\nabaacccaaaacccccaaaaaccccccccccccccccckkkkpppppppllmmddddddaaaacccc\r\nabaaaccaaaaccccccaaaaaacaaacccccccccckkkkpppuuuppplmmmmdddddaaacccc\r\nabaaacccaaaccccaaaaaaaacaaaaccccccckkkkkoppuuuuuppqmmmmmmdddddacccc\r\nabcccccccccccccaaaaaaaacaaaacccccjkkkkkooppuuuuuuqqqmmmmmmmddddcccc\r\nabccccccccccccccccaaccccaaaccccjjjjkoooooouuuxuuuqqqqqqmmmmmddecccc\r\nabacaaccccccccccccaacccccccccccjjjjoooooouuuxxxuvvqqqqqqqmmmeeecccc\r\nabaaaacccccccacccaccccccccccccjjjjoootuuuuuuxxxyvvvvvqqqqmmmeeecccc\r\nabaaaaacccccaaacaaacccccccccccjjjoooottuuuuuxxyyvvvvvvvqqmnneeecccc\r\nabaaaaaccaaaaaaaaaaccccccccaccjjjooottttxxxxxxyyyyyyvvvqqnnneeecccc\r\nabaaaccccaaaaaaaaaacccccccaaccjjjoootttxxxxxxxyyyyyyvvqqqnnneeecccc\r\nSbcaaccccaaaaaaaaaaccccaaaaacajjjnnntttxxxxEzzzyyyyvvvrrqnnneeccccc\r\nabcccccccaaaaaaaaaaacccaaaaaaaajjjnnntttxxxxyyyyyvvvvrrrnnneeeccccc\r\nabcccccccaaaaaaaaaaacccccaaaaccjjjnnnnttttxxyyyyywvvrrrnnneeecccccc\r\nabcccccccccaaaaaaccaccccaaaaaccciiinnnnttxxyyyyyyywwrrnnnneeecccccc\r\nabccccccccccccaaacccccccaacaaaccciiinnnttxxyywwyyywwrrnnnffeccccccc\r\nabccccccccccccaaacccccccaccaaaccciiinnnttwwwwwwwwwwwrrrnnfffccccccc\r\nabccccccccccccccccccccccccccccccciiinnnttwwwwsswwwwwrrrnnfffccccccc\r\nabaaaccaaccccccccccccccccccccccccciinnnttswwwssswwwwrrroofffacccccc\r\nabaaccaaaaaacccccccccccccccccaaacciinnntssssssssssrrrrooofffacccccc\r\nabaccccaaaaacccccccaaacccccccaaaaciinnnssssssmmssssrrrooofffacccccc\r\nabaacaaaaaaacccccccaaaaccccccaaaaciiinmmmssmmmmmoosroooooffaaaacccc\r\nabaaaaaaaaaaaccccccaaaaccccccaaacciiimmmmmmmmmmmoooooooofffaaaacccc\r\nabcaaaaaaaaaaccccccaaaaccccccccccccihhmmmmmmmhggoooooooffffaaaccccc\r\nabcccccaaacaccccccccaaccccccccccccchhhhhhhhhhhggggggggggffaaacccccc\r\nabaccccaacccccccccccaaaccccccccccccchhhhhhhhhhgggggggggggcaaacccccc\r\nabaaaccccaccccccccccaaaacccaacccccccchhhhhhhaaaaaggggggcccccccccccc\r\nabaaaccccaaacaaaccccaaaacaaaacccccccccccccccaaaacccccccccccccccaaac\r\nabaacccccaaaaaaaccccaaaaaaaaacccccccccccccccaaacccccccccccccccccaaa\r\nabaaaccccaaaaaaccccaaaaaaaaccccccccccccccccccaacccccccccccccccccaaa\r\nabccccccaaaaaaaaaaaaaaaaaaacccccccccccccccccaaccccccccccccccccaaaaa\r\nabcccccaaaaaaaaaaaaaaaaaaaaacccccccccccccccccccccccccccccccccaaaaaa";


//var inputs = "Sabqponm\r\nabcryxxl\r\naccszExk\r\nacctuvwj\r\nabdefghi";

var map = new Map(inputs);

MapDrawer.DrapMap(map);

var pathFinder = new PathFinder(map);

pathFinder.Find();

Console.WriteLine(pathFinder.MinDistance);

MapDrawer.DrawPathOnMap(map, pathFinder.ShortestPath.Select(node => node.Position).ToList());


var mapPart2 = new MapPart2(inputs);

var pathFinderPart2 = new PathFinder(mapPart2);

MapDrawer.DrapMap(mapPart2);

pathFinderPart2.Find();

MapDrawer.DrawPathOnMap(mapPart2, pathFinderPart2.ShortestPath.Select(node => node.Position).ToList());


Console.WriteLine(pathFinderPart2.ShortestPath.Count() + 1 );

internal class Map
{
    internal List<Location> Locations;

    internal Map(string datas)
    {
        Locations = datas.Split("\r\n").SelectMany((line, index) => line.ToCharArray().Select((loc, rowInex) => ParseLocationSignal(loc, rowInex, index))).ToList();
    }

    internal Location GetLocation(Position pos)
        => Locations.First(l => (l.Position.Equals(pos)));

    protected virtual Location ParseLocationSignal(char elevation, int X, int Y)
        => elevation switch
        {
            'S' => new StartLocation(new Position(X, Y)),
            'E' => new EndLocation(new Position(X, Y)),
            char c when char.IsLower(c) => new Location((int)c % 32, new Position(X, Y)),
            _ => throw new Exception("on atteint des sommets inconnus")
        };
}

internal class MapPart2 : Map
{
    internal MapPart2(string datas) : base(datas)
    {
    }

    protected override Location ParseLocationSignal(char elevation, int X, int Y)
        => elevation switch
        {
            'S' => new EndLocation(new Position(X, Y)),
            'E' => new StartLocation(new Position(X, Y)),
            'a' => new EndLocation(new Position(X, Y)),
            char c when char.IsLower(c) => new Location( 27 - (int)c % 32, new Position(X, Y)),
            _ => throw new Exception("on atteint des sommets inconnus")
        };
}

internal class PathFinder
{
    HashSet<PathNode> AlreadyExplored = new HashSet<PathNode>();
    Queue<List<PathNode>> ToExplore = new Queue<List<PathNode>>();

    internal readonly Map Map;
    internal int MinDistance { get; private set; } = int.MaxValue;
    internal List<PathNode> ShortestPath { get; private set; } = new List<PathNode>();

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
        ToExplore.Enqueue(new() { new(null, startLocation.Position, 0, 0) });

        while (ToExplore.Any())
        {
            var nodeToExplore = ToExplore.Dequeue();
            ExploreMap(nodeToExplore);
        }
    }

    private void ExploreMap(List<PathNode> currentPath)
    {
        bool CanGoUp(int currentElevation, int destinationElevation)
         => currentElevation >= destinationElevation - 1 ;
        bool IsNotalreadyEcploredOrShortest(Position destinationPosition, int distance)
        {
            if (AlreadyExplored.Any(node => node.Position.Equals(destinationPosition)))
            {
                var lastNode = AlreadyExplored.Last(node => node.Position.Equals(destinationPosition));
                if (lastNode.Distance > distance)
                    return true;
                else
                    return false;
            }
            else
            {
                return true;
            }
        }

        var currentNode = currentPath.Last();

        AlreadyExplored.Add(currentNode);

        if (currentNode.Distance > MinDistance)
            return;

        foreach (var nextPosition in GetSurroundingPositions(currentNode.Position))
        {
            var nextLocation = Map.GetLocation(nextPosition);

            if (CanGoUp(currentNode.Elevation, nextLocation.Elevation) 
                && 
                IsNotalreadyEcploredOrShortest(nextPosition, currentNode.Distance + 1) 
                && 
                !ToExplore.Any(list => list.Any(node => node.Position.Equals(nextPosition))))
            {
                if (typeof(EndLocation) != nextLocation.GetType())
                {
                    var newPath = currentPath.ToList();
                    newPath.Add(new(currentNode, nextPosition, currentNode.Distance + 1, nextLocation.Elevation));
                    ToExplore.Enqueue(newPath);

                }
                else
                {
                    MinDistance = MinDistance > currentNode.Distance + 1 ? currentNode.Distance + 1 : MinDistance;
                    ShortestPath = currentPath;
                }
            }
        }
    }

    private List<Position> GetSurroundingPositions(Position pos)
    {
        var result = new List<Position>();

        if (pos.X + 1 < RightBoundary)
            result.Add(new Position(pos.X + 1, pos.Y));
        if (pos.Y + 1 < BottomBoundary)
            result.Add(new Position(pos.X, pos.Y + 1));
        if (pos.X - 1 >= 0)
            result.Add(new Position(pos.X - 1, pos.Y));
        if (pos.Y - 1 >= 0)
            result.Add(new Position(pos.X, pos.Y - 1));

        return result;
    }

    internal class PathNode
    {
        internal int Distance;
        internal int Elevation;
        internal readonly PathNode? Parent;
        internal readonly Position Position;

        internal PathNode(PathNode parent, Position position, int distance, int elevation)
        {
            Parent = parent;
            Position = position;
            Distance = distance;
            Elevation = elevation;
        }

        public override bool Equals(object? obj)
        {
            var testOjb = (PathNode)obj;
            return testOjb.Position.Equals(Position);
        }

        public override int GetHashCode()
        {
            return Position.GetHashCode();
        }
    }

    internal class EndNode : PathNode
    {
        internal EndNode(PathNode parent, Position position, int distance) : base(parent, position, distance, 26)
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

internal static class MapDrawer
{
    internal static void DrapMap(Map map)
    {
        foreach (var Y in Enumerable.Range(0, map.Locations.Max(l => l.Position.Y) + 1))
        {
            Console.WriteLine(string.Concat(map.Locations.Where(l => l.Position.Y == Y).OrderBy(l => l.Position.X).Select(l => l.ToString())));
        }

    }

    internal static void DrawPathOnMap(Map map, List<Position> locs)
    {
        Console.WriteLine();
        var sb = new StringBuilder();
        foreach (var Y in Enumerable.Range(0, map.Locations.Max(l => l.Position.Y) + 1))
        {
            sb.AppendLine(string.Concat(map.Locations.Where(l => l.Position.Y == Y).OrderBy(l => l.Position.X).Select(l => locs.Contains(l.Position) ? " " : l.ToString())));
        }
        Console.WriteLine(sb.ToString());

        //Thread.Sleep(1);
    }

    internal static void DrawLoctionOnMap(Map map, Position loc)
    {
        Console.Clear();
        var sb = new StringBuilder();
        foreach (var Y in Enumerable.Range(0, map.Locations.Max(l => l.Position.Y) + 1))
        {
            sb.AppendLine(string.Concat(map.Locations.Where(l => l.Position.Y == Y).OrderBy(l => l.Position.X).Select(l => l.Position.Equals(loc) ? " " : l.ToString())));
        }
        Console.WriteLine(sb.ToString());

        //Thread.Sleep(1);
    }

}
