using ContactBook_PTDN_Project.models;
using System.ComponentModel;

namespace ContactBook_PTDN_Project.components
{
    internal class ContactItem : IComponent
    {
        #region Controls declaration
        private readonly TableLayoutPanel _ContactItemWrapperTable;

        private readonly FlowLayoutPanel _FullNameWrapperFlowLp;
        private readonly FlowLayoutPanel _BirthdayWrapperFlowLp;
        private readonly FlowLayoutPanel _PhoneWrapperFlowLp;
        private readonly FlowLayoutPanel _EmailWrapperFlowLp;

        private readonly TextBox _FullNameInput;
        private readonly TextBox _EmailInput;
        private readonly DateTimePicker _BirthdayInput;
        private readonly MaskedTextBox _PhoneInput;

        private readonly Label _FullNameLabel;
        private readonly Label _FullNameValueLabel;
        private readonly Label _BirthdayLabel;
        private readonly Label _BirthdayValueLabel;
        private readonly Label _PhoneLabel;
        private readonly Label _PhoneValueLabel;
        private readonly Label _EmailLabel;
        private readonly Label _EmailValueLabel;

        private readonly Label _FullNameErrorLabel;
        private readonly Label _BirthdayErrorLabel;
        private readonly Label _PhoneErrorLabel;
        private readonly Label _EmailErrorLabel;

        private readonly PictureBox _EditImage;
        private readonly PictureBox _DeleteImage;
        private readonly PictureBox _SubmitImage;
        private readonly PictureBox _CancelImage;
        #endregion

        private readonly ToolTip _toolTip = new()
        {
            AutoPopDelay = 5 * 1000,
            InitialDelay = 1 * 1000,
            ReshowDelay = 500,
        };

        private readonly ContactDto _contact;
        private readonly Func<bool> OnDelete;

        private string _fullNameValue;
        private long _birthdayTicksValue;
        private string _phoneValue;
        private string _emailValue;

        private bool _isFullNameChanged = false;
        private bool _isBirthdayChanged = false;
        private bool _isPhoneChanged = false;
        private bool _isEmailChanged = false;

        public ContactItem(int width, ContactDto contactDto, Func<bool> OnDelete)
        {
            var (firstName, lastName, birthday, phone, email) = contactDto;

            _contact = contactDto;
            this.OnDelete = OnDelete;

            _fullNameValue = $"{firstName} {lastName}";
            _birthdayTicksValue = birthday;
            _phoneValue = phone;
            _emailValue = email;

            var birthdayValue = new DateTime(_birthdayTicksValue).ToString("dd MMMM yyyy");

            #region Controls initialization
            _ContactItemWrapperTable = new TableLayoutPanel();

            _FullNameWrapperFlowLp = new FlowLayoutPanel();
            _BirthdayWrapperFlowLp = new FlowLayoutPanel();
            _PhoneWrapperFlowLp = new FlowLayoutPanel();
            _EmailWrapperFlowLp = new FlowLayoutPanel();

            _FullNameInput = new TextBox();
            _EmailInput = new TextBox();
            _BirthdayInput = new DateTimePicker();
            _PhoneInput = new MaskedTextBox();

            _FullNameLabel = new Label();
            _FullNameValueLabel = new Label();
            _BirthdayLabel = new Label();
            _BirthdayValueLabel = new Label();
            _PhoneLabel = new Label();
            _PhoneValueLabel = new Label();
            _EmailLabel = new Label();
            _EmailValueLabel = new Label();

            _FullNameErrorLabel = new Label();
            _BirthdayErrorLabel = new Label();
            _PhoneErrorLabel = new Label();
            _EmailErrorLabel = new Label();

            _EditImage = new PictureBox();
            _DeleteImage = new PictureBox();
            _SubmitImage = new PictureBox();
            _CancelImage = new PictureBox();
            #endregion

            #region Controls pre setup
            _ContactItemWrapperTable.SuspendLayout();

            _FullNameWrapperFlowLp.SuspendLayout();
            _BirthdayWrapperFlowLp.SuspendLayout();
            _PhoneWrapperFlowLp.SuspendLayout();
            _EmailWrapperFlowLp.SuspendLayout();

            ((ISupportInitialize)_EditImage).BeginInit();
            ((ISupportInitialize)_DeleteImage).BeginInit();
            ((ISupportInitialize)_SubmitImage).BeginInit();
            ((ISupportInitialize)_CancelImage).BeginInit();
            #endregion

            #region Controls setup
            //
            // ContactItemWrapperTable
            //
            _ContactItemWrapperTable.ColumnCount = 5;
            _ContactItemWrapperTable.RowCount = 2;
            _ContactItemWrapperTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            _ContactItemWrapperTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            _ContactItemWrapperTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            _ContactItemWrapperTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            _ContactItemWrapperTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            _ContactItemWrapperTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            _ContactItemWrapperTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            _ContactItemWrapperTable.Controls.Add(_FullNameLabel, 0, 0);
            _ContactItemWrapperTable.Controls.Add(_BirthdayLabel, 0, 1);
            _ContactItemWrapperTable.Controls.Add(_FullNameValueLabel, 1, 0);
            _ContactItemWrapperTable.Controls.Add(_BirthdayValueLabel, 1, 1);
            _ContactItemWrapperTable.Controls.Add(_PhoneLabel, 2, 0);
            _ContactItemWrapperTable.Controls.Add(_EmailLabel, 2, 1);
            _ContactItemWrapperTable.Controls.Add(_PhoneValueLabel, 3, 0);
            _ContactItemWrapperTable.Controls.Add(_EmailValueLabel, 3, 1);
            _ContactItemWrapperTable.Controls.Add(_EditImage, 4, 0);
            _ContactItemWrapperTable.Controls.Add(_DeleteImage, 4, 1);
            _ContactItemWrapperTable.Name = "ContactItemWrapperTable";
            _ContactItemWrapperTable.Size = new Size(width, 73);
            _ContactItemWrapperTable.MinimumSize = new Size(width, 73);
            _ContactItemWrapperTable.MaximumSize = new Size(width, 0);
            _ContactItemWrapperTable.AutoSize = true;
            //
            // FullNameLabel
            //
            _FullNameLabel.Anchor = AnchorStyles.Right;
            _FullNameLabel.AutoSize = true;
            _FullNameLabel.BackColor = Color.Transparent;
            _FullNameLabel.Name = "FullNameLabel";
            _FullNameLabel.Text = "Full name:";
            //
            // FullNameValueLabel
            //
            _FullNameValueLabel.Anchor = AnchorStyles.Left;
            _FullNameValueLabel.AutoSize = true;
            _FullNameValueLabel.BackColor = Color.Transparent;
            _FullNameValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _FullNameValueLabel.Name = "FullNameValueLabel";
            _FullNameValueLabel.Text = _fullNameValue;
            _FullNameValueLabel.AutoEllipsis = true;
            //
            // BirthdayLabel
            //
            _BirthdayLabel.Anchor = AnchorStyles.Right;
            _BirthdayLabel.AutoSize = true;
            _BirthdayLabel.BackColor = Color.Transparent;
            _BirthdayLabel.Name = "BirthdayLabel";
            _BirthdayLabel.Text = "Birth Date:";
            //
            // BirthdayValueLabel
            //
            _BirthdayValueLabel.Anchor = AnchorStyles.Left;
            _BirthdayValueLabel.AutoSize = true;
            _BirthdayValueLabel.BackColor = Color.Transparent;
            _BirthdayValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _BirthdayValueLabel.Name = "BirthdayValueLabel";
            _BirthdayValueLabel.Text = birthdayValue;
            _BirthdayValueLabel.AutoEllipsis = true;
            //
            // PhoneLabel
            //
            _PhoneLabel.Anchor = AnchorStyles.Right;
            _PhoneLabel.AutoSize = true;
            _PhoneLabel.BackColor = Color.Transparent;
            _PhoneLabel.Name = "PhoneLabel";
            _PhoneLabel.Text = "Phone:";
            //
            // PhoneValueLabel
            //
            _PhoneValueLabel.Anchor = AnchorStyles.Left;
            _PhoneValueLabel.AutoSize = true;
            _PhoneValueLabel.BackColor = Color.Transparent;
            _PhoneValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _PhoneValueLabel.Name = "PhoneValueLabel";
            _PhoneValueLabel.Text = _phoneValue;
            _PhoneValueLabel.AutoEllipsis = true;
            //
            // EmailLabel
            //
            _EmailLabel.Anchor = AnchorStyles.Right;
            _EmailLabel.AutoSize = true;
            _EmailLabel.BackColor = Color.Transparent;
            _EmailLabel.Name = "EmailLabel";
            _EmailLabel.Text = "Email:";
            //
            // EmailValueLabel
            //
            _EmailValueLabel.Anchor = AnchorStyles.Left;
            _EmailValueLabel.AutoSize = true;
            _EmailValueLabel.BackColor = Color.Transparent;
            _EmailValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _EmailValueLabel.Name = "EmailValueLabel";
            _EmailValueLabel.Text = _emailValue;
            _EmailValueLabel.AutoEllipsis = true;
            //
            // EditImage
            //
            _EditImage.Anchor = AnchorStyles.Bottom;
            _EditImage.ErrorImage = null;
            _EditImage.Image = Properties.Resources.pencil;
            _EditImage.Name = "EditImage";
            _EditImage.Size = new Size(20, 20);
            _EditImage.SizeMode = PictureBoxSizeMode.Zoom;
            _EditImage.TabStop = false;
            _EditImage.Margin = new Padding(3, 3, 3, 5);
            //
            // DeleteImage
            //
            _DeleteImage.Anchor = AnchorStyles.Top;
            _DeleteImage.ErrorImage = null;
            _DeleteImage.Image = Properties.Resources.rubbish_bin;
            _DeleteImage.Name = "DeleteImage";
            _DeleteImage.Size = new Size(20, 20);
            _DeleteImage.SizeMode = PictureBoxSizeMode.Zoom;
            _DeleteImage.TabStop = false;
            _DeleteImage.Margin = new Padding(3, 5, 3, 3);
            //
            // SubmitImage
            //
            _SubmitImage.Anchor = AnchorStyles.Bottom;
            _SubmitImage.ErrorImage = null;
            _SubmitImage.Image = Properties.Resources.check_mark;
            _SubmitImage.Name = "SubmitImage";
            _SubmitImage.Size = new Size(20, 20);
            _SubmitImage.SizeMode = PictureBoxSizeMode.Zoom;
            _SubmitImage.TabStop = false;
            _SubmitImage.Margin = new Padding(3, 3, 3, 5);
            //
            // CancelImage
            //
            _CancelImage.Anchor = AnchorStyles.Top;
            _CancelImage.ErrorImage = null;
            _CancelImage.Image = Properties.Resources.cross;
            _CancelImage.Name = "CancelImage";
            _CancelImage.Size = new Size(20, 20);
            _CancelImage.SizeMode = PictureBoxSizeMode.Zoom;
            _CancelImage.TabStop = false;
            _CancelImage.Margin = new Padding(3, 3, 3, 5);
            //
            // FullNameWrapperFlowLp
            //
            _FullNameWrapperFlowLp.Anchor = AnchorStyles.Left;
            _FullNameWrapperFlowLp.AutoSize = true;
            _FullNameWrapperFlowLp.Controls.Add(_FullNameInput);
            _FullNameWrapperFlowLp.Controls.Add(_FullNameErrorLabel);
            _FullNameWrapperFlowLp.FlowDirection = FlowDirection.TopDown;
            _FullNameWrapperFlowLp.Name = "FullNameWrapperFlowLp";
            //
            // BirthdayWrapperFlowLp
            //
            _BirthdayWrapperFlowLp.Anchor = AnchorStyles.Left;
            _BirthdayWrapperFlowLp.AutoSize = true;
            _BirthdayWrapperFlowLp.Controls.Add(_BirthdayInput);
            _BirthdayWrapperFlowLp.Controls.Add(_BirthdayErrorLabel);
            _BirthdayWrapperFlowLp.FlowDirection = FlowDirection.TopDown;
            _BirthdayWrapperFlowLp.Name = "BirthdayWrapperFlowLp";
            //
            // PhoneWrapperFlowLp
            //
            _PhoneWrapperFlowLp.Anchor = AnchorStyles.Left;
            _PhoneWrapperFlowLp.AutoSize = true;
            _PhoneWrapperFlowLp.Controls.Add(_PhoneInput);
            _PhoneWrapperFlowLp.Controls.Add(_PhoneErrorLabel);
            _PhoneWrapperFlowLp.FlowDirection = FlowDirection.TopDown;
            _PhoneWrapperFlowLp.Name = "PhoneWrapperFlowLp";
            //
            // EmailWrapperFlowLp
            //
            _EmailWrapperFlowLp.Anchor = AnchorStyles.Left;
            _EmailWrapperFlowLp.AutoSize = true;
            _EmailWrapperFlowLp.Controls.Add(_EmailInput);
            _EmailWrapperFlowLp.Controls.Add(_EmailErrorLabel);
            _EmailWrapperFlowLp.FlowDirection = FlowDirection.TopDown;
            _EmailWrapperFlowLp.Name = "EmailWrapperFlowLp";
            //
            // FullNameInput
            //
            _FullNameInput.Name = "FullNameInput";
            _FullNameInput.Width = 150;
            _FullNameInput.PlaceholderText = "Full name ...";
            _FullNameInput.Text = _fullNameValue;
            //
            // EmailInput
            //
            _EmailInput.Name = "EmailInput";
            _EmailInput.Width = 150;
            _EmailInput.PlaceholderText = "Email ...";
            _EmailInput.Text = _emailValue;
            //
            // BirthdayInput
            //
            _BirthdayInput.CustomFormat = "dd.MM.yyyy";
            _BirthdayInput.Format = DateTimePickerFormat.Custom;
            _BirthdayInput.Name = "BirthdayInput";
            _BirthdayInput.Width = 150;
            _BirthdayInput.Value = new DateTime(_birthdayTicksValue);
            //
            // PhoneInput
            //
            _PhoneInput.Mask = "+48 000 000 000";
            _PhoneInput.Name = "PhoneInput";
            _PhoneInput.Width = 150;
            _PhoneInput.Text = _phoneValue;
            //
            // FullNameErrorLabel
            //
            _FullNameErrorLabel.AutoSize = true;
            _FullNameErrorLabel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            _FullNameErrorLabel.ForeColor = Color.Red;
            _FullNameErrorLabel.Name = "FullNameErrorLabel";
            _FullNameErrorLabel.Text = "<full name placeholder>";
            _FullNameErrorLabel.Visible = false;
            //
            // BirthdayErrorLabel
            //
            _BirthdayErrorLabel.AutoSize = true;
            _BirthdayErrorLabel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            _BirthdayErrorLabel.ForeColor = Color.Red;
            _BirthdayErrorLabel.Name = "BirthdayErrorLabel";
            _BirthdayErrorLabel.Text = "<birthday placeholder>";
            _BirthdayErrorLabel.Visible = false;
            //
            // PhoneErrorLabel
            //
            _PhoneErrorLabel.AutoSize = true;
            _PhoneErrorLabel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            _PhoneErrorLabel.ForeColor = Color.Red;
            _PhoneErrorLabel.Name = "PhoneErrorLabel";
            _PhoneErrorLabel.Text = "<phone placeholder>";
            _PhoneErrorLabel.Visible = false;
            //
            // EmailErrorLabel
            //
            _EmailErrorLabel.AutoSize = true;
            _EmailErrorLabel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            _EmailErrorLabel.ForeColor = Color.Red;
            _EmailErrorLabel.Name = "EmailErrorLabel";
            _EmailErrorLabel.Text = "<email placeholder>";
            _EmailErrorLabel.Visible = false;
            #endregion

            #region Controls post setup
            _ContactItemWrapperTable.ResumeLayout(true);

            _FullNameWrapperFlowLp.ResumeLayout(true);
            _BirthdayWrapperFlowLp.ResumeLayout(true);
            _PhoneWrapperFlowLp.ResumeLayout(true);
            _EmailWrapperFlowLp.ResumeLayout(true);

            ((ISupportInitialize)_EditImage).EndInit();
            ((ISupportInitialize)_DeleteImage).EndInit();
            ((ISupportInitialize)_SubmitImage).EndInit();
            ((ISupportInitialize)_CancelImage).EndInit();

            _toolTip.SetToolTip(_FullNameValueLabel, _fullNameValue);
            _toolTip.SetToolTip(_BirthdayValueLabel, birthdayValue);
            _toolTip.SetToolTip(_PhoneValueLabel, _phoneValue);
            _toolTip.SetToolTip(_EmailValueLabel, _emailValue);
            #endregion

            #region Controls event handlers assignment
            _FullNameInput.Enter += FullNameInput_Enter;
            _FullNameInput.Leave += FullNameInput_Leave;

            _BirthdayInput.Enter += BirthdayInput_Enter;
            _BirthdayInput.Leave += BirthdayInput_Leave;

            _PhoneInput.Enter += PhoneInput_Enter;
            _PhoneInput.Leave += PhoneInput_Leave;

            _EmailInput.Enter += EmailInput_Enter;
            _EmailInput.Leave += EmailInput_Leave;

            _EditImage.Click += EditImage_Click;
            _EditImage.MouseEnter += EditImage_MouseEnter;
            _EditImage.MouseLeave += EditImage_MouseLeave;

            _DeleteImage.Click += DeleteImage_Click;
            _DeleteImage.MouseEnter += DeleteImage_MouseEnter;
            _DeleteImage.MouseLeave += DeleteImage_MouseLeave;

            _SubmitImage.Click += SubmitImage_Click;
            _SubmitImage.MouseEnter += SubmitImage_MouseEnter;
            _SubmitImage.MouseLeave += SubmitImage_MouseLeave;

            _CancelImage.Click += CancelImage_Click;
            _CancelImage.MouseEnter += CancelImage_MouseEnter;
            _CancelImage.MouseLeave += CancelImage_MouseLeave;
            #endregion 
        }

        public Control Control => _ContactItemWrapperTable;

        private void TogglePreviewMode()
        {
            _ContactItemWrapperTable.Controls.Remove(_FullNameWrapperFlowLp);
            _ContactItemWrapperTable.Controls.Remove(_BirthdayWrapperFlowLp);
            _ContactItemWrapperTable.Controls.Remove(_PhoneWrapperFlowLp);
            _ContactItemWrapperTable.Controls.Remove(_EmailWrapperFlowLp);
            _ContactItemWrapperTable.Controls.Remove(_SubmitImage);
            _ContactItemWrapperTable.Controls.Remove(_CancelImage);

            _ContactItemWrapperTable.Controls.Add(_FullNameValueLabel, 1, 0);
            _ContactItemWrapperTable.Controls.Add(_BirthdayValueLabel, 1, 1);
            _ContactItemWrapperTable.Controls.Add(_PhoneValueLabel, 3, 0);
            _ContactItemWrapperTable.Controls.Add(_EmailValueLabel, 3, 1);
            _ContactItemWrapperTable.Controls.Add(_EditImage, 4, 0);
            _ContactItemWrapperTable.Controls.Add(_DeleteImage, 4, 1);
        }

        private void ResetInputs()
        {
            _FullNameInput.Text = _fullNameValue;
            _BirthdayInput.Value = new DateTime(_birthdayTicksValue);
            _PhoneInput.Text = _phoneValue;
            _EmailInput.Text = _emailValue;

            _isFullNameChanged = false;
            _isBirthdayChanged = false;
            _isPhoneChanged = false;
            _isEmailChanged = false;

            _FullNameErrorLabel.Visible = false;
            _BirthdayErrorLabel.Visible = false;
            _PhoneErrorLabel.Visible = false;
            _EmailErrorLabel.Visible = false;
        }

        private bool ValidateForm()
        {
            var isValid = true;

            if (!InputValidator.ValidateFullNameInput(_FullNameInput, out var errorMessage))
            {
                _FullNameErrorLabel.Text = errorMessage;
                _FullNameErrorLabel.Visible = true;
                isValid = false;
            }
            if (!InputValidator.ValidateBirthdayInput(_BirthdayInput, out errorMessage))
            {
                _BirthdayErrorLabel.Text = errorMessage;
                _BirthdayErrorLabel.Visible = true;
                isValid = false;
            }
            if (!InputValidator.ValidatePhoneInput(_PhoneInput, out errorMessage))
            {
                _PhoneErrorLabel.Text = errorMessage;
                _PhoneErrorLabel.Visible = true;
                isValid = false;
            }
            if (!InputValidator.ValidateEmailInput(_EmailInput, out errorMessage))
            {
                _EmailErrorLabel.Text = errorMessage;
                _EmailErrorLabel.Visible = true;
                isValid = false;
            }

            return isValid;
        }

        #region Controls event handlers
        private void FullNameInput_Enter(object? sender, EventArgs e) => _isFullNameChanged = true;
        private void FullNameInput_Leave(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var FullNameInput = (TextBox)sender;

            if (!InputValidator.ValidateFullNameInput(FullNameInput, out var errorMessage))
            {
                _FullNameErrorLabel.Text = errorMessage;
                _FullNameErrorLabel.Visible = true;
                return;
            }

            _FullNameErrorLabel.Visible = false;
        }

        private void BirthdayInput_Enter(object? sender, EventArgs e) => _isBirthdayChanged = true;
        private void BirthdayInput_Leave(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var BirthdayInput = (DateTimePicker)sender;

            if (!InputValidator.ValidateBirthdayInput(BirthdayInput, out var errorMessage))
            {
                _BirthdayErrorLabel.Text = errorMessage;
                _FullNameErrorLabel.Visible = true;
                return;
            }

            _BirthdayErrorLabel.Visible = false;
        }

        private void PhoneInput_Enter(object? sender, EventArgs e) => _isPhoneChanged = true;
        private void PhoneInput_Leave(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var PhoneInput = (MaskedTextBox)sender;

            if (!InputValidator.ValidatePhoneInput(PhoneInput, out var errorMessage))
            {
                _PhoneErrorLabel.Text = errorMessage;
                _PhoneErrorLabel.Visible = true;
                return;
            }

            _PhoneErrorLabel.Visible = false;
        }

        private void EmailInput_Enter(object? sender, EventArgs e) => _isEmailChanged = true;
        private void EmailInput_Leave(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var EmailInput = (TextBox)sender;

            if (!InputValidator.ValidateEmailInput(EmailInput, out var errorMessage))
            {
                _EmailErrorLabel.Text = errorMessage;
                _EmailErrorLabel.Visible = true;
                return;
            }

            _EmailErrorLabel.Visible = false;
        }

        private void EditImage_Click(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var EditImage = (PictureBox)sender;

            _ContactItemWrapperTable.Controls.Remove(_FullNameValueLabel);
            _ContactItemWrapperTable.Controls.Remove(_BirthdayValueLabel);
            _ContactItemWrapperTable.Controls.Remove(_PhoneValueLabel);
            _ContactItemWrapperTable.Controls.Remove(_EmailValueLabel);
            _ContactItemWrapperTable.Controls.Remove(EditImage);
            _ContactItemWrapperTable.Controls.Remove(_DeleteImage);

            _ContactItemWrapperTable.Controls.Add(_FullNameWrapperFlowLp, 1, 0);
            _ContactItemWrapperTable.Controls.Add(_BirthdayWrapperFlowLp, 1, 1);
            _ContactItemWrapperTable.Controls.Add(_PhoneWrapperFlowLp, 3, 0);
            _ContactItemWrapperTable.Controls.Add(_EmailWrapperFlowLp, 3, 1);
            _ContactItemWrapperTable.Controls.Add(_SubmitImage, 4, 0);
            _ContactItemWrapperTable.Controls.Add(_CancelImage, 4, 1);
        }
        private void EditImage_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var EditImage = (PictureBox)sender;
            EditImage.Image.Dispose();
            EditImage.Image = Properties.Resources.pencil_blue;
        }
        private void EditImage_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var EditImage = (PictureBox)sender;
            EditImage.Image.Dispose();
            EditImage.Image = Properties.Resources.pencil;
        }

        private void DeleteImage_Click(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            if (OnDelete())
            {
                _EditImage.Image.Dispose();
                _DeleteImage.Image.Dispose();
                _SubmitImage.Image.Dispose();
                _CancelImage.Image.Dispose();
            };
        }
        private void DeleteImage_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var DeleteImage = (PictureBox)sender;
            DeleteImage.Image.Dispose();
            DeleteImage.Image = Properties.Resources.rubbish_bin_red;
        }
        private void DeleteImage_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var DeleteImage = (PictureBox)sender;
            DeleteImage.Image.Dispose();
            DeleteImage.Image = Properties.Resources.rubbish_bin;
        }

        private void SubmitImage_Click(object? sender, EventArgs e)
        {
            var isFormChanged = _isFullNameChanged || _isBirthdayChanged || _isPhoneChanged || _isEmailChanged;

            if (!isFormChanged)
            {
                TogglePreviewMode();
                return;
            }

            if (!ValidateForm())
            {
                MessageBox.Show("Form is invalid !", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fullNameValue = _FullNameInput.Text.Trim();
            var splitFullName = fullNameValue.Split(" ");
            var firstNameValue = splitFullName[0].Trim();
            var lastNameValue = splitFullName[1].Trim();
            var birthdayTicksValue = _BirthdayInput.Value.Ticks;
            var phoneValue = _PhoneInput.Text;
            var emailValue = _EmailInput.Text.Trim();

            var commandText =
            $@"
                UPDATE {DatabaseManager._contactsTableName}
                SET 
                    {DatabaseManager._contactsColumnNameFirstName} = '{firstNameValue}',
                    {DatabaseManager._contactsColumnNameLastName} = '{lastNameValue}',
                    {DatabaseManager._contactsColumnNameBirthdayTicks} = {birthdayTicksValue},
                    {DatabaseManager._contactsColumnNamePhoneNumber} = '{phoneValue}',
                    {DatabaseManager._contactsColumnNameEmail} = '{emailValue}'
                WHERE {DatabaseManager._contactsColumnNameId} = '{_contact.Id}';
            ";
            var rowsAffected = DatabaseManager.ExecuteCommand(commandText, out var errorMessage);
            if (rowsAffected == 0)
            {
                MessageBox.Show($"Something went wrong while saving contact !{(errorMessage is not null ? $"\nDatabase error message: {errorMessage}" : string.Empty)}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _fullNameValue = fullNameValue;
            _birthdayTicksValue = birthdayTicksValue;
            _phoneValue = phoneValue;
            _emailValue = emailValue;

            var birhdayValue = new DateTime(_birthdayTicksValue).ToString("dd.MM.yyyy");

            _FullNameValueLabel.Text = _fullNameValue;
            _BirthdayValueLabel.Text = birhdayValue;
            _PhoneValueLabel.Text = _phoneValue;
            _EmailValueLabel.Text = _emailValue;

            _toolTip.SetToolTip(_FullNameValueLabel, _fullNameValue);
            _toolTip.SetToolTip(_BirthdayValueLabel, birhdayValue);
            _toolTip.SetToolTip(_PhoneValueLabel, _phoneValue);
            _toolTip.SetToolTip(_EmailValueLabel, _emailValue);

            TogglePreviewMode();
        }
        private void SubmitImage_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var SubmitImage = (PictureBox)sender;
            SubmitImage.Image.Dispose();
            SubmitImage.Image = Properties.Resources.check_mark_green;
        }
        private void SubmitImage_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var SubmitImage = (PictureBox)sender;
            SubmitImage.Image.Dispose();
            SubmitImage.Image = Properties.Resources.check_mark;
        }

        private void CancelImage_Click(object? sender, EventArgs e)
        {
            if (sender is null) { return; }

            var isFormChanged = _isFullNameChanged || _isBirthdayChanged || _isPhoneChanged || _isEmailChanged;
            if (isFormChanged)
            {
                var result = MessageBox.Show("Are you sure you want cancel ? All changes will be discarded !", "Cancel Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { return; }
            }

            TogglePreviewMode();
            ResetInputs();
        }
        private void CancelImage_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var CancelImage = (PictureBox)sender;
            CancelImage.Image.Dispose();
            CancelImage.Image = Properties.Resources.cross_red;
        }
        private void CancelImage_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is null) { return; }
            var CancelImage = (PictureBox)sender;
            CancelImage.Image.Dispose();
            CancelImage.Image = Properties.Resources.cross;
        }
        #endregion

        #region Control getters
        public TableLayoutPanel ContactItemWrapperTable => _ContactItemWrapperTable;
        public FlowLayoutPanel FullNameWrapperFlowLp => _FullNameWrapperFlowLp;
        public FlowLayoutPanel BirthdayWrapperFlowLp => _BirthdayWrapperFlowLp;
        public FlowLayoutPanel PhoneWrapperFlowLp => _PhoneWrapperFlowLp;
        public FlowLayoutPanel EmailWrapperFlowLp => _EmailWrapperFlowLp;
        public TextBox FullNameInput => _FullNameInput;
        public TextBox EmailInput => _EmailInput;
        public DateTimePicker BirthdayInput => _BirthdayInput;
        public MaskedTextBox PhoneInput => _PhoneInput;
        public Label FullNameLabel => _FullNameLabel;
        public Label FullNameValueLabel => _FullNameValueLabel;
        public Label BirthdayLabel => _BirthdayLabel;
        public Label BirthdayValueLabel => _BirthdayValueLabel;
        public Label PhoneLabel => _PhoneLabel;
        public Label PhoneValueLabel => _PhoneValueLabel;
        public Label EmailLabel => _EmailLabel;
        public Label EmailValueLabel => _EmailValueLabel;
        public PictureBox EditImage => _EditImage;
        public PictureBox DeleteImage => _DeleteImage;
        #endregion
    }
}
