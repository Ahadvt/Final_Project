#pragma checksum "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60be128078cbb7f950e1caac4aafef07848da304"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Bussines_Views_Courier_Detail), @"mvc.1.0.view", @"/Areas/Bussines/Views/Courier/Detail.cshtml")]
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
#line 2 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\_ViewImports.cshtml"
using Final_Project.Areas.Bussines.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\_ViewImports.cshtml"
using Final_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60be128078cbb7f950e1caac4aafef07848da304", @"/Areas/Bussines/Views/Courier/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adad1f849b9d6b0784f5010f749081b4609c39f7", @"/Areas/Bussines/Views/_ViewImports.cshtml")]
    public class Areas_Bussines_Views_Courier_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "bussinesaccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "restuorantmain", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Previous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    double totalcourier = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""container"">

    <div class=""row"">
        <div class=""col-md-12 stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <p class=""card-title"">completed orders</p>
                    <div class=""table-responsive"">
                        <table id=""recent-purchases-listing"" class=""table"">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Client</th>
                                    <th>Payment Method</th>
                                    <th>Date</th>
                                    <th>Earn</th>

                                </tr>

                            </thead>

                            <tbody>
");
#nullable restore
#line 33 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                 foreach (Order order in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td style=\"display:none;\">\r\n                                            ");
#nullable restore
#line 37 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                        Write(totalcourier+=2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 39 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                       Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 40 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                       Write(order.AppUser.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 41 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                        Write(order.IsCard?"Card":"Cash");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 42 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                       Write(order.Date.ToString("yyyy:dd:MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>Azn ");
#nullable restore
#line 43 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                           Write(order.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 45 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <nav aria-label=\"Page navigation example\">\r\n        <ul class=\"pagination\">\r\n");
#nullable restore
#line 56 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
             if (ViewBag.CurrentPage == 1)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""page-item"">
                    <a style=""pointer-events:none"" class=""page-link"" href=""#"" aria-label=""Previous"">
                        <span aria-hidden=""true"">&laquo;</span>
                    </a>
                </li>
");
#nullable restore
#line 64 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60be128078cbb7f950e1caac4aafef07848da30410141", async() => {
                WriteLiteral("\r\n                        <span aria-hidden=\"true\">&laquo;</span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                                                                         WriteLiteral(ViewBag.CurrentPage-1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 73 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
             for (int i = 1; i <= ViewBag.TotalPage; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 2751, "\"", 2814, 2);
            WriteAttributeValue("", 2759, "page-item", 2759, 9, true);
#nullable restore
#line 78 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
WriteAttributeValue("  ", 2768, ViewBag.CurrentPage == i ?  "active" : "", 2770, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 2815, "\"", 2876, 1);
#nullable restore
#line 78 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
WriteAttributeValue("", 2823, ViewBag.CurrentPage==i ? "pointer-events:none" :"", 2823, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60be128078cbb7f950e1caac4aafef07848da30414273", async() => {
#nullable restore
#line 78 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                                                                                                                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                                                                                                                                                                                                                        WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 79 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 81 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
             if (ViewBag.TotalPage == ViewBag.CurrentPage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a style=\"pointer-events:none\" class=\"page-link\" href=\"#\" aria-label=\"Next\">\r\n                        <span aria-hidden=\"true\">&laquo;</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 88 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60be128078cbb7f950e1caac4aafef07848da30418427", async() => {
                WriteLiteral("\r\n                        <span aria-hidden=\"true\">&raquo;</span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                                                                         WriteLiteral(ViewBag.CurrentPage+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 96 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </ul>
    </nav>

   


    <div class=""tab-content py-0 px-0"">
        <div class=""tab-pane fade show active"" id=""overview"" role=""tabpanel"" aria-labelledby=""overview-tab"">
            <div class=""d-flex flex-wrap justify-content-xl-between"">
                <div class=""d-flex py-3 border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">

                    <i class="" me-3 icon-lg text-success fa-solid fa-person-booth""></i>
                    <div class=""d-flex flex-column justify-content-around"">
                        <small class=""mb-1 text-muted"">courier </small>
                        <h5 class=""me-2 mb-0"">20% Azn ");
#nullable restore
#line 113 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Detail.cshtml"
                                                 Write(totalcourier.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
