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
            //idLabel.Text = registrationCard.rc_id.ToString();
            //this.dataGridView1.Rows.Add(registrationCard);
            _registrationCard = registrationCard;
            InitializeComponent();
        }



        private void RecordCard_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
