using BLL7.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rogov_V_3_42x_lab7
{
    public partial class Form5 : Form
    {
        public ComboBox ComboBoxDep => comboBoxDep; // Make combobox accessible

        public Form5()
        {
            InitializeComponent();
        }

        // Method to set department data from main form
        public void SetDepartments(List<DepartmentDTO> departments)
        {
            comboBoxDep.DataSource = departments;
            comboBoxDep.DisplayMember = "DepartmentName";
            comboBoxDep.ValueMember = "Id";
        }
    }
}
