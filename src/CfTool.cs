namespace MyCfTool;

public class CfTool 
{
    public static readonly string URI = "https://codeforces.com/api/";
    public static readonly HttpClient client;
    
    static CfTool(){
        client = new HttpClient();
        client.Timeout = TimeSpan.FromSeconds(30);
    }

    public async Task Connect()
    {
        try
        {
            using HttpResponseMessage response = await client.GetAsync(URI + "problemset.problems");
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
        } 
        catch(HttpRequestException e)
        { 
            Console.WriteLine("\nException Cought!");
            Console.WriteLine($"\tMessage: {(int)(e.StatusCode ?? 0)} {e.StatusCode}");
        }
    }
}
