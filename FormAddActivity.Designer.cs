namespace LR8_s8.DBCon
{
    partial class FormAddActivity
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dayLabel;
            System.Windows.Forms.Label eventPlanIDLabel;
            System.Windows.Forms.Label groupsJuryLabel;
            System.Windows.Forms.Label moderatorIDLabel;
            System.Windows.Forms.Label startedAtLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddActivity));
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.activityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.eventPlanIDComboBox = new System.Windows.Forms.ComboBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxModerator = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxJuri = new System.Windows.Forms.ComboBox();
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.buttonAddJuri = new System.Windows.Forms.Button();
            dayLabel = new System.Windows.Forms.Label();
            eventPlanIDLabel = new System.Windows.Forms.Label();
            groupsJuryLabel = new System.Windows.Forms.Label();
            moderatorIDLabel = new System.Windows.Forms.Label();
            startedAtLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingNavigator)).BeginInit();
            this.activityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dayLabel.Location = new System.Drawing.Point(278, 351);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new System.Drawing.Size(108, 56);
            dayLabel.TabIndex = 1;
            dayLabel.Text = "День";
            // 
            // eventPlanIDLabel
            // 
            eventPlanIDLabel.AutoSize = true;
            eventPlanIDLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            eventPlanIDLabel.Location = new System.Drawing.Point(135, 253);
            eventPlanIDLabel.Name = "eventPlanIDLabel";
            eventPlanIDLabel.Size = new System.Drawing.Size(264, 56);
            eventPlanIDLabel.TabIndex = 3;
            eventPlanIDLabel.Text = "План события";
            // 
            // groupsJuryLabel
            // 
            groupsJuryLabel.AutoSize = true;
            groupsJuryLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            groupsJuryLabel.Location = new System.Drawing.Point(259, 615);
            groupsJuryLabel.Name = "groupsJuryLabel";
            groupsJuryLabel.Size = new System.Drawing.Size(127, 56);
            groupsJuryLabel.TabIndex = 5;
            groupsJuryLabel.Text = "Жюри";
            groupsJuryLabel.Click += new System.EventHandler(this.groupsJuryLabel_Click);
            // 
            // moderatorIDLabel
            // 
            moderatorIDLabel.AutoSize = true;
            moderatorIDLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            moderatorIDLabel.Location = new System.Drawing.Point(166, 524);
            moderatorIDLabel.Name = "moderatorIDLabel";
            moderatorIDLabel.Size = new System.Drawing.Size(220, 56);
            moderatorIDLabel.TabIndex = 9;
            moderatorIDLabel.Text = "Модератор";
            // 
            // startedAtLabel
            // 
            startedAtLabel.AutoSize = true;
            startedAtLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            startedAtLabel.Location = new System.Drawing.Point(136, 438);
            startedAtLabel.Name = "startedAtLabel";
            startedAtLabel.Size = new System.Drawing.Size(250, 56);
            startedAtLabel.TabIndex = 11;
            startedAtLabel.Text = "Начало мерю";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(211, 154);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(175, 56);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(328, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(545, 56);
            label1.TabIndex = 21;
            label1.Text = "Добавление новой активности";
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataSource = typeof(LR8_s8.DBCon.Activity);
            // 
            // activityBindingNavigator
            // 
            this.activityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.activityBindingNavigator.BindingSource = this.activityBindingSource;
            this.activityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.activityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.activityBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.activityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.activityBindingNavigatorSaveItem});
            this.activityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.activityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.activityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.activityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.activityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.activityBindingNavigator.Name = "activityBindingNavigator";
            this.activityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.activityBindingNavigator.Size = new System.Drawing.Size(1130, 42);
            this.activityBindingNavigator.TabIndex = 0;
            this.activityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(86, 36);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // activityBindingNavigatorSaveItem
            // 
            this.activityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.activityBindingNavigatorSaveItem.Enabled = false;
            this.activityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("activityBindingNavigatorSaveItem.Image")));
            this.activityBindingNavigatorSaveItem.Name = "activityBindingNavigatorSaveItem";
            this.activityBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.activityBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(420, 154);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(500, 64);
            this.titleTextBox.TabIndex = 14;
            // 
            // eventPlanIDComboBox
            // 
            this.eventPlanIDComboBox.DataSource = this.eventBindingSource;
            this.eventPlanIDComboBox.DisplayMember = "Title";
            this.eventPlanIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventPlanIDComboBox.FormattingEnabled = true;
            this.eventPlanIDComboBox.Location = new System.Drawing.Point(420, 270);
            this.eventPlanIDComboBox.Name = "eventPlanIDComboBox";
            this.eventPlanIDComboBox.Size = new System.Drawing.Size(500, 33);
            this.eventPlanIDComboBox.TabIndex = 15;
            this.eventPlanIDComboBox.ValueMember = "ID";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(LR8_s8.DBCon.Event);
            this.eventBindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(420, 449);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(500, 31);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(420, 351);
            this.dayTextBox.Multiline = true;
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(500, 55);
            this.dayTextBox.TabIndex = 17;
            // 
            // comboBoxModerator
            // 
            this.comboBoxModerator.DataSource = this.userBindingSource;
            this.comboBoxModerator.DisplayMember = "Surname";
            this.comboBoxModerator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModerator.FormattingEnabled = true;
            this.comboBoxModerator.Location = new System.Drawing.Point(420, 535);
            this.comboBoxModerator.Name = "comboBoxModerator";
            this.comboBoxModerator.Size = new System.Drawing.Size(500, 33);
            this.comboBoxModerator.TabIndex = 18;
            this.comboBoxModerator.ValueMember = "ID";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(LR8_s8.DBCon.User);
            // 
            // comboBoxJuri
            // 
            this.comboBoxJuri.DataSource = this.userBindingSource2;
            this.comboBoxJuri.DisplayMember = "Surname";
            this.comboBoxJuri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJuri.FormattingEnabled = true;
            this.comboBoxJuri.Location = new System.Drawing.Point(420, 632);
            this.comboBoxJuri.Name = "comboBoxJuri";
            this.comboBoxJuri.Size = new System.Drawing.Size(500, 33);
            this.comboBoxJuri.TabIndex = 19;
            this.comboBoxJuri.ValueMember = "ID";
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataSource = typeof(LR8_s8.DBCon.User);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(41, 64);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(131, 54);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Location = new System.Drawing.Point(313, 729);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(527, 56);
            this.buttonAddActivity.TabIndex = 22;
            this.buttonAddActivity.Text = "Добавить новую активность";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // buttonAddJuri
            // 
            this.buttonAddJuri.Location = new System.Drawing.Point(945, 632);
            this.buttonAddJuri.Name = "buttonAddJuri";
            this.buttonAddJuri.Size = new System.Drawing.Size(160, 39);
            this.buttonAddJuri.TabIndex = 23;
            this.buttonAddJuri.Text = "Добавить";
            this.buttonAddJuri.UseVisualStyleBackColor = true;
            this.buttonAddJuri.Click += new System.EventHandler(this.buttonAddJuri_Click);
            // 
            // FormAddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 853);
            this.Controls.Add(this.buttonAddJuri);
            this.Controls.Add(this.buttonAddActivity);
            this.Controls.Add(label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxJuri);
            this.Controls.Add(this.comboBoxModerator);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.eventPlanIDComboBox);
            this.Controls.Add(dayLabel);
            this.Controls.Add(eventPlanIDLabel);
            this.Controls.Add(groupsJuryLabel);
            this.Controls.Add(moderatorIDLabel);
            this.Controls.Add(startedAtLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.activityBindingNavigator);
            this.Name = "FormAddActivity";
            this.Text = "FormAddActivity";
            this.Load += new System.EventHandler(this.FormAddActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingNavigator)).EndInit();
            this.activityBindingNavigator.ResumeLayout(false);
            this.activityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.BindingNavigator activityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton activityBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox eventPlanIDComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.ComboBox comboBoxModerator;
        private System.Windows.Forms.ComboBox comboBoxJuri;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Button buttonAddJuri;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource2;
    }
}