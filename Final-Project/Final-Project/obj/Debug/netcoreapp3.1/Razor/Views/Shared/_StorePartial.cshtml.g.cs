#pragma checksum "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Views\Shared\_StorePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d468cda2636dcb984008805c2d452e9643197c2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__StorePartial), @"mvc.1.0.view", @"/Views/Shared/_StorePartial.cshtml")]
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
#line 2 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d468cda2636dcb984008805c2d452e9643197c2f", @"/Views/Shared/_StorePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37aa9dcf256fe53d484c02dd8f802c8d1f78dbd4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__StorePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Store>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("jhk"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Views\Shared\_StorePartial.cshtml"
 foreach (Store store in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"item \">\r\n        <a href=\"#\" class=\"card tada\">\r\n            <div class=\"img\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d468cda2636dcb984008805c2d452e9643197c2f3860", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 180, "~/assets/image/", 180, 15, true);
#nullable restore
#line 8 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Views\Shared\_StorePartial.cshtml"
AddHtmlAttributeValue("", 195, store.Image, 195, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"title-name-time\">\r\n                <div class=\"title-name\">\r\n                    <div class=\"restoran-name\">\r\n                        <h6>");
#nullable restore
#line 13 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Views\Shared\_StorePartial.cshtml"
                       Write(store.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <div class=\"title\">\r\n                        <p>");
#nullable restore
#line 16 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Views\Shared\_StorePartial.cshtml"
                      Write(Html.Raw(store.Title.Substring(0, 17)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""time"">
                    20-30<br><br>min
                </div>
            </div>
            <div style=""padding:5px;"" class=""card-bottom"">
                <span class=""delivery-icon"">
                    <svg style=""color: gray;"" viewBox=""0 0 24 24""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M4.401 9.602C4.682 9.883 5.067 10.041 5.463 10.041H5.502C5.918 10.031 6.299 9.854 6.577 9.545L9.734 6.038C10.27 5.443 10.245 4.534 9.679 3.967L8.098 2.385C7.809 2.096 7.394 1.941 7 1.947C6.59 1.957 6.198 2.138 5.924 2.442L2.764 5.954C2.23 6.547 2.254 7.455 2.818 8.02L4.401 9.602ZM10.722 11.734L12.173 10.075C13.547 11.004 15.169 11.499 16.828 11.495H17.5C18.329 11.495 19 10.823 19 9.995C19 9.16599 18.329 8.495 17.5 8.495H16.828C15.416 8.49099 14.062 7.93 13.061 6.93399C12.774 6.62999 12.367 6.47 11.95 6.496C11.535 6.509 11.145 6.69499 10.871 7.007L7.371 11.007C6.827 11.632 6.891 12.58 7.516 13.123C7.565 13.166 7.617 13.2");
            WriteLiteral(@"06 7.671 13.243L8.335 13.685C10.123 14.89 10.994 17.063 10.535 19.169C10.338 19.974 10.83 20.787 11.635 20.984C12.44 21.181 13.252 20.688 13.449 19.883C13.454 19.863 13.459 19.841 13.463 19.82C14.115 16.825 13.061 13.714 10.722 11.734ZM22 18.495C22 17.114 20.881 15.995 19.5 15.995C18.119 15.995 17 17.114 17 18.495C17 19.875 18.119 20.995 19.5 20.995C20.881 20.995 22 19.875 22 18.495ZM24 18.495C24 20.98 21.985 22.995 19.5 22.995C17.015 22.995 15 20.98 15 18.495C15 16.009 17.015 13.995 19.5 13.995C21.985 13.995 24 16.009 24 18.495ZM7 18.495C7 17.114 5.881 15.995 4.5 15.995C3.119 15.995 2 17.114 2 18.495C2 19.875 3.119 20.995 4.5 20.995C5.881 20.995 7 19.875 7 18.495ZM9 18.495C9 20.98 6.985 22.995 4.5 22.995C2.015 22.995 0 20.98 0 18.495C0 16.009 2.015 13.995 4.5 13.995C6.985 13.995 9 16.009 9 18.495ZM12.125 3.995C12.125 2.683 13.189 1.62 14.5 1.62C15.812 1.62 16.875 2.683 16.875 3.995C16.875 5.30599 15.812 6.37 14.5 6.37C13.189 6.37 12.125 5.30599 12.125 3.995Z""></path></svg>
                </span>
");
#nullable restore
#line 27 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Views\Shared\_StorePartial.cshtml"
                 if (store.IsDeliveryFree)
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"delivery-price\">AZN 0.00</span>\r\n");
#nullable restore
#line 32 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Views\Shared\_StorePartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"delivery-price\">AZN 2.00</span>\r\n");
#nullable restore
#line 36 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Views\Shared\_StorePartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"usd-icon\">$<span");
            BeginWriteAttribute("class", " class=\"", 2918, "\"", 2926, 0);
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

        </a>
    </div>
");
#nullable restore
#line 49 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Views\Shared\_StorePartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Store>> Html { get; private set; }
    }
}
#pragma warning restore 1591
