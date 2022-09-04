namespace QuizConcurso
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SistemasLbl = new System.Windows.Forms.Label();
            this.SuporteLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(458, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha qual Quiz você quer praticar:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(138)))), ((int)(((byte)(154)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(214, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sistemas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(138)))), ((int)(((byte)(154)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(784, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Suporte";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SistemasLbl
            // 
            this.SistemasLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SistemasLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SistemasLbl.Location = new System.Drawing.Point(238, 450);
            this.SistemasLbl.Name = "SistemasLbl";
            this.SistemasLbl.Size = new System.Drawing.Size(201, 32);
            this.SistemasLbl.TabIndex = 3;
            this.SistemasLbl.Text = "Acertos: 0/25";
            // 
            // SuporteLbl
            // 
            this.SuporteLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SuporteLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SuporteLbl.Location = new System.Drawing.Point(822, 450);
            this.SuporteLbl.Name = "SuporteLbl";
            this.SuporteLbl.Size = new System.Drawing.Size(194, 32);
            this.SuporteLbl.TabIndex = 4;
            this.SuporteLbl.Text = "Acertos: 0/20";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 657);
            this.Controls.Add(this.SuporteLbl);
            this.Controls.Add(this.SistemasLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label SistemasLbl;
        private System.Windows.Forms.Label SuporteLbl;
    }
}

