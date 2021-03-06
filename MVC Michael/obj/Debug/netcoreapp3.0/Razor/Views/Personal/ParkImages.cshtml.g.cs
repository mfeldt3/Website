#pragma checksum "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd4eac07f6d33ee13fd111ef5dcdf29e21d70ab6"
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
#line 1 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\_ViewImports.cshtml"
using MVC_Michael;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\_ViewImports.cshtml"
using MVC_Michael.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\_ViewImports.cshtml"
using MVC_Michael.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd4eac07f6d33ee13fd111ef5dcdf29e21d70ab6", @"/Views/Personal/ParkImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a95dad75a1fe4a861eeba91aca524e8192fdf194", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_ParkImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
  
    ViewData["Title"] = "Park Images";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Button trigger modal -->
<button id=""AddImage"" type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
    Add an Image
</button>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" onsubmit=""return checkAuthorization()"">
");
#nullable restore
#line 12 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
     using (Html.BeginForm("SaveImage", "Personal", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal-dialog\" role=\"document\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-header\">\r\n                    <h5 class=\"modal-title\" id=\"exampleModalLabel\">Add an Image for ");
#nullable restore
#line 17 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
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
                    <input type=""file"" name=""Image"" accept=""image/x-png,image/gif,image/jpeg, image/jpg"" required />
                    <input name=""ParkName"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 1223, "\"", 1258, 1);
#nullable restore
#line 24 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 1231, Model.ParkDetails.ParkName, 1231, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                    <p>Park Name</p>\r\n                    <input name=\"ParkId\" type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 1365, "\"", 1402, 1);
#nullable restore
#line 26 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 1373, Model.ParkDetails.ParkNumber, 1373, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />
                    <p>Park Number</p>
                    <input name=""Title"" type=""text"" maxlength=""50"" required />
                    <p> Image Title</p>
                    <textarea name=""Description"" cols=""60"" rows=""5"" maxlength=""150"" placeholder=""What trail was this?""></textarea>
                    <p> Image Description</p>
                    <input id=""authorizationCode"" type=""password"" maxlength=""25"" required />
                    <p id=""authLabel""> Authorization Code </p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <input class=""btn btn-primary"" type=""submit"" id=""btnUpload"" value=""Upload"" />

                </div>
            </div>
        </div>
");
#nullable restore
#line 42 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 45 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
 if (Model.ParkImages.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6 class=\"text-center\">We have not visited this park yet. Please check back later.</h6>\r\n");
#nullable restore
#line 48 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
}


#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 53 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
           int slide = 0;
            foreach (ParkImage parkImage in Model.ParkImages)
            {
                string carousel = slide == 0 ? "active" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 57 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
                                                                       Write(slide);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"></li>\r\n");
#nullable restore
#line 58 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
                slide = slide + 1;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\r\n    <div class=\"carousel-inner\" role=\"listbox\">\r\n");
#nullable restore
#line 63 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
           int imageNumber = 0;
            foreach (ParkImage parkImage in Model.ParkImages)
            {
                string carousel = imageNumber == 0 ? "carousel-item active" : "carousel-item";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 3188, "\"", 3205, 1);
#nullable restore
#line 67 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 3196, carousel, 3196, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 3231, "\'", 3310, 1);
#nullable restore
#line 68 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 3238, Url.Action("GetImageById", "Personal", new { ImageId = @parkImage.Id }), 3238, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img");
            BeginWriteAttribute("src", " src=\'", 3317, "\'", 3395, 1);
#nullable restore
#line 68 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 3323, Url.Action("GetImageById", "Personal", new { ImageId = @parkImage.Id }), 3323, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </a>\r\n                    <div class=\"carousel-caption text-center\">\r\n                        <h1>");
#nullable restore
#line 70 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
                       Write(parkImage.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <h4>");
#nullable restore
#line 71 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
                       Write(parkImage.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <a id=\"delete\" class=\"nav-link\" onclick=\"return deleteValidation()\"");
            BeginWriteAttribute("href", " href=\"", 3667, "\"", 3833, 1);
#nullable restore
#line 72 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
WriteAttributeValue("", 3674, Url.Action("DeleteImageById", "Personal", new { imageId = @parkImage.Id, Parkname = @Model.ParkDetails.ParkName, ParkNumber = @Model.ParkDetails.ParkNumber }), 3674, 159, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash-alt\"></i> </a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 75 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
                imageNumber = imageNumber + 1;
            }

        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 80 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
     if (@Model.ParkImages.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span><i id=""arrow"" class=""fas fa-arrow-circle-left fa-lg""></i></span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span><i id=""arrow"" class=""fas fa-arrow-circle-right fa-lg""></i></span>
        </a>
");
#nullable restore
#line 88 "C:\Users\micha\Documents\GitHub\Website\MVC Michael\Views\Personal\ParkImages.cshtml"
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
