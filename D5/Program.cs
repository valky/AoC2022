
//Stack<char>[] stacks =
//{
//    new Stack<char>(new[] { 'Z', 'N' }),
//    new Stack<char>(new[] { 'M', 'C', 'D'}),
//    new Stack<char>(new[] { 'P'})
//};

//List<char>[] stacksV2 =
//{
//    new List<char>(new[] { 'Z', 'N' }),
//    new List<char>(new[] { 'M', 'C', 'D'}),
//    new List<char>(new[] { 'P'})
//};

//string instructions = "move 1 from 2 to 1\r\nmove 3 from 1 to 3\r\nmove 2 from 2 to 1\r\nmove 1 from 1 to 2";

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Stack<char>[] stacks =
{
    new Stack<char>(new[] { 'H', 'C', 'R' }),
    new Stack<char>(new[] { 'B', 'J', 'H', 'L', 'S', 'F'}),
    new Stack<char>(new[] { 'R', 'M', 'D', 'H', 'J', 'T', 'Q'}),
    new Stack<char>(new[] { 'S', 'G', 'R', 'H', 'Z', 'B', 'J'}),
    new Stack<char>(new[] { 'R', 'P', 'F', 'Z', 'T', 'D', 'C', 'B'}),
    new Stack<char>(new[] { 'T', 'H', 'C', 'G'}),
    new Stack<char>(new[] { 'S', 'N', 'V', 'Z', 'B', 'P', 'W', 'L'}),
    new Stack<char>(new[] { 'R', 'J', 'Q', 'G', 'C'}),
    new Stack<char>(new[] { 'L', 'D', 'T', 'R', 'H', 'P', 'F', 'S'}),
};

List<char>[] stacksV2 =
{
    new List<char>(new[] { 'H', 'C', 'R' }),
    new List<char>(new[] { 'B', 'J', 'H', 'L', 'S', 'F'}),
    new List<char>(new[] { 'R', 'M', 'D', 'H', 'J', 'T', 'Q'}),
    new List<char>(new[] { 'S', 'G', 'R', 'H', 'Z', 'B', 'J'}),
    new List<char>(new[] { 'R', 'P', 'F', 'Z', 'T', 'D', 'C', 'B'}),
    new List<char>(new[] { 'T', 'H', 'C', 'G'}),
    new List<char>(new[] { 'S', 'N', 'V', 'Z', 'B', 'P', 'W', 'L'}),
    new List<char>(new[] { 'R', 'J', 'Q', 'G', 'C'}),
    new List<char>(new[] { 'L', 'D', 'T', 'R', 'H', 'P', 'F', 'S'}),
};

string instructions = "move 8 from 7 to 1\r\nmove 9 from 1 to 9\r\nmove 4 from 5 to 4\r\nmove 4 from 6 to 1\r\nmove 3 from 8 to 5\r\nmove 6 from 5 to 9\r\nmove 1 from 5 to 1\r\nmove 4 from 4 to 9\r\nmove 7 from 3 to 7\r\nmove 6 from 7 to 3\r\nmove 1 from 8 to 7\r\nmove 2 from 7 to 6\r\nmove 1 from 8 to 9\r\nmove 1 from 6 to 3\r\nmove 4 from 3 to 5\r\nmove 5 from 1 to 3\r\nmove 1 from 1 to 8\r\nmove 2 from 3 to 4\r\nmove 1 from 4 to 1\r\nmove 7 from 9 to 2\r\nmove 1 from 6 to 3\r\nmove 2 from 1 to 9\r\nmove 20 from 9 to 7\r\nmove 6 from 4 to 9\r\nmove 1 from 2 to 9\r\nmove 6 from 9 to 4\r\nmove 1 from 4 to 6\r\nmove 1 from 8 to 6\r\nmove 1 from 4 to 7\r\nmove 5 from 2 to 3\r\nmove 2 from 6 to 4\r\nmove 3 from 9 to 5\r\nmove 5 from 3 to 5\r\nmove 3 from 3 to 8\r\nmove 3 from 5 to 6\r\nmove 1 from 9 to 8\r\nmove 5 from 4 to 5\r\nmove 3 from 4 to 9\r\nmove 1 from 8 to 2\r\nmove 2 from 8 to 2\r\nmove 11 from 5 to 6\r\nmove 16 from 7 to 1\r\nmove 2 from 1 to 7\r\nmove 14 from 6 to 1\r\nmove 11 from 1 to 6\r\nmove 2 from 1 to 4\r\nmove 4 from 3 to 4\r\nmove 9 from 2 to 4\r\nmove 2 from 4 to 8\r\nmove 2 from 5 to 3\r\nmove 9 from 4 to 7\r\nmove 2 from 3 to 2\r\nmove 1 from 2 to 7\r\nmove 1 from 8 to 4\r\nmove 4 from 1 to 4\r\nmove 1 from 9 to 1\r\nmove 7 from 4 to 7\r\nmove 2 from 6 to 5\r\nmove 1 from 8 to 6\r\nmove 1 from 4 to 2\r\nmove 10 from 1 to 6\r\nmove 5 from 7 to 3\r\nmove 1 from 4 to 7\r\nmove 2 from 1 to 2\r\nmove 2 from 2 to 4\r\nmove 4 from 3 to 4\r\nmove 18 from 7 to 6\r\nmove 6 from 6 to 4\r\nmove 1 from 7 to 4\r\nmove 1 from 7 to 6\r\nmove 11 from 4 to 5\r\nmove 14 from 5 to 9\r\nmove 1 from 8 to 7\r\nmove 8 from 6 to 2\r\nmove 2 from 4 to 5\r\nmove 7 from 9 to 1\r\nmove 6 from 9 to 7\r\nmove 5 from 1 to 8\r\nmove 1 from 3 to 6\r\nmove 10 from 6 to 3\r\nmove 1 from 9 to 6\r\nmove 1 from 5 to 4\r\nmove 4 from 3 to 8\r\nmove 1 from 5 to 9\r\nmove 9 from 2 to 3\r\nmove 1 from 9 to 5\r\nmove 4 from 8 to 4\r\nmove 1 from 5 to 3\r\nmove 5 from 8 to 7\r\nmove 5 from 7 to 2\r\nmove 3 from 4 to 1\r\nmove 8 from 6 to 5\r\nmove 1 from 7 to 9\r\nmove 4 from 1 to 3\r\nmove 2 from 4 to 6\r\nmove 5 from 5 to 2\r\nmove 4 from 6 to 9\r\nmove 1 from 1 to 2\r\nmove 1 from 5 to 6\r\nmove 7 from 2 to 8\r\nmove 5 from 6 to 8\r\nmove 4 from 7 to 9\r\nmove 15 from 3 to 9\r\nmove 1 from 7 to 3\r\nmove 1 from 5 to 3\r\nmove 6 from 2 to 6\r\nmove 1 from 5 to 2\r\nmove 2 from 3 to 9\r\nmove 1 from 6 to 8\r\nmove 5 from 8 to 9\r\nmove 2 from 3 to 8\r\nmove 3 from 3 to 6\r\nmove 11 from 9 to 4\r\nmove 1 from 2 to 1\r\nmove 2 from 8 to 4\r\nmove 1 from 1 to 4\r\nmove 7 from 4 to 7\r\nmove 9 from 6 to 3\r\nmove 4 from 7 to 8\r\nmove 4 from 7 to 6\r\nmove 19 from 9 to 4\r\nmove 7 from 8 to 5\r\nmove 5 from 3 to 6\r\nmove 6 from 6 to 9\r\nmove 3 from 3 to 5\r\nmove 1 from 3 to 9\r\nmove 8 from 4 to 5\r\nmove 2 from 9 to 6\r\nmove 3 from 8 to 2\r\nmove 1 from 8 to 4\r\nmove 1 from 2 to 5\r\nmove 19 from 4 to 1\r\nmove 2 from 5 to 7\r\nmove 2 from 2 to 4\r\nmove 13 from 5 to 2\r\nmove 1 from 5 to 1\r\nmove 2 from 6 to 9\r\nmove 1 from 8 to 7\r\nmove 9 from 9 to 3\r\nmove 2 from 3 to 8\r\nmove 1 from 4 to 2\r\nmove 5 from 6 to 7\r\nmove 1 from 4 to 6\r\nmove 2 from 8 to 7\r\nmove 7 from 1 to 5\r\nmove 1 from 6 to 7\r\nmove 10 from 1 to 8\r\nmove 1 from 1 to 3\r\nmove 1 from 1 to 2\r\nmove 6 from 5 to 3\r\nmove 4 from 5 to 3\r\nmove 5 from 7 to 1\r\nmove 3 from 1 to 2\r\nmove 4 from 7 to 5\r\nmove 8 from 3 to 6\r\nmove 2 from 1 to 7\r\nmove 4 from 5 to 8\r\nmove 7 from 3 to 5\r\nmove 3 from 7 to 2\r\nmove 1 from 7 to 3\r\nmove 12 from 2 to 8\r\nmove 23 from 8 to 2\r\nmove 16 from 2 to 6\r\nmove 1 from 9 to 6\r\nmove 7 from 5 to 7\r\nmove 7 from 2 to 4\r\nmove 2 from 3 to 8\r\nmove 1 from 1 to 9\r\nmove 5 from 8 to 1\r\nmove 2 from 3 to 9\r\nmove 2 from 7 to 1\r\nmove 4 from 1 to 3\r\nmove 4 from 7 to 2\r\nmove 2 from 1 to 4\r\nmove 11 from 2 to 9\r\nmove 3 from 3 to 4\r\nmove 1 from 9 to 1\r\nmove 2 from 2 to 7\r\nmove 4 from 4 to 8\r\nmove 2 from 9 to 5\r\nmove 2 from 5 to 7\r\nmove 4 from 4 to 6\r\nmove 1 from 3 to 8\r\nmove 1 from 9 to 8\r\nmove 4 from 4 to 2\r\nmove 2 from 1 to 3\r\nmove 1 from 8 to 4\r\nmove 2 from 3 to 5\r\nmove 3 from 9 to 7\r\nmove 2 from 8 to 9\r\nmove 1 from 9 to 6\r\nmove 2 from 7 to 3\r\nmove 2 from 8 to 1\r\nmove 1 from 4 to 9\r\nmove 18 from 6 to 2\r\nmove 1 from 6 to 5\r\nmove 1 from 5 to 9\r\nmove 18 from 2 to 3\r\nmove 1 from 8 to 7\r\nmove 2 from 5 to 9\r\nmove 1 from 1 to 4\r\nmove 3 from 2 to 1\r\nmove 9 from 9 to 4\r\nmove 7 from 4 to 6\r\nmove 2 from 7 to 3\r\nmove 2 from 4 to 9\r\nmove 7 from 6 to 7\r\nmove 3 from 7 to 2\r\nmove 7 from 6 to 3\r\nmove 2 from 6 to 9\r\nmove 24 from 3 to 9\r\nmove 2 from 6 to 8\r\nmove 1 from 4 to 2\r\nmove 2 from 8 to 5\r\nmove 31 from 9 to 3\r\nmove 6 from 7 to 4\r\nmove 35 from 3 to 7\r\nmove 1 from 1 to 8\r\nmove 1 from 5 to 7\r\nmove 1 from 5 to 4\r\nmove 1 from 3 to 9\r\nmove 1 from 8 to 2\r\nmove 3 from 1 to 7\r\nmove 7 from 4 to 5\r\nmove 1 from 9 to 8\r\nmove 4 from 5 to 6\r\nmove 2 from 5 to 2\r\nmove 6 from 2 to 5\r\nmove 2 from 5 to 7\r\nmove 2 from 2 to 1\r\nmove 2 from 5 to 4\r\nmove 1 from 8 to 4\r\nmove 3 from 4 to 6\r\nmove 4 from 6 to 7\r\nmove 1 from 5 to 2\r\nmove 2 from 6 to 9\r\nmove 1 from 6 to 4\r\nmove 1 from 4 to 8\r\nmove 2 from 9 to 6\r\nmove 1 from 8 to 9\r\nmove 34 from 7 to 9\r\nmove 6 from 7 to 3\r\nmove 1 from 7 to 2\r\nmove 1 from 5 to 8\r\nmove 1 from 8 to 6\r\nmove 6 from 7 to 4\r\nmove 1 from 7 to 3\r\nmove 7 from 3 to 5\r\nmove 6 from 4 to 6\r\nmove 31 from 9 to 1\r\nmove 3 from 5 to 7\r\nmove 24 from 1 to 3\r\nmove 1 from 2 to 4\r\nmove 3 from 9 to 1\r\nmove 14 from 3 to 5\r\nmove 1 from 4 to 3\r\nmove 1 from 9 to 7\r\nmove 8 from 3 to 7\r\nmove 1 from 2 to 9\r\nmove 7 from 1 to 5\r\nmove 3 from 6 to 8\r\nmove 3 from 6 to 1\r\nmove 1 from 1 to 3\r\nmove 4 from 3 to 2\r\nmove 4 from 2 to 3\r\nmove 2 from 5 to 1\r\nmove 9 from 7 to 4\r\nmove 1 from 6 to 5\r\nmove 1 from 1 to 7\r\nmove 3 from 8 to 9\r\nmove 5 from 4 to 2\r\nmove 3 from 2 to 3\r\nmove 1 from 2 to 3\r\nmove 2 from 4 to 1\r\nmove 2 from 9 to 4\r\nmove 1 from 9 to 3\r\nmove 1 from 6 to 1\r\nmove 1 from 9 to 6\r\nmove 25 from 5 to 4\r\nmove 4 from 1 to 9\r\nmove 2 from 3 to 7\r\nmove 2 from 6 to 9\r\nmove 2 from 9 to 5\r\nmove 6 from 7 to 1\r\nmove 5 from 3 to 6\r\nmove 10 from 4 to 3\r\nmove 10 from 4 to 8\r\nmove 2 from 4 to 2\r\nmove 5 from 1 to 9\r\nmove 2 from 6 to 4\r\nmove 6 from 9 to 6\r\nmove 7 from 6 to 4\r\nmove 3 from 9 to 4\r\nmove 3 from 2 to 4\r\nmove 4 from 3 to 8\r\nmove 2 from 5 to 3\r\nmove 10 from 4 to 9\r\nmove 4 from 9 to 7\r\nmove 5 from 9 to 5\r\nmove 4 from 5 to 1\r\nmove 9 from 4 to 6\r\nmove 10 from 1 to 3\r\nmove 1 from 5 to 4\r\nmove 3 from 4 to 5\r\nmove 2 from 5 to 7\r\nmove 1 from 7 to 3\r\nmove 1 from 6 to 9\r\nmove 11 from 8 to 6\r\nmove 14 from 6 to 5\r\nmove 1 from 4 to 7\r\nmove 7 from 5 to 3\r\nmove 3 from 5 to 4\r\nmove 2 from 9 to 5\r\nmove 2 from 4 to 3\r\nmove 2 from 7 to 4\r\nmove 11 from 3 to 9\r\nmove 2 from 8 to 2\r\nmove 2 from 2 to 3\r\nmove 1 from 8 to 2\r\nmove 1 from 2 to 9\r\nmove 3 from 4 to 5\r\nmove 2 from 6 to 9\r\nmove 1 from 1 to 8\r\nmove 10 from 9 to 7\r\nmove 2 from 9 to 3\r\nmove 23 from 3 to 9\r\nmove 4 from 6 to 4\r\nmove 9 from 5 to 6\r\nmove 1 from 5 to 3\r\nmove 5 from 6 to 7\r\nmove 1 from 1 to 7\r\nmove 1 from 3 to 9\r\nmove 4 from 6 to 7\r\nmove 1 from 8 to 7\r\nmove 1 from 7 to 5\r\nmove 1 from 5 to 1\r\nmove 12 from 7 to 6\r\nmove 9 from 9 to 3\r\nmove 6 from 6 to 4\r\nmove 8 from 7 to 3\r\nmove 3 from 7 to 4\r\nmove 6 from 3 to 1\r\nmove 10 from 4 to 8\r\nmove 10 from 8 to 7\r\nmove 2 from 3 to 7\r\nmove 9 from 3 to 8\r\nmove 2 from 6 to 3\r\nmove 10 from 7 to 1\r\nmove 3 from 4 to 6\r\nmove 5 from 8 to 5\r\nmove 3 from 5 to 7\r\nmove 1 from 3 to 2\r\nmove 1 from 2 to 6\r\nmove 6 from 9 to 1\r\nmove 12 from 1 to 3\r\nmove 3 from 6 to 9\r\nmove 3 from 1 to 7\r\nmove 1 from 3 to 2\r\nmove 7 from 1 to 7\r\nmove 1 from 2 to 7\r\nmove 2 from 6 to 4\r\nmove 1 from 4 to 5\r\nmove 3 from 8 to 7\r\nmove 2 from 6 to 3\r\nmove 2 from 6 to 1\r\nmove 1 from 3 to 8\r\nmove 5 from 3 to 4\r\nmove 2 from 8 to 5\r\nmove 14 from 7 to 4\r\nmove 1 from 3 to 2\r\nmove 1 from 3 to 7\r\nmove 7 from 7 to 4\r\nmove 2 from 5 to 3\r\nmove 2 from 1 to 4\r\nmove 9 from 4 to 6\r\nmove 1 from 1 to 2\r\nmove 4 from 9 to 4\r\nmove 8 from 9 to 3\r\nmove 2 from 2 to 7\r\nmove 13 from 4 to 8\r\nmove 4 from 4 to 1\r\nmove 2 from 7 to 6\r\nmove 12 from 3 to 2\r\nmove 11 from 2 to 9\r\nmove 6 from 4 to 9\r\nmove 18 from 9 to 4\r\nmove 2 from 1 to 6\r\nmove 6 from 8 to 1\r\nmove 13 from 6 to 5\r\nmove 8 from 4 to 5\r\nmove 1 from 2 to 9\r\nmove 8 from 1 to 4\r\nmove 7 from 4 to 8\r\nmove 4 from 3 to 5\r\nmove 10 from 8 to 5\r\nmove 13 from 5 to 8\r\nmove 12 from 4 to 5\r\nmove 2 from 9 to 8\r\nmove 29 from 5 to 9\r\nmove 24 from 9 to 2\r\nmove 23 from 2 to 4\r\nmove 5 from 9 to 2\r\nmove 7 from 5 to 7\r\nmove 1 from 5 to 1\r\nmove 7 from 4 to 8\r\nmove 14 from 8 to 1\r\nmove 5 from 2 to 6\r\nmove 16 from 4 to 7\r\nmove 8 from 1 to 6\r\nmove 1 from 2 to 8\r\nmove 20 from 7 to 6\r\nmove 11 from 6 to 4\r\nmove 3 from 1 to 5\r\nmove 3 from 4 to 3\r\nmove 8 from 4 to 9\r\nmove 8 from 6 to 1\r\nmove 2 from 1 to 4\r\nmove 3 from 5 to 2\r\nmove 12 from 8 to 2\r\nmove 1 from 7 to 1\r\nmove 1 from 3 to 5\r\nmove 1 from 7 to 8\r\nmove 1 from 7 to 3\r\nmove 12 from 2 to 8\r\nmove 13 from 6 to 4\r\nmove 2 from 1 to 9\r\nmove 3 from 2 to 6\r\nmove 3 from 9 to 7\r\nmove 5 from 9 to 1\r\nmove 4 from 6 to 4\r\nmove 2 from 3 to 6\r\nmove 1 from 5 to 9\r\nmove 1 from 6 to 7\r\nmove 9 from 1 to 5\r\nmove 11 from 8 to 3\r\nmove 1 from 6 to 8\r\nmove 3 from 7 to 1\r\nmove 1 from 8 to 7\r\nmove 2 from 8 to 9\r\nmove 7 from 1 to 2\r\nmove 17 from 4 to 7\r\nmove 1 from 8 to 6\r\nmove 4 from 7 to 2\r\nmove 4 from 9 to 7\r\nmove 4 from 2 to 3\r\nmove 1 from 1 to 4\r\nmove 2 from 4 to 3\r\nmove 9 from 5 to 4\r\nmove 1 from 6 to 8\r\nmove 6 from 2 to 1\r\nmove 5 from 1 to 9\r\nmove 9 from 4 to 3\r\nmove 1 from 4 to 6\r\nmove 2 from 9 to 7\r\nmove 1 from 1 to 5\r\nmove 1 from 2 to 7\r\nmove 1 from 8 to 9\r\nmove 1 from 6 to 8\r\nmove 1 from 5 to 4\r\nmove 1 from 8 to 7\r\nmove 23 from 3 to 7\r\nmove 36 from 7 to 6\r\nmove 33 from 6 to 1\r\nmove 1 from 4 to 8\r\nmove 7 from 1 to 5\r\nmove 1 from 8 to 1\r\nmove 3 from 7 to 2\r\nmove 24 from 1 to 3\r\nmove 7 from 7 to 3\r\nmove 3 from 5 to 1\r\nmove 4 from 5 to 3\r\nmove 1 from 9 to 8\r\nmove 2 from 9 to 6\r\nmove 1 from 8 to 5\r\nmove 3 from 2 to 5\r\nmove 30 from 3 to 5\r\nmove 1 from 6 to 7\r\nmove 6 from 1 to 8\r\nmove 7 from 3 to 2\r\nmove 1 from 7 to 5\r\nmove 2 from 3 to 2\r\nmove 2 from 6 to 8\r\nmove 1 from 6 to 1\r\nmove 7 from 5 to 8\r\nmove 8 from 8 to 7\r\nmove 20 from 5 to 8\r\nmove 2 from 9 to 7\r\nmove 8 from 2 to 1\r\nmove 7 from 7 to 3\r\nmove 1 from 2 to 1\r\nmove 3 from 7 to 9\r\nmove 4 from 8 to 3\r\nmove 5 from 5 to 6\r\nmove 1 from 5 to 9\r\nmove 4 from 9 to 4\r\nmove 1 from 5 to 9\r\nmove 2 from 3 to 6\r\nmove 1 from 5 to 8\r\nmove 7 from 6 to 3\r\nmove 1 from 4 to 1\r\nmove 7 from 3 to 2\r\nmove 3 from 3 to 5\r\nmove 2 from 4 to 7";

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
void MoveCrane(string instruction)
{
    var instructionArray = instruction.Split(' ');

    for (int i = 0; i < int.Parse(instructionArray[1]); i++)
    {
        stacks[int.Parse(instructionArray[5]) - 1].Push(stacks[int.Parse(instructionArray[3]) - 1].Pop());
    }
}

void MoveCraneV2(string instruction)
{
    var instructionArray = instruction.Split(' ');
    var indexTo = int.Parse(instructionArray[5]) - 1;
    var indexFrom = int.Parse(instructionArray[3]) - 1;
    int nb = int.Parse(instructionArray[1]);
    stacksV2[indexTo].AddRange(stacksV2[indexFrom].TakeLast(nb));
    stacksV2[indexFrom].RemoveRange(stacksV2[indexFrom].Count - nb, nb);

}
////////
foreach (var instruction in instructions.Split("\r\n"))
{
    MoveCrane(instruction);
}

foreach (var stack in stacks)
{
    Console.Write(stack.Peek());
}
Console.WriteLine();
//////////////

foreach (var instruction in instructions.Split("\r\n"))
{
    MoveCraneV2(instruction);
}

foreach (var stack in stacksV2)
{
    Console.Write(stack.Last());
}
Console.WriteLine();

