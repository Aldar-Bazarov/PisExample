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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.registyDGW = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddRegCard = new System.Windows.Forms.Button();
            this.btnEditRegCard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.urgencyCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.animalCategoryCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.aplCategoryCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPickerStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnViewRegCard = new System.Windows.Forms.Button();
            this.btnViewJournal = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reg_cardCombo = new System.Windows.Forms.ComboBox();
            this.distrCombo = new System.Windows.Forms.ComboBox();
            this.locationCombo = new System.Windows.Forms.ComboBox();
            this.orgCombo = new System.Windows.Forms.ComboBox();
            this.dtPickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registyDGW)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1147, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Василий Петров:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1260, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "оператор ОМСУ";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(1378, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAddRegCard
            // 
            this.btnAddRegCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRegCard.Location = new System.Drawing.Point(1054, 395);
            this.btnAddRegCard.Name = "btnAddRegCard";
            this.btnAddRegCard.Size = new System.Drawing.Size(140, 27);
            this.btnAddRegCard.TabIndex = 4;
            this.btnAddRegCard.Text = "Добавить заявку";
            this.btnAddRegCard.UseVisualStyleBackColor = true;
            // 
            // btnEditRegCard
            // 
            this.btnEditRegCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditRegCard.Location = new System.Drawing.Point(1054, 428);
            this.btnEditRegCard.Name = "btnEditRegCard";
            this.btnEditRegCard.Size = new System.Drawing.Size(140, 27);
            this.btnEditRegCard.TabIndex = 5;
            this.btnEditRegCard.Text = "Изменить заявку";
            this.btnEditRegCard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPickerEnd);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.orgCombo);
            this.groupBox1.Controls.Add(this.locationCombo);
            this.groupBox1.Controls.Add(this.distrCombo);
            this.groupBox1.Controls.Add(this.reg_cardCombo);
            this.groupBox1.Controls.Add(this.btnApplyFilters);
            this.groupBox1.Controls.Add(this.btnClearFilters);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.statusCombo);
            this.groupBox1.Controls.Add(this.urgencyCombo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.animalCategoryCombo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.aplCategoryCombo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtPickerStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1054, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 352);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyFilters.Location = new System.Drawing.Point(182, 310);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(97, 27);
            this.btnApplyFilters.TabIndex = 12;
            this.btnApplyFilters.Text = "Применить";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearFilters.Location = new System.Drawing.Point(285, 310);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(97, 27);
            this.btnClearFilters.TabIndex = 10;
            this.btnClearFilters.Text = "Очистить";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Текущий статус заявки:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Организация по отлову:";
            // 
            // statusCombo
            // 
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Items.AddRange(new object[] {
            "as_id"});
            this.statusCombo.Location = new System.Drawing.Point(182, 280);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(200, 24);
            this.statusCombo.TabIndex = 26;
            // 
            // urgencyCombo
            // 
            this.urgencyCombo.FormattingEnabled = true;
            this.urgencyCombo.Items.AddRange(new object[] {
            "ut_id"});
            this.urgencyCombo.Location = new System.Drawing.Point(182, 222);
            this.urgencyCombo.Name = "urgencyCombo";
            this.urgencyCombo.Size = new System.Drawing.Size(200, 24);
            this.urgencyCombo.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Срочность исполнения:";
            // 
            // animalCategoryCombo
            // 
            this.animalCategoryCombo.FormattingEnabled = true;
            this.animalCategoryCombo.Items.AddRange(new object[] {
            "anc_id"});
            this.animalCategoryCombo.Location = new System.Drawing.Point(182, 192);
            this.animalCategoryCombo.Name = "animalCategoryCombo";
            this.animalCategoryCombo.Size = new System.Drawing.Size(200, 24);
            this.animalCategoryCombo.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Категория животного:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Место обитания животного:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Населенный пункт:";
            // 
            // aplCategoryCombo
            // 
            this.aplCategoryCombo.FormattingEnabled = true;
            this.aplCategoryCombo.Items.AddRange(new object[] {
            "apc_id"});
            this.aplCategoryCombo.Location = new System.Drawing.Point(182, 106);
            this.aplCategoryCombo.Name = "aplCategoryCombo";
            this.aplCategoryCombo.Size = new System.Drawing.Size(200, 24);
            this.aplCategoryCombo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Категория заявителя:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Номер заявки:";
            // 
            // dtPickerStart
            // 
            this.dtPickerStart.Location = new System.Drawing.Point(182, 22);
            this.dtPickerStart.Name = "dtPickerStart";
            this.dtPickerStart.Size = new System.Drawing.Size(200, 22);
            this.dtPickerStart.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата подачи заявления от:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сортировка по:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackgroundImage = global::PisFirst.Properties.Resources.excel;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportExcel.Location = new System.Drawing.Point(1315, 436);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(61, 55);
            this.btnExportExcel.TabIndex = 9;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(1290, 413);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Экспорт в Excel:";
            // 
            // btnViewRegCard
            // 
            this.btnViewRegCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewRegCard.Location = new System.Drawing.Point(1054, 461);
            this.btnViewRegCard.Name = "btnViewRegCard";
            this.btnViewRegCard.Size = new System.Drawing.Size(140, 27);
            this.btnViewRegCard.TabIndex = 11;
            this.btnViewRegCard.Text = "Учётная карточка";
            this.btnViewRegCard.UseVisualStyleBackColor = true;
            // 
            // btnViewJournal
            // 
            this.btnViewJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewJournal.Location = new System.Drawing.Point(1054, 494);
            this.btnViewJournal.Name = "btnViewJournal";
            this.btnViewJournal.Size = new System.Drawing.Size(140, 27);
            this.btnViewJournal.TabIndex = 12;
            this.btnViewJournal.Text = "Форма журнала";
            this.btnViewJournal.UseVisualStyleBackColor = true;
            this.btnViewJournal.Click += new System.EventHandler(this.btnViewJournal_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(800, 14);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(217, 25);
            this.bindingNavigator1.TabIndex = 13;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // reg_cardCombo
            // 
            this.reg_cardCombo.FormattingEnabled = true;
            this.reg_cardCombo.Items.AddRange(new object[] {
            "rc_id"});
            this.reg_cardCombo.Location = new System.Drawing.Point(182, 78);
            this.reg_cardCombo.Name = "reg_cardCombo";
            this.reg_cardCombo.Size = new System.Drawing.Size(200, 24);
            this.reg_cardCombo.TabIndex = 29;
            // 
            // distrCombo
            // 
            this.distrCombo.FormattingEnabled = true;
            this.distrCombo.Items.AddRange(new object[] {
            "md_id"});
            this.distrCombo.Location = new System.Drawing.Point(182, 134);
            this.distrCombo.Name = "distrCombo";
            this.distrCombo.Size = new System.Drawing.Size(200, 24);
            this.distrCombo.TabIndex = 30;
            // 
            // locationCombo
            // 
            this.locationCombo.FormattingEnabled = true;
            this.locationCombo.Items.AddRange(new object[] {
            "rc_animal_habitat"});
            this.locationCombo.Location = new System.Drawing.Point(182, 162);
            this.locationCombo.Name = "locationCombo";
            this.locationCombo.Size = new System.Drawing.Size(200, 24);
            this.locationCombo.TabIndex = 31;
            // 
            // orgCombo
            // 
            this.orgCombo.FormattingEnabled = true;
            this.orgCombo.Items.AddRange(new object[] {
            "or_id"});
            this.orgCombo.Location = new System.Drawing.Point(182, 252);
            this.orgCombo.Name = "orgCombo";
            this.orgCombo.Size = new System.Drawing.Size(200, 24);
            this.orgCombo.TabIndex = 32;
            // 
            // dtPickerEnd
            // 
            this.dtPickerEnd.Location = new System.Drawing.Point(182, 50);
            this.dtPickerEnd.Name = "dtPickerEnd";
            this.dtPickerEnd.Size = new System.Drawing.Size(200, 22);
            this.dtPickerEnd.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "Дата подачи заявления до:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 970);
            this.Controls.Add(this.changeRecordButton);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.showRegistrationCard);
            this.Controls.Add(this.registrationCard_dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientSize = new System.Drawing.Size(1462, 533);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.btnViewJournal);
            this.Controls.Add(this.btnViewRegCard);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEditRegCard);
            this.Controls.Add(this.btnAddRegCard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registyDGW);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationCard_dataGridView)).EndInit();
            this.Text = "Регистр по отлову животных без владельцев";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registyDGW)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView registyDGW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddRegCard;
        private System.Windows.Forms.Button btnEditRegCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.ComboBox urgencyCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox animalCategoryCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox aplCategoryCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtPickerStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnViewRegCard;
        private System.Windows.Forms.Button btnViewJournal;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ComboBox orgCombo;
        private System.Windows.Forms.ComboBox locationCombo;
        private System.Windows.Forms.ComboBox distrCombo;
        private System.Windows.Forms.ComboBox reg_cardCombo;
        private System.Windows.Forms.DateTimePicker dtPickerEnd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView registrationCard_dataGridView;
        private System.Windows.Forms.Button showRegistrationCard;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button changeRecordButton;
    }
}