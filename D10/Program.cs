using System;

//var inputs = "noop\r\naddx 3\r\naddx -5";
//var inputs = "addx 15\r\naddx -11\r\naddx 6\r\naddx -3\r\naddx 5\r\naddx -1\r\naddx -8\r\naddx 13\r\naddx 4\r\nnoop\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx -35\r\naddx 1\r\naddx 24\r\naddx -19\r\naddx 1\r\naddx 16\r\naddx -11\r\nnoop\r\nnoop\r\naddx 21\r\naddx -15\r\nnoop\r\nnoop\r\naddx -3\r\naddx 9\r\naddx 1\r\naddx -3\r\naddx 8\r\naddx 1\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx -36\r\nnoop\r\naddx 1\r\naddx 7\r\nnoop\r\nnoop\r\nnoop\r\naddx 2\r\naddx 6\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx 1\r\nnoop\r\nnoop\r\naddx 7\r\naddx 1\r\nnoop\r\naddx -13\r\naddx 13\r\naddx 7\r\nnoop\r\naddx 1\r\naddx -33\r\nnoop\r\nnoop\r\nnoop\r\naddx 2\r\nnoop\r\nnoop\r\nnoop\r\naddx 8\r\nnoop\r\naddx -1\r\naddx 2\r\naddx 1\r\nnoop\r\naddx 17\r\naddx -9\r\naddx 1\r\naddx 1\r\naddx -3\r\naddx 11\r\nnoop\r\nnoop\r\naddx 1\r\nnoop\r\naddx 1\r\nnoop\r\nnoop\r\naddx -13\r\naddx -19\r\naddx 1\r\naddx 3\r\naddx 26\r\naddx -30\r\naddx 12\r\naddx -1\r\naddx 3\r\naddx 1\r\nnoop\r\nnoop\r\nnoop\r\naddx -9\r\naddx 18\r\naddx 1\r\naddx 2\r\nnoop\r\nnoop\r\naddx 9\r\nnoop\r\nnoop\r\nnoop\r\naddx -1\r\naddx 2\r\naddx -37\r\naddx 1\r\naddx 3\r\nnoop\r\naddx 15\r\naddx -21\r\naddx 22\r\naddx -6\r\naddx 1\r\nnoop\r\naddx 2\r\naddx 1\r\nnoop\r\naddx -10\r\nnoop\r\nnoop\r\naddx 20\r\naddx 1\r\naddx 2\r\naddx 2\r\naddx -6\r\naddx -11\r\nnoop\r\nnoop\r\nnoop";
var inputs = "addx 1\r\naddx 4\r\naddx -2\r\naddx 3\r\naddx 3\r\naddx 1\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\naddx 5\r\naddx 2\r\naddx 3\r\nnoop\r\naddx 2\r\naddx 4\r\nnoop\r\naddx -1\r\nnoop\r\naddx 3\r\naddx -10\r\naddx -17\r\nnoop\r\naddx -3\r\naddx 2\r\naddx 25\r\naddx -24\r\naddx 2\r\naddx 5\r\naddx 2\r\naddx 3\r\nnoop\r\naddx 2\r\naddx 14\r\naddx -9\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\naddx -2\r\naddx 5\r\naddx 2\r\naddx -5\r\nnoop\r\nnoop\r\naddx -19\r\naddx -11\r\naddx 5\r\naddx 3\r\nnoop\r\naddx 2\r\naddx 3\r\naddx -2\r\naddx 2\r\nnoop\r\naddx 3\r\naddx 4\r\nnoop\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\naddx 5\r\naddx -3\r\naddx 8\r\nnoop\r\naddx -15\r\nnoop\r\naddx -12\r\naddx -9\r\nnoop\r\naddx 6\r\naddx 7\r\naddx -6\r\naddx 4\r\nnoop\r\nnoop\r\nnoop\r\naddx 4\r\naddx 1\r\naddx 5\r\naddx -11\r\naddx 29\r\naddx -15\r\nnoop\r\naddx -12\r\naddx 17\r\naddx 7\r\nnoop\r\nnoop\r\naddx -32\r\naddx 3\r\naddx -8\r\naddx 7\r\nnoop\r\naddx -2\r\naddx 5\r\naddx 2\r\naddx 6\r\naddx -8\r\naddx 5\r\naddx 2\r\naddx 5\r\naddx 17\r\naddx -12\r\naddx -2\r\nnoop\r\nnoop\r\naddx 7\r\naddx 9\r\naddx -8\r\naddx 2\r\naddx -33\r\naddx -1\r\naddx 2\r\nnoop\r\naddx 26\r\naddx -22\r\naddx 19\r\naddx -16\r\naddx 8\r\naddx -1\r\naddx 3\r\naddx -2\r\naddx 2\r\naddx -17\r\naddx 24\r\naddx 1\r\nnoop\r\naddx 5\r\naddx -1\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\naddx 1\r\nnoop\r\nnoop";

var operations = inputs.Split("\r\n").Select(line => OperationFactory.Create(line)).ToList();

int valueX = 1;

var opt = new Queue<Operation>(operations);
Stack<AddX> toExecute = new Stack<AddX>();

var valueXHistory = new Dictionary<int, int>();

var totalCycles = operations.Count() + operations.OfType<AddX>().Count();
Enumerable.Range(1, totalCycles).ToList().ForEach(cIndex => ExecuteCycle(cIndex));


var resultP1 = Enumerable.Range(0, 6).Select(i => 20 + i * 40).Select(cycleNumber => valueXHistory[cycleNumber] * cycleNumber).Sum();

Console.WriteLine(resultP1);

Console.WriteLine(string.Join("\r\n", valueXHistory.Chunk(40).Select(chunck => DrawCRTLine(chunck))));

void ExecuteCycle(int cycleIndex)
{
    valueXHistory.Add(cycleIndex, valueX);

    if (toExecute.Count == 0)
    {
        switch (opt.Dequeue())
        {
            case Noop noop:
                break;
            case AddX addx:
                toExecute.Push(addx);
                break;
            default:
                throw new Exception("On est pas sorti de l'auberge");
        }
    }
    else
    {
        var addx = toExecute.Pop();
        valueX += addx.Value;
    }
}

string DrawCRTLine(KeyValuePair<int, int>[] chunck)
    => string.Concat(chunck.ToList().Select(v => DrawCRTPixel(v)));

char DrawCRTPixel(KeyValuePair<int, int> info)
{
    var crtLine = string.Concat(Enumerable.Range(0, 40).ToList().Select(i => '.')).ToArray();

    foreach (var index in Enumerable.Range(info.Value -1 , 3))
    {
        if (index > -1 && index < 40)
        {
            crtLine[index] = '#';    
        }
    }

    return crtLine[(info.Key % 40 == 0 ? 40 : info.Key % 40) - 1];
}

internal record Operation();

internal record Noop(): Operation;

internal record AddX(int Value) : Operation;

internal static class OperationFactory
{
    internal static Operation Create(string line)
    {
        var cmd = line.Split(" ");

        return cmd switch
        {
            var c when c.Length == 1 => new Noop(),
            var c when c.Length == 2 => new AddX(int.Parse(cmd[1])),
            _ => throw new Exception("ha c est balo!")
        }; ;
    }
}
