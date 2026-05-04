using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(File.Exists("Player.bin"))
            {
                ReadBinaryFile("Player.bin");
            }
            else
            {
                Player[] Arr = new Player[3]
                {
                new Player("Hearbert",100,10,10000),
                new Player("Damian",120,15,(decimal)15.55),
                new Player("Domaaenik",110, 12, (decimal)199.99)
                };

                WriteBinaryFile("Player.bin", Arr);
                ReadBinaryFile("Player.bin");
            }



        }
        private static void WriteBinaryFile(string path, Player[] Arr)
        {
            FileStream myStream = new FileStream(path, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(myStream);

            writer.Write(Arr.Length);
            for (int i = 0; i < Arr.Length; i++)
            {
                writer.Write(Arr[i].Name);
                writer.Write(Arr[i].Healt);
                writer.Write(Arr[i].Attak);
                writer.Write(Arr[i].Money);
            }

            writer.Close();
            myStream.Close();
        }
        private static void ReadBinaryFile(string path)
        {
            FileStream myStream = new FileStream(path, FileMode.Open);
            BinaryReader reader = new BinaryReader(myStream);

            int anzahl = reader.ReadInt32();
            Console.WriteLine(anzahl);

            while (reader.PeekChar() > -1)
            {
                string name = reader.ReadString();
                Console.WriteLine(name);

                int healt = reader.ReadInt32();
                Console.WriteLine(healt);

                int atk = reader.ReadInt32();
                Console.WriteLine(atk);

                decimal money = reader.ReadDecimal();
                Console.WriteLine(money);
            }

            reader.Close();
            myStream.Close();
        }
    }
}
