using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConcurso.Entities
{
    internal class SystemsQuestions
    {
        public int CorrectAnswer { get; set; }
        public int QuestionNumber { get; set; }
        public int Corrects { get; set; }
        public string QuestionText { get; set; }
        public string AnswerAText { get; set; }
        public string AnswerBText { get; set; }
        public string AnswerCText { get; set; }
        public string AnswerDText { get; set; }

        public SystemsQuestions(int correctAnswer, int questionNumber, string questionText, 
            string answerAText, string answerBText, string answerCText, string answerDText)
        {
            CorrectAnswer = correctAnswer;
            QuestionNumber = questionNumber;
            QuestionText = questionText;
            AnswerAText = answerAText;
            AnswerBText = answerBText;
            AnswerCText = answerCText;
            AnswerDText = answerDText;
        }

        public void Question(int questionNumber)
        {
            QuestionNumber = questionNumber;
            switch (questionNumber)
            {
                case 0:
                    QuestionText = "“Uma declaração do método final nunca pode mudar, assim todas as " +
                        "subclasses utilizam a mesma implementação do método; e chamadas métodos final são " +
                        "resolvidas em tempo de compilação – isso é conhecido como _________________.” " +
                        "Acerca da linguagem Java, assinale a alternativa que completa corretamente a " +
                        "afirmativa:";
                    AnswerAText = "A) subclasse";
                    AnswerBText = "B) superclasse ";
                    AnswerCText = "C) vinculação estática";
                    AnswerDText = "D) interface de marcação";
                    CorrectAnswer = 3;
                    break;
                case 1:
                    QuestionText = "Sobre a linguagem Java, analise as afirmativas a seguir." + Environment.NewLine +
                        "I.As instruções de um switch geralmente terminam com uma instrução break que termina a " +
                        "execução em um while, por exemplo. " + Environment.NewLine +
                        "II.A instrução break, quando executada em um while, " +
                        "for, do…while ou switch, ocasiona a saída imediata dessa instrução. " + Environment.NewLine +
                        "III.Os operadores & e | funcionam de forma idêntica aos operadores && e ||, mas sempre avaliam ambos os " +
                        "operandos." + Environment.NewLine + "IV.Cada valor que se deseja testar em um scanner deve ser " +
                        "listado em um rótulo case separado." + Environment.NewLine + "Está(ão) correta(s)apenas a(s) afirmativa(s)";
                    AnswerAText = "A) II";
                    AnswerBText = "B) III";
                    AnswerCText = "C) I e IV";
                    AnswerDText = "D) II e III";
                    CorrectAnswer = 4;
                    break;
                case 2:
                    QuestionText = "O PHP possui diversas funções que são utilizadas para manipulação de imagens. Uma dessas " +
                        "funções define o modo de transparência de uma imagem. Assinale a alternativa correta que apresenta essa função.";
                    AnswerAText = "A) gd_info";
                    AnswerBText = "B) getimagesize";
                    AnswerCText = "C) imagealphablending";
                    AnswerDText = "D) imagecolorallocatealpha";
                    CorrectAnswer = 3;
                    break;
                case 3:
                    QuestionText = "“Sobre comandos do PHP para diretórios, esta função obtém o diretório corrente de trabalho.”" +
                        " Trata-se da função:";
                    AnswerAText = "A) dir";
                    AnswerBText = "B) readdir";
                    AnswerCText = "C) getcwd";
                    AnswerDText = "D) opendir";
                    CorrectAnswer = 3;
                    break;
                case 4:
                    QuestionText = "“Acerca dos comandos em PHP, sobre arrays, uma das funções retorna um array com chaves e valores trocados.”" +
                        " Essa função denomina-se:";
                    AnswerAText = "A) array_fill";
                    AnswerBText = "B) array-flip";
                    AnswerCText = "C) array_keys";
                    AnswerDText = "D) array_merge";
                    CorrectAnswer = 2;
                    break;
                case 5:
                    QuestionText = "Acerca das métricas de confiabilidade, “a confiabilidade pode ser especificada como a probabilidade de uma " +
                        "falha de sistema ocorrer quando um sistema estiver em uso dentro de um ambiente operacional especificado”. Existem duas " +
                        "métricas importantes para especificar a confiabilidade e uma adicional para especificar os atributos de disponibilidade, " +
                        "que estão relacionadas ao sistema.São essas métricas, EXCETO: ";
                    AnswerAText = "A) Disponibilidade";
                    AnswerBText = "B) Taxa de ocorrência de falhas";
                    AnswerCText = "C) Probabilidade de falha sob demanda";
                    AnswerDText = "D) Número de transações entre as falhas";
                    CorrectAnswer = 4;
                    break;
                case 6:
                    QuestionText = "Garantir a qualidade de um software engloba diversos fatores, bem como muitas atividades, " +
                        "concentradas na gestãoda qualidade do software, em que várias ações são apresentadas. “Uma dessas ações é uma função de " +
                        "controle dequalidade, mas que tem como objetivo principal descobrir erros”. Assinale a alternativa que apresenta essa ação.";
                    AnswerAText = "A) Testes";
                    AnswerBText = "B) Padrões";
                    AnswerCText = "C) Proteção";
                    AnswerDText = "D) Administração de segurança";
                    CorrectAnswer = 1;
                    break;
                case 7:
                    QuestionText = "Desenvolver software com qualidade e eficiência demanda muito trabalho e muitos fatores devem ser levados em  conta nessa tarefa. As funcionalidades do software devem ser medidas sob o ponto de vista do usuário. Com relação à qualidade do código, o atributo compreensibilidade refere-se a duas métricas. Assinale a alternativa referente a uma dessas métricas.";
                    AnswerAText = "A) Índice de regularidade";
                    AnswerBText = "B) Número de padrões usados";
                    AnswerCText = "C) Convenções de atribuição variáveis";
                    AnswerDText = "D) Complexidade do projeto procedural";
                    CorrectAnswer = 3;
                    break;
                case 8:
                    QuestionText = "O HTMLS 5 introduziu vários atributos novos para formulários, tipos de entrada e outros elementos. No caso de formulários, esse atributo especifica uma expressão regular de JavaScript para o valor do campo que possa ser verificada, bem como facilita implementar uma validação específica para códigos de produto, números de cobrança, e assim por diante. Assinale a alternativa que apresenta esse atributo.";
                    AnswerAText = "A) pattern";
                    AnswerBText = "B) required";
                    AnswerCText = "C) autofocus";
                    AnswerDText = "D) placeholder";
                    CorrectAnswer = 1;
                    break;
                case 9:
                    QuestionText = "Em Modelagem de Dados, um tipo de atributo, que não pertence propriamente ao objeto (entidade ou relacionamento) onde está alocado, mas fez algum tipo de citação ou ligação desse objeto com outro, recebe um nome. Assinale a alternativa referente a esse atributo.";
                    AnswerAText = "A) Atributo chave";
                    AnswerBText = "B) Atributo referencial";
                    AnswerCText = "C) Atributo descritivo derivado";
                    AnswerDText = "D) Atributo descritivo composto";
                    CorrectAnswer = 2;
                    break;
                case 10:
                    QuestionText = "“O processo __________________ pode envolver a escolha de estratégias alternativas, a execução de um plano de contingência ou alternativo, a adoção de ações corretivas e a modificação do plano de gerenciamento do projeto.” Acerca dos processos das áreas do conhecimento em Gestão de Projetos, de acordo com o guia PMBOK 5, assinale a alternativa que completa corretamente a afirmativa anterior.";
                    AnswerAText = "A) Controlar os riscos";
                    AnswerBText = "B) Controlar os custos";
                    AnswerCText = "C) Controlar as aquisições";
                    AnswerDText = "D) Controlar as comunicações";
                    CorrectAnswer = 1;
                    break;
                case 11:
                    QuestionText = "De acordo com o PMBOK 5, o Gerenciamento das Aquisições do Projeto “inclui os processos necessários para comprar ou adquirir produtos, serviços ou resultados externos à equipe do projeto”. Um dos processos do gerenciamento das aquisições do projeto é controlar as aquisições. Segundo o PMBOK, os processos das áreas de conhecimento em Gestão de Projetos possuem Entradas, Ferramentas e Técnicas e Saídas. Assinale a alternativa que apresenta uma das ferramentas e técnicas do processo controlar as aquisições.";
                    AnswerAText = "A) Solicitações de mudança";
                    AnswerBText = "B) Sistema de gerenciamento de registros";
                    AnswerCText = "C) Atualizações nos documentos do projeto";
                    AnswerDText = "D) Atualizações no plano de gerenciamento de projeto";
                    CorrectAnswer = 2;
                    break;
                case 12:
                    QuestionText = "A etapa de Mineração de Dados compreende a busca efetiva por conhecimentos úteis no contexto da aplicação de KDD (Knowledge Discovery in Database), ou Descoberta do Conhecimento em Bases de Dados. É a principal etapa do processo de KDD.” Acerca de algumas das tarefas do KDD, analise a assertiva a seguir: “compreende a busca por uma função que mapeie os registros de um banco de dados em um intervalo de valores reais”. Assinale a alternativa que apresenta esta tarefa.";
                    AnswerAText = "A) Regressão";
                    AnswerBText = "B) Classificação";
                    AnswerCText = "C) Sumarização";
                    AnswerDText = "D) Agrupamento";
                    CorrectAnswer = 2;
                    break;
                case 13:
                    QuestionText = "Acerca dos métodos tradicionais de Mineração de Dados, um desses métodos “produz Árvores de Decisão a partir de uma abordagem recursiva de particionamento de um conjunto de dados, e utiliza conceitos e medidas da Teoria da Informação”. Trata-se do método:";
                    AnswerAText = "A) C4.5";
                    AnswerBText = "B) Apriori";
                    AnswerCText = "C) Máquinas de Vetores Suporte";
                    AnswerDText = "D) Classificador Bayesiano Ingênuo";
                    CorrectAnswer = 1;
                    break;
                case 14:
                    QuestionText = "Acerca dos cabeçalhos em HTML5, um desses novos elementos é “usado para informação adicional sobre o conteúdo, tais como quem o escreveu, links para documentos relacionados, dados de copyright, um link para o topo da página, etc., e normalmente aparece no fim do conteúdo”. Esse elemento denomina-se";
                    AnswerAText = "A) <footer>";
                    AnswerBText = "B) <header>";
                    AnswerCText = "C) <hgroup>";
                    AnswerDText = "D) <filedset>";
                    CorrectAnswer = 1;
                    break;
                case 15:
                    QuestionText = "Os computadore digitais convencionais baseiam-se no modelo idealizado por John Von Neumann, que prevê cinco componentes principais. Diante disso, assinale a alternativa que apresenta um componente INVÁLIDO.";
                    AnswerAText = "A) Unidade de memória";
                    AnswerBText = "B) Unidade de controle";
                    AnswerCText = "C) Unidade de conversão";
                    AnswerDText = "D) Unidade lógica e aritmética";
                    CorrectAnswer = 3;
                    break;
                case 16:
                    QuestionText = "Nos processadores atuais, são implementadas unidades de cálculo de números reais. Essas unidades são mais complexas que unidades de lógica e aritmética e trabalham com operadores maiores, com tamanhos típicos variando entre 64 e 128 bits. Sendo assim, assinale a alternativa que apresenta o nome dessa unidade.";
                    AnswerAText = "A) Unidade de controle de cálculo";
                    AnswerBText = "B) Unidade de ponto flutuante";
                    AnswerCText = "C) Unidade de cálculo real";
                    AnswerDText = "D) Unidade lógica centralizada";
                    CorrectAnswer = 2;
                    break;
                case 17:
                    QuestionText = "Assinale a alternativa que apresenta a definição correta de memória estática.";
                    AnswerAText = "A) Os dados são gravados de modo semipermanente em pequenos cartões ou faixas revestidos com filme magnético.";
                    AnswerBText = "B) Os dados contidos nela podem ser acessados a partir de qualquer endereço.";
                    AnswerCText = "C) Pode ser gravada ou regravada por meio de um equipamento que fornece voltagens adequadas para cada pino.";
                    AnswerDText = "D) Não precisa ser analisada ou recarregada a cada momento. É fabricada com circuitos latch.";
                    CorrectAnswer = 4;
                    break;
                case 18:
                    QuestionText = "Considerando os tipos de arquiteturas de sistemas operacionais, assinale a alternativa que apresenta aquele em que todos os componentes do núcleo operam em modo núcleo e se inter-relacionam conforme suas necessidades, sem restrições de acesso entre si, pois o código no nível núcleo tem acesso pleno a todos os recursos e áreas de memória.";
                    AnswerAText = "A) Sistemas em camadas";
                    AnswerBText = "B) Sistemas monolíticos";
                    AnswerCText = "C) Sistemas micronúcleos";
                    AnswerDText = "D) Sistemas lineares";
                    CorrectAnswer = 2;
                    break;
                case 19:
                    QuestionText = "As redes cuja arquitetura é dedicada ao armazenamento de dados são conhecidas como:";
                    AnswerAText = "A) PAN";
                    AnswerBText = "B) WAN";
                    AnswerCText = "C) MAN";
                    AnswerDText = "D) SAN";
                    CorrectAnswer = 4;
                    break;
                case 20:
                    QuestionText = "O termo que determina a capacidade de transmissão, em especial da conexão de rede, além de ser usada em processamento de sinais, eletrônica e mesmo em outras áreas, é chamado de:";
                    AnswerAText = "A) Latência de banda";
                    AnswerBText = "B) Largura de banda";
                    AnswerCText = "C) Intensidade de banda";
                    AnswerDText = "D) Dimensão de banda";
                    CorrectAnswer = 2;
                    break;
                case 21:
                    QuestionText = "Considerando a estrutura de um código java, os arquivos class são colocados em um outro tipo de arquivo. Assinale a alternativa que apresenta esse segundo tipo de arquivo.";
                    AnswerAText = "A) Arquivo source";
                    AnswerBText = "B) Arquivo methods";
                    AnswerCText = "C) Arquivo main";
                    AnswerDText = "D) Arquivo sub";
                    CorrectAnswer = 1;
                    break;
                case 22:
                    QuestionText = "A ferramenta cuja função é de, propositalmente, simular falhas de segurança a fim de colher informações sobre o invasor é chamada de:";
                    AnswerAText = "A) Data Execution Prevention";
                    AnswerBText = "B) Crimeware";
                    AnswerCText = "C) Netsentron";
                    AnswerDText = "D) Honeypot";
                    CorrectAnswer = 4;
                    break;
                case 23:
                    QuestionText = "Para o usuário, em um banco de dados pouco deve importar qual unidade de armazenamento está sendo usada, contanto que estes estejam disponíveis no momento necessário. Para isso, dá-se o nome 'abstração de dados'. Isso se dá em três níveis. Diante do exposto, assinale a alternativa que apresenta um nível INVÁLIDO:";
                    AnswerAText = "A) Nível de visão do usuário: as partes do banco de dados que o usuário tem acesso de acordo com a necessidade individual de cada usuário ou grupo de usuários";
                    AnswerBText = "B) Nível conceitual: define quais os dados que estão armazenados e qual o relacionamento entre eles";
                    AnswerCText = "C) Nível físico: é o nível mais baixo de abstração, em que define efetivamente de que maneira os dados estão armazenados";
                    AnswerDText = "D) Nível de conversão: realiza a conversão das requisições do usuário em dados relevantes para a estrutura do banco, normalmente através de ferramentas de modelagem";
                    CorrectAnswer = 4;
                    break;
                case 24:
                    QuestionText = "No ciclo de vida do desenvolvimento de software, a fase em que o produto e o ambiente são projetados de acordo com a especificação, ajudando a determinar o hardware e a arquitetura do sistema, é chamada de:";
                    AnswerAText = "A) Implementação";
                    AnswerBText = "B) Modelagem";
                    AnswerCText = "C) Publicação";
                    AnswerDText = "D) Levantamento de requisitos e análise";
                    CorrectAnswer = 2;
                    break;
            }
        }
    }
}