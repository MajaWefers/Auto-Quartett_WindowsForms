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
            this.SuspendLayout();
            // 
            // SpielButton
            // 
            this.SpielButton.Location = new System.Drawing.Point(197, 54);
            this.SpielButton.Name = "SpielButton";
            this.SpielButton.Size = new System.Drawing.Size(75, 23);
            this.SpielButton.TabIndex = 0;
            this.SpielButton.Text = "Spiel";
            this.SpielButton.UseVisualStyleBackColor = true;
            this.SpielButton.Click += new System.EventHandler(this.SpielButton_Click);
            // 
            // EditorButton
            // 
            this.EditorButton.Location = new System.Drawing.Point(197, 104);
            this.EditorButton.Name = "EditorButton";
            this.EditorButton.Size = new System.Drawing.Size(75, 23);
            this.EditorButton.TabIndex = 1;
            this.EditorButton.Text = "Editor";
            this.EditorButton.UseVisualStyleBackColor = true;
            this.EditorButton.Click += new System.EventHandler(this.EditorButton_Click);
            // 
            // BeendenButton
            // 
            this.BeendenButton.Location = new System.Drawing.Point(197, 154);
            this.BeendenButton.Name = "BeendenButton";
            this.BeendenButton.Size = new System.Drawing.Size(75, 23);
            this.BeendenButton.TabIndex = 2;
            this.BeendenButton.Text = "Beenden";
            this.BeendenButton.UseVisualStyleBackColor = true;
            this.BeendenButton.Click += new System.EventHandler(this.BeendenButton_Click);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 210);
            this.Controls.Add(this.BeendenButton);
            this.Controls.Add(this.EditorButton);
            this.Controls.Add(this.SpielButton);
            this.Name = "Menü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SpielButton;
        private System.Windows.Forms.Button EditorButton;
        private System.Windows.Forms.Button BeendenButton;
    }
}