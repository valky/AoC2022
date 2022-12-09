using System.Runtime.CompilerServices;

var inputs = "R 4\r\nU 4\r\nL 3\r\nD 1\r\nR 4\r\nD 1\r\nL 5\r\nR 2";         // => 1
//var inputs = "R 5\r\nU 8\r\nL 8\r\nD 3\r\nR 17\r\nD 10\r\nL 25\r\nU 20";   // => 36
//var inputs = "U 1\r\nR 2\r\nD 2\r\nU 2\r\nL 1\r\nU 1\r\nR 1\r\nU 2\r\nR 1\r\nD 1\r\nU 2\r\nL 1\r\nR 1\r\nU 1\r\nL 1\r\nD 1\r\nL 1\r\nD 1\r\nU 2\r\nR 2\r\nU 1\r\nL 1\r\nR 2\r\nU 2\r\nL 2\r\nU 2\r\nR 2\r\nD 2\r\nR 1\r\nU 2\r\nL 2\r\nU 1\r\nR 1\r\nL 2\r\nU 2\r\nR 2\r\nL 1\r\nR 2\r\nL 1\r\nD 1\r\nR 2\r\nL 2\r\nD 2\r\nL 1\r\nD 1\r\nL 2\r\nU 1\r\nR 2\r\nL 2\r\nU 2\r\nD 2\r\nR 2\r\nD 2\r\nL 2\r\nD 2\r\nL 1\r\nD 2\r\nL 1\r\nR 2\r\nL 2\r\nR 1\r\nD 2\r\nU 1\r\nR 2\r\nL 1\r\nR 2\r\nD 1\r\nU 1\r\nR 1\r\nU 2\r\nD 2\r\nR 1\r\nD 1\r\nU 1\r\nL 2\r\nD 2\r\nU 1\r\nR 2\r\nL 2\r\nR 1\r\nD 2\r\nL 1\r\nU 1\r\nD 1\r\nU 2\r\nD 1\r\nU 1\r\nD 2\r\nR 2\r\nL 1\r\nD 1\r\nU 1\r\nR 1\r\nL 2\r\nD 1\r\nL 2\r\nR 1\r\nL 2\r\nU 2\r\nR 1\r\nL 2\r\nD 2\r\nL 2\r\nU 2\r\nL 1\r\nU 2\r\nR 2\r\nL 2\r\nR 2\r\nL 2\r\nU 1\r\nL 1\r\nU 1\r\nD 1\r\nU 3\r\nR 2\r\nL 3\r\nR 2\r\nD 2\r\nU 3\r\nR 1\r\nL 3\r\nD 1\r\nU 3\r\nR 2\r\nD 1\r\nU 3\r\nR 2\r\nL 3\r\nR 3\r\nL 2\r\nR 1\r\nU 2\r\nR 2\r\nU 3\r\nD 1\r\nU 3\r\nL 2\r\nD 1\r\nR 2\r\nU 3\r\nR 3\r\nL 3\r\nD 3\r\nR 3\r\nU 3\r\nL 3\r\nU 1\r\nL 2\r\nU 3\r\nL 1\r\nU 1\r\nD 3\r\nR 3\r\nU 1\r\nR 1\r\nU 1\r\nL 3\r\nR 2\r\nU 2\r\nL 3\r\nD 1\r\nL 2\r\nD 2\r\nL 2\r\nR 2\r\nU 3\r\nD 3\r\nR 2\r\nU 3\r\nL 2\r\nU 1\r\nD 2\r\nR 3\r\nL 1\r\nU 1\r\nR 2\r\nD 3\r\nL 1\r\nR 1\r\nU 1\r\nD 3\r\nR 2\r\nD 3\r\nR 2\r\nU 1\r\nL 2\r\nU 1\r\nR 2\r\nU 1\r\nR 2\r\nL 2\r\nU 2\r\nR 3\r\nL 3\r\nD 2\r\nL 1\r\nR 3\r\nD 1\r\nU 1\r\nL 2\r\nR 1\r\nD 3\r\nU 3\r\nD 3\r\nU 1\r\nR 2\r\nL 3\r\nR 1\r\nL 3\r\nR 2\r\nD 2\r\nU 1\r\nD 1\r\nL 3\r\nR 1\r\nL 3\r\nR 3\r\nL 1\r\nD 2\r\nL 3\r\nU 2\r\nD 1\r\nL 1\r\nU 2\r\nR 3\r\nL 2\r\nR 3\r\nU 3\r\nL 2\r\nD 4\r\nU 4\r\nR 3\r\nU 2\r\nL 1\r\nU 3\r\nD 4\r\nL 2\r\nU 3\r\nL 4\r\nD 4\r\nR 3\r\nD 3\r\nR 1\r\nD 2\r\nL 1\r\nR 2\r\nD 3\r\nL 1\r\nR 2\r\nU 3\r\nD 4\r\nR 4\r\nL 2\r\nR 4\r\nU 3\r\nR 4\r\nU 4\r\nL 4\r\nD 3\r\nR 4\r\nD 1\r\nU 3\r\nL 3\r\nR 1\r\nU 2\r\nR 3\r\nU 4\r\nD 2\r\nU 3\r\nD 2\r\nL 2\r\nD 3\r\nL 4\r\nR 2\r\nU 2\r\nL 2\r\nU 4\r\nD 2\r\nU 4\r\nL 4\r\nU 2\r\nR 3\r\nD 4\r\nU 4\r\nL 3\r\nD 3\r\nR 4\r\nL 3\r\nR 2\r\nL 4\r\nU 3\r\nD 2\r\nL 4\r\nR 1\r\nU 2\r\nL 3\r\nD 1\r\nR 2\r\nU 2\r\nD 4\r\nR 1\r\nU 1\r\nR 2\r\nD 2\r\nL 3\r\nR 1\r\nU 2\r\nR 1\r\nD 4\r\nU 1\r\nR 1\r\nU 3\r\nD 1\r\nU 2\r\nD 3\r\nU 3\r\nL 2\r\nU 4\r\nR 1\r\nL 2\r\nD 2\r\nL 2\r\nD 3\r\nU 3\r\nL 3\r\nU 1\r\nD 1\r\nR 1\r\nD 2\r\nL 2\r\nU 2\r\nD 3\r\nR 1\r\nL 4\r\nU 3\r\nL 5\r\nR 5\r\nL 4\r\nD 4\r\nR 4\r\nL 4\r\nR 4\r\nL 2\r\nR 3\r\nD 3\r\nR 2\r\nL 4\r\nR 2\r\nU 5\r\nD 5\r\nU 1\r\nR 4\r\nU 2\r\nR 3\r\nL 4\r\nD 2\r\nU 3\r\nD 4\r\nU 2\r\nD 5\r\nL 5\r\nR 2\r\nU 3\r\nR 1\r\nD 1\r\nR 4\r\nU 5\r\nR 3\r\nL 3\r\nU 3\r\nL 1\r\nU 5\r\nD 2\r\nU 3\r\nR 1\r\nD 5\r\nL 4\r\nU 3\r\nD 1\r\nL 3\r\nR 2\r\nU 1\r\nL 2\r\nR 2\r\nD 4\r\nR 2\r\nL 3\r\nU 2\r\nD 1\r\nL 1\r\nR 4\r\nL 1\r\nD 2\r\nR 1\r\nL 5\r\nR 4\r\nU 2\r\nR 2\r\nU 1\r\nD 3\r\nR 3\r\nL 1\r\nU 5\r\nR 2\r\nD 3\r\nU 3\r\nR 1\r\nU 4\r\nR 1\r\nD 2\r\nL 1\r\nD 4\r\nL 1\r\nR 5\r\nL 5\r\nR 5\r\nL 1\r\nU 5\r\nR 2\r\nU 5\r\nL 2\r\nD 3\r\nU 5\r\nL 4\r\nD 5\r\nU 2\r\nR 2\r\nD 2\r\nR 4\r\nL 4\r\nD 5\r\nR 2\r\nL 2\r\nR 5\r\nU 2\r\nL 1\r\nU 2\r\nD 2\r\nR 5\r\nU 1\r\nL 5\r\nR 1\r\nL 4\r\nD 4\r\nL 3\r\nD 4\r\nU 2\r\nL 2\r\nD 5\r\nU 4\r\nR 3\r\nL 6\r\nD 3\r\nR 2\r\nU 2\r\nL 2\r\nU 1\r\nR 6\r\nU 5\r\nR 2\r\nU 2\r\nR 1\r\nU 5\r\nL 3\r\nU 2\r\nR 5\r\nL 3\r\nU 3\r\nD 2\r\nU 5\r\nL 5\r\nU 4\r\nR 6\r\nD 2\r\nL 6\r\nU 1\r\nL 5\r\nD 4\r\nU 3\r\nD 3\r\nU 5\r\nL 6\r\nU 4\r\nD 3\r\nU 4\r\nD 6\r\nR 1\r\nU 4\r\nL 1\r\nD 4\r\nU 5\r\nR 2\r\nL 3\r\nR 2\r\nU 2\r\nD 1\r\nL 3\r\nR 6\r\nL 2\r\nU 5\r\nL 3\r\nD 1\r\nL 2\r\nD 4\r\nU 4\r\nL 4\r\nD 1\r\nL 2\r\nD 2\r\nR 5\r\nL 2\r\nR 2\r\nL 3\r\nR 2\r\nU 2\r\nL 1\r\nU 4\r\nD 4\r\nR 5\r\nL 3\r\nU 2\r\nD 3\r\nR 6\r\nD 3\r\nR 3\r\nL 4\r\nU 5\r\nD 3\r\nR 5\r\nU 4\r\nR 2\r\nU 4\r\nL 1\r\nU 6\r\nD 6\r\nL 1\r\nR 2\r\nU 6\r\nD 5\r\nL 1\r\nU 3\r\nL 1\r\nD 6\r\nL 3\r\nU 4\r\nD 6\r\nU 4\r\nD 3\r\nL 3\r\nU 5\r\nR 2\r\nL 5\r\nD 3\r\nR 2\r\nD 2\r\nU 1\r\nD 2\r\nR 2\r\nU 5\r\nR 4\r\nU 1\r\nR 5\r\nD 2\r\nR 2\r\nU 5\r\nL 6\r\nU 3\r\nL 7\r\nD 1\r\nR 4\r\nD 4\r\nR 7\r\nL 7\r\nU 7\r\nD 4\r\nL 4\r\nR 6\r\nU 6\r\nL 7\r\nR 3\r\nL 6\r\nU 6\r\nR 5\r\nD 4\r\nL 6\r\nU 1\r\nR 6\r\nD 3\r\nU 5\r\nD 3\r\nU 2\r\nR 7\r\nU 5\r\nD 5\r\nL 2\r\nD 2\r\nU 4\r\nL 3\r\nD 1\r\nL 1\r\nR 2\r\nL 2\r\nR 6\r\nD 4\r\nL 7\r\nD 7\r\nR 4\r\nL 6\r\nR 3\r\nL 3\r\nU 7\r\nR 3\r\nL 5\r\nD 6\r\nR 3\r\nU 5\r\nD 3\r\nL 4\r\nU 7\r\nR 6\r\nD 6\r\nU 5\r\nR 3\r\nL 3\r\nR 6\r\nL 3\r\nD 1\r\nL 3\r\nU 5\r\nD 2\r\nL 3\r\nR 4\r\nL 7\r\nR 5\r\nU 3\r\nL 7\r\nD 5\r\nU 6\r\nD 5\r\nL 6\r\nR 6\r\nL 1\r\nR 3\r\nD 4\r\nL 5\r\nR 2\r\nU 4\r\nR 2\r\nD 4\r\nR 3\r\nD 2\r\nL 3\r\nR 2\r\nL 4\r\nR 5\r\nU 7\r\nL 7\r\nD 3\r\nR 5\r\nL 1\r\nU 4\r\nR 5\r\nU 4\r\nR 6\r\nL 1\r\nR 4\r\nD 8\r\nL 2\r\nU 7\r\nL 3\r\nR 3\r\nU 1\r\nD 8\r\nU 5\r\nD 3\r\nR 3\r\nL 2\r\nU 2\r\nD 8\r\nR 3\r\nU 4\r\nL 6\r\nD 7\r\nR 7\r\nU 6\r\nL 7\r\nU 5\r\nR 1\r\nL 2\r\nU 4\r\nD 1\r\nL 6\r\nD 5\r\nR 7\r\nU 7\r\nR 8\r\nL 7\r\nU 7\r\nD 3\r\nL 3\r\nD 4\r\nL 1\r\nR 6\r\nD 5\r\nU 1\r\nD 8\r\nR 1\r\nL 2\r\nU 1\r\nD 2\r\nL 3\r\nR 7\r\nL 2\r\nD 8\r\nR 5\r\nU 6\r\nD 4\r\nL 1\r\nU 6\r\nR 1\r\nD 4\r\nR 4\r\nL 2\r\nD 4\r\nR 1\r\nU 2\r\nR 8\r\nL 6\r\nR 8\r\nU 8\r\nL 3\r\nR 6\r\nD 3\r\nR 2\r\nL 3\r\nU 6\r\nD 6\r\nU 4\r\nR 7\r\nL 3\r\nR 2\r\nL 4\r\nU 3\r\nR 7\r\nD 8\r\nR 1\r\nD 6\r\nU 7\r\nR 2\r\nU 2\r\nL 6\r\nU 5\r\nR 1\r\nD 1\r\nR 6\r\nL 2\r\nU 3\r\nD 2\r\nL 2\r\nD 5\r\nR 4\r\nL 1\r\nD 7\r\nR 6\r\nD 4\r\nU 2\r\nD 5\r\nU 3\r\nD 8\r\nU 6\r\nR 5\r\nL 6\r\nU 7\r\nL 3\r\nR 8\r\nU 3\r\nL 2\r\nR 3\r\nL 5\r\nR 3\r\nL 2\r\nU 9\r\nD 2\r\nU 5\r\nR 7\r\nU 9\r\nL 9\r\nR 6\r\nL 7\r\nD 1\r\nL 4\r\nD 3\r\nR 7\r\nL 6\r\nR 9\r\nD 6\r\nR 4\r\nD 8\r\nL 1\r\nU 5\r\nR 9\r\nD 9\r\nU 6\r\nL 5\r\nR 4\r\nD 2\r\nR 5\r\nD 1\r\nR 6\r\nD 3\r\nR 8\r\nL 1\r\nU 2\r\nR 5\r\nU 3\r\nL 1\r\nR 8\r\nD 6\r\nL 5\r\nD 7\r\nR 3\r\nU 2\r\nL 7\r\nU 3\r\nD 4\r\nL 2\r\nR 8\r\nD 6\r\nL 3\r\nU 5\r\nL 1\r\nU 5\r\nL 4\r\nR 7\r\nU 6\r\nR 1\r\nD 3\r\nU 3\r\nD 2\r\nR 4\r\nL 5\r\nU 2\r\nR 6\r\nL 8\r\nU 6\r\nL 9\r\nD 3\r\nR 3\r\nU 9\r\nD 8\r\nL 2\r\nR 7\r\nD 6\r\nR 1\r\nD 8\r\nU 8\r\nD 2\r\nU 4\r\nD 8\r\nL 9\r\nR 8\r\nD 8\r\nR 7\r\nU 8\r\nL 8\r\nU 8\r\nR 7\r\nL 8\r\nU 3\r\nD 6\r\nR 7\r\nD 2\r\nL 5\r\nU 8\r\nD 7\r\nU 6\r\nR 3\r\nD 7\r\nU 9\r\nL 7\r\nR 3\r\nL 1\r\nU 9\r\nL 7\r\nU 2\r\nD 7\r\nL 5\r\nR 9\r\nD 2\r\nR 7\r\nU 6\r\nD 7\r\nU 3\r\nR 8\r\nU 9\r\nL 8\r\nR 8\r\nD 10\r\nL 7\r\nR 3\r\nU 5\r\nR 5\r\nD 9\r\nU 10\r\nL 2\r\nD 4\r\nL 2\r\nU 1\r\nD 3\r\nL 3\r\nU 7\r\nD 6\r\nL 6\r\nD 7\r\nL 8\r\nU 1\r\nD 9\r\nL 7\r\nU 4\r\nL 3\r\nU 6\r\nD 2\r\nL 5\r\nU 10\r\nD 9\r\nU 8\r\nD 1\r\nR 10\r\nU 4\r\nL 1\r\nR 7\r\nU 2\r\nL 5\r\nD 5\r\nR 7\r\nD 1\r\nR 4\r\nU 2\r\nD 6\r\nL 7\r\nU 10\r\nR 3\r\nL 9\r\nD 7\r\nL 2\r\nR 5\r\nU 10\r\nD 10\r\nR 9\r\nD 5\r\nU 3\r\nL 7\r\nD 5\r\nU 6\r\nD 7\r\nL 6\r\nD 10\r\nR 7\r\nU 8\r\nL 4\r\nD 9\r\nL 4\r\nU 5\r\nR 9\r\nU 9\r\nR 3\r\nU 2\r\nR 2\r\nD 1\r\nR 1\r\nU 6\r\nR 8\r\nD 10\r\nU 2\r\nD 9\r\nL 8\r\nR 1\r\nD 1\r\nL 9\r\nR 8\r\nD 9\r\nR 5\r\nL 9\r\nU 10\r\nD 4\r\nR 7\r\nU 4\r\nL 3\r\nU 8\r\nL 2\r\nU 9\r\nD 9\r\nL 1\r\nR 4\r\nU 2\r\nL 4\r\nU 3\r\nD 7\r\nU 11\r\nR 6\r\nU 9\r\nD 6\r\nR 7\r\nL 1\r\nD 7\r\nR 2\r\nD 6\r\nU 2\r\nL 2\r\nU 4\r\nR 6\r\nU 6\r\nL 11\r\nD 7\r\nR 9\r\nL 2\r\nD 10\r\nL 10\r\nU 4\r\nL 6\r\nD 11\r\nU 9\r\nL 1\r\nR 10\r\nL 7\r\nR 4\r\nD 5\r\nL 3\r\nU 2\r\nR 9\r\nL 9\r\nD 1\r\nL 11\r\nD 5\r\nU 6\r\nD 5\r\nU 9\r\nR 1\r\nL 7\r\nU 3\r\nR 7\r\nL 2\r\nD 6\r\nR 3\r\nU 2\r\nD 5\r\nR 9\r\nL 3\r\nD 11\r\nU 9\r\nD 11\r\nR 2\r\nD 7\r\nR 9\r\nU 4\r\nD 6\r\nU 7\r\nR 10\r\nD 3\r\nL 4\r\nR 9\r\nD 3\r\nL 7\r\nR 7\r\nL 11\r\nD 6\r\nR 9\r\nD 9\r\nR 3\r\nU 3\r\nR 3\r\nL 6\r\nD 11\r\nR 2\r\nL 10\r\nU 2\r\nR 2\r\nD 11\r\nR 7\r\nD 8\r\nR 2\r\nD 10\r\nU 5\r\nD 3\r\nL 10\r\nR 1\r\nD 5\r\nR 4\r\nL 10\r\nU 5\r\nD 9\r\nU 2\r\nL 3\r\nU 3\r\nR 5\r\nD 4\r\nL 1\r\nD 1\r\nR 10\r\nL 4\r\nD 8\r\nL 5\r\nD 5\r\nL 3\r\nD 5\r\nL 3\r\nR 1\r\nL 3\r\nR 4\r\nU 9\r\nR 4\r\nD 12\r\nL 5\r\nR 4\r\nL 11\r\nD 10\r\nU 3\r\nR 2\r\nU 5\r\nL 6\r\nD 5\r\nU 5\r\nD 10\r\nR 12\r\nL 2\r\nR 10\r\nD 11\r\nR 12\r\nU 5\r\nR 4\r\nL 4\r\nU 2\r\nR 12\r\nL 6\r\nD 3\r\nR 2\r\nD 1\r\nU 9\r\nL 6\r\nU 6\r\nL 10\r\nD 8\r\nR 9\r\nL 1\r\nU 1\r\nD 5\r\nU 4\r\nR 10\r\nU 5\r\nR 10\r\nD 12\r\nU 6\r\nD 9\r\nU 3\r\nL 8\r\nR 8\r\nD 7\r\nL 6\r\nU 7\r\nR 1\r\nU 6\r\nD 9\r\nR 2\r\nU 11\r\nD 7\r\nL 12\r\nD 6\r\nL 5\r\nU 8\r\nR 8\r\nL 8\r\nD 3\r\nR 7\r\nL 11\r\nD 1\r\nL 5\r\nD 5\r\nU 8\r\nD 2\r\nR 8\r\nL 6\r\nD 7\r\nL 3\r\nD 3\r\nU 9\r\nL 1\r\nU 8\r\nD 7\r\nL 8\r\nU 4\r\nR 12\r\nU 7\r\nL 10\r\nD 4\r\nU 7\r\nD 7\r\nU 5\r\nL 4\r\nR 9\r\nD 5\r\nR 4\r\nU 2\r\nR 1\r\nD 9\r\nU 7\r\nR 9\r\nU 12\r\nD 4\r\nR 8\r\nU 4\r\nD 10\r\nL 10\r\nD 11\r\nL 8\r\nR 11\r\nU 5\r\nD 4\r\nL 3\r\nD 1\r\nU 7\r\nL 5\r\nR 13\r\nL 2\r\nR 9\r\nL 6\r\nR 6\r\nL 2\r\nU 10\r\nD 11\r\nU 13\r\nR 11\r\nU 6\r\nL 7\r\nD 11\r\nR 7\r\nU 4\r\nL 1\r\nD 9\r\nR 7\r\nL 11\r\nU 13\r\nL 8\r\nR 12\r\nU 5\r\nR 9\r\nU 11\r\nR 3\r\nD 11\r\nU 9\r\nL 8\r\nU 6\r\nD 6\r\nL 11\r\nU 4\r\nD 3\r\nU 11\r\nD 1\r\nL 6\r\nU 5\r\nR 10\r\nL 10\r\nR 8\r\nL 12\r\nR 4\r\nU 3\r\nR 8\r\nL 8\r\nU 4\r\nL 10\r\nU 9\r\nR 8\r\nU 3\r\nD 2\r\nU 4\r\nD 10\r\nL 6\r\nR 10\r\nU 8\r\nL 9\r\nR 13\r\nD 8\r\nU 10\r\nD 10\r\nL 13\r\nU 1\r\nR 4\r\nU 11\r\nD 12\r\nL 1\r\nR 2\r\nU 12\r\nD 7\r\nU 9\r\nR 13\r\nU 5\r\nD 6\r\nR 4\r\nL 6\r\nU 9\r\nL 5\r\nU 8\r\nD 4\r\nL 5\r\nU 6\r\nL 8\r\nU 1\r\nR 3\r\nU 8\r\nR 2\r\nD 5\r\nU 12\r\nD 9\r\nL 2\r\nU 3\r\nR 11\r\nU 9\r\nR 7\r\nD 10\r\nU 2\r\nL 3\r\nD 3\r\nU 9\r\nD 6\r\nU 1\r\nR 9\r\nL 5\r\nR 2\r\nL 2\r\nR 11\r\nD 7\r\nL 10\r\nU 13\r\nL 6\r\nR 11\r\nU 6\r\nD 11\r\nU 4\r\nR 10\r\nD 5\r\nR 4\r\nL 6\r\nU 3\r\nL 8\r\nD 6\r\nU 14\r\nR 3\r\nU 1\r\nL 6\r\nR 7\r\nU 9\r\nL 9\r\nD 10\r\nU 10\r\nD 12\r\nR 9\r\nD 12\r\nR 4\r\nD 12\r\nU 9\r\nR 9\r\nU 2\r\nL 11\r\nD 13\r\nU 12\r\nL 7\r\nD 14\r\nR 4\r\nD 14\r\nU 11\r\nD 5\r\nR 10\r\nL 2\r\nD 11\r\nL 3\r\nU 9\r\nR 4\r\nL 8\r\nU 8\r\nR 7\r\nU 7\r\nD 5\r\nR 8\r\nU 5\r\nL 3\r\nR 7\r\nD 6\r\nR 12\r\nU 3\r\nD 8\r\nL 8\r\nU 3\r\nL 8\r\nR 7\r\nL 13\r\nU 2\r\nL 8\r\nU 14\r\nR 5\r\nL 1\r\nD 14\r\nR 10\r\nU 14\r\nR 6\r\nU 14\r\nD 5\r\nU 13\r\nD 1\r\nU 12\r\nR 7\r\nL 2\r\nU 4\r\nR 10\r\nU 8\r\nR 12\r\nL 2\r\nU 7\r\nD 9\r\nL 6\r\nD 3\r\nU 7\r\nL 11\r\nU 8\r\nR 7\r\nD 5\r\nU 5\r\nR 13\r\nD 9\r\nR 14\r\nU 8\r\nR 14\r\nD 8\r\nU 1\r\nL 13\r\nR 12\r\nD 7\r\nL 6\r\nR 3\r\nD 10\r\nR 10\r\nL 6\r\nD 12\r\nL 5\r\nU 14\r\nD 1\r\nU 8\r\nR 5\r\nD 15\r\nR 11\r\nD 10\r\nL 11\r\nD 13\r\nL 5\r\nD 3\r\nU 15\r\nR 6\r\nL 12\r\nR 12\r\nL 15\r\nU 5\r\nD 8\r\nR 13\r\nD 10\r\nR 4\r\nL 6\r\nU 8\r\nR 6\r\nD 15\r\nU 6\r\nL 13\r\nD 15\r\nU 11\r\nD 6\r\nU 7\r\nL 1\r\nR 5\r\nL 1\r\nU 7\r\nD 15\r\nL 1\r\nD 7\r\nU 6\r\nR 14\r\nD 4\r\nR 5\r\nU 4\r\nD 5\r\nR 13\r\nD 5\r\nL 1\r\nD 11\r\nL 3\r\nD 3\r\nR 13\r\nL 15\r\nD 4\r\nR 4\r\nU 5\r\nL 10\r\nU 14\r\nD 2\r\nR 9\r\nU 8\r\nR 1\r\nU 13\r\nL 5\r\nU 12\r\nR 10\r\nU 8\r\nL 9\r\nD 7\r\nR 10\r\nL 8\r\nR 13\r\nD 12\r\nL 2\r\nR 4\r\nD 14\r\nR 14\r\nD 2\r\nU 4\r\nD 14\r\nU 1\r\nL 3\r\nR 7\r\nL 2\r\nD 10\r\nR 10\r\nL 1\r\nR 5\r\nD 6\r\nL 5\r\nR 11\r\nU 15\r\nL 6\r\nD 4\r\nR 14\r\nD 6\r\nR 1\r\nL 12\r\nR 15\r\nL 10\r\nU 1\r\nD 3\r\nR 2\r\nD 2\r\nL 8\r\nU 9\r\nD 14\r\nL 4\r\nR 2\r\nU 14\r\nL 11\r\nD 12\r\nU 5\r\nL 11\r\nR 5\r\nU 14\r\nR 9\r\nU 12\r\nL 12\r\nD 9\r\nR 10\r\nD 4\r\nL 3\r\nU 4\r\nR 2\r\nD 9\r\nU 5\r\nL 13\r\nU 5\r\nR 15\r\nL 4\r\nR 10\r\nU 8\r\nR 3\r\nU 13\r\nD 4\r\nU 4\r\nL 8\r\nU 1\r\nD 13\r\nR 10\r\nU 13\r\nL 5\r\nU 7\r\nD 2\r\nU 15\r\nR 10\r\nU 12\r\nD 9\r\nR 12\r\nL 3\r\nD 7\r\nR 7\r\nL 3\r\nR 14\r\nL 9\r\nD 4\r\nR 8\r\nD 1\r\nR 1\r\nU 1\r\nR 14\r\nL 7\r\nR 10\r\nD 14\r\nL 1\r\nU 12\r\nD 8\r\nU 1\r\nR 13\r\nU 12\r\nD 4\r\nU 8\r\nL 8\r\nD 8\r\nL 4\r\nR 2\r\nD 6\r\nR 2\r\nL 3\r\nD 16\r\nR 6\r\nL 16\r\nD 16\r\nL 2\r\nR 16\r\nD 15\r\nL 1\r\nD 4\r\nU 3\r\nL 5\r\nU 4\r\nL 4\r\nD 9\r\nL 2\r\nR 8\r\nD 7\r\nU 7\r\nR 12\r\nU 12\r\nR 3\r\nD 8\r\nL 12\r\nD 12\r\nR 13\r\nU 8\r\nR 5\r\nU 2\r\nD 3\r\nU 11\r\nL 13\r\nR 4\r\nL 5\r\nR 9\r\nD 9\r\nU 14\r\nR 15\r\nL 16\r\nR 13\r\nD 11\r\nU 13\r\nL 10\r\nD 11\r\nL 10\r\nR 4\r\nU 7\r\nD 17\r\nU 7\r\nR 10\r\nU 11\r\nL 2\r\nD 8\r\nU 3\r\nR 14\r\nU 13\r\nD 8\r\nU 6\r\nL 2\r\nD 9\r\nL 1\r\nD 4\r\nU 16\r\nD 4\r\nL 13\r\nU 1\r\nD 13\r\nU 12\r\nR 17\r\nL 6\r\nR 17\r\nL 17\r\nR 13\r\nL 9\r\nU 12\r\nL 15\r\nR 17\r\nU 3\r\nR 2\r\nL 12\r\nU 7\r\nL 12\r\nU 9\r\nL 15\r\nR 9\r\nU 3\r\nL 13\r\nR 8\r\nL 3\r\nR 2\r\nL 17\r\nU 14\r\nD 16\r\nL 13\r\nD 2\r\nU 17\r\nD 6\r\nU 8\r\nL 5\r\nD 10\r\nL 3\r\nD 3\r\nR 7\r\nL 16\r\nR 8\r\nU 13\r\nL 17\r\nU 16\r\nL 9\r\nU 8\r\nD 12\r\nR 10\r\nU 11\r\nD 10\r\nL 17\r\nR 3\r\nD 7\r\nU 13\r\nD 11\r\nR 7\r\nD 16\r\nU 4\r\nR 12\r\nD 12\r\nU 11\r\nD 2\r\nL 9\r\nD 6\r\nL 4\r\nR 5\r\nL 13\r\nU 7\r\nL 12\r\nD 1\r\nL 15\r\nU 8\r\nR 4\r\nU 15\r\nR 15\r\nD 7\r\nR 8\r\nU 9\r\nR 5\r\nD 12\r\nR 12\r\nU 2\r\nD 13\r\nU 2\r\nL 6\r\nD 8\r\nU 12\r\nR 6\r\nD 16\r\nU 4\r\nR 9\r\nL 6\r\nU 18\r\nL 7\r\nR 15\r\nU 8\r\nD 18\r\nL 11\r\nR 16\r\nD 2\r\nR 7\r\nD 8\r\nL 10\r\nU 15\r\nL 13\r\nD 7\r\nR 13\r\nD 14\r\nR 2\r\nL 14\r\nD 4\r\nL 10\r\nR 13\r\nL 18\r\nU 15\r\nL 17\r\nR 18\r\nD 2\r\nU 7\r\nR 18\r\nD 4\r\nL 1\r\nU 12\r\nL 1\r\nU 16\r\nD 6\r\nR 7\r\nU 9\r\nL 1\r\nU 13\r\nR 2\r\nL 8\r\nD 5\r\nR 18\r\nD 16\r\nR 8\r\nD 2\r\nR 13\r\nL 16\r\nR 18\r\nL 10\r\nD 6\r\nU 4\r\nD 15\r\nU 3\r\nD 9\r\nR 17\r\nD 8\r\nL 4\r\nR 17\r\nD 15\r\nR 1\r\nD 18\r\nU 1\r\nR 5\r\nL 7\r\nD 18\r\nU 16\r\nD 2\r\nL 11\r\nR 7\r\nL 12\r\nD 2\r\nU 8\r\nL 17\r\nU 18\r\nL 10\r\nR 16\r\nL 5\r\nR 1\r\nL 10\r\nR 14\r\nL 4\r\nD 15\r\nR 8\r\nD 15\r\nL 12\r\nD 5\r\nU 11\r\nL 1\r\nR 8\r\nD 11\r\nU 5\r\nL 12\r\nD 11\r\nU 9\r\nD 12\r\nR 7\r\nD 11\r\nU 2\r\nR 15\r\nL 2\r\nR 8\r\nU 2\r\nD 8\r\nR 14\r\nL 4\r\nD 1\r\nU 4\r\nR 4\r\nD 2\r\nR 5\r\nD 9\r\nL 10\r\nU 8\r\nR 13\r\nD 15\r\nR 18\r\nD 5\r\nU 5\r\nL 1\r\nU 1\r\nR 9\r\nD 2\r\nU 6\r\nR 5\r\nU 5\r\nR 17\r\nL 2\r\nD 1\r\nR 3\r\nD 5\r\nU 13\r\nR 10\r\nD 10\r\nR 13\r\nD 5\r\nL 1\r\nU 14\r\nD 17\r\nU 15\r\nR 16\r\nL 9\r\nU 12\r\nL 17\r\nR 19\r\nU 1\r\nD 4\r\nU 14\r\nL 7\r\nR 16\r\nL 5\r\nD 4\r\nL 14\r\nU 13\r\nR 10\r\nL 19\r\nD 1\r\nR 17\r\nD 6\r\nL 19\r\nU 11\r\nL 14\r\nU 15\r\nD 10\r\nU 17\r\nR 16\r\nU 12\r\nL 13\r\nD 1\r\nR 11\r\nD 10\r\nL 4\r\nD 15\r\nL 18\r\nR 2\r\nU 5\r\nL 2\r\nU 9\r\nD 16\r\nR 8\r\nD 13\r\nR 19\r\nU 14\r\nL 10\r\nR 13\r\nU 3\r\nR 2\r\nU 11\r\nL 2\r\nR 2\r\nU 12\r\nL 14\r\nU 15\r\nR 6\r\nD 10\r\nR 8\r\nU 14\r\nD 9\r\nL 2\r\nU 3\r\nD 8\r\nU 7\r\nR 10\r\nU 16\r\nR 3\r\nU 9\r\nL 16\r\nD 1\r\nR 1\r\nU 12\r\nR 12\r\nU 8\r\nL 19\r\nU 14\r\nR 9\r\nU 5\r\nL 15\r\nU 7\r\nL 17\r\nU 16\r\nR 19\r\nU 17\r\nL 1\r\nD 7";

var tailsPositions = new List<Position>();

var motions = inputs.Split("\r\n").Select(l => Motion.Parse(l));

Execute(2);

Console.WriteLine(tailsPositions.Distinct().Count());

tailsPositions.Clear();

Execute(10);


Console.WriteLine(tailsPositions.Distinct().Count());


void Execute(int numnberOfNode)
{
    List<Position> knots = Enumerable.Range(0, numnberOfNode).Select(u => new Position(0, 0)).ToList();

    foreach (var motion in motions)
    {
        foreach (var step in Enumerable.Range(0, motion.Steps))
        {
            foreach (var index in Enumerable.Range(0, knots.Count()))
            {
                var currentNode = knots[index];
                if (index > 0)
                {
                    var previousNode = knots[index - 1];

                    if (!(previousNode).Surrounding.Contains(currentNode))
                    {
                        if (previousNode != currentNode) // If Head overlap Node no need to move
                        {
                            switch (motion.Direction)
                            {
                                case 'R':
                                    currentNode.X = previousNode.X - 1;
                                    currentNode.Y = previousNode.Y + 0;
                                    break;
                                case 'U':
                                    currentNode.X = previousNode.X + 0;
                                    currentNode.Y = previousNode.Y - 1;
                                    break;
                                case 'L':
                                    currentNode.X = previousNode.X + 1;
                                    currentNode.Y = previousNode.Y + 0;
                                    break;
                                case 'D':
                                    currentNode.X = previousNode.X + 0;
                                    currentNode.Y = previousNode.Y + 1;
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    switch (motion.Direction)
                    {
                        case 'R':
                            currentNode.X++;
                            break;
                        case 'U':
                            currentNode.Y++;
                            break;
                        case 'L':
                            currentNode.X--;
                            break;
                        case 'D':
                            currentNode.Y--;
                            break;
                    }
                }

                if (index == knots.Count() - 1)
                {
                    tailsPositions.Add(new Position(currentNode.X, currentNode.Y));
                }
            }
        }
    }
}

internal class Motion
{
    internal readonly char Direction;
    internal readonly int Steps;
    Motion(char direction, int steps)
    {
        Direction = direction;
        Steps = steps;
    }

    internal static Motion Parse(string line) => new(line[0], int.Parse(line.Split(" ")[1]));
}

internal class Position
{
    internal int X { get; set; }
    internal int Y { get; set; }

    internal Position(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    // The FNV prime value.
    private const uint FNV_PRIME = 13;
    // The FNV offset basis.
    private const uint FNV_OFFSET_BASIS = 5;

    public override bool Equals(object? obj)
    {
        if (obj == null)
            if (this == null)
                return true;
            else
                return false;

        if (! (obj is Position))
            return false;

        return ((Position)obj).X == this.X && ((Position)obj).Y == this.Y;
    }

    public override int GetHashCode()
    {
        var hashX = (FNV_OFFSET_BASIS * FNV_PRIME) ^ X;
        var hashY = (FNV_OFFSET_BASIS * FNV_PRIME) ^ Y;
        return (int)hashX ^ (int)hashY; //a bit unsafe but do the work here
    }

    public override string ToString()
    {
        return $"[{X},{Y}]";
    }

    /*
        | -1,1  | 0,1  | 1,1  |
        | -1,0  | 0,0  | 1,0  |
        | -1,-1 | 0,-1 | 1,-1 |

        0,0 is the position of H and T should be in any of this position
    */
    internal List<Position> Surrounding
    {
        get
        {
            return new List<Position>()
            {
                new Position(X - 1, Y + 1),
                new Position(X + 0, Y + 1),
                new Position(X + 1, Y + 1),

                new Position(X - 1, Y + 0),
                new Position(X + 0, Y + 0),
                new Position(X + 1, Y + 0),

                new Position(X - 1, Y - 1),
                new Position(X + 0, Y - 1),
                new Position(X + 1, Y - 1),
            };

        }
    }
}



