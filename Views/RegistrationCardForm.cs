using PisFirst.Controllers.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PisFirst.Views
{
    public partial class RegistrationCardForm : Form
    {
        private bool isShow;
        public RegistrationCardForm(bool isShow)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.isShow = isShow;
        }

        private void RegistrationCardForm_Load(object sender, EventArgs e)
        {
            if (isShow)
            {
                throw new NotImplementedException();
            }
            else
            {
                appDateTimePicker.Value = DateTime.Now;
                appUserTextBox.Text = "Сотрудник"; // доделать
                applicationTextBox.Text = "Зарегистрировано";

                ComboBox[] comboBoxes = new ComboBox[]
                {
                    omsuComboBox,
                    organizationComboBox,
                    urgencyTypeComboBox,
                    animalCategoryComboBox,
                    applicantCategoryComboBox
                };

                RecordsCRUD.FillComboBoxes(comboBoxes);
            }
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            var values = new string[10]
            {
                appDateTimePicker.Value.Date.ToString("yyyy-MM-dd"),
                animalHabitatTextBox.Text,
                captureReasonTextBox.Text,
                signingTimePicker.Value.Date.ToString("yyyy-MM-dd"),
                signingTextBox.Text,
                omsuComboBox.SelectedValue.ToString(),
                organizationComboBox.SelectedValue.ToString(),
                urgencyTypeComboBox.SelectedValue.ToString(),
                animalCategoryComboBox.SelectedValue.ToString(),
                applicantCategoryComboBox.SelectedValue.ToString(),
            };

            RecordsCRUD.CreateRecord(values);

            this.Close();
        }
    }
}
