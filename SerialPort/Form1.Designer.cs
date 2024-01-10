namespace SerialPortTest
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados。
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDataRec = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetConf = new System.Windows.Forms.ToolStripMenuItem();
            this.GBSerialPort = new System.Windows.Forms.GroupBox();
            this.CBStopBit = new System.Windows.Forms.ComboBox();
            this.CBCheckBit = new System.Windows.Forms.ComboBox();
            this.CBDataBit = new System.Windows.Forms.ComboBox();
            this.CBBaudRate = new System.Windows.Forms.ComboBox();
            this.CBCom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtCom = new System.Windows.Forms.Button();
            this.GBSendSetting = new System.Windows.Forms.GroupBox();
            this.RBTxDataHex = new System.Windows.Forms.RadioButton();
            this.RBTxDataASCII = new System.Windows.Forms.RadioButton();
            this.GBReceiveSetting = new System.Windows.Forms.GroupBox();
            this.RBRxDataHEX = new System.Windows.Forms.RadioButton();
            this.RBRxDataASCII = new System.Windows.Forms.RadioButton();
            this.GBReceiveData = new System.Windows.Forms.GroupBox();
            this.BtClear = new System.Windows.Forms.Button();
            this.TxtBoxReceive = new System.Windows.Forms.TextBox();
            this.GBSendData = new System.Windows.Forms.GroupBox();
            this.BtSend = new System.Windows.Forms.Button();
            this.TxtBoxSend = new System.Windows.Forms.TextBox();
            this.TimerPort = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip1.SuspendLayout();
            this.GBSerialPort.SuspendLayout();
            this.GBSendSetting.SuspendLayout();
            this.GBReceiveSetting.SuspendLayout();
            this.GBReceiveData.SuspendLayout();
            this.GBSendData.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuSetting});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(691, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveDataRec,
            this.Exit});
            this.MenuFile.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(60, 20);
            this.MenuFile.Text = "Arquivo";
            // 
            // SaveDataRec
            // 
            this.SaveDataRec.Name = "SaveDataRec";
            this.SaveDataRec.Size = new System.Drawing.Size(180, 22);
            this.SaveDataRec.Text = "Salvar dados";
            this.SaveDataRec.Click += new System.EventHandler(this.SaveDataRec_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MenuSetting
            // 
            this.MenuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetConf});
            this.MenuSetting.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MenuSetting.Name = "MenuSetting";
            this.MenuSetting.Size = new System.Drawing.Size(81, 20);
            this.MenuSetting.Text = "Ferramenta";
            // 
            // ResetConf
            // 
            this.ResetConf.Name = "ResetConf";
            this.ResetConf.Size = new System.Drawing.Size(194, 22);
            this.ResetConf.Text = "Resetar configurações";
            this.ResetConf.Click += new System.EventHandler(this.ResetConf_Click);
            // 
            // GBSerialPort
            // 
            this.GBSerialPort.Controls.Add(this.CBStopBit);
            this.GBSerialPort.Controls.Add(this.CBCheckBit);
            this.GBSerialPort.Controls.Add(this.CBDataBit);
            this.GBSerialPort.Controls.Add(this.CBBaudRate);
            this.GBSerialPort.Controls.Add(this.CBCom);
            this.GBSerialPort.Controls.Add(this.label5);
            this.GBSerialPort.Controls.Add(this.label4);
            this.GBSerialPort.Controls.Add(this.label3);
            this.GBSerialPort.Controls.Add(this.label2);
            this.GBSerialPort.Controls.Add(this.label1);
            this.GBSerialPort.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSerialPort.Location = new System.Drawing.Point(12, 29);
            this.GBSerialPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSerialPort.Name = "GBSerialPort";
            this.GBSerialPort.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSerialPort.Size = new System.Drawing.Size(233, 169);
            this.GBSerialPort.TabIndex = 2;
            this.GBSerialPort.TabStop = false;
            this.GBSerialPort.Text = "Configurações";
            // 
            // CBStopBit
            // 
            this.CBStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStopBit.FormattingEnabled = true;
            this.CBStopBit.Location = new System.Drawing.Point(96, 141);
            this.CBStopBit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBStopBit.Name = "CBStopBit";
            this.CBStopBit.Size = new System.Drawing.Size(121, 22);
            this.CBStopBit.TabIndex = 9;
            // 
            // CBCheckBit
            // 
            this.CBCheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCheckBit.FormattingEnabled = true;
            this.CBCheckBit.Location = new System.Drawing.Point(96, 110);
            this.CBCheckBit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBCheckBit.Name = "CBCheckBit";
            this.CBCheckBit.Size = new System.Drawing.Size(121, 22);
            this.CBCheckBit.TabIndex = 8;
            // 
            // CBDataBit
            // 
            this.CBDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDataBit.FormattingEnabled = true;
            this.CBDataBit.Location = new System.Drawing.Point(96, 82);
            this.CBDataBit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBDataBit.Name = "CBDataBit";
            this.CBDataBit.Size = new System.Drawing.Size(121, 22);
            this.CBDataBit.TabIndex = 7;
            // 
            // CBBaudRate
            // 
            this.CBBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBaudRate.FormattingEnabled = true;
            this.CBBaudRate.Location = new System.Drawing.Point(96, 54);
            this.CBBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBBaudRate.Name = "CBBaudRate";
            this.CBBaudRate.Size = new System.Drawing.Size(121, 22);
            this.CBBaudRate.TabIndex = 6;
            // 
            // CBCom
            // 
            this.CBCom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CBCom.BackColor = System.Drawing.SystemColors.Window;
            this.CBCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCom.FormattingEnabled = true;
            this.CBCom.Location = new System.Drawing.Point(96, 28);
            this.CBCom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBCom.Name = "CBCom";
            this.CBCom.Size = new System.Drawing.Size(121, 22);
            this.CBCom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stop Bits";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtCom
            // 
            this.BtCom.Font = new System.Drawing.Font("Tahoma", 9F);
            this.BtCom.Location = new System.Drawing.Point(12, 203);
            this.BtCom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtCom.Name = "BtCom";
            this.BtCom.Size = new System.Drawing.Size(102, 29);
            this.BtCom.TabIndex = 3;
            this.BtCom.Text = "Conectar";
            this.BtCom.UseVisualStyleBackColor = true;
            this.BtCom.Click += new System.EventHandler(this.BtCom_Click);
            // 
            // GBSendSetting
            // 
            this.GBSendSetting.Controls.Add(this.RBTxDataHex);
            this.GBSendSetting.Controls.Add(this.RBTxDataASCII);
            this.GBSendSetting.Font = new System.Drawing.Font("Tahoma", 9F);
            this.GBSendSetting.Location = new System.Drawing.Point(12, 398);
            this.GBSendSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSendSetting.Name = "GBSendSetting";
            this.GBSendSetting.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSendSetting.Size = new System.Drawing.Size(233, 50);
            this.GBSendSetting.TabIndex = 5;
            this.GBSendSetting.TabStop = false;
            this.GBSendSetting.Text = "Enviar em";
            // 
            // RBTxDataHex
            // 
            this.RBTxDataHex.AutoSize = true;
            this.RBTxDataHex.Location = new System.Drawing.Point(82, 18);
            this.RBTxDataHex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBTxDataHex.Name = "RBTxDataHex";
            this.RBTxDataHex.Size = new System.Drawing.Size(47, 18);
            this.RBTxDataHex.TabIndex = 1;
            this.RBTxDataHex.TabStop = true;
            this.RBTxDataHex.Text = "HEX";
            this.RBTxDataHex.UseVisualStyleBackColor = true;
            // 
            // RBTxDataASCII
            // 
            this.RBTxDataASCII.AutoSize = true;
            this.RBTxDataASCII.Location = new System.Drawing.Point(19, 19);
            this.RBTxDataASCII.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBTxDataASCII.Name = "RBTxDataASCII";
            this.RBTxDataASCII.Size = new System.Drawing.Size(55, 18);
            this.RBTxDataASCII.TabIndex = 0;
            this.RBTxDataASCII.TabStop = true;
            this.RBTxDataASCII.Text = "ASCII";
            this.RBTxDataASCII.UseVisualStyleBackColor = true;
            // 
            // GBReceiveSetting
            // 
            this.GBReceiveSetting.Controls.Add(this.RBRxDataHEX);
            this.GBReceiveSetting.Controls.Add(this.RBRxDataASCII);
            this.GBReceiveSetting.Font = new System.Drawing.Font("Tahoma", 9F);
            this.GBReceiveSetting.Location = new System.Drawing.Point(12, 344);
            this.GBReceiveSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBReceiveSetting.Name = "GBReceiveSetting";
            this.GBReceiveSetting.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBReceiveSetting.Size = new System.Drawing.Size(233, 50);
            this.GBReceiveSetting.TabIndex = 6;
            this.GBReceiveSetting.TabStop = false;
            this.GBReceiveSetting.Text = "Receber em";
            // 
            // RBRxDataHEX
            // 
            this.RBRxDataHEX.AutoSize = true;
            this.RBRxDataHEX.Location = new System.Drawing.Point(82, 18);
            this.RBRxDataHEX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBRxDataHEX.Name = "RBRxDataHEX";
            this.RBRxDataHEX.Size = new System.Drawing.Size(47, 18);
            this.RBRxDataHEX.TabIndex = 1;
            this.RBRxDataHEX.TabStop = true;
            this.RBRxDataHEX.Text = "HEX";
            this.RBRxDataHEX.UseVisualStyleBackColor = true;
            // 
            // RBRxDataASCII
            // 
            this.RBRxDataASCII.AutoSize = true;
            this.RBRxDataASCII.Location = new System.Drawing.Point(19, 18);
            this.RBRxDataASCII.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBRxDataASCII.Name = "RBRxDataASCII";
            this.RBRxDataASCII.Size = new System.Drawing.Size(55, 18);
            this.RBRxDataASCII.TabIndex = 0;
            this.RBRxDataASCII.TabStop = true;
            this.RBRxDataASCII.Text = "ASCII";
            this.RBRxDataASCII.UseVisualStyleBackColor = true;
            // 
            // GBReceiveData
            // 
            this.GBReceiveData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBReceiveData.Controls.Add(this.BtClear);
            this.GBReceiveData.Controls.Add(this.TxtBoxReceive);
            this.GBReceiveData.Font = new System.Drawing.Font("Tahoma", 9F);
            this.GBReceiveData.Location = new System.Drawing.Point(260, 245);
            this.GBReceiveData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBReceiveData.Name = "GBReceiveData";
            this.GBReceiveData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBReceiveData.Size = new System.Drawing.Size(419, 203);
            this.GBReceiveData.TabIndex = 7;
            this.GBReceiveData.TabStop = false;
            this.GBReceiveData.Text = "Dados Recebidos";
            // 
            // BtClear
            // 
            this.BtClear.Location = new System.Drawing.Point(300, 174);
            this.BtClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(75, 24);
            this.BtClear.TabIndex = 1;
            this.BtClear.Text = "Limpar";
            this.BtClear.UseVisualStyleBackColor = true;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // TxtBoxReceive
            // 
            this.TxtBoxReceive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtBoxReceive.Location = new System.Drawing.Point(3, 16);
            this.TxtBoxReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxReceive.Multiline = true;
            this.TxtBoxReceive.Name = "TxtBoxReceive";
            this.TxtBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoxReceive.Size = new System.Drawing.Size(410, 154);
            this.TxtBoxReceive.TabIndex = 0;
            // 
            // GBSendData
            // 
            this.GBSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBSendData.Controls.Add(this.BtSend);
            this.GBSendData.Controls.Add(this.TxtBoxSend);
            this.GBSendData.Font = new System.Drawing.Font("Tahoma", 9F);
            this.GBSendData.Location = new System.Drawing.Point(260, 29);
            this.GBSendData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSendData.Name = "GBSendData";
            this.GBSendData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSendData.Size = new System.Drawing.Size(419, 203);
            this.GBSendData.TabIndex = 8;
            this.GBSendData.TabStop = false;
            this.GBSendData.Text = "Enviar dados";
            // 
            // BtSend
            // 
            this.BtSend.Location = new System.Drawing.Point(300, 174);
            this.BtSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtSend.Name = "BtSend";
            this.BtSend.Size = new System.Drawing.Size(75, 24);
            this.BtSend.TabIndex = 1;
            this.BtSend.Text = "Enviar";
            this.BtSend.UseVisualStyleBackColor = true;
            this.BtSend.Click += new System.EventHandler(this.BtSend_Click);
            // 
            // TxtBoxSend
            // 
            this.TxtBoxSend.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBoxSend.Location = new System.Drawing.Point(3, 17);
            this.TxtBoxSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxSend.Multiline = true;
            this.TxtBoxSend.Name = "TxtBoxSend";
            this.TxtBoxSend.Size = new System.Drawing.Size(413, 154);
            this.TxtBoxSend.TabIndex = 0;
            // 
            // TimerPort
            // 
            this.TimerPort.Interval = 1000;
            this.TimerPort.Tick += new System.EventHandler(this.TimerPort_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 459);
            this.Controls.Add(this.GBSendData);
            this.Controls.Add(this.GBReceiveSetting);
            this.Controls.Add(this.GBReceiveData);
            this.Controls.Add(this.GBSendSetting);
            this.Controls.Add(this.BtCom);
            this.Controls.Add(this.GBSerialPort);
            this.Controls.Add(this.MenuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Form1";
            this.Text = "SerialPort";
            this.Load += new System.EventHandler(this.Form1Init);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.GBSerialPort.ResumeLayout(false);
            this.GBSerialPort.PerformLayout();
            this.GBSendSetting.ResumeLayout(false);
            this.GBSendSetting.PerformLayout();
            this.GBReceiveSetting.ResumeLayout(false);
            this.GBReceiveSetting.PerformLayout();
            this.GBReceiveData.ResumeLayout(false);
            this.GBReceiveData.PerformLayout();
            this.GBSendData.ResumeLayout(false);
            this.GBSendData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSetting;
        private System.Windows.Forms.GroupBox GBSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBStopBit;
        private System.Windows.Forms.ComboBox CBCheckBit;
        private System.Windows.Forms.ComboBox CBDataBit;
        private System.Windows.Forms.ComboBox CBBaudRate;
        private System.Windows.Forms.ComboBox CBCom;
        private System.Windows.Forms.Button BtCom;
        private System.Windows.Forms.GroupBox GBSendSetting;
        private System.Windows.Forms.RadioButton RBTxDataASCII;
        private System.Windows.Forms.RadioButton RBTxDataHex;
        private System.Windows.Forms.GroupBox GBReceiveSetting;
        private System.Windows.Forms.RadioButton RBRxDataASCII;
        private System.Windows.Forms.RadioButton RBRxDataHEX;
        private System.Windows.Forms.GroupBox GBReceiveData;
        private System.Windows.Forms.TextBox TxtBoxReceive;
        private System.Windows.Forms.GroupBox GBSendData;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.TextBox TxtBoxSend;
        private System.Windows.Forms.Button BtSend;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem ResetConf;
        private System.Windows.Forms.ToolStripMenuItem SaveDataRec;
        private System.Windows.Forms.Timer TimerPort;
    }
}

