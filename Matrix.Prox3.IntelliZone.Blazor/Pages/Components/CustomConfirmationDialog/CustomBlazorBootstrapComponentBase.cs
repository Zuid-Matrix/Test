using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Matrix.Prox3.IntelliZone.Blazor.Pages.Components.CustomConfirmationDialog
{
    public abstract class CustomBlazorBootstrapComponentBase : ComponentBase, IDisposable, IAsyncDisposable
    {
        private string? customClass;

        private string? customStyle;

        private Queue<Func<Task>>? executeAfterRenderQueue;

        protected bool AsyncDisposed { get; private set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> Attributes { get; set; }

        [Inject]
        protected CustomBootstrapClassProvider BootstrapClassProvider { get; set; } = default!;

        [Parameter]
        public string? Class
        {
            get
            {
                return customClass ?? "";
            }
            set
            {
                customClass = value;
                DirtyClasses();
            }
        }

        protected CustomCssClassBuilder? ClassBuilder { get; private set; }

        public string? ClassNames => ClassBuilder?.ClassNames;

        protected bool Disposed { get; private set; }

        [Parameter]
        public string? ElementId { get; set; }

        public ElementReference ElementRef { get; set; }

        [Inject]
        protected CustomIIdGenerator IdGenerator { get; set; } = default!;

        [Inject]
        protected IJSRuntime JS { get; set; }

        protected bool Rendered { get; private set; }

        protected virtual bool ShouldAutoGenerateId => false;

        [Parameter]
        public string? Style
        {
            get
            {
                return customStyle;
            }
            set
            {
                customStyle = value;
                DirtyStyles();
            }
        }

        protected CustomSccStyleBuilder? StyleBuilder { get; private set; }

        public string? StyleNames => StyleBuilder?.Styles;

        public CustomBlazorBootstrapComponentBase()
        {
            ClassBuilder = new CustomCssClassBuilder(BuildClasses);
            StyleBuilder = new CustomSccStyleBuilder(BuildStyles);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            Rendered = true;
            Queue<Func<Task>>? queue = executeAfterRenderQueue;
            if (queue != null && queue.Count > 0)
            {
                while (executeAfterRenderQueue?.Count > 0)
                {
                    Func<Task> action = executeAfterRenderQueue.Dequeue();
                    await action();
                }
            }

            await base.OnAfterRenderAsync(firstRender);
        }

        protected override void OnInitialized()
        {
            if (ShouldAutoGenerateId && ElementId == null)
            {
                ElementId = IdGenerator.GetNextId();
            }

            base.OnInitialized();
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public async ValueTask DisposeAsync()
        {
            await DisposeAsync(disposing: true);
            Dispose(disposing: false);
        }

        protected internal virtual void DirtyClasses()
        {
            ClassBuilder?.Dirty();
        }

        protected virtual void BuildClasses(CustomCssClassBuilder builder)
        {
            if (Class != null)
            {
                builder.Append(Class);
            }
        }

        protected virtual void BuildStyles(CustomSccStyleBuilder builder)
        {
            if (Style != null)
            {
                builder.Append(Style);
            }
        }

        protected virtual void DirtyStyles()
        {
            StyleBuilder?.Dirty();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    ClassBuilder = null;
                    StyleBuilder = null;
                }

                if (disposing && executeAfterRenderQueue != null)
                {
                    executeAfterRenderQueue.Clear();
                    executeAfterRenderQueue = null;
                }

                Disposed = true;
            }
        }

        protected virtual ValueTask DisposeAsync(bool disposing)
        {
            try
            {
                if (!AsyncDisposed)
                {
                    if (disposing)
                    {
                        ClassBuilder = null;
                        StyleBuilder = null;
                    }

                    AsyncDisposed = true;
                }

                return default;
            }
            catch (Exception exception)
            {
                return new ValueTask(Task.FromException(exception));
            }
        }

        protected void ExecuteAfterRender(Func<Task> action)
        {
            if (executeAfterRenderQueue == null)
            {
                executeAfterRenderQueue = new Queue<Func<Task>>();
            }

            executeAfterRenderQueue.Enqueue(action);
        }
    }
}
