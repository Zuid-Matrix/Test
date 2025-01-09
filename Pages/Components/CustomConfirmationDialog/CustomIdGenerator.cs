namespace Matrix.Prox3.IntelliZone.Blazor.Pages.Components.CustomConfirmationDialog
{
    public interface CustomIIdGenerator
    {
        string GetNextId();
    }
    public class CustomIdGenerator : CustomIIdGenerator
    {
        private int currentId = 0;

        public string GetNextId()
        {
            currentId++;
            return $"id_{currentId}";
        }
    }
}
