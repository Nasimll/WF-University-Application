using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLIst
{

    
    class Students
    {
        public static List<string> students = new List<string>();
        public static Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        public string name {  get; set; }
        public string lastname {  get; set; }

        public string classes { get; set; }
        public string id { get; set; }

       public static string data;

        public Students( string name, string lastname, string classes, string id)
        {
            this.name = name;
            this.lastname = lastname;
            this.classes = classes;
            this.id = id;

        }


        public Students(string data)
        {
            string[] splitData = data.Split('/');
            this.name = splitData[0];
            this.lastname = splitData[1];
            this.classes = splitData[3];
            this.id = splitData[2];
        }


        public string dataString()
        {
            return $"{name}/{lastname}/{id}/{classes}";
        }


        public static List<string> getWordsBasedOnKey(string key)
        {
            List<string> result = new List<string>();

            if (key == "All")
            {
                foreach (var entry in dictionary)
                {
                    foreach (var data in entry.Value)
                    {
                        Students st = new Students(data);
                        result.Add(st.id);
                    }
                }
            }
            else
            {
                if (dictionary.ContainsKey(key))
                {
                    foreach (var data in dictionary[key])
                    {
                        Students st = new Students(data);
                        result.Add(st.id);
                    }
                }
            }

            return result;
        }

        public static void writeProduct(Students st)
        {
            FileStream fs = new FileStream("dataFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(st.dataString());

            sw.Close();
            fs.Close();

        }

        public static void ReadFile()
        {
            
            FileStream fs = new FileStream("dataFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                string[] splitData = line.Split('/');
                string classeNeed = splitData[3];

                if (!dictionary.ContainsKey(classeNeed)){

                    dictionary.Add(classeNeed, new List<string>());
                }

                dictionary[classeNeed].Add(line);
            }

            sr.Close();
            fs.Close();
        }


        public void checkifCOntains(string id) 
        {
            
        }


    }
}
