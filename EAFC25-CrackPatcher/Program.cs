using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAFC25_CrackPatcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EAFC25-CrackPatcher by RimisiusDev";
            if (!File.Exists("EAFC25_CrackByRimisiusDev_SHOWCASE.zip"))
            {
                Console.WriteLine("This Zip File is not Exist... Pls Download EAFC25 Crack by RimisiusDev or NOT UNINSTALL THIS CRACK!!!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please Write you're Destination Folder: ");
                string Dest_Folder = Console.ReadLine();
                if (File.Exists(Dest_Folder + "\\EAFC25.exe"))
                {
                    File.Delete(Dest_Folder + "\\EAFC25.exe");
                    ZipFile.ExtractToDirectory("EAFC25_CrackByRimisiusDev.zip", Dest_Folder.ToString());
                }
                else
                {
                    Console.WriteLine("This File Is Deleted Manually!!! Extracting...");
                    ZipFile.ExtractToDirectory("EAFC25_CrackByRimisiusDev.zip", Dest_Folder.ToString());
                    Environment.Exit(443);
                }
            }
            Environment.Exit(2212);
        }
    }
}
