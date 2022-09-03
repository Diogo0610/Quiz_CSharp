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
    public partial class FormSuporte : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int corrects = 0;
        public FormSuporte()
        {
            InitializeComponent();
            askQuestion(questionNumber);
        }
        public int AnswersCorrects
        {
            get { return corrects; }
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                MessageBox.Show("Você acertou! Clique em 'Ok' para continuar.", "Quiz");
                corrects++;
                questionNumber++;
                askQuestion(questionNumber);
                if(questionNumber > 19)
                {
                    Close();
                }
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
                        if (questionNumber > 19)
                        {
                            Close();
                        }
                        break;
                    case 2:
                        MessageBox.Show($"Você errou! A resposta correta é a alternativa '{button2.Text}'." +
                        " Clique em 'Ok' para continuar.", "Quiz");
                        questionNumber++;
                        askQuestion(questionNumber);
                        if (questionNumber > 19)
                        {
                            Close();
                        }
                        break;
                    case 3:
                        MessageBox.Show($"Você errou! A resposta correta é a alternativa '{button3.Text}'." +
                        " Clique em 'Ok' para continuar.", "Quiz");
                        questionNumber++;
                        askQuestion(questionNumber);
                        if (questionNumber > 19)
                        {
                            Close();
                        }
                        break;
                    case 4:
                        MessageBox.Show($"Você errou! A resposta correta é a alternativa '{button4.Text}'." +
                        " Clique em 'Ok' para continuar.", "Quiz");
                        questionNumber++;
                        askQuestion(questionNumber);
                        if (questionNumber > 19)
                        {
                            Close();
                        }
                        break;
                }
            }
        }
        private void askQuestion(int questionNum)
        { 
            switch (questionNum)
            {
                case 1:
                    lblQuestion.Text = "O Windows 10 é o mais recente sistema operacional da Microsoft. Desde que foi lançado, em 2015, milhões de usuários instalaram esse novo sistema em seus computadores ou foram compradosjá com esse novo sistema. Muitos comandos podem ser utilizados com o Windows 10 através da janela “Executar”. Tomando como base o Windows 10, Configuração Local, Idioma Português-Brasil, um desses comandos tem a seguinte descrição: “abre o assistente de transferência de arquivo Bluetooth”. Trata-se do comando:";
                    button1.Text = "A) migwiz";
                    button2.Text = "B) fsquirt";
                    button3.Text = "C) wiaacmgr";
                    button4.Text = "D) appwiz.cpl";
                    correctAnswer = 2;
                    break;
                case 2:
                    lblQuestion.Text = "Ainda sobre os comandos do Windows 10, Configuração Local, Idioma Português-Brasil, relacione adequadamente as colunas a seguir." + Environment.NewLine +
                    "1. cliconfg. ( ) Utilitário de verificação de integridade dos arquivos do sistema." + Environment.NewLine + "2. charmap. ( ) Serviços de componente." + Environment.NewLine + "3. dcomcnfg. ( ) Utilitário de rede para clientes SQL Server." + Environment.NewLine + "4. dialer. ( ) Abre o mapa de caracteres." + Environment.NewLine + "5. sfc. ( ) Acessa o discador telefônico." + Environment.NewLine + "A sequência está correta em:";
                    button1.Text = "A) 5, 3, 1, 2, 4";
                    button2.Text = "B) 3, 5, 4, 1, 2";
                    button3.Text = "C) 2, 4, 3, 5, 1";
                    button4.Text = "D) 4, 1, 2, 3, 5";
                    correctAnswer = 1;
                    break;
                case 3:
                    lblQuestion.Text = "“O arquivo ________________ só é legível pelo superusuário e serve para manter senhas criptografadas protegidas contra o acesso não autorizado. Ele também fornece informações sobre contas que não são disponíveis em ________________.” Assinale a alternativa que completa correta e sequencialmente a afirmativa sobre o Sistema Operacional Linux.";
                    button1.Text = "A) /etc/passwd; /etc/group";
                    button2.Text = "B) /etc/group; /etc/passwd";
                    button3.Text = "C) /etc/passwd; etc/shaddow";
                    button4.Text = "D) /etc/shaddow; /etc/passwd";
                    correctAnswer = 4;
                    break;
                case 4:
                    lblQuestion.Text = "No sistema Linux, quando o kernel reclamar que um sistema de arquivos, que se tenta desmontar, está ocupado, a utilização do comando fuser ajuda a descobrir essa razão, sendo que este comando também pode relatar o uso de arquivos específicos. Nessa utilização, alguns códigos são exibidos, mostrando o que cada processo está fazendo para interferir na desmontagem. Esses códigos são apresentados por letras, como: [ f ], [ c ], [ e ], [ r ], [ m ]. Assinale a alternativa que apresenta corretamente o significado do código [ f ].";
                    button1.Text = "A) O processo está atualmente executando um arquivo";
                    button2.Text = "B) O processo possui um arquivo aberto para leitura ou gravação";
                    button3.Text = "C) O diretório atual do processo se encontra no sistema de arquivos";
                    button4.Text = "D) O processo mapeou um arquivo ou biblioteca compartilhada (normalmente um executável inativo)";
                    correctAnswer = 2;
                    break;
                case 5:
                    lblQuestion.Text = "“O __________________________ garante que o banco de dados permanece em um estado consistente (correto) apesar de falhas do sistema (por exemplo, interrupções de energia e falhas do sistema operacional) e falhas de transação.” Assinale a alternativa que completa corretamente a afirmativa sobre banco de dados.";
                    button1.Text = "A) organizador de arquivos";
                    button2.Text = "B) gerenciador de armazenamento";
                    button3.Text = "C) gerenciador de controle de concorrência";
                    button4.Text = "D) componente de gerenciamento de transação";
                    correctAnswer = 4;
                    break;
                case 6:
                    lblQuestion.Text = "O cabeçalho de um pacote IP (Internet Protocol – Protocolo de Internet) possui diversos componentes, cada um com suas funções definidas. Da mesma forma, o formato de um pacote ARP (Address Resolution Protocol) possui diversos componentes, mas com tamanho variável. Um desses componentes representa o endereço lógico desejado. Assinale a alternativa correta acerca desse componente.";
                    button1.Text = "A) Protocoll.en";
                    button2.Text = "B) ProtocolType";
                    button3.Text = "C) TargetProtocolAddr";
                    button4.Text = "D) SenderProtocolAddr";
                    correctAnswer = 3;
                    break;
                case 7:
                    lblQuestion.Text = "Analise as afirmativas a seguir." + Environment.NewLine + "I. O protocolo UDP (User Datagram Protocol) oferece aos protocolos da camada de aplicação um serviço orientado à conexão, ou seja, não confiável." + Environment.NewLine + "II. O protocolo UDP (User Datagram Protocol) transmite uma mensagem pelos canais de comunicação, igualmente como acontece com o TCP." + Environment.NewLine + "III. Como exemplos de protocolo que utilizam o protocolo UDP temos o DNS e o TELNET." + Environment.NewLine + "IV. Um segmento UDP é composto apenas de uma parte, que é também chamada cabeçalho de controle." + Environment.NewLine + "Está(ão) correta(s) apenas a(s) afirmativa(s)";
                    button1.Text = "A) I";
                    button2.Text = "B) I e II";
                    button3.Text = "C) II e III";
                    button4.Text = "D) III e IV";
                    correctAnswer = 2;
                    break;
                case 8:
                    lblQuestion.Text = "Em SQL, ao final de uma instrução CREATE TABLE, uma cláusula adicional pode ser usada para especificar outras restrições de tabelas, além das restrições de chave e integridade referencial, que são especificadas por palavras-chave especiais. Assinale a alternativa que apresenta corretamente essa cláusula";
                    button1.Text = "A) CHECK";
                    button2.Text = "B) WHERE";
                    button3.Text = "C) HAVING";
                    button4.Text = "D) CONSTAINTS";
                    correctAnswer = 1;
                    break;
                case 9:
                    lblQuestion.Text = "No desenvolvimento de aplicações TCP/IP, as interfaces utilizadas são conhecidas como APIs socket. “O socket estabelece um conjunto de interfaces para uma aplicação acessar os protocolos do modelo de referência TCP/IP”. Uma API socket é constituída basicamente por constantes, estruturas e funções C, que são chamadas em uma sequência adequada, na definição de algoritmos genéricos para aplicações cliente-servidor. Entre as funções socket, uma delas atribui o número de porta e o endereço IP para um socket recém-criado pela função socket(). Assinale a alternativa referente a essa função.";
                    button1.Text = "A) bind()";
                    button2.Text = "B) accept()";
                    button3.Text = "C) connect()";
                    button4.Text = "D) recvfrom()";
                    correctAnswer = 1;
                    break;
                case 10:
                    lblQuestion.Text = "O SMTP (Simple Mail Transfer Protocol) ou Protocolo de Transferência de Correio Simples é o protocolo padrão para envio de mensagens eletrônicas (e-mail) pela web. Utiliza, como protocolo da camada de transporte, o TCP (Transmission Control Protocol), tendo como porta padrão a de número 25, mas, devido ao grande número de spams, a porta recomendada pelo CGI para o SMTP passou a ser a 587. O SMTP utiliza comandos e respostas para suas requisições, sendo que essas respostas são através de códigos. Um desses códigos refere-se a uma mensagem de erro do tipo servidor temporariamente indisponível. Trata-se do código:";
                    button1.Text = "A) 1xx";
                    button2.Text = "B) 2xx";
                    button3.Text = "C) 4xx";
                    button4.Text = "D) 5xx";
                    correctAnswer = 3;
                    break;
                case 11:
                    lblQuestion.Text = "Acerca dos ataques de DoS (Denial of Service – Negação de Serviço), analise a afirmativa a seguir: “ele ataca a capacidade de um servidor em rede de responder a requisições de conexão TCP, inundando as tabelas usadas para gerenciar tais conexões. Isso significa que requisições de conexão futuras vindas de usuários legítimos falharão, negando a eles acesso ao servidor”. Assinale a alternativa que apresenta corretamente esse tipo de ataque.";
                    button1.Text = "A) Inundação ICMP";
                    button2.Text = "B) Inundação TCP SYN";
                    button3.Text = "C) Falsificação de SYN (SYN spoofing)";
                    button4.Text = "D) Falsificação de endereço de origem";
                    correctAnswer = 3;
                    break;
                case 12:
                    lblQuestion.Text = "O WINS (Windows Internet Name Service) é um serviço que resolve nomes de computadores para endereços IP presente na versão do Windows Server 2008 e Windows Server 2012. O WINS é necessário porque dá suporte a sistemas anteriores ao Windows 2000, bem como a aplicativos mais antigos que fazem uso do NETBIOS sobre TCP/IP, como os utilitários de linha comando .NET. Depois que um cliente estabelece uma sessão com o servidor WINS, ele poderá solicitar serviços de resolução de nome. Quatro métodos de resolução de nomes estão disponíveis; assinale-os.";
                    button1.Text = "A) Simples; Direto; Master; e, Híbrido";
                    button2.Text = "B) Híbrido; Malha; Simples; e, Híbrido";
                    button3.Text = "C) Único; Ponto a ponto; Híbrido; e, Master";
                    button4.Text = "D) Difusão; Ponto a ponto; Misto; e, Híbrido";
                    correctAnswer = 4;
                    break;
                case 13:
                    lblQuestion.Text = "“Refere-se ao esquema mais comum de rotação de mídias para backup. Foi originalmente concebido para execução de backup em fitas, mas funciona muito bem em qualquer estrutura de backup hierárquico. Seu método básico consiste em criar três conjuntos de backup, sendo um diário, um semanal e outro mensal.” Esse esquema de backup denomina-se:";
                    button1.Text = "A) Fileset backup (FSB)";
                    button2.Text = "B) SmallestVolume backup (SVB)";
                    button3.Text = "C) Storage daemon backup (SDB)";
                    button4.Text = "D) Grandfather-father-son backup (GFS)";
                    correctAnswer = 4;
                    break;
                case 14:
                    lblQuestion.Text = "Em relação aos sistemas distribuídos, analise a assertiva a seguir: “é composto por um conjunto de processos ou objetos, em um grupo de computadores, que interagem entre si de forma a implementar a comunicação e oferecer suporte para compartilhamento de recursos a aplicativos distribuídos”. Trata-se de:";
                    button1.Text = "A) Thread";
                    button2.Text = "B) Callback";
                    button3.Text = "C) Plataforma";
                    button4.Text = "D) Middleware";
                    correctAnswer = 4;
                    break;
                case 15:
                    lblQuestion.Text = "Assim como nos sistemas operacionais, os sistemas distribuídos também têm deadlock. Um deadlock distribuído “ocorre quando os processos espalhados por diferentes computadores em uma rede aguardam eventos que não ocorrerão”. Existem três tipos de deadlock distribuído. São esses tipos, EXCETO:";
                    button1.Text = "A) Deadlock fantasma";
                    button2.Text = "B) Deadlock de espera";
                    button3.Text = "C) Deadlock de recurso";
                    button4.Text = "D) Deadlock de comunicação";
                    correctAnswer = 2;
                    break;
                case 16:
                    lblQuestion.Text = "Uma instalação física segura para um computador do tipo Desktop requer uma série de cuidados. Assinale a afirmação correta relacionada com esses cuidados.";
                    button1.Text = "A) Recomenda-se o uso de no-breaks, sendo que diversos desses equipamentos, além de fornecerem alimentação ininterrupta ao computador, incluem um estabilizador e um filtro de linha.";
                    button2.Text = "B) O pino de terra da tomada deve ser eliminado, sempre que possível, para evitar que descargas advindas de raios atinjam o computador por esse pino.";
                    button3.Text = "C) O pino do neutro da tomada deve ser conectado ao pino terra para proteger o computador contra descargas elétricas e grandes flutuações da rede.";
                    button4.Text = "D) O uso de um estabilizador é interessante, uma vez que ele mantém a energia do computador por até 5 minutos no caso de queda da energia elétrica, tempo esse que permite o desligamento seguro do equipamento.";
                    correctAnswer = 1;
                    break;
                case 17:
                    lblQuestion.Text = "Os computadores, que possuem inúmeros componentes eletrônicos, devem ser manuseados com cuidado por um profissional que nele realiza manutenção ou instalação de novos componentes. Analise as afirmações a respeito desses cuidados:" + Environment.NewLine + "I. a remoção da poeira que se acumula nas placas deve ser feita com cuidado utilizando-se um pincel, evitando danos aos componentes eletrônicos, como capacitores e demais componentes salientes; produtos de limpeza como removedores, álcool comum e limpadores multi-uso não devem ser utilizados, exceto álcool isopropílico;" + Environment.NewLine + "II. as bordas das placas que possuem pontos de contato não devem ser tocadas, pois a oleosidade natural das mãos podem favorecer a oxidação dos mesmos e o acúmulo de sujeira, provocando mau contato;" + Environment.NewLine + "III. o profissional deve utilizar uma pulseira anti-estática, conectada ao pino neutro da tomada da rede elétrica, visando protegê-lo de choques acidentais." + Environment.NewLine + "Sobre as afirmações, pode-se dizer que está correto o contido em";
                    button1.Text = "A) I, apenas";
                    button2.Text = "B) II, apenas";
                    button3.Text = "C) III, apenas";
                    button4.Text = "D)  I e II, apenas";
                    correctAnswer = 4;
                    break;
                case 18:
                    lblQuestion.Text = "Analise as afirmações sobre o procedimento backup incremental:" + Environment.NewLine + "I. é efetuada a cópia apenas dos arquivos criados ou alterados desde a realização do último backup normal ou incremental;" + Environment.NewLine + "II. esse tipo de backup costuma ser mais lento do que os demais;" + Environment.NewLine + "III. o atributo de arquivo-morto dos arquivos é desmarcado;" + Environment.NewLine + "IV. uma das vantagens desse tipo de backup é requerer menor quantidade de armazenamento de dados." + Environment.NewLine + "Sobre as afirmações, pode - se dizer que está correto o contido em";
            button1.Text = "A) I, apenas";
                    button2.Text = "B) I e II, apenas";
                    button3.Text = "C) III e IV, apenas";
                    button4.Text = "D)  I, III e IV, apenas";
                    correctAnswer = 4;
                    break;
                case 19:
                    lblQuestion.Text = "Analise as afirmações sobre o procedimento backup diferencial:" + Environment.NewLine + "a restauração dos dados de um sistema exige apenas as mídias dos últimos backups normal e diferencial;" + Environment.NewLine + "II. apenas os arquivos criados ou alterados desde a realização do último procedimento de backup normal ou incremental são salvos;" + Environment.NewLine + "III. o atributo de arquivo-morto dos arquivos não é desmarcado," + Environment.NewLine + "Sobre as afirmações, pode-se dizer que está correto o contido em";
                    button1.Text = "A) I, apenas";
                    button2.Text = "B) II, apenas";
                    button3.Text = "C) III, apenas";
                    button4.Text = "D) I e II, apenas";
                    correctAnswer = 4;
                    break;
                case 20:
                    lblQuestion.Text = "Analise as afirmações sobre o procedimento backup diferencial:" + Environment.NewLine + "a restauração dos dados de um sistema exige apenas as mídias dos últimos backups normal e diferencial;" + Environment.NewLine + "II. apenas os arquivos criados ou alterados desde a realização do último procedimento de backup normal ou incremental são salvos;" + Environment.NewLine + "III. o atributo de arquivo-morto dos arquivos não é desmarcado," + Environment.NewLine + "Sobre as afirmações, pode-se dizer que está correto o contido em";
                    button1.Text = "A) I, apenas";
                    button2.Text = "B) II, apenas";
                    button3.Text = "C) III, apenas";
                    button4.Text = "D) I e II, apenas";
                    correctAnswer = 4;
                    break;
            }
        }
    }
}
