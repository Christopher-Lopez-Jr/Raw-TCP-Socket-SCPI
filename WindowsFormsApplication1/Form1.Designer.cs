namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.inputSCPI = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SCPI = new System.Windows.Forms.Label();
            this.txtSent = new System.Windows.Forms.TextBox();
            this.txtDebug = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(51, 32);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(51, 58);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(157, 55);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // inputSCPI
            // 
            this.inputSCPI.Location = new System.Drawing.Point(51, 84);
            this.inputSCPI.Name = "inputSCPI";
            this.inputSCPI.Size = new System.Drawing.Size(100, 20);
            this.inputSCPI.TabIndex = 5;
            this.inputSCPI.TextChanged += new System.EventHandler(this.inputSCPI_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(157, 82);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // SCPI
            // 
            this.SCPI.AutoSize = true;
            this.SCPI.Location = new System.Drawing.Point(12, 87);
            this.SCPI.Name = "SCPI";
            this.SCPI.Size = new System.Drawing.Size(37, 13);
            this.SCPI.TabIndex = 7;
            this.SCPI.Text = "SCPI: ";
            // 
            // txtSent
            // 
            this.txtSent.Location = new System.Drawing.Point(51, 123);
            this.txtSent.Multiline = true;
            this.txtSent.Name = "txtSent";
            this.txtSent.Size = new System.Drawing.Size(181, 51);
            this.txtSent.TabIndex = 8;
            // 
            // txtDebug
            // 
            this.txtDebug.AutoSize = true;
            this.txtDebug.Location = new System.Drawing.Point(48, 107);
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(39, 13);
            this.txtDebug.TabIndex = 9;
            this.txtDebug.Text = "Debug";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 198);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 51);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtQuery
            // 
            this.txtQuery.AutoSize = true;
            this.txtQuery.Location = new System.Drawing.Point(48, 182);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(35, 13);
            this.txtQuery.TabIndex = 11;
            this.txtQuery.Text = "Query";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.txtSent);
            this.Controls.Add(this.SCPI);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.inputSCPI);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox inputSCPI;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label SCPI;
        private System.Windows.Forms.TextBox txtSent;
        private System.Windows.Forms.Label txtDebug;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtQuery;
    }
}

