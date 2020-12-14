using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<double> lista = new List<double>();
        BindingSource source = new BindingSource();
        

        private void add_Click(object sender, EventArgs e)
        {
       
            double opt = double.Parse(number.Text);
            lista.Add(opt);
            numerik.Value = lista.Count;
            number.Clear();
            source.CurrencyManager.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ord_Click(object sender, EventArgs e)
        {            
            
            foreach (double i in lista)
            {
                listBox.Items.Add(i);
            }
            lista.Sort();
            Task.Delay(900).Wait();
            for (int i = 0; i<listBox.Items.Count; i++)
            {
                double selection = lista[i];               
                object moment = listBox.Items[i];
                
                int ind = listBox.Items.IndexOf(selection);
                listBox.Items[i] = listBox.Items[ind];
                Task.Delay(500).Wait();
                listBox.Items[ind] = "";
                Task.Delay(500).Wait();
                listBox.Items[ind] = moment;
            }


        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
         
        }



    }
}
