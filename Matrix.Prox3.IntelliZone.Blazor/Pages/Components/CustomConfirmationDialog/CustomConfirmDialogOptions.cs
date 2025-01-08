namespace Matrix.Prox3.IntelliZone.Blazor.Pages.Components.CustomConfirmationDialog
{
    public class CustomConfirmDialogOptions
    {
        public string? DialogCssClass { get; set; }

        public bool Dismissable { get; set; } = true;


        public string? HeaderCssClass { get; set; }

        public bool IsScrollable { get; set; }

        public bool IsVerticallyCentered { get; set; }

        public CustomButtonColor NoButtonColor { get; set; } = CustomButtonColor.Secondary;


        public string NoButtonText { get; set; } = "No";


        public CustomDialogSize Size { get; set; }

        public CustomButtonColor YesButtonColor { get; set; } = CustomButtonColor.Secondary;


        public string YesButtonText { get; set; } = "Yes";
    }
}
