using PisFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PisFirst.Views
{
    public partial class RecordCard : Form
    {
        RegistrationCard _registrationCard;
        public RecordCard(RegistrationCard registrationCard)
        {
            _registrationCard = registrationCard;
            InitializeComponent();
        }



        private void RecordCard_Load(object sender, EventArgs e)
        {
            zayavkaId.Text = _registrationCard.rc_id.ToString();
            category.Text = _registrationCard.ApplicantCategory.ToString();
            town.Text = "hz";
            animalCategory.Text = _registrationCard.AnimalCategory.ToString();
            urgency.Text = _registrationCard.UrgencyType.ToString();
            organization.Text = _registrationCard.Organization.ToString();
            zayavkaStatus.Text = _registrationCard.ApplicationStatus.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
