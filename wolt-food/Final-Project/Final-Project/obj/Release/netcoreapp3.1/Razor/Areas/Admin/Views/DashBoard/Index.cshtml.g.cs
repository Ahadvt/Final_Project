#pragma checksum "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1e134d42b0cb2b2541c46c829920c324dbeb67d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DashBoard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DashBoard/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\_ViewImports.cshtml"
using Final_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
using Final_Project.Areas.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1e134d42b0cb2b2541c46c829920c324dbeb67d", @"/Areas/Admin/Views/DashBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1e0c8e717f8e079dbc23c4b9ad3c7f9f21b12f1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashBoardVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    double totalsale = 0;
    double totalcart = 0;
    double totalcash = 0;
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
                                    <th>Company</th>
                                    <th>Payment Method</th>
                                    <th>Date</th>
                                    <th>Price</th>

                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 34 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                 foreach (Order order in Model.Orderstotal)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"d-none\">\r\n                                    ");
#nullable restore
#line 37 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                Write(totalsale+=order.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                     if (order.IsCard)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                    Write(totalcart+=order.TotalPrice);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                                                      
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                    Write(totalcash+=order.TotalPrice);

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                                                      
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                     if (order.IsDelivery)
                                    {
                                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                   Write(totalcourier+=totalcourier+2);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                                                      

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n");
#nullable restore
#line 52 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                 foreach (Order order in Model.Orders)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td>");
#nullable restore
#line 58 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                       Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 59 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                       Write(order.AppUser.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 60 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                        Write(order.RestuorantId==null?order.Store.Name:order.Restuorant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 61 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                        Write(order.IsCard?"Card":"Cash");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 62 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                       Write(order.Date.ToString("yyyy:dd:MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>Azn ");
#nullable restore
#line 63 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                           Write(String.Format("{0:00.0}", order.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                            </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <nav aria-label=""Page navigation example"">
        <ul class=""pagination"">
");
#nullable restore
#line 76 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
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
#line 84 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1e134d42b0cb2b2541c46c829920c324dbeb67d13756", async() => {
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
#line 89 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
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
#line 93 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 96 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
             for (int i = 1; i <= ViewBag.TotalPage; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 3798, "\"", 3861, 2);
            WriteAttributeValue("", 3806, "page-item", 3806, 9, true);
#nullable restore
#line 98 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
WriteAttributeValue("  ", 3815, ViewBag.CurrentPage == i ?  "active" : "", 3817, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 3862, "\"", 3923, 1);
#nullable restore
#line 98 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
WriteAttributeValue("", 3870, ViewBag.CurrentPage==i ? "pointer-events:none" :"", 3870, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1e134d42b0cb2b2541c46c829920c324dbeb67d17913", async() => {
#nullable restore
#line 98 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
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
#line 98 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
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
#line 99 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 101 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
             if (ViewBag.TotalPage == ViewBag.CurrentPage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a style=\"pointer-events:none\" class=\"page-link\" href=\"#\" aria-label=\"Next\">\r\n                        <span aria-hidden=\"true\">&laquo;</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 108 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1e134d42b0cb2b2541c46c829920c324dbeb67d22079", async() => {
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
#line 112 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
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
#line 116 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </ul>
    </nav>

    <div class=""row"">
        <div class=""col-md-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body dashboard-tabs p-0"">

                    <div class=""tab-content py-0 px-0"">
                        <div class=""tab-pane fade show active"" id=""overview"" role=""tabpanel"" aria-labelledby=""overview-tab"">
                            <div class=""d-flex flex-wrap justify-content-xl-between"">
                                <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                    <i class=""mdi mdi-currency-usd me-3 icon-lg text-danger""></i>
                                    <div class=""d-flex flex-column justify-content-around"">
                                        <small class=""mb-1 text-muted"">Total Sale</small>
                                        <h5 class=""me-2 mb-0"">Azn ");
#nullable restore
#line 134 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                                             Write(totalsale.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    </div>
                                </div>
                                <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">

                                    <i class=""fa-brands me-3 icon-lg fa-cc-amazon-pay text-secondary""></i>
                                    <div class=""d-flex flex-column justify-content-around"">
                                        <small class=""mb-1 text-muted"">Total paid by card </small>
                                        <h5 class=""me-2 mb-0"">Azn ");
#nullable restore
#line 142 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                                             Write(totalcart.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    </div>
                                </div>
                                <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">


                                    <i class="" me-3 icon-lg text-secondary fa-solid fa-manat-sign""></i>
                                    <div class=""d-flex flex-column justify-content-around"">
                                        <small class=""mb-1 text-muted"">Downloads</small>
                                        <h5 class=""me-2 mb-0"">Azn ");
#nullable restore
#line 151 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                                             Write(totalcash.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    </div>
                                </div>
                                <div class=""d-flex py-3 border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">

                                    <i class="" me-3 icon-lg text-info fa-solid fa-hand-holding-dollar""></i>
                                    <div class=""d-flex flex-column justify-content-around"">
                                        <small class=""mb-1 text-muted"">Earning</small>
                                        <h5 class=""me-2 mb-0"">20% Azn ");
#nullable restore
#line 159 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                                                  Write(((totalsale*20)/100).ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    </div>
                                </div>

                                <div class=""d-flex py-3 border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">

                                    <i class="" me-3 icon-lg text-success fa-solid fa-person-booth""></i>
                                    <div class=""d-flex flex-column justify-content-around"">
                                        <small class=""mb-1 text-muted"">courier </small>
                                        <h5 class=""me-2 mb-0"">20% Azn ");
#nullable restore
#line 168 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Areas\Admin\Views\DashBoard\Index.cshtml"
                                                                 Write(totalcourier.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>



</div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashBoardVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
