
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml;

namespace LV12Editor
{


    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();

            comboBoxPort.Items.AddRange(ports);

            // Carrega o valor inteiro salvo nas configurações locais
            int indexSalvo = Properties.Settings.Default.Linguagem;

            // Verifica se o índice é válido para os itens no ComboBox
            if (indexSalvo >= 0 && indexSalvo < Linguage_Box.Items.Count)
            {
                // Se o índice é válido, define o SelectedIndex do ComboBox
                Linguage_Box.SelectedIndex = indexSalvo;
            }
            CarregarComandos();
        }


        #region functions avulsas
        private void AdicionarItemAoListView(string comando)
        {
            var item = new ListViewItem(comando);
            listViewComandos.Items.Add(item);
        }
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show($"{mensagem}",
                             "Erro", // Título da janela 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        private void SalvarComandos()
        {
            var comandos = new List<string>();

            // Itera por cada item no ListView
            foreach (ListViewItem item in listViewComandos.Items)
            {
                // Adiciona o texto do item (primeira coluna) à lista de comandos
                comandos.Add(item.Text);
            }

            // Converte a lista em uma string delimitada por ";"
            string comandosDelimitados = string.Join(";", comandos);
            Properties.Settings.Default.Codigos = comandosDelimitados;
            Properties.Settings.Default.Save();

            // Salva a string delimitada nas configurações do aplicativo

            Properties.Settings.Default.Save();
        }


        private void CarregarComandos()
        {
            // Lê a string delimitada das configurações do aplicativo
            string comandosDelimitados = Properties.Settings.Default.Codigos;

            // Verifica se a string não está vazia
            if (!string.IsNullOrEmpty(comandosDelimitados))
            {
                // Divide a string delimitada para obter os comandos
                string[] comandos = comandosDelimitados.Split(';');

                // Limpa o ListView antes de adicionar os itens carregados
                listViewComandos.Items.Clear();

                // Adiciona cada comando de volta ao ListView
                foreach (string comando in comandos)
                {
                    listViewComandos.Items.Add(new ListViewItem(comando));
                }
            }
        }

        private void LerDevice(string portName, string command)  // envia o comando de ler o dispositivo e salva em string a leitura
        {
            using (SerialPort port = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One))
            {
                try
                {
                    port.Open();
                    ProgressBar.Visible = true;
                    ProgressBar.Value = 25;
                    port.Write(command);
                    port.ReadTimeout = 5000;
                    Thread.Sleep(2000);
                    ProgressBar.Value = 45;
                    string response = port.ReadLine();
                    List<string> configuracaoAtual = new List<string>(response.Split(';'));
                    ProgressBar.Value = 60;
                    for (int i = 0; i < configuracaoAtual.Count; i++)
                    {
                        ProgressBar.Value = i;
                        Console.WriteLine($"[{i}] {configuracaoAtual[i]}");
                    }
                    ProgressBar.Value = 70;
                    if (configuracaoAtual.Count > 1)
                    {
                        this.Invoke(new Action(() => Server_Input.Text = $"{configuracaoAtual[13]}"));
                        this.Invoke(new Action(() => Port_Input.Text = $"{configuracaoAtual[14]}"));
                        this.Invoke(new Action(() => APN_Input.Text = $"{configuracaoAtual[10]}"));
                        this.Invoke(new Action(() => User_Input.Text = $"{configuracaoAtual[11]}"));
                        this.Invoke(new Action(() => Pass_Input.Text = $"{configuracaoAtual[12]}"));
                        ProgressBar.Value = 99;
                        ProgressBar.Visible = false;
                    }
                    else
                    {
                        MensagemErro("Nenhuma configuração Recebida.");
                        ProgressBar.Value = 0;
                        ProgressBar.Visible = false;
                    }

                }
                catch (TimeoutException)
                {
                    MessageBox.Show("A resposta do dispositivo excedeu o tempo limite.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao comunicar com o dispositivo: {ex.Message}");
                }
                finally
                {
                    if (port.IsOpen)
                        port.Close();
                }
            }
        }


        #endregion

        #region funcoes de comportamento
        private void ButtonReadAPN_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        #endregion

        private void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPort.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma porta COM.");
                return;
            }


            string portName = comboBoxPort.SelectedItem.ToString();
            LerDevice(portName, $"ST300CMD;511050564;02;Preset"); // Substitua "PRESET" pelo comando correto se necessário
        }




        bool Expandido = false;
        private void Expandir_MouseLeave(object sender, EventArgs e)
        {
            Expandir.Location = new Point(Expandir.Location.X + 3, Expandir.Location.Y + 5);
            Expandir.Size = new Size(45, 30);
        }
        private void Expandir_MouseHover(object sender, EventArgs e)
        {
            Expandir.Size = new Size(50, 35);
            Expandir.Location = new Point(Expandir.Location.X - 3, Expandir.Location.Y - 5);
        }

        public void Expandir_Click(object sender, EventArgs e)
        {

            if (Expandido == false)
            {
                this.Size = new Size(775, 570);
                Expandir.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                Expandido = true;
            }
            else
            {
                this.Size = new Size(775, 455);
                Expandido = false;
                Expandir.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SaveConfig_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "LV files (*.lv)|*.lv|All files (*.*)|*.*",
                DefaultExt = "lv",
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode rootNode = xmlDoc.CreateElement("config");
                xmlDoc.AppendChild(rootNode);

                XmlNode connectNode = xmlDoc.CreateElement("connect");
                rootNode.AppendChild(connectNode);

                XmlNode serverNode = xmlDoc.CreateElement("server");
                serverNode.InnerText = Server_Input.Text;
                connectNode.AppendChild(serverNode);

                XmlNode portNode = xmlDoc.CreateElement("port");
                portNode.InnerText = Port_Input.Text;
                connectNode.AppendChild(portNode);

                XmlNode simCardNode = xmlDoc.CreateElement("SIMCard");
                rootNode.AppendChild(simCardNode);

                XmlNode apnNode = xmlDoc.CreateElement("apn");
                apnNode.InnerText = APN_Input.Text;
                simCardNode.AppendChild(apnNode);

                XmlNode userNode = xmlDoc.CreateElement("user");
                userNode.InnerText = User_Input.Text;
                simCardNode.AppendChild(userNode);

                XmlNode passNode = xmlDoc.CreateElement("pass");
                passNode.InnerText = Pass_Input.Text;
                simCardNode.AppendChild(passNode);

                xmlDoc.Save(saveFileDialog.FileName);
                MessageBox.Show("Arquivo salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void OpenConfig_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "LV files (*.lv)|*.lv|All files (*.*)|*.*",
                DefaultExt = "lv",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(openFileDialog.FileName);

                Server_Input.Text = xmlDoc.SelectSingleNode("/config/connect/server")?.InnerText ?? "";
                Port_Input.Text = xmlDoc.SelectSingleNode("/config/connect/port")?.InnerText ?? "";
                APN_Input.Text = xmlDoc.SelectSingleNode("/config/SIMCard/apn")?.InnerText ?? "";
                User_Input.Text = xmlDoc.SelectSingleNode("/config/SIMCard/user")?.InnerText ?? "";
                Pass_Input.Text = xmlDoc.SelectSingleNode("/config/SIMCard/pass")?.InnerText ?? "";

                MessageBox.Show("Dados importados com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddCommando_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxComando.Text))
            {
                AdicionarItemAoListView(textBoxComando.Text);
                textBoxComando.Clear(); // Limpa o TextBox após adicionar
                SalvarComandos();
            }

        }

        private void Formulario_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void listViewComandos_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla Delete foi pressionada e se o ListView tem o foco
            if (e.KeyCode == Keys.Delete && listViewComandos.Focused)
            {
                // Cria uma cópia da coleção de itens selecionados para evitar modificação durante a iteração
                List<ListViewItem> itensSelecionados = new List<ListViewItem>();
                foreach (ListViewItem item in listViewComandos.SelectedItems)
                {
                    itensSelecionados.Add(item);
                }

                // Remove os itens selecionados
                foreach (ListViewItem item in itensSelecionados)
                {
                    listViewComandos.Items.Remove(item);
                }

                // Opcional: Atualiza os comandos salvos após a remoção
                SalvarComandos();
            }
        }
    }
}
