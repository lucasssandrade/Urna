using System.ComponentModel.DataAnnotations;
using System.Media;
using static Projeto_3.Votação;

namespace Projeto_3
{
    public partial class Votação : Form
    {
        private Dictionary<string, Candidatos> _dicCandidato;
        private Dictionary<string, int> _resultados;

        public Votação()
        {
            InitializeComponent();
            _dicCandidato = new Dictionary<string, Candidatos>();
            _resultados = new Dictionary<string, int>();
            _todosVotos = new List<string>();
            _dicCandidato.Add("12", new Candidatos() { Id = 12, Nome = "Biroliro", Foto = Properties.Resources.biroliro });
            _dicCandidato.Add("13", new Candidatos() { Id = 13, Nome = "Polvo", Foto = Properties.Resources.Lula_meme });
            _dicCandidato.Add("14", new Candidatos() { Id = 14, Nome = "Lulonaro", Foto = Properties.Resources.lulonaro });
            _dicCandidato.Add("15", new Candidatos() { Id = 15, Nome = "Nós", Foto = Properties.Resources.sosia });
            _dicCandidato.Add("00", new Candidatos() { Id = 00, Nome = "Nulo", Foto = Properties.Resources.Imagem_principal });
        }

        //Define os dados de Candidatos
        public class Candidatos
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public Image Foto { get; set; }

        }

        private List<string> _todosVotos;

        private void button1_Click(object sender, EventArgs e)
        {
            Registro("1");
        }

        private void Beijo_Click(object sender, EventArgs e)
        {
            Registro("2");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registro("3");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Registro("4");
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Registro("0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
            lblCand.Text = String.Empty;
            pictureBox1.Image = Properties.Resources.Imagem_principal;
            escolha.Text = string.Empty;
        }



        private void btn5_Click(object sender, EventArgs e)
        {
            Registro("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Registro("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Registro("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Registro("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Registro("9");
        }





        //Registra na label o número clickado
        private void Registro(string digito)
        {
            if (lbl.TextLength < 2)
            {
                lbl.Text += digito;

                if (lbl.TextLength == 2)
                {
                    PreencherCandidato(lbl.Text);
                }
            }
            else
            {
                MessageBox.Show("Apenas dois dígitos são permitidos. Aguarde o próximo voto.");
            }


        }




        //Mostra ou não o candidato compativel com o código enviado 
        private void PreencherCandidato(string d1)
        {
            if (_dicCandidato.ContainsKey(d1))
            {
                escolha.Text = _dicCandidato[d1].Nome;
                pictureBox1.Image = _dicCandidato[d1].Foto;
            }
            else
            {
                MessageBox.Show("Candidato não encontrado");
            }
        }




        //Função para limpar dados
        private void Limpar()
        {

            lbl.Text = "";
            pictureBox1.Image = Properties.Resources.Imagem_principal;
            escolha.Text = string.Empty;


        }





        //Mostra totais de votos.
        private void ExibirResultados()
        {
            if (_dicCandidato != null)
            {
                int totalVotos = _resultados.Values.Sum();
                string mensagem = $"Total: {totalVotos} votos\n\n";

                foreach (var resultado in _resultados)
                {
                    string nomeCandidato = _dicCandidato.ContainsKey(resultado.Key) ? _dicCandidato[resultado.Key].Nome : "Candidato não encontrado";
                    mensagem += $"Candidato: {nomeCandidato}, Votos: {resultado.Value}\n";
                }

                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Erro: Dicionário de candidatos não inicializado corretamente.");
            }
        }


        // Função para exibir Ganhador.
        private void ExibirGanhador()
        {
            if (_resultados.Count == 0)
            {
                MessageBox.Show("Nenhum voto registrado ainda.");
                return;
            }

            // Encontrar o primeiro e o segundo colocados (Isso é para o caso de "NULO")
            var ganhador = _resultados.OrderByDescending(x => x.Value).FirstOrDefault();

            if (ganhador.Value > 0)
            {
                var segundoColocado = _resultados.Where(x => x.Key != ganhador.Key).OrderByDescending(x => x.Value).FirstOrDefault();
                string nomeGanhador = _dicCandidato.ContainsKey(ganhador.Key) ? _dicCandidato[ganhador.Key].Nome : "Candidato não encontrado (Nulo)";

                if (segundoColocado.Key != null && ganhador.Value == segundoColocado.Value)
                {
                    // Empate detectado
                    string nomeSegundoColocado = _dicCandidato.ContainsKey(segundoColocado.Key) ? _dicCandidato[segundoColocado.Key].Nome : "Candidato não encontrado (Nulo)";

                    MessageBox.Show($"Empate detectado entre {nomeGanhador} e {nomeSegundoColocado}. Cada candidato receberá mais um voto!");

                    IniciarSegundaVotacao();
                }
                else
                {
                    // Não há empate, mostra o ganhador
                    string nomeVencedor = _dicCandidato.ContainsKey(ganhador.Key) ? _dicCandidato[ganhador.Key].Nome : "Candidato não encontrado (Nulo)";
                    Image imagemVencedor = _dicCandidato.ContainsKey(ganhador.Key) ? _dicCandidato[ganhador.Key].Foto : null;
                    // Exibir resultados com contagem total de votos
                    int totalVotos = _resultados.Values.Sum();
                    MessageBox.Show($"O ganhador é: {nomeVencedor} com {ganhador.Value} votos. Total de votos: {totalVotos}.");
                    if (imagemVencedor != null)
                    {
                        MostrarImagemVencedor(imagemVencedor);
                    }
                }
            }
            else
            {
                // Caso específico de empate em zero votos ou nenhum voto, não declarar ganhador
                MessageBox.Show("Empate detectado ou nenhum voto registrado. Cada candidato receberá mais um voto!");
                IniciarSegundaVotacao();
            }

            // Exibir resultados apenas se houver um ganhador ou um empate detectado
            ExibirResultados();

        }

        private void MostrarImagemVencedor(Image imagem)
        {
            Form formularioImagem = new Form();
            PictureBox pictureBox = new PictureBox();

            pictureBox.Image = imagem;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            formularioImagem.Controls.Add(pictureBox);
            formularioImagem.AutoSize = true;

            formularioImagem.ShowDialog();
        }



        //Reinicia votação em caso de empate "2º Turno"

        private void IniciarSegundaVotacao()
        {
            // Mostra mensagem de empate e inicia segunda votação
            MessageBox.Show("Empate detectado. Iniciando segunda votação!");

            // Limpar dados para a segunda votação, se necessário
            Limpar();

        }





        //Zera dados
        private void btnAnu_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
        }





        //Só é permitido apertar no botão confirma após 2 digitos

        private void lbl_TextChanged(object sender, EventArgs e)
        {
            // Verifica se dois números foram digitados
            btnCon.Enabled = lbl.TextLength == 2;
        }

        //Confirma voto e impede que seja registrado votos que não sejam valores definidos (Estão no dicionario nas primeiras linhas)
        private void btnCon_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl.Text))
            {
                MessageBox.Show("Favor informar o candidato.");
                return;
            }

            // Verificar se o candidato está no dicionário
            string candidatoSelecionado = lbl.Text;
            if (!_dicCandidato.ContainsKey(candidatoSelecionado))
            {
                MessageBox.Show("Candidato não encontrado. Voto não registrado.");
                Limpar();
                return;
            }

            MessageBox.Show("Voto registrado");

            // Registrar o voto nos resultados
            if (_resultados.ContainsKey(candidatoSelecionado))
            {
                _resultados[candidatoSelecionado]++;
            }
            else
            {
                _resultados.Add(candidatoSelecionado, 1);
            }

            Limpar();

            // Desabilita o botão de confirmação após o voto
            btnCon.Enabled = false;
        }


        //Botão de Resultados, mostra o ganhador ou o empate
        private void btnRes_Click_1(object sender, EventArgs e)
        {
            ExibirGanhador();
        }
    }
}
