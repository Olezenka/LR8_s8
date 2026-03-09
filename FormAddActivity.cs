using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using LR8_s8.DBCon;

namespace LR8_s8.DBCon
{
    public partial class FormAddActivity : Form
    {
        public FormAddActivity()
        {
            InitializeComponent();
        }
        private List<int> Id_Juri = new List<int>();
        private void groupsJuryLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormAddActivity_Load(object sender, EventArgs e)
        {
            eventBindingSource.DataSource = DBConst.model.Event.ToList();
            userBindingSource.DataSource = DBConst.model.User.Where(x => x.RoleID == 1).ToList();
            userBindingSource2.DataSource = DBConst.model.User.Where(x => x.RoleID == 2).ToList();
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                MessageBox.Show("Заполните поле Название!");
                return;
            }
            try
            {
                Convert.ToInt32(dayTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("В поле день должно стоять целочисленное значение!");
                return;
            }
            if (Id_Juri.Count <= 0)
            {
                MessageBox.Show("Добавьте хотя бы одного члена жюри!");
                return;
            }
            Activity activity = new Activity();
            activity.Title = titleTextBox.Text;
            activity.EventPlanID = (int)eventPlanIDComboBox.SelectedValue;
            activity.Day = Convert.ToInt32(dayTextBox.Text);
            activity.StartedAt = dateTimePicker1.Value.TimeOfDay;
            activity.ModeratorID = (int)comboBoxModerator.SelectedValue;
            activity.GroupsJury = JsonSerializer.Serialize(Id_Juri);

            DBConst.model.Activity.Add(activity);
            try
            {
                DBConst.model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Close();
        }
    }
}
