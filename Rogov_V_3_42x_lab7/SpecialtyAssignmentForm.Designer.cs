namespace Rogov_V_3_42x_lab7
{
    partial class SpecialtyAssignmentForm
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
            this.comboBoxSpecialties = new System.Windows.Forms.ComboBox();
            this.labelEmployee = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCurrentSpecialty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxSpecialties
            // 
            this.comboBoxSpecialties.FormattingEnabled = true;
            this.comboBoxSpecialties.Location = new System.Drawing.Point(54, 125);
            this.comboBoxSpecialties.Name = "comboBoxSpecialties";
            this.comboBoxSpecialties.Size = new System.Drawing.Size(248, 24);
            this.comboBoxSpecialties.TabIndex = 0;
            // 
            // labelEmployee
            // 
            this.labelEmployee.Location = new System.Drawing.Point(54, 49);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(248, 22);
            this.labelEmployee.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(139, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelCurrentSpecialty
            // 
            this.labelCurrentSpecialty.Location = new System.Drawing.Point(54, 87);
            this.labelCurrentSpecialty.Name = "labelCurrentSpecialty";
            this.labelCurrentSpecialty.Size = new System.Drawing.Size(248, 22);
            this.labelCurrentSpecialty.TabIndex = 3;
            // 
            // SpecialtyAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 250);
            this.Controls.Add(this.labelCurrentSpecialty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.comboBoxSpecialties);
            this.Name = "SpecialtyAssignmentForm";
            this.Text = "SpecialtyAssignmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBoxSpecialties;
        public System.Windows.Forms.TextBox labelEmployee;
        public System.Windows.Forms.TextBox labelCurrentSpecialty;
    }
}