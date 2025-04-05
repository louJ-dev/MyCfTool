using MyCfTool;

CfTool cftool = new CfTool();
var response = await Utils.GetProblems(CfTool.client); 
if (response != null)
{   
    var problems = response.problems;
    var stats = response.problemStatistics;
    
    // show 8 only for testing purposes
    int MAX = 8;
    
    for(int i = 0; i < MAX; i++)
    {
        Console.WriteLine(problems[i].ToString());
        Console.WriteLine(stats[i].ToString());
        
        // if(problems[i].index == "A")
        // {
        //     Console.WriteLine(problems[i].ToString());
        // }
    }
}

// trying out opening in browser
// Process.Start(new ProcessStartInfo() { FileName=@"https://www.google.com", UseShellExecute=true });
