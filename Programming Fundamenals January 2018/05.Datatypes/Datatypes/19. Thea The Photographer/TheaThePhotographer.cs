using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheaThePhotographer
{
    static void Main()
    {
        int numsOfPics=int.Parse(Console.ReadLine());
        int filterTime=int.Parse(Console.ReadLine());
        int percentPics=int.Parse(Console.ReadLine());
        int uploadTime=int.Parse(Console.ReadLine());

        int filteredPics=(int)Math.Ceiling(numsOfPics*percentPics/100.0);
        long totalPicsFilterTime=(long)numsOfPics*filterTime;
        long totalUploadTime=(long)filteredPics*uploadTime;
        long totalTimeInSec=totalPicsFilterTime+totalUploadTime;

        TimeSpan totalWorkTime= TimeSpan.FromSeconds(totalTimeInSec);
        
        string formatResult=@"d\:hh\:mm\:ss";

        Console.WriteLine(totalWorkTime.ToString(formatResult));
    }
}
