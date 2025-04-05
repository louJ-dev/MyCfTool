using System.Text.Json.Serialization;

namespace MyCfTool.Models;

public class ProblemSet
{
    [JsonPropertyName("problems")]
    public Problem[] problems { get; set; } = new Problem[0];
    
    [JsonPropertyName("problemStatistics")]
    public ProblemStatistics[] problemStatistics { get; set; } = new ProblemStatistics[0];
}
