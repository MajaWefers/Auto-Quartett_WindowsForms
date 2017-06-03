namespace Auto_Quartett_WindowsForms
{
    partial class Menü
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
            this.SpielButton = new System.Windows.Forms.Button();
            this.EditorButton = new System.Windows.Forms.Button();
            this.BeendenButton = new System.Windows.Forms.Button();
            this.GallerieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpielButton
            // 
            this.SpielButton.BackColor = System.Drawing.Color.Lime;
            this.SpielButton.Location = new System.Drawing.Point(184, 36);
            this.SpielButton.Name = "SpielButton";
            this.SpielButton.Size = new System.Drawing.Size(88, 37);
            this.SpielButton.TabIndex = 0;
            this.SpielButton.Text = "Spiel";
            this.SpielButton.UseVisualStyleBackColor = false;
            this.SpielButton.Click += new System.EventHandler(this.SpielButton_Click);
            // 
            // EditorButton
            // 
            this.EditorButton.BackColor = System.Drawing.Color.Yellow;
            this.EditorButton.Location = new System.Drawing.Point(269, 86);
            this.EditorButton.Name = "EditorButton";
            this.EditorButton.Size = new System.Drawing.Size(86, 37);
            this.EditorButton.TabIndex = 2;
            this.EditorButton.Text = "Editor";
            this.EditorButton.UseVisualStyleBackColor = false;
            this.EditorButton.Click += new System.EventHandler(this.EditorButton_Click);
            // 
            // BeendenButton
            // 
            this.BeendenButton.BackColor = System.Drawing.Color.LightCoral;
            this.BeendenButton.Location = new System.Drawing.Point(184, 141);
            this.BeendenButton.Name = "BeendenButton";
            this.BeendenButton.Size = new System.Drawing.Size(88, 37);
            this.BeendenButton.TabIndex = 3;
            this.BeendenButton.Text = "Beenden";
            this.BeendenButton.UseVisualStyleBackColor = false;
            this.BeendenButton.Click += new System.EventHandler(this.BeendenButton_Click);
            // 
            // GallerieButton
            // 
            this.GallerieButton.BackColor = System.Drawing.Color.Yellow;
            this.GallerieButton.Location = new System.Drawing.Point(104, 86);
            this.GallerieButton.Name = "GallerieButton";
            this.GallerieButton.Size = new System.Drawing.Size(86, 37);
            this.GallerieButton.TabIndex = 1;
            this.GallerieButton.Text = "Gallerie";
            this.GallerieButton.UseVisualStyleBackColor = false;
            this.GallerieButton.Click += new System.EventHandler(this.GallerieButton_Click);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 210);
            this.Controls.Add(this.GallerieButton);
            this.Controls.Add(this.BeendenButton);
            this.Controls.Add(this.EditorButton);
            this.Controls.Add(this.SpielButton);
            this.Name = "Menü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Quartett";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SpielButton;
        private System.Windows.Forms.Button EditorButton;
        private System.Windows.Forms.Button BeendenButton;
        private System.Windows.Forms.Button GallerieButton;
    }
}