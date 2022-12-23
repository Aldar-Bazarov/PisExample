namespace PisFirst.Views
{
    partial class JournalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.journalGrid = new System.Windows.Forms.DataGridView();
            this.omsuComboBox = new System.Windows.Forms.ComboBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportToWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.journalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(130, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Форма журнала учёта заявок на отлов животных без владельцев";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(252, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = " учёта заявок на отлов животных без владельцев";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataLabel.Location = new System.Drawing.Point(131, 127);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(0, 16);
            this.dataLabel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(252, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "______________________________________ муниципального образования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(170, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "(наименование муниципального образования)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(395, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Журнал";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(348, 603);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(233, 16);
            this.label27.TabIndex = 7;
            this.label27.Text = "Экспорт перечня заявок на отлов:";
            // 
            // journalGrid
            // 
            this.journalGrid.AllowUserToAddRows = false;
            this.journalGrid.AllowUserToDeleteRows = false;
            this.journalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journalGrid.Location = new System.Drawing.Point(79, 180);
            this.journalGrid.Name = "journalGrid";
            this.journalGrid.ReadOnly = true;
            this.journalGrid.Size = new System.Drawing.Size(682, 376);
            this.journalGrid.TabIndex = 11;
            // 
            // omsuComboBox
            // 
            this.omsuComboBox.FormattingEnabled = true;
            this.omsuComboBox.Location = new System.Drawing.Point(255, 127);
            this.omsuComboBox.Name = "omsuComboBox";
            this.omsuComboBox.Size = new System.Drawing.Size(261, 21);
            this.omsuComboBox.TabIndex = 12;
            this.omsuComboBox.SelectedIndexChanged += new System.EventHandler(this.omsuComboBox_SelectedIndexChanged);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackgroundImage = global::PisFirst.Properties.Resources.excel;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportExcel.Location = new System.Drawing.Point(668, 587);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(60, 49);
            this.btnExportExcel.TabIndex = 10;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportToWord
            // 
            this.btnExportToWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportToWord.BackgroundImage")));
            this.btnExportToWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExportToWord.Location = new System.Drawing.Point(597, 587);
            this.btnExportToWord.Name = "btnExportToWord";
            this.btnExportToWord.Size = new System.Drawing.Size(58, 49);
            this.btnExportToWord.TabIndex = 8;
            this.btnExportToWord.UseVisualStyleBackColor = true;
            this.btnExportToWord.Click += new System.EventHandler(this.btnExportToWord_Click);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 667);
            this.Controls.Add(this.omsuComboBox);
            this.Controls.Add(this.journalGrid);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnExportToWord);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JournalForm";
            this.Text = "Таблица журнала учёта заявок на отлов животных без владельцев";
            this.Load += new System.EventHandler(this.JournalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.journalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnExportToWord;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridView journalGrid;
        private System.Windows.Forms.ComboBox omsuComboBox;
    }
}