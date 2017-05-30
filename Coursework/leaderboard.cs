using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class leaderboard : Form
    {
        
            public leaderboard()
        {
            InitializeComponent();
            WorkWithXML.WriteXml();
            if (WorkWithXML.List != null)
            {

                for (int i = 0; i < WorkWithXML.List.Count; i++)
                {
                    listBox1.Items.Add(WorkWithXML.List[i].Score + "\t"+ WorkWithXML.List[i].Name);
                }
            }

        }
        
    }
}