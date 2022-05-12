using ContactBook_PTDN_Project.components;
using ContactBook_PTDN_Project.models;
using System.Collections.Specialized;

namespace ContactBook_PTDN_Project
{
    public partial class MainWindowForm : Form
    {
        private List<ContactDto> _contacts = new();
        private OrderedDictionary _contactComponents = new();

        private string? _searchQuery = null;
        private long _searchDateTicks = DateTime.Now.Ticks;

        private void LoadContacts()
        {
            _contacts = new();

            var commandText = $"SELECT * FROM {DatabaseManager._contactsTableName}\n";

            if (_searchQuery != null)
            {
                commandText +=
                $@"
                    WHERE {DatabaseManager._contactsColumnNameFirstName} LIKE '%{_searchQuery}%'
                        OR {DatabaseManager._contactsColumnNameLastName} LIKE '%{_searchQuery}%'
                        OR {DatabaseManager._contactsColumnNamePhoneNumber} LIKE '%{_searchQuery}%'
                        OR {DatabaseManager._contactsColumnNameEmail} LIKE '%{_searchQuery}%'
                ";
            }
            commandText += $"ORDER BY {DatabaseManager._contactsColumnNameFirstName} ASC;";

            using var connection = DatabaseManager.ExecuteQuery(commandText, out var result, out var errorMessage);

            if (result is null)
            {
                MessageBox.Show($"Something went wrong while loading contacts !{(errorMessage is not null ? $"\nDatabase error message: {errorMessage}" : string.Empty)}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (result.Read())
            {
                var birthdayTicks = (long)result[DatabaseManager._contactsColumnNameBirthdayTicks];
                if (!HasBirthdayThisWeek(new DateTime(birthdayTicks)) && DateContactFilterCheckBox.Checked) { continue; }

                _contacts.Add(new()
                {
                    Id = (string)result[DatabaseManager._contactsColumnNameId],
                    FirstName = (string)result[DatabaseManager._contactsColumnNameFirstName],
                    LastName = (string)result[DatabaseManager._contactsColumnNameLastName],
                    BirthdayTicks = birthdayTicks,
                    Phone = (string)result[DatabaseManager._contactsColumnNamePhoneNumber],
                    Email = (string)result[DatabaseManager._contactsColumnNameEmail],
                });
            }
        }

        private void CreateContactComponents()
        {
            var contactComponents = _contactComponents;
            _contactComponents = new();

            foreach (var contact in _contacts)
            {
                var contactId = contact.Id;

                var contactComponent = contactComponents[contactId];
                if (contactComponent is not null)
                {
                    _contactComponents[contactId] = contactComponent;
                    continue;
                }

                var DeleteHandler = this.DeleteHandler(contactId);

                var contactItem = new ContactItem(716, contact, DeleteHandler);
                var contactItemContactItemWrapperTableMargin = contactItem.ContactItemWrapperTable.Margin;
                contactItemContactItemWrapperTableMargin.Left = 20;
                contactItemContactItemWrapperTableMargin.Right = 0;
                contactItem.ContactItemWrapperTable.Margin = contactItemContactItemWrapperTableMargin;

                _contactComponents.Add(contactId, contactItem);
            }
        }

        private void RenderContacts()
        {
            ContactsMainWrapperFlowLp.Controls.Clear();

            if (_contactComponents.Count == 0)
            {
                ContactsMainWrapperFlowLp.Controls.Add(new NoContactsLabel(ContactsMainWrapperFlowLp.Size).Control);
                return;
            }

            for (int i = 0; i < _contactComponents.Count; i++)
            {
                IComponent? contactComponent = (IComponent?)_contactComponents[i];
                if (contactComponent is null) { continue; }

                Divider? divider = null;
                if (i != 0)
                {
                    divider = new Divider(716);
                    var dividerDividerLabelMargin = divider.DividerLabel.Margin;
                    dividerDividerLabelMargin.Left = 20;
                    dividerDividerLabelMargin.Right = 0;
                    divider.DividerLabel.Margin = dividerDividerLabelMargin;
                }

                ContactsMainWrapperFlowLp.Controls.Add(contactComponent.Control);
                contactComponent.Control.Refresh();
                /*
                * Problem was solved this way, because previously existing contactComponent in ContactsMainWrapperFlowLp.Controls  
                * list after removal from this list and following addition to this list stays on its previous (before removal) index 
                * in ContactsMainWrapperFlowLp.Controls list, therefore dividers were adding to the end of the list with regular 
                * Controls.Add method
                */
                if (divider is not null)
                {
                    ContactsMainWrapperFlowLp.Controls.Add(divider.Control);
                    ContactsMainWrapperFlowLp.Controls.SetChildIndex(divider.Control, ContactsMainWrapperFlowLp.Controls.Count - 2);
                }
            }
        }

        private void RerenderContacts()
        {
            LoadContacts();
            CreateContactComponents();
            GC.Collect();
            RenderContacts();
        }

        private bool ValidateContactForm()
        {
            var isValid = true;

            if (!InputValidator.ValidateFirstNameInput(ContactFirstNameInput, out var errorMessage))
            {
                ContactFirstNameErrorLabel.Text = errorMessage;
                ContactFirstNameErrorLabel.Visible = true;
                isValid = false;
            }
            if (!InputValidator.ValidateLastNameInput(ContactLastNameInput, out errorMessage))
            {
                ContactLastNameErrorLabel.Text = errorMessage;
                ContactLastNameErrorLabel.Visible = true;
                isValid = false;
            }
            if (!InputValidator.ValidateBirthdayInput(ContactBirthdayInput, out errorMessage))
            {
                ContactBirthdayErrorLabel.Text = errorMessage;
                ContactBirthdayErrorLabel.Visible = true;
                isValid = false;
            }
            if (!InputValidator.ValidatePhoneInput(ContactPhoneInput, out errorMessage))
            {
                ContactPhoneErrorLabel.Text = errorMessage;
                ContactPhoneErrorLabel.Visible = true;
                isValid = false;
            }
            if (!InputValidator.ValidateEmailInput(ContactEmailInput, out errorMessage))
            {
                ContactEmailErrorLabel.Text = errorMessage;
                ContactEmailErrorLabel.Visible = true;
                isValid = false;
            }

            return isValid;
        }

        private Func<bool> DeleteHandler(string contactId) => () =>
        {
            var result = MessageBox.Show("Are you sure ?", "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) { return false; }

            var commandText =
            $@"
                DELETE FROM {DatabaseManager._contactsTableName}
                WHERE {DatabaseManager._contactsColumnNameId} = '{contactId}';
            ";
            var rowsAffected = DatabaseManager.ExecuteCommand(commandText, out var errorMessage);
            if (rowsAffected == 0)
            {
                MessageBox.Show($"Something went wrong while deleting contact !{(errorMessage is not null ? $"\nDatabase error message: {errorMessage}" : string.Empty)}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _contactComponents.Remove(contactId);
            RenderContacts();
            return true;
        };

        private bool HasBirthdayThisWeek(DateTime date)
        {
            var startOfTheWeek = GetStartOfTheWeek(new DateTime(_searchDateTicks));
            var endOfTheWeek = startOfTheWeek.AddDays(6);
            var yearDifference = endOfTheWeek.Year - date.Year;

            if (Convert.ToBoolean(endOfTheWeek.Year - startOfTheWeek.Year) && startOfTheWeek.Month == date.Month) { yearDifference--; }
            date = date.AddYears(yearDifference);
            // Reset time
            date = new DateTime(date.Year, date.Month, date.Day);

            return startOfTheWeek <= date && endOfTheWeek >= date;
        }

        private static DateTime GetStartOfTheWeek(DateTime date)
        {
            while (date.DayOfWeek != DayOfWeek.Monday) { date = date.AddDays(-1); }
            return date;
        }

        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void ContactFirstNameLabel_Click(object sender, EventArgs e)
        {
            ContactFirstNameInput.Focus();
        }

        private void ContactLastNameLabel_Click(object sender, EventArgs e)
        {
            ContactLastNameInput.Focus();
        }

        private void ContactBirthdayLabel_Click(object sender, EventArgs e)
        {
            ContactBirthdayInput.Focus();
        }

        private void ContactPhoneLabel_Click(object sender, EventArgs e)
        {
            ContactPhoneInput.Focus();
        }

        private void ContactEmailLabel_Click(object sender, EventArgs e)
        {
            ContactEmailInput.Focus();
        }

        private void ContactFirstNameInput_Leave(object sender, EventArgs e)
        {
            var ContactFirstNameInput = (TextBox)sender;

            if (!InputValidator.ValidateFirstNameInput(ContactFirstNameInput, out var errorMessage))
            {
                ContactFirstNameErrorLabel.Text = errorMessage;
                ContactFirstNameErrorLabel.Visible = true;
                return;
            }

            ContactFirstNameErrorLabel.Visible = false;
        }

        private void ContactLastNameInput_Leave(object sender, EventArgs e)
        {
            var ContactLastNameInput = (TextBox)sender;

            if (!InputValidator.ValidateLastNameInput(ContactLastNameInput, out var errorMessage))
            {
                ContactLastNameErrorLabel.Text = errorMessage;
                ContactLastNameErrorLabel.Visible = true;
                return;
            }

            ContactLastNameErrorLabel.Visible = false;
        }

        private void ContactBirthdayInput_Leave(object sender, EventArgs e)
        {
            var ContactBirthdayInput = (DateTimePicker)sender;

            if (!InputValidator.ValidateBirthdayInput(ContactBirthdayInput, out var errorMessage))
            {
                ContactBirthdayErrorLabel.Text = errorMessage;
                ContactBirthdayErrorLabel.Visible = true;
                return;
            }

            ContactBirthdayErrorLabel.Visible = false;
        }

        private void ContactPhoneInput_Leave(object sender, EventArgs e)
        {
            var ContactPhoneInput = (MaskedTextBox)sender;

            if (!InputValidator.ValidatePhoneInput(ContactPhoneInput, out var errorMessage))
            {
                ContactPhoneErrorLabel.Text = errorMessage;
                ContactPhoneErrorLabel.Visible = true;
                return;
            }

            ContactPhoneErrorLabel.Visible = false;
        }

        private void ContactEmailInput_Leave(object sender, EventArgs e)
        {
            var ContactEmailInput = (TextBox)sender;

            if (!InputValidator.ValidateEmailInput(ContactEmailInput, out var errorMessage))
            {
                ContactEmailErrorLabel.Text = errorMessage;
                ContactEmailErrorLabel.Visible = true;
                return;
            }

            ContactEmailErrorLabel.Visible = false;
        }

        private void SubmitContactFormButton_Click(object sender, EventArgs e)
        {
            ContactFormDbMessageLabel.Visible = false;

            if (!ValidateContactForm())
            {
                MessageBox.Show("Contact form is invalid !", "Contact Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var firstNameInputValue = ContactFirstNameInput.Text.Trim();
            var lastNameInputValue = ContactLastNameInput.Text.Trim();
            var birthdayInputValue = ContactBirthdayInput.Value;
            var phoneInputValue = ContactPhoneInput.Text;
            var emailInputValue = ContactEmailInput.Text.Trim();

            var commandText =
            @$"
                INSERT INTO {DatabaseManager._contactsTableName} (
                    {DatabaseManager._contactsColumnNameId}, 
                    {DatabaseManager._contactsColumnNameFirstName}, 
                    {DatabaseManager._contactsColumnNameLastName}, 
                    {DatabaseManager._contactsColumnNameBirthdayTicks}, 
                    {DatabaseManager._contactsColumnNamePhoneNumber}, 
                    {DatabaseManager._contactsColumnNameEmail}
                )
                VALUES (
                    '{Guid.NewGuid()}', 
                    '{firstNameInputValue}', 
                    '{lastNameInputValue}', 
                    {birthdayInputValue.Ticks}, 
                    '{phoneInputValue}', 
                    '{emailInputValue}'
                );
            ";

            var rowsAffected = DatabaseManager.ExecuteCommand(commandText, out var errorMessage);
            if (rowsAffected == 0)
            {
                MessageBox.Show($"Something went wrong while saving contact !{(errorMessage is not null ? $"\nDatabase error message: {errorMessage}" : string.Empty)}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ContactFirstNameInput.Text = string.Empty;
            ContactLastNameInput.Text = string.Empty;
            ContactBirthdayInput.Value = DateTime.Now;
            ContactPhoneInput.Text = string.Empty;
            ContactEmailInput.Text = string.Empty;

            ContactFormDbMessageLabel.Text = "Contact successfully saved !";
            ContactFormDbMessageLabel.Visible = true;
        }

        private void ContactsTabPage_Enter(object sender, EventArgs e) => RerenderContacts();

        private void ContactSearchInput_TextChanged(object sender, EventArgs e)
        {
            var ContactSearchInput = (TextBox)sender;
            _searchQuery = ContactSearchInput.Text.Trim();
            RerenderContacts();
        }

        private void DateContactFilterDtp_ValueChanged(object sender, EventArgs e)
        {
            var DateContactFilterDtp = (DateTimePicker)sender;
            _searchDateTicks = DateContactFilterDtp.Value.Ticks;
            RerenderContacts();
        }

        private void DateContactFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var DateContactFilterCheckBox = (CheckBox)sender;
            if (DateContactFilterCheckBox.Checked) { DateContactFilterDtp.Enabled = true; }
            else { DateContactFilterDtp.Enabled = false; }
            RerenderContacts();
        }

        private void DateContactFilterLabel_Click(object sender, EventArgs e) => DateContactFilterDtp.Focus();
    }
}