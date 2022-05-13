namespace ContactBook_PTDN_Project
{
    partial class MainWindowForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.AddContactTabPage = new System.Windows.Forms.TabPage();
            this.ContactFormHeaderLabel = new System.Windows.Forms.Label();
            this.ContactFormTable = new System.Windows.Forms.TableLayoutPanel();
            this.ContactEmailWrapperFlowLp = new System.Windows.Forms.FlowLayoutPanel();
            this.ContactEmailInput = new System.Windows.Forms.TextBox();
            this.ContactEmailErrorLabel = new System.Windows.Forms.Label();
            this.ContactPhoneWrapperFlowLp = new System.Windows.Forms.FlowLayoutPanel();
            this.ContactPhoneInput = new System.Windows.Forms.MaskedTextBox();
            this.ContactPhoneErrorLabel = new System.Windows.Forms.Label();
            this.ContactBirthdayWrapperFlowLp = new System.Windows.Forms.FlowLayoutPanel();
            this.ContactBirthdayInput = new System.Windows.Forms.DateTimePicker();
            this.ContactBirthdayErrorLabel = new System.Windows.Forms.Label();
            this.ContactLastNameWrapperFlowLp = new System.Windows.Forms.FlowLayoutPanel();
            this.ContactLastNameInput = new System.Windows.Forms.TextBox();
            this.ContactLastNameErrorLabel = new System.Windows.Forms.Label();
            this.ContactFirstNameWrapperFlowLp = new System.Windows.Forms.FlowLayoutPanel();
            this.ContactFirstNameInput = new System.Windows.Forms.TextBox();
            this.ContactFirstNameErrorLabel = new System.Windows.Forms.Label();
            this.ContactLastNameLabel = new System.Windows.Forms.Label();
            this.ContactBirthdayLabel = new System.Windows.Forms.Label();
            this.ContactPhoneLabel = new System.Windows.Forms.Label();
            this.ContactEmailLabel = new System.Windows.Forms.Label();
            this.ContactFirstNameLabel = new System.Windows.Forms.Label();
            this.SubmitWrapperTable = new System.Windows.Forms.TableLayoutPanel();
            this.SubmitContactFormButton = new System.Windows.Forms.Button();
            this.ContactFormDbMessageLabel = new System.Windows.Forms.Label();
            this.ContactsTabPage = new System.Windows.Forms.TabPage();
            this.DateContactFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.ContactSearchInput = new System.Windows.Forms.TextBox();
            this.DateContactFilterLabel = new System.Windows.Forms.Label();
            this.DateContactFilterDtp = new System.Windows.Forms.DateTimePicker();
            this.ContactsMainWrapperFlowLp = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ContactsHeaderLabel = new System.Windows.Forms.Label();
            this.ContactsTimer = new System.Windows.Forms.Timer(this.components);
            this.MainTabControl.SuspendLayout();
            this.AddContactTabPage.SuspendLayout();
            this.ContactFormTable.SuspendLayout();
            this.ContactEmailWrapperFlowLp.SuspendLayout();
            this.ContactPhoneWrapperFlowLp.SuspendLayout();
            this.ContactBirthdayWrapperFlowLp.SuspendLayout();
            this.ContactLastNameWrapperFlowLp.SuspendLayout();
            this.ContactFirstNameWrapperFlowLp.SuspendLayout();
            this.SubmitWrapperTable.SuspendLayout();
            this.ContactsTabPage.SuspendLayout();
            this.ContactsMainWrapperFlowLp.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.AccessibleName = "";
            this.MainTabControl.Controls.Add(this.AddContactTabPage);
            this.MainTabControl.Controls.Add(this.ContactsTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(776, 426);
            this.MainTabControl.TabIndex = 0;
            // 
            // AddContactTabPage
            // 
            this.AddContactTabPage.Controls.Add(this.ContactFormHeaderLabel);
            this.AddContactTabPage.Controls.Add(this.ContactFormTable);
            this.AddContactTabPage.Location = new System.Drawing.Point(4, 24);
            this.AddContactTabPage.Name = "AddContactTabPage";
            this.AddContactTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddContactTabPage.Size = new System.Drawing.Size(768, 398);
            this.AddContactTabPage.TabIndex = 0;
            this.AddContactTabPage.Text = "Add Contact";
            this.AddContactTabPage.UseVisualStyleBackColor = true;
            // 
            // ContactFormHeaderLabel
            // 
            this.ContactFormHeaderLabel.AutoSize = true;
            this.ContactFormHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactFormHeaderLabel.Location = new System.Drawing.Point(272, 37);
            this.ContactFormHeaderLabel.Name = "ContactFormHeaderLabel";
            this.ContactFormHeaderLabel.Size = new System.Drawing.Size(224, 46);
            this.ContactFormHeaderLabel.TabIndex = 0;
            this.ContactFormHeaderLabel.Text = "Contact Form";
            // 
            // ContactFormTable
            // 
            this.ContactFormTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContactFormTable.ColumnCount = 4;
            this.ContactFormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ContactFormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.ContactFormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ContactFormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.ContactFormTable.Controls.Add(this.ContactEmailWrapperFlowLp, 3, 1);
            this.ContactFormTable.Controls.Add(this.ContactPhoneWrapperFlowLp, 3, 0);
            this.ContactFormTable.Controls.Add(this.ContactBirthdayWrapperFlowLp, 1, 2);
            this.ContactFormTable.Controls.Add(this.ContactLastNameWrapperFlowLp, 1, 1);
            this.ContactFormTable.Controls.Add(this.ContactFirstNameWrapperFlowLp, 1, 0);
            this.ContactFormTable.Controls.Add(this.ContactLastNameLabel, 0, 1);
            this.ContactFormTable.Controls.Add(this.ContactBirthdayLabel, 0, 2);
            this.ContactFormTable.Controls.Add(this.ContactPhoneLabel, 2, 0);
            this.ContactFormTable.Controls.Add(this.ContactEmailLabel, 2, 1);
            this.ContactFormTable.Controls.Add(this.ContactFirstNameLabel, 0, 0);
            this.ContactFormTable.Controls.Add(this.SubmitWrapperTable, 0, 3);
            this.ContactFormTable.Location = new System.Drawing.Point(6, 118);
            this.ContactFormTable.Name = "ContactFormTable";
            this.ContactFormTable.RowCount = 4;
            this.ContactFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ContactFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ContactFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ContactFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ContactFormTable.Size = new System.Drawing.Size(756, 250);
            this.ContactFormTable.TabIndex = 1;
            // 
            // ContactEmailWrapperFlowLp
            // 
            this.ContactEmailWrapperFlowLp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContactEmailWrapperFlowLp.AutoSize = true;
            this.ContactEmailWrapperFlowLp.Controls.Add(this.ContactEmailInput);
            this.ContactEmailWrapperFlowLp.Controls.Add(this.ContactEmailErrorLabel);
            this.ContactEmailWrapperFlowLp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContactEmailWrapperFlowLp.Location = new System.Drawing.Point(490, 54);
            this.ContactEmailWrapperFlowLp.Margin = new System.Windows.Forms.Padding(0);
            this.ContactEmailWrapperFlowLp.Name = "ContactEmailWrapperFlowLp";
            this.ContactEmailWrapperFlowLp.Size = new System.Drawing.Size(156, 42);
            this.ContactEmailWrapperFlowLp.TabIndex = 4;
            // 
            // ContactEmailInput
            // 
            this.ContactEmailInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContactEmailInput.Location = new System.Drawing.Point(3, 3);
            this.ContactEmailInput.Name = "ContactEmailInput";
            this.ContactEmailInput.PlaceholderText = "Email ...";
            this.ContactEmailInput.Size = new System.Drawing.Size(150, 23);
            this.ContactEmailInput.TabIndex = 5;
            this.ContactEmailInput.Leave += new System.EventHandler(this.ContactEmailInput_Leave);
            // 
            // ContactEmailErrorLabel
            // 
            this.ContactEmailErrorLabel.AutoSize = true;
            this.ContactEmailErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactEmailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ContactEmailErrorLabel.Location = new System.Drawing.Point(3, 29);
            this.ContactEmailErrorLabel.Name = "ContactEmailErrorLabel";
            this.ContactEmailErrorLabel.Size = new System.Drawing.Size(112, 13);
            this.ContactEmailErrorLabel.TabIndex = 1;
            this.ContactEmailErrorLabel.Text = "<error placeholder>";
            this.ContactEmailErrorLabel.Visible = false;
            // 
            // ContactPhoneWrapperFlowLp
            // 
            this.ContactPhoneWrapperFlowLp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContactPhoneWrapperFlowLp.AutoSize = true;
            this.ContactPhoneWrapperFlowLp.Controls.Add(this.ContactPhoneInput);
            this.ContactPhoneWrapperFlowLp.Controls.Add(this.ContactPhoneErrorLabel);
            this.ContactPhoneWrapperFlowLp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContactPhoneWrapperFlowLp.Location = new System.Drawing.Point(490, 4);
            this.ContactPhoneWrapperFlowLp.Margin = new System.Windows.Forms.Padding(0);
            this.ContactPhoneWrapperFlowLp.Name = "ContactPhoneWrapperFlowLp";
            this.ContactPhoneWrapperFlowLp.Size = new System.Drawing.Size(156, 42);
            this.ContactPhoneWrapperFlowLp.TabIndex = 3;
            // 
            // ContactPhoneInput
            // 
            this.ContactPhoneInput.Location = new System.Drawing.Point(3, 3);
            this.ContactPhoneInput.Mask = "+48 000 000 000";
            this.ContactPhoneInput.Name = "ContactPhoneInput";
            this.ContactPhoneInput.Size = new System.Drawing.Size(150, 23);
            this.ContactPhoneInput.TabIndex = 4;
            this.ContactPhoneInput.Leave += new System.EventHandler(this.ContactPhoneInput_Leave);
            // 
            // ContactPhoneErrorLabel
            // 
            this.ContactPhoneErrorLabel.AutoSize = true;
            this.ContactPhoneErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactPhoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ContactPhoneErrorLabel.Location = new System.Drawing.Point(3, 29);
            this.ContactPhoneErrorLabel.Name = "ContactPhoneErrorLabel";
            this.ContactPhoneErrorLabel.Size = new System.Drawing.Size(112, 13);
            this.ContactPhoneErrorLabel.TabIndex = 1;
            this.ContactPhoneErrorLabel.Text = "<error placeholder>";
            this.ContactPhoneErrorLabel.Visible = false;
            // 
            // ContactBirthdayWrapperFlowLp
            // 
            this.ContactBirthdayWrapperFlowLp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContactBirthdayWrapperFlowLp.AutoSize = true;
            this.ContactBirthdayWrapperFlowLp.Controls.Add(this.ContactBirthdayInput);
            this.ContactBirthdayWrapperFlowLp.Controls.Add(this.ContactBirthdayErrorLabel);
            this.ContactBirthdayWrapperFlowLp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContactBirthdayWrapperFlowLp.Location = new System.Drawing.Point(113, 104);
            this.ContactBirthdayWrapperFlowLp.Margin = new System.Windows.Forms.Padding(0);
            this.ContactBirthdayWrapperFlowLp.Name = "ContactBirthdayWrapperFlowLp";
            this.ContactBirthdayWrapperFlowLp.Size = new System.Drawing.Size(156, 41);
            this.ContactBirthdayWrapperFlowLp.TabIndex = 2;
            // 
            // ContactBirthdayInput
            // 
            this.ContactBirthdayInput.CustomFormat = "dd.MM.yyyy";
            this.ContactBirthdayInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ContactBirthdayInput.Location = new System.Drawing.Point(3, 3);
            this.ContactBirthdayInput.Name = "ContactBirthdayInput";
            this.ContactBirthdayInput.Size = new System.Drawing.Size(150, 23);
            this.ContactBirthdayInput.TabIndex = 1;
            this.ContactBirthdayInput.Leave += new System.EventHandler(this.ContactBirthdayInput_Leave);
            // 
            // ContactBirthdayErrorLabel
            // 
            this.ContactBirthdayErrorLabel.AutoSize = true;
            this.ContactBirthdayErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactBirthdayErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ContactBirthdayErrorLabel.Location = new System.Drawing.Point(3, 29);
            this.ContactBirthdayErrorLabel.Name = "ContactBirthdayErrorLabel";
            this.ContactBirthdayErrorLabel.Size = new System.Drawing.Size(93, 12);
            this.ContactBirthdayErrorLabel.TabIndex = 1;
            this.ContactBirthdayErrorLabel.Text = "<error placeholder>";
            this.ContactBirthdayErrorLabel.Visible = false;
            // 
            // ContactLastNameWrapperFlowLp
            // 
            this.ContactLastNameWrapperFlowLp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContactLastNameWrapperFlowLp.AutoSize = true;
            this.ContactLastNameWrapperFlowLp.Controls.Add(this.ContactLastNameInput);
            this.ContactLastNameWrapperFlowLp.Controls.Add(this.ContactLastNameErrorLabel);
            this.ContactLastNameWrapperFlowLp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContactLastNameWrapperFlowLp.Location = new System.Drawing.Point(113, 54);
            this.ContactLastNameWrapperFlowLp.Margin = new System.Windows.Forms.Padding(0);
            this.ContactLastNameWrapperFlowLp.Name = "ContactLastNameWrapperFlowLp";
            this.ContactLastNameWrapperFlowLp.Size = new System.Drawing.Size(156, 42);
            this.ContactLastNameWrapperFlowLp.TabIndex = 1;
            // 
            // ContactLastNameInput
            // 
            this.ContactLastNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContactLastNameInput.Location = new System.Drawing.Point(3, 3);
            this.ContactLastNameInput.Name = "ContactLastNameInput";
            this.ContactLastNameInput.PlaceholderText = "Last name ...";
            this.ContactLastNameInput.Size = new System.Drawing.Size(150, 23);
            this.ContactLastNameInput.TabIndex = 1;
            this.ContactLastNameInput.Leave += new System.EventHandler(this.ContactLastNameInput_Leave);
            // 
            // ContactLastNameErrorLabel
            // 
            this.ContactLastNameErrorLabel.AutoSize = true;
            this.ContactLastNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactLastNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ContactLastNameErrorLabel.Location = new System.Drawing.Point(3, 29);
            this.ContactLastNameErrorLabel.Name = "ContactLastNameErrorLabel";
            this.ContactLastNameErrorLabel.Size = new System.Drawing.Size(112, 13);
            this.ContactLastNameErrorLabel.TabIndex = 1;
            this.ContactLastNameErrorLabel.Text = "<error placeholder>";
            this.ContactLastNameErrorLabel.Visible = false;
            // 
            // ContactFirstNameWrapperFlowLp
            // 
            this.ContactFirstNameWrapperFlowLp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContactFirstNameWrapperFlowLp.AutoSize = true;
            this.ContactFirstNameWrapperFlowLp.Controls.Add(this.ContactFirstNameInput);
            this.ContactFirstNameWrapperFlowLp.Controls.Add(this.ContactFirstNameErrorLabel);
            this.ContactFirstNameWrapperFlowLp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContactFirstNameWrapperFlowLp.Location = new System.Drawing.Point(113, 4);
            this.ContactFirstNameWrapperFlowLp.Margin = new System.Windows.Forms.Padding(0);
            this.ContactFirstNameWrapperFlowLp.Name = "ContactFirstNameWrapperFlowLp";
            this.ContactFirstNameWrapperFlowLp.Size = new System.Drawing.Size(156, 42);
            this.ContactFirstNameWrapperFlowLp.TabIndex = 0;
            // 
            // ContactFirstNameInput
            // 
            this.ContactFirstNameInput.BackColor = System.Drawing.SystemColors.Window;
            this.ContactFirstNameInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ContactFirstNameInput.Location = new System.Drawing.Point(3, 3);
            this.ContactFirstNameInput.Name = "ContactFirstNameInput";
            this.ContactFirstNameInput.PlaceholderText = "First name ...";
            this.ContactFirstNameInput.Size = new System.Drawing.Size(150, 23);
            this.ContactFirstNameInput.TabIndex = 0;
            this.ContactFirstNameInput.Leave += new System.EventHandler(this.ContactFirstNameInput_Leave);
            // 
            // ContactFirstNameErrorLabel
            // 
            this.ContactFirstNameErrorLabel.AutoSize = true;
            this.ContactFirstNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactFirstNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ContactFirstNameErrorLabel.Location = new System.Drawing.Point(3, 29);
            this.ContactFirstNameErrorLabel.Name = "ContactFirstNameErrorLabel";
            this.ContactFirstNameErrorLabel.Size = new System.Drawing.Size(112, 13);
            this.ContactFirstNameErrorLabel.TabIndex = 1;
            this.ContactFirstNameErrorLabel.Text = "<error placeholder>";
            this.ContactFirstNameErrorLabel.Visible = false;
            // 
            // ContactLastNameLabel
            // 
            this.ContactLastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ContactLastNameLabel.AutoSize = true;
            this.ContactLastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ContactLastNameLabel.Location = new System.Drawing.Point(44, 67);
            this.ContactLastNameLabel.Name = "ContactLastNameLabel";
            this.ContactLastNameLabel.Size = new System.Drawing.Size(66, 15);
            this.ContactLastNameLabel.TabIndex = 5;
            this.ContactLastNameLabel.Text = "Last Name:";
            this.ContactLastNameLabel.Click += new System.EventHandler(this.ContactLastNameLabel_Click);
            // 
            // ContactBirthdayLabel
            // 
            this.ContactBirthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ContactBirthdayLabel.AutoSize = true;
            this.ContactBirthdayLabel.Location = new System.Drawing.Point(48, 117);
            this.ContactBirthdayLabel.Name = "ContactBirthdayLabel";
            this.ContactBirthdayLabel.Size = new System.Drawing.Size(62, 15);
            this.ContactBirthdayLabel.TabIndex = 7;
            this.ContactBirthdayLabel.Text = "Birth Date:";
            this.ContactBirthdayLabel.Click += new System.EventHandler(this.ContactBirthdayLabel_Click);
            // 
            // ContactPhoneLabel
            // 
            this.ContactPhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ContactPhoneLabel.AutoSize = true;
            this.ContactPhoneLabel.Location = new System.Drawing.Point(443, 17);
            this.ContactPhoneLabel.Name = "ContactPhoneLabel";
            this.ContactPhoneLabel.Size = new System.Drawing.Size(44, 15);
            this.ContactPhoneLabel.TabIndex = 8;
            this.ContactPhoneLabel.Text = "Phone:";
            this.ContactPhoneLabel.Click += new System.EventHandler(this.ContactPhoneLabel_Click);
            // 
            // ContactEmailLabel
            // 
            this.ContactEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ContactEmailLabel.AutoSize = true;
            this.ContactEmailLabel.Location = new System.Drawing.Point(448, 67);
            this.ContactEmailLabel.Name = "ContactEmailLabel";
            this.ContactEmailLabel.Size = new System.Drawing.Size(39, 15);
            this.ContactEmailLabel.TabIndex = 9;
            this.ContactEmailLabel.Text = "Email:";
            this.ContactEmailLabel.Click += new System.EventHandler(this.ContactEmailLabel_Click);
            // 
            // ContactFirstNameLabel
            // 
            this.ContactFirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ContactFirstNameLabel.AutoSize = true;
            this.ContactFirstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ContactFirstNameLabel.Location = new System.Drawing.Point(43, 17);
            this.ContactFirstNameLabel.Name = "ContactFirstNameLabel";
            this.ContactFirstNameLabel.Size = new System.Drawing.Size(67, 15);
            this.ContactFirstNameLabel.TabIndex = 10;
            this.ContactFirstNameLabel.Text = "First Name:";
            this.ContactFirstNameLabel.Click += new System.EventHandler(this.ContactFirstNameLabel_Click);
            // 
            // SubmitWrapperTable
            // 
            this.SubmitWrapperTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitWrapperTable.AutoSize = true;
            this.SubmitWrapperTable.ColumnCount = 1;
            this.ContactFormTable.SetColumnSpan(this.SubmitWrapperTable, 4);
            this.SubmitWrapperTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SubmitWrapperTable.Controls.Add(this.SubmitContactFormButton, 0, 0);
            this.SubmitWrapperTable.Controls.Add(this.ContactFormDbMessageLabel, 0, 1);
            this.SubmitWrapperTable.Location = new System.Drawing.Point(284, 175);
            this.SubmitWrapperTable.Name = "SubmitWrapperTable";
            this.SubmitWrapperTable.RowCount = 2;
            this.SubmitWrapperTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SubmitWrapperTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SubmitWrapperTable.Size = new System.Drawing.Size(187, 49);
            this.SubmitWrapperTable.TabIndex = 5;
            // 
            // SubmitContactFormButton
            // 
            this.SubmitContactFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitWrapperTable.SetColumnSpan(this.SubmitContactFormButton, 4);
            this.SubmitContactFormButton.Location = new System.Drawing.Point(18, 3);
            this.SubmitContactFormButton.Name = "SubmitContactFormButton";
            this.SubmitContactFormButton.Size = new System.Drawing.Size(150, 30);
            this.SubmitContactFormButton.TabIndex = 5;
            this.SubmitContactFormButton.Text = "Add Contact";
            this.SubmitContactFormButton.UseVisualStyleBackColor = true;
            this.SubmitContactFormButton.Click += new System.EventHandler(this.SubmitContactFormButton_Click);
            // 
            // ContactFormDbMessageLabel
            // 
            this.ContactFormDbMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContactFormDbMessageLabel.AutoSize = true;
            this.ContactFormDbMessageLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactFormDbMessageLabel.ForeColor = System.Drawing.Color.Green;
            this.ContactFormDbMessageLabel.Location = new System.Drawing.Point(3, 36);
            this.ContactFormDbMessageLabel.Name = "ContactFormDbMessageLabel";
            this.ContactFormDbMessageLabel.Size = new System.Drawing.Size(181, 13);
            this.ContactFormDbMessageLabel.TabIndex = 6;
            this.ContactFormDbMessageLabel.Text = "<database message placeholder>";
            this.ContactFormDbMessageLabel.Visible = false;
            // 
            // ContactsTabPage
            // 
            this.ContactsTabPage.Controls.Add(this.DateContactFilterCheckBox);
            this.ContactsTabPage.Controls.Add(this.ContactSearchInput);
            this.ContactsTabPage.Controls.Add(this.DateContactFilterLabel);
            this.ContactsTabPage.Controls.Add(this.DateContactFilterDtp);
            this.ContactsTabPage.Controls.Add(this.ContactsMainWrapperFlowLp);
            this.ContactsTabPage.Controls.Add(this.ContactsHeaderLabel);
            this.ContactsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ContactsTabPage.Name = "ContactsTabPage";
            this.ContactsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ContactsTabPage.Size = new System.Drawing.Size(768, 398);
            this.ContactsTabPage.TabIndex = 1;
            this.ContactsTabPage.Text = "Contacts";
            this.ContactsTabPage.UseVisualStyleBackColor = true;
            this.ContactsTabPage.Enter += new System.EventHandler(this.ContactsTabPage_Enter);
            // 
            // DateContactFilterCheckBox
            // 
            this.DateContactFilterCheckBox.AutoSize = true;
            this.DateContactFilterCheckBox.Checked = true;
            this.DateContactFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DateContactFilterCheckBox.Location = new System.Drawing.Point(592, 38);
            this.DateContactFilterCheckBox.Name = "DateContactFilterCheckBox";
            this.DateContactFilterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DateContactFilterCheckBox.TabIndex = 6;
            this.DateContactFilterCheckBox.UseVisualStyleBackColor = true;
            this.DateContactFilterCheckBox.Visible = false;
            this.DateContactFilterCheckBox.CheckedChanged += new System.EventHandler(this.DateContactFilterCheckBox_CheckedChanged);
            // 
            // ContactSearchInput
            // 
            this.ContactSearchInput.Location = new System.Drawing.Point(26, 55);
            this.ContactSearchInput.Name = "ContactSearchInput";
            this.ContactSearchInput.PlaceholderText = "Search ...";
            this.ContactSearchInput.Size = new System.Drawing.Size(150, 23);
            this.ContactSearchInput.TabIndex = 5;
            this.ContactSearchInput.TextChanged += new System.EventHandler(this.ContactSearchInput_TextChanged);
            // 
            // DateContactFilterLabel
            // 
            this.DateContactFilterLabel.AutoSize = true;
            this.DateContactFilterLabel.Location = new System.Drawing.Point(604, 37);
            this.DateContactFilterLabel.Name = "DateContactFilterLabel";
            this.DateContactFilterLabel.Size = new System.Drawing.Size(100, 15);
            this.DateContactFilterLabel.TabIndex = 4;
            this.DateContactFilterLabel.Text = "Filter by birthdate";
            this.DateContactFilterLabel.Visible = false;
            this.DateContactFilterLabel.Click += new System.EventHandler(this.DateContactFilterLabel_Click);
            // 
            // DateContactFilterDtp
            // 
            this.DateContactFilterDtp.CustomFormat = "dd MMMM";
            this.DateContactFilterDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateContactFilterDtp.Location = new System.Drawing.Point(592, 55);
            this.DateContactFilterDtp.Name = "DateContactFilterDtp";
            this.DateContactFilterDtp.Size = new System.Drawing.Size(150, 23);
            this.DateContactFilterDtp.TabIndex = 3;
            this.DateContactFilterDtp.Value = new System.DateTime(2022, 4, 22, 0, 0, 0, 0);
            this.DateContactFilterDtp.Visible = false;
            this.DateContactFilterDtp.ValueChanged += new System.EventHandler(this.DateContactFilterDtp_ValueChanged);
            // 
            // ContactsMainWrapperFlowLp
            // 
            this.ContactsMainWrapperFlowLp.AutoScroll = true;
            this.ContactsMainWrapperFlowLp.BackColor = System.Drawing.Color.Transparent;
            this.ContactsMainWrapperFlowLp.Controls.Add(this.tableLayoutPanel1);
            this.ContactsMainWrapperFlowLp.Controls.Add(this.label17);
            this.ContactsMainWrapperFlowLp.Controls.Add(this.tableLayoutPanel2);
            this.ContactsMainWrapperFlowLp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContactsMainWrapperFlowLp.Location = new System.Drawing.Point(6, 118);
            this.ContactsMainWrapperFlowLp.Name = "ContactsMainWrapperFlowLp";
            this.ContactsMainWrapperFlowLp.Size = new System.Drawing.Size(756, 270);
            this.ContactsMainWrapperFlowLp.TabIndex = 2;
            this.ContactsMainWrapperFlowLp.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(20, 3, 0, 3);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(716, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(716, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 73);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::ContactBook_PTDN_Project.Properties.Resources.rubbish_bin;
            this.pictureBox2.Location = new System.Drawing.Point(655, 41);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ContactBook_PTDN_Project.Properties.Resources.pencil;
            this.pictureBox1.Location = new System.Drawing.Point(655, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(64, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fullname:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(123, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "<fullname placeholder>";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(386, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(61, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Birth Date:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(123, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "<birthday placeholder>";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(430, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "<phone placeholder>";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(391, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(430, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 37);
            this.label8.TabIndex = 18;
            this.label8.Text = "testesttesttesetttesttesttesttesttesttestBoleslawRutkowski@gmail.com";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(20, 89);
            this.label17.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(716, 1);
            this.label17.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox4, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel6, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 103);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(20, 3, 0, 3);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(716, 0);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(716, 96);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(716, 118);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = global::ContactBook_PTDN_Project.Properties.Resources.cross;
            this.pictureBox4.Location = new System.Drawing.Point(655, 64);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::ContactBook_PTDN_Project.Properties.Resources.check_mark;
            this.pictureBox3.Location = new System.Drawing.Point(655, 34);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.textBox2);
            this.flowLayoutPanel6.Controls.Add(this.label16);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(433, 68);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(156, 41);
            this.flowLayoutPanel6.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Email ...";
            this.textBox2.Size = new System.Drawing.Size(150, 23);
            this.textBox2.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(3, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "<email placeholder>";
            this.label16.Visible = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.maskedTextBox1);
            this.flowLayoutPanel5.Controls.Add(this.label14);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(433, 9);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(156, 41);
            this.flowLayoutPanel5.TabIndex = 21;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(3, 3);
            this.maskedTextBox1.Mask = "+48 000 000 000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(150, 23);
            this.maskedTextBox1.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(3, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 12);
            this.label14.TabIndex = 19;
            this.label14.Text = "<phone placeholder>";
            this.label14.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(126, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(174, 53);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Fullname ...";
            this.textBox1.Size = new System.Drawing.Size(150, 23);
            this.textBox1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(3, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "First name should contain 2 or more letters";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(64, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Fullname:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(386, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Phone:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(391, 81);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "Email:";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.dateTimePicker1);
            this.flowLayoutPanel3.Controls.Add(this.label13);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(126, 68);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(156, 41);
            this.flowLayoutPanel3.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 23);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(3, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "<birthday placeholder>";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(61, 81);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Birth Date:";
            // 
            // ContactsHeaderLabel
            // 
            this.ContactsHeaderLabel.AutoSize = true;
            this.ContactsHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactsHeaderLabel.Location = new System.Drawing.Point(308, 37);
            this.ContactsHeaderLabel.Name = "ContactsHeaderLabel";
            this.ContactsHeaderLabel.Size = new System.Drawing.Size(151, 46);
            this.ContactsHeaderLabel.TabIndex = 1;
            this.ContactsHeaderLabel.Text = "Contacts";
            // 
            // ContactsTimer
            // 
            this.ContactsTimer.Tick += new System.EventHandler(this.ContactsTimer_Tick);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindowForm";
            this.Text = "Contact Book";
            this.MainTabControl.ResumeLayout(false);
            this.AddContactTabPage.ResumeLayout(false);
            this.AddContactTabPage.PerformLayout();
            this.ContactFormTable.ResumeLayout(false);
            this.ContactFormTable.PerformLayout();
            this.ContactEmailWrapperFlowLp.ResumeLayout(false);
            this.ContactEmailWrapperFlowLp.PerformLayout();
            this.ContactPhoneWrapperFlowLp.ResumeLayout(false);
            this.ContactPhoneWrapperFlowLp.PerformLayout();
            this.ContactBirthdayWrapperFlowLp.ResumeLayout(false);
            this.ContactBirthdayWrapperFlowLp.PerformLayout();
            this.ContactLastNameWrapperFlowLp.ResumeLayout(false);
            this.ContactLastNameWrapperFlowLp.PerformLayout();
            this.ContactFirstNameWrapperFlowLp.ResumeLayout(false);
            this.ContactFirstNameWrapperFlowLp.PerformLayout();
            this.SubmitWrapperTable.ResumeLayout(false);
            this.SubmitWrapperTable.PerformLayout();
            this.ContactsTabPage.ResumeLayout(false);
            this.ContactsTabPage.PerformLayout();
            this.ContactsMainWrapperFlowLp.ResumeLayout(false);
            this.ContactsMainWrapperFlowLp.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabControl;
        private TabPage AddContactTabPage;
        private TextBox ContactEmailInput;
        private TextBox ContactFirstNameInput;
        private Label ContactFirstNameLabel;
        private TextBox ContactLastNameInput;
        private Label ContactLastNameLabel;
        private TableLayoutPanel ContactFormTable;
        private Label ContactPhoneLabel;
        private Label ContactBirthdayLabel;
        private Label ContactEmailLabel;
        private Button SubmitContactFormButton;
        private Label ContactFormHeaderLabel;
        private FlowLayoutPanel ContactFirstNameWrapperFlowLp;
        private Label ContactFirstNameErrorLabel;
        private FlowLayoutPanel ContactLastNameWrapperFlowLp;
        private Label ContactLastNameErrorLabel;
        private FlowLayoutPanel ContactBirthdayWrapperFlowLp;
        private Label ContactBirthdayErrorLabel;
        private FlowLayoutPanel ContactPhoneWrapperFlowLp;
        private Label ContactPhoneErrorLabel;
        private FlowLayoutPanel ContactEmailWrapperFlowLp;
        private Label ContactEmailErrorLabel;
        private DateTimePicker ContactBirthdayInput;
        private MaskedTextBox ContactPhoneInput;
        private TableLayoutPanel SubmitWrapperTable;
        private Label ContactFormDbMessageLabel;
        private TabPage ContactsTabPage;
        private FlowLayoutPanel ContactsMainWrapperFlowLp;
        private TableLayoutPanel tableLayoutPanel1;
        private Label ContactsHeaderLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label15;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel6;
        private TextBox textBox2;
        private Label label16;
        private FlowLayoutPanel flowLayoutPanel5;
        private MaskedTextBox maskedTextBox1;
        private FlowLayoutPanel flowLayoutPanel3;
        private DateTimePicker dateTimePicker1;
        private Label label13;
        private Label label17;
        private DateTimePicker DateContactFilterDtp;
        private Label DateContactFilterLabel;
        private TextBox ContactSearchInput;
        private CheckBox DateContactFilterCheckBox;
        private Label label14;
        private Label label10;
        private System.Windows.Forms.Timer ContactsTimer;
    }
}