namespace MyCfTool.Models;

public class Problem
{
    public int contestId { get; set; }
    public string? problemsetName { get; set; }
    public string? index { get; set; }
    public string? name { get; set; }
    public string? type { get; set; }
    public float points { get; set; }
    public int rating { get; set; }
    public string[]? tags { get; set; }

    public override string ToString()
    {
        string data = "[\n";
        data += $"\tcontestId: {contestId}, \n";
        data += $"\tproblemsetName: {problemsetName}, \n";
        data += $"\tindex: {index}, \n";
        data += $"\ttype: {type}, \n";
        data += $"\tpoints: {points}, \n";
        data += $"\trating: {rating}, \n";
        data += $"\ttags: {String.Join(", ", tags ?? new string[0])}\n]";

        return data;
    }
}
