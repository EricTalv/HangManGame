namespace HangManGame
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
            this.L_Lost = new System.Windows.Forms.Label();
            this.L_Wins = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.P_LabelPanel = new System.Windows.Forms.Panel();
            this.L_WrongCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.L_Info = new System.Windows.Forms.Label();
            this.L_WordLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SSL_RevealWord = new System.Windows.Forms.ToolStripStatusLabel();
            this.SSL_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.L_TryCount = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.B_StartGame = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.P_KeyBoard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBX_Pics = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Pics)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Lost
            // 
            this.L_Lost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L_Lost.ForeColor = System.Drawing.Color.Red;
            this.L_Lost.Location = new System.Drawing.Point(272, 163);
            this.L_Lost.Name = "L_Lost";
            this.L_Lost.Size = new System.Drawing.Size(40, 19);
            this.L_Lost.TabIndex = 33;
            this.L_Lost.Text = "0";
            this.L_Lost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_Wins
            // 
            this.L_Wins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L_Wins.ForeColor = System.Drawing.Color.Green;
            this.L_Wins.Location = new System.Drawing.Point(272, 126);
            this.L_Wins.Name = "L_Wins";
            this.L_Wins.Size = new System.Drawing.Size(40, 19);
            this.L_Wins.TabIndex = 32;
            this.L_Wins.Text = "0";
            this.L_Wins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(179, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Kaotused:    ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(179, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Võidud:    ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // P_LabelPanel
            // 
            this.P_LabelPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.P_LabelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_LabelPanel.Location = new System.Drawing.Point(12, 53);
            this.P_LabelPanel.Name = "P_LabelPanel";
            this.P_LabelPanel.Size = new System.Drawing.Size(442, 61);
            this.P_LabelPanel.TabIndex = 19;
            // 
            // L_WrongCount
            // 
            this.L_WrongCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L_WrongCount.Location = new System.Drawing.Point(164, 196);
            this.L_WrongCount.Name = "L_WrongCount";
            this.L_WrongCount.Size = new System.Drawing.Size(283, 21);
            this.L_WrongCount.TabIndex = 29;
            this.L_WrongCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Valesti Arvatud:    ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_Info
            // 
            this.L_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_Info.Location = new System.Drawing.Point(325, 121);
            this.L_Info.Name = "L_Info";
            this.L_Info.Size = new System.Drawing.Size(129, 65);
            this.L_Info.TabIndex = 27;
            this.L_Info.Text = "  ";
            this.L_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_WordLength
            // 
            this.L_WordLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L_WordLength.Location = new System.Drawing.Point(126, 161);
            this.L_WordLength.Name = "L_WordLength";
            this.L_WordLength.Size = new System.Drawing.Size(39, 21);
            this.L_WordLength.TabIndex = 26;
            this.L_WordLength.Text = "0";
            this.L_WordLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sõna Pikkus:    ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Proove Alles:    ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SSL_RevealWord
            // 
            this.SSL_RevealWord.Name = "SSL_RevealWord";
            this.SSL_RevealWord.Size = new System.Drawing.Size(105, 29);
            this.SSL_RevealWord.Text = "Show Word";
            this.SSL_RevealWord.Click += new System.EventHandler(this.SSL_RevealWord_Click);
            // 
            // SSL_Status
            // 
            this.SSL_Status.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.SSL_Status.Name = "SSL_Status";
            this.SSL_Status.Size = new System.Drawing.Size(64, 29);
            this.SSL_Status.Text = "Ready";
            // 
            // L_TryCount
            // 
            this.L_TryCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L_TryCount.Location = new System.Drawing.Point(135, 126);
            this.L_TryCount.Name = "L_TryCount";
            this.L_TryCount.Size = new System.Drawing.Size(30, 19);
            this.L_TryCount.TabIndex = 24;
            this.L_TryCount.Text = "0";
            this.L_TryCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SSL_Status,
            this.SSL_RevealWord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(741, 34);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // B_StartGame
            // 
            this.B_StartGame.Location = new System.Drawing.Point(12, 6);
            this.B_StartGame.Name = "B_StartGame";
            this.B_StartGame.Size = new System.Drawing.Size(442, 41);
            this.B_StartGame.TabIndex = 20;
            this.B_StartGame.Text = "Alusta Mäng";
            this.B_StartGame.UseVisualStyleBackColor = true;
            this.B_StartGame.Click += new System.EventHandler(this.B_StartGame_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel.Controls.Add(this.P_KeyBoard);
            this.panel.Location = new System.Drawing.Point(12, 227);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(714, 174);
            this.panel.TabIndex = 18;
            // 
            // P_KeyBoard
            // 
            this.P_KeyBoard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.P_KeyBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_KeyBoard.Location = new System.Drawing.Point(20, 16);
            this.P_KeyBoard.Name = "P_KeyBoard";
            this.P_KeyBoard.Size = new System.Drawing.Size(675, 142);
            this.P_KeyBoard.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 67);
            this.panel1.TabIndex = 21;
            // 
            // PBX_Pics
            // 
            this.PBX_Pics.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PBX_Pics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_Pics.Image = global::HangManGame.Properties.Resources.WaitingPlate;
            this.PBX_Pics.Location = new System.Drawing.Point(460, 6);
            this.PBX_Pics.Name = "PBX_Pics";
            this.PBX_Pics.Size = new System.Drawing.Size(266, 215);
            this.PBX_Pics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBX_Pics.TabIndex = 17;
            this.PBX_Pics.TabStop = false;
            this.PBX_Pics.Paint += new System.Windows.Forms.PaintEventHandler(this.PBX_Pics_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 447);
            this.Controls.Add(this.L_Lost);
            this.Controls.Add(this.L_Wins);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.P_LabelPanel);
            this.Controls.Add(this.L_WrongCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.L_Info);
            this.Controls.Add(this.L_WordLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_TryCount);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.B_StartGame);
            this.Controls.Add(this.PBX_Pics);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "The Hangman Game EST";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Pics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Lost;
        private System.Windows.Forms.Label L_Wins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel P_LabelPanel;
        private System.Windows.Forms.Label L_WrongCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label L_Info;
        private System.Windows.Forms.Label L_WordLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel SSL_RevealWord;
        private System.Windows.Forms.ToolStripStatusLabel SSL_Status;
        private System.Windows.Forms.Label L_TryCount;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button B_StartGame;
        private System.Windows.Forms.PictureBox PBX_Pics;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel P_KeyBoard;
        private System.Windows.Forms.Panel panel1;
    }
}

