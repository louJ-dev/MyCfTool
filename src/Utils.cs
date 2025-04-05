using System.Text.Json;
using MyCfTool.Models;

namespace MyCfTool;

public static class Utils
{
    public static async Task<ProblemSet> GetProblems(HttpClient client)
    {
        try
        {
            using HttpResponseMessage response = await client.GetAsync(CfTool.URI + "problemset.problems");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStream();
            
            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken token = source.Token;

            var res = await JsonSerializer.DeserializeAsync<Response>(content, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }, token);
            
            if (res == null || res.result == null)
            {
                return new ProblemSet();
            }
            
            var results = JsonSerializer.Deserialize((JsonElement)res.result, typeof(ProblemSet));

            if (results == null)
            {
                return new ProblemSet();
            }

            return (ProblemSet)results ?? new ProblemSet(); 
        }
        catch(HttpRequestException e)
        { 
            Console.WriteLine("\nException cought from: GetProblems()");
            Console.WriteLine($"\tMessage: {(int)(e.StatusCode ?? 0)} {e.StatusCode}");
            
        }
        catch(Exception e)
        {
            Console.WriteLine("\nException cought from: GetProblems()");
            Console.WriteLine($"\tMessage: {e.Message}");
        }
        
        return new ProblemSet();
    }
}
