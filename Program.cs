string[] arr ={"apple","=)","412","rtfm","banana","for"};
var realSize = 0;

var result = new string[arr.Length];

foreach (var count in arr)
{
    if (count.Length <= 3)
    {
        result[realSize] = count;
        realSize++;
    }
}
System.Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));