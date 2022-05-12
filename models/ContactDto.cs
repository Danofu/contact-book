namespace ContactBook_PTDN_Project.models
{
    internal class ContactDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public long BirthdayTicks { get; set; } = 0;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public void Deconstruct(out string firstName, out string lastName, out long birthdayTicks, out string phone, out string email)
        {
            firstName = FirstName;
            lastName = LastName;
            birthdayTicks = BirthdayTicks;
            phone = Phone;
            email = Email;
        }
    }
}
