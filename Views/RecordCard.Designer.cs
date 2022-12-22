namespace PisFirst.Views
{
    partial class RecordCard
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
            this.id = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.locality = new System.Windows.Forms.Label();
            this.localityBox = new System.Windows.Forms.TextBox();
            this.habitat = new System.Windows.Forms.Label();
            this.habitatBox = new System.Windows.Forms.TextBox();
            this.captureReason = new System.Windows.Forms.Label();
            this.captureReasonBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.Location = new System.Drawing.Point(12, 9);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(43, 32);
            this.id.TabIndex = 3;
            this.id.Text = "ID";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(389, 12);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(357, 22);
            this.idBox.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(12, 59);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(350, 32);
            this.Date.TabIndex = 6;
            this.Date.Text = "Дата подачи заявления";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(389, 69);
            this.DateBox.Name = "DateBox";
            this.DateBox.ReadOnly = true;
            this.DateBox.Size = new System.Drawing.Size(357, 22);
            this.DateBox.TabIndex = 7;
            // 
            // locality
            // 
            this.locality.AutoSize = true;
            this.locality.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locality.Location = new System.Drawing.Point(12, 113);
            this.locality.Name = "locality";
            this.locality.Size = new System.Drawing.Size(99, 32);
            this.locality.TabIndex = 8;
            this.locality.Text = "Город";
            // 
            // localityBox
            // 
            this.localityBox.Location = new System.Drawing.Point(389, 113);
            this.localityBox.Name = "localityBox";
            this.localityBox.ReadOnly = true;
            this.localityBox.Size = new System.Drawing.Size(357, 22);
            this.localityBox.TabIndex = 9;
            // 
            // habitat
            // 
            this.habitat.AutoSize = true;
            this.habitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.habitat.Location = new System.Drawing.Point(12, 172);
            this.habitat.Name = "habitat";
            this.habitat.Size = new System.Drawing.Size(243, 32);
            this.habitat.TabIndex = 10;
            this.habitat.Text = "Среда обитания";
            // 
            // habitatBox
            // 
            this.habitatBox.Location = new System.Drawing.Point(389, 172);
            this.habitatBox.Name = "habitatBox";
            this.habitatBox.ReadOnly = true;
            this.habitatBox.Size = new System.Drawing.Size(357, 22);
            this.habitatBox.TabIndex = 11;
            // 
            // captureReason
            // 
            this.captureReason.AutoSize = true;
            this.captureReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captureReason.Location = new System.Drawing.Point(12, 232);
            this.captureReason.Name = "captureReason";
            this.captureReason.Size = new System.Drawing.Size(242, 32);
            this.captureReason.TabIndex = 12;
            this.captureReason.Text = "Причина отлова";
            // 
            // captureReasonBox
            // 
            this.captureReasonBox.Location = new System.Drawing.Point(389, 232);
            this.captureReasonBox.Name = "captureReasonBox";
            this.captureReasonBox.ReadOnly = true;
            this.captureReasonBox.Size = new System.Drawing.Size(357, 22);
            this.captureReasonBox.TabIndex = 13;
            // 
            // RecordCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 859);
            this.Controls.Add(this.captureReasonBox);
            this.Controls.Add(this.captureReason);
            this.Controls.Add(this.habitatBox);
            this.Controls.Add(this.habitat);
            this.Controls.Add(this.localityBox);
            this.Controls.Add(this.locality);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.id);
            this.Name = "RecordCard";
            this.Text = "Учётная карточка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label locality;
        private System.Windows.Forms.TextBox localityBox;
        private System.Windows.Forms.Label habitat;
        private System.Windows.Forms.TextBox habitatBox;
        private System.Windows.Forms.Label captureReason;
        private System.Windows.Forms.TextBox captureReasonBox;
    }
}