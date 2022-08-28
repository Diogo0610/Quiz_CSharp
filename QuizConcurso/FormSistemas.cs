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
    public partial class FormSistemas : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        public FormSistemas()
        {
            InitializeComponent();
            askQuestion(questionNumber);
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
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
                        "operandos." + Environment.NewLine + "IV.Cada valor que se deseja testar em um scanner deve ser " +
                        "listado em um rótulo case separado." + Environment.NewLine + "Está(ão) correta(s)apenas a(s) afirmativa(s)";
                    button1.Text = "A) II";
                    button2.Text = "B) III";
                    button3.Text = "C) I e IV";
                    button4.Text = "D) II e III";
                    correctAnswer = 4;
                    break;
                case 3:
                    lblQuestion.Text = "O PHP possui diversas funções que são utilizadas para manipulação de imagens. Uma dessas " +
                        "funções define o modo de transparência de uma imagem. Assinale a alternativa correta que apresenta essa função.";
                    button1.Text = "A) gd_info";
                    button2.Text = "B) getimagesize";
                    button3.Text = "C) imagealphablending";
                    button4.Text = "D) imagecolorallocatealpha";
                    correctAnswer = 3;
                    break;
                case 4:
                    lblQuestion.Text = "“Sobre comandos do PHP para diretórios, esta função obtém o diretório corrente de trabalho.”" +
                        " Trata-se da função:";
                    button1.Text = "A) dir";
                    button2.Text = "B) readdir";
                    button3.Text = "C) getcwd";
                    button4.Text = "D) opendir";
                    correctAnswer = 3;
                    break;
                case 5:
                    lblQuestion.Text = "“Acerca dos comandos em PHP, sobre arrays, uma das funções retorna um array com chaves e valores trocados.”" +
                        " Essa função denomina-se:";
                    button1.Text = "A) array_fill";
                    button2.Text = "B) array-flip";
                    button3.Text = "C) array_keys";
                    button4.Text = "D) array_merge";
                    correctAnswer = 2;
                    break;
                case 6:
                    lblQuestion.Text = "Acerca das métricas de confiabilidade, “a confiabilidade pode ser especificada como a probabilidade de uma " +
                        "falha de sistema ocorrer quando um sistema estiver em uso dentro de um ambiente operacional especificado”. Existem duas " +
                        "métricas importantes para especificar a confiabilidade e uma adicional para especificar os atributos de disponibilidade, " +
                        "que estão relacionadas ao sistema.São essas métricas, EXCETO: ";
                    button1.Text = "A) Disponibilidade";
                    button2.Text = "B) Taxa de ocorrência de falhas";
                    button3.Text = "C) Probabilidade de falha sob demanda";
                    button4.Text = "D) Número de transações entre as falhas";
                    correctAnswer = 4;
                    break;
                case 7:
                    lblQuestion.Text = "Garantir a qualidade de um software engloba diversos fatores, bem como muitas atividades, " +
                        "concentradas na gestãoda qualidade do software, em que várias ações são apresentadas. “Uma dessas ações é uma função de " +
                        "controle dequalidade, mas que tem como objetivo principal descobrir erros”. Assinale a alternativa que apresenta essa ação.";
                    button1.Text = "A) Testes";
                    button2.Text = "B) Padrões";
                    button3.Text = "C) Proteção";
                    button4.Text = "D) Administração de segurança";
                    correctAnswer = 1;
                    break;
            }
        }
    }
}
