using BucStop.Models;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace BucStop.Services
{

    public class VisitCountManager
    {
        private VisitCount visitCount;
        private string jsonFilePath;  // Field to store the JSON file path

        //public VisitCountManager(VisitCount visitCount, IWebHostEnvironment webHostEnvironment)
        public VisitCountManager(IWebHostEnvironment webHostEnvironment)
        {
            //this.visitCount = visitCount;
            this.visitCount = new VisitCount { Id = 1, VisitorCount = 0 };
            jsonFilePath = Path.Combine(webHostEnvironment.WebRootPath, "visitcount.json");
            LoadVisitCounts();
        }

        public void IncrementVisitCount()
        {
            visitCount.VisitorCount++;
            SaveVisitCounts();
        }

        public int GetVisitCounts()
        {
            return visitCount.VisitorCount;
        }

        private void LoadVisitCounts()
        {
            if (File.Exists(jsonFilePath))
            {
                var jsonText = File.ReadAllText(jsonFilePath);
                var loadedVisitCount = JsonSerializer.Deserialize<VisitCount>(jsonText);

                if (loadedVisitCount != null)
                {
                    visitCount.VisitorCount = loadedVisitCount.VisitorCount;
                }
            }
            else
            {
                // if the file doesn't exist, initialize the visit count to 0
                visitCount.VisitorCount = 0;
                SaveVisitCounts();
            }
        }

        private void SaveVisitCounts()
        {
            var jsonText = JsonSerializer.Serialize(visitCount);
            File.WriteAllText(jsonFilePath, jsonText);
        }
    }
}