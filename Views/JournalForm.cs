using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PisFirst.Controllers.ExportToolsController;
using Spire.Pdf.Exporting.XPS.Schema;
using Path = System.IO.Path;

namespace PisFirst.Views
{
    public partial class JournalForm : Form
    {
        public JournalForm()
        {
            InitializeComponent();
     

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // ExportToolsController.ExportExcelTrappingApplications(new []{"12"}, new[] { "12" });
        }

        private void btnExportToWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Документ Word (*.docx)|*.docx";
            sfd.FileName = "ExportedJournalOfTrappingApplications";
            DialogResult result = sfd.ShowDialog();
            if (result != DialogResult.OK) return;
            ExportToolsController.ExportWordTrappingApplications(new []{"12"}, new[] { "12" },Path.GetFullPath( sfd.FileName));

        }
    }
}
