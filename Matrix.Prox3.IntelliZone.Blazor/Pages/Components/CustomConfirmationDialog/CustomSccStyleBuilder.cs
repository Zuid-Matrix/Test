namespace Matrix.Prox3.IntelliZone.Blazor.Pages.Components.CustomConfirmationDialog
{
    public class CustomSccStyleBuilder
    {
        private readonly Action<CustomSccStyleBuilder> buildStyles;

        private bool dirty = true;

        private List<string> styleList = new List<string>();

        private string? styles;

        public string? Styles
        {
            get
            {
                if (dirty)
                {
                    styleList = new List<string>();
                    buildStyles(this);
                    styles = styleList.Any() ? string.Join(";", styleList) : null;
                    dirty = false;
                }

                return styles;
            }
        }

        public CustomSccStyleBuilder(Action<CustomSccStyleBuilder> buildStyles)
        {
            this.buildStyles = buildStyles;
        }

        public void Append(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                styleList.Add(value);
            }
        }

        public void Append(string value, bool condition)
        {
            if (condition && !string.IsNullOrWhiteSpace(value))
            {
                styleList.Add(value);
            }
        }

        public void Append(IEnumerable<string> values)
        {
            if (values != null && values.Any())
            {
                styleList.AddRange(values);
            }
        }

        public void Dirty()
        {
            dirty = true;
        }
    }
}
