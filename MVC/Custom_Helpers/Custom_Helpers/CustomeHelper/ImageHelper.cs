using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custom_Helpers.CustomeHelper
{
    public static  class ImageHelper
    {
        public static MvcHtmlString getimage(this HtmlHelper obj,string s,string w,string h)
        {
            //string str="<img src="+s+"width="+w+"height="+h">";
            TagBuilder tb = new TagBuilder("img");
            tb.MergeAttribute("src", s);
            tb.MergeAttribute("width", w);
            tb.MergeAttribute("height", h);
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));

        }
    }
}