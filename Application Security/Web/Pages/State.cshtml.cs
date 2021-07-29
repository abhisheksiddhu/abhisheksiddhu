using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class StateModel : PageModel
    {
        private readonly ApplicationState applicationState;

        public StateModel(ApplicationState applicationState)
        {
            this.applicationState = applicationState;
        }

        public void OnGet(string? clear)
        {
            if (!string.IsNullOrWhiteSpace(clear))
            {
                switch (clear)
                {
                    case "all":
                        applicationState.CSRFPosts.Clear();
                        applicationState.XSSPosts.Clear();
                        break;
                    case "csrf":
                        applicationState.CSRFPosts.Clear();
                        break;
                    case "xss":
                        applicationState.XSSPosts.Clear();
                        break;
                }
            }
        }
    }
}
