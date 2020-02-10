#pragma checksum "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df50480a59b4108631e1092d5a6a2b5bd170f3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_ParkImages), @"mvc.1.0.view", @"/Views/Personal/ParkImages.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\micha\Documents\Website\MVC Michael\Views\_ViewImports.cshtml"
using MVC_Michael;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\Documents\Website\MVC Michael\Views\_ViewImports.cshtml"
using MVC_Michael.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\micha\Documents\Website\MVC Michael\Views\_ViewImports.cshtml"
using MVC_Michael.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df50480a59b4108631e1092d5a6a2b5bd170f3bd", @"/Views/Personal/ParkImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a95dad75a1fe4a861eeba91aca524e8192fdf194", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_ParkImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
  
    ViewData["Title"] = "Park Images";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <input type=\"button\" onclick=\"ToggleAddForm()\" value=\"Add an Image for this park\" />\r\n</div>\r\n");
#nullable restore
#line 8 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
 using (Html.BeginForm("SaveImage", "Personal", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"AddImageForm\">\r\n            <input type=\"file\" name=\"Image\" />\r\n            <input name=\"Parkname\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 406, "\"", 441, 1);
#nullable restore
#line 12 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 414, Model.ParkDetails.ParkName, 414, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n            <input name=\"ParkID\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 500, "\"", 537, 1);
#nullable restore
#line 13 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 508, Model.ParkDetails.ParkListId, 508, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n            <input name=\"Title\" type=\"text\" />\r\n            <input name=\"Description\" type=\"text\" />\r\n            <input type=\"submit\" id=\"btnUpload\" value=\"Upload\" />\r\n        </div> \r\n");
#nullable restore
#line 18 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 24 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
           int slide = 0;
            foreach (ParkImage parkImage in Model.ParkImages)
            {
                string carousel = slide == 0 ? "active" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 28 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
                                                                       Write(slide);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"></li>\r\n");
#nullable restore
#line 29 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
                slide = slide + 1;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\r\n    <div class=\"carousel-inner\" role=\"listbox\">\r\n");
#nullable restore
#line 34 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
           int imageNumber = 0;
                foreach (ParkImage parkImage in Model.ParkImages)
                {
                    string carousel = imageNumber == 0 ? "carousel-item active" : "carousel-item";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 1506, "\"", 1523, 1);
#nullable restore
#line 38 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 1514, carousel, 1514, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a");
            BeginWriteAttribute("href", " href=\'", 1553, "\'", 1632, 1);
#nullable restore
#line 39 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 1560, Url.Action("GetImageById", "Personal", new { ImageId = @parkImage.Id }), 1560, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img");
            BeginWriteAttribute("src", " src=\'", 1639, "\'", 1717, 1);
#nullable restore
#line 39 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 1645, Url.Action("GetImageById", "Personal", new { ImageId = @parkImage.Id }), 1645, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </a>\r\n                        <div class=\"carousel-caption text-center\">\r\n                            <h2>");
#nullable restore
#line 41 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
                           Write(parkImage.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <h5>");
#nullable restore
#line 42 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
                           Write(parkImage.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <a class=\"nav-link text-dark\"");
            BeginWriteAttribute("href", " href=\"", 1967, "\"", 2129, 1);
#nullable restore
#line 43 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 1974, Url.Action("DeleteImageById", "Personal", new { imageId = @parkImage.Id, Parkname = @Model.ParkDetails.ParkName, ParkId = @Model.ParkDetails.ParkListId }), 1974, 155, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete this Image </a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 46 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
                    imageNumber = imageNumber + 1;
                }

        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 51 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
     if (@Model.ParkImages.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
");
#nullable restore
#line 61 "C:\Users\micha\Documents\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
