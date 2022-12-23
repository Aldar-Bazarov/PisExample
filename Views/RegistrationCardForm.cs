using PisFirst.Controllers.RecordsController;
using System;
using System.Windows.Forms;

namespace PisFirst.Views
{
    /// <summary>
    /// Учётная карточка реестра
    /// </summary>
    internal partial class RegistrationCardForm : Form
    {
        /// <summary>
        /// Id выбранной карточки
        /// </summary>
        private int recordId;

        /// <summary>
        /// Именение captureDateIsChanged
        /// </summary>
        private bool captureDateIsChanged = false;

        /// <summary>
        /// Инициализация экземпляра
        /// </summary>
        /// <remarks> При добавлении карточки </remarks>
        public RegistrationCardForm(Program.UserRole role)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            if (role != Program.UserRole.OmsuOperator || role != Program.UserRole.TrappingOperator)
            {
                addCardButton.Enabled = false;
            }

            editCardButton.Enabled = false;

            addCardButton.Enabled = true;
            editCardButton.Enabled = false;

            var user = Program.AuthSession.AppUser;

            appDateTimePicker.Enabled = false;
            captureDateTimePicker.Enabled = false;
            appUserTextBox.Text = $"{user.u_first_name} {user.u_second_name}";
            appUserTextBox.Enabled = false;
            omsuTextBox.Text = user.Omsu.om_name;
            omsuTextBox.Enabled = false;
            organizationComboBox.Enabled = false;

            ComboBox[] comboBoxes = new ComboBox[]
            {
                organizationComboBox,
                urgencyTypeComboBox,
                animalCategoryComboBox,
                applicantCategoryComboBox
            };

            RecordsController.FillRecordComboBoxes(comboBoxes);
        }

        /// <summary>
        /// Инициализация экземпляра
        /// </summary>
        /// <param name="recordId">Id выбранной карточки</param>
        /// <remarks> При изменении карточки </remarks>
        public RegistrationCardForm(string recordId, Program.UserRole role)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            addCardButton.Enabled = true;
            editCardButton.Enabled = false;

            this.recordId = Convert.ToInt32(recordId);

            addCardButton.Enabled = false;
            editCardButton.Enabled = true;

            var record = RecordsController.GetOneRecord(this.recordId);

            var user = Program.AuthSession.AppUser;

            appDateTimePicker.Value = record.rc_application_date;
            appDateTimePicker.Enabled = false;
            animalHabitatTextBox.Text = record.rc_animal_habitat;
            animalHabitatTextBox.Enabled = false;
            captureReasonTextBox.Text = record.rc_capture_reason;
            captureReasonTextBox.Enabled = false;

            appUserTextBox.Text = $"{user.u_first_name} {user.u_second_name}";
            appUserTextBox.Enabled = false;
            omsuTextBox.Text = user.Omsu.om_name;
            omsuTextBox.Enabled = false;
            //organizationComboBox.SelectedValue = record.Organization?.or_name ?? String.Empty;
            //urgencyTypeComboBox.SelectedValue = record.UrgencyType.ut_name;
            urgencyTypeComboBox.Enabled = false;
            //animalCategoryComboBox.SelectedValue = record.AnimalCategory.anc_name;
            animalCategoryComboBox.Enabled = false;
            //applicantCategoryComboBox.SelectedValue = record.ApplicantCategory.apc_name;
            applicantCategoryComboBox.Enabled = false;

            ComboBox[] comboBoxes = new ComboBox[]
            {
                organizationComboBox,
                urgencyTypeComboBox,
                animalCategoryComboBox,
                applicantCategoryComboBox
            };

            RecordsController.FillRecordComboBoxes(comboBoxes);
        }

        // Добавить карточку в реестр
        private void addCardButton_Click(object sender, EventArgs e)
        {
            if (animalHabitatTextBox.Text == "" || captureReasonTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var values = new string[]
                {
                appDateTimePicker.Value.ToString(),
                animalHabitatTextBox.Text,
                captureReasonTextBox.Text,
                Program.AuthSession.AppUser.u_id.ToString(),
                Program.AuthSession.AppUser.om_id.ToString(),
                urgencyTypeComboBox.SelectedValue.ToString(),
                animalCategoryComboBox.SelectedValue.ToString(),
                applicantCategoryComboBox.SelectedValue.ToString(),
                };

                RecordsController.CreateRecord(values);

                this.Close();
            }
        }

        /// <summary>
        /// Изменить данные карточки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editCardButton_Click(object sender, EventArgs e)
        {
            RecordsController.UpdateRecord(this.recordId, (int)organizationComboBox.SelectedValue, captureDateTimePicker.Value, captureDateIsChanged);
            this.Close();
        }

        /// <summary>
        /// Отлов изменения captureDateIsChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void captureDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            captureDateIsChanged = true;
        }

        private void statusHistoryBtn_Click(object sender, EventArgs e)
        {
            StatusHistory sh = new StatusHistory(recordId);
            sh.Show();
        }
    }
}
