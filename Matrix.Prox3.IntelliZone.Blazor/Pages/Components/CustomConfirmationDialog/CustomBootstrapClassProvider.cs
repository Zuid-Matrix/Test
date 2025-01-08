namespace Matrix.Prox3.IntelliZone.Blazor.Pages.Components.CustomConfirmationDialog
{
    public class CustomBootstrapClassProvider
    {
        public string Nav => "nav";

        public string NavPills => Nav + "-pills";

        public string NavTabs => Nav + "-tabs";

        public string Accordion()
        {
            return "accordion";
        }

        public string AccordionButton()
        {
            return Accordion() + "-button";
        }

        public string AccordionFlush()
        {
            return Accordion() + "-flush";
        }

        public string AccordionItem()
        {
            return Accordion() + "-item";
        }

        public string AccordionItemBody()
        {
            return Accordion() + "-body";
        }

        public string AccordionItemHeader()
        {
            return Accordion() + "-header";
        }

        public string Active()
        {
            return "active";
        }

        public string Alert()
        {
            return "alert";
        }

        public string AlertColor(CustomAlertColor Color)
        {
            return Alert() + "-" + ToAlertColor(Color);
        }

        public string? AlertDescription()
        {
            return null;
        }

        public string AlertDismisable()
        {
            return "alert-dismissible";
        }

        //public string AlertFade()
        //{
        //    return Fade();
        //}

        public string? AlertHasDescription()
        {
            return null;
        }

        public string? AlertHasMessage()
        {
            return null;
        }

        public string? AlertMessage()
        {
            return null;
        }

        public string AlertShow()
        {
            return Show();
        }

        public string BackgroundColor(CustomBackgroundColor backgroundColor)
        {
            return "bg-" + ToBackgroundColor(backgroundColor);
        }

        public string Badge()
        {
            return "badge";
        }


        public string Button()
        {
            return "btn";
        }

        public string ButtonActive()
        {
            return "active";
        }

        public string ButtonBlock()
        {
            return Button() + "-block";
        }

        public string ButtonColor(CustomButtonColor Color)
        {
            return Button() + "-" + ToButtonColor(Color);
        }

        public string ButtonDisabled()
        {
            return "disabled";
        }

        public string ButtonGroup()
        {
            return Button() + "-group";
        }

        public string? ButtonLoading()
        {
            return null;
        }

        public string ButtonOutline(CustomButtonColor Color)
        {
            return Color != 0 ? Button() + "-outline-" + ToButtonColor(Color) : Button() + "-outline";
        }

        public string ButtonSize(CustomSize size)
        {
            return Button() + "-" + ToSize(size);
        }

        public string Callout()
        {
            return "bb-callout";
        }

        public string CalloutHeading()
        {
            return Callout() + "-heading";
        }

        public string Card()
        {
            return "card";
        }

        public string CardBody()
        {
            return Card() + "-body";
        }

        public string CardFooter()
        {
            return Card() + "-footer";
        }

        public string CardGroup()
        {
            return Card() + "-group";
        }

        public string CardHeader()
        {
            return Card() + "-header";
        }

        public string CardLink()
        {
            return Card() + "-link";
        }

        public string CardSubTitle()
        {
            return Card() + "-subtitle";
        }

        public string CardText()
        {
            return Card() + "-text";
        }

        public string CardTitle()
        {
            return Card() + "-title";
        }

        public string Checks()
        {
            return "form-check-input";
        }

        public string ChecksReverse()
        {
            return "form-check-reverse";
        }

        public string Collapse()
        {
            return "collapse";
        }

        public string Collapsed()
        {
            return "collapsed";
        }

        public string CollapseHorizontal()
        {
            return Collapse() + "-horizontal";
        }

        public string ConfirmationModal()
        {
            return "modal-confirmation";
        }

        public string Disabled()
        {
            return "disabled";
        }

        public string DisplayHeadingSize(CustomDisplayHeadingSize displayHeadingSize)
        {
            return "display-" + ToDisplayHeadingSize(displayHeadingSize);
        }

        public string Divider()
        {
            return "divider";
        }

        public string DividerType(CustomDividerType dividerType)
        {
            return Divider() + "-" + ToDividerType(dividerType);
        }

        //public string Dropdown()
        //{
        //    return "dropdown";
        //}

        //public string DropdownDirection(DropdownDirection direction)
        //{
        //    return ToDropdownDirection(direction);
        //}

        //public string DropdownDivider()
        //{
        //    return Dropdown() + "-divider";
        //}

        //public string DropdownHeader()
        //{
        //    return Dropdown() + "-header";
        //}

        //public string DropdownItem()
        //{
        //    return Dropdown() + "-item";
        //}

        //public string DropdownMenu()
        //{
        //    return Dropdown() + "-menu";
        //}

        //public string DropdownMenuPosition(DropdownMenuPosition position)
        //{
        //    return ToDropdownMenuPosition(position);
        //}

        //public string DropdownToggle()
        //{
        //    return Dropdown() + "-toggle";
        //}

        //public string DropdownToggleSplit()
        //{
        //    return DropdownToggle() + "-split";
        //}

        public string Fade()
        {
            return "fade";
        }

        //public string FlexAlignment(Alignment alignment)
        //{
        //    return "justify-content-" + ToAlignment(alignment);
        //}

        //public string FormControl()
        //{
        //    return "form-control";
        //}

        //public string HeadingSize(HeadingSize headingSize)
        //{
        //    return "h" + ToHeadingSize(headingSize);
        //}

        //public string IconColor(IconColor iconColor)
        //{
        //    return "text-" + ToIconColor(iconColor);
        //}

        //public string IsInValid()
        //{
        //    return "invalid";
        //}

        //public string IsValid()
        //{
        //    return "valid";
        //}

        public string Modal()
        {
            return "modal";
        }

        public string ModalFade()
        {
            return Fade();
        }

        //public string ModalHeader(ModalType modalType)
        //{
        //    return "text-bg-" + ToModalTypeColor(modalType) + " border-bottom " + ToModalHeaderBottomBorderColor(modalType);
        //}

        //public string Offcanvas()
        //{
        //    return "offcanvas";
        //}

        //public string Offcanvas(Placement placement)
        //{
        //    return Offcanvas() + "-" + ToPlacement(placement);
        //}

        //public string PageLoadingModal()
        //{
        //    return "modal-page-loading";
        //}

        //public string Pagination()
        //{
        //    return "pagination";
        //}

        //public string PaginationItem()
        //{
        //    return "page-item";
        //}

        //public string PaginationItemActive()
        //{
        //    return Active();
        //}

        //public string PaginationItemDisabled()
        //{
        //    return Disabled();
        //}

        //public string PaginationLink()
        //{
        //    return "page-link";
        //}

        //public string? PaginationLinkActive()
        //{
        //    return null;
        //}

        //public string? PaginationLinkDisabled()
        //{
        //    return null;
        //}

        //public string PaginationSize(PaginationSize size)
        //{
        //    return Pagination() + "-" + ToPaginationSize(size);
        //}

        //public string PillBadge()
        //{
        //    return "rounded-pill";
        //}

        //public string Placeholder()
        //{
        //    return "placeholder";
        //}

        //public string PlaceholderAnimation(PlaceholderAnimation animation)
        //{
        //    return Placeholder() + "-" + ToPlaceholderAnimation(animation);
        //}

        //public string PlaceholderColor(PlaceholderColor Color)
        //{
        //    return "bg-" + ToPlaceholderColor(Color);
        //}

        //public string PlaceholderSize(PlaceholderSize size)
        //{
        //    return Placeholder() + "-" + ToPlaceholderSize(size);
        //}

        //public string PlaceholderWidth(PlaceholderWidth width)
        //{
        //    return ToPlaceholderWidth(width) ?? "";
        //}

        public string Position()
        {
            return "position";
        }

        public string PositionAbsolute()
        {
            return Position() + "-absolute";
        }

        public string PositionFixed()
        {
            return Position() + "-fixed";
        }

        public string PositionRelative()
        {
            return Position() + "-relative";
        }

        public string PositionStatic()
        {
            return Position() + "-static";
        }

        public string PositionSticky()
        {
            return Position() + "-sticky";
        }

        public string Progress()
        {
            return "progress";
        }

        //public string ProgressBackgroundColor(ProgressColor Color)
        //{
        //    return "bg-" + ToProgressColor(Color);
        //}

        public string ProgressBar()
        {
            return Progress() + "-bar";
        }

        public string ProgressBarAnimated()
        {
            return ProgressBar() + "-animated";
        }

        public string ProgressBarStriped()
        {
            return ProgressBar() + "-striped";
        }

        public string Show()
        {
            return "show";
        }

        public string Table()
        {
            return "table";
        }

        public string TableActive()
        {
            return "table-active";
        }

        public string TableBordered()
        {
            return "table-bordered";
        }

        public string TableBorderless()
        {
            return "table-borderless";
        }

        public string TableDanger()
        {
            return "table-danger";
        }

        public string TableDark()
        {
            return "table-dark";
        }

        public string TableGroupDivider()
        {
            return "table-group-divider";
        }

        public string TableHover()
        {
            return "table-hover";
        }

        public string TableInfo()
        {
            return "table-info";
        }

        public string TableLight()
        {
            return "table-light";
        }

        public string TablePrimary()
        {
            return "table-primary";
        }

        public string TableResponsive()
        {
            return "table-responsive";
        }

        public string TableSecondary()
        {
            return "table-secondary";
        }

        public string TableSticky()
        {
            return "bb-table-sticky";
        }

        public string TableStriped()
        {
            return "table-striped";
        }

        public string TableSmall()
        {
            return "table-sm";
        }

        public string TableStripedColumns()
        {
            return "table-striped-columns";
        }

        public string TableSuccess()
        {
            return "table-success";
        }

        public string TableWarning()
        {
            return "table-warning";
        }

        //public string TextAlignment(Alignment alignment)
        //{
        //    return "text-" + ToAlignment(alignment);
        //}

        //public string TextAndBackgroundColor(BackgroundColor backgroundColor)
        //{
        //    return "text-bg-" + ToBackgroundColor(backgroundColor);
        //}

        //public string TextColor(TextColor textColor)
        //{
        //    return "text-" + ToTextColor(textColor);
        //}

        public string TextNoWrap()
        {
            return "text-nowrap";
        }

        public string ToAlertColor(CustomAlertColor Color)
        {
            if (1 == 0)
            {
            }

            string result = Color switch
            {
                CustomAlertColor.Primary => "primary",
                CustomAlertColor.Secondary => "secondary",
                CustomAlertColor.Success => "success",
                CustomAlertColor.Danger => "danger",
                CustomAlertColor.Warning => "warning",
                CustomAlertColor.Info => "info",
                CustomAlertColor.Light => "light",
                CustomAlertColor.Dark => "dark",
                _ => string.Empty,
            };
            if (1 == 0)
            {
            }

            return result;
        }

        //public string ToAlignment(Alignment alignment)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = alignment switch
        //    {
        //        Alignment.Start => "start",
        //        Alignment.Center => "center",
        //        Alignment.End => "end",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        public string Toast()
        {
            return "toast";
        }

        public string ToastContainer()
        {
            return Toast() + "-container";
        }

        //public string ToAutoCompleteSize(AutoCompleteSize size)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = size switch
        //    {
        //        AutoCompleteSize.Large => "form-control-lg",
        //        AutoCompleteSize.Small => "form-control-sm",
        //        _ => "",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        public string ToBackgroundColor(CustomBackgroundColor Color)
        {
            if (1 == 0)
            {
            }

            string result = Color switch
            {
                CustomBackgroundColor.Primary => "primary",
                CustomBackgroundColor.Secondary => "secondary",
                CustomBackgroundColor.Success => "success",
                CustomBackgroundColor.Danger => "danger",
                CustomBackgroundColor.Warning => "warning",
                CustomBackgroundColor.Info => "info",
                CustomBackgroundColor.Light => "light",
                CustomBackgroundColor.Dark => "dark",
                CustomBackgroundColor.Body => "body",
                CustomBackgroundColor.White => "white",
                CustomBackgroundColor.Transparent => "transparent",
                _ => string.Empty,
            };
            if (1 == 0)
            {
            }

            return result;
        }

        //public string ToBadgeColor(BadgeColor Color)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = Color switch
        //    {
        //        BlazorBootstrap.BadgeColor.Primary => "primary",
        //        BlazorBootstrap.BadgeColor.Secondary => "secondary",
        //        BlazorBootstrap.BadgeColor.Success => "success",
        //        BlazorBootstrap.BadgeColor.Danger => "danger",
        //        BlazorBootstrap.BadgeColor.Warning => "warning",
        //        BlazorBootstrap.BadgeColor.Info => "info",
        //        BlazorBootstrap.BadgeColor.Light => "light",
        //        BlazorBootstrap.BadgeColor.Dark => "dark",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToBadgeIndicator(BadgeIndicatorType indicatorType)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = indicatorType switch
        //    {
        //        BadgeIndicatorType.RoundedPill => "rounded-pill",
        //        BadgeIndicatorType.RoundedCircle => "rounded-circle",
        //        _ => "",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToBadgePlacement(BadgePlacement badgePlacement)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = badgePlacement switch
        //    {
        //        BadgePlacement.TopLeft => "top-0 start-0 translate-middle",
        //        BadgePlacement.TopCenter => "top-0 start-50 translate-middle",
        //        BadgePlacement.TopRight => "top-0 start-100 translate-middle",
        //        BadgePlacement.MiddleLeft => "top-50 start-0 translate-middle",
        //        BadgePlacement.MiddleCenter => "top-50 start-50 translate-middle",
        //        BadgePlacement.MiddleRight => "top-50 start-100 translate-middle",
        //        BadgePlacement.BottomLeft => "top-100 start-0 translate-middle",
        //        BadgePlacement.BottomCenter => "top-100 start-50 translate-middle",
        //        BadgePlacement.BottomRight => "top-100 start-100 translate-middle",
        //        _ => "top-0 start-100 translate-middle",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        public string ToButtonColor(CustomButtonColor Color)
        {
            if (1 == 0)
            {
            }

            string result = Color switch
            {
                CustomButtonColor.Primary => "primary",
                CustomButtonColor.Secondary => "secondary",
                CustomButtonColor.Success => "success",
                CustomButtonColor.Danger => "danger",
                CustomButtonColor.Warning => "warning",
                CustomButtonColor.Info => "info",
                CustomButtonColor.Light => "light",
                CustomButtonColor.Dark => "dark",
                CustomButtonColor.Link => "link",
                _ => string.Empty,
            };
            if (1 == 0)
            {
            }

            return result;
        }

        //public string ToCalloutType(CalloutType type)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = type switch
        //    {
        //        CalloutType.Default => "",
        //        CalloutType.Danger => Callout() + "-danger",
        //        CalloutType.Warning => Callout() + "-warning",
        //        CalloutType.Info => Callout() + "-info",
        //        CalloutType.Tip => Callout() + "-success",
        //        _ => "",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToCardColor(CardColor Color)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = Color switch
        //    {
        //        CardColor.Primary => "text-bg-primary",
        //        CardColor.Secondary => "text-bg-secondary",
        //        CardColor.Success => "text-bg-success",
        //        CardColor.Danger => "text-bg-danger",
        //        CardColor.Warning => "text-bg-warning",
        //        CardColor.Info => "text-bg-info",
        //        CardColor.Light => "text-bg-light",
        //        CardColor.Dark => "text-bg-dark",
        //        _ => "",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToColor(TextColor Color)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = Color switch
        //    {
        //        BlazorBootstrap.TextColor.Primary => "primary",
        //        BlazorBootstrap.TextColor.Secondary => "secondary",
        //        BlazorBootstrap.TextColor.Success => "success",
        //        BlazorBootstrap.TextColor.Danger => "danger",
        //        BlazorBootstrap.TextColor.Warning => "warning",
        //        BlazorBootstrap.TextColor.Info => "info",
        //        BlazorBootstrap.TextColor.Light => "light",
        //        BlazorBootstrap.TextColor.Dark => "dark",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        public string ToDialogSize(CustomDialogSize size)
        {
            if (1 == 0)
            {
            }

            string result = size switch
            {
                CustomDialogSize.Regular => string.Empty,
                CustomDialogSize.Small => "modal-sm",
                CustomDialogSize.Large => "modal-lg",
                CustomDialogSize.ExtraLarge => "modal-xl",
                _ => string.Empty,
            };
            if (1 == 0)
            {
            }

            return result;
        }

        public string ToDisplayHeadingSize(CustomDisplayHeadingSize displayHeadingSize)
        {
            if (1 == 0)
            {
            }

            string result = displayHeadingSize switch
            {
                CustomDisplayHeadingSize.H1 => "1",
                CustomDisplayHeadingSize.H2 => "2",
                CustomDisplayHeadingSize.H3 => "3",
                CustomDisplayHeadingSize.H4 => "4",
                _ => string.Empty,
            };
            if (1 == 0)
            {
            }

            return result;
        }

        public string ToDividerType(CustomDividerType dividerType)
        {
            if (1 == 0)
            {
            }

            string result = dividerType switch
            {
                CustomDividerType.Dashed => "dashed",
                CustomDividerType.Dotted => "dotted",
                CustomDividerType.TextContent => "text",
                _ => "solid",
            };
            if (1 == 0)
            {
            }

            return result;
        }

        //public string ToDropdownDirection(DropdownDirection direction)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = direction switch
        //    {
        //        BlazorBootstrap.DropdownDirection.Dropdown => "dropdown",
        //        BlazorBootstrap.DropdownDirection.DropdownCentered => "dropdown dropdown-center",
        //        BlazorBootstrap.DropdownDirection.Dropend => "dropend",
        //        BlazorBootstrap.DropdownDirection.Dropup => "dropup",
        //        BlazorBootstrap.DropdownDirection.DropupCentered => "dropup dropup-center",
        //        BlazorBootstrap.DropdownDirection.Dropstart => "dropstart",
        //        _ => "",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToDropdownMenuPosition(DropdownMenuPosition position)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = position switch
        //    {
        //        BlazorBootstrap.DropdownMenuPosition.Start => "dropdown-menu-start",
        //        BlazorBootstrap.DropdownMenuPosition.End => "dropdown-menu-end",
        //        _ => "",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToHeadingSize(HeadingSize headingSize)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = headingSize switch
        //    {
        //        BlazorBootstrap.HeadingSize.H1 => "1",
        //        BlazorBootstrap.HeadingSize.H2 => "2",
        //        BlazorBootstrap.HeadingSize.H3 => "3",
        //        BlazorBootstrap.HeadingSize.H4 => "4",
        //        BlazorBootstrap.HeadingSize.H5 => "5",
        //        BlazorBootstrap.HeadingSize.H6 => "6",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToIconColor(IconColor Color)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = Color switch
        //    {
        //        BlazorBootstrap.IconColor.Primary => "primary",
        //        BlazorBootstrap.IconColor.Secondary => "secondary",
        //        BlazorBootstrap.IconColor.Success => "success",
        //        BlazorBootstrap.IconColor.Danger => "danger",
        //        BlazorBootstrap.IconColor.Warning => "warning",
        //        BlazorBootstrap.IconColor.Info => "info",
        //        BlazorBootstrap.IconColor.Light => "light",
        //        BlazorBootstrap.IconColor.Dark => "dark",
        //        BlazorBootstrap.IconColor.Body => "body",
        //        BlazorBootstrap.IconColor.Muted => "muted",
        //        BlazorBootstrap.IconColor.White => "white",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToModalFullscreen(ModalFullscreen fullscreen)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = fullscreen switch
        //    {
        //        ModalFullscreen.Disabled => null,
        //        ModalFullscreen.Always => "modal-fullscreen",
        //        ModalFullscreen.SmallDown => "modal-fullscreen-sm-down",
        //        ModalFullscreen.MediumDown => "modal-fullscreen-md-down",
        //        ModalFullscreen.LargeDown => "modal-fullscreen-lg-down",
        //        ModalFullscreen.ExtraLargeDown => "modal-fullscreen-xl-down",
        //        ModalFullscreen.ExtraExtraLargeDown => "modal-fullscreen-xxl-down",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToModalHeaderBottomBorderColor(ModalType modalType)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = modalType switch
        //    {
        //        ModalType.Primary => "border-primary",
        //        ModalType.Secondary => "border-secondary",
        //        ModalType.Success => "border-success",
        //        ModalType.Danger => "border-danger",
        //        ModalType.Warning => "border-warning",
        //        ModalType.Info => "border-info",
        //        ModalType.Light => null,
        //        ModalType.Dark => "border-dark",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToModalSize(ModalSize size)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = size switch
        //    {
        //        ModalSize.Regular => null,
        //        ModalSize.Small => "modal-sm",
        //        ModalSize.Large => "modal-lg",
        //        ModalSize.ExtraLarge => "modal-xl",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToModalTypeColor(ModalType modalType)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = modalType switch
        //    {
        //        ModalType.Primary => "primary",
        //        ModalType.Secondary => "secondary",
        //        ModalType.Success => "success",
        //        ModalType.Danger => "danger",
        //        ModalType.Warning => "warning",
        //        ModalType.Info => "info",
        //        ModalType.Light => "light",
        //        ModalType.Dark => "dark",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToOffcanvasSize(OffcanvasSize size)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = size switch
        //    {
        //        OffcanvasSize.Regular => null,
        //        OffcanvasSize.Small => "bb-offcanvas-sm",
        //        OffcanvasSize.Large => "bb-offcanvas-lg",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string Tooltip()
        //{
        //    return "b-tooltip";
        //}

        //public string TooltipAlwaysActive()
        //{
        //    return "b-tooltip-active";
        //}

        //public string TooltipColor(TooltipColor Color)
        //{
        //    return ToTooltipColor(Color);
        //}

        //public string TooltipFade()
        //{
        //    return "b-tooltip-fade";
        //}

        //public string TooltipInline()
        //{
        //    return "b-tooltip-inline";
        //}

        //public string TooltipMultiline()
        //{
        //    return "b-tooltip-multiline";
        //}

        //public string TooltipPlacement(TooltipPlacement tooltipPlacement)
        //{
        //    return Tooltip() + "-" + ToTooltipPlacement(tooltipPlacement);
        //}

        //public string ToPaginationSize(PaginationSize size)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = size switch
        //    {
        //        BlazorBootstrap.PaginationSize.Small => "sm",
        //        BlazorBootstrap.PaginationSize.Large => "lg",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToPlaceholderAnimation(PlaceholderAnimation animation)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = animation switch
        //    {
        //        BlazorBootstrap.PlaceholderAnimation.Glow => "glow",
        //        BlazorBootstrap.PlaceholderAnimation.Wave => "wave",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToPlaceholderColor(PlaceholderColor Color)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = Color switch
        //    {
        //        BlazorBootstrap.PlaceholderColor.Primary => "primary",
        //        BlazorBootstrap.PlaceholderColor.Secondary => "secondary",
        //        BlazorBootstrap.PlaceholderColor.Success => "success",
        //        BlazorBootstrap.PlaceholderColor.Danger => "danger",
        //        BlazorBootstrap.PlaceholderColor.Warning => "warning",
        //        BlazorBootstrap.PlaceholderColor.Info => "info",
        //        BlazorBootstrap.PlaceholderColor.Light => "light",
        //        BlazorBootstrap.PlaceholderColor.Dark => "dark",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToPlaceholderSize(PlaceholderSize size)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = size switch
        //    {
        //        BlazorBootstrap.PlaceholderSize.ExtraSmall => "xs",
        //        BlazorBootstrap.PlaceholderSize.Small => "sm",
        //        BlazorBootstrap.PlaceholderSize.Large => "lg",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToPlaceholderWidth(PlaceholderWidth width)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = width switch
        //    {
        //        BlazorBootstrap.PlaceholderWidth.Col1 => "col-1",
        //        BlazorBootstrap.PlaceholderWidth.Col2 => "col-2",
        //        BlazorBootstrap.PlaceholderWidth.Col3 => "col-3",
        //        BlazorBootstrap.PlaceholderWidth.Col4 => "col-4",
        //        BlazorBootstrap.PlaceholderWidth.Col5 => "col-5",
        //        BlazorBootstrap.PlaceholderWidth.Col6 => "col-6",
        //        BlazorBootstrap.PlaceholderWidth.Col7 => "col-7",
        //        BlazorBootstrap.PlaceholderWidth.Col8 => "col-8",
        //        BlazorBootstrap.PlaceholderWidth.Col9 => "col-9",
        //        BlazorBootstrap.PlaceholderWidth.Col10 => "col-10",
        //        BlazorBootstrap.PlaceholderWidth.Col11 => "col-11",
        //        BlazorBootstrap.PlaceholderWidth.Col12 => "col-12",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToPlacement(Placement placement)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = placement switch
        //    {
        //        Placement.Start => "start",
        //        Placement.End => "end",
        //        Placement.Top => "top",
        //        _ => "bottom",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToPosition(Position position)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = position switch
        //    {
        //        BlazorBootstrap.Position.Static => PositionAbsolute(),
        //        BlazorBootstrap.Position.Relative => PositionRelative(),
        //        BlazorBootstrap.Position.Absolute => PositionAbsolute(),
        //        BlazorBootstrap.Position.Fixed => PositionFixed(),
        //        BlazorBootstrap.Position.Sticky => PositionSticky(),
        //        _ => "",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToProgressColor(ProgressColor Color)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = Color switch
        //    {
        //        ProgressColor.Primary => "primary",
        //        ProgressColor.Secondary => "secondary",
        //        ProgressColor.Success => "success",
        //        ProgressColor.Danger => "danger",
        //        ProgressColor.Warning => "warning",
        //        ProgressColor.Info => "info",
        //        ProgressColor.Dark => "dark",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToScreenreader(Screenreader screenreader)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = screenreader switch
        //    {
        //        Screenreader.Only => "sr-only",
        //        Screenreader.OnlyFocusable => "sr-only-focusable",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        public string ToSize(CustomSize size)
        {
            if (1 == 0)
            {
            }

            string result = size switch
            {
                CustomSize.ExtraSmall => "xs",
                CustomSize.Small => "sm",
                CustomSize.Medium => "md",
                CustomSize.Large => "lg",
                CustomSize.ExtraLarge => "xl",
                _ => string.Empty,
            };
            if (1 == 0)
            {
            }

            return result;
        }

        //public string ToTabColor(TabColor Color)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = Color switch
        //    {
        //        TabColor.Primary => "bg-primary text-white",
        //        TabColor.Secondary => "bg-secondary text-white",
        //        TabColor.Success => "bg-success text-white",
        //        TabColor.Danger => "bg-danger text-white",
        //        TabColor.Warning => "bg-warning text-dark",
        //        TabColor.Info => "bg-info text-dark",
        //        TabColor.Light => "bg-light text-dark",
        //        TabColor.Dark => "bg-dark text-white",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToTextAlignment(Alignment alignment)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result;
        //    switch (alignment)
        //    {
        //        case Alignment.None:
        //        case Alignment.Start:
        //            result = "text-start";
        //            break;
        //        case Alignment.Center:
        //            result = "text-center";
        //            break;
        //        case Alignment.End:
        //            result = "text-end";
        //            break;
        //        default:
        //            result = "";
        //            break;
        //    }

        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToTextColor(TextColor Color)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = Color switch
        //    {
        //        BlazorBootstrap.TextColor.Primary => "primary",
        //        BlazorBootstrap.TextColor.Secondary => "secondary",
        //        BlazorBootstrap.TextColor.Success => "success",
        //        BlazorBootstrap.TextColor.Danger => "danger",
        //        BlazorBootstrap.TextColor.Warning => "warning",
        //        BlazorBootstrap.TextColor.Info => "info",
        //        BlazorBootstrap.TextColor.Light => "light",
        //        BlazorBootstrap.TextColor.Dark => "dark",
        //        BlazorBootstrap.TextColor.Body => "body",
        //        BlazorBootstrap.TextColor.Muted => "muted",
        //        BlazorBootstrap.TextColor.White => "white",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToToastBackgroundColor(ToastType toastType)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = toastType switch
        //    {
        //        ToastType.Primary => "primary",
        //        ToastType.Secondary => "secondary",
        //        ToastType.Success => "success",
        //        ToastType.Danger => "danger",
        //        ToastType.Warning => "warning",
        //        ToastType.Info => "info",
        //        ToastType.Light => "light",
        //        ToastType.Dark => "dark",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToToastsPlacement(ToastsPlacement toastsPlacement)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = toastsPlacement switch
        //    {
        //        ToastsPlacement.TopLeft => "top-0 start-0",
        //        ToastsPlacement.TopCenter => "top-0 start-50 translate-middle-x",
        //        ToastsPlacement.TopRight => "top-0 end-0",
        //        ToastsPlacement.MiddleLeft => "top-50 start-0 translate-middle-y",
        //        ToastsPlacement.MiddleCenter => "top-50 start-50 translate-middle",
        //        ToastsPlacement.MiddleRight => "top-50 end-0 translate-middle-y",
        //        ToastsPlacement.BottomLeft => "bottom-0 start-0",
        //        ToastsPlacement.BottomCenter => "bottom-0 start-50 translate-middle-x",
        //        ToastsPlacement.BottomRight => "bottom-0 end-0",
        //        _ => "top-0 end-0",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToToastTextColor(ToastType toastType)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result;
        //    switch (toastType)
        //    {
        //        case ToastType.Primary:
        //        case ToastType.Secondary:
        //        case ToastType.Success:
        //        case ToastType.Danger:
        //        case ToastType.Dark:
        //            result = "white";
        //            break;
        //        case ToastType.Warning:
        //        case ToastType.Info:
        //        case ToastType.Light:
        //            result = "dark";
        //            break;
        //        default:
        //            result = null;
        //            break;
        //    }

        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToTooltipColor(TooltipColor Color)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = Color switch
        //    {
        //        BlazorBootstrap.TooltipColor.Primary => "bb-tooltip-primary",
        //        BlazorBootstrap.TooltipColor.Secondary => "bb-tooltip-tooltip-secondary",
        //        BlazorBootstrap.TooltipColor.Success => "bb-tooltip-success",
        //        BlazorBootstrap.TooltipColor.Danger => "bb-tooltip-danger",
        //        BlazorBootstrap.TooltipColor.Warning => "bb-tooltip-warning",
        //        BlazorBootstrap.TooltipColor.Info => "bb-tooltip-info",
        //        BlazorBootstrap.TooltipColor.Light => "bb-tooltip-light",
        //        BlazorBootstrap.TooltipColor.Dark => "bb-tooltip-dark",
        //        _ => null,
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}

        //public string ToTooltipPlacement(TooltipPlacement tooltipPlacement)
        //{
        //    if (1 == 0)
        //    {
        //    }

        //    string result = tooltipPlacement switch
        //    {
        //        BlazorBootstrap.TooltipPlacement.Bottom => "bottom",
        //        BlazorBootstrap.TooltipPlacement.Left => "left",
        //        BlazorBootstrap.TooltipPlacement.Right => "right",
        //        _ => "top",
        //    };
        //    if (1 == 0)
        //    {
        //    }

        //    return result;
        //}
    }
}
