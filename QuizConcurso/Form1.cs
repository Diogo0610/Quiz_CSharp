using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuizConcurso
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top,
                int right, int bottom, int width, int height);
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSistemas formSistemas = new FormSistemas();
            formSistemas.ShowDialog();
            SistemasLbl.Text = $"Acertos: {formSistemas.AnswersCorrects}/25";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSuporte formSuporte = new FormSuporte();
            formSuporte.ShowDialog();
            SuporteLbl.Text = $"Acertos: {formSuporte.AnswersCorrects}/20";
        }
    }
}
