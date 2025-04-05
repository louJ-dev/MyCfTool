namespace MyCfTool.Models;

public class ProblemStatistics 
{
    public int contestId { get; set; }
    public string index { get; set; } = "none";
    public int solvedCount { get; set; }

    public override string ToString()
    { 
        string data = "[\n";
        data += $"\tcontestId: {contestId}, \n";
        data += $"\tindex: {index}, \n";
        data += $"\tsolvedCount: {solvedCount} \n]";
        
        return data;
    }
}
