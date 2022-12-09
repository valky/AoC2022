//var inputs = "R 4\r\nU 4\r\nL 3\r\nD 1\r\nR 4\r\nD 1\r\nL 5\r\nR 2";         // => 1
//var inputs = "R 5\r\nU 8\r\nL 8\r\nD 3\r\nR 17\r\nD 10\r\nL 25\r\nU 20";   // => 36
var inputs = "U 1\r\nR 2\r\nD 2\r\nU 2\r\nL 1\r\nU 1\r\nR 1\r\nU 2\r\nR 1\r\nD 1\r\nU 2\r\nL 1\r\nR 1\r\nU 1\r\nL 1\r\nD 1\r\nL 1\r\nD 1\r\nU 2\r\nR 2\r\nU 1\r\nL 1\r\nR 2\r\nU 2\r\nL 2\r\nU 2\r\nR 2\r\nD 2\r\nR 1\r\nU 2\r\nL 2\r\nU 1\r\nR 1\r\nL 2\r\nU 2\r\nR 2\r\nL 1\r\nR 2\r\nL 1\r\nD 1\r\nR 2\r\nL 2\r\nD 2\r\nL 1\r\nD 1\r\nL 2\r\nU 1\r\nR 2\r\nL 2\r\nU 2\r\nD 2\r\nR 2\r\nD 2\r\nL 2\r\nD 2\r\nL 1\r\nD 2\r\nL 1\r\nR 2\r\nL 2\r\nR 1\r\nD 2\r\nU 1\r\nR 2\r\nL 1\r\nR 2\r\nD 1\r\nU 1\r\nR 1\r\nU 2\r\nD 2\r\nR 1\r\nD 1\r\nU 1\r\nL 2\r\nD 2\r\nU 1\r\nR 2\r\nL 2\r\nR 1\r\nD 2\r\nL 1\r\nU 1\r\nD 1\r\nU 2\r\nD 1\r\nU 1\r\nD 2\r\nR 2\r\nL 1\r\nD 1\r\nU 1\r\nR 1\r\nL 2\r\nD 1\r\nL 2\r\nR 1\r\nL 2\r\nU 2\r\nR 1\r\nL 2\r\nD 2\r\nL 2\r\nU 2\r\nL 1\r\nU 2\r\nR 2\r\nL 2\r\nR 2\r\nL 2\r\nU 1\r\nL 1\r\nU 1\r\nD 1\r\nU 3\r\nR 2\r\nL 3\r\nR 2\r\nD 2\r\nU 3\r\nR 1\r\nL 3\r\nD 1\r\nU 3\r\nR 2\r\nD 1\r\nU 3\r\nR 2\r\nL 3\r\nR 3\r\nL 2\r\nR 1\r\nU 2\r\nR 2\r\nU 3\r\nD 1\r\nU 3\r\nL 2\r\nD 1\r\nR 2\r\nU 3\r\nR 3\r\nL 3\r\nD 3\r\nR 3\r\nU 3\r\nL 3\r\nU 1\r\nL 2\r\nU 3\r\nL 1\r\nU 1\r\nD 3\r\nR 3\r\nU 1\r\nR 1\r\nU 1\r\nL 3\r\nR 2\r\nU 2\r\nL 3\r\nD 1\r\nL 2\r\nD 2\r\nL 2\r\nR 2\r\nU 3\r\nD 3\r\nR 2\r\nU 3\r\nL 2\r\nU 1\r\nD 2\r\nR 3\r\nL 1\r\nU 1\r\nR 2\r\nD 3\r\nL 1\r\nR 1\r\nU 1\r\nD 3\r\nR 2\r\nD 3\r\nR 2\r\nU 1\r\nL 2\r\nU 1\r\nR 2\r\nU 1\r\nR 2\r\nL 2\r\nU 2\r\nR 3\r\nL 3\r\nD 2\r\nL 1\r\nR 3\r\nD 1\r\nU 1\r\nL 2\r\nR 1\r\nD 3\r\nU 3\r\nD 3\r\nU 1\r\nR 2\r\nL 3\r\nR 1\r\nL 3\r\nR 2\r\nD 2\r\nU 1\r\nD 1\r\nL 3\r\nR 1\r\nL 3\r\nR 3\r\nL 1\r\nD 2\r\nL 3\r\nU 2\r\nD 1\r\nL 1\r\nU 2\r\nR 3\r\nL 2\r\nR 3\r\nU 3\r\nL 2\r\nD 4\r\nU 4\r\nR 3\r\nU 2\r\nL 1\r\nU 3\r\nD 4\r\nL 2\r\nU 3\r\nL 4\r\nD 4\r\nR 3\r\nD 3\r\nR 1\r\nD 2\r\nL 1\r\nR 2\r\nD 3\r\nL 1\r\nR 2\r\nU 3\r\nD 4\r\nR 4\r\nL 2\r\nR 4\r\nU 3\r\nR 4\r\nU 4\r\nL 4\r\nD 3\r\nR 4\r\nD 1\r\nU 3\r\nL 3\r\nR 1\r\nU 2\r\nR 3\r\nU 4\r\nD 2\r\nU 3\r\nD 2\r\nL 2\r\nD 3\r\nL 4\r\nR 2\r\nU 2\r\nL 2\r\nU 4\r\nD 2\r\nU 4\r\nL 4\r\nU 2\r\nR 3\r\nD 4\r\nU 4\r\nL 3\r\nD 3\r\nR 4\r\nL 3\r\nR 2\r\nL 4\r\nU 3\r\nD 2\r\nL 4\r\nR 1\r\nU 2\r\nL 3\r\nD 1\r\nR 2\r\nU 2\r\nD 4\r\nR 1\r\nU 1\r\nR 2\r\nD 2\r\nL 3\r\nR 1\r\nU 2\r\nR 1\r\nD 4\r\nU 1\r\nR 1\r\nU 3\r\nD 1\r\nU 2\r\nD 3\r\nU 3\r\nL 2\r\nU 4\r\nR 1\r\nL 2\r\nD 2\r\nL 2\r\nD 3\r\nU 3\r\nL 3\r\nU 1\r\nD 1\r\nR 1\r\nD 2\r\nL 2\r\nU 2\r\nD 3\r\nR 1\r\nL 4\r\nU 3\r\nL 5\r\nR 5\r\nL 4\r\nD 4\r\nR 4\r\nL 4\r\nR 4\r\nL 2\r\nR 3\r\nD 3\r\nR 2\r\nL 4\r\nR 2\r\nU 5\r\nD 5\r\nU 1\r\nR 4\r\nU 2\r\nR 3\r\nL 4\r\nD 2\r\nU 3\r\nD 4\r\nU 2\r\nD 5\r\nL 5\r\nR 2\r\nU 3\r\nR 1\r\nD 1\r\nR 4\r\nU 5\r\nR 3\r\nL 3\r\nU 3\r\nL 1\r\nU 5\r\nD 2\r\nU 3\r\nR 1\r\nD 5\r\nL 4\r\nU 3\r\nD 1\r\nL 3\r\nR 2\r\nU 1\r\nL 2\r\nR 2\r\nD 4\r\nR 2\r\nL 3\r\nU 2\r\nD 1\r\nL 1\r\nR 4\r\nL 1\r\nD 2\r\nR 1\r\nL 5\r\nR 4\r\nU 2\r\nR 2\r\nU 1\r\nD 3\r\nR 3\r\nL 1\r\nU 5\r\nR 2\r\nD 3\r\nU 3\r\nR 1\r\nU 4\r\nR 1\r\nD 2\r\nL 1\r\nD 4\r\nL 1\r\nR 5\r\nL 5\r\nR 5\r\nL 1\r\nU 5\r\nR 2\r\nU 5\r\nL 2\r\nD 3\r\nU 5\r\nL 4\r\nD 5\r\nU 2\r\nR 2\r\nD 2\r\nR 4\r\nL 4\r\nD 5\r\nR 2\r\nL 2\r\nR 5\r\nU 2\r\nL 1\r\nU 2\r\nD 2\r\nR 5\r\nU 1\r\nL 5\r\nR 1\r\nL 4\r\nD 4\r\nL 3\r\nD 4\r\nU 2\r\nL 2\r\nD 5\r\nU 4\r\nR 3\r\nL 6\r\nD 3\r\nR 2\r\nU 2\r\nL 2\r\nU 1\r\nR 6\r\nU 5\r\nR 2\r\nU 2\r\nR 1\r\nU 5\r\nL 3\r\nU 2\r\nR 5\r\nL 3\r\nU 3\r\nD 2\r\nU 5\r\nL 5\r\nU 4\r\nR 6\r\nD 2\r\nL 6\r\nU 1\r\nL 5\r\nD 4\r\nU 3\r\nD 3\r\nU 5\r\nL 6\r\nU 4\r\nD 3\r\nU 4\r\nD 6\r\nR 1\r\nU 4\r\nL 1\r\nD 4\r\nU 5\r\nR 2\r\nL 3\r\nR 2\r\nU 2\r\nD 1\r\nL 3\r\nR 6\r\nL 2\r\nU 5\r\nL 3\r\nD 1\r\nL 2\r\nD 4\r\nU 4\r\nL 4\r\nD 1\r\nL 2\r\nD 2\r\nR 5\r\nL 2\r\nR 2\r\nL 3\r\nR 2\r\nU 2\r\nL 1\r\nU 4\r\nD 4\r\nR 5\r\nL 3\r\nU 2\r\nD 3\r\nR 6\r\nD 3\r\nR 3\r\nL 4\r\nU 5\r\nD 3\r\nR 5\r\nU 4\r\nR 2\r\nU 4\r\nL 1\r\nU 6\r\nD 6\r\nL 1\r\nR 2\r\nU 6\r\nD 5\r\nL 1\r\nU 3\r\nL 1\r\nD 6\r\nL 3\r\nU 4\r\nD 6\r\nU 4\r\nD 3\r\nL 3\r\nU 5\r\nR 2\r\nL 5\r\nD 3\r\nR 2\r\nD 2\r\nU 1\r\nD 2\r\nR 2\r\nU 5\r\nR 4\r\nU 1\r\nR 5\r\nD 2\r\nR 2\r\nU 5\r\nL 6\r\nU 3\r\nL 7\r\nD 1\r\nR 4\r\nD 4\r\nR 7\r\nL 7\r\nU 7\r\nD 4\r\nL 4\r\nR 6\r\nU 6\r\nL 7\r\nR 3\r\nL 6\r\nU 6\r\nR 5\r\nD 4\r\nL 6\r\nU 1\r\nR 6\r\nD 3\r\nU 5\r\nD 3\r\nU 2\r\nR 7\r\nU 5\r\nD 5\r\nL 2\r\nD 2\r\nU 4\r\nL 3\r\nD 1\r\nL 1\r\nR 2\r\nL 2\r\nR 6\r\nD 4\r\nL 7\r\nD 7\r\nR 4\r\nL 6\r\nR 3\r\nL 3\r\nU 7\r\nR 3\r\nL 5\r\nD 6\r\nR 3\r\nU 5\r\nD 3\r\nL 4\r\nU 7\r\nR 6\r\nD 6\r\nU 5\r\nR 3\r\nL 3\r\nR 6\r\nL 3\r\nD 1\r\nL 3\r\nU 5\r\nD 2\r\nL 3\r\nR 4\r\nL 7\r\nR 5\r\nU 3\r\nL 7\r\nD 5\r\nU 6\r\nD 5\r\nL 6\r\nR 6\r\nL 1\r\nR 3\r\nD 4\r\nL 5\r\nR 2\r\nU 4\r\nR 2\r\nD 4\r\nR 3\r\nD 2\r\nL 3\r\nR 2\r\nL 4\r\nR 5\r\nU 7\r\nL 7\r\nD 3\r\nR 5\r\nL 1\r\nU 4\r\nR 5\r\nU 4\r\nR 6\r\nL 1\r\nR 4\r\nD 8\r\nL 2\r\nU 7\r\nL 3\r\nR 3\r\nU 1\r\nD 8\r\nU 5\r\nD 3\r\nR 3\r\nL 2\r\nU 2\r\nD 8\r\nR 3\r\nU 4\r\nL 6\r\nD 7\r\nR 7\r\nU 6\r\nL 7\r\nU 5\r\nR 1\r\nL 2\r\nU 4\r\nD 1\r\nL 6\r\nD 5\r\nR 7\r\nU 7\r\nR 8\r\nL 7\r\nU 7\r\nD 3\r\nL 3\r\nD 4\r\nL 1\r\nR 6\r\nD 5\r\nU 1\r\nD 8\r\nR 1\r\nL 2\r\nU 1\r\nD 2\r\nL 3\r\nR 7\r\nL 2\r\nD 8\r\nR 5\r\nU 6\r\nD 4\r\nL 1\r\nU 6\r\nR 1\r\nD 4\r\nR 4\r\nL 2\r\nD 4\r\nR 1\r\nU 2\r\nR 8\r\nL 6\r\nR 8\r\nU 8\r\nL 3\r\nR 6\r\nD 3\r\nR 2\r\nL 3\r\nU 6\r\nD 6\r\nU 4\r\nR 7\r\nL 3\r\nR 2\r\nL 4\r\nU 3\r\nR 7\r\nD 8\r\nR 1\r\nD 6\r\nU 7\r\nR 2\r\nU 2\r\nL 6\r\nU 5\r\nR 1\r\nD 1\r\nR 6\r\nL 2\r\nU 3\r\nD 2\r\nL 2\r\nD 5\r\nR 4\r\nL 1\r\nD 7\r\nR 6\r\nD 4\r\nU 2\r\nD 5\r\nU 3\r\nD 8\r\nU 6\r\nR 5\r\nL 6\r\nU 7\r\nL 3\r\nR 8\r\nU 3\r\nL 2\r\nR 3\r\nL 5\r\nR 3\r\nL 2\r\nU 9\r\nD 2\r\nU 5\r\nR 7\r\nU 9\r\nL 9\r\nR 6\r\nL 7\r\nD 1\r\nL 4\r\nD 3\r\nR 7\r\nL 6\r\nR 9\r\nD 6\r\nR 4\r\nD 8\r\nL 1\r\nU 5\r\nR 9\r\nD 9\r\nU 6\r\nL 5\r\nR 4\r\nD 2\r\nR 5\r\nD 1\r\nR 6\r\nD 3\r\nR 8\r\nL 1\r\nU 2\r\nR 5\r\nU 3\r\nL 1\r\nR 8\r\nD 6\r\nL 5\r\nD 7\r\nR 3\r\nU 2\r\nL 7\r\nU 3\r\nD 4\r\nL 2\r\nR 8\r\nD 6\r\nL 3\r\nU 5\r\nL 1\r\nU 5\r\nL 4\r\nR 7\r\nU 6\r\nR 1\r\nD 3\r\nU 3\r\nD 2\r\nR 4\r\nL 5\r\nU 2\r\nR 6\r\nL 8\r\nU 6\r\nL 9\r\nD 3\r\nR 3\r\nU 9\r\nD 8\r\nL 2\r\nR 7\r\nD 6\r\nR 1\r\nD 8\r\nU 8\r\nD 2\r\nU 4\r\nD 8\r\nL 9\r\nR 8\r\nD 8\r\nR 7\r\nU 8\r\nL 8\r\nU 8\r\nR 7\r\nL 8\r\nU 3\r\nD 6\r\nR 7\r\nD 2\r\nL 5\r\nU 8\r\nD 7\r\nU 6\r\nR 3\r\nD 7\r\nU 9\r\nL 7\r\nR 3\r\nL 1\r\nU 9\r\nL 7\r\nU 2\r\nD 7\r\nL 5\r\nR 9\r\nD 2\r\nR 7\r\nU 6\r\nD 7\r\nU 3\r\nR 8\r\nU 9\r\nL 8\r\nR 8\r\nD 10\r\nL 7\r\nR 3\r\nU 5\r\nR 5\r\nD 9\r\nU 10\r\nL 2\r\nD 4\r\nL 2\r\nU 1\r\nD 3\r\nL 3\r\nU 7\r\nD 6\r\nL 6\r\nD 7\r\nL 8\r\nU 1\r\nD 9\r\nL 7\r\nU 4\r\nL 3\r\nU 6\r\nD 2\r\nL 5\r\nU 10\r\nD 9\r\nU 8\r\nD 1\r\nR 10\r\nU 4\r\nL 1\r\nR 7\r\nU 2\r\nL 5\r\nD 5\r\nR 7\r\nD 1\r\nR 4\r\nU 2\r\nD 6\r\nL 7\r\nU 10\r\nR 3\r\nL 9\r\nD 7\r\nL 2\r\nR 5\r\nU 10\r\nD 10\r\nR 9\r\nD 5\r\nU 3\r\nL 7\r\nD 5\r\nU 6\r\nD 7\r\nL 6\r\nD 10\r\nR 7\r\nU 8\r\nL 4\r\nD 9\r\nL 4\r\nU 5\r\nR 9\r\nU 9\r\nR 3\r\nU 2\r\nR 2\r\nD 1\r\nR 1\r\nU 6\r\nR 8\r\nD 10\r\nU 2\r\nD 9\r\nL 8\r\nR 1\r\nD 1\r\nL 9\r\nR 8\r\nD 9\r\nR 5\r\nL 9\r\nU 10\r\nD 4\r\nR 7\r\nU 4\r\nL 3\r\nU 8\r\nL 2\r\nU 9\r\nD 9\r\nL 1\r\nR 4\r\nU 2\r\nL 4\r\nU 3\r\nD 7\r\nU 11\r\nR 6\r\nU 9\r\nD 6\r\nR 7\r\nL 1\r\nD 7\r\nR 2\r\nD 6\r\nU 2\r\nL 2\r\nU 4\r\nR 6\r\nU 6\r\nL 11\r\nD 7\r\nR 9\r\nL 2\r\nD 10\r\nL 10\r\nU 4\r\nL 6\r\nD 11\r\nU 9\r\nL 1\r\nR 10\r\nL 7\r\nR 4\r\nD 5\r\nL 3\r\nU 2\r\nR 9\r\nL 9\r\nD 1\r\nL 11\r\nD 5\r\nU 6\r\nD 5\r\nU 9\r\nR 1\r\nL 7\r\nU 3\r\nR 7\r\nL 2\r\nD 6\r\nR 3\r\nU 2\r\nD 5\r\nR 9\r\nL 3\r\nD 11\r\nU 9\r\nD 11\r\nR 2\r\nD 7\r\nR 9\r\nU 4\r\nD 6\r\nU 7\r\nR 10\r\nD 3\r\nL 4\r\nR 9\r\nD 3\r\nL 7\r\nR 7\r\nL 11\r\nD 6\r\nR 9\r\nD 9\r\nR 3\r\nU 3\r\nR 3\r\nL 6\r\nD 11\r\nR 2\r\nL 10\r\nU 2\r\nR 2\r\nD 11\r\nR 7\r\nD 8\r\nR 2\r\nD 10\r\nU 5\r\nD 3\r\nL 10\r\nR 1\r\nD 5\r\nR 4\r\nL 10\r\nU 5\r\nD 9\r\nU 2\r\nL 3\r\nU 3\r\nR 5\r\nD 4\r\nL 1\r\nD 1\r\nR 10\r\nL 4\r\nD 8\r\nL 5\r\nD 5\r\nL 3\r\nD 5\r\nL 3\r\nR 1\r\nL 3\r\nR 4\r\nU 9\r\nR 4\r\nD 12\r\nL 5\r\nR 4\r\nL 11\r\nD 10\r\nU 3\r\nR 2\r\nU 5\r\nL 6\r\nD 5\r\nU 5\r\nD 10\r\nR 12\r\nL 2\r\nR 10\r\nD 11\r\nR 12\r\nU 5\r\nR 4\r\nL 4\r\nU 2\r\nR 12\r\nL 6\r\nD 3\r\nR 2\r\nD 1\r\nU 9\r\nL 6\r\nU 6\r\nL 10\r\nD 8\r\nR 9\r\nL 1\r\nU 1\r\nD 5\r\nU 4\r\nR 10\r\nU 5\r\nR 10\r\nD 12\r\nU 6\r\nD 9\r\nU 3\r\nL 8\r\nR 8\r\nD 7\r\nL 6\r\nU 7\r\nR 1\r\nU 6\r\nD 9\r\nR 2\r\nU 11\r\nD 7\r\nL 12\r\nD 6\r\nL 5\r\nU 8\r\nR 8\r\nL 8\r\nD 3\r\nR 7\r\nL 11\r\nD 1\r\nL 5\r\nD 5\r\nU 8\r\nD 2\r\nR 8\r\nL 6\r\nD 7\r\nL 3\r\nD 3\r\nU 9\r\nL 1\r\nU 8\r\nD 7\r\nL 8\r\nU 4\r\nR 12\r\nU 7\r\nL 10\r\nD 4\r\nU 7\r\nD 7\r\nU 5\r\nL 4\r\nR 9\r\nD 5\r\nR 4\r\nU 2\r\nR 1\r\nD 9\r\nU 7\r\nR 9\r\nU 12\r\nD 4\r\nR 8\r\nU 4\r\nD 10\r\nL 10\r\nD 11\r\nL 8\r\nR 11\r\nU 5\r\nD 4\r\nL 3\r\nD 1\r\nU 7\r\nL 5\r\nR 13\r\nL 2\r\nR 9\r\nL 6\r\nR 6\r\nL 2\r\nU 10\r\nD 11\r\nU 13\r\nR 11\r\nU 6\r\nL 7\r\nD 11\r\nR 7\r\nU 4\r\nL 1\r\nD 9\r\nR 7\r\nL 11\r\nU 13\r\nL 8\r\nR 12\r\nU 5\r\nR 9\r\nU 11\r\nR 3\r\nD 11\r\nU 9\r\nL 8\r\nU 6\r\nD 6\r\nL 11\r\nU 4\r\nD 3\r\nU 11\r\nD 1\r\nL 6\r\nU 5\r\nR 10\r\nL 10\r\nR 8\r\nL 12\r\nR 4\r\nU 3\r\nR 8\r\nL 8\r\nU 4\r\nL 10\r\nU 9\r\nR 8\r\nU 3\r\nD 2\r\nU 4\r\nD 10\r\nL 6\r\nR 10\r\nU 8\r\nL 9\r\nR 13\r\nD 8\r\nU 10\r\nD 10\r\nL 13\r\nU 1\r\nR 4\r\nU 11\r\nD 12\r\nL 1\r\nR 2\r\nU 12\r\nD 7\r\nU 9\r\nR 13\r\nU 5\r\nD 6\r\nR 4\r\nL 6\r\nU 9\r\nL 5\r\nU 8\r\nD 4\r\nL 5\r\nU 6\r\nL 8\r\nU 1\r\nR 3\r\nU 8\r\nR 2\r\nD 5\r\nU 12\r\nD 9\r\nL 2\r\nU 3\r\nR 11\r\nU 9\r\nR 7\r\nD 10\r\nU 2\r\nL 3\r\nD 3\r\nU 9\r\nD 6\r\nU 1\r\nR 9\r\nL 5\r\nR 2\r\nL 2\r\nR 11\r\nD 7\r\nL 10\r\nU 13\r\nL 6\r\nR 11\r\nU 6\r\nD 11\r\nU 4\r\nR 10\r\nD 5\r\nR 4\r\nL 6\r\nU 3\r\nL 8\r\nD 6\r\nU 14\r\nR 3\r\nU 1\r\nL 6\r\nR 7\r\nU 9\r\nL 9\r\nD 10\r\nU 10\r\nD 12\r\nR 9\r\nD 12\r\nR 4\r\nD 12\r\nU 9\r\nR 9\r\nU 2\r\nL 11\r\nD 13\r\nU 12\r\nL 7\r\nD 14\r\nR 4\r\nD 14\r\nU 11\r\nD 5\r\nR 10\r\nL 2\r\nD 11\r\nL 3\r\nU 9\r\nR 4\r\nL 8\r\nU 8\r\nR 7\r\nU 7\r\nD 5\r\nR 8\r\nU 5\r\nL 3\r\nR 7\r\nD 6\r\nR 12\r\nU 3\r\nD 8\r\nL 8\r\nU 3\r\nL 8\r\nR 7\r\nL 13\r\nU 2\r\nL 8\r\nU 14\r\nR 5\r\nL 1\r\nD 14\r\nR 10\r\nU 14\r\nR 6\r\nU 14\r\nD 5\r\nU 13\r\nD 1\r\nU 12\r\nR 7\r\nL 2\r\nU 4\r\nR 10\r\nU 8\r\nR 12\r\nL 2\r\nU 7\r\nD 9\r\nL 6\r\nD 3\r\nU 7\r\nL 11\r\nU 8\r\nR 7\r\nD 5\r\nU 5\r\nR 13\r\nD 9\r\nR 14\r\nU 8\r\nR 14\r\nD 8\r\nU 1\r\nL 13\r\nR 12\r\nD 7\r\nL 6\r\nR 3\r\nD 10\r\nR 10\r\nL 6\r\nD 12\r\nL 5\r\nU 14\r\nD 1\r\nU 8\r\nR 5\r\nD 15\r\nR 11\r\nD 10\r\nL 11\r\nD 13\r\nL 5\r\nD 3\r\nU 15\r\nR 6\r\nL 12\r\nR 12\r\nL 15\r\nU 5\r\nD 8\r\nR 13\r\nD 10\r\nR 4\r\nL 6\r\nU 8\r\nR 6\r\nD 15\r\nU 6\r\nL 13\r\nD 15\r\nU 11\r\nD 6\r\nU 7\r\nL 1\r\nR 5\r\nL 1\r\nU 7\r\nD 15\r\nL 1\r\nD 7\r\nU 6\r\nR 14\r\nD 4\r\nR 5\r\nU 4\r\nD 5\r\nR 13\r\nD 5\r\nL 1\r\nD 11\r\nL 3\r\nD 3\r\nR 13\r\nL 15\r\nD 4\r\nR 4\r\nU 5\r\nL 10\r\nU 14\r\nD 2\r\nR 9\r\nU 8\r\nR 1\r\nU 13\r\nL 5\r\nU 12\r\nR 10\r\nU 8\r\nL 9\r\nD 7\r\nR 10\r\nL 8\r\nR 13\r\nD 12\r\nL 2\r\nR 4\r\nD 14\r\nR 14\r\nD 2\r\nU 4\r\nD 14\r\nU 1\r\nL 3\r\nR 7\r\nL 2\r\nD 10\r\nR 10\r\nL 1\r\nR 5\r\nD 6\r\nL 5\r\nR 11\r\nU 15\r\nL 6\r\nD 4\r\nR 14\r\nD 6\r\nR 1\r\nL 12\r\nR 15\r\nL 10\r\nU 1\r\nD 3\r\nR 2\r\nD 2\r\nL 8\r\nU 9\r\nD 14\r\nL 4\r\nR 2\r\nU 14\r\nL 11\r\nD 12\r\nU 5\r\nL 11\r\nR 5\r\nU 14\r\nR 9\r\nU 12\r\nL 12\r\nD 9\r\nR 10\r\nD 4\r\nL 3\r\nU 4\r\nR 2\r\nD 9\r\nU 5\r\nL 13\r\nU 5\r\nR 15\r\nL 4\r\nR 10\r\nU 8\r\nR 3\r\nU 13\r\nD 4\r\nU 4\r\nL 8\r\nU 1\r\nD 13\r\nR 10\r\nU 13\r\nL 5\r\nU 7\r\nD 2\r\nU 15\r\nR 10\r\nU 12\r\nD 9\r\nR 12\r\nL 3\r\nD 7\r\nR 7\r\nL 3\r\nR 14\r\nL 9\r\nD 4\r\nR 8\r\nD 1\r\nR 1\r\nU 1\r\nR 14\r\nL 7\r\nR 10\r\nD 14\r\nL 1\r\nU 12\r\nD 8\r\nU 1\r\nR 13\r\nU 12\r\nD 4\r\nU 8\r\nL 8\r\nD 8\r\nL 4\r\nR 2\r\nD 6\r\nR 2\r\nL 3\r\nD 16\r\nR 6\r\nL 16\r\nD 16\r\nL 2\r\nR 16\r\nD 15\r\nL 1\r\nD 4\r\nU 3\r\nL 5\r\nU 4\r\nL 4\r\nD 9\r\nL 2\r\nR 8\r\nD 7\r\nU 7\r\nR 12\r\nU 12\r\nR 3\r\nD 8\r\nL 12\r\nD 12\r\nR 13\r\nU 8\r\nR 5\r\nU 2\r\nD 3\r\nU 11\r\nL 13\r\nR 4\r\nL 5\r\nR 9\r\nD 9\r\nU 14\r\nR 15\r\nL 16\r\nR 13\r\nD 11\r\nU 13\r\nL 10\r\nD 11\r\nL 10\r\nR 4\r\nU 7\r\nD 17\r\nU 7\r\nR 10\r\nU 11\r\nL 2\r\nD 8\r\nU 3\r\nR 14\r\nU 13\r\nD 8\r\nU 6\r\nL 2\r\nD 9\r\nL 1\r\nD 4\r\nU 16\r\nD 4\r\nL 13\r\nU 1\r\nD 13\r\nU 12\r\nR 17\r\nL 6\r\nR 17\r\nL 17\r\nR 13\r\nL 9\r\nU 12\r\nL 15\r\nR 17\r\nU 3\r\nR 2\r\nL 12\r\nU 7\r\nL 12\r\nU 9\r\nL 15\r\nR 9\r\nU 3\r\nL 13\r\nR 8\r\nL 3\r\nR 2\r\nL 17\r\nU 14\r\nD 16\r\nL 13\r\nD 2\r\nU 17\r\nD 6\r\nU 8\r\nL 5\r\nD 10\r\nL 3\r\nD 3\r\nR 7\r\nL 16\r\nR 8\r\nU 13\r\nL 17\r\nU 16\r\nL 9\r\nU 8\r\nD 12\r\nR 10\r\nU 11\r\nD 10\r\nL 17\r\nR 3\r\nD 7\r\nU 13\r\nD 11\r\nR 7\r\nD 16\r\nU 4\r\nR 12\r\nD 12\r\nU 11\r\nD 2\r\nL 9\r\nD 6\r\nL 4\r\nR 5\r\nL 13\r\nU 7\r\nL 12\r\nD 1\r\nL 15\r\nU 8\r\nR 4\r\nU 15\r\nR 15\r\nD 7\r\nR 8\r\nU 9\r\nR 5\r\nD 12\r\nR 12\r\nU 2\r\nD 13\r\nU 2\r\nL 6\r\nD 8\r\nU 12\r\nR 6\r\nD 16\r\nU 4\r\nR 9\r\nL 6\r\nU 18\r\nL 7\r\nR 15\r\nU 8\r\nD 18\r\nL 11\r\nR 16\r\nD 2\r\nR 7\r\nD 8\r\nL 10\r\nU 15\r\nL 13\r\nD 7\r\nR 13\r\nD 14\r\nR 2\r\nL 14\r\nD 4\r\nL 10\r\nR 13\r\nL 18\r\nU 15\r\nL 17\r\nR 18\r\nD 2\r\nU 7\r\nR 18\r\nD 4\r\nL 1\r\nU 12\r\nL 1\r\nU 16\r\nD 6\r\nR 7\r\nU 9\r\nL 1\r\nU 13\r\nR 2\r\nL 8\r\nD 5\r\nR 18\r\nD 16\r\nR 8\r\nD 2\r\nR 13\r\nL 16\r\nR 18\r\nL 10\r\nD 6\r\nU 4\r\nD 15\r\nU 3\r\nD 9\r\nR 17\r\nD 8\r\nL 4\r\nR 17\r\nD 15\r\nR 1\r\nD 18\r\nU 1\r\nR 5\r\nL 7\r\nD 18\r\nU 16\r\nD 2\r\nL 11\r\nR 7\r\nL 12\r\nD 2\r\nU 8\r\nL 17\r\nU 18\r\nL 10\r\nR 16\r\nL 5\r\nR 1\r\nL 10\r\nR 14\r\nL 4\r\nD 15\r\nR 8\r\nD 15\r\nL 12\r\nD 5\r\nU 11\r\nL 1\r\nR 8\r\nD 11\r\nU 5\r\nL 12\r\nD 11\r\nU 9\r\nD 12\r\nR 7\r\nD 11\r\nU 2\r\nR 15\r\nL 2\r\nR 8\r\nU 2\r\nD 8\r\nR 14\r\nL 4\r\nD 1\r\nU 4\r\nR 4\r\nD 2\r\nR 5\r\nD 9\r\nL 10\r\nU 8\r\nR 13\r\nD 15\r\nR 18\r\nD 5\r\nU 5\r\nL 1\r\nU 1\r\nR 9\r\nD 2\r\nU 6\r\nR 5\r\nU 5\r\nR 17\r\nL 2\r\nD 1\r\nR 3\r\nD 5\r\nU 13\r\nR 10\r\nD 10\r\nR 13\r\nD 5\r\nL 1\r\nU 14\r\nD 17\r\nU 15\r\nR 16\r\nL 9\r\nU 12\r\nL 17\r\nR 19\r\nU 1\r\nD 4\r\nU 14\r\nL 7\r\nR 16\r\nL 5\r\nD 4\r\nL 14\r\nU 13\r\nR 10\r\nL 19\r\nD 1\r\nR 17\r\nD 6\r\nL 19\r\nU 11\r\nL 14\r\nU 15\r\nD 10\r\nU 17\r\nR 16\r\nU 12\r\nL 13\r\nD 1\r\nR 11\r\nD 10\r\nL 4\r\nD 15\r\nL 18\r\nR 2\r\nU 5\r\nL 2\r\nU 9\r\nD 16\r\nR 8\r\nD 13\r\nR 19\r\nU 14\r\nL 10\r\nR 13\r\nU 3\r\nR 2\r\nU 11\r\nL 2\r\nR 2\r\nU 12\r\nL 14\r\nU 15\r\nR 6\r\nD 10\r\nR 8\r\nU 14\r\nD 9\r\nL 2\r\nU 3\r\nD 8\r\nU 7\r\nR 10\r\nU 16\r\nR 3\r\nU 9\r\nL 16\r\nD 1\r\nR 1\r\nU 12\r\nR 12\r\nU 8\r\nL 19\r\nU 14\r\nR 9\r\nU 5\r\nL 15\r\nU 7\r\nL 17\r\nU 16\r\nR 19\r\nU 17\r\nL 1\r\nD 7";

var motions = inputs.Split("\r\n").Select(l => Motion.Parse(l)).ToList();

var ropePartOne = new Rope(2);

ropePartOne.ApplyMotions(motions);

Console.WriteLine(ropePartOne.KnotsPositionsHistory[2].Distinct().Count());

var ropePartTwo = new Rope(10);
ropePartTwo.ApplyMotions(motions);

Console.WriteLine(ropePartTwo.KnotsPositionsHistory[10].Distinct().Count());

internal class Rope
{
    List<Knot> Knots { get; }
    internal Dictionary<int,List<Position>> KnotsPositionsHistory { get; }

    internal Rope(int knotsNumber)
    {
        Knots = Enumerable.Range(0, knotsNumber).Select(u => new Knot(new(0, 0))).ToList();
        KnotsPositionsHistory = Knots.Select((k, i) 
            => new 
            { 
                Key = i + 1, 
                Value = new List<Position>() 
                { 
                    new(k.Position.X, k.Position.Y) 
                } 
            })
            .ToDictionary(n => n.Key, n => n.Value);
    }

    internal void ApplyMotions(List<Motion> motions) 
        => motions.ForEach(m => ApplyMotion(m));

    private void ApplyMotion(Motion motion) 
        => Enumerable.Range(0, motion.Steps).ToList().ForEach(s => ApplyStep(motion.Direction));

    private void ApplyStep(Direction direction)
    {
        Knots[0].Move(new() { direction });

        Enumerable.Range(1, Knots.Count() - 1).ToList().ForEach(i => Knots[i].Pursue(Knots[i - 1]));
        Enumerable.Range(0, Knots.Count()).ToList().ForEach(i => KnotsPositionsHistory[i + 1].Add(new(Knots[i].Position.X , Knots[i].Position.Y)));
    }
}

internal class Motion
{
    internal readonly int Steps;
    internal readonly Direction Direction;

    Motion(Direction direction, int steps)
    {
        Direction = direction;
        Steps = steps;
    }

    internal static Motion Parse(string line)
    {
        var direction = line[0] switch
        {
            'U' => Direction.Up,
            'D' => Direction.Down,
            'L' => Direction.Left,
            'R' => Direction.Right,
            _ => throw new Exception("La je suis pas dans le caca")
        };

        return new(direction, int.Parse(line.Split(" ")[1]));
    }
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

        if (!(obj is Position))
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
}

internal class Knot
{
    internal Position Position { get; set; }

    internal Knot(Position position) => Position = position;

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
                new Position(Position.X - 1, Position.Y + 1),
                new Position(Position.X + 0, Position.Y + 1),
                new Position(Position.X + 1, Position.Y + 1),

                new Position(Position.X - 1, Position.Y + 0),
                new Position(Position.X + 0, Position.Y + 0),
                new Position(Position.X + 1, Position.Y + 0),

                new Position(Position.X - 1, Position.Y - 1),
                new Position(Position.X + 0, Position.Y - 1),
                new Position(Position.X + 1, Position.Y - 1),
            };

        }
    }

    internal void Move(List<Direction> directions)
    {
        foreach (var direction in directions)
        {
            switch (direction)
            {
                case Direction.Right:
                    this.Position.X++;
                    break;
                case Direction.Up:
                    this.Position.Y++;
                    break;
                case Direction.Left:
                    this.Position.X--;
                    break;
                case Direction.Down:
                    this.Position.Y--;
                    break;
            }
        }
    }

    internal void Pursue(Knot target)
    {
        if (!(target).Surrounding.Contains(this.Position) && target != this)
        {
            var directions = new List<Direction>();

            if (target.Position.X - this.Position.X > 0)
                directions.Add(Direction.Right);
            if (target.Position.Y - this.Position.Y > 0)
                directions.Add(Direction.Up);
            if (target.Position.X - this.Position.X < 0)
                directions.Add(Direction.Left);
            if (target.Position.Y - this.Position.Y < 0)
                directions.Add(Direction.Down);
            Move(directions);
        }
    }
}

internal enum Direction
{
    Up,
    Down,
    Left,
    Right,

}


