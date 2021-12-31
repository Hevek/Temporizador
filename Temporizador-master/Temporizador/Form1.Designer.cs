namespace Temporizador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.minuto = new System.Windows.Forms.Label();
            this.segundo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerSegundos = new System.Windows.Forms.Timer(this.components);
            this.iniciar = new System.Windows.Forms.Button();
            this.zerar = new System.Windows.Forms.Button();
            this.pausar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxHoras = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutos = new System.Windows.Forms.ComboBox();
            this.comboBoxSegundos = new System.Windows.Forms.ComboBox();
            this.textBoxHoras = new System.Windows.Forms.TextBox();
            this.textBoxMinutos = new System.Windows.Forms.TextBox();
            this.textBoxSegundos = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.opcoes = new System.Windows.Forms.ListBox();
            this.radioButton1ComboBox = new System.Windows.Forms.RadioButton();
            this.radioButton1TextBox = new System.Windows.Forms.RadioButton();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(84, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temporizador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.LimeGreen;
            this.hora.Location = new System.Drawing.Point(77, 218);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(53, 40);
            this.hora.TabIndex = 0;
            this.hora.Text = "00";
            // 
            // minuto
            // 
            this.minuto.AutoSize = true;
            this.minuto.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuto.ForeColor = System.Drawing.Color.LimeGreen;
            this.minuto.Location = new System.Drawing.Point(171, 218);
            this.minuto.Name = "minuto";
            this.minuto.Size = new System.Drawing.Size(53, 40);
            this.minuto.TabIndex = 0;
            this.minuto.Text = "00";
            // 
            // segundo
            // 
            this.segundo.AutoSize = true;
            this.segundo.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundo.ForeColor = System.Drawing.Color.LimeGreen;
            this.segundo.Location = new System.Drawing.Point(265, 218);
            this.segundo.Name = "segundo";
            this.segundo.Size = new System.Drawing.Size(53, 40);
            this.segundo.TabIndex = 0;
            this.segundo.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(136, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(230, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = ":";
            // 
            // timerSegundos
            // 
            this.timerSegundos.Interval = 997;
            this.timerSegundos.Tick += new System.EventHandler(this.timerSegundos_Tick);
            // 
            // iniciar
            // 
            this.iniciar.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.iniciar.ForeColor = System.Drawing.Color.Firebrick;
            this.iniciar.Location = new System.Drawing.Point(12, 340);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(118, 57);
            this.iniciar.TabIndex = 11;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // zerar
            // 
            this.zerar.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.zerar.ForeColor = System.Drawing.Color.Firebrick;
            this.zerar.Location = new System.Drawing.Point(143, 340);
            this.zerar.Name = "zerar";
            this.zerar.Size = new System.Drawing.Size(118, 57);
            this.zerar.TabIndex = 12;
            this.zerar.Text = "Zerar";
            this.zerar.UseVisualStyleBackColor = true;
            this.zerar.Click += new System.EventHandler(this.zerar_Click);
            // 
            // pausar
            // 
            this.pausar.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.pausar.ForeColor = System.Drawing.Color.Firebrick;
            this.pausar.Location = new System.Drawing.Point(272, 340);
            this.pausar.Name = "pausar";
            this.pausar.Size = new System.Drawing.Size(118, 57);
            this.pausar.TabIndex = 13;
            this.pausar.Text = "Pausar";
            this.pausar.UseVisualStyleBackColor = true;
            this.pausar.Click += new System.EventHandler(this.pausar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Horas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(156, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Minutos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Segundos";
            // 
            // comboBoxHoras
            // 
            this.comboBoxHoras.FormattingEnabled = true;
            this.comboBoxHoras.Location = new System.Drawing.Point(60, 136);
            this.comboBoxHoras.Name = "comboBoxHoras";
            this.comboBoxHoras.Size = new System.Drawing.Size(59, 21);
            this.comboBoxHoras.TabIndex = 2;
            // 
            // comboBoxMinutos
            // 
            this.comboBoxMinutos.FormattingEnabled = true;
            this.comboBoxMinutos.Location = new System.Drawing.Point(169, 136);
            this.comboBoxMinutos.Name = "comboBoxMinutos";
            this.comboBoxMinutos.Size = new System.Drawing.Size(59, 21);
            this.comboBoxMinutos.TabIndex = 3;
            // 
            // comboBoxSegundos
            // 
            this.comboBoxSegundos.FormattingEnabled = true;
            this.comboBoxSegundos.Location = new System.Drawing.Point(283, 136);
            this.comboBoxSegundos.Name = "comboBoxSegundos";
            this.comboBoxSegundos.Size = new System.Drawing.Size(59, 21);
            this.comboBoxSegundos.TabIndex = 4;
            // 
            // textBoxHoras
            // 
            this.textBoxHoras.Location = new System.Drawing.Point(60, 163);
            this.textBoxHoras.MaxLength = 2;
            this.textBoxHoras.Name = "textBoxHoras";
            this.textBoxHoras.Size = new System.Drawing.Size(60, 20);
            this.textBoxHoras.TabIndex = 6;
            this.textBoxHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxMinutos
            // 
            this.textBoxMinutos.Location = new System.Drawing.Point(169, 163);
            this.textBoxMinutos.MaxLength = 2;
            this.textBoxMinutos.Name = "textBoxMinutos";
            this.textBoxMinutos.Size = new System.Drawing.Size(60, 20);
            this.textBoxMinutos.TabIndex = 7;
            this.textBoxMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxSegundos
            // 
            this.textBoxSegundos.Location = new System.Drawing.Point(282, 163);
            this.textBoxSegundos.MaxLength = 2;
            this.textBoxSegundos.Name = "textBoxSegundos";
            this.textBoxSegundos.Size = new System.Drawing.Size(60, 20);
            this.textBoxSegundos.TabIndex = 8;
            this.textBoxSegundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // opcoes
            // 
            this.opcoes.BackColor = System.Drawing.SystemColors.Control;
            this.opcoes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcoes.ForeColor = System.Drawing.Color.Black;
            this.opcoes.FormattingEnabled = true;
            this.opcoes.ItemHeight = 15;
            this.opcoes.Location = new System.Drawing.Point(13, 273);
            this.opcoes.Name = "opcoes";
            this.opcoes.Size = new System.Drawing.Size(141, 49);
            this.opcoes.TabIndex = 9;
            this.opcoes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opcoes_MouseClick);
            this.opcoes.SelectedIndexChanged += new System.EventHandler(this.opcoes_SelectedIndexChanged);
            // 
            // radioButton1ComboBox
            // 
            this.radioButton1ComboBox.AutoSize = true;
            this.radioButton1ComboBox.Checked = true;
            this.radioButton1ComboBox.Location = new System.Drawing.Point(40, 136);
            this.radioButton1ComboBox.Name = "radioButton1ComboBox";
            this.radioButton1ComboBox.Size = new System.Drawing.Size(14, 13);
            this.radioButton1ComboBox.TabIndex = 1;
            this.radioButton1ComboBox.TabStop = true;
            this.radioButton1ComboBox.UseVisualStyleBackColor = true;
            this.radioButton1ComboBox.Click += new System.EventHandler(this.radioButton1ComboBox_Click);
            // 
            // radioButton1TextBox
            // 
            this.radioButton1TextBox.AutoSize = true;
            this.radioButton1TextBox.Location = new System.Drawing.Point(40, 166);
            this.radioButton1TextBox.Name = "radioButton1TextBox";
            this.radioButton1TextBox.Size = new System.Drawing.Size(14, 13);
            this.radioButton1TextBox.TabIndex = 5;
            this.radioButton1TextBox.TabStop = true;
            this.radioButton1TextBox.UseVisualStyleBackColor = true;
            this.radioButton1TextBox.Click += new System.EventHandler(this.radioButton1TextBox_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(160, 273);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(217, 44);
            this.player.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(402, 410);
            this.Controls.Add(this.radioButton1TextBox);
            this.Controls.Add(this.radioButton1ComboBox);
            this.Controls.Add(this.opcoes);
            this.Controls.Add(this.player);
            this.Controls.Add(this.textBoxSegundos);
            this.Controls.Add(this.textBoxMinutos);
            this.Controls.Add(this.textBoxHoras);
            this.Controls.Add(this.comboBoxSegundos);
            this.Controls.Add(this.comboBoxMinutos);
            this.Controls.Add(this.comboBoxHoras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pausar);
            this.Controls.Add(this.zerar);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.segundo);
            this.Controls.Add(this.minuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Temporizador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label minuto;
        private System.Windows.Forms.Label segundo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerSegundos;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Button zerar;
        private System.Windows.Forms.Button pausar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxHoras;
        private System.Windows.Forms.ComboBox comboBoxMinutos;
        private System.Windows.Forms.ComboBox comboBoxSegundos;
        private System.Windows.Forms.TextBox textBoxHoras;
        private System.Windows.Forms.TextBox textBoxMinutos;
        private System.Windows.Forms.TextBox textBoxSegundos;

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private System.Windows.Forms.FontDialog fontDialog1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListBox opcoes;
        private System.Windows.Forms.RadioButton radioButton1ComboBox;
        private System.Windows.Forms.RadioButton radioButton1TextBox;
    }
}

