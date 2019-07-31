using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Teori_Falan
{

    public partial class GirdiAl : Form
    {

        public string Veri { get; set; }
        public string Başlık { get; set; }

        public string LabelVeri { get; set; }


        public GirdiAl()
        {
            InitializeComponent();
        }

        private void GirdiAl_Load(object sender, EventArgs e)
        {
            this.label1.Text = LabelVeri;
            this.Text = Başlık;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox1.Text) || String.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                Veri = " ";
            }
            Veri = this.textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
