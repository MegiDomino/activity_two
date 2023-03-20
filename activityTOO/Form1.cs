using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listahan_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionOut.Text = listahan.Text;
        }

        private void butang_Click(object sender, EventArgs e)
        {
            listahan.Items.Add("Samsung S23 Ultra");
            listahan.Items.Add("TJNN Yuu-chan");
            listahan.Items.Add("All NNN Neso");
            listahan.Items.Add("Travel to Japan");
            listahan.Items.Add("Palit Kompyuter");
            listahan.Items.Add("Go to Maid Cafe");
            listahan.Items.Add("Go to Akihabara");
            listahan.Items.Add("Go to Kanda Myojin");
            listahan.Items.Add("Go to Numazu");
            listahan.Items.Add("Go to Odaiba");
            listahan.Items.Add("Go to Shinjuku");
            listahan.Items.Add("Go to Mito Sea");
            listahan.Items.Add("Palit yuta");
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sort_Click(object sender, EventArgs e)
        {
            listahan.Sorted = true;
        }

        private void tangtang_Click(object sender, EventArgs e)
        {
            listahan.Items.Clear();
        }

        private void ihap_Click(object sender, EventArgs e)
        {
            countOut.Text = Convert.ToString(listahan.Items.Count);
        }

        private void countOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectionOut_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
