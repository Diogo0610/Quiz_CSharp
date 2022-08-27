using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizConcurso
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;

        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                MessageBox.Show("Você acertou! Clique em 'Ok' para continuar.", "Quiz");
                questionNumber++;
                askQuestion(questionNumber);
            }
            else
            {
                switch (correctAnswer)
                {
                    case 1:
                        MessageBox.Show($"Você errou! A resposta correta é a alternativa '{button1.Text}'." +
                        " Clique em 'Ok' para continuar.", "Quiz");
                        questionNumber++;
                        askQuestion(questionNumber);
                        break;
                    case 2:
                        MessageBox.Show($"Você errou! A resposta correta é a alternativa '{button2.Text}'." +
                        " Clique em 'Ok' para continuar.", "Quiz");
                        questionNumber++;
                        askQuestion(questionNumber);
                        break;
                    case 3:
                        MessageBox.Show($"Você errou! A resposta correta é a alternativa '{button3.Text}'." +
                        " Clique em 'Ok' para continuar.", "Quiz");
                        questionNumber++;
                        askQuestion(questionNumber);
                        break;
                    case 4:
                        MessageBox.Show($"Você errou! A resposta correta é a alternativa '{button4.Text}'." +
                        " Clique em 'Ok' para continuar.", "Quiz");
                        questionNumber++;
                        askQuestion(questionNumber);
                        break;
                }
            }
        }

        private void askQuestion(int questionNum)
        {
            switch (questionNum)
            {
                case 1:
                    lblQuestion.Text = "“Uma declaração do método final nunca pode mudar, assim todas as " +
                        "subclasses utilizam a mesma implementação do método; e chamadas métodos final são " +
                        "resolvidas em tempo de compilação – isso é conhecido como _________________.” " +
                        "Acerca da linguagem Java, assinale a alternativa que completa corretamente a " +
                        "afirmativa:";
                    button1.Text = "A) subclasse";
                    button2.Text = "B) superclasse ";
                    button3.Text = "C) vinculação estática";
                    button4.Text = "D) interface de marcação";
                    correctAnswer = 3;
                    break;
                case 2:
                    lblQuestion.Text = "Sobre a linguagem Java, analise as afirmativas a seguir." + Environment.NewLine +
                        "I.As instruções de um switch geralmente terminam com uma instrução break que termina a " +
                        "execução em um while, por exemplo. " + Environment.NewLine +
                        "II.A instrução break, quando executada em um while, " +
                        "for, do…while ou switch, ocasiona a saída imediata dessa instrução. " + Environment.NewLine +
                        "III.Os operadores & e | funcionam de forma idêntica aos operadores && e ||, mas sempre avaliam ambos os " +
                        "operandos." + Environment.NewLine +"IV.Cada valor que se deseja testar em um scanner deve ser " +
                        "listado em um rótulo case separado." + Environment.NewLine + "Está(ão) correta(s)apenas a(s) afirmativa(s)";
                    button1.Text = "A) II";
                    button2.Text = "B) III";
                    button3.Text = "C) I e IV";
                    button4.Text = "D) II e III";
                    correctAnswer = 4;
                    break;
            }
        }
    }
}
