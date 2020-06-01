using NSoup.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArivaScraperMarvin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var getdata = new Dictionary<String, List<Double>>(); try
            {
                String url1 = "https://www.ariva.de/ado_properties_s-a-aktie/bilanz-guv" + "?page=1";

                SortedDictionary<String, List<Double>> daten = new SortedDictionary<String, List<Double>>();

                Document dc = NSoup.connect(url1).timeout(6000).get();


            }
            catch (Exception i)
            {
                Console.WriteLine($"Generic Exception Handler: {i}");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        public String richTextBox1_TextChanged(object sender, EventArgs e)
        {
            String url = "https://www.ariva.de/ado_properties_s-a-aktie/bilanz-guv";
            return url;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
