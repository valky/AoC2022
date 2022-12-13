using System.Numerics;
var inputs = "Monkey 0:\r\n  Starting items: 73, 77\r\n  Operation: new = old * 5\r\n  Test: divisible by 11\r\n    If true: throw to monkey 6\r\n    If false: throw to monkey 5\r\n\r\nMonkey 1:\r\n  Starting items: 57, 88, 80\r\n  Operation: new = old + 5\r\n  Test: divisible by 19\r\n    If true: throw to monkey 6\r\n    If false: throw to monkey 0\r\n\r\nMonkey 2:\r\n  Starting items: 61, 81, 84, 69, 77, 88\r\n  Operation: new = old * 19\r\n  Test: divisible by 5\r\n    If true: throw to monkey 3\r\n    If false: throw to monkey 1\r\n\r\nMonkey 3:\r\n  Starting items: 78, 89, 71, 60, 81, 84, 87, 75\r\n  Operation: new = old + 7\r\n  Test: divisible by 3\r\n    If true: throw to monkey 1\r\n    If false: throw to monkey 0\r\n\r\nMonkey 4:\r\n  Starting items: 60, 76, 90, 63, 86, 87, 89\r\n  Operation: new = old + 2\r\n  Test: divisible by 13\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 7\r\n\r\nMonkey 5:\r\n  Starting items: 88\r\n  Operation: new = old + 1\r\n  Test: divisible by 17\r\n    If true: throw to monkey 4\r\n    If false: throw to monkey 7\r\n\r\nMonkey 6:\r\n  Starting items: 84, 98, 78, 85\r\n  Operation: new = old * old\r\n  Test: divisible by 7\r\n    If true: throw to monkey 5\r\n    If false: throw to monkey 4\r\n\r\nMonkey 7:\r\n  Starting items: 98, 89, 78, 73, 71\r\n  Operation: new = old + 4\r\n  Test: divisible by 2\r\n    If true: throw to monkey 3\r\n    If false: throw to monkey 2";

//var inputs = "Monkey 0:\r\n  Starting items: 79, 98\r\n  Operation: new = old * 19\r\n  Test: divisible by 23\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 3\r\n\r\nMonkey 1:\r\n  Starting items: 54, 65, 75, 74\r\n  Operation: new = old + 6\r\n  Test: divisible by 19\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 0\r\n\r\nMonkey 2:\r\n  Starting items: 79, 60, 97\r\n  Operation: new = old * old\r\n  Test: divisible by 13\r\n    If true: throw to monkey 1\r\n    If false: throw to monkey 3\r\n\r\nMonkey 3:\r\n  Starting items: 74\r\n  Operation: new = old + 3\r\n  Test: divisible by 17\r\n    If true: throw to monkey 0\r\n    If false: throw to monkey 1";


var Monkeys = inputs.Split("\r\n\r\n").Select(raw => new Monkey(raw, 3)).ToList();
var magicModulo = Monkeys.Aggregate(1ul, (product, monkey) => product * monkey.WorryTester);

foreach (var i in Enumerable.Range(1,20))
{
    Monkeys.ForEach(monkey => monkey.EvaluateItemToThrow(magicModulo).ToList().ForEach(ia => Monkeys.First(m => m.MonkeyId == ia.ToMonkeyId).ItemsCarried.Enqueue(ia.item)));
    //Monkeys.ForEach(monkey => Console.WriteLine(monkey.ToString()));
    //Console.WriteLine("                   ");
}
Monkeys.ForEach(monkey => Console.WriteLine($"Monkey {monkey.MonkeyId} inspected items {monkey.NumberOfItemAnalized} times."));

var resultPart1 = Monkeys.OrderByDescending(monkey => monkey.NumberOfItemAnalized).Take(2).Select(m => m.NumberOfItemAnalized).Aggregate((m1, m2) => m1 * m2);
Console.WriteLine(resultPart1);

var Monkeys2 = inputs.Split("\r\n\r\n").Select(raw => new Monkey(raw, 1)).ToList();
var magicModulo2 = Monkeys2.Aggregate(1ul, (product, monkey) => product * monkey.WorryTester);

foreach (var i in Enumerable.Range(1, 10_000))
{
    Monkeys2.ForEach(monkey => monkey.EvaluateItemToThrow(magicModulo2).ToList().ForEach(ia => Monkeys2.First(m => m.MonkeyId == ia.ToMonkeyId).ItemsCarried.Enqueue(ia.item)));
    //Console.WriteLine($"{i}         ");
    //Console.WriteLine($"          {i}         ");
    //Monkeys.ForEach(monkey => Console.WriteLine(monkey.ToString()));
}
Monkeys2.ForEach(monkey => Console.WriteLine($"Monkey {monkey.MonkeyId} inspected items {monkey.NumberOfItemAnalized} times."));

var resultPart2 = Monkeys2.OrderByDescending(monkey => monkey.NumberOfItemAnalized).Take(2).Select(m => m.NumberOfItemAnalized).Aggregate((m1, m2) => m1 * m2);
Console.WriteLine(resultPart2);

internal class Monkey
{
    internal readonly int MonkeyId;
    internal Queue<Item> ItemsCarried;
    internal readonly ulong WorryTester;
    internal long NumberOfItemAnalized = 0;

    private readonly ulong DevWorryLevel;
    private readonly int MonkeyIdToSendIfTrue;
    private readonly int MonkeyIdToSendIfFalse;
    private readonly Func<Item, ulong> Operation;

    internal Monkey(string rawMonkey, ulong devWorryLevel)
    {
        var datas = rawMonkey.Split("\r\n");

        MonkeyId = int.Parse(datas[0].Replace("Monkey ", string.Empty).Replace(":", string.Empty));
        ItemsCarried = new Queue<Item>(datas[1].Replace("  Starting items: ", string.Empty).Split(", ").Select(i => new Item(ulong.Parse(i))));
        Operation = ParseOperation(datas[2].Replace("  Operation: new = ", string.Empty));
        WorryTester = ulong.Parse(datas[3].Replace("  Test: divisible by ", string.Empty));
        MonkeyIdToSendIfTrue = int.Parse(datas[4].Replace("    If true: throw to monkey ", string.Empty));
        MonkeyIdToSendIfFalse = int.Parse(datas[5].Replace("    If false: throw to monkey ", string.Empty));

        DevWorryLevel = devWorryLevel;
    }

    internal IEnumerable<ItemThrow> EvaluateItemToThrow(ulong modulo)
    {
        var toThrow = new List<ItemThrow>();

        NumberOfItemAnalized += ItemsCarried.Count;

        while (ItemsCarried.Count > 0)
        {
            var item = ItemsCarried.Dequeue();

            EvaluateNewWorryLevel(item, modulo);

            yield return item.Value % WorryTester == 0 ? new ItemThrow(item, MonkeyIdToSendIfTrue) : new ItemThrow(item, MonkeyIdToSendIfFalse);
        }
    }

    private void EvaluateNewWorryLevel(Item item, ulong modulo)
    {
        if (DevWorryLevel > 1)
            item.Value = (ulong)Math.Round((decimal)(Operation(item) / DevWorryLevel), 0) % modulo;
        else
            item.Value = Operation(item) % modulo;
    }

    private Func<Item, ulong> ParseOperation(string operation)
        => (item) =>
        {
            var exp = operation.Split(" ");
            var right = exp[2] == "old" ? item.Value : ulong.Parse(exp[2]);
            switch (exp[1])
            {
                case "+":
                    return item.Value + right;
                case "*":
                    return item.Value * right;
                default:
                    throw new BananaExecption();
            }
        };

    public override string ToString()
        => $"Monkey {MonkeyId}: {string.Join(", ", ItemsCarried)}"; 
}

internal class Item
{
    internal ulong Value;
    internal Item(ulong value)
    {
        Value = value;
    }

    public override string ToString() 
        => Value.ToString();
}

internal record ItemThrow(Item item, int ToMonkeyId);


internal class BananaExecption : Exception
{
    internal BananaExecption() : base("Oups, j'ai glissé sur une banane")
    { }
}
