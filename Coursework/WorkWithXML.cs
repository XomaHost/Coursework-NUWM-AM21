using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Coursework
{
    class WorkWithXML
    {
        public static List<Playerforsave> List;

        public static void WriteXml()
        {
           
            List = new List<Playerforsave>();
            Readxml();
            if (Game.Player != null)
            {


                List.Add(new Playerforsave(Game.Player.score, Game.Player.name));
                List.Sort(delegate (Playerforsave c1, Playerforsave c2) { return c2.Score.CompareTo(c1.Score); });
            }
            XmlTextWriter writer = null;
            writer = new XmlTextWriter("Score.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("Score");
            for (int i = 0; i < List.Count; i++)
            {
                writer.WriteElementString(List[i].Name, "" + List[i].Score);
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            if (writer != null)
            {
                writer.Close();
            }
        }

        public static void Readxml()
        {
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader("Score.xml");
                reader.WhitespaceHandling = WhitespaceHandling.None;
                int count = 0;
                int check = 0;
                bool qwer = true;
                int a = 0;
                string b = "0";
                try
                {
                    while (reader.Read())
                    {
                        if (count > 1)
                        {
                            if (check == 0 && qwer == true)
                            {
                                b = reader.Name;
                                check++;
                                qwer = false;
                            }
                            if (check == 1 && qwer == true)
                            {
                                a = Convert.ToInt32(reader.Value);
                                qwer = false;
                                check++;
                            }
                            if (check == 2 && qwer == true)
                            {
                                qwer = false;
                                check = 0;
                                List.Add(new Playerforsave(a, b));
                            }
                            qwer = true;
                        }
                        count++;
                    }
                }
                catch (SystemException) { }
            }
            catch (XmlException)
            {
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        
    }
    public class Playerforsave
    {
        public int Score { set; get; }
        public string Name { set; get; }
        public Playerforsave(int score, string name)
        {
            Score = score;
            Name = name;
        }
    }
}
