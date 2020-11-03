using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TrelloAttachmentsDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Pass path to json file through arguments!");
                return;
            }
            var fileName = args[0];
            var fileContent = File.ReadAllText(fileName);
            var result = JsonConvert.DeserializeObject<RootCard>(fileContent);
            var cardName = result.name;
            var assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var outputFolder = Path.Combine(assemblyFolder, cardName);
            var attachments = result.actions
                .Where(x =>
                    x.data.attachment != null &&
                    !string.IsNullOrEmpty(x.data.attachment.url) &&
                    !string.IsNullOrEmpty(x.data.attachment.name))
                .Select(x => x.data.attachment)
                .ToArray();
            if(attachments.Any())
            {
                if (Directory.Exists(outputFolder))
                {
                    Console.WriteLine($@"Output folder ""{outputFolder}"" already exists!");
                    return;
                }
                Directory.CreateDirectory(outputFolder);
            }
            int i = 1;
            foreach (var attachment in attachments)
            {
                Console.WriteLine($"[{i}/{attachments.Length}] Downloading {attachment.name}");
                using (var wc = new System.Net.WebClient())
                    wc.DownloadFile(attachment.url, Path.Combine(outputFolder, attachment.name));
                i++;
            }
            if(attachments.Any())
            {
                Console.WriteLine(@$"Attachments successfully downloaded to folder ""{outputFolder}""");
            }
        }
    }
}
