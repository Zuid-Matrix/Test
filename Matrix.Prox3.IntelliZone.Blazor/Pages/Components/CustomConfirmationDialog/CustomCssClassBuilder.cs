namespace Matrix.Prox3.IntelliZone.Blazor.Pages.Components.CustomConfirmationDialog
{
    public class CustomCssClassBuilder
    {
        private readonly Action<CustomCssClassBuilder> buildClasses;

        private List<string> classList = new List<string>();

        private string? classNames;

        private bool dirty = true;

        public string? ClassNames
        {
            get
            {
                if (dirty)
                {
                    classList = new List<string>();
                    buildClasses(this);
                    classNames = classList.Any() ? string.Join(" ", classList) : null;
                    dirty = false;
                }

                return classNames;
            }
        }

        public CustomCssClassBuilder(Action<CustomCssClassBuilder> buildClasses)
        {
            this.buildClasses = buildClasses;
        }

        public void Append(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                classList.Add(value);
            }
        }

        public void Append(string value, bool condition)
        {
            if (condition && !string.IsNullOrWhiteSpace(value))
            {
                classList.Add(value);
            }
        }

        public void Append(IEnumerable<string> values)
        {
            if (values != null && values.Any())
            {
                classList.AddRange(values);
            }
        }

        public void Dirty()
        {
            dirty = true;
        }
    }
}
