using System.Collections.Generic;

namespace Web
{
    public class ApplicationState
    {
        public List<string> CSRFPosts { get; set; } = new();
        public List<string> XSSPosts { get; set; } = new();
    }
}
