using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Proyecto_de_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fons_formulari.PNG");
            this.BackgroundImage = img;
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWord.Text = "Josselyn Edith Rivas Garay";
            label1.Text = "USIS052421";
            label2.Text = "Karla Daniela Torres Esperanza";
            label3.Text = "USIS046821";
            label4.Text = "Ivania Melani Campos Gómez";
            label5.Text = "USIS055421";
            label6.Text = "Alan Derek Henríquez Monterrosa";
            label7.Text = "USIS003421";
            label8.Text = "Geovanni Alexander Guerrero Munguía";
            label9.Text = "USIS015221";
            label10.Text = "Álvaro Antonio Rivera Moran";
            label11.Text = "USIS039521";

        }

        private void lblHelloWord_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
