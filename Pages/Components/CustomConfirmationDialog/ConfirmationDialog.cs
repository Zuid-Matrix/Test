﻿using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using static MudBlazor.CategoryTypes;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components.CompilerServices;

namespace Matrix.Prox3.IntelliZone.Blazor.Pages.Components.CustomConfirmationDialog
{
    public class CustomConfirmationDialog : CustomBlazorBootstrapComponentBase
    {

        private Type? childComponent;

        private string? dialogCssClass;

        private bool dismissable;

        private string? headerCssClass;

        private bool isVisible;

        private string? message1;

        private string? message2;

        private string? modalSize;

        private string? noButtonColor;

        private string? noButtonText;

        private Dictionary<string, object>? parameters;

        private string? scrollable;

        private bool showBackdrop;

        private TaskCompletionSource<bool>? taskCompletionSource;

        private string? title;

        private string? verticallyCentered;

        private string? yesButtonColor;

        private string? yesButtonText;


        protected override bool ShouldAutoGenerateId => true;

        protected override void BuildClasses(CustomCssClassBuilder builder)
        {
            builder.Append(BootstrapClassProvider.Modal());
            builder.Append(BootstrapClassProvider.ConfirmationModal());
            builder.Append(BootstrapClassProvider.ModalFade());
            base.BuildClasses(builder);
        }

        protected override void BuildStyles(CustomSccStyleBuilder builder)
        {
            builder.Append("display:block", showBackdrop);
            builder.Append("display:none", !showBackdrop);
            base.BuildStyles(builder);
        }

        public Task<bool> ShowAsync(string title, string message1, CustomConfirmDialogOptions? confirmDialogOptions = null)
        {
            return Show(title, message1, null, null, null, confirmDialogOptions!);
        }

        public Task<bool> ShowAsync(string title, string message1, string message2, CustomConfirmDialogOptions? confirmDialogOptions = null)
        {
            return Show(title, message1, message2, null, null, confirmDialogOptions!);
        }

        public Task<bool> ShowAsync<T>(string title, Dictionary<string, object>? parameters = null, CustomConfirmDialogOptions? confirmDialogOptions = null) where T : Microsoft.AspNetCore.Components.ComponentBase
        {
            return Show(title, null, null, typeof(T), parameters, confirmDialogOptions!);
        }

        private void Hide()
        {
            isVisible = false;
            showBackdrop = false;
            DirtyClasses();
            DirtyStyles();
            StateHasChanged();
            Task.Run(() => JS.InvokeVoidAsync("window.blazorBootstrap.confirmDialog.hide", ElementId));
        }

        private void OnNoClick()
        {
            Hide();
            taskCompletionSource!.SetResult(result: false);
        }

        private void OnYesClick()
        {
            Hide();
            taskCompletionSource!.SetResult(result: true);
        }

        private Task<bool> Show(string title, string? message1, string? message2, Type? type, Dictionary<string, object>? parameters, CustomConfirmDialogOptions confirmDialogOptions)
        {
            taskCompletionSource = new TaskCompletionSource<bool>();
            Task<bool> task = taskCompletionSource.Task;
            this.title = title;
            this.message1 = message1;
            this.message2 = message2;
            childComponent = type;
            this.parameters = parameters;
            if (confirmDialogOptions == null)
            {
                confirmDialogOptions = new CustomConfirmDialogOptions();
            }

            dialogCssClass = confirmDialogOptions.DialogCssClass;
            dismissable = confirmDialogOptions.Dismissable;
            headerCssClass = confirmDialogOptions.HeaderCssClass;
            scrollable = confirmDialogOptions.IsScrollable ? "modal-dialog-scrollable" : "";
            verticallyCentered = confirmDialogOptions.IsVerticallyCentered ? "modal-dialog-centered" : "";
            noButtonColor = confirmDialogOptions.NoButtonColor.ToButtonClass();
            noButtonText = "No";
            modalSize = BootstrapClassProvider.ToDialogSize(confirmDialogOptions.Size);
            yesButtonColor = confirmDialogOptions.YesButtonColor.ToButtonClass();
            yesButtonText = "Yes";
            isVisible = true;
            showBackdrop = true;
            DirtyClasses();
            DirtyStyles();
            StateHasChanged();
            Task.Run(() => JS.InvokeVoidAsync("window.blazorBootstrap.confirmDialog.show", ElementId));
            return task;
        }

        protected override void BuildRenderTree(RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", ElementId);
            __builder.AddAttribute(2, "class", ClassNames);
            __builder.AddAttribute(3, "style", StyleNames);
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddMultipleAttributes(5, RuntimeHelpers.TypeCheck((IEnumerable<KeyValuePair<string, object>>)Attributes));
            __builder.AddElementReferenceCapture(6, delegate (ElementReference __value)
            {
                ElementRef = __value;
            });
            if (isVisible)
            {
                __builder.OpenElement(7, "div");
                __builder.AddAttribute(8, "class", "modal-dialog " + scrollable + " " + verticallyCentered + " " + modalSize + " " + dialogCssClass);
                __builder.OpenElement(9, "div");
                __builder.AddAttribute(10, "class", "modal-content");
                if (!string.IsNullOrWhiteSpace(title))
                {
                    __builder.OpenElement(11, "div");
                    __builder.AddAttribute(12, "class", "modal-header custom-modal-header " + headerCssClass);
                    __builder.OpenElement(13, "h5");
                    __builder.AddAttribute(14, "class", "modal-title");
                    __builder.AddContent(15, title);
                    __builder.CloseElement();
                    if (dismissable)
                    {
                        __builder.OpenElement(16, "button");
                        __builder.AddAttribute(17, "type", "button");
                        __builder.AddAttribute(18, "class", "btn-close");
                        __builder.AddAttribute(19, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnNoClick));
                        __builder.CloseElement();
                    }
                    __builder.CloseElement();
                }

                __builder.OpenElement(20, "div");
                __builder.AddAttribute(21, "class", "modal-body custom-modal-body");
                if ((object)childComponent! != null)
                {
                    __builder.OpenComponent<DynamicComponent>(22);
                    __builder.AddAttribute(23, "Type", RuntimeHelpers.TypeCheck(childComponent));
                    __builder.AddAttribute(24, "Parameters", RuntimeHelpers.TypeCheck((IDictionary<string, object>)parameters!));
                    __builder.CloseComponent();
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(message1))
                    {
                        __builder.OpenElement(25, "div");
                        __builder.AddAttribute(26, "class", "pb-2");
                        __builder.AddContent(27, message1);
                        __builder.CloseElement();
                    }

                    if (!string.IsNullOrWhiteSpace(message2))
                    {
                        __builder.OpenElement(28, "div");
                        __builder.AddAttribute(29, "class", "pb-2");
                        __builder.AddContent(30, message2);
                        __builder.CloseElement();
                    }
                }

                __builder.CloseElement();
                __builder.AddMarkupContent(31, "\r\n                ");
                __builder.OpenElement(32, "div");
                __builder.AddAttribute(33, "class", "modal-footer custom-modal-footer border-top-0");
                __builder.OpenElement(34, "div");
                __builder.AddAttribute(35, "class", "d-grid gap-1 d-flex justify-content-md-end");
                if (!string.IsNullOrWhiteSpace(yesButtonText))
                {
                    __builder.OpenElement(41, "button");
                    __builder.AddAttribute(42, "class", yesButtonColor + " px-4");
                    __builder.AddAttribute(43, "type", "button");
                    __builder.AddAttribute(44, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnYesClick));
                    __builder.AddContent(45, yesButtonText);
                    __builder.CloseElement();
                }
                if (!string.IsNullOrWhiteSpace(noButtonText))
                {
                    __builder.OpenElement(36, "button");
                    __builder.AddAttribute(37, "class", noButtonColor + " me-md-2 px-4");
                    __builder.AddAttribute(38, "type", "button");
                    __builder.AddAttribute(39, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, OnNoClick));
                    __builder.AddContent(40, noButtonText);
                    __builder.CloseElement();
                }
                __builder.CloseElement();
                __builder.CloseElement();
                __builder.CloseElement();
                __builder.CloseElement();
            }

            __builder.CloseElement();
            if (showBackdrop)
            {
                __builder.AddMarkupContent(46, "<div class=\"modal-backdrop modal-backdrop-confirmation fade show\"></div>");
            }
        }
    }
}
