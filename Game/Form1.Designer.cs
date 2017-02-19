namespace Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctbAvatar = new System.Windows.Forms.PictureBox();
            this.pnlSpin = new System.Windows.Forms.Panel();
            this.bntStop = new System.Windows.Forms.Button();
            this.txbSpinCard = new System.Windows.Forms.TextBox();
            this.bntSpin = new System.Windows.Forms.Button();
            this.pctbSpin = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.timerSpin = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).BeginInit();
            this.pnlSpin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSpin)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlChessBoard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlChessBoard.Location = new System.Drawing.Point(242, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(730, 537);
            this.pnlChessBoard.TabIndex = 0;
            this.pnlChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChessBoard_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pctbAvatar);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 130);
            this.panel2.TabIndex = 1;
            // 
            // pctbAvatar
            // 
            this.pctbAvatar.BackgroundImage = global::Game.Properties.Resources.logo;
            this.pctbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctbAvatar.Location = new System.Drawing.Point(0, 0);
            this.pctbAvatar.Name = "pctbAvatar";
            this.pctbAvatar.Size = new System.Drawing.Size(224, 130);
            this.pctbAvatar.TabIndex = 0;
            this.pctbAvatar.TabStop = false;
            // 
            // pnlSpin
            // 
            this.pnlSpin.Controls.Add(this.bntStop);
            this.pnlSpin.Controls.Add(this.txbSpinCard);
            this.pnlSpin.Controls.Add(this.bntSpin);
            this.pnlSpin.Controls.Add(this.pctbSpin);
            this.pnlSpin.Location = new System.Drawing.Point(12, 148);
            this.pnlSpin.Name = "pnlSpin";
            this.pnlSpin.Size = new System.Drawing.Size(224, 249);
            this.pnlSpin.TabIndex = 2;
            // 
            // bntStop
            // 
            this.bntStop.Location = new System.Drawing.Point(125, 223);
            this.bntStop.Name = "bntStop";
            this.bntStop.Size = new System.Drawing.Size(75, 25);
            this.bntStop.TabIndex = 3;
            this.bntStop.Text = "STOP";
            this.bntStop.UseVisualStyleBackColor = true;
            // 
            // txbSpinCard
            // 
            this.txbSpinCard.Location = new System.Drawing.Point(22, 203);
            this.txbSpinCard.Name = "txbSpinCard";
            this.txbSpinCard.ReadOnly = true;
            this.txbSpinCard.Size = new System.Drawing.Size(178, 20);
            this.txbSpinCard.TabIndex = 2;
            this.txbSpinCard.Text = "Kết quả";
            this.txbSpinCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bntSpin
            // 
            this.bntSpin.Location = new System.Drawing.Point(22, 223);
            this.bntSpin.Name = "bntSpin";
            this.bntSpin.Size = new System.Drawing.Size(75, 25);
            this.bntSpin.TabIndex = 1;
            this.bntSpin.Text = "SPIN";
            this.bntSpin.UseVisualStyleBackColor = true;
            // 
            // pctbSpin
            // 
            this.pctbSpin.BackColor = System.Drawing.SystemColors.Control;
            this.pctbSpin.BackgroundImage = global::Game.Properties.Resources.startCard;
            this.pctbSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbSpin.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pctbSpin.Location = new System.Drawing.Point(22, 0);
            this.pctbSpin.Name = "pctbSpin";
            this.pctbSpin.Size = new System.Drawing.Size(178, 197);
            this.pctbSpin.TabIndex = 0;
            this.pctbSpin.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLAN);
            this.panel4.Controls.Add(this.txbIP);
            this.panel4.Controls.Add(this.pctbMark);
            this.panel4.Controls.Add(this.prcbCoolDown);
            this.panel4.Controls.Add(this.txbPlayerName);
            this.panel4.Location = new System.Drawing.Point(12, 403);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 146);
            this.panel4.TabIndex = 3;
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(4, 85);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(115, 23);
            this.btnLAN.TabIndex = 4;
            this.btnLAN.Text = "LAN";
            this.btnLAN.UseVisualStyleBackColor = true;
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(4, 59);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(115, 20);
            this.txbIP.TabIndex = 3;
            // 
            // pctbMark
            // 
            this.pctbMark.Location = new System.Drawing.Point(125, 1);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(99, 99);
            this.pctbMark.TabIndex = 2;
            this.pctbMark.TabStop = false;
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(4, 30);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(115, 23);
            this.prcbCoolDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(4, 4);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.ReadOnly = true;
            this.txbPlayerName.Size = new System.Drawing.Size(115, 20);
            this.txbPlayerName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlSpin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).EndInit();
            this.pnlSpin.ResumeLayout(false);
            this.pnlSpin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSpin)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlSpin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pctbAvatar;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Button bntSpin;
        private System.Windows.Forms.PictureBox pctbSpin;
        private System.Windows.Forms.TextBox txbSpinCard;
        private System.Windows.Forms.Timer timerSpin;
        private System.Windows.Forms.Button bntStop;
    }
}

