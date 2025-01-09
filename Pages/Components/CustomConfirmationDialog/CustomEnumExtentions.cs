namespace Matrix.Prox3.IntelliZone.Blazor.Pages.Components.CustomConfirmationDialog
{
    public static class CustomEnumExtentions
    {
        public static string ToBackgroundAndTextClass(this CustomBackgroundColor backgroundColor)
        {
            if (1 == 0)
            {
            }

            string result = backgroundColor switch
            {
                CustomBackgroundColor.Primary => "bg-primary text-white",
                CustomBackgroundColor.Secondary => "bg-secondary text-white",
                CustomBackgroundColor.Success => "bg-success text-white",
                CustomBackgroundColor.Danger => "bg-danger text-white",
                CustomBackgroundColor.Warning => "bg-warning text-dark",
                CustomBackgroundColor.Info => "bg-info text-dark",
                CustomBackgroundColor.Light => "bg-light text-dark",
                CustomBackgroundColor.Dark => "bg-dark text-white",
                CustomBackgroundColor.Body => "bg-body text-dark",
                CustomBackgroundColor.White => "bg-white text-dark",
                CustomBackgroundColor.Transparent => "bg-transparent text-dark",
                _ => "",
            };
            if (1 == 0)
            {
            }

            return result;
        }

        public static string ToBackgroundClass(this CustomBackgroundColor backgroundColor)
        {
            if (1 == 0)
            {
            }

            string result = backgroundColor switch
            {
                CustomBackgroundColor.Primary => "bg-primary",
                CustomBackgroundColor.Secondary => "bg-secondary",
                CustomBackgroundColor.Success => "bg-success",
                CustomBackgroundColor.Danger => "bg-danger",
                CustomBackgroundColor.Warning => "bg-warning",
                CustomBackgroundColor.Info => "bg-info",
                CustomBackgroundColor.Light => "bg-light",
                CustomBackgroundColor.Dark => "bg-dark",
                CustomBackgroundColor.Body => "bg-body",
                CustomBackgroundColor.White => "bg-white",
                CustomBackgroundColor.Transparent => "bg-transparent",
                _ => "",
            };
            if (1 == 0)
            {
            }

            return result;
        }

        public static string ToButtonClass(this CustomButtonColor buttonColor)
        {
            if (1 == 0)
            {
            }

            string result = buttonColor switch
            {
                CustomButtonColor.Primary => "btn btn-primary",
                CustomButtonColor.Secondary => "btn btn-secondary",
                CustomButtonColor.Success => "btn btn-success",
                CustomButtonColor.Danger => "btn btn-danger",
                CustomButtonColor.Warning => "btn btn-warning",
                CustomButtonColor.Info => "btn btn-info",
                CustomButtonColor.Light => "btn btn-light",
                CustomButtonColor.Dark => "btn btn-dark",
                CustomButtonColor.Link => "btn btn-link",
                _ => "btn btn-primary",
            };
            if (1 == 0)
            {
            }

            return result;
        }

        public static string ToButtonTagName(this CustomBottonTypecs buttonType)
        {
            if (1 == 0)
            {
            }

            string result = buttonType != CustomBottonTypecs.Link ? "button" : "a";
            if (1 == 0)
            {
            }

            return result;
        }

        public static string ToButtonTypeString(this CustomBottonTypecs buttonType)
        {
            if (1 == 0)
            {
            }

            string result = buttonType switch
            {
                CustomBottonTypecs.Button => "button",
                CustomBottonTypecs.Submit => "submit",
                CustomBottonTypecs.Reset => "reset",
                _ => null,
            };
            if (1 == 0)
            {
            }

            return result;
        }

        //public static string ToCalloutColor(this CalloutType calloutColor)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = calloutColor switch
        //    {
        //        CalloutType.Default => "",
        //        CalloutType.Danger => "bb-callout-danger",
        //        CalloutType.Warning => "bb-callout-warning",
        //        CalloutType.Info => "bb-callout-info",
        //        _ => "",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public static string ToSpinnerColor(this SpinnerColor Color)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = Color switch
        //    {
        //        SpinnerColor.Primary => "text-primary",
        //        SpinnerColor.Secondary => "text-secondary",
        //        SpinnerColor.Success => "text-success",
        //        SpinnerColor.Danger => "text-danger",
        //        SpinnerColor.Warning => "text-warning",
        //        SpinnerColor.Info => "text-info",
        //        SpinnerColor.Light => "text-light",
        //        SpinnerColor.Dark => "text-dark",
        //        _ => "",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public static string ToTargetString(this Target target)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = target switch
        //    {
        //        Target.Blank => "_blank",
        //        Target.Parent => "_parent",
        //        Target.Top => "_top",
        //        Target.Self => "_self",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public static string ToTooltipPlacementName(this TooltipPlacement tooltipPlacement)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = tooltipPlacement switch
        //    {
        //        TooltipPlacement.Auto => "auto",
        //        TooltipPlacement.Right => "right",
        //        TooltipPlacement.Bottom => "bottom",
        //        TooltipPlacement.Left => "left",
        //        _ => "top",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}
    }
}
