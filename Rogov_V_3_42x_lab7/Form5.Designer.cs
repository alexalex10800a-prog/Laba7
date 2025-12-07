namespace Rogov_V_3_42x_lab7
{
    partial class Form5
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
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Location = new System.Drawing.Point(78, 101);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(260, 24);
            this.comboBoxDep.TabIndex = 0;
            // 
            // btnOK2
            // 
            this.btnOK2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK2.Location = new System.Drawing.Point(154, 219);
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.Size = new System.Drawing.Size(101, 23);
            this.btnOK2.TabIndex = 1;
            this.btnOK2.Text = "OK";
            this.btnOK2.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 325);
            this.Controls.Add(this.btnOK2);
            this.Controls.Add(this.comboBoxDep);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxDep;
        public System.Windows.Forms.Button btnOK2;
    }
}