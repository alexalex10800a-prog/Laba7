namespace Rogov_V_3_42x_lab7
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxDep2 = new System.Windows.Forms.ComboBox();
            this.comboBoxSpec2 = new System.Windows.Forms.ComboBox();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(166, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxDep2
            // 
            this.comboBoxDep2.FormattingEnabled = true;
            this.comboBoxDep2.Location = new System.Drawing.Point(49, 235);
            this.comboBoxDep2.Name = "comboBoxDep2";
            this.comboBoxDep2.Size = new System.Drawing.Size(308, 24);
            this.comboBoxDep2.TabIndex = 1;
            // 
            // comboBoxSpec2
            // 
            this.comboBoxSpec2.FormattingEnabled = true;
            this.comboBoxSpec2.Location = new System.Drawing.Point(47, 175);
            this.comboBoxSpec2.Name = "comboBoxSpec2";
            this.comboBoxSpec2.Size = new System.Drawing.Size(308, 24);
            this.comboBoxSpec2.TabIndex = 2;
            // 
            // textBoxName2
            // 
            this.textBoxName2.Location = new System.Drawing.Point(47, 122);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(310, 22);
            this.textBoxName2.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 375);
            this.Controls.Add(this.textBoxName2);
            this.Controls.Add(this.comboBoxSpec2);
            this.Controls.Add(this.comboBoxDep2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBoxDep2;
        public System.Windows.Forms.ComboBox comboBoxSpec2;
        public System.Windows.Forms.TextBox textBoxName2;
    }
}