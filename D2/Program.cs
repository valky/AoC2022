﻿// See https://aka.ms/new-console-template for more information

string win = "A Y|B Z|C X";
string draw = "A X|B Y|C Z";
string loose = "A Z|B X|C Y";

int CountRoundResult(string input)
{
    char yourMove = input[2];
    int score = yourMove == 'X' ? 1 : yourMove == 'Y' ? 2 : 3;

    score += input switch
    {
        var n when win.Contains(n) => 6,
        var n when draw.Contains(n) => 3,
        var n when loose.Contains(n) => 0,
        _ => throw new Exception()
    };

    return score;
}

int CountRoundResultV2(string input)
{
    return (input[0], input[2]) switch
    {
        ('A', 'X') => 3,  // 0 (loose) + 3(sci)
        ('A', 'Y') => 4,  // 3 (draw)  + 1(rock)
        ('A', 'Z') => 8,  // 6 (win)   + 2(paper)
        ('B', 'X') => 1,  // 0 (loose) + 1(rock)
        ('B', 'Y') => 5,  // 3 (draw)  + 2(paper)
        ('B', 'Z') => 9,  // 6 (win)   + 3(sci)
        ('C', 'X') => 2,  // 0 (loose) + 2(papper)
        ('C', 'Y') => 6,  // 3 (draw)  + 3(sci)
        ('C', 'Z') => 7,  // 6 (win)   + 1(rock)
        (_, _) => throw new Exception(input)
    };
}

//string inputs = "A Y\r\nB X\r\nC Z";
string inputs = "B Y\r\nA Z\r\nA Z\r\nC Z\r\nB Y\r\nB Y\r\nB X\r\nB Z\r\nC Z\r\nB X\r\nB Y\r\nA Z\r\nB Y\r\nB Z\r\nB Y\r\nC Z\r\nB Z\r\nB Y\r\nB Z\r\nC Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nA Z\r\nB Y\r\nB X\r\nA Z\r\nB X\r\nA Z\r\nA Z\r\nB Y\r\nB Y\r\nB X\r\nA Z\r\nB Y\r\nB Z\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nC X\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nB Y\r\nB Z\r\nB X\r\nB X\r\nA Z\r\nA X\r\nB Y\r\nB Y\r\nB Z\r\nC Z\r\nB Z\r\nB Z\r\nB Z\r\nA Z\r\nA Z\r\nB X\r\nB X\r\nB Y\r\nB X\r\nB X\r\nC Z\r\nC Z\r\nA Z\r\nA Y\r\nA Z\r\nB Z\r\nA Z\r\nB Y\r\nC X\r\nB X\r\nC X\r\nB Z\r\nB Z\r\nC Z\r\nB Z\r\nB X\r\nC X\r\nA Z\r\nC X\r\nB Z\r\nA Y\r\nC Z\r\nB Y\r\nC Y\r\nB X\r\nA X\r\nB Y\r\nB X\r\nB X\r\nB Z\r\nB Y\r\nA Z\r\nB Z\r\nB Y\r\nB Y\r\nA X\r\nA Z\r\nB X\r\nB X\r\nB X\r\nB X\r\nB Z\r\nB Z\r\nB Y\r\nC X\r\nA Z\r\nA Z\r\nB Y\r\nB Z\r\nB Y\r\nA Z\r\nB Z\r\nA Z\r\nA Z\r\nC X\r\nB Z\r\nA Z\r\nA Z\r\nB Y\r\nB Z\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nB Z\r\nB Y\r\nB X\r\nC X\r\nB X\r\nB X\r\nB X\r\nA Z\r\nA Z\r\nC Y\r\nA Z\r\nB Y\r\nA Z\r\nC X\r\nB Z\r\nB Z\r\nC X\r\nB Y\r\nC X\r\nB X\r\nB X\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nB X\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nB Y\r\nB Y\r\nA X\r\nA Z\r\nA Z\r\nB Y\r\nC X\r\nC Y\r\nB Y\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nA Z\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nB X\r\nB Y\r\nA Z\r\nB Y\r\nB X\r\nB X\r\nC X\r\nB Y\r\nC Y\r\nA Z\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nC X\r\nA Y\r\nA Y\r\nB Z\r\nB Y\r\nA Z\r\nB Z\r\nB X\r\nB X\r\nB Y\r\nA Z\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nB Z\r\nA Y\r\nC X\r\nB Y\r\nB Y\r\nB Z\r\nB Z\r\nB Y\r\nC X\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nB X\r\nB Y\r\nC Z\r\nB Y\r\nB X\r\nA Z\r\nB Z\r\nB Z\r\nA Z\r\nC X\r\nB Y\r\nC Z\r\nA Z\r\nB Y\r\nC Z\r\nB Y\r\nB X\r\nB Y\r\nB X\r\nC Z\r\nB Z\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nB Z\r\nB Y\r\nB X\r\nB Y\r\nA Z\r\nB Z\r\nC Z\r\nB X\r\nB Z\r\nB Z\r\nA Z\r\nB Y\r\nB X\r\nA Z\r\nA Z\r\nB Y\r\nB X\r\nA Z\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nB Y\r\nB Y\r\nB Z\r\nC X\r\nA Z\r\nB X\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nB X\r\nB Z\r\nB X\r\nC Z\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nB X\r\nB X\r\nA Y\r\nC X\r\nB Y\r\nA Y\r\nB Z\r\nB X\r\nA Z\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nB Y\r\nB X\r\nC Z\r\nB Z\r\nC X\r\nB Z\r\nB Y\r\nC X\r\nA Z\r\nB Y\r\nA Z\r\nA Z\r\nB Z\r\nB Y\r\nB X\r\nA Z\r\nB X\r\nB Y\r\nA Z\r\nB Z\r\nB X\r\nB X\r\nA Z\r\nC Y\r\nB X\r\nA Z\r\nB X\r\nB Y\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB X\r\nA Y\r\nA Z\r\nB Z\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nC Z\r\nB Y\r\nA Z\r\nB X\r\nA Z\r\nC X\r\nA X\r\nB Z\r\nB Z\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nA Z\r\nB Z\r\nA Z\r\nB Y\r\nB Z\r\nC Z\r\nA Y\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nB Z\r\nB Z\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nA Z\r\nB Z\r\nA Z\r\nC X\r\nB Y\r\nB X\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nC X\r\nB Y\r\nB X\r\nB Y\r\nC X\r\nA X\r\nA Z\r\nC Z\r\nB Y\r\nC Z\r\nB X\r\nC Z\r\nC X\r\nC Z\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nB Y\r\nC X\r\nA Y\r\nB Y\r\nB X\r\nB X\r\nB Z\r\nB Y\r\nC Y\r\nC X\r\nB X\r\nB Y\r\nB Z\r\nB X\r\nB Z\r\nB Z\r\nC X\r\nB X\r\nB Y\r\nB Z\r\nB X\r\nC Z\r\nA Y\r\nB Y\r\nB Y\r\nB Y\r\nA Y\r\nC Y\r\nB Y\r\nB Z\r\nB Z\r\nB Y\r\nB Y\r\nB Z\r\nB X\r\nB X\r\nB Y\r\nA Z\r\nC Y\r\nC Z\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nC X\r\nA Z\r\nB X\r\nC X\r\nC Z\r\nA Z\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nA Z\r\nB Y\r\nA Y\r\nB Y\r\nA Z\r\nA Z\r\nB X\r\nC X\r\nA Z\r\nB X\r\nB Z\r\nA Z\r\nA Z\r\nB X\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nB Y\r\nB Z\r\nC X\r\nC X\r\nB Y\r\nA Z\r\nB X\r\nB X\r\nB Y\r\nB Z\r\nB Y\r\nB X\r\nB Z\r\nB X\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC Y\r\nA Z\r\nB Y\r\nB X\r\nB Y\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nB Z\r\nB X\r\nA Z\r\nB Y\r\nB X\r\nB X\r\nA Z\r\nB Y\r\nA Z\r\nB Z\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nB Z\r\nC Z\r\nB Y\r\nB Y\r\nC Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Z\r\nB X\r\nA Z\r\nB Z\r\nC X\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB X\r\nA Z\r\nA Z\r\nC Z\r\nB X\r\nB X\r\nB Y\r\nB Z\r\nB Z\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nA Z\r\nA Y\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nB X\r\nB Y\r\nA Z\r\nC Z\r\nB Z\r\nB Z\r\nB Y\r\nA Z\r\nA Z\r\nB Y\r\nB X\r\nB Z\r\nB X\r\nB Y\r\nB Y\r\nB X\r\nC X\r\nB Z\r\nB X\r\nA Z\r\nB Y\r\nC Z\r\nB X\r\nA Z\r\nC Z\r\nC Z\r\nA Z\r\nB Y\r\nB Y\r\nA Y\r\nB Y\r\nC Z\r\nB X\r\nC X\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nA Z\r\nB X\r\nB X\r\nA Y\r\nB Z\r\nB X\r\nB Z\r\nA Y\r\nB Z\r\nC X\r\nB X\r\nB X\r\nB Z\r\nB X\r\nC Y\r\nB Y\r\nC X\r\nC X\r\nB Z\r\nB X\r\nC Z\r\nB Z\r\nA Z\r\nC Y\r\nB Y\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nB Y\r\nB X\r\nC X\r\nB Y\r\nB Y\r\nC Y\r\nB Z\r\nC X\r\nA Z\r\nB X\r\nB X\r\nB Z\r\nB X\r\nB Y\r\nA Z\r\nB Z\r\nB X\r\nA Z\r\nB Y\r\nC X\r\nA Y\r\nA Z\r\nC X\r\nB X\r\nB Z\r\nB X\r\nC X\r\nA Z\r\nB X\r\nB Y\r\nB Y\r\nA Z\r\nB Z\r\nC X\r\nA Z\r\nB Z\r\nC X\r\nB X\r\nA Z\r\nC X\r\nC Z\r\nB Y\r\nB Z\r\nB Y\r\nB X\r\nC Z\r\nB Z\r\nB Z\r\nB Y\r\nA Z\r\nC Z\r\nA Y\r\nB Y\r\nC X\r\nB Y\r\nB Z\r\nA Z\r\nB Z\r\nA Z\r\nB X\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nB X\r\nC Z\r\nB Z\r\nC X\r\nB Y\r\nB X\r\nC Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nC X\r\nB Z\r\nB Y\r\nA Z\r\nB X\r\nC X\r\nB Y\r\nB X\r\nA Z\r\nC Z\r\nA Z\r\nB Z\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nA Z\r\nC X\r\nC Z\r\nA Y\r\nA Z\r\nC X\r\nC Y\r\nC Z\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nB X\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nB X\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nC Z\r\nB X\r\nB Y\r\nB Y\r\nB Z\r\nB X\r\nB X\r\nB Z\r\nB Z\r\nA Z\r\nA Z\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB X\r\nA Y\r\nC Z\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Z\r\nB Y\r\nB Z\r\nB X\r\nB Z\r\nB Y\r\nA Z\r\nB X\r\nB Z\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nA Z\r\nB X\r\nB Y\r\nB Z\r\nB X\r\nB Y\r\nB X\r\nB X\r\nB Y\r\nB X\r\nC Y\r\nB Z\r\nB Y\r\nB Z\r\nC Y\r\nA Z\r\nB Y\r\nA Z\r\nB X\r\nA Z\r\nA Z\r\nC Z\r\nB X\r\nC Y\r\nA Z\r\nB Z\r\nB Z\r\nB X\r\nB Z\r\nB Y\r\nA Z\r\nB Z\r\nC Z\r\nA Z\r\nC Y\r\nA Z\r\nB Y\r\nA Z\r\nB Y\r\nA Z\r\nB X\r\nA Z\r\nB Z\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Z\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nB Y\r\nB Z\r\nB X\r\nB Y\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Z\r\nB Z\r\nB X\r\nB Z\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nC X\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB X\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nB X\r\nB X\r\nA Y\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB X\r\nB X\r\nC Z\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Z\r\nB X\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nC Z\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nB X\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nB Z\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nC Z\r\nB Z\r\nB X\r\nA Z\r\nB X\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nB X\r\nC Z\r\nC Z\r\nB X\r\nB Y\r\nB Y\r\nB Z\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nA Z\r\nA Z\r\nB X\r\nB Y\r\nB Z\r\nB Y\r\nB Z\r\nB Y\r\nB Z\r\nC X\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC Y\r\nA Z\r\nB X\r\nC Z\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB X\r\nB Y\r\nA Z\r\nC Y\r\nB Y\r\nA Z\r\nB Y\r\nB Z\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nA Y\r\nC Y\r\nB X\r\nB X\r\nB X\r\nB X\r\nB Z\r\nB X\r\nB Z\r\nB Y\r\nB Y\r\nA Z\r\nB X\r\nB X\r\nA Z\r\nA Y\r\nB Y\r\nB Z\r\nB Y\r\nC X\r\nB Y\r\nB X\r\nB Z\r\nC X\r\nB Z\r\nB Y\r\nB X\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nA X\r\nB X\r\nC X\r\nB X\r\nC X\r\nB X\r\nA X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nC Y\r\nC X\r\nA Z\r\nB Z\r\nB Z\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nB X\r\nB Z\r\nA Z\r\nA Z\r\nB Z\r\nB X\r\nB Z\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nA Y\r\nB X\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Z\r\nC X\r\nA Z\r\nA Z\r\nB Z\r\nA Y\r\nC X\r\nB X\r\nB X\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nB Y\r\nB Z\r\nA X\r\nA X\r\nB Y\r\nC X\r\nA Z\r\nB Z\r\nA Z\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nB Y\r\nC X\r\nB Z\r\nB Y\r\nB X\r\nB X\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nB X\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nA Z\r\nC X\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nB X\r\nA Z\r\nC Y\r\nB X\r\nB Z\r\nB Y\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nA Z\r\nB Y\r\nB Z\r\nB Y\r\nA Z\r\nB Y\r\nB Z\r\nA Z\r\nC Z\r\nB Y\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nB X\r\nB X\r\nB Y\r\nB Z\r\nB X\r\nB Y\r\nC Z\r\nA X\r\nB Y\r\nC X\r\nA X\r\nB X\r\nB X\r\nB Z\r\nA X\r\nB X\r\nB Y\r\nB X\r\nA Z\r\nB Z\r\nC Z\r\nB X\r\nB X\r\nA Z\r\nB X\r\nB X\r\nB Z\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nB X\r\nB Y\r\nA Y\r\nC X\r\nB X\r\nA Z\r\nB X\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nA Z\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nB X\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nB X\r\nA X\r\nA Z\r\nB Y\r\nB X\r\nB Z\r\nB Z\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nA Z\r\nC X\r\nB Z\r\nB X\r\nB Z\r\nA Z\r\nB Y\r\nB Z\r\nB X\r\nA Z\r\nA Z\r\nC X\r\nB X\r\nA Y\r\nC X\r\nB Z\r\nB Z\r\nC Z\r\nB Z\r\nB Z\r\nC Y\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nB Z\r\nB Y\r\nC X\r\nB Y\r\nB X\r\nA Z\r\nC Y\r\nB X\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nA Z\r\nA Z\r\nB Y\r\nB Z\r\nB Y\r\nC X\r\nB X\r\nB Y\r\nB X\r\nA Z\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nC Z\r\nA X\r\nC Z\r\nB X\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nB Y\r\nC X\r\nB Z\r\nC Y\r\nB Z\r\nB Z\r\nB Z\r\nB X\r\nB X\r\nB X\r\nB Z\r\nB X\r\nC X\r\nB Y\r\nC X\r\nB X\r\nC Z\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nA Z\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nA Y\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nC Z\r\nB X\r\nB Y\r\nB Y\r\nB Z\r\nC Z\r\nC X\r\nA Z\r\nC X\r\nA X\r\nB X\r\nB Z\r\nB Y\r\nA Z\r\nC Z\r\nB Y\r\nC Z\r\nB X\r\nA Z\r\nB X\r\nA Z\r\nB Y\r\nA Y\r\nB Y\r\nB Y\r\nA Z\r\nC X\r\nB X\r\nB Y\r\nA Z\r\nB Z\r\nB Y\r\nB X\r\nB X\r\nC Y\r\nB X\r\nA Z\r\nB Z\r\nA Z\r\nC X\r\nC Y\r\nB Z\r\nB Z\r\nA Z\r\nB X\r\nB Y\r\nB X\r\nC X\r\nB Y\r\nB Y\r\nB X\r\nC X\r\nB X\r\nB Y\r\nB X\r\nB Y\r\nB Z\r\nB Y\r\nB X\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nC X\r\nC Y\r\nC X\r\nA Z\r\nA Z\r\nB X\r\nB X\r\nB Z\r\nA Z\r\nA Z\r\nC Z\r\nB Z\r\nA X\r\nB X\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB X\r\nB X\r\nB X\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nA Z\r\nB Y\r\nB X\r\nC X\r\nA Y\r\nB Y\r\nB Y\r\nB Z\r\nC Z\r\nB X\r\nC X\r\nB Z\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nB X\r\nA Z\r\nB X\r\nA Y\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nB Y\r\nB X\r\nB X\r\nB X\r\nC Z\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nB X\r\nA Y\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nB Z\r\nB X\r\nB Z\r\nB X\r\nB Y\r\nA Y\r\nA Z\r\nC Y\r\nB Z\r\nC X\r\nB Z\r\nB Y\r\nB X\r\nA Y\r\nB Y\r\nB X\r\nB Y\r\nB X\r\nC Z\r\nB X\r\nC Z\r\nB Y\r\nB X\r\nB Z\r\nA Y\r\nA Y\r\nC Z\r\nB X\r\nB X\r\nB Y\r\nA Z\r\nB Y\r\nB Z\r\nA Z\r\nB X\r\nB X\r\nB X\r\nB X\r\nB X\r\nB Z\r\nA Z\r\nA Z\r\nC Y\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nB X\r\nB X\r\nB Z\r\nB X\r\nA Z\r\nB Y\r\nB X\r\nB Y\r\nC X\r\nA Z\r\nB Z\r\nC X\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nC Y\r\nB X\r\nB Z\r\nB Y\r\nA Z\r\nB Z\r\nA Y\r\nB Y\r\nA Z\r\nB X\r\nB Y\r\nA Z\r\nB Y\r\nC Z\r\nB Z\r\nB Y\r\nC X\r\nC X\r\nB X\r\nB Z\r\nB Y\r\nB Z\r\nB Z\r\nB Z\r\nB Z\r\nA Z\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nB X\r\nA Z\r\nA Z\r\nA Z\r\nB Y\r\nC Y\r\nC Z\r\nB Z\r\nB X\r\nB Y\r\nB Z\r\nB Y\r\nA Z\r\nA Z\r\nC Z\r\nB X\r\nB Y\r\nB Z\r\nB X\r\nA Y\r\nA Y\r\nB Y\r\nA Y\r\nB Z\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nB X\r\nB Z\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB X\r\nB Y\r\nB Z\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nC X\r\nC X\r\nB Z\r\nA Z\r\nA Z\r\nB Z\r\nB Y\r\nB X\r\nA Z\r\nC Z\r\nB Y\r\nB X\r\nC Z\r\nC X\r\nB X\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nB Y\r\nA Z\r\nB X\r\nB X\r\nB X\r\nB Y\r\nA Y\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nB Z\r\nB X\r\nB Z\r\nC X\r\nB Y\r\nB Z\r\nC X\r\nB X\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nA Z\r\nB Y\r\nB X\r\nC Z\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nC X\r\nA Z\r\nC Z\r\nB Z\r\nB X\r\nB X\r\nA Z\r\nB X\r\nB Z\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nC Y\r\nC Z\r\nB X\r\nA Z\r\nB Z\r\nB Y\r\nC Z\r\nC X\r\nB X\r\nA Z\r\nB Y\r\nB Z\r\nB X\r\nA Z\r\nA Z\r\nA Z\r\nB Y\r\nB X\r\nC X\r\nB Z\r\nB Z\r\nB X\r\nB X\r\nB Y\r\nA Z\r\nB X\r\nB X\r\nB Z\r\nA Z\r\nC X\r\nB X\r\nB Y\r\nB Z\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Z\r\nA Y\r\nA Z\r\nB Z\r\nC X\r\nA Z\r\nA Z\r\nB Y\r\nC X\r\nB Y\r\nB Z\r\nC X\r\nB Y\r\nB Y\r\nA Z\r\nB Z\r\nA Z\r\nC Z\r\nA Z\r\nB X\r\nB Z\r\nA Z\r\nB X\r\nB Y\r\nC Z\r\nA Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Z\r\nA Y\r\nA Z\r\nB Z\r\nB Y\r\nB Y\r\nA Y\r\nB Y\r\nC X\r\nB Z\r\nB Z\r\nA Z\r\nB X\r\nB X\r\nA Z\r\nB Z\r\nC Y\r\nA Z\r\nA Z\r\nB Y\r\nB Z\r\nB X\r\nC Y\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nB Z\r\nB X\r\nB X\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nB X\r\nB X\r\nC X\r\nA Z\r\nB Y\r\nC Z\r\nA Z\r\nB X\r\nB Y\r\nB Z\r\nA Z\r\nC Y\r\nA Z\r\nB Z\r\nA Z\r\nC X\r\nC X\r\nB X\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nB X\r\nB Z\r\nC Y\r\nB Y\r\nA Z\r\nB Y\r\nB X\r\nA Y\r\nB Y\r\nB Z\r\nC X\r\nB X\r\nA Z\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nC X\r\nB X\r\nB Y\r\nB Y\r\nB Z\r\nA Z\r\nA Z\r\nC Z\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Z\r\nB Y\r\nA Z\r\nA Y\r\nB Y\r\nB Y\r\nB Z\r\nA X\r\nA Z\r\nB Z\r\nB X\r\nA Z\r\nB Z\r\nB Y\r\nB Y\r\nB X\r\nA Y\r\nC Y\r\nB Y\r\nB Y\r\nB X\r\nB Z\r\nA Z\r\nB X\r\nB X\r\nB Y\r\nB Y\r\nA Z\r\nB X\r\nC X\r\nB X\r\nB X\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nB X\r\nC Z\r\nA Z\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nA Z\r\nC Z\r\nB X\r\nB X\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB X\r\nA Z\r\nB Y\r\nB Z\r\nB X\r\nA Z\r\nB Y\r\nC Z\r\nC X\r\nA Z\r\nA Y\r\nB X\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nB Z\r\nA Y\r\nC X\r\nB X\r\nC X\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nC Y\r\nC X\r\nB Z\r\nC X\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nB Y\r\nA Z\r\nB X\r\nB X\r\nB X\r\nC Z\r\nB Z\r\nC Y\r\nB Y\r\nA Z\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Z\r\nC Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB Z\r\nA Z\r\nB Y\r\nB Y\r\nC Y\r\nB Z\r\nB X\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nC Y\r\nC Y\r\nA Z\r\nB X\r\nB X\r\nA Y\r\nB Z\r\nA Z\r\nB Y\r\nB X\r\nB X\r\nB Z\r\nB X\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nB Z\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nB Z\r\nB Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA Y\r\nC X\r\nB Y\r\nB Z\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nC Y\r\nC Y\r\nB X\r\nA Z\r\nB Y\r\nC X\r\nB Y\r\nA Y\r\nB X\r\nB X\r\nB Y\r\nC X\r\nA Z\r\nB Y\r\nB X\r\nC X\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB X\r\nA Z\r\nC Z\r\nB Z\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nB X\r\nA Z\r\nC X\r\nC Z\r\nB X\r\nB Y\r\nC Y\r\nB X\r\nA Z\r\nB Y\r\nA Z\r\nB Y\r\nA Y\r\nA Z\r\nA Z\r\nB Y\r\nB Y\r\nB Z\r\nC Z\r\nC X\r\nB Y\r\nB Z\r\nB Y\r\nA Z\r\nB Y\r\nB Z\r\nB Y\r\nB X\r\nB Y\r\nB Z\r\nB Y\r\nB Z\r\nC X\r\nB Y\r\nB Y\r\nC Z\r\nA Z\r\nB Y\r\nC X\r\nB X\r\nA Y\r\nB Y\r\nA Z\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nB X\r\nB Y\r\nB Y\r\nC Z\r\nB Z\r\nC X\r\nC Z\r\nB Y\r\nC X\r\nB X\r\nA Z\r\nB Y\r\nC Z\r\nA Y\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB X\r\nB Y\r\nB Y\r\nB Z\r\nC X\r\nB X\r\nB Z\r\nA Z\r\nB X\r\nB Z\r\nB X\r\nA Z\r\nB Y\r\nB Z\r\nC X\r\nB X\r\nC X\r\nB X\r\nB Y\r\nB Z\r\nB Z\r\nB Z\r\nA Z\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nB X\r\nB Z\r\nB Y\r\nC X\r\nA Z\r\nB Z\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nC X\r\nB X\r\nA Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nA Z\r\nC Y\r\nB Z\r\nA Y\r\nB Y\r\nB X\r\nB X\r\nB Y\r\nC X\r\nB Y\r\nC Z\r\nB Y\r\nA X\r\nB Y\r\nB X\r\nB Y\r\nB X\r\nC Z\r\nB Y\r\nB Z\r\nB X\r\nB Z\r\nA Z\r\nB Y\r\nB X\r\nB Y\r\nA Z\r\nB X\r\nC Y\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Z\r\nC X\r\nA Z\r\nB Y\r\nC Y\r\nB X\r\nA Z\r\nC Z\r\nB X\r\nB Y\r\nB X\r\nC Z\r\nB X\r\nB Z\r\nC Y\r\nB X\r\nB Y\r\nB X\r\nB Z\r\nB X\r\nB Z\r\nB Y\r\nB Z\r\nB X\r\nA Z\r\nB X\r\nA X\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Z\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nB X\r\nC Z\r\nB Z\r\nB X\r\nA Z\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nB Z\r\nB Y\r\nB Y\r\nB Z\r\nA Z\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nC Y\r\nA Z\r\nB Z\r\nC X\r\nB X\r\nC Z\r\nB X\r\nB X\r\nB Y\r\nB Y\r\nA X\r\nB Y\r\nC Z\r\nA Z\r\nB X\r\nC Z\r\nC Z\r\nB X\r\nA Z\r\nB X\r\nC Z\r\nB Z\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nB X\r\nB Y\r\nB X\r\nB X\r\nB X\r\nB Y\r\nC X\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nA Z\r\nA Z\r\nB Y\r\nB Z\r\nB Y\r\nA Z\r\nB Y\r\nB X\r\nA Z\r\nB Z\r\nB Y\r\nB X\r\nB Y\r\nA Y\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nB X\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nC Y\r\nB Z\r\nA Z\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nB Z\r\nB Y\r\nB X\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nB X\r\nB X\r\nB Y\r\nA Y\r\nB Y\r\nB Z\r\nB X\r\nB Y\r\nB Y\r\nA Z\r\nB X\r\nB Y\r\nA Z\r\nA Y\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA X\r\nB Y\r\nB Y\r\nA Z\r\nB X\r\nB Z\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nB X\r\nC Z\r\nC Z\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nA Z\r\nC Z\r\nB Y\r\nA Z\r\nB Z\r\nB X\r\nA Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nA Z\r\nC Z\r\nA Z\r\nB Y\r\nB Z\r\nA Z\r\nB X\r\nB X\r\nB Z\r\nB X\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nC Z\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nC Z\r\nB Z\r\nA Z\r\nB Y\r\nB X\r\nB Y\r\nB Z\r\nC Z\r\nA Y\r\nA Z\r\nB X\r\nB X\r\nA Z\r\nC Y\r\nB Y\r\nA X\r\nA Z\r\nB X\r\nB Y\r\nB X\r\nA Z\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nA X\r\nB Y\r\nA Z\r\nA Z\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB X\r\nB X\r\nB X\r\nB Y\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nB X\r\nB Z\r\nB Y\r\nA Z";

var resultP1 = inputs.Split("\r\n").Select(i => CountRoundResult(i)).Sum();


Console.WriteLine(resultP1);

var resultP2 = inputs.Split("\r\n").Select(i => CountRoundResultV2(i)).Sum();

Console.WriteLine(resultP2);


