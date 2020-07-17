namespace BouncingRadioButton
{
    partial class FakeInstallerForm
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
            this.ball = new System.Windows.Forms.RadioButton();
            this.frameTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.yesOffer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fakeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.AutoSize = true;
            this.ball.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ball.Location = new System.Drawing.Point(8, 51);
            this.ball.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 13);
            this.ball.TabIndex = 1;
            this.ball.Enter += new System.EventHandler(this.ball_FocusEnter);
            this.ball.MouseEnter += new System.EventHandler(this.ball_MouseEnter);
            // 
            // frameTimer
            // 
            this.frameTimer.Interval = 20;
            this.frameTimer.Tick += new System.EventHandler(this.frameTimer_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(307, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Next ->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yesOffer
            // 
            this.yesOffer.AutoSize = true;
            this.yesOffer.Checked = true;
            this.yesOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yesOffer.Location = new System.Drawing.Point(8, 24);
            this.yesOffer.Name = "yesOffer";
            this.yesOffer.Size = new System.Drawing.Size(265, 19);
            this.yesOffer.TabIndex = 0;
            this.yesOffer.TabStop = true;
            this.yesOffer.Text = "Yes! Install Free™ PC Optimizer right now! :D";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ball);
            this.groupBox1.Controls.Add(this.fakeLabel);
            this.groupBox1.Controls.Add(this.yesOffer);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Free™ Offer";
            // 
            // fakeLabel
            // 
            this.fakeLabel.AutoSize = true;
            this.fakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fakeLabel.Location = new System.Drawing.Point(25, 50);
            this.fakeLabel.Name = "fakeLabel";
            this.fakeLabel.Size = new System.Drawing.Size(199, 15);
            this.fakeLabel.TabIndex = 2;
            this.fakeLabel.Text = "Do not install Free™ PC Optimizer :(";
            this.fakeLabel.MouseEnter += new System.EventHandler(this.ball_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thank you for installing our software!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Would you also like to install Free™ PC Optimizer for Free™?";
            // 
            // FakeInstallerForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 351);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(400, 240);
            this.Name = "FakeInstallerForm";
            this.Text = "Totally Legit Software Installer (Patent Pending)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ball;
        private System.Windows.Forms.Timer frameTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton yesOffer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fakeLabel;
    }
}

