#pragma checksum "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcb037e131aad75d9a3235bed457fb0d1c55be84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Store2Partial), @"mvc.1.0.view", @"/Views/Shared/_Store2Partial.cshtml")]
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
#line 2 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcb037e131aad75d9a3235bed457fb0d1c55be84", @"/Views/Shared/_Store2Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37aa9dcf256fe53d484c02dd8f802c8d1f78dbd4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Store2Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("jhk"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card tada "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
 foreach (Store store in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"box  col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcb037e131aad75d9a3235bed457fb0d1c55be845226", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"img\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fcb037e131aad75d9a3235bed457fb0d1c55be845536", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 250, "~/assets/image/", 250, 15, true);
#nullable restore
#line 7 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
AddHtmlAttributeValue("", 265, store.Image, 265, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"title-name-time\">\r\n                <div class=\"title-name\">\r\n                    <div class=\"restoran-name\">\r\n                        <h6>");
#nullable restore
#line 12 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
                       Write(store.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                    </div>\r\n");
#nullable restore
#line 14 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
                     if (store.Title.Length > 17)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"title\">\r\n                            <p>");
#nullable restore
#line 18 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
                          Write(Html.Raw(store.Title.Substring(0, 17)));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 20 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"title\">\r\n                            <p>");
#nullable restore
#line 24 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
                          Write(Html.Raw(store.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 26 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
                <div class=""time"">
                    20-30<br><br>min
                </div>
            </div>
            <div class=""card-bottom"">
                <span class=""delivery-icon"">
                    <svg style=""color: gray;"" viewBox=""0 0 24 24""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M4.401 9.602C4.682 9.883 5.067 10.041 5.463 10.041H5.502C5.918 10.031 6.299 9.854 6.577 9.545L9.734 6.038C10.27 5.443 10.245 4.534 9.679 3.967L8.098 2.385C7.809 2.096 7.394 1.941 7 1.947C6.59 1.957 6.198 2.138 5.924 2.442L2.764 5.954C2.23 6.547 2.254 7.455 2.818 8.02L4.401 9.602ZM10.722 11.734L12.173 10.075C13.547 11.004 15.169 11.499 16.828 11.495H17.5C18.329 11.495 19 10.823 19 9.995C19 9.16599 18.329 8.495 17.5 8.495H16.828C15.416 8.49099 14.062 7.93 13.061 6.93399C12.774 6.62999 12.367 6.47 11.95 6.496C11.535 6.509 11.145 6.69499 10.871 7.007L7.371 11.007C6.827 11.632 6.891 12.58 7.516 13.123C7.565 13.166 7.617 13.206 7.671 13.243L8.335 13.685C10.123 14.89 10.994 17.063");
                WriteLiteral(@" 10.535 19.169C10.338 19.974 10.83 20.787 11.635 20.984C12.44 21.181 13.252 20.688 13.449 19.883C13.454 19.863 13.459 19.841 13.463 19.82C14.115 16.825 13.061 13.714 10.722 11.734ZM22 18.495C22 17.114 20.881 15.995 19.5 15.995C18.119 15.995 17 17.114 17 18.495C17 19.875 18.119 20.995 19.5 20.995C20.881 20.995 22 19.875 22 18.495ZM24 18.495C24 20.98 21.985 22.995 19.5 22.995C17.015 22.995 15 20.98 15 18.495C15 16.009 17.015 13.995 19.5 13.995C21.985 13.995 24 16.009 24 18.495ZM7 18.495C7 17.114 5.881 15.995 4.5 15.995C3.119 15.995 2 17.114 2 18.495C2 19.875 3.119 20.995 4.5 20.995C5.881 20.995 7 19.875 7 18.495ZM9 18.495C9 20.98 6.985 22.995 4.5 22.995C2.015 22.995 0 20.98 0 18.495C0 16.009 2.015 13.995 4.5 13.995C6.985 13.995 9 16.009 9 18.495ZM12.125 3.995C12.125 2.683 13.189 1.62 14.5 1.62C15.812 1.62 16.875 2.683 16.875 3.995C16.875 5.30599 15.812 6.37 14.5 6.37C13.189 6.37 12.125 5.30599 12.125 3.995Z""></path></svg>
                </span>
");
#nullable restore
#line 36 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
                 if (store.IsDeliveryFree)
                {



#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span class=\"delivery-price\">AZN 0.00</span>\r\n");
#nullable restore
#line 41 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span class=\"delivery-price\">AZN 2.00</span>\r\n");
#nullable restore
#line 45 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span class=\"usd-icon\">$<span");
                BeginWriteAttribute("class", " class=\"", 3286, "\"", 3294, 0);
                EndWriteAttribute();
                WriteLiteral(@">$$$</span></span>
                <span class=""icon"">
                    <svg viewBox=""0 0 24 24"" class=""VenueCardFooter__StyledRatingSmiley-sc-vwzuvz-2 eqSvGJ""><path d=""M12 0c6.6 0 12 5.4 12 12s-5.4 12-12 12S0 18.6 0 12 5.4 0 12 0zm0 2C6.5 2 2 6.5 2 12s4.5 10 10 10 10-4.5 10-10S17.5 2 12 2zm4.7 12.2c.4.3.6.8.3 1.3-1.2 1.9-2.8 3-5 3.1-2.2-.1-3.8-1-4.8-2.9-.2-.5-.2-.9.1-1.3.2-.3.6-.4 1-.3.4.1.5.4.7.7.7 1.3 1.9 1.9 3.3 1.7 1.2-.1 2-.7 2.8-1.6.1-.2.2-.4.4-.5.2-.4.7-.5 1.2-.2zM16 7c1 0 1.9.8 1.9 1.9s-.8 1.9-1.9 1.9c-1 0-1.9-.8-1.9-1.9 0-1.1.8-1.9 1.9-1.9zM8 7c1 0 1.9.8 1.9 1.9s-.8 1.8-1.9 1.8c-1.1 0-1.9-.8-1.9-1.9C6.1 7.8 7 7 8 7z"" fill-rule=""evenodd"" clip-rule=""evenodd"" fill=""currentColor""></path></svg>
                </span>
                <span class=""point"">
                    9.8
                </span>
                <span class=""delivery-time-respon"">20-30 min</span>
            </div>


        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 4 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
                                                         WriteLiteral(store.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 59 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Shared\_Store2Partial.cshtml"
}

#line default
#line hidden
#nullable disable
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
