namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main(string[] args)
        {//C:\Users\Deivid\source\repos\Advanced_ExerciseStreams, files and Directories_Skeleton\DirectoryTraversal
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath, "*");
            Dictionary<string, Dictionary<string, double>> filesInfo = new Dictionary<string, Dictionary<string, double>>();
            //.cs                    fileName, razmer        
            foreach (var filePath in files)
            {
                string fileName = Path.GetFileName(filePath);
                string extension = Path.GetExtension(filePath);
                double size = new FileInfo(filePath).Length / 1024.0;//razmer v kilobytes
                if (!filesInfo.ContainsKey(extension))
                {
                    filesInfo.Add(extension, new Dictionary<string, double>());
                }
                filesInfo[extension].Add(fileName, size);
            }
            StringBuilder sb = new StringBuilder();
            foreach (var item in filesInfo.OrderByDescending(x=>x.Value.Count)
                .ThenBy(x=>x.Key))
            {
                sb.AppendLine(item.Key);
                foreach (var file in item.Value.OrderBy(x=>x.Value))
                {
                    sb.AppendLine($"--{file.Key} - {file.Value:f3}kb");
                }
            }
            return sb.ToString().TrimEnd();
            //Get all files
            //Group by extension->name->size
            //order
            //return as string
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            //save as report.txt
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"/report.txt.";
            File.WriteAllText(path,textContent);
        }

    }
}
