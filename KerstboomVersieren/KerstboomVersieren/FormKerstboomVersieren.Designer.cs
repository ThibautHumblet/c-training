namespace KerstboomVersieren
{
    partial class FormKerstboomVersieren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKerstboomVersieren));
            this.labelHK = new System.Windows.Forms.Label();
            this.textBoxHoogte = new System.Windows.Forms.TextBox();
            this.buttonBereken = new System.Windows.Forms.Button();
            this.labelAB = new System.Windows.Forms.Label();
            this.labelAantalBallen = new System.Windows.Forms.Label();
            this.labelLengteSlinger = new System.Windows.Forms.Label();
            this.labelLS = new System.Windows.Forms.Label();
            this.labelLengteLicht = new System.Windows.Forms.Label();
            this.labelLL = new System.Windows.Forms.Label();
            this.labelHoogteSter = new System.Windows.Forms.Label();
            this.labelHS = new System.Windows.Forms.Label();
            this.pictureBoxKerstboom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKerstboom)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHK
            // 
            this.labelHK.AutoSize = true;
            this.labelHK.Location = new System.Drawing.Point(22, 23);
            this.labelHK.Name = "labelHK";
            this.labelHK.Size = new System.Drawing.Size(291, 20);
            this.labelHK.TabIndex = 0;
            this.labelHK.Text = "hoogte van de kerstboom in cm:";
            // 
            // textBoxHoogte
            // 
            this.textBoxHoogte.Location = new System.Drawing.Point(251, 20);
            this.textBoxHoogte.Name = "textBoxHoogte";
            this.textBoxHoogte.Size = new System.Drawing.Size(57, 27);
            this.textBoxHoogte.TabIndex = 1;
            // 
            // buttonBereken
            // 
            this.buttonBereken.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonBereken.Location = new System.Drawing.Point(25, 68);
            this.buttonBereken.Name = "buttonBereken";
            this.buttonBereken.Size = new System.Drawing.Size(283, 32);
            this.buttonBereken.TabIndex = 2;
            this.buttonBereken.Text = "Bereken de benodigdheden";
            this.buttonBereken.UseVisualStyleBackColor = true;
            this.buttonBereken.Click += new System.EventHandler(this.buttonBereken_Click);
            // 
            // labelAB
            // 
            this.labelAB.AutoSize = true;
            this.labelAB.Location = new System.Drawing.Point(22, 126);
            this.labelAB.Name = "labelAB";
            this.labelAB.Size = new System.Drawing.Size(171, 20);
            this.labelAB.TabIndex = 0;
            this.labelAB.Text = "aantal kerstballen:";
            // 
            // labelAantalBallen
            // 
            this.labelAantalBallen.AutoSize = true;
            this.labelAantalBallen.Location = new System.Drawing.Point(234, 126);
            this.labelAantalBallen.Name = "labelAantalBallen";
            this.labelAantalBallen.Size = new System.Drawing.Size(45, 20);
            this.labelAantalBallen.TabIndex = 3;
            this.labelAantalBallen.Text = "XXX";
            // 
            // labelLengteSlinger
            // 
            this.labelLengteSlinger.AutoSize = true;
            this.labelLengteSlinger.Location = new System.Drawing.Point(234, 160);
            this.labelLengteSlinger.Name = "labelLengteSlinger";
            this.labelLengteSlinger.Size = new System.Drawing.Size(45, 20);
            this.labelLengteSlinger.TabIndex = 5;
            this.labelLengteSlinger.Text = "XXX";
            // 
            // labelLS
            // 
            this.labelLS.AutoSize = true;
            this.labelLS.Location = new System.Drawing.Point(22, 160);
            this.labelLS.Name = "labelLS";
            this.labelLS.Size = new System.Drawing.Size(242, 20);
            this.labelLS.TabIndex = 4;
            this.labelLS.Text = "lengte van de kerstslinger:";
            // 
            // labelLengteLicht
            // 
            this.labelLengteLicht.AutoSize = true;
            this.labelLengteLicht.Location = new System.Drawing.Point(234, 197);
            this.labelLengteLicht.Name = "labelLengteLicht";
            this.labelLengteLicht.Size = new System.Drawing.Size(45, 20);
            this.labelLengteLicht.TabIndex = 7;
            this.labelLengteLicht.Text = "XXX";
            // 
            // labelLL
            // 
            this.labelLL.AutoSize = true;
            this.labelLL.Location = new System.Drawing.Point(22, 197);
            this.labelLL.Name = "labelLL";
            this.labelLL.Size = new System.Drawing.Size(232, 20);
            this.labelLL.TabIndex = 6;
            this.labelLL.Text = "lengte van het lichtsnoer:";
            // 
            // labelHoogteSter
            // 
            this.labelHoogteSter.AutoSize = true;
            this.labelHoogteSter.Location = new System.Drawing.Point(234, 235);
            this.labelHoogteSter.Name = "labelHoogteSter";
            this.labelHoogteSter.Size = new System.Drawing.Size(45, 20);
            this.labelHoogteSter.TabIndex = 9;
            this.labelHoogteSter.Text = "XXX";
            // 
            // labelHS
            // 
            this.labelHS.AutoSize = true;
            this.labelHS.Location = new System.Drawing.Point(22, 235);
            this.labelHS.Name = "labelHS";
            this.labelHS.Size = new System.Drawing.Size(222, 20);
            this.labelHS.TabIndex = 8;
            this.labelHS.Text = "hoogte van de kerstster:";
            // 
            // pictureBoxKerstboom
            // 
            this.pictureBoxKerstboom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKerstboom.Image")));
            this.pictureBoxKerstboom.Location = new System.Drawing.Point(335, 20);
            this.pictureBoxKerstboom.Name = "pictureBoxKerstboom";
            this.pictureBoxKerstboom.Size = new System.Drawing.Size(200, 231);
            this.pictureBoxKerstboom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKerstboom.TabIndex = 10;
            this.pictureBoxKerstboom.TabStop = false;
            // 
            // FormKerstboomVersieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(559, 284);
            this.Controls.Add(this.pictureBoxKerstboom);
            this.Controls.Add(this.labelHoogteSter);
            this.Controls.Add(this.labelHS);
            this.Controls.Add(this.labelLengteLicht);
            this.Controls.Add(this.labelLL);
            this.Controls.Add(this.labelLengteSlinger);
            this.Controls.Add(this.labelLS);
            this.Controls.Add(this.labelAantalBallen);
            this.Controls.Add(this.buttonBereken);
            this.Controls.Add(this.textBoxHoogte);
            this.Controls.Add(this.labelAB);
            this.Controls.Add(this.labelHK);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKerstboomVersieren";
            this.Text = "Benodigdheden voor de perfect versierde kerstboom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKerstboom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHK;
        private System.Windows.Forms.TextBox textBoxHoogte;
        private System.Windows.Forms.Button buttonBereken;
        private System.Windows.Forms.Label labelAB;
        private System.Windows.Forms.Label labelAantalBallen;
        private System.Windows.Forms.Label labelLengteSlinger;
        private System.Windows.Forms.Label labelLS;
        private System.Windows.Forms.Label labelLengteLicht;
        private System.Windows.Forms.Label labelLL;
        private System.Windows.Forms.Label labelHoogteSter;
        private System.Windows.Forms.Label labelHS;
        private System.Windows.Forms.PictureBox pictureBoxKerstboom;
    }
}

