using System.Collections.Generic;
using System.IO;
using BucStop.Models;
using System.Text.Json;

public class VisitCountService
{
    private string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "visitcount.json");
    
    public VisitCount? GetVisitCount()
    {
        string json = File.ReadAllText(path);
        VisitCount? visitcount = JsonSerializer.Deserialize<VisitCount>(json);
        return visitcount;
    }
}