namespace ColorGetter
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HexLabel = new System.Windows.Forms.Label();
            this.ColorPicBox = new System.Windows.Forms.PictureBox();
            this.TopmostCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "R:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "G:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "B:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.RLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RLabel.Location = new System.Drawing.Point(105, 23);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(39, 42);
            this.RLabel.TabIndex = 3;
            this.RLabel.Text = "0";
            this.RLabel.Click += new System.EventHandler(this.RLabel_Click);
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.BLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.BLabel.Location = new System.Drawing.Point(105, 175);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(39, 42);
            this.BLabel.TabIndex = 4;
            this.BLabel.Text = "0";
            this.BLabel.Click += new System.EventHandler(this.BLabel_Click);
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.GLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GLabel.Location = new System.Drawing.Point(105, 99);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(39, 42);
            this.GLabel.TabIndex = 5;
            this.GLabel.Text = "0";
            this.GLabel.Click += new System.EventHandler(this.GLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.WindowText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(29, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hex:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // HexLabel
            // 
            this.HexLabel.AutoSize = true;
            this.HexLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.HexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HexLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.HexLabel.Location = new System.Drawing.Point(148, 262);
            this.HexLabel.Name = "HexLabel";
            this.HexLabel.Size = new System.Drawing.Size(39, 42);
            this.HexLabel.TabIndex = 7;
            this.HexLabel.Text = "0";
            this.HexLabel.Click += new System.EventHandler(this.HexLabel_Click);
            // 
            // ColorPicBox
            // 
            this.ColorPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPicBox.Location = new System.Drawing.Point(219, 87);
            this.ColorPicBox.Name = "ColorPicBox";
            this.ColorPicBox.Size = new System.Drawing.Size(100, 84);
            this.ColorPicBox.TabIndex = 9;
            this.ColorPicBox.TabStop = false;
            // 
            // TopmostCheckBox
            // 
            this.TopmostCheckBox.AutoSize = true;
            this.TopmostCheckBox.Checked = true;
            this.TopmostCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TopmostCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TopmostCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.TopmostCheckBox.Location = new System.Drawing.Point(219, 210);
            this.TopmostCheckBox.Name = "TopmostCheckBox";
            this.TopmostCheckBox.Size = new System.Drawing.Size(114, 29);
            this.TopmostCheckBox.TabIndex = 11;
            this.TopmostCheckBox.Text = "Topmost";
            this.TopmostCheckBox.UseVisualStyleBackColor = true;
            this.TopmostCheckBox.CheckedChanged += new System.EventHandler(this.TopmostCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(356, 354);
            this.Controls.Add(this.TopmostCheckBox);
            this.Controls.Add(this.ColorPicBox);
            this.Controls.Add(this.HexLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GLabel);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Global color getter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColorPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HexLabel;
        private System.Windows.Forms.PictureBox ColorPicBox;
        private System.Windows.Forms.CheckBox TopmostCheckBox;
    }
}

