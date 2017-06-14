namespace WindowsFormsApp1
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
            this.Paddle2 = new System.Windows.Forms.PictureBox();
            this.Paddle1 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Paddle2
            // 
            this.Paddle2.Image = ((System.Drawing.Image)(resources.GetObject("Paddle2.Image")));
            this.Paddle2.Location = new System.Drawing.Point(12, 185);
            this.Paddle2.Name = "Paddle2";
            this.Paddle2.Size = new System.Drawing.Size(23, 202);
            this.Paddle2.TabIndex = 0;
            this.Paddle2.TabStop = false;
            // 
            // Paddle1
            // 
            this.Paddle1.Image = ((System.Drawing.Image)(resources.GetObject("Paddle1.Image")));
            this.Paddle1.Location = new System.Drawing.Point(1305, 498);
            this.Paddle1.Name = "Paddle1";
            this.Paddle1.Size = new System.Drawing.Size(20, 202);
            this.Paddle1.TabIndex = 1;
            this.Paddle1.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(404, 185);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 19);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            this.Ball.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(592, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoEllipsis = true;
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPlayer2.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayer2.Location = new System.Drawing.Point(563, 79);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(41, 43);
            this.labelPlayer2.TabIndex = 4;
            this.labelPlayer2.Text = "0";
            this.labelPlayer2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(629, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "\\";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoEllipsis = true;
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPlayer1.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayer1.Location = new System.Drawing.Point(690, 79);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(41, 43);
            this.labelPlayer1.TabIndex = 6;
            this.labelPlayer1.Text = "0";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMode.Location = new System.Drawing.Point(588, 9);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(112, 21);
            this.labelMode.TabIndex = 7;
            this.labelMode.Text = "Ultimate mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1337, 700);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Paddle1);
            this.Controls.Add(this.Paddle2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Paddle2;
        private System.Windows.Forms.PictureBox Paddle1;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelMode;
    }
}

