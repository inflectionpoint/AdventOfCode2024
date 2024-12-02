// https://adventofcode.com/2024/day/1

// PLAN PART A:
// Read File, split on new line,
// Sort A, Sort B, C = abs(A[n] - B[n]), sum(C)

// PLAN PART B:
// Frequency of number from A in B, Sum(A*Feq(B))

using System.Collections.ObjectModel;

// FILE OPERATIONS
StreamReader reader = new(@"C:\Users\andre\source\repos\AdventOfCode2024\Day01.txt");

string input = reader.ReadToEnd();

Collection<int> A = [];
Collection<int> B = [];
int AnswerA = 0;
int AnswerB = 0;

var lines = input.Split('\n');

// DATA MANIPULATION

foreach (var line in lines)
{
    var ab = ProgramHelpers.ColumnSplit().Split(line.TrimEnd());
    A.Add(int.Parse(ab[0]));
    B.Add(int.Parse(ab[1]));
}

var AO = A.Order().ToList();
var BO = B.Order().ToList();

// PART A
for (int i = 0; i < AO.Count; i++)
{
    AnswerA += Math.Abs(AO[i] - BO[i]);
}
Console.WriteLine(AnswerA);

// PART B
foreach (var a in AO)
{
    AnswerB += a * B.Count(v => v.Equals(a));
}
Console.WriteLine(AnswerB);

Console.ReadKey();