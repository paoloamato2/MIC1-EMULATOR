using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Linq;

namespace MIC1_SYS.Emulatore.ServiziTecnici.FileSystem
{
    public class GestoreFileSystem
    {
        private static readonly object Object = new object();
        private static volatile GestoreFileSystem _gfs;

        private GestoreFileSystem()
        {
        }

        public static GestoreFileSystem GetInstance()
        {
            if (_gfs != null) return _gfs;
            lock (Object)
            {
                if (_gfs == null) _gfs = new GestoreFileSystem();
            }

            return _gfs;
        }

        public string[] LeggiContenuto(string percorso)
        {
            return File.Exists(percorso) ? File.ReadAllLines(percorso) : null;
        }

        public void ScriviProgramma(string nome, int id, string[] data)
        {
            var toCompress = string.Join("\n", data);
            var toWrite = new List<string>
            {
                "----",
                "####",
                "Nome Programma: " + nome,
                "####",
                "ID Programma: " + id,
                "####",
                "Codice Programma:",
                CompressioneDati.CompressString(toCompress),
                "----"
            };

            //ToWrite.AddRange(data);


            TextWriter tw = new StreamWriter(Directory.GetCurrentDirectory() + @"\programs.programlist", true);
            foreach (var s in toWrite)
                tw.WriteLine(s);
            tw.Close();
        }

        public void ScriviMicroProgramma(string nome, int id, string[] data)
        {
            var toCompress = string.Join("\n", data);
            var toWrite = new List<string>
            {
                "----",
                "####",
                "Nome MicroProgramma: " + nome,
                "####",
                "ID MicroProgramma: " + id,
                "####",
                "Codice MicroProgramma:",
                CompressioneDati.CompressString(toCompress),
                "----"
            };


            //data = ToCompress.Split('\n');
            //ToWrite.AddRange(data);


            TextWriter tw = new StreamWriter(Directory.GetCurrentDirectory() + @"\microprograms.programlist", true);
            foreach (var s in toWrite)
                tw.WriteLine(s);
            tw.Close();

            //Debug.WriteLine(DecompressString("rAAAAB+LCAAAAAAABABzMDSy4DIgAPAqMAQCLgecagyRDTHEJgFjYppgaAiSM4QoMTQAAO3JcjCsAAAA"));
        }

        public void RimuoviProgramma(int id)
        {
            var readData = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\programs.programlist");
            var lineId = 0;
            string line;
            var found = false;
            var file = new StreamReader(Directory.GetCurrentDirectory() + @"\programs.programlist");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("ID Programma: " + id))
                {
                    found = true;
                    break;
                }

                lineId++;
            }

            file.Close();

            if (!found) return;
            var temp = readData.ToList();
            temp.RemoveRange(lineId - 4, 9);
            readData = temp.ToArray();
            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\programs.programlist", readData);
        }

        public void RimuoviMicroProgramma(int id)
        {
            var readData = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\microprograms.programlist");
            var lineId = 0;
            string line;
            var found = false;
            var file = new StreamReader(Directory.GetCurrentDirectory() + @"\microprograms.programlist");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("ID MicroProgramma: " + id))
                {
                    found = true;
                    break;
                }

                lineId++;
            }

            file.Close();

            if (!found) return;
            var temp = readData.ToList();
            temp.RemoveRange(lineId - 4, 9);
            readData = temp.ToArray();
            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\microprograms.programlist", readData);
        }

        public void RiscriviProgramma(int vecchioId, int nuovoId, string nuovoNome, string[] data)
        {
            var readData = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\programs.programlist");
            var lineId = 0;
            string line;
            var found = false;
            var file = new StreamReader(Directory.GetCurrentDirectory() + @"\programs.programlist");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("ID Programma: " + vecchioId))
                {
                    found = true;
                    break;
                }

                lineId++;
            }

            file.Close();

            if (!found) return;
            readData[lineId - 2] = "Nome Programma: " + nuovoNome;
            readData[lineId] = "ID Programma: " + nuovoId;

            var toCompress = string.Join("\n", data);

            readData[lineId + 3] = CompressioneDati.CompressString(toCompress);

            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\programs.programlist", readData);
        }

        public void RiscriviMicroProgramma(int vecchioId, int nuovoId, string nuovoNome, string[] data)
        {
            var readData = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\microprograms.programlist");
            var lineId = 0;
            string line;
            var found = false;
            var file = new StreamReader(Directory.GetCurrentDirectory() + @"\microprograms.programlist");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("ID MicroProgramma: " + vecchioId))
                {
                    found = true;
                    break;
                }

                lineId++;
            }

            file.Close();

            if (!found) return;
            readData[lineId - 2] = "Nome MicroProgramma: " + nuovoNome;
            readData[lineId] = "ID MicroProgramma: " + nuovoId;

            var toCompress = string.Join("\n", data);

            readData[lineId + 3] = CompressioneDati.CompressString(toCompress);
            // Debug.WriteLine(DecompressString("/0kAAB+LCAAAAAAABADtyjERADAIALG9aqh/c3AIAATk78dEzP36LaaDIAiCIAiCIAiCIAiCIAiCIAiCIAiCIAiCIAiCIAiCIAiCIAiCIAiCIAiCIAiCIAiCIAiCIAiCLigBLHYK4f9JAAA="));

            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\microprograms.programlist", readData);
        }


        public List<string[]> PrelevaProgrammi()
        {
            var returnedList = new List<string[]>();
            var readData = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\programs.programlist");
            string line;
            var lineId = 0;
            var file = new StreamReader(Directory.GetCurrentDirectory() + @"\programs.programlist");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("ID Programma:"))
                {
                    var arr = new string[3];
                    arr[0] = readData[lineId - 2].Substring(16); //nome
                    arr[1] = readData[lineId].Substring(14); //id
                    arr[2] = readData[lineId + 3];
                    arr[2] = CompressioneDati.DecompressString(arr[2]);
                    returnedList.Add(arr);
                }

                lineId++;
            }

            file.Close();

            return returnedList;
        }


        public List<string[]> PrelevaMicroProgrammi()
        {
            var returnedList = new List<string[]>();
            var readData = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\microprograms.programlist");
            string line;
            var lineId = 0;
            var file = new StreamReader(Directory.GetCurrentDirectory() + @"\microprograms.programlist");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("ID MicroProgramma:"))
                {
                    var arr = new string[3];
                    arr[0] = readData[lineId - 2].Substring(21); //nome
                    arr[1] = readData[lineId].Substring(19); //id
                    arr[2] = readData[lineId + 3];
                    arr[2] = CompressioneDati.DecompressString(arr[2]);
                    returnedList.Add(arr);
                }

                lineId++;
            }

            file.Close();

            return returnedList;
        }
    }
}