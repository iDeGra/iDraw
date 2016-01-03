namespace iDraw {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.drawPanel = new System.Windows.Forms.Panel();
            this.GreenColorButton = new System.Windows.Forms.Button();
            this.BlueColorButton = new System.Windows.Forms.Button();
            this.RedColorButton = new System.Windows.Forms.Button();
            this.drawPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.Controls.Add(this.GreenColorButton);
            this.drawPanel.Controls.Add(this.BlueColorButton);
            this.drawPanel.Controls.Add(this.RedColorButton);
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPanel.Location = new System.Drawing.Point(0, 0);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(284, 262);
            this.drawPanel.TabIndex = 0;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            // 
            // GreenColorButton
            // 
            this.GreenColorButton.BackColor = System.Drawing.Color.Green;
            this.GreenColorButton.Location = new System.Drawing.Point(0, 29);
            this.GreenColorButton.Margin = new System.Windows.Forms.Padding(0);
            this.GreenColorButton.Name = "GreenColorButton";
            this.GreenColorButton.Size = new System.Drawing.Size(20, 20);
            this.GreenColorButton.TabIndex = 2;
            this.GreenColorButton.UseVisualStyleBackColor = false;
            this.GreenColorButton.Click += new System.EventHandler(this.GreenColorButton_Click);
            // 
            // BlueColorButton
            // 
            this.BlueColorButton.BackColor = System.Drawing.Color.Blue;
            this.BlueColorButton.Location = new System.Drawing.Point(0, 49);
            this.BlueColorButton.Margin = new System.Windows.Forms.Padding(0);
            this.BlueColorButton.Name = "BlueColorButton";
            this.BlueColorButton.Size = new System.Drawing.Size(20, 20);
            this.BlueColorButton.TabIndex = 1;
            this.BlueColorButton.UseVisualStyleBackColor = false;
            this.BlueColorButton.Click += new System.EventHandler(this.BlueColorButton_Click);
            // 
            // RedColorButton
            // 
            this.RedColorButton.BackColor = System.Drawing.Color.Red;
            this.RedColorButton.Location = new System.Drawing.Point(0, 9);
            this.RedColorButton.Margin = new System.Windows.Forms.Padding(0);
            this.RedColorButton.Name = "RedColorButton";
            this.RedColorButton.Size = new System.Drawing.Size(20, 20);
            this.RedColorButton.TabIndex = 0;
            this.RedColorButton.UseVisualStyleBackColor = false;
            this.RedColorButton.Click += new System.EventHandler(this.RedColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.drawPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.drawPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Button GreenColorButton;
        private System.Windows.Forms.Button BlueColorButton;
        private System.Windows.Forms.Button RedColorButton;
    }
}

