namespace Auto_Quartett_WindowsForms
{
    partial class Editor
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
            this.tbMarke = new System.Windows.Forms.TextBox();
            this.tbGeschwindigkeit = new System.Windows.Forms.TextBox();
            this.tbVerbrauch = new System.Windows.Forms.TextBox();
            this.tbZylinder = new System.Windows.Forms.TextBox();
            this.tbLeistung = new System.Windows.Forms.TextBox();
            this.tbLadevolumen = new System.Windows.Forms.TextBox();
            this.tbZuladung = new System.Windows.Forms.TextBox();
            this.tbHubraum = new System.Windows.Forms.TextBox();
            this.tbBeschleunigung = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColMarke = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColModell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColGeschwindigkeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColVerbrauch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColZylinder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLeistung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHubraum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColBeschleunigung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColZuladung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLadevolumen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.tbModell = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMarke
            // 
            this.tbMarke.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarke.Location = new System.Drawing.Point(3, 16);
            this.tbMarke.Name = "tbMarke";
            this.tbMarke.ShortcutsEnabled = false;
            this.tbMarke.Size = new System.Drawing.Size(62, 23);
            this.tbMarke.TabIndex = 0;
            this.tbMarke.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumAndChar_KeyPress);
            // 
            // tbGeschwindigkeit
            // 
            this.tbGeschwindigkeit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGeschwindigkeit.Location = new System.Drawing.Point(3, 57);
            this.tbGeschwindigkeit.Name = "tbGeschwindigkeit";
            this.tbGeschwindigkeit.ShortcutsEnabled = false;
            this.tbGeschwindigkeit.Size = new System.Drawing.Size(62, 23);
            this.tbGeschwindigkeit.TabIndex = 1;
            this.tbGeschwindigkeit.TextChanged += new System.EventHandler(this.tbGeschwindigkeit_TextChanged);
            this.tbGeschwindigkeit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // tbVerbrauch
            // 
            this.tbVerbrauch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVerbrauch.Location = new System.Drawing.Point(3, 102);
            this.tbVerbrauch.Name = "tbVerbrauch";
            this.tbVerbrauch.ShortcutsEnabled = false;
            this.tbVerbrauch.Size = new System.Drawing.Size(62, 23);
            this.tbVerbrauch.TabIndex = 2;
            this.tbVerbrauch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // tbZylinder
            // 
            this.tbZylinder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZylinder.Location = new System.Drawing.Point(3, 147);
            this.tbZylinder.Name = "tbZylinder";
            this.tbZylinder.ShortcutsEnabled = false;
            this.tbZylinder.Size = new System.Drawing.Size(62, 23);
            this.tbZylinder.TabIndex = 3;
            this.tbZylinder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // tbLeistung
            // 
            this.tbLeistung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLeistung.Location = new System.Drawing.Point(3, 193);
            this.tbLeistung.Name = "tbLeistung";
            this.tbLeistung.ShortcutsEnabled = false;
            this.tbLeistung.Size = new System.Drawing.Size(62, 23);
            this.tbLeistung.TabIndex = 4;
            this.tbLeistung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // tbLadevolumen
            // 
            this.tbLadevolumen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLadevolumen.Location = new System.Drawing.Point(212, 193);
            this.tbLadevolumen.Name = "tbLadevolumen";
            this.tbLadevolumen.ShortcutsEnabled = false;
            this.tbLadevolumen.Size = new System.Drawing.Size(62, 23);
            this.tbLadevolumen.TabIndex = 5;
            this.tbLadevolumen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // tbZuladung
            // 
            this.tbZuladung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZuladung.Location = new System.Drawing.Point(212, 144);
            this.tbZuladung.Name = "tbZuladung";
            this.tbZuladung.ShortcutsEnabled = false;
            this.tbZuladung.Size = new System.Drawing.Size(62, 23);
            this.tbZuladung.TabIndex = 6;
            this.tbZuladung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // tbHubraum
            // 
            this.tbHubraum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHubraum.Location = new System.Drawing.Point(212, 57);
            this.tbHubraum.Name = "tbHubraum";
            this.tbHubraum.ShortcutsEnabled = false;
            this.tbHubraum.Size = new System.Drawing.Size(62, 23);
            this.tbHubraum.TabIndex = 7;
            this.tbHubraum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // tbBeschleunigung
            // 
            this.tbBeschleunigung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeschleunigung.Location = new System.Drawing.Point(212, 102);
            this.tbBeschleunigung.Name = "tbBeschleunigung";
            this.tbBeschleunigung.ShortcutsEnabled = false;
            this.tbBeschleunigung.Size = new System.Drawing.Size(62, 23);
            this.tbBeschleunigung.TabIndex = 8;
            this.tbBeschleunigung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColMarke,
            this.ColModell,
            this.ColGeschwindigkeit,
            this.ColVerbrauch,
            this.ColZylinder,
            this.ColLeistung,
            this.ColHubraum,
            this.ColBeschleunigung,
            this.ColZuladung,
            this.ColLadevolumen});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(764, 196);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // ColMarke
            // 
            this.ColMarke.Tag = "";
            this.ColMarke.Text = "Marke";
            this.ColMarke.Width = 70;
            // 
            // ColModell
            // 
            this.ColModell.Text = "Modell";
            this.ColModell.Width = 70;
            // 
            // ColGeschwindigkeit
            // 
            this.ColGeschwindigkeit.Tag = "";
            this.ColGeschwindigkeit.Text = "Geschwindigkeit";
            this.ColGeschwindigkeit.Width = 105;
            // 
            // ColVerbrauch
            // 
            this.ColVerbrauch.Text = "Verbrauch";
            this.ColVerbrauch.Width = 70;
            // 
            // ColZylinder
            // 
            this.ColZylinder.Text = "Zylinder";
            // 
            // ColLeistung
            // 
            this.ColLeistung.Text = "Leistung";
            // 
            // ColHubraum
            // 
            this.ColHubraum.Text = "Hubraum";
            this.ColHubraum.Width = 70;
            // 
            // ColBeschleunigung
            // 
            this.ColBeschleunigung.Text = "Beschleunigung";
            this.ColBeschleunigung.Width = 105;
            // 
            // ColZuladung
            // 
            this.ColZuladung.Text = "Zuladung";
            this.ColZuladung.Width = 70;
            // 
            // ColLadevolumen
            // 
            this.ColLadevolumen.Text = "Ladevolumen";
            this.ColLadevolumen.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Geschwindigkeit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Leistung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Verbrauch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Zylinder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hubraum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Beschleunigung";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Zuladung";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ladevolumen";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.BackColor = System.Drawing.Color.Lime;
            this.btnSpeichern.Location = new System.Drawing.Point(688, 403);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(88, 37);
            this.btnSpeichern.TabIndex = 18;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = false;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // tbModell
            // 
            this.tbModell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModell.Location = new System.Drawing.Point(212, 16);
            this.tbModell.Name = "tbModell";
            this.tbModell.ShortcutsEnabled = false;
            this.tbModell.Size = new System.Drawing.Size(62, 23);
            this.tbModell.TabIndex = 20;
            this.tbModell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumAndChar_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Marke";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbMarke);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbModell);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbGeschwindigkeit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbVerbrauch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbZylinder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbLadevolumen);
            this.panel1.Controls.Add(this.tbZuladung);
            this.panel1.Controls.Add(this.tbBeschleunigung);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbHubraum);
            this.panel1.Controls.Add(this.tbLeistung);
            this.panel1.Location = new System.Drawing.Point(12, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 225);
            this.panel1.TabIndex = 22;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.listView1);
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbMarke;
        private System.Windows.Forms.TextBox tbGeschwindigkeit;
        private System.Windows.Forms.TextBox tbVerbrauch;
        private System.Windows.Forms.TextBox tbZylinder;
        private System.Windows.Forms.TextBox tbLeistung;
        private System.Windows.Forms.TextBox tbLadevolumen;
        private System.Windows.Forms.TextBox tbZuladung;
        private System.Windows.Forms.TextBox tbHubraum;
        private System.Windows.Forms.TextBox tbBeschleunigung;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSpeichern;
        public System.Windows.Forms.ColumnHeader ColMarke;
        private System.Windows.Forms.ColumnHeader ColGeschwindigkeit;
        private System.Windows.Forms.ColumnHeader ColVerbrauch;
        private System.Windows.Forms.ColumnHeader ColZylinder;
        private System.Windows.Forms.ColumnHeader ColLeistung;
        private System.Windows.Forms.ColumnHeader ColHubraum;
        private System.Windows.Forms.ColumnHeader ColBeschleunigung;
        private System.Windows.Forms.ColumnHeader ColZuladung;
        private System.Windows.Forms.ColumnHeader ColLadevolumen;
        private System.Windows.Forms.ColumnHeader ColModell;
        private System.Windows.Forms.TextBox tbModell;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
    }
}