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
            this.buttonReadPort = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.PORTUSBText = new System.Windows.Forms.Label();
            this.Gmt_Text = new System.Windows.Forms.Label();
            this.Server_Input = new System.Windows.Forms.TextBox();
            this.PORTText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServidorText = new System.Windows.Forms.Label();
            this.Port_Input = new System.Windows.Forms.NumericUpDown();
            this.GMT_Box = new System.Windows.Forms.ComboBox();
            this.CONNECTIONText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.APN_Input = new System.Windows.Forms.TextBox();
            this.PASSText = new System.Windows.Forms.Label();
            this.Pass_Input = new System.Windows.Forms.TextBox();
            this.APNText = new System.Windows.Forms.Label();
            this.USERText = new System.Windows.Forms.Label();
            this.User_Input = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LoadProfileButton = new System.Windows.Forms.Button();
            this.ENGButton = new System.Windows.Forms.Button();
            this.PTBRButton = new System.Windows.Forms.Button();
            this.SaveProfileButton = new System.Windows.Forms.Button();
            this.SaveDevice = new System.Windows.Forms.Button();
            this.PROFILEText = new System.Windows.Forms.Label();
            this.buttonClosePort = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SIMText = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Angle_Input = new System.Windows.Forms.NumericUpDown();
            this.OnMovingNet_Input = new System.Windows.Forms.NumericUpDown();
            this.OnStopNet_Input = new System.Windows.Forms.NumericUpDown();
            this.ANGLEText = new System.Windows.Forms.Label();
            this.STOPText = new System.Windows.Forms.Label();
            this.MOVINGText = new System.Windows.Forms.Label();
            this.STREAMINGText = new System.Windows.Forms.Label();
            this.listViewComandos = new System.Windows.Forms.ListView();
            this.comandos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddCommando_Button = new System.Windows.Forms.Button();
            this.textBoxComando = new System.Windows.Forms.TextBox();
            this.COMMANDSText = new System.Windows.Forms.Label();
            this.Expandir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OutPutText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port_Input)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Angle_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnMovingNet_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnStopNet_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReadPort
            // 
            this.buttonReadPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonReadPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReadPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadPort.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.buttonReadPort.ForeColor = System.Drawing.Color.White;
            this.buttonReadPort.Location = new System.Drawing.Point(12, 62);
            this.buttonReadPort.Name = "buttonReadPort";
            this.buttonReadPort.Size = new System.Drawing.Size(82, 33);
            this.buttonReadPort.TabIndex = 4;
            this.buttonReadPort.Text = "Abrir";
            this.buttonReadPort.UseVisualStyleBackColor = false;
            this.buttonReadPort.Click += new System.EventHandler(this.ButtonReadAPN_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(105, 37);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(110, 21);
            this.comboBoxPort.TabIndex = 5;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // PORTUSBText
            // 
            this.PORTUSBText.AutoSize = true;
            this.PORTUSBText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PORTUSBText.ForeColor = System.Drawing.Color.White;
            this.PORTUSBText.Location = new System.Drawing.Point(9, 36);
            this.PORTUSBText.Name = "PORTUSBText";
            this.PORTUSBText.Size = new System.Drawing.Size(95, 18);
            this.PORTUSBText.TabIndex = 7;
            this.PORTUSBText.Text = "Porta USB ";
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
            this.Server_Input.Location = new System.Drawing.Point(55, 20);
            this.Server_Input.Name = "Server_Input";
            this.Server_Input.Size = new System.Drawing.Size(188, 20);
            this.Server_Input.TabIndex = 26;
            // 
            // PORTText
            // 
            this.PORTText.AutoSize = true;
            this.PORTText.Location = new System.Drawing.Point(3, 60);
            this.PORTText.Name = "PORTText";
            this.PORTText.Size = new System.Drawing.Size(32, 13);
            this.PORTText.TabIndex = 25;
            this.PORTText.Text = "Porta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ServidorText);
            this.panel1.Controls.Add(this.Port_Input);
            this.panel1.Controls.Add(this.GMT_Box);
            this.panel1.Controls.Add(this.Server_Input);
            this.panel1.Controls.Add(this.Gmt_Text);
            this.panel1.Controls.Add(this.PORTText);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 125);
            this.panel1.TabIndex = 34;
            // 
            // ServidorText
            // 
            this.ServidorText.AutoSize = true;
            this.ServidorText.Location = new System.Drawing.Point(3, 22);
            this.ServidorText.Name = "ServidorText";
            this.ServidorText.Size = new System.Drawing.Size(46, 13);
            this.ServidorText.TabIndex = 45;
            this.ServidorText.Text = "Servidor";
            // 
            // Port_Input
            // 
            this.Port_Input.Location = new System.Drawing.Point(55, 58);
            this.Port_Input.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Port_Input.Name = "Port_Input";
            this.Port_Input.Size = new System.Drawing.Size(188, 20);
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
            this.GMT_Box.Location = new System.Drawing.Point(55, 92);
            this.GMT_Box.Name = "GMT_Box";
            this.GMT_Box.Size = new System.Drawing.Size(188, 21);
            this.GMT_Box.TabIndex = 41;
            // 
            // CONNECTIONText
            // 
            this.CONNECTIONText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CONNECTIONText.AutoSize = true;
            this.CONNECTIONText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONNECTIONText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CONNECTIONText.Location = new System.Drawing.Point(15, 163);
            this.CONNECTIONText.Name = "CONNECTIONText";
            this.CONNECTIONText.Size = new System.Drawing.Size(78, 18);
            this.CONNECTIONText.TabIndex = 35;
            this.CONNECTIONText.Text = "Conexão";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.APN_Input);
            this.panel2.Controls.Add(this.PASSText);
            this.panel2.Controls.Add(this.Pass_Input);
            this.panel2.Controls.Add(this.APNText);
            this.panel2.Controls.Add(this.USERText);
            this.panel2.Controls.Add(this.User_Input);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(270, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 125);
            this.panel2.TabIndex = 35;
            // 
            // APN_Input
            // 
            this.APN_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.APN_Input.Location = new System.Drawing.Point(58, 20);
            this.APN_Input.Name = "APN_Input";
            this.APN_Input.Size = new System.Drawing.Size(188, 20);
            this.APN_Input.TabIndex = 26;
            // 
            // PASSText
            // 
            this.PASSText.AutoSize = true;
            this.PASSText.Location = new System.Drawing.Point(3, 95);
            this.PASSText.Name = "PASSText";
            this.PASSText.Size = new System.Drawing.Size(38, 13);
            this.PASSText.TabIndex = 16;
            this.PASSText.Text = "Senha";
            // 
            // Pass_Input
            // 
            this.Pass_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass_Input.Location = new System.Drawing.Point(58, 92);
            this.Pass_Input.Name = "Pass_Input";
            this.Pass_Input.Size = new System.Drawing.Size(188, 20);
            this.Pass_Input.TabIndex = 19;
            // 
            // APNText
            // 
            this.APNText.AutoSize = true;
            this.APNText.Location = new System.Drawing.Point(3, 25);
            this.APNText.Name = "APNText";
            this.APNText.Size = new System.Drawing.Size(29, 13);
            this.APNText.TabIndex = 24;
            this.APNText.Text = "APN";
            // 
            // USERText
            // 
            this.USERText.AutoSize = true;
            this.USERText.Location = new System.Drawing.Point(3, 60);
            this.USERText.Name = "USERText";
            this.USERText.Size = new System.Drawing.Size(43, 13);
            this.USERText.TabIndex = 25;
            this.USERText.Text = "Usuario";
            // 
            // User_Input
            // 
            this.User_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_Input.Location = new System.Drawing.Point(58, 58);
            this.User_Input.Name = "User_Input";
            this.User_Input.Size = new System.Drawing.Size(188, 20);
            this.User_Input.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(24)))));
            this.panel3.Controls.Add(this.LoadProfileButton);
            this.panel3.Controls.Add(this.ENGButton);
            this.panel3.Controls.Add(this.PTBRButton);
            this.panel3.Controls.Add(this.SaveProfileButton);
            this.panel3.Controls.Add(this.SaveDevice);
            this.panel3.Controls.Add(this.PROFILEText);
            this.panel3.Controls.Add(this.buttonClosePort);
            this.panel3.Controls.Add(this.ProgressBar);
            this.panel3.Controls.Add(this.PORTUSBText);
            this.panel3.Controls.Add(this.buttonReadPort);
            this.panel3.Controls.Add(this.comboBoxPort);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 133);
            this.panel3.TabIndex = 36;
            // 
            // LoadProfileButton
            // 
            this.LoadProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LoadProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadProfileButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadProfileButton.ForeColor = System.Drawing.Color.White;
            this.LoadProfileButton.Location = new System.Drawing.Point(248, 62);
            this.LoadProfileButton.Name = "LoadProfileButton";
            this.LoadProfileButton.Size = new System.Drawing.Size(91, 33);
            this.LoadProfileButton.TabIndex = 52;
            this.LoadProfileButton.Text = "Carregar";
            this.LoadProfileButton.UseVisualStyleBackColor = false;
            // 
            // ENGButton
            // 
            this.ENGButton.BackColor = System.Drawing.Color.Transparent;
            this.ENGButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ENGButton.BackgroundImage")));
            this.ENGButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ENGButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ENGButton.FlatAppearance.BorderSize = 0;
            this.ENGButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ENGButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ENGButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ENGButton.Location = new System.Drawing.Point(51, 9);
            this.ENGButton.Margin = new System.Windows.Forms.Padding(0);
            this.ENGButton.Name = "ENGButton";
            this.ENGButton.Size = new System.Drawing.Size(32, 24);
            this.ENGButton.TabIndex = 51;
            this.ENGButton.UseVisualStyleBackColor = false;
            this.ENGButton.Click += new System.EventHandler(this.ENGButton_Click);
            // 
            // PTBRButton
            // 
            this.PTBRButton.BackColor = System.Drawing.Color.Transparent;
            this.PTBRButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PTBRButton.BackgroundImage")));
            this.PTBRButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PTBRButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PTBRButton.FlatAppearance.BorderSize = 0;
            this.PTBRButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PTBRButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PTBRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PTBRButton.Location = new System.Drawing.Point(12, 9);
            this.PTBRButton.Margin = new System.Windows.Forms.Padding(0);
            this.PTBRButton.Name = "PTBRButton";
            this.PTBRButton.Size = new System.Drawing.Size(32, 24);
            this.PTBRButton.TabIndex = 50;
            this.PTBRButton.UseVisualStyleBackColor = false;
            this.PTBRButton.Click += new System.EventHandler(this.PTBRButton_Click);
            // 
            // SaveProfileButton
            // 
            this.SaveProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SaveProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProfileButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProfileButton.ForeColor = System.Drawing.Color.White;
            this.SaveProfileButton.Location = new System.Drawing.Point(345, 62);
            this.SaveProfileButton.Name = "SaveProfileButton";
            this.SaveProfileButton.Size = new System.Drawing.Size(86, 33);
            this.SaveProfileButton.TabIndex = 27;
            this.SaveProfileButton.Text = "Salvar";
            this.SaveProfileButton.UseVisualStyleBackColor = false;
            this.SaveProfileButton.Click += new System.EventHandler(this.SaveConfig_Button_Click);
            // 
            // SaveDevice
            // 
            this.SaveDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SaveDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDevice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveDevice.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.SaveDevice.Location = new System.Drawing.Point(437, 62);
            this.SaveDevice.Name = "SaveDevice";
            this.SaveDevice.Size = new System.Drawing.Size(170, 33);
            this.SaveDevice.TabIndex = 39;
            this.SaveDevice.Text = "Salvar Dispositivo";
            this.SaveDevice.UseVisualStyleBackColor = false;
            // 
            // PROFILEText
            // 
            this.PROFILEText.AutoSize = true;
            this.PROFILEText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROFILEText.ForeColor = System.Drawing.Color.White;
            this.PROFILEText.Location = new System.Drawing.Point(245, 36);
            this.PROFILEText.Name = "PROFILEText";
            this.PROFILEText.Size = new System.Drawing.Size(49, 18);
            this.PROFILEText.TabIndex = 12;
            this.PROFILEText.Text = "Perfil";
            // 
            // buttonClosePort
            // 
            this.buttonClosePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonClosePort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClosePort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClosePort.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.buttonClosePort.ForeColor = System.Drawing.Color.White;
            this.buttonClosePort.Location = new System.Drawing.Point(100, 62);
            this.buttonClosePort.Name = "buttonClosePort";
            this.buttonClosePort.Size = new System.Drawing.Size(115, 33);
            this.buttonClosePort.TabIndex = 10;
            this.buttonClosePort.Text = "Fechar";
            this.buttonClosePort.UseVisualStyleBackColor = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(738, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 96);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SIMText
            // 
            this.SIMText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SIMText.AutoSize = true;
            this.SIMText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIMText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SIMText.Location = new System.Drawing.Point(273, 163);
            this.SIMText.Name = "SIMText";
            this.SIMText.Size = new System.Drawing.Size(44, 18);
            this.SIMText.TabIndex = 37;
            this.SIMText.Text = "Chip";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Angle_Input);
            this.panel4.Controls.Add(this.OnMovingNet_Input);
            this.panel4.Controls.Add(this.OnStopNet_Input);
            this.panel4.Controls.Add(this.ANGLEText);
            this.panel4.Controls.Add(this.STOPText);
            this.panel4.Controls.Add(this.MOVINGText);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.Location = new System.Drawing.Point(527, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 125);
            this.panel4.TabIndex = 36;
            // 
            // Angle_Input
            // 
            this.Angle_Input.Location = new System.Drawing.Point(67, 93);
            this.Angle_Input.Name = "Angle_Input";
            this.Angle_Input.Size = new System.Drawing.Size(142, 20);
            this.Angle_Input.TabIndex = 43;
            // 
            // OnMovingNet_Input
            // 
            this.OnMovingNet_Input.Location = new System.Drawing.Point(67, 58);
            this.OnMovingNet_Input.Name = "OnMovingNet_Input";
            this.OnMovingNet_Input.Size = new System.Drawing.Size(142, 20);
            this.OnMovingNet_Input.TabIndex = 42;
            // 
            // OnStopNet_Input
            // 
            this.OnStopNet_Input.Location = new System.Drawing.Point(67, 20);
            this.OnStopNet_Input.Name = "OnStopNet_Input";
            this.OnStopNet_Input.Size = new System.Drawing.Size(142, 20);
            this.OnStopNet_Input.TabIndex = 41;
            // 
            // ANGLEText
            // 
            this.ANGLEText.AutoSize = true;
            this.ANGLEText.Location = new System.Drawing.Point(3, 95);
            this.ANGLEText.Name = "ANGLEText";
            this.ANGLEText.Size = new System.Drawing.Size(40, 13);
            this.ANGLEText.TabIndex = 16;
            this.ANGLEText.Text = "Angulo";
            // 
            // STOPText
            // 
            this.STOPText.AutoSize = true;
            this.STOPText.Location = new System.Drawing.Point(3, 25);
            this.STOPText.Name = "STOPText";
            this.STOPText.Size = new System.Drawing.Size(41, 13);
            this.STOPText.TabIndex = 24;
            this.STOPText.Text = "Parado";
            // 
            // MOVINGText
            // 
            this.MOVINGText.AutoSize = true;
            this.MOVINGText.Location = new System.Drawing.Point(3, 60);
            this.MOVINGText.Name = "MOVINGText";
            this.MOVINGText.Size = new System.Drawing.Size(50, 13);
            this.MOVINGText.TabIndex = 25;
            this.MOVINGText.Text = "Andando";
            // 
            // STREAMINGText
            // 
            this.STREAMINGText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.STREAMINGText.AutoSize = true;
            this.STREAMINGText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STREAMINGText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.STREAMINGText.Location = new System.Drawing.Point(531, 163);
            this.STREAMINGText.Name = "STREAMINGText";
            this.STREAMINGText.Size = new System.Drawing.Size(110, 18);
            this.STREAMINGText.TabIndex = 38;
            this.STREAMINGText.Text = "Transmissão";
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
            this.listViewComandos.Size = new System.Drawing.Size(197, 357);
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
            this.AddCommando_Button.Location = new System.Drawing.Point(922, 498);
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
            this.textBoxComando.Location = new System.Drawing.Point(755, 498);
            this.textBoxComando.Name = "textBoxComando";
            this.textBoxComando.Size = new System.Drawing.Size(165, 20);
            this.textBoxComando.TabIndex = 28;
            // 
            // COMMANDSText
            // 
            this.COMMANDSText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.COMMANDSText.AutoSize = true;
            this.COMMANDSText.BackColor = System.Drawing.Color.Transparent;
            this.COMMANDSText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMMANDSText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.COMMANDSText.Location = new System.Drawing.Point(815, 135);
            this.COMMANDSText.Name = "COMMANDSText";
            this.COMMANDSText.Size = new System.Drawing.Size(93, 18);
            this.COMMANDSText.TabIndex = 49;
            this.COMMANDSText.Text = "Comandos";
            // 
            // Expandir
            // 
            this.Expandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Expandir.BackColor = System.Drawing.Color.Transparent;
            this.Expandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Expandir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Expandir.FlatAppearance.BorderSize = 0;
            this.Expandir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Expandir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Expandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expandir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expandir.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Expandir.Location = new System.Drawing.Point(361, 488);
            this.Expandir.Name = "Expandir";
            this.Expandir.Size = new System.Drawing.Size(45, 30);
            this.Expandir.TabIndex = 11;
            this.Expandir.UseVisualStyleBackColor = false;
            this.Expandir.Click += new System.EventHandler(this.Expandir_Click);
            this.Expandir.MouseEnter += new System.EventHandler(this.Expandir_MouseHover);
            this.Expandir.MouseLeave += new System.EventHandler(this.Expandir_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(12, 322);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(737, 167);
            this.textBox1.TabIndex = 50;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(12, 498);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(706, 20);
            this.textBox2.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Location = new System.Drawing.Point(720, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 20);
            this.button1.TabIndex = 52;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // OutPutText
            // 
            this.OutPutText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OutPutText.AutoSize = true;
            this.OutPutText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPutText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OutPutText.Location = new System.Drawing.Point(16, 312);
            this.OutPutText.Name = "OutPutText";
            this.OutPutText.Size = new System.Drawing.Size(53, 18);
            this.OutPutText.TabIndex = 53;
            this.OutPutText.Text = "Saida";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(954, 530);
            this.Controls.Add(this.OutPutText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.COMMANDSText);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxComando);
            this.Controls.Add(this.AddCommando_Button);
            this.Controls.Add(this.Expandir);
            this.Controls.Add(this.STREAMINGText);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.SIMText);
            this.Controls.Add(this.CONNECTIONText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listViewComandos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.Text = "Lv12 4G";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
 
        private System.Windows.Forms.Button buttonReadPort;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label PORTUSBText;
        private System.Windows.Forms.Label Gmt_Text;
        private System.Windows.Forms.TextBox Server_Input;
        private System.Windows.Forms.Label PORTText;
        private System.Windows.Forms.Label SERVERText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CONNECTIONText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox APN_Input;
        private System.Windows.Forms.Label PASSText;
        private System.Windows.Forms.TextBox Pass_Input;
        private System.Windows.Forms.Label APNText;
        private System.Windows.Forms.Label USERText;
        private System.Windows.Forms.TextBox User_Input;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonClosePort;
        private System.Windows.Forms.Label SIMText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ANGLEText;
        private System.Windows.Forms.Label STOPText;
        private System.Windows.Forms.Label MOVINGText;
        private System.Windows.Forms.Label STREAMINGText;
        private System.Windows.Forms.Button Expandir;
        private System.Windows.Forms.Button SaveDevice;
        private System.Windows.Forms.NumericUpDown Angle_Input;
        private System.Windows.Forms.NumericUpDown OnMovingNet_Input;
        private System.Windows.Forms.NumericUpDown OnStopNet_Input;
        private System.Windows.Forms.ComboBox GMT_Box;
        private System.Windows.Forms.NumericUpDown Port_Input;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button SaveProfileButton;
        private System.Windows.Forms.Button AddCommando_Button;
        private System.Windows.Forms.TextBox textBoxComando;
        private System.Windows.Forms.ColumnHeader comandos;
        private System.Windows.Forms.Label COMMANDSText;
        public System.Windows.Forms.ListView listViewComandos;
        private System.Windows.Forms.Label PROFILEText;
        private System.Windows.Forms.Button PTBRButton;
        private System.Windows.Forms.Button ENGButton;
        private System.Windows.Forms.Button LoadProfileButton;
        private System.Windows.Forms.Label ServidorText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label OutPutText;
    }
}

