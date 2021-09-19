using System;
using System.Drawing;
using System.IO;
using System.Text.Json;

namespace AppWebView
{
    public class Configuration
    {
        public static readonly DirectoryInfo CURRENT_PATH = new DirectoryInfo(AppContext.BaseDirectory);

        public string LaunchUrl { get; set; } = "https://teams.microsoft.com/";

        public string IconFilename { get; set; } = "";

        public string BrowserFixedVersionFolder { get; set; } = "";

        public Point Location { get; set; } = new Point(10, 10);

        public Size Size { get; set; } = new Size(1280, 720);

        public static FileInfo Filename
        {
            get
            {
                return new FileInfo(Path.Combine(CURRENT_PATH.FullName, "AppSettings.json"));
            }
        }

        public static DirectoryInfo BrowserUserData
        {
            get
            {
                return new DirectoryInfo(Path.Combine(CURRENT_PATH.FullName, "UserData"));
            }
        }

        public Configuration Load()
        {
            var config = new Configuration();

            if (Filename.Exists)
            {
                string fileContent = File.ReadAllText(Filename.FullName);
                config = JsonSerializer.Deserialize<Configuration>(fileContent);

                if (config.Location.X < -1000 || config.Location.Y < -1000)
                    config.Location = new Point(0, 0);

                if (config.Size.Width < -1000 || config.Size.Height < -1000)
                    config.Size = new Size(1280, 720);

                this.LaunchUrl = config.LaunchUrl;
                this.BrowserFixedVersionFolder = config.BrowserFixedVersionFolder;
                this.Location = config.Location;
                this.Size = config.Size;
                this.IconFilename = config.IconFilename;
            }

            return config;
        }
        
        public void Save()
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };

            var fileContent = JsonSerializer.Serialize(this, options);
            if (Filename.Exists)
            {
                Filename.Delete();
            }
            File.AppendAllText(Filename.FullName, fileContent);
        }

    }
}
