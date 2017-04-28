using SportsStore.WebPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebPortal.Hepers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper htmlHelper, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder liTag = new TagBuilder("li");

                TagBuilder tag = new TagBuilder("a");

                if (i != pagingInfo.CurrentPage)
                {
                    tag.MergeAttribute("href", pageUrl(i));
                }
                else
                {
                    liTag.MergeAttribute("class", "active");
                }

                tag.InnerHtml = i.ToString();

                liTag.InnerHtml = tag.ToString();

                result.Append(liTag.ToString());
            }

            return MvcHtmlString.Create(result.ToString());
        }
    }
}