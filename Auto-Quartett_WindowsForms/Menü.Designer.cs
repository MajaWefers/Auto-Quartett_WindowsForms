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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEditor = new System.Windows.Forms.Label();
            this.lblGallerie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbMenueSpiel = new System.Windows.Forms.PictureBox();
            this.GallerieButton = new System.Windows.Forms.Button();
            this.BeendenButton = new System.Windows.Forms.Button();
            this.EditorButton = new System.Windows.Forms.Button();
            this.SpielButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenueSpiel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEditor);
            this.panel1.Controls.Add(this.lblGallerie);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pbMenueSpiel);
            this.panel1.Controls.Add(this.GallerieButton);
            this.panel1.Controls.Add(this.BeendenButton);
            this.panel1.Controls.Add(this.EditorButton);
            this.panel1.Controls.Add(this.SpielButton);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 278);
            this.panel1.TabIndex = 0;
            // 
            // lblEditor
            // 
            this.lblEditor.BackColor = System.Drawing.Color.White;
            this.lblEditor.Location = new System.Drawing.Point(292, 161);
            this.lblEditor.Name = "lblEditor";
            this.lblEditor.Size = new System.Drawing.Size(103, 31);
            this.lblEditor.TabIndex = 23;
            this.lblEditor.Text = "Erstellen neuer Karten";
            this.lblEditor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGallerie
            // 
            this.lblGallerie.BackColor = System.Drawing.Color.White;
            this.lblGallerie.Location = new System.Drawing.Point(156, 161);
            this.lblGallerie.Name = "lblGallerie";
            this.lblGallerie.Size = new System.Drawing.Size(104, 31);
            this.lblGallerie.TabIndex = 22;
            this.lblGallerie.Text = "Ansicht aller Quartettkarten";
            this.lblGallerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 43);
            this.label1.TabIndex = 21;
            this.label1.Text = "Spiel gegen den Computer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Auto_Quartett_WindowsForms.Properties.Resources.menue_editor;
            this.pictureBox2.Location = new System.Drawing.Point(293, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Auto_Quartett_WindowsForms.Properties.Resources.menue_gallerie;
            this.pictureBox1.Location = new System.Drawing.Point(157, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pbMenueSpiel
            // 
            this.pbMenueSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMenueSpiel.Image = global::Auto_Quartett_WindowsForms.Properties.Resources.menue_spiel;
            this.pbMenueSpiel.Location = new System.Drawing.Point(17, 53);
            this.pbMenueSpiel.Name = "pbMenueSpiel";
            this.pbMenueSpiel.Size = new System.Drawing.Size(102, 99);
            this.pbMenueSpiel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenueSpiel.TabIndex = 18;
            this.pbMenueSpiel.TabStop = false;
            // 
            // GallerieButton
            // 
            this.GallerieButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GallerieButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GallerieButton.BackColor = System.Drawing.Color.Yellow;
            this.GallerieButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GallerieButton.Location = new System.Drawing.Point(156, 10);
            this.GallerieButton.Name = "GallerieButton";
            this.GallerieButton.Size = new System.Drawing.Size(103, 37);
            this.GallerieButton.TabIndex = 15;
            this.GallerieButton.Text = "Gallerie";
            this.GallerieButton.UseVisualStyleBackColor = false;
            this.GallerieButton.Click += new System.EventHandler(this.GallerieButton_Click);
            // 
            // BeendenButton
            // 
            this.BeendenButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BeendenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BeendenButton.BackColor = System.Drawing.Color.White;
            this.BeendenButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeendenButton.Location = new System.Drawing.Point(157, 226);
            this.BeendenButton.Name = "BeendenButton";
            this.BeendenButton.Size = new System.Drawing.Size(102, 37);
            this.BeendenButton.TabIndex = 17;
            this.BeendenButton.Text = "Beenden";
            this.BeendenButton.UseVisualStyleBackColor = false;
            this.BeendenButton.Click += new System.EventHandler(this.BeendenButton_Click);
            // 
            // EditorButton
            // 
            this.EditorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditorButton.BackColor = System.Drawing.Color.Red;
            this.EditorButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorButton.Location = new System.Drawing.Point(292, 10);
            this.EditorButton.Name = "EditorButton";
            this.EditorButton.Size = new System.Drawing.Size(103, 37);
            this.EditorButton.TabIndex = 16;
            this.EditorButton.Text = "Editor";
            this.EditorButton.UseVisualStyleBackColor = false;
            this.EditorButton.Click += new System.EventHandler(this.EditorButton_Click);
            // 
            // SpielButton
            // 
            this.SpielButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SpielButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SpielButton.BackColor = System.Drawing.Color.Lime;
            this.SpielButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpielButton.Location = new System.Drawing.Point(17, 10);
            this.SpielButton.Name = "SpielButton";
            this.SpielButton.Size = new System.Drawing.Size(102, 37);
            this.SpielButton.TabIndex = 14;
            this.SpielButton.Text = "Spiel";
            this.SpielButton.UseVisualStyleBackColor = false;
            this.SpielButton.Click += new System.EventHandler(this.SpielButton_Click);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 298);
            this.Controls.Add(this.panel1);
            this.Name = "Menü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Quartett";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenueSpiel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEditor;
        private System.Windows.Forms.Label lblGallerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbMenueSpiel;
        private System.Windows.Forms.Button GallerieButton;
        private System.Windows.Forms.Button BeendenButton;
        private System.Windows.Forms.Button EditorButton;
        private System.Windows.Forms.Button SpielButton;
    }
}