namespace Toetsniveau
{
    partial class FormToetsniveau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToetsniveau));
            this.textBoxBehaald = new System.Windows.Forms.TextBox();
            this.labelBehaald = new System.Windows.Forms.Label();
            this.labelMaximum = new System.Windows.Forms.Label();
            this.buttonBepaal = new System.Windows.Forms.Button();
            this.listBoxMaximum = new System.Windows.Forms.ListBox();
            this.checkBoxCommentaar = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBoxBonus = new System.Windows.Forms.GroupBox();
            this.labelNiveau = new System.Windows.Forms.Label();
            this.labelCommentaar = new System.Windows.Forms.Label();
            this.groupBoxBonus.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBehaald
            // 
            this.textBoxBehaald.Location = new System.Drawing.Point(226, 29);
            this.textBoxBehaald.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBehaald.Name = "textBoxBehaald";
            this.textBoxBehaald.Size = new System.Drawing.Size(68, 27);
            this.textBoxBehaald.TabIndex = 0;
            this.textBoxBehaald.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelBehaald
            // 
            this.labelBehaald.AutoSize = true;
            this.labelBehaald.Location = new System.Drawing.Point(55, 32);
            this.labelBehaald.Name = "labelBehaald";
            this.labelBehaald.Size = new System.Drawing.Size(139, 20);
            this.labelBehaald.TabIndex = 1;
            this.labelBehaald.Text = "Behaalde score";
            // 
            // labelMaximum
            // 
            this.labelMaximum.AutoSize = true;
            this.labelMaximum.Location = new System.Drawing.Point(55, 73);
            this.labelMaximum.Name = "labelMaximum";
            this.labelMaximum.Size = new System.Drawing.Size(138, 20);
            this.labelMaximum.TabIndex = 2;
            this.labelMaximum.Text = "Maximumscore";
            // 
            // buttonBepaal
            // 
            this.buttonBepaal.Location = new System.Drawing.Point(47, 225);
            this.buttonBepaal.Name = "buttonBepaal";
            this.buttonBepaal.Size = new System.Drawing.Size(195, 36);
            this.buttonBepaal.TabIndex = 3;
            this.buttonBepaal.Text = "Bepaal het niveau";
            this.buttonBepaal.UseVisualStyleBackColor = true;
            this.buttonBepaal.Click += new System.EventHandler(this.buttonBepaal_Click);
            // 
            // listBoxMaximum
            // 
            this.listBoxMaximum.FormattingEnabled = true;
            this.listBoxMaximum.ItemHeight = 18;
            this.listBoxMaximum.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "100"});
            this.listBoxMaximum.Location = new System.Drawing.Point(226, 73);
            this.listBoxMaximum.Name = "listBoxMaximum";
            this.listBoxMaximum.Size = new System.Drawing.Size(68, 40);
            this.listBoxMaximum.TabIndex = 5;
            // 
            // checkBoxCommentaar
            // 
            this.checkBoxCommentaar.AutoSize = true;
            this.checkBoxCommentaar.Location = new System.Drawing.Point(58, 291);
            this.checkBoxCommentaar.Name = "checkBoxCommentaar";
            this.checkBoxCommentaar.Size = new System.Drawing.Size(184, 24);
            this.checkBoxCommentaar.TabIndex = 6;
            this.checkBoxCommentaar.Tag = "";
            this.checkBoxCommentaar.Text = "Toon commentaar";
            this.checkBoxCommentaar.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(104, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(192, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(41, 24);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBoxBonus
            // 
            this.groupBoxBonus.Controls.Add(this.radioButton1);
            this.groupBoxBonus.Controls.Add(this.radioButton3);
            this.groupBoxBonus.Controls.Add(this.radioButton2);
            this.groupBoxBonus.Location = new System.Drawing.Point(47, 148);
            this.groupBoxBonus.Name = "groupBoxBonus";
            this.groupBoxBonus.Size = new System.Drawing.Size(247, 53);
            this.groupBoxBonus.TabIndex = 10;
            this.groupBoxBonus.TabStop = false;
            this.groupBoxBonus.Text = "Extra bonuspunten";
            // 
            // labelNiveau
            // 
            this.labelNiveau.AutoSize = true;
            this.labelNiveau.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNiveau.Location = new System.Drawing.Point(271, 229);
            this.labelNiveau.Name = "labelNiveau";
            this.labelNiveau.Size = new System.Drawing.Size(29, 29);
            this.labelNiveau.TabIndex = 11;
            this.labelNiveau.Text = "X";
            // 
            // labelCommentaar
            // 
            this.labelCommentaar.AutoSize = true;
            this.labelCommentaar.Location = new System.Drawing.Point(55, 334);
            this.labelCommentaar.Name = "labelCommentaar";
            this.labelCommentaar.Size = new System.Drawing.Size(45, 20);
            this.labelCommentaar.TabIndex = 12;
            this.labelCommentaar.Text = "XXX";
            this.labelCommentaar.Visible = false;
            // 
            // FormToetsniveau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(388, 377);
            this.Controls.Add(this.labelCommentaar);
            this.Controls.Add(this.labelNiveau);
            this.Controls.Add(this.groupBoxBonus);
            this.Controls.Add(this.checkBoxCommentaar);
            this.Controls.Add(this.listBoxMaximum);
            this.Controls.Add(this.buttonBepaal);
            this.Controls.Add(this.labelMaximum);
            this.Controls.Add(this.labelBehaald);
            this.Controls.Add(this.textBoxBehaald);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormToetsniveau";
            this.Text = "Toetsniveau bepalen";
            this.groupBoxBonus.ResumeLayout(false);
            this.groupBoxBonus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBehaald;
        private System.Windows.Forms.Label labelBehaald;
        private System.Windows.Forms.Label labelMaximum;
        private System.Windows.Forms.Button buttonBepaal;
        private System.Windows.Forms.ListBox listBoxMaximum;
        private System.Windows.Forms.CheckBox checkBoxCommentaar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBoxBonus;
        private System.Windows.Forms.Label labelNiveau;
        private System.Windows.Forms.Label labelCommentaar;
    }
}

