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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SistemasLbl = new System.Windows.Forms.Label();
            this.SuporteLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_quiz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Question_lbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NextCheckAnswer = new System.Windows.Forms.Button();
            this.Answer_radioD = new System.Windows.Forms.RadioButton();
            this.Answer_radioC = new System.Windows.Forms.RadioButton();
            this.Answer_radioB = new System.Windows.Forms.RadioButton();
            this.Answer_radioA = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(12, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sistemas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(12, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Suporte";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SistemasLbl
            // 
            this.SistemasLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SistemasLbl.AutoSize = true;
            this.SistemasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SistemasLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SistemasLbl.Location = new System.Drawing.Point(22, 191);
            this.SistemasLbl.Name = "SistemasLbl";
            this.SistemasLbl.Size = new System.Drawing.Size(153, 26);
            this.SistemasLbl.TabIndex = 3;
            this.SistemasLbl.Text = "Acertos: 0/25";
            // 
            // SuporteLbl
            // 
            this.SuporteLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SuporteLbl.AutoSize = true;
            this.SuporteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuporteLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SuporteLbl.Location = new System.Drawing.Point(22, 295);
            this.SuporteLbl.Name = "SuporteLbl";
            this.SuporteLbl.Size = new System.Drawing.Size(153, 26);
            this.SuporteLbl.TabIndex = 4;
            this.SuporteLbl.Text = "Acertos: 0/20";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SuporteLbl);
            this.panel1.Controls.Add(this.SistemasLbl);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(6, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 636);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 525);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 111);
            this.panel3.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(43, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_quiz);
            this.panel2.Location = new System.Drawing.Point(3, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 75);
            this.panel2.TabIndex = 0;
            // 
            // lbl_quiz
            // 
            this.lbl_quiz.AutoSize = true;
            this.lbl_quiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_quiz.Location = new System.Drawing.Point(65, 14);
            this.lbl_quiz.Name = "lbl_quiz";
            this.lbl_quiz.Size = new System.Drawing.Size(95, 40);
            this.lbl_quiz.TabIndex = 0;
            this.lbl_quiz.Text = "Quiz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Escolha o tema:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.panel4.Controls.Add(this.Question_lbl);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(223, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1035, 428);
            this.panel4.TabIndex = 6;
            // 
            // Question_lbl
            // 
            this.Question_lbl.AutoSize = true;
            this.Question_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Question_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Question_lbl.Location = new System.Drawing.Point(0, 0);
            this.Question_lbl.Name = "Question_lbl";
            this.Question_lbl.Size = new System.Drawing.Size(118, 29);
            this.Question_lbl.TabIndex = 0;
            this.Question_lbl.Text = "Pergunta";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.panel5.Controls.Add(this.NextCheckAnswer);
            this.panel5.Controls.Add(this.Answer_radioD);
            this.panel5.Controls.Add(this.Answer_radioC);
            this.panel5.Controls.Add(this.Answer_radioB);
            this.panel5.Controls.Add(this.Answer_radioA);
            this.panel5.Location = new System.Drawing.Point(223, 443);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1035, 202);
            this.panel5.TabIndex = 7;
            // 
            // NextCheckAnswer
            // 
            this.NextCheckAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.NextCheckAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NextCheckAnswer.Location = new System.Drawing.Point(893, 158);
            this.NextCheckAnswer.Name = "NextCheckAnswer";
            this.NextCheckAnswer.Size = new System.Drawing.Size(139, 41);
            this.NextCheckAnswer.TabIndex = 4;
            this.NextCheckAnswer.Text = "Próxima";
            this.NextCheckAnswer.UseVisualStyleBackColor = false;
            this.NextCheckAnswer.Click += new System.EventHandler(this.NextCheckAnswer);
            // 
            // Answer_radioD
            // 
            this.Answer_radioD.AutoSize = true;
            this.Answer_radioD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_radioD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Answer_radioD.Location = new System.Drawing.Point(5, 111);
            this.Answer_radioD.Name = "Answer_radioD";
            this.Answer_radioD.Size = new System.Drawing.Size(138, 29);
            this.Answer_radioD.TabIndex = 3;
            this.Answer_radioD.TabStop = true;
            this.Answer_radioD.Text = "Resposta D";
            this.Answer_radioD.UseVisualStyleBackColor = true;
            // 
            // Answer_radioC
            // 
            this.Answer_radioC.AutoSize = true;
            this.Answer_radioC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_radioC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Answer_radioC.Location = new System.Drawing.Point(5, 75);
            this.Answer_radioC.Name = "Answer_radioC";
            this.Answer_radioC.Size = new System.Drawing.Size(139, 29);
            this.Answer_radioC.TabIndex = 2;
            this.Answer_radioC.TabStop = true;
            this.Answer_radioC.Text = "Resposta C";
            this.Answer_radioC.UseVisualStyleBackColor = true;
            // 
            // Answer_radioB
            // 
            this.Answer_radioB.AutoSize = true;
            this.Answer_radioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_radioB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Answer_radioB.Location = new System.Drawing.Point(5, 39);
            this.Answer_radioB.Name = "Answer_radioB";
            this.Answer_radioB.Size = new System.Drawing.Size(137, 29);
            this.Answer_radioB.TabIndex = 1;
            this.Answer_radioB.TabStop = true;
            this.Answer_radioB.Text = "Resposta B";
            this.Answer_radioB.UseVisualStyleBackColor = true;
            // 
            // Answer_radioA
            // 
            this.Answer_radioA.AutoSize = true;
            this.Answer_radioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_radioA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Answer_radioA.Location = new System.Drawing.Point(5, 3);
            this.Answer_radioA.Name = "Answer_radioA";
            this.Answer_radioA.Size = new System.Drawing.Size(138, 29);
            this.Answer_radioA.TabIndex = 0;
            this.Answer_radioA.TabStop = true;
            this.Answer_radioA.Text = "Resposta A";
            this.Answer_radioA.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 657);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label SistemasLbl;
        private System.Windows.Forms.Label SuporteLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_quiz;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton Answer_radioD;
        private System.Windows.Forms.RadioButton Answer_radioC;
        private System.Windows.Forms.RadioButton Answer_radioB;
        private System.Windows.Forms.RadioButton Answer_radioA;
        private System.Windows.Forms.Label Question_lbl;
        private System.Windows.Forms.Button NextCheckAnswer;
    }
}

