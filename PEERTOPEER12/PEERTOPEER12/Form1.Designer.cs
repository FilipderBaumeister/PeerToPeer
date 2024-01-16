
namespace PEERTOPEER12
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.ServerIPtextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServerPortsTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientIPTextbox = new System.Windows.Forms.TextBox();
            this.ClientPortsTextbox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChatScreen = new System.Windows.Forms.TextBox();
            this.Messagebox = new System.Windows.Forms.TextBox();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(618, 38);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(114, 31);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServerIPtextbox
            // 
            this.ServerIPtextbox.Location = new System.Drawing.Point(105, 38);
            this.ServerIPtextbox.Multiline = true;
            this.ServerIPtextbox.Name = "ServerIPtextbox";
            this.ServerIPtextbox.Size = new System.Drawing.Size(191, 31);
            this.ServerIPtextbox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.ClientPortsTextbox);
            this.groupBox1.Controls.Add(this.ClientIPTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ServerPortsTextbox);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.ServerIPtextbox);
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // ServerPortsTextbox
            // 
            this.ServerPortsTextbox.Location = new System.Drawing.Point(408, 38);
            this.ServerPortsTextbox.Multiline = true;
            this.ServerPortsTextbox.Name = "ServerPortsTextbox";
            this.ServerPortsTextbox.Size = new System.Drawing.Size(191, 31);
            this.ServerPortsTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ports";
            // 
            // ClientIPTextbox
            // 
            this.ClientIPTextbox.Location = new System.Drawing.Point(105, 117);
            this.ClientIPTextbox.Multiline = true;
            this.ClientIPTextbox.Name = "ClientIPTextbox";
            this.ClientIPTextbox.Size = new System.Drawing.Size(191, 31);
            this.ClientIPTextbox.TabIndex = 5;
            // 
            // ClientPortsTextbox
            // 
            this.ClientPortsTextbox.Location = new System.Drawing.Point(408, 117);
            this.ClientPortsTextbox.Multiline = true;
            this.ClientPortsTextbox.Name = "ClientPortsTextbox";
            this.ClientPortsTextbox.Size = new System.Drawing.Size(191, 31);
            this.ClientPortsTextbox.TabIndex = 6;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(618, 117);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(114, 31);
            this.ConnectButton.TabIndex = 7;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP";
            // 
            // ChatScreen
            // 
            this.ChatScreen.Location = new System.Drawing.Point(27, 229);
            this.ChatScreen.Multiline = true;
            this.ChatScreen.Name = "ChatScreen";
            this.ChatScreen.Size = new System.Drawing.Size(747, 141);
            this.ChatScreen.TabIndex = 10;
            // 
            // Messagebox
            // 
            this.Messagebox.Location = new System.Drawing.Point(27, 387);
            this.Messagebox.Multiline = true;
            this.Messagebox.Name = "Messagebox";
            this.Messagebox.Size = new System.Drawing.Size(539, 39);
            this.Messagebox.TabIndex = 11;
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(583, 387);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(191, 39);
            this.Sendbutton.TabIndex = 10;
            this.Sendbutton.Text = "Send";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.Messagebox);
            this.Controls.Add(this.ChatScreen);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox ServerIPtextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ClientPortsTextbox;
        private System.Windows.Forms.TextBox ClientIPTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerPortsTextbox;
        private System.Windows.Forms.TextBox ChatScreen;
        private System.Windows.Forms.TextBox Messagebox;
        private System.Windows.Forms.Button Sendbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

