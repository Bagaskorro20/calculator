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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNILAIA.Text); // casting
            var b = Convert.ToInt32(txtNILAIB.Text); // casting

            Hasil.Items.Clear(); // kosongkan isi listbox

            // tampilkan hasil semua pemanggilan method calculator ke dalam listbox
            Hasil.Items.Add(string.Format("Hasil Penambahan : {0} + {1} = {2}", a, b, Penambahan(a, b)));
            Hasil.Items.Add(string.Format("Hasil Pengurangan : {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            Hasil.Items.Add(string.Format("Hasil Perkalian : {0} x {1} = {2}", a, b, Perkalian(a, b)));
            Hasil.Items.Add(string.Format("Hasil Pembagian : {0} / {1} = {2}", a, b, Pembagian(a, b)));
        }
    }
}
