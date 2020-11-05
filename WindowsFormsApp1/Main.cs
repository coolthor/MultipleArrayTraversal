using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

            List<int> a = new List<int>{ 1, 2, 3, 4 };
            List<int> b = new List<int> { 5, 6, 7, 8};
            List<int> c = new List<int> { 9, 10, 11, 12};
            List<int> d = new List<int> { 13, 14, 15, 16 };

            List<List<int>> summary = new List<List<int>> {a,b,c,d};
            try
            {
                int iCnt = 0;
                for (int i = 0; i < summary.Count; i++)
                {
                    summary[i].ForEach(o =>
                    {
                        if (i + 1 == summary.Count)
                            return;

                        for (int j = i + 1; j < summary.Count; j++)
                        {
                            summary[j].ForEach(t =>
                            {
                                iCnt++;
                                listBox1.Items.Add(o.ToString() + "*" + t.ToString());
                            });
                        }
                    });
                }
                listBox1.Items.Add("count:"+iCnt.ToString());
            }
            catch(Exception ex)
            {

            }
        }
    }
}
