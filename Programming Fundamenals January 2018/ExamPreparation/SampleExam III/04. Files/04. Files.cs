using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Files
{
    class File
    {
        public string Ext { get; set; }
        public long Size { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<File>> folders = new Dictionary<string, List<File>>();

            int numOfFiles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfFiles; i++)
            {
                string text = Console.ReadLine();
                string[] args = text.Split('\\', ';');
                string root = args[0];
                string extension = args[args.Length - 2];
                long size = long.Parse(args[args.Length - 1]);

                if (!folders.ContainsKey(root))
                {
                    folders.Add(root, new List<File>());
                }

                var allFiles = folders[root];

                var existing = allFiles
                    .FirstOrDefault(x => x.Ext == extension);

                if (existing == null)
                {
                    File currFile = new File()
                    {
                        Ext = extension,
                        Size = size
                    };
                    folders[root].Add(currFile);
                }
                else
                {
                    existing.Size = size;
                }
            }
            string[] search = Console.ReadLine().Split();
            string serchedExt = search[0];
            string dir = search.Last();

            if (!folders.ContainsKey(dir))
            {
                Console.WriteLine("No");
                return;
            }

            var result = folders[dir]
                .Where(x => x.Ext.EndsWith(serchedExt))
                .OrderByDescending(x => x.Size)
                .ThenBy(x => x.Ext)
                .ToList();

            if (!folders[dir].Any(x => x.Ext.EndsWith(serchedExt)))
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Ext} - {item.Size} KB ");
                }

            }


        }
    }
}
