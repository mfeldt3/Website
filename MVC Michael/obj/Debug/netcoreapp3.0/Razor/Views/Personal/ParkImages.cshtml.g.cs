#pragma checksum "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ee9b231c2190818535f0ce03b8013f61cafb773"
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
#line 1 "C:\Users\mfeldt\Desktop\MVC Michael\Views\_ViewImports.cshtml"
using MVC_Michael;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mfeldt\Desktop\MVC Michael\Views\_ViewImports.cshtml"
using MVC_Michael.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mfeldt\Desktop\MVC Michael\Views\_ViewImports.cshtml"
using MVC_Michael.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ee9b231c2190818535f0ce03b8013f61cafb773", @"/Views/Personal/ParkImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a95dad75a1fe4a861eeba91aca524e8192fdf194", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_ParkImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
  
    ViewData["Title"] = "Park Images";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Button trigger modal -->
<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
    Add an Image
</button>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
");
#nullable restore
#line 12 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
     using (Html.BeginForm("SaveImage", "Personal", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal-dialog\" role=\"document\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-header\">\r\n                    <h5 class=\"modal-title\" id=\"exampleModalLabel\">Add an Image for ");
#nullable restore
#line 17 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
                                                                               Write(Model.ParkDetails.ParkName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <input type=""file"" name=""Image"" accept=""image/x-png,image/gif,image/jpeg, image/jpg"" required/>
                    <input name=""ParkName"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 1169, "\"", 1204, 1);
#nullable restore
#line 24 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 1177, Model.ParkDetails.ParkName, 1177, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                    <p>Park Name</p>\r\n                    <input name=\"ParkID\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1309, "\"", 1346, 1);
#nullable restore
#line 26 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 1317, Model.ParkDetails.ParkListId, 1317, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />
                    <p>Park ID</p>
                    <input name=""Title"" type=""text"" maxlength=""50"" required/>
                    <p> Image Title</p>
                    <textarea name=""Description"" cols=""60"" rows=""5"" maxlength=""150"" placeholder=""What trail was this?""></textarea>
                    <p> Image Description</p>
                    <input name""authorizationCode"" type=""password"" maxlength=""25"" required/>
                    <p> Authorization Code </p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <input class=""btn btn-primary"" type=""submit"" id=""btnUpload"" value=""Upload"" />

                </div>
            </div>
        </div>
");
#nullable restore
#line 42 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
            WriteLiteral("<div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 48 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
           int slide = 0;
            foreach (ParkImage parkImage in Model.ParkImages)
            {
                string carousel = slide == 0 ? "active" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 52 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
                                                                       Write(slide);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"></li>\r\n");
#nullable restore
#line 53 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
                slide = slide + 1;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\r\n    <div class=\"carousel-inner\" role=\"listbox\">\r\n");
#nullable restore
#line 58 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
           int imageNumber = 0;
            foreach (ParkImage parkImage in Model.ParkImages)
            {
                string carousel = imageNumber == 0 ? "carousel-item active" : "carousel-item";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 2953, "\"", 2970, 1);
#nullable restore
#line 62 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 2961, carousel, 2961, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 2996, "\'", 3075, 1);
#nullable restore
#line 63 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 3003, Url.Action("GetImageById", "Personal", new { ImageId = @parkImage.Id }), 3003, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img");
            BeginWriteAttribute("src", " src=\'", 3082, "\'", 3160, 1);
#nullable restore
#line 63 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 3088, Url.Action("GetImageById", "Personal", new { ImageId = @parkImage.Id }), 3088, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </a>\r\n                    <div class=\"carousel-caption text-center\">\r\n                        <h1>");
#nullable restore
#line 65 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
                       Write(parkImage.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <h4>");
#nullable restore
#line 66 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
                       Write(parkImage.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 3384, "\"", 3546, 1);
#nullable restore
#line 67 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 3391, Url.Action("DeleteImageById", "Personal", new { imageId = @parkImage.Id, Parkname = @Model.ParkDetails.ParkName, ParkId = @Model.ParkDetails.ParkListId }), 3391, 155, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete this Image </a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 70 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
                imageNumber = imageNumber + 1;
            }

        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 75 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
     if (@Model.ParkImages.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span><i class=""fas fa-arrow-circle-left fa-lg""></i></span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span><i class=""fas fa-arrow-circle-right fa-lg""></i></span>
        </a>
");
#nullable restore
#line 83 "C:\Users\mfeldt\Desktop\MVC Michael\Views\Personal\ParkImages.cshtml"
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
