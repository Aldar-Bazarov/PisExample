using System.Windows.Forms;
using PisFirst.Controllers.Authorization;

namespace PisFirst.Views
{
    /// <summary>
    /// Форма авторизации пользователя
    /// </summary>
    public partial class AuthorizationForm : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public AuthorizationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        /// <summary>
        /// Событие срабатывающее при загрузке формы
        /// </summary>
        /// <param name="sender">Инициатор</param>
        /// <param name="e">Аргументы события</param>
        private void AuthorizationForm_Load(object sender, System.EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        /// <summary>
        /// Событие срабатывающее при нажатии на кнопку "Войти",
        /// совершает авторизацию пользовтеля в системе
        /// </summary>
        /// <param name="sender">Инициатор</param>
        /// <param name="e">Аргументы события</param>
        private void buttonEnter_Click(object sender, System.EventArgs e)
        {
            if (textBox_login.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Введите логин и пароль!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var isExist = AuthorizationController.Authorize(textBox_login.Text, textBox_password.Text);

            if (isExist)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new MainForm().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
