namespace PisFirst.Views
{
    partial class RegistrationCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationCardForm));
            this.omsuTextBox = new System.Windows.Forms.TextBox();
            this.editCardButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.animalCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.applicantCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.urgencyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.appUserTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.appDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addCardButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.organizationComboBox = new System.Windows.Forms.ComboBox();
            this.captureReasonTextBox = new System.Windows.Forms.TextBox();
            this.animalHabitatTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.captureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusHistoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // omsuTextBox
            // 
            this.omsuTextBox.Enabled = false;
            this.omsuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.omsuTextBox.Location = new System.Drawing.Point(287, 180);
            this.omsuTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.omsuTextBox.Name = "omsuTextBox";
            this.omsuTextBox.Size = new System.Drawing.Size(274, 26);
            this.omsuTextBox.TabIndex = 68;
            // 
            // editCardButton
            // 
            this.editCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editCardButton.Location = new System.Drawing.Point(287, 370);
            this.editCardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editCardButton.Name = "editCardButton";
            this.editCardButton.Size = new System.Drawing.Size(134, 40);
            this.editCardButton.TabIndex = 67;
            this.editCardButton.Text = "Изменить";
            this.editCardButton.UseVisualStyleBackColor = true;
            this.editCardButton.Click += new System.EventHandler(this.editCardButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(29, 309);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 20);
            this.label11.TabIndex = 66;
            this.label11.Text = "Категория заявителя:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(29, 277);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 20);
            this.label10.TabIndex = 65;
            this.label10.Text = "Категория животного:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(29, 245);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "Тип срочности:";
            // 
            // animalCategoryComboBox
            // 
            this.animalCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animalCategoryComboBox.FormattingEnabled = true;
            this.animalCategoryComboBox.Location = new System.Drawing.Point(287, 273);
            this.animalCategoryComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animalCategoryComboBox.Name = "animalCategoryComboBox";
            this.animalCategoryComboBox.Size = new System.Drawing.Size(274, 28);
            this.animalCategoryComboBox.TabIndex = 63;
            // 
            // applicantCategoryComboBox
            // 
            this.applicantCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applicantCategoryComboBox.FormattingEnabled = true;
            this.applicantCategoryComboBox.Location = new System.Drawing.Point(287, 305);
            this.applicantCategoryComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.applicantCategoryComboBox.Name = "applicantCategoryComboBox";
            this.applicantCategoryComboBox.Size = new System.Drawing.Size(274, 28);
            this.applicantCategoryComboBox.TabIndex = 62;
            // 
            // urgencyTypeComboBox
            // 
            this.urgencyTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.urgencyTypeComboBox.FormattingEnabled = true;
            this.urgencyTypeComboBox.Location = new System.Drawing.Point(287, 241);
            this.urgencyTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.urgencyTypeComboBox.Name = "urgencyTypeComboBox";
            this.urgencyTypeComboBox.Size = new System.Drawing.Size(274, 28);
            this.urgencyTypeComboBox.TabIndex = 61;
            // 
            // appUserTextBox
            // 
            this.appUserTextBox.Enabled = false;
            this.appUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appUserTextBox.Location = new System.Drawing.Point(287, 151);
            this.appUserTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appUserTextBox.Name = "appUserTextBox";
            this.appUserTextBox.Size = new System.Drawing.Size(274, 26);
            this.appUserTextBox.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Сотрудник принявший заявку:";
            // 
            // appDateTimePicker
            // 
            this.appDateTimePicker.Enabled = false;
            this.appDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appDateTimePicker.Location = new System.Drawing.Point(287, 34);
            this.appDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appDateTimePicker.Name = "appDateTimePicker";
            this.appDateTimePicker.Size = new System.Drawing.Size(274, 26);
            this.appDateTimePicker.TabIndex = 58;
            // 
            // addCardButton
            // 
            this.addCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCardButton.Location = new System.Drawing.Point(426, 370);
            this.addCardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(134, 40);
            this.addCardButton.TabIndex = 57;
            this.addCardButton.Text = "Добавить";
            this.addCardButton.UseVisualStyleBackColor = true;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(29, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "ОМСУ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(29, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Организация:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Причина отлова:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Место обитания животного:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Дата заявки:";
            // 
            // organizationComboBox
            // 
            this.organizationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organizationComboBox.FormattingEnabled = true;
            this.organizationComboBox.Location = new System.Drawing.Point(287, 210);
            this.organizationComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.organizationComboBox.Name = "organizationComboBox";
            this.organizationComboBox.Size = new System.Drawing.Size(274, 28);
            this.organizationComboBox.TabIndex = 51;
            // 
            // captureReasonTextBox
            // 
            this.captureReasonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captureReasonTextBox.Location = new System.Drawing.Point(287, 93);
            this.captureReasonTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.captureReasonTextBox.Name = "captureReasonTextBox";
            this.captureReasonTextBox.Size = new System.Drawing.Size(274, 26);
            this.captureReasonTextBox.TabIndex = 50;
            // 
            // animalHabitatTextBox
            // 
            this.animalHabitatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animalHabitatTextBox.Location = new System.Drawing.Point(287, 63);
            this.animalHabitatTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animalHabitatTextBox.Name = "animalHabitatTextBox";
            this.animalHabitatTextBox.Size = new System.Drawing.Size(274, 26);
            this.animalHabitatTextBox.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Дата отлова:";
            // 
            // captureDateTimePicker
            // 
            this.captureDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captureDateTimePicker.Location = new System.Drawing.Point(287, 122);
            this.captureDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.captureDateTimePicker.Name = "captureDateTimePicker";
            this.captureDateTimePicker.Size = new System.Drawing.Size(274, 26);
            this.captureDateTimePicker.TabIndex = 71;
            this.captureDateTimePicker.ValueChanged += new System.EventHandler(this.captureDateTimePicker_ValueChanged);
            // 
            // statusHistoryBtn
            // 
            this.statusHistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusHistoryBtn.Location = new System.Drawing.Point(12, 394);
            this.statusHistoryBtn.Name = "statusHistoryBtn";
            this.statusHistoryBtn.Size = new System.Drawing.Size(129, 57);
            this.statusHistoryBtn.TabIndex = 72;
            this.statusHistoryBtn.Text = "История статуса";
            this.statusHistoryBtn.UseVisualStyleBackColor = true;
            this.statusHistoryBtn.Click += new System.EventHandler(this.statusHistoryBtn_Click);
            // 
            // RegistrationCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 463);
            this.Controls.Add(this.statusHistoryBtn);
            this.Controls.Add(this.captureDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.omsuTextBox);
            this.Controls.Add(this.editCardButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.animalCategoryComboBox);
            this.Controls.Add(this.applicantCategoryComboBox);
            this.Controls.Add(this.urgencyTypeComboBox);
            this.Controls.Add(this.appUserTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.appDateTimePicker);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.organizationComboBox);
            this.Controls.Add(this.captureReasonTextBox);
            this.Controls.Add(this.animalHabitatTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrationCardForm";
            this.Text = "Учётная карточка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox omsuTextBox;
        private System.Windows.Forms.Button editCardButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox animalCategoryComboBox;
        private System.Windows.Forms.ComboBox applicantCategoryComboBox;
        private System.Windows.Forms.ComboBox urgencyTypeComboBox;
        private System.Windows.Forms.TextBox appUserTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker appDateTimePicker;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox organizationComboBox;
        private System.Windows.Forms.TextBox captureReasonTextBox;
        private System.Windows.Forms.TextBox animalHabitatTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker captureDateTimePicker;
        private System.Windows.Forms.Button statusHistoryBtn;
    }
}