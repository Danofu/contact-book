namespace ContactBook_PTDN_Project.components
{
    internal class NoContactsLabel : IComponent
    {
        private readonly Label _noContactLabel;

        internal NoContactsLabel(Size size)
        {
            _noContactLabel = new()
            {
                Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = SystemColors.GrayText,
                Margin = new Padding(0),
                Name = "NoContactsLabel",
                Size = size,
                Text = "No Contacts Found",
                TextAlign = ContentAlignment.MiddleCenter
            };
        }

        public Control Control => _noContactLabel;

        internal Label NoContactLabel => _noContactLabel;
    }
}
