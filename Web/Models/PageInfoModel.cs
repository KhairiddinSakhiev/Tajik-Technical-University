using System.Collections.Generic;

namespace Web.Models
{
    public class PageInfoModel
    {
        public string Info { get; set; }
        public List<Link> Links { get; set; }
    }

    public class Link
    {
        public string Title { get; set; }
        public string HyperLink { get; set; }
    }

}