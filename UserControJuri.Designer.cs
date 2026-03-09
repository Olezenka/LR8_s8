namespace LR8_s8
{
    partial class UserControJuri
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label genderIDLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label surnameLabel;
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.genderIDTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dateOfBirthLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            genderIDLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(69, 178);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(141, 25);
            dateOfBirthLabel.TabIndex = 1;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(216, 174);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.dateOfBirthDateTimePicker.TabIndex = 2;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(69, 214);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(113, 25);
            firstnameLabel.TabIndex = 3;
            firstnameLabel.Text = "Firstname:";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(216, 211);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(200, 31);
            this.firstnameTextBox.TabIndex = 4;
            // 
            // genderIDLabel
            // 
            genderIDLabel.AutoSize = true;
            genderIDLabel.Location = new System.Drawing.Point(69, 251);
            genderIDLabel.Name = "genderIDLabel";
            genderIDLabel.Size = new System.Drawing.Size(115, 25);
            genderIDLabel.TabIndex = 5;
            genderIDLabel.Text = "Gender ID:";
            // 
            // genderIDTextBox
            // 
            this.genderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "GenderID", true));
            this.genderIDTextBox.Location = new System.Drawing.Point(216, 248);
            this.genderIDTextBox.Name = "genderIDTextBox";
            this.genderIDTextBox.Size = new System.Drawing.Size(200, 31);
            this.genderIDTextBox.TabIndex = 6;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(477, 174);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(38, 25);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(624, 171);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 31);
            this.iDTextBox.TabIndex = 8;
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(477, 211);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(125, 25);
            patronymicLabel.TabIndex = 9;
            patronymicLabel.Text = "Patronymic:";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(624, 208);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(200, 31);
            this.patronymicTextBox.TabIndex = 10;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(477, 248);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(104, 25);
            surnameLabel.TabIndex = 11;
            surnameLabel.Text = "Surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(624, 245);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 31);
            this.surnameTextBox.TabIndex = 12;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(385, 75);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(120, 56);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "label1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(LR8_s8.DBCon.User);
            // 
            // UserControJuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelName);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(genderIDLabel);
            this.Controls.Add(this.genderIDTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Name = "UserControJuri";
            this.Size = new System.Drawing.Size(899, 335);
            this.Load += new System.EventHandler(this.UserControJuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox genderIDTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label labelName;
    }
}
