namespace Rogov_V_3_42x_lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSpecSave = new System.Windows.Forms.Button();
            this.btnSpecDelete = new System.Windows.Forms.Button();
            this.btnSpecUpdate = new System.Windows.Forms.Button();
            this.btnSpecAdd = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnProc = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnLinq = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.departmentDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeProjectsDTOSource = new System.Windows.Forms.BindingSource(this.components);
            this.DepartmentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyDTOBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProjectsDTOSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "specialty";
            this.dataGridViewComboBoxColumn1.HeaderText = "specialty";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Width = 125;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "specialty";
            this.dataGridViewComboBoxColumn2.HeaderText = "specialty";
            this.dataGridViewComboBoxColumn2.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(693, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(693, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(693, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(23, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 403);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnTransfer);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "БФ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(693, 234);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(94, 23);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "Перевод";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(693, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.departmentComboBox,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.empBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 343);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn1.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DataPropertyName = "DepartmentCode";
            this.departmentComboBox.DataSource = this.empBindingSource;
            this.departmentComboBox.HeaderText = "DepartmentCode";
            this.departmentComboBox.MinimumWidth = 6;
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.departmentComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.departmentComboBox.ValueMember = "DepartmentCode";
            this.departmentComboBox.Width = 125;
            // 
            // empBindingSource
            // 
            this.empBindingSource.DataSource = typeof(BLL7.models.EmployeeDTO);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SpecialtyCode";
            this.dataGridViewTextBoxColumn2.DataSource = this.empBindingSource;
            this.dataGridViewTextBoxColumn2.HeaderText = "SpecialtyCode";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnSpecSave);
            this.tabPage4.Controls.Add(this.btnSpecDelete);
            this.tabPage4.Controls.Add(this.btnSpecUpdate);
            this.tabPage4.Controls.Add(this.btnSpecAdd);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(803, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "specialties";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSpecSave
            // 
            this.btnSpecSave.Location = new System.Drawing.Point(650, 191);
            this.btnSpecSave.Name = "btnSpecSave";
            this.btnSpecSave.Size = new System.Drawing.Size(128, 23);
            this.btnSpecSave.TabIndex = 4;
            this.btnSpecSave.Text = "Сохранить";
            this.btnSpecSave.UseVisualStyleBackColor = true;
            this.btnSpecSave.Click += new System.EventHandler(this.btnSpecSave_Click);
            // 
            // btnSpecDelete
            // 
            this.btnSpecDelete.Location = new System.Drawing.Point(650, 133);
            this.btnSpecDelete.Name = "btnSpecDelete";
            this.btnSpecDelete.Size = new System.Drawing.Size(128, 23);
            this.btnSpecDelete.TabIndex = 3;
            this.btnSpecDelete.Text = "Удалить";
            this.btnSpecDelete.UseVisualStyleBackColor = true;
            this.btnSpecDelete.Click += new System.EventHandler(this.btnSpecDelete_Click);
            // 
            // btnSpecUpdate
            // 
            this.btnSpecUpdate.Location = new System.Drawing.Point(650, 75);
            this.btnSpecUpdate.Name = "btnSpecUpdate";
            this.btnSpecUpdate.Size = new System.Drawing.Size(128, 23);
            this.btnSpecUpdate.TabIndex = 2;
            this.btnSpecUpdate.Text = "Изменить";
            this.btnSpecUpdate.UseVisualStyleBackColor = true;
            this.btnSpecUpdate.Click += new System.EventHandler(this.btnSpecUpdate_Click);
            // 
            // btnSpecAdd
            // 
            this.btnSpecAdd.Location = new System.Drawing.Point(650, 21);
            this.btnSpecAdd.Name = "btnSpecAdd";
            this.btnSpecAdd.Size = new System.Drawing.Size(128, 23);
            this.btnSpecAdd.TabIndex = 1;
            this.btnSpecAdd.Text = "Добавить";
            this.btnSpecAdd.UseVisualStyleBackColor = true;
            this.btnSpecAdd.Click += new System.EventHandler(this.btnSpecAdd_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView4.DataSource = this.specialtyDTOBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(6, 21);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(622, 330);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SpecialtyName";
            this.dataGridViewTextBoxColumn4.HeaderText = "SpecialtyName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // specialtyDTOBindingSource
            // 
            this.specialtyDTOBindingSource.DataSource = typeof(BLL7.models.SpecialtyDTO);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnProc);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LINQ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(7, 20);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(123, 23);
            this.btnProc.TabIndex = 1;
            this.btnProc.Text = "Запрос";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(755, 299);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnLinq);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(803, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Procedure";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnLinq
            // 
            this.btnLinq.Location = new System.Drawing.Point(19, 29);
            this.btnLinq.Name = "btnLinq";
            this.btnLinq.Size = new System.Drawing.Size(107, 23);
            this.btnLinq.TabIndex = 1;
            this.btnLinq.Text = "Процедура";
            this.btnLinq.UseVisualStyleBackColor = true;
            this.btnLinq.Click += new System.EventHandler(this.btnLinq_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmentCode,
            this.SpecialtyCode,
            this.FullName,
            this.SpecialtyName,
            this.departmentNameDataGridViewTextBoxColumn,
            this.ParticipationStatus,
            this.ProjectCode});
            this.dataGridView3.DataSource = this.EmployeeProjectsDTOSource;
            this.dataGridView3.Location = new System.Drawing.Point(19, 69);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(767, 289);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // departmentDTOBindingSource
            // 
            this.departmentDTOBindingSource.DataSource = typeof(BLL7.models.DepartmentDTO);
            // 
            // EmployeeProjectsDTOSource
            // 
            this.EmployeeProjectsDTOSource.DataSource = typeof(BLL7.models.EmployeeProjectsDTO);
            // 
            // DepartmentCode
            // 
            this.DepartmentCode.DataPropertyName = "DepartmentCode";
            this.DepartmentCode.HeaderText = "DepartmentCode";
            this.DepartmentCode.MinimumWidth = 6;
            this.DepartmentCode.Name = "DepartmentCode";
            this.DepartmentCode.Visible = false;
            this.DepartmentCode.Width = 125;
            // 
            // SpecialtyCode
            // 
            this.SpecialtyCode.DataPropertyName = "SpecialtyCode";
            this.SpecialtyCode.HeaderText = "SpecialtyCode";
            this.SpecialtyCode.MinimumWidth = 6;
            this.SpecialtyCode.Name = "SpecialtyCode";
            this.SpecialtyCode.Visible = false;
            this.SpecialtyCode.Width = 125;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "FullName";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 125;
            // 
            // SpecialtyName
            // 
            this.SpecialtyName.DataPropertyName = "SpecialtyName";
            this.SpecialtyName.HeaderText = "SpecialtyName";
            this.SpecialtyName.MinimumWidth = 6;
            this.SpecialtyName.Name = "SpecialtyName";
            this.SpecialtyName.Width = 125;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ParticipationStatus
            // 
            this.ParticipationStatus.DataPropertyName = "ParticipationStatus";
            this.ParticipationStatus.HeaderText = "ParticipationStatus";
            this.ParticipationStatus.MinimumWidth = 6;
            this.ParticipationStatus.Name = "ParticipationStatus";
            this.ParticipationStatus.Width = 125;
            // 
            // ProjectCode
            // 
            this.ProjectCode.DataPropertyName = "ProjectCode";
            this.ProjectCode.HeaderText = "ProjectCode";
            this.ProjectCode.MinimumWidth = 6;
            this.ProjectCode.Name = "ProjectCode";
            this.ProjectCode.ReadOnly = true;
            this.ProjectCode.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 457);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Организация";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyDTOBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProjectsDTOSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn specialtycodeFK1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn departmentcodeFK2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnLinq;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSpecSave;
        private System.Windows.Forms.Button btnSpecDelete;
        private System.Windows.Forms.Button btnSpecUpdate;
        private System.Windows.Forms.Button btnSpecAdd;
        private System.Windows.Forms.BindingSource empBindingSource;
        private System.Windows.Forms.BindingSource departmentDTOBindingSource;
        private System.Windows.Forms.BindingSource specialtyDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn departmentComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource EmployeeProjectsDTOSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipationStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectCode;
    }
}

