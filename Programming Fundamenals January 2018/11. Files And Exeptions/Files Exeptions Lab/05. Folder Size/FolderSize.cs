using System;
using System.IO;
/// <summary>
/// This program calculate size of specific folder.
/// </summary>

namespace _05._Folder_Size
{
    class FolderSize
    {
        static void Main()
        {
            string[]dir=Directory.GetFiles("TestFolder");
            
            double dirSize=0;

            foreach (var file in dir)
            {
                FileInfo fileSize=new FileInfo(file);
                dirSize+=fileSize.Length;
            }
            dirSize=dirSize/1024/1024;
            File.WriteAllText("Output.txt",dirSize.ToString());
        }
    }
}
