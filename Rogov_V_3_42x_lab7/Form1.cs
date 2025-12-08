using BLL7;
using BLL7.models;
using BLL7.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourProject.BLL7.Services;
using BLL7.Interface;

namespace Rogov_V_3_42x_lab7
{

    // UI/Form1.cs
    public partial class Form1 : Form
    {
        private EmployeeSpecialtyService _specialtyService;
        private readonly EmployeeTransferService _transferService;

        //DBDataOperations _dbOperations = new DBDataOperations();
        IDbCrud _dbOperations;
        IReportService _reportService;

        private List<SpecialtyDTO> _allSpecialties;
        private List<DepartmentDTO> _allDepartments;
        private List<EmployeeDTO> _allEmployees;
        private BindingList<EmployeeDTO> _employees;

        public Form1(IDbCrud crudDB, IReportService reportService)
        {
            InitializeComponent();
            _dbOperations = crudDB;
            _reportService = reportService;
            LoadAllData();

        }
        
        private void LoadAllData()
        {
            // Load lookup data first
            _allSpecialties = _dbOperations.GetAllSpecialties();
            _allDepartments = _dbOperations.GetAllDepartments();
            _specialtyService = new EmployeeSpecialtyService();
            LoadEmployees();
            LoadSpecialties();
            LoadDepartments();

        }


        private void LoadEmployees()
        {
            _allEmployees = _dbOperations.GetAllEmployees();
            empBindingSource.DataSource = _allEmployees;
            Console.WriteLine("=== DATA GRID VIEW COLUMNS ===");
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                Console.WriteLine($"Column: '{column.Name}', Type: {column.GetType().Name}");
            }
            FillDepartmentComboBox();
            FillSpecialtyComboBox();
        }
        public void FillDepartmentComboBox()
        {
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["departmentComboBox"]).DataSource = _allDepartments;
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["departmentComboBox"]).DisplayMember = "DepartmentName";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["departmentComboBox"]).ValueMember = "ID";
        }
        public void FillSpecialtyComboBox()
        {
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["dataGridViewTextBoxColumn2"]).DataSource = _allSpecialties;
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["dataGridViewTextBoxColumn2"]).DisplayMember = "SpecialtyName";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["dataGridViewTextBoxColumn2"]).ValueMember = "ID";
        }
        private void LoadSpecialties()
        {
            _allSpecialties = _dbOperations.GetAllSpecialties();
            specialtyDTOBindingSource.DataSource = _allSpecialties;
        }
        private void LoadDepartments()
        {
            _allDepartments = _dbOperations.GetAllDepartments();
            departmentDTOBindingSource.DataSource = _allDepartments;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.comboBoxSpec.DataSource = _allSpecialties;
            f.comboBoxSpec.DisplayMember = "SpecialtyName";
            f.comboBoxSpec.ValueMember = "ID";

            f.comboBoxDep.DataSource = _allDepartments;
            f.comboBoxDep.DisplayMember = "DepartmentName";
            f.comboBoxDep.ValueMember = "ID";

            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            EmployeeDTO emp = new EmployeeDTO();
            emp.SpecialtyCode = (int)f.comboBoxSpec.SelectedValue;
            emp.FullName = f.textBoxName.Text;
            emp.DepartmentCode = (int)f.comboBoxDep.SelectedValue;

            // Call the business logic version that returns BusinessResult
            BusinessResult createResult = _dbOperations.CreateEmployee(emp);

            if (createResult.IsSuccess)
            {
                _allEmployees = _dbOperations.GetAllEmployees();
                empBindingSource.DataSource = _allEmployees;
                MessageBox.Show(createResult.Message); // "Сотрудник успешно создан!"
            }
            else
            {
                MessageBox.Show(createResult.Message, "Нарушение бизнес-правила",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int getSelectedRow(DataGridView dataGridView)
        {
            int index = -1;
            if (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                    index = dataGridView.SelectedRows[0].Index;
                else index = dataGridView.SelectedCells[0].RowIndex;
            }
            return index;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

            int index = getSelectedRow(dataGridView1);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                EmployeeDTO emp = _allEmployees.Where(i => i.ID == id).FirstOrDefault();
                if (emp != null)
                {
                    Form3 f = new Form3();
                    f.comboBoxSpec2.DataSource = _allSpecialties;
                    f.comboBoxSpec2.DisplayMember = "SpecialtyName";
                    f.comboBoxSpec2.ValueMember = "ID";

                    f.comboBoxDep2.DataSource = _allDepartments;
                    f.comboBoxDep2.DisplayMember = "DepartmentName";
                    f.comboBoxDep2.ValueMember = "ID";

                    f.textBoxName2.Text = emp.FullName;


                    DialogResult result = f.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;

                    emp.FullName = f.textBoxName2.Text;
                    emp.SpecialtyCode = (int)f.comboBoxSpec2.SelectedValue;   
                    emp.DepartmentCode = (int)f.comboBoxDep2.SelectedValue;  

                    _dbOperations.UpdateEmployee(emp);
                    LoadEmployees();
                    MessageBox.Show("Объект обновлен");
                }
            }
            else
                MessageBox.Show("Ни один объект не выбран!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridView1);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                _dbOperations.DeleteEmployee(id);
                empBindingSource.DataSource = _dbOperations.GetAllEmployees();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Force DataGridView to commit any pending edits
            dataGridView1.EndEdit();

            bool hasChanges = false;

            // Check each row for changes
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                var employeeDTO = row.DataBoundItem as EmployeeDTO;
                if (employeeDTO != null)
                {
                    // Update every employee (or use more sophisticated change tracking)
                    _dbOperations.UpdateEmployee(employeeDTO);
                    hasChanges = true;
                }
            }

            if (hasChanges)
            {
                bool saveResult = _dbOperations.Save();
                if (saveResult)
                    MessageBox.Show("Changes saved successfully!");
                else
                    MessageBox.Show("Save failed");
            }
            else
            {
                MessageBox.Show("No changes to save");
            }
        }

        private void btnSpecAdd_Click(object sender, EventArgs e)
        {
            SpecAdd f = new SpecAdd();

            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            SpecialtyDTO sp = new SpecialtyDTO();
            sp.SpecialtyName = f.textBox1.Text;

            _dbOperations.CreateSpecialty(sp);
            _allSpecialties = _dbOperations.GetAllSpecialties();
            specialtyDTOBindingSource.DataSource = _allSpecialties;
            MessageBox.Show("Новый объект добавлен");
        }

        private void btnSpecUpdate_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridView4);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridView4[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                SpecialtyDTO sp = _allSpecialties.Where(i => i.ID == id).FirstOrDefault();
                if (sp != null)
                {
                    SpecAdd f = new SpecAdd();

                    f.textBox1.Text = sp.SpecialtyName;


                    DialogResult result = f.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;

                    sp.SpecialtyName = f.textBox1.Text;

                    _dbOperations.UpdateSpecialty(sp);
                    LoadSpecialties();
                    MessageBox.Show("Объект обновлен");
                }
            }
            else
                MessageBox.Show("Ни один объект не выбран!");
        }

        private void btnSpecDelete_Click(object sender, EventArgs e)
        {

            SpecDlt f = new SpecDlt();

            f.comboBox1.DataSource = _allSpecialties;
            f.comboBox1.DisplayMember = "SpecialtyName";
            f.comboBox1.ValueMember = "ID";

            DialogResult result = f.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                return;
            }


            SpecialtyDTO sp = f.comboBox1.SelectedItem as SpecialtyDTO;

            if (sp == null)
            {
                MessageBox.Show("No specialty selected");
                return;
            }


            bool exists = _dbOperations.HasEmployeesWithSpecialty(sp.ID);

            if (exists)
            {
                MessageBox.Show("Ошибка. Есть сотрудники этой специальности");
            }
            else
            {
                _dbOperations.DeleteSpecialty(sp.ID);
                _allSpecialties = _dbOperations.GetAllSpecialties();
                specialtyDTOBindingSource.DataSource = _allSpecialties;
                _allEmployees = _dbOperations.GetAllEmployees();
                empBindingSource.DataSource = _allEmployees;
                MessageBox.Show("Объект удален");
            }
        }

        private void btnSpecSave_Click(object sender, EventArgs e)
        {
            dataGridView4.EndEdit();

            bool hasChanges = false;

            // Check each row for changes
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                if (row.IsNewRow) continue;

                var specialtyDTO = row.DataBoundItem as SpecialtyDTO;
                if (specialtyDTO != null)
                {
                    // Update every employee (or use more sophisticated change tracking)
                    _dbOperations.UpdateSpecialty(specialtyDTO);
                    hasChanges = true;
                }
            }

            if (hasChanges)
            {
                bool saveResult = _dbOperations.Save();
                if (saveResult)
                    MessageBox.Show("Changes saved successfully!");
                else
                    MessageBox.Show("Save failed");
            }
            else
            {
                MessageBox.Show("No changes to save");
            }
        }

        private void btnProc_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Clicked");
            try
            {
                // Option 1: Direct call to DBDataOperations
                var stats = _dbOperations.GetDepartmentStats();
                dataGridView2.DataSource = stats;

                // Option 2: Using the service layer (if you want business logic)
                //var stats = _reportService.GetFormattedDepartmentStats();
                //dataGridView2.DataSource = stats;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading department stats: {ex.Message}");
            }
        }

        private void btnLinq_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();


            // Use DTOs instead of direct entities
            var departments = _dbOperations.GetAllDepartments();
            f.SetDepartments(departments);

            DialogResult result = f.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            // Get selected department
            int departmentId = (int)f.ComboBoxDep.SelectedValue;

            try
            {
                // Call static method directly (like the example)
                var employeesWithProjects =
                    _reportService.GetEmployeesWithProjectsByDepartment(departmentId);

                dataGridView3.DataSource = employeesWithProjects;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is EmployeeDTO selectedEmployee)
            {
                try
                {
                    // Show a simple dialog to select new department
                    using (var transferDialog = new Form())
                    {
                        transferDialog.Text = "Transfer Employee";
                        transferDialog.Size = new Size(300, 200);

                        var comboBox = new ComboBox
                        {
                            Location = new Point(20, 30),
                            Width = 200,
                            DataSource = _dbOperations.GetAllDepartments(),
                            DisplayMember = "DepartmentName",
                            ValueMember = "Id"
                        };

                        var btnOk = new Button
                        {
                            Text = "Перевод",
                            Location = new Point(20, 70),
                            DialogResult = DialogResult.OK
                        };

                        var btnCancel = new Button
                        {
                            Text = "Отмена",
                            Location = new Point(120, 70),
                            DialogResult = DialogResult.Cancel
                        };

                        transferDialog.Controls.AddRange(new Control[] { comboBox, btnOk, btnCancel });

                        if (transferDialog.ShowDialog() == DialogResult.OK)
                        {
                            var transferDto = new EmployeeTransferDTO
                            {
                                EmployeeId = selectedEmployee.ID,
                                NewDepartmentId = (int)comboBox.SelectedValue
                            };

                            _transferService.TransferEmployee(transferDto);
                            MessageBox.Show("Перевод в другой департамент успешен");
                            LoadEmployees(); // Refresh the grid
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Transfer failed: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridView1);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                EmployeeDTO emp = _allEmployees.Where(i => i.ID == id).FirstOrDefault();
                if (emp != null)
                {
                    SpecialtyAssignmentForm f = new SpecialtyAssignmentForm();

                    // Set current employee info
                    f.labelEmployee.Text = emp.FullName;

                    var currentSpecialty = _allSpecialties.FirstOrDefault(s => s.ID == emp.SpecialtyCode);
                    f.labelCurrentSpecialty.Text = currentSpecialty?.SpecialtyName ?? "None";

                    // Load available specialties
                    f.comboBoxSpecialties.DataSource = _allSpecialties;
                    f.comboBoxSpecialties.DisplayMember = "SpecialtyName";
                    f.comboBoxSpecialties.ValueMember = "ID";

                    // Set current specialty as default selection
                    if (emp.SpecialtyCode > 0)
                    {
                        f.comboBoxSpecialties.SelectedValue = emp.SpecialtyCode;
                    }

                    DialogResult result = f.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;

                    // Get the selected specialty
                    int newSpecialtyId = (int)f.comboBoxSpecialties.SelectedValue;

                    // Call business logic service
                    BusinessResult businessResult = _specialtyService.AssignSpecialty(emp.ID, newSpecialtyId);

                    if (businessResult.IsSuccess)
                    {
                        LoadEmployees();
                        MessageBox.Show("Специальность назначена успешно!");
                        _allEmployees = _dbOperations.GetAllEmployees();
                        empBindingSource.DataSource = _allEmployees;
                    }
                    else
                    {
                        MessageBox.Show(businessResult.Message, "Ошибка бизнес-правила");
                    }
                }
            }
            else
                MessageBox.Show("Ни один сотрудник не выбран!");
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

