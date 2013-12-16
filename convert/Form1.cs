using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox7.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8);

                List<string> lLineEN = new List<string>();
                List<string> lLineVI = new List<string>();
                List<string> lLineDE = new List<string>();
                List<string> lLineID = new List<string>();
                List<string> lLineTH = new List<string>();
                List<string> lLineRU = new List<string>();
                foreach (string line in richTextBox7.Lines)
                {
                    if (line.Trim() != "")
                    {
                        string[] temp = line.Split('\t');
                        lLineEN.Add(temp[0].Replace("\"", "\\\"").Replace("  ", " ").Trim());
                        lLineVI.Add(temp[1].Replace("\"", "\\\"").Replace("  ", " ").Trim());
                        lLineDE.Add(temp[2].Replace("\"", "\\\"").Replace("  ", " ").Trim());
                        lLineID.Add(temp[3].Replace("\"", "\\\"").Replace("  ", " ").Trim());
                        lLineTH.Add(temp[4].Replace("\"", "\\\"").Replace("  ", " ").Trim());
                        lLineRU.Add(temp[5].Replace("\"", "\\\"").Replace("  ", " ").Trim());
                    }
                }
                richTextBox7.Text = "";
                for (int i = 0; i < lLineEN.Count; i++)
                {
                    richTextBox7.AppendText("\"" + lLineEN[i] + "\"=\"" + lLineEN[i] + "\";");
                    richTextBox7.AppendText("\n");
                }
                //***-EN
                for (int i = 0; i < lLineEN.Count; i++)
                {
                    richTextBox1.AppendText("\"" + lLineEN[i] + "\"=\"" + lLineEN[i] + "\";");
                    richTextBox1.AppendText("\n");
                    richTextBox1.AppendText("\"" + lLineVI[i] + "\"=\"" + lLineEN[i] + "\";");
                    richTextBox1.AppendText("\n");
                    richTextBox1.AppendText("\"" + lLineDE[i] + "\"=\"" + lLineEN[i] + "\";");
                    richTextBox1.AppendText("\n");
                    richTextBox1.AppendText("\"" + lLineID[i] + "\"=\"" + lLineEN[i] + "\";");
                    richTextBox1.AppendText("\n");
                    richTextBox1.AppendText("\"" + lLineTH[i] + "\"=\"" + lLineEN[i] + "\";");
                    richTextBox1.AppendText("\n");
                    richTextBox1.AppendText("\"" + lLineRU[i] + "\"=\"" + lLineEN[i] + "\";");
                    richTextBox1.AppendText("\n");
                }

                //***-VI
                for (int i = 0; i < lLineEN.Count; i++)
                {
                    richTextBox2.AppendText("\"" + lLineEN[i] + "\"=\"" + lLineVI[i] + "\";");
                    richTextBox2.AppendText("\n");
                    richTextBox2.AppendText("\"" + lLineVI[i] + "\"=\"" + lLineVI[i] + "\";");
                    richTextBox2.AppendText("\n");
                    richTextBox2.AppendText("\"" + lLineDE[i] + "\"=\"" + lLineVI[i] + "\";");
                    richTextBox2.AppendText("\n");
                    richTextBox2.AppendText("\"" + lLineID[i] + "\"=\"" + lLineVI[i] + "\";");
                    richTextBox2.AppendText("\n");
                    richTextBox2.AppendText("\"" + lLineTH[i] + "\"=\"" + lLineVI[i] + "\";");
                    richTextBox2.AppendText("\n");
                    richTextBox2.AppendText("\"" + lLineRU[i] + "\"=\"" + lLineVI[i] + "\";");
                    richTextBox2.AppendText("\n");
                }

                //***-DE
                for (int i = 0; i < lLineEN.Count; i++)
                {
                    richTextBox3.AppendText("\"" + lLineEN[i] + "\"=\"" + lLineDE[i] + "\";");
                    richTextBox3.AppendText("\n");
                    richTextBox3.AppendText("\"" + lLineVI[i] + "\"=\"" + lLineDE[i] + "\";");
                    richTextBox3.AppendText("\n");
                    richTextBox3.AppendText("\"" + lLineDE[i] + "\"=\"" + lLineDE[i] + "\";");
                    richTextBox3.AppendText("\n");
                    richTextBox3.AppendText("\"" + lLineID[i] + "\"=\"" + lLineDE[i] + "\";");
                    richTextBox3.AppendText("\n");
                    richTextBox3.AppendText("\"" + lLineTH[i] + "\"=\"" + lLineDE[i] + "\";");
                    richTextBox3.AppendText("\n");
                    richTextBox3.AppendText("\"" + lLineRU[i] + "\"=\"" + lLineDE[i] + "\";");
                    richTextBox3.AppendText("\n");
                }

                //***-ID
                for (int i = 0; i < lLineEN.Count; i++)
                {
                    richTextBox4.AppendText("\"" + lLineEN[i] + "\"=\"" + lLineID[i] + "\";");
                    richTextBox4.AppendText("\n");
                    richTextBox4.AppendText("\"" + lLineVI[i] + "\"=\"" + lLineID[i] + "\";");
                    richTextBox4.AppendText("\n");
                    richTextBox4.AppendText("\"" + lLineDE[i] + "\"=\"" + lLineID[i] + "\";");
                    richTextBox4.AppendText("\n");
                    richTextBox4.AppendText("\"" + lLineID[i] + "\"=\"" + lLineID[i] + "\";");
                    richTextBox4.AppendText("\n");
                    richTextBox4.AppendText("\"" + lLineTH[i] + "\"=\"" + lLineID[i] + "\";");
                    richTextBox4.AppendText("\n");
                    richTextBox4.AppendText("\"" + lLineRU[i] + "\"=\"" + lLineID[i] + "\";");
                    richTextBox4.AppendText("\n");
                }

                //***-TH
                for (int i = 0; i < lLineEN.Count; i++)
                {
                    richTextBox5.AppendText("\"" + lLineEN[i] + "\"=\"" + lLineTH[i] + "\";");
                    richTextBox5.AppendText("\n");
                    richTextBox5.AppendText("\"" + lLineVI[i] + "\"=\"" + lLineTH[i] + "\";");
                    richTextBox5.AppendText("\n");
                    richTextBox5.AppendText("\"" + lLineDE[i] + "\"=\"" + lLineTH[i] + "\";");
                    richTextBox5.AppendText("\n");
                    richTextBox5.AppendText("\"" + lLineID[i] + "\"=\"" + lLineTH[i] + "\";");
                    richTextBox5.AppendText("\n");
                    richTextBox5.AppendText("\"" + lLineTH[i] + "\"=\"" + lLineTH[i] + "\";");
                    richTextBox5.AppendText("\n");
                    richTextBox5.AppendText("\"" + lLineRU[i] + "\"=\"" + lLineTH[i] + "\";");
                    richTextBox5.AppendText("\n");
                }

                //***-RU
                for (int i = 0; i < lLineEN.Count; i++)
                {
                    richTextBox6.AppendText("\"" + lLineEN[i] + "\"=\"" + lLineRU[i] + "\";");
                    richTextBox6.AppendText("\n");
                    richTextBox6.AppendText("\"" + lLineVI[i] + "\"=\"" + lLineRU[i] + "\";");
                    richTextBox6.AppendText("\n");
                    richTextBox6.AppendText("\"" + lLineDE[i] + "\"=\"" + lLineRU[i] + "\";");
                    richTextBox6.AppendText("\n");
                    richTextBox6.AppendText("\"" + lLineID[i] + "\"=\"" + lLineRU[i] + "\";");
                    richTextBox6.AppendText("\n");
                    richTextBox6.AppendText("\"" + lLineTH[i] + "\"=\"" + lLineRU[i] + "\";");
                    richTextBox6.AppendText("\n");
                    richTextBox6.AppendText("\"" + lLineRU[i] + "\"=\"" + lLineRU[i] + "\";");
                    richTextBox6.AppendText("\n");
                }
            }
        }
    }
}
