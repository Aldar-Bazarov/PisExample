namespace PisFirst.Views
{
    partial class MainForm
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
            this.registrationCard_dataGridView = new System.Windows.Forms.DataGridView();
            this.showRegistrationCard = new System.Windows.Forms.Button();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.changeRecordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registrationCard_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationCard_dataGridView
            // 
            this.registrationCard_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registrationCard_dataGridView.Location = new System.Drawing.Point(3, 2);
            this.registrationCard_dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrationCard_dataGridView.Name = "registrationCard_dataGridView";
            this.registrationCard_dataGridView.RowHeadersWidth = 51;
            this.registrationCard_dataGridView.Size = new System.Drawing.Size(1568, 751);
            this.registrationCard_dataGridView.TabIndex = 0;
            // 
            // showRegistrationCard
            // 
            this.showRegistrationCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showRegistrationCard.Location = new System.Drawing.Point(51, 786);
            this.showRegistrationCard.Name = "showRegistrationCard";
            this.showRegistrationCard.Size = new System.Drawing.Size(231, 81);
            this.showRegistrationCard.TabIndex = 1;
            this.showRegistrationCard.Text = "Просмотр учётной карточки";
            this.showRegistrationCard.UseVisualStyleBackColor = true;
            this.showRegistrationCard.Click += new System.EventHandler(this.showRegistrationCard_Click);
            // 
            // addRecordButton
            // 
            this.addRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRecordButton.Location = new System.Drawing.Point(323, 786);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(140, 81);
            this.addRecordButton.TabIndex = 2;
            this.addRecordButton.Text = "Добавить запись";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // changeRecordButton
            // 
            this.changeRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeRecordButton.Location = new System.Drawing.Point(498, 786);
            this.changeRecordButton.Name = "changeRecordButton";
            this.changeRecordButton.Size = new System.Drawing.Size(140, 81);
            this.changeRecordButton.TabIndex = 3;
            this.changeRecordButton.Text = "Изменить запись";
            this.changeRecordButton.UseVisualStyleBackColor = true;
            this.changeRecordButton.Click += new System.EventHandler(this.changeRecordButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 970);
            this.Controls.Add(this.changeRecordButton);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.showRegistrationCard);
            this.Controls.Add(this.registrationCard_dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationCard_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView registrationCard_dataGridView;
        private System.Windows.Forms.Button showRegistrationCard;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button changeRecordButton;
    }
}