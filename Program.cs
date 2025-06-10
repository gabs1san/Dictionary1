using Dictionary1.Entities;
using System;
using System.Globalization;
using System.IO;

namespace Dicitionary1
{
    class Program
    {

        static void Main(string[] args)
        {
            Dicitionary<Vote, int> Votes = new Dicitionary<Vote, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] fields = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        if (fields.Length != 2)
                            continue;

                        string name = fields[0].Trim();
                        int tvc = int.Parse(fields[1].Trim());

                        Vote votes = new Vote { Name = name };

                        if (votes.ContainsKey(Votes))
                        {
                            votes[vote] += tvc;
                        }
                    }

                Console.WriteLine("Voting result: ");
                foreach (var entry in votes)
                {
                    Console.WriteLine(entry);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("\r\nError trying to read file: " + e.Message);
            }
        }
    }
}
