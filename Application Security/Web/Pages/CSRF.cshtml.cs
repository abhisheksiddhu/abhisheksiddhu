using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class CSRFModel : PageModel
    {
        public CSRFModel(ApplicationState applicationState)
        {
            ApplicationState = applicationState;
        }

        public ApplicationState ApplicationState { get; }

        public void OnGet(string? add)
        {
            if (!string.IsNullOrWhiteSpace(add))
            {
                ApplicationState.CSRFPosts.Add(add);
            }
        }
    }
}
