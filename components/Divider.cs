namespace ContactBook_PTDN_Project.components
{
    internal class Divider : IComponent
    {
        public enum DividerType { HORIZONTAL, VERTICAL };

        private readonly Label _DividerLabel;

        public Divider(int length, DividerType type = DividerType.HORIZONTAL)
        {
            var isHorizontal = type == DividerType.HORIZONTAL;

            var width = isHorizontal ? length : 1;
            var height = isHorizontal ? 1 : length;

            var topBottomMargin = isHorizontal ? 10 : 3;
            var leftRightMargin = isHorizontal ? 3 : 10;

            _DividerLabel = new()
            {
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(leftRightMargin, topBottomMargin, leftRightMargin, topBottomMargin),
                Name = "DividerLabel",
                Size = new Size(width, height)
            };
        }

        public Control Control => _DividerLabel;

        public Label DividerLabel => _DividerLabel;
    }
}
