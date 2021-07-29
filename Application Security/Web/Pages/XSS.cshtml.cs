using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class XSSModel : PageModel
    {
        public XSSModel(ApplicationState applicationState)
        {
            ApplicationState = applicationState;
        }

        public ApplicationState ApplicationState { get; }

        public void OnGet(string? add)
        {
            if (!string.IsNullOrWhiteSpace(add))
            {
                ApplicationState.XSSPosts.Add($"<script>alert('{add}');</script>");
            }
        }
    }
}
