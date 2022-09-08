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
        int corrects = 0;
        public FormSistemas()
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
                if (questionNumber > 25)
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
                        if (questionNumber > 25)
                        {
                            Close();
                        }
                        break;
                    case 2:
                        MessageBox.Show($"Você errou! A resposta correta é a alternativa '{button2.Text}'." +
                        " Clique em 'Ok' para continuar.", "Quiz");
                        questionNumber++;
                        askQuestion(questionNumber);
                        if (questionNumber > 25)
                        {
                            Close();
                        }
                        break;
                    case 3:
                        MessageBox.Show($"Você errou! A resposta correta é a alternativa '{button3.Text}'." +
                        " Clique em 'Ok' para continuar.", "Quiz");
                        questionNumber++;
                        askQuestion(questionNumber);
                        if (questionNumber > 25)
                        {
                            Close();
                        }
                        break;
                    case 4:
                        MessageBox.Show($"Você errou! A resposta correta é a alternativa '{button4.Text}'." +
                        " Clique em 'Ok' para continuar.", "Quiz");
                        questionNumber++;
                        askQuestion(questionNumber);
                        if (questionNumber > 25)
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
                case 8:
                    lblQuestion.Text = "Desenvolver software com qualidade e eficiência demanda muito trabalho e muitos fatores devem ser levados em  conta nessa tarefa. As funcionalidades do software devem ser medidas sob o ponto de vista do usuário. Com relação à qualidade do código, o atributo compreensibilidade refere-se a duas métricas. Assinale a alternativa referente a uma dessas métricas.";
                    button1.Text = "A) Índice de regularidade";
                    button2.Text = "B) Número de padrões usados";
                    button3.Text = "C) Convenções de atribuição variáveis";
                    button4.Text = "D) Complexidade do projeto procedural";
                    correctAnswer = 3;
                    break;
                case 9:
                    lblQuestion.Text = "O HTMLS 5 introduziu vários atributos novos para formulários, tipos de entrada e outros elementos. No caso de formulários, esse atributo especifica uma expressão regular de JavaScript para o valor do campo que possa ser verificada, bem como facilita implementar uma validação específica para códigos de produto, números de cobrança, e assim por diante. Assinale a alternativa que apresenta esse atributo.";
                    button1.Text = "A) pattern";
                    button2.Text = "B) required";
                    button3.Text = "C) autofocus";
                    button4.Text = "D) placeholder";
                    correctAnswer = 1;
                    break;
                case 10:
                    lblQuestion.Text = "Em Modelagem de Dados, um tipo de atributo, que não pertence propriamente ao objeto (entidade ou relacionamento) onde está alocado, mas fez algum tipo de citação ou ligação desse objeto com outro, recebe um nome. Assinale a alternativa referente a esse atributo.";
                    button1.Text = "A) Atributo chave";
                    button2.Text = "B) Atributo referencial";
                    button3.Text = "C) Atributo descritivo derivado";
                    button4.Text = "D) Atributo descritivo composto";
                    correctAnswer = 2;
                    break;
                case 11:
                    lblQuestion.Text = "“O processo __________________ pode envolver a escolha de estratégias alternativas, a execução de um plano de contingência ou alternativo, a adoção de ações corretivas e a modificação do plano de gerenciamento do projeto.” Acerca dos processos das áreas do conhecimento em Gestão de Projetos, de acordo com o guia PMBOK 5, assinale a alternativa que completa corretamente a afirmativa anterior.";
                    button1.Text = "A) Controlar os riscos";
                    button2.Text = "B) Controlar os custos";
                    button3.Text = "C) Controlar as aquisições";
                    button4.Text = "D) Controlar as comunicações";
                    correctAnswer = 1;
                    break;
                case 12:
                    lblQuestion.Text = "De acordo com o PMBOK 5, o Gerenciamento das Aquisições do Projeto “inclui os processos necessários para comprar ou adquirir produtos, serviços ou resultados externos à equipe do projeto”. Um dos processos do gerenciamento das aquisições do projeto é controlar as aquisições. Segundo o PMBOK, os processos das áreas de conhecimento em Gestão de Projetos possuem Entradas, Ferramentas e Técnicas e Saídas. Assinale a alternativa que apresenta uma das ferramentas e técnicas do processo controlar as aquisições.";
                    button1.Text = "A) Solicitações de mudança";
                    button2.Text = "B) Sistema de gerenciamento de registros";
                    button3.Text = "C) Atualizações nos documentos do projeto";
                    button4.Text = "D) Atualizações no plano de gerenciamento de projeto";
                    correctAnswer = 2;
                    break;
                case 13:
                    lblQuestion.Text = "A etapa de Mineração de Dados compreende a busca efetiva por conhecimentos úteis no contexto da aplicação de KDD (Knowledge Discovery in Database), ou Descoberta do Conhecimento em Bases de Dados. É a principal etapa do processo de KDD.” Acerca de algumas das tarefas do KDD, analise a assertiva a seguir: “compreende a busca por uma função que mapeie os registros de um banco de dados em um intervalo de valores reais”. Assinale a alternativa que apresenta esta tarefa.";
                    button1.Text = "A) Regressão";
                    button2.Text = "B) Classificação";
                    button3.Text = "C) Sumarização";
                    button4.Text = "D) Agrupamento";
                    correctAnswer = 2;
                    break;
                case 14:
                    lblQuestion.Text = "Acerca dos métodos tradicionais de Mineração de Dados, um desses métodos “produz Árvores de Decisão a partir de uma abordagem recursiva de particionamento de um conjunto de dados, e utiliza conceitos e medidas da Teoria da Informação”. Trata-se do método:";
                    button1.Text = "A) C4.5";
                    button2.Text = "B) Apriori";
                    button3.Text = "C) Máquinas de Vetores Suporte";
                    button4.Text = "D) Classificador Bayesiano Ingênuo";
                    correctAnswer = 1;
                    break;
                case 15:
                    lblQuestion.Text = "Acerca dos cabeçalhos em HTML5, um desses novos elementos é “usado para informação adicional sobre o conteúdo, tais como quem o escreveu, links para documentos relacionados, dados de copyright, um link para o topo da página, etc., e normalmente aparece no fim do conteúdo”. Esse elemento denomina-se";
                    button1.Text = "A) <footer>";
                    button2.Text = "B) <header>";
                    button3.Text = "C) <hgroup>";
                    button4.Text = "D) <filedset>";
                    correctAnswer = 1;
                    break;
                case 16:
                    lblQuestion.Text = "Os computadore digitais convencionais baseiam-se no modelo idealizado por John Von Neumann, que prevê cinco componentes principais. Diante disso, assinale a alternativa que apresenta um componente INVÁLIDO.";
                    button1.Text = "A) Unidade de memória";
                    button2.Text = "B) Unidade de controle";
                    button3.Text = "C) Unidade de conversão";
                    button4.Text = "D) Unidade lógica e aritmética";
                    correctAnswer = 3;
                    break;
                case 17:
                    lblQuestion.Text = "Nos processadores atuais, são implementadas unidades de cálculo de números reais. Essas unidades são mais complexas que unidades de lógica e aritmética e trabalham com operadores maiores, com tamanhos típicos variando entre 64 e 128 bits. Sendo assim, assinale a alternativa que apresenta o nome dessa unidade.";
                    button1.Text = "A) Unidade de controle de cálculo";
                    button2.Text = "B) Unidade de ponto flutuante";
                    button3.Text = "C) Unidade de cálculo real";
                    button4.Text = "D) Unidade lógica centralizada";
                    correctAnswer = 2;
                    break;
                case 18:
                    lblQuestion.Text = "Assinale a alternativa que apresenta a definição correta de memória estática.";
                    button1.Text = "A) Os dados são gravados de modo semipermanente em pequenos cartões ou faixas revestidos com filme magnético.";
                    button2.Text = "B) Os dados contidos nela podem ser acessados a partir de qualquer endereço.";
                    button3.Text = "C) Pode ser gravada ou regravada por meio de um equipamento que fornece voltagens adequadas para cada pino.";
                    button4.Text = "D) Não precisa ser analisada ou recarregada a cada momento. É fabricada com circuitos latch.";
                    correctAnswer = 4;
                    break;
                case 19:
                    lblQuestion.Text = "Considerando os tipos de arquiteturas de sistemas operacionais, assinale a alternativa que apresenta aquele em que todos os componentes do núcleo operam em modo núcleo e se inter-relacionam conforme suas necessidades, sem restrições de acesso entre si, pois o código no nível núcleo tem acesso pleno a todos os recursos e áreas de memória.";
                    button1.Text = "A) Sistemas em camadas";
                    button2.Text = "B) Sistemas monolíticos";
                    button3.Text = "C) Sistemas micronúcleos";
                    button4.Text = "D) Sistemas lineares";
                    correctAnswer = 2;
                    break;
                case 20:
                    lblQuestion.Text = "As redes cuja arquitetura é dedicada ao armazenamento de dados são conhecidas como:";
                    button1.Text = "A) PAN";
                    button2.Text = "B) WAN";
                    button3.Text = "C) MAN";
                    button4.Text = "D) SAN";
                    correctAnswer = 4;
                    break;
                case 21:
                    lblQuestion.Text = "O termo que determina a capacidade de transmissão, em especial da conexão de rede, além de ser usada em processamento de sinais, eletrônica e mesmo em outras áreas, é chamado de:";
                    button1.Text = "A) Latência de banda";
                    button2.Text = "B) Largura de banda";
                    button3.Text = "C) Intensidade de banda";
                    button4.Text = "D) Dimensão de banda";
                    correctAnswer = 2;
                    break;
                case 22:
                    lblQuestion.Text = "Considerando a estrutura de um código java, os arquivos class são colocados em um outro tipo de arquivo. Assinale a alternativa que apresenta esse segundo tipo de arquivo.";
                    button1.Text = "A) Arquivo source";
                    button2.Text = "B) Arquivo methods";
                    button3.Text = "C) Arquivo main";
                    button4.Text = "D) Arquivo sub";
                    correctAnswer = 1;
                    break;
                case 23:
                    lblQuestion.Text = "A ferramenta cuja função é de, propositalmente, simular falhas de segurança a fim de colher informações sobre o invasor é chamada de:";
                    button1.Text = "A) Data Execution Prevention";
                    button2.Text = "B) Crimeware";
                    button3.Text = "C) Netsentron";
                    button4.Text = "D) Honeypot";
                    correctAnswer = 4;
                    break;
                case 24:
                    lblQuestion.Text = "Para o usuário, em um banco de dados pouco deve importar qual unidade de armazenamento está sendo usada, contanto que estes estejam disponíveis no momento necessário. Para isso, dá-se o nome 'abstração de dados'. Isso se dá em três níveis. Diante do exposto, assinale a alternativa que apresenta um nível INVÁLIDO:";
                    button1.Text = "A) Nível de visão do usuário: as partes do banco de dados que o usuário tem acesso de acordo com a necessidade individual de cada usuário ou grupo de usuários";
                    button2.Text = "B) Nível conceitual: define quais os dados que estão armazenados e qual o relacionamento entre eles";
                    button3.Text = "C) Nível físico: é o nível mais baixo de abstração, em que define efetivamente de que maneira os dados estão armazenados";
                    button4.Text = "D) Nível de conversão: realiza a conversão das requisições do usuário em dados relevantes para a estrutura do banco, normalmente através de ferramentas de modelagem";
                    correctAnswer = 4;
                    break;
                case 25:
                    lblQuestion.Text = "No ciclo de vida do desenvolvimento de software, a fase em que o produto e o ambiente são projetados de acordo com a especificação, ajudando a determinar o hardware e a arquitetura do sistema, é chamada de:";
                    button1.Text = "A) Implementação";
                    button2.Text = "B) Modelagem";
                    button3.Text = "C) Publicação";
                    button4.Text = "D) Levantamento de requisitos e análise";
                    correctAnswer = 2;
                    break;
            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
