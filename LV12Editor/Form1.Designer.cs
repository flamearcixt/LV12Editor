namespace LV12Editor
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.buttonReadAPN = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.SelectComText = new System.Windows.Forms.Label();
            this.Gmt_Text = new System.Windows.Forms.Label();
            this.Server_Input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Servidor_Text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Port_Input = new System.Windows.Forms.NumericUpDown();
            this.GMT_Box = new System.Windows.Forms.ComboBox();
            this.ServerConfig_Text = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.APN_Input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pass_Input = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.User_Input = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Linguage_Box = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Angle_Input = new System.Windows.Forms.NumericUpDown();
            this.OnMovingNet_Input = new System.Windows.Forms.NumericUpDown();
            this.OnStopNet_Input = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Parado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Expandir = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.listViewComandos = new System.Windows.Forms.ListView();
            this.comandos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddCommando_Button = new System.Windows.Forms.Button();
            this.textBoxComando = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port_Input)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Angle_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnMovingNet_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnStopNet_Input)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReadAPN
            // 
            this.buttonReadAPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonReadAPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReadAPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadAPN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadAPN.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.buttonReadAPN.Location = new System.Drawing.Point(12, 75);
            this.buttonReadAPN.Name = "buttonReadAPN";
            this.buttonReadAPN.Size = new System.Drawing.Size(75, 33);
            this.buttonReadAPN.TabIndex = 4;
            this.buttonReadAPN.Text = "Abrir";
            this.buttonReadAPN.UseVisualStyleBackColor = false;
            this.buttonReadAPN.Click += new System.EventHandler(this.ButtonReadAPN_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(9, 48);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(156, 21);
            this.comboBoxPort.TabIndex = 5;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // SelectComText
            // 
            this.SelectComText.AutoSize = true;
            this.SelectComText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectComText.ForeColor = System.Drawing.Color.White;
            this.SelectComText.Location = new System.Drawing.Point(9, 27);
            this.SelectComText.Name = "SelectComText";
            this.SelectComText.Size = new System.Drawing.Size(94, 18);
            this.SelectComText.TabIndex = 7;
            this.SelectComText.Text = "Porta COM";
            // 
            // Gmt_Text
            // 
            this.Gmt_Text.AutoSize = true;
            this.Gmt_Text.Location = new System.Drawing.Point(3, 95);
            this.Gmt_Text.Name = "Gmt_Text";
            this.Gmt_Text.Size = new System.Drawing.Size(31, 13);
            this.Gmt_Text.TabIndex = 16;
            this.Gmt_Text.Text = "GMT";
            // 
            // Server_Input
            // 
            this.Server_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Server_Input.Location = new System.Drawing.Point(53, 20);
            this.Server_Input.Name = "Server_Input";
            this.Server_Input.Size = new System.Drawing.Size(156, 20);
            this.Server_Input.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Porta";
            // 
            // Servidor_Text
            // 
            this.Servidor_Text.AutoSize = true;
            this.Servidor_Text.Location = new System.Drawing.Point(3, 25);
            this.Servidor_Text.Name = "Servidor_Text";
            this.Servidor_Text.Size = new System.Drawing.Size(46, 13);
            this.Servidor_Text.TabIndex = 24;
            this.Servidor_Text.Text = "Servidor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Port_Input);
            this.panel1.Controls.Add(this.GMT_Box);
            this.panel1.Controls.Add(this.Server_Input);
            this.panel1.Controls.Add(this.Gmt_Text);
            this.panel1.Controls.Add(this.Servidor_Text);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 125);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Port_Input
            // 
            this.Port_Input.Location = new System.Drawing.Point(53, 58);
            this.Port_Input.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Port_Input.Name = "Port_Input";
            this.Port_Input.Size = new System.Drawing.Size(156, 20);
            this.Port_Input.TabIndex = 44;
            // 
            // GMT_Box
            // 
            this.GMT_Box.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.GMT_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GMT_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GMT_Box.FormattingEnabled = true;
            this.GMT_Box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GMT_Box.Items.AddRange(new object[] {
            "Português",
            "Inglês"});
            this.GMT_Box.Location = new System.Drawing.Point(53, 92);
            this.GMT_Box.Name = "GMT_Box";
            this.GMT_Box.Size = new System.Drawing.Size(156, 21);
            this.GMT_Box.TabIndex = 41;
            // 
            // ServerConfig_Text
            // 
            this.ServerConfig_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ServerConfig_Text.AutoSize = true;
            this.ServerConfig_Text.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerConfig_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ServerConfig_Text.Location = new System.Drawing.Point(15, 163);
            this.ServerConfig_Text.Name = "ServerConfig_Text";
            this.ServerConfig_Text.Size = new System.Drawing.Size(78, 18);
            this.ServerConfig_Text.TabIndex = 35;
            this.ServerConfig_Text.Text = "Conexão";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.APN_Input);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Pass_Input);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.User_Input);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(270, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 125);
            this.panel2.TabIndex = 35;
            // 
            // APN_Input
            // 
            this.APN_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.APN_Input.Location = new System.Drawing.Point(53, 20);
            this.APN_Input.Name = "APN_Input";
            this.APN_Input.Size = new System.Drawing.Size(156, 20);
            this.APN_Input.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Senha";
            // 
            // Pass_Input
            // 
            this.Pass_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass_Input.Location = new System.Drawing.Point(53, 93);
            this.Pass_Input.Name = "Pass_Input";
            this.Pass_Input.Size = new System.Drawing.Size(156, 20);
            this.Pass_Input.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "APN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Usuario";
            // 
            // User_Input
            // 
            this.User_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_Input.Location = new System.Drawing.Point(53, 58);
            this.User_Input.Name = "User_Input";
            this.User_Input.Size = new System.Drawing.Size(156, 20);
            this.User_Input.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(24)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.ProgressBar);
            this.panel3.Controls.Add(this.Linguage_Box);
            this.panel3.Controls.Add(this.SelectComText);
            this.panel3.Controls.Add(this.buttonReadAPN);
            this.panel3.Controls.Add(this.comboBoxPort);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 133);
            this.panel3.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(177, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Porta COM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Location = new System.Drawing.Point(90, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.Green;
            this.ProgressBar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ProgressBar.Location = new System.Drawing.Point(0, 110);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(954, 23);
            this.ProgressBar.TabIndex = 11;
            this.ProgressBar.Visible = false;
            // 
            // Linguage_Box
            // 
            this.Linguage_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Linguage_Box.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Linguage_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Linguage_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Linguage_Box.FormattingEnabled = true;
            this.Linguage_Box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Linguage_Box.Items.AddRange(new object[] {
            "Português",
            "Inglês"});
            this.Linguage_Box.Location = new System.Drawing.Point(180, 48);
            this.Linguage_Box.Name = "Linguage_Box";
            this.Linguage_Box.Size = new System.Drawing.Size(156, 21);
            this.Linguage_Box.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LV12Editor.Properties.Resources.LOGO_IMPERIO_DOS_RASTREADORES;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(738, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 96);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(273, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "SIM Card";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Angle_Input);
            this.panel4.Controls.Add(this.OnMovingNet_Input);
            this.panel4.Controls.Add(this.OnStopNet_Input);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Parado);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.Location = new System.Drawing.Point(527, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 125);
            this.panel4.TabIndex = 36;
            // 
            // Angle_Input
            // 
            this.Angle_Input.Location = new System.Drawing.Point(53, 93);
            this.Angle_Input.Name = "Angle_Input";
            this.Angle_Input.Size = new System.Drawing.Size(156, 20);
            this.Angle_Input.TabIndex = 43;
            // 
            // OnMovingNet_Input
            // 
            this.OnMovingNet_Input.Location = new System.Drawing.Point(53, 58);
            this.OnMovingNet_Input.Name = "OnMovingNet_Input";
            this.OnMovingNet_Input.Size = new System.Drawing.Size(156, 20);
            this.OnMovingNet_Input.TabIndex = 42;
            // 
            // OnStopNet_Input
            // 
            this.OnStopNet_Input.Location = new System.Drawing.Point(53, 20);
            this.OnStopNet_Input.Name = "OnStopNet_Input";
            this.OnStopNet_Input.Size = new System.Drawing.Size(156, 20);
            this.OnStopNet_Input.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Angulo";
            // 
            // Parado
            // 
            this.Parado.AutoSize = true;
            this.Parado.Location = new System.Drawing.Point(3, 25);
            this.Parado.Name = "Parado";
            this.Parado.Size = new System.Drawing.Size(41, 13);
            this.Parado.TabIndex = 24;
            this.Parado.Text = "Parado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Andando";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(531, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Transmissão";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button3.Location = new System.Drawing.Point(595, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 33);
            this.button3.TabIndex = 39;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Expandir
            // 
            this.Expandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Expandir.BackColor = System.Drawing.Color.Transparent;
            this.Expandir.BackgroundImage = global::LV12Editor.Properties.Resources._5093064;
            this.Expandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Expandir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Expandir.FlatAppearance.BorderSize = 0;
            this.Expandir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Expandir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Expandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expandir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expandir.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Expandir.Location = new System.Drawing.Point(361, 408);
            this.Expandir.Name = "Expandir";
            this.Expandir.Size = new System.Drawing.Size(45, 30);
            this.Expandir.TabIndex = 11;
            this.Expandir.UseVisualStyleBackColor = false;
            this.Expandir.Click += new System.EventHandler(this.Expandir_Click);
            this.Expandir.MouseEnter += new System.EventHandler(this.Expandir_MouseHover);
            this.Expandir.MouseLeave += new System.EventHandler(this.Expandir_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel6.Location = new System.Drawing.Point(12, 391);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(224, 47);
            this.panel6.TabIndex = 45;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Location = new System.Drawing.Point(130, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 33);
            this.button2.TabIndex = 27;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.SaveConfig_Button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button4.Location = new System.Drawing.Point(6, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "Carregar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.OpenConfig_Button_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(16, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 46;
            this.label10.Text = "Perfil";
            // 
            // listViewComandos
            // 
            this.listViewComandos.BackColor = System.Drawing.Color.White;
            this.listViewComandos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewComandos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.comandos});
            this.listViewComandos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewComandos.FullRowSelect = true;
            this.listViewComandos.GridLines = true;
            this.listViewComandos.HideSelection = false;
            this.listViewComandos.Location = new System.Drawing.Point(755, 132);
            this.listViewComandos.Name = "listViewComandos";
            this.listViewComandos.Size = new System.Drawing.Size(197, 277);
            this.listViewComandos.TabIndex = 47;
            this.listViewComandos.UseCompatibleStateImageBehavior = false;
            this.listViewComandos.View = System.Windows.Forms.View.Details;
            this.listViewComandos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewComandos_KeyDown);
            // 
            // comandos
            // 
            this.comandos.Text = "";
            this.comandos.Width = 195;
            // 
            // AddCommando_Button
            // 
            this.AddCommando_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddCommando_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddCommando_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCommando_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddCommando_Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCommando_Button.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.AddCommando_Button.Location = new System.Drawing.Point(922, 415);
            this.AddCommando_Button.Name = "AddCommando_Button";
            this.AddCommando_Button.Size = new System.Drawing.Size(32, 20);
            this.AddCommando_Button.TabIndex = 48;
            this.AddCommando_Button.Text = ">";
            this.AddCommando_Button.UseVisualStyleBackColor = false;
            this.AddCommando_Button.Click += new System.EventHandler(this.AddCommando_Button_Click);
            // 
            // textBoxComando
            // 
            this.textBoxComando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxComando.Location = new System.Drawing.Point(757, 415);
            this.textBoxComando.Name = "textBoxComando";
            this.textBoxComando.Size = new System.Drawing.Size(165, 20);
            this.textBoxComando.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(815, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 18);
            this.label11.TabIndex = 49;
            this.label11.Text = "Comandos";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxComando);
            this.Controls.Add(this.AddCommando_Button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Expandir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerConfig_Text);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listViewComandos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.Text = "Lv12 4G";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulario_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port_Input)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Angle_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnMovingNet_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnStopNet_Input)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
 
        private System.Windows.Forms.Button buttonReadAPN;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label SelectComText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Gmt_Text;
        private System.Windows.Forms.TextBox Server_Input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Servidor_Text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ServerConfig_Text;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox APN_Input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pass_Input;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox User_Input;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Parado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Expandir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Linguage_Box;
        private System.Windows.Forms.NumericUpDown Angle_Input;
        private System.Windows.Forms.NumericUpDown OnMovingNet_Input;
        private System.Windows.Forms.NumericUpDown OnStopNet_Input;
        private System.Windows.Forms.ComboBox GMT_Box;
        private System.Windows.Forms.NumericUpDown Port_Input;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddCommando_Button;
        private System.Windows.Forms.TextBox textBoxComando;
        private System.Windows.Forms.ColumnHeader comandos;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ListView listViewComandos;
    }
}

