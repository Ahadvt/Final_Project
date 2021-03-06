#pragma checksum "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd1559d439675e83a9c8f3ba226314c3c0f5d6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Chat_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Chat/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
using Final_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acd1559d439675e83a9c8f3ba226314c3c0f5d6f", @"/Areas/Admin/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1e0c8e717f8e079dbc23c4b9ad3c7f9f21b12f1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChatVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle user_img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            DefineSection("Css", async() => {
                WriteLiteral(@" 
    <style>


.chat {
    margin-top: auto;
    margin-bottom: auto;
}

.card {
    height: 500px;
    border-radius: 15px !important;
    background-color: rgba(0,0,0,0.4) !important;
}

.contacts_body {
    padding: 0.75rem 0 !important;
    overflow-y: auto;
    white-space: nowrap;
}

.msg_card_body {
    overflow-y: auto;
}

.card-header {
    border-radius: 15px 15px 0 0 !important;
    border-bottom: 0 !important;
}

.card-footer {
    border-radius: 0 0 15px 15px !important;
    border-top: 0 !important;
}

.container {
    align-content: center;
}

.search {
    border-radius: 15px 0 0 15px !important;
    background-color: rgba(0,0,0,0.3) !important;
    border: 0 !important;
    color: white !important;
}

    .search:focus {
        box-shadow: none !important;
        outline: 0px !important;
    }

.type_msg {
    background-color: rgba(0,0,0,0.3) !important;
    border: 0 !important;
    color: white !important;
    height: 60px !importan");
                WriteLiteral(@"t;
    overflow-y: auto;
}

    .type_msg:focus {
        box-shadow: none !important;
        outline: 0px !important;
    }

.attach_btn {
    border-radius: 15px 0 0 15px !important;
    background-color: rgba(0,0,0,0.3) !important;
    border: 0 !important;
    color: white !important;
    cursor: pointer;
}

.send_btn {
    border-radius: 0 15px 15px 0 !important;
    background-color: rgba(0,0,0,0.3) !important;
    border: 0 !important;
    color: white !important;
    cursor: pointer;
}

.search_btn {
    border-radius: 0 15px 15px 0 !important;
    background-color: rgba(0,0,0,0.3) !important;
    border: 0 !important;
    color: white !important;
    cursor: pointer;
}

.contacts {
    list-style: none;
    padding: 0;
}

    .contacts li {
        width: 100% !important;
        padding: 5px 10px;
        margin-bottom: 15px !important;
    }

.active1 {
    background-color: rgba(0,0,0,0.3);
}

.user_img {
    height: 70px;
    width: 70px;
    bo");
                WriteLiteral(@"rder: 1.5px solid #f5f6fa;
}

.user_img_msg {
    height: 40px;
    width: 40px;
    border: 1.5px solid #f5f6fa;
}

.img_cont {
    position: relative;
    height: 70px;
    width: 70px;
}

.img_cont_msg {
    height: 40px;
    width: 40px;
}

.online_icon {
    position: absolute;
    height: 15px;
    width: 15px;
    background-color: #4cd137;
    border-radius: 50%;
    bottom: 0.2em;
    right: 0.4em;
    border: 1.5px solid white;
}

.offline {
    background-color: #c23616 !important;
}

.user_info {
    margin-top: auto;
    margin-bottom: auto;
    margin-left: 15px;
}

    .user_info span {
        font-size: 20px;
        color: white;
    }

    .user_info p {
        font-size: 10px;
        color: rgba(255,255,255,0.6);
    }

.video_cam {
    margin-left: 50px;
    margin-top: 5px;
}

    .video_cam span {
        color: white;
        font-size: 20px;
        cursor: pointer;
        margin-right: 20px;
    }

.msg_cotainer {
   ");
                WriteLiteral(@" margin-top: auto;
    margin-bottom: auto;
    margin-left: 10px;
    border-radius: 25px;
    background-color: #82ccdd;
    padding: 10px;
    position: relative;
}

.msg_cotainer_send {
    margin-top: auto;
    margin-bottom: auto;
    margin-right: 10px;
    border-radius: 25px;
    background-color: #78e08f;
    padding: 10px;
    position: relative;
}

.msg_time {
    position: absolute;
    left: 0;
    bottom: -15px;
    color: rgba(255,255,255,0.5);
    font-size: 10px;
}

.msg_time_send {
    position: absolute;
    right: 0;
    bottom: -15px;
    color: rgba(255,255,255,0.5);
    font-size: 10px;
}

.msg_head {
    position: relative;
}

#action_menu_btn {
    position: absolute;
    right: 10px;
    top: 10px;
    color: white;
    cursor: pointer;
    font-size: 20px;
}

.action_menu {
    z-index: 1;
    position: absolute;
    padding: 15px 0;
    background-color: rgba(0,0,0,0.5);
    color: white;
    border-radius: 15px;
    top: 30px");
                WriteLiteral(@";
    right: 15px;
    display: none;
}

    .action_menu ul {
        list-style: none;
        padding: 0;
        margin: 0;
    }

        .action_menu ul li {
            width: 100%;
            padding: 10px 15px;
            margin-bottom: 5px;
        }

            .action_menu ul li i {
                padding-right: 10px;
            }

            .action_menu ul li:hover {
                cursor: pointer;
                background-color: rgba(0,0,0,0.2);
            }

");
                WriteLiteral("@media(max-width: 576px) {\r\n    .contacts_card {\r\n        margin-bottom: 15px !important;\r\n    }\r\n}\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container-fluid h-100"">
    <div class=""row justify-content-center h-100"">
        <div class=""col-md-4 col-xl-4 chat"">
            <div class=""card mb-sm-3 mb-md-0 contacts_card"">
             
                <div class=""card-body contacts_body"">
                    <p id=""Admin"" style=""display:none"">");
#nullable restore
#line 271 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                                                  Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul class=\"contacts\">\r\n\r\n");
#nullable restore
#line 274 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                         for (int i = 0; i < Model.Restuorants.Count; i++)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"user-list\" style=\"cursor:pointer;\" data-id=\"");
#nullable restore
#line 277 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                                                                              Write(Model.Restuorants[i].AppUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                <div class=\"d-flex bd-highlight\">\r\n                                    <div class=\"img_cont\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "acd1559d439675e83a9c8f3ba226314c3c0f5d6f10762", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5626, "~/assets/image/", 5626, 15, true);
#nullable restore
#line 280 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
AddHtmlAttributeValue("", 5641, Model.Restuorants[i].Image, 5641, 27, false);

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
            WriteLiteral("\r\n                                        <span");
            BeginWriteAttribute("id", " id=\"", 5749, "\"", 5785, 1);
#nullable restore
#line 281 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
WriteAttributeValue("", 5754, Model.Restuorants[i].AppUserId, 5754, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5786, "\"", 5858, 1);
#nullable restore
#line 281 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
WriteAttributeValue("", 5794, Model.Users[i].ConnectionId!=null?"online_icon":"ofline_icon", 5794, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                    </div>\r\n                                    <div class=\"user_info\">\r\n                                        <span>");
#nullable restore
#line 284 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                                         Write(Model.Restuorants[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <p data-id=\"");
#nullable restore
#line 285 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                                               Write(Model.Restuorants[i].AppUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"is_online\">");
#nullable restore
#line 285 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                                                                                                  Write(Model.Restuorants[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 285 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                                                                                                                               Write(Model.Users[i].ConnectionId!=null?"is online":"is ofline");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                    </div>\r\n                                </div>\r\n                            </li>\r\n");
#nullable restore
#line 289 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 292 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                         for (int i = 0; i < Model.Stores.Count; i++)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"user-list\" style=\"cursor:pointer;\" data-id=\"");
#nullable restore
#line 295 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                                                                              Write(Model.Stores[i].AppUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                <div class=\"d-flex bd-highlight\">\r\n                                    <div class=\"img_cont\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "acd1559d439675e83a9c8f3ba226314c3c0f5d6f16010", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6793, "~/assets/image/", 6793, 15, true);
#nullable restore
#line 298 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
AddHtmlAttributeValue("", 6808, Model.Stores[i].Image, 6808, 22, false);

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
            WriteLiteral("\r\n                                        <span");
            BeginWriteAttribute("id", " id=\"", 6911, "\"", 6942, 1);
#nullable restore
#line 299 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
WriteAttributeValue("", 6916, Model.Stores[i].AppUserId, 6916, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 6943, "\"", 7020, 1);
#nullable restore
#line 299 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
WriteAttributeValue("", 6951, Model.StoreUsers[i].ConnectionId!=null?"online_icon":"ofline_icon", 6951, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                    </div>\r\n                                    <div class=\"user_info\">\r\n                                        <span>");
#nullable restore
#line 302 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                                         Write(Model.Stores[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <p data-id=\"");
#nullable restore
#line 303 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                                               Write(Model.Stores[i].AppUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"is_online\">");
#nullable restore
#line 303 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                                                                                             Write(Model.Stores[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 303 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                                                                                                                     Write(Model.StoreUsers[i].ConnectionId!=null?"is online":"is ofline");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                    </div>\r\n                                </div>\r\n                            </li>\r\n");
#nullable restore
#line 307 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Admin\Views\Chat\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </ul>
                </div>
                <div class=""card-footer""></div>
            </div>
        </div>
        <div class="" area_message d-none col-md-8 col-xl-6 chat"">
            <div id=""user_messages"" class=""card"">

            </div>
        </div>
    </div>
</div>

");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd1559d439675e83a9c8f3ba226314c3c0f5d6f20753", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        var Connection = new signalR.HubConnectionBuilder().withUrl(""/orderhub"").build()
        Connection.start()
        Connection.on(""recivemessage"", function (data) {
        var msglist = document.getElementById(""msglist"")
            var body = document.querySelector("".msg_card_body"")
            console.log(data)
            var divv = document.createElement(""div"")
            console.log(divv)
            divv.classList.add(""d-flex"")
            divv.classList.add(""justify-content-start"")
            divv.classList.add(""mb-4"")
            divv.innerHTML = `
            <div class=""img_cont_msg"">
                    <img src=""https://localhost:44378/assets/image/${data.image}"" class=""rounded-circle user_img_msg"">
                    </div>
                    <div class=""msg_cotainer"">
                       ${data.text}
                        <span class=""msg_time"">${data.date}</span>
                    </div>
`
            msglist.appendChild(divv)
           ");
                WriteLiteral(@" body.scrollTop = body.scrollHeight;

        })
        Connection.on(""UserConnected"", function (id) {

            var userid=id.toString()
            var user = document.getElementById(userid)
            user.classList.add(""online_icon"")
            user.classList.remove(""ofline_icon"")
            var is_onlines = document.querySelectorAll("".is_online"")
            is_onlines.forEach(online => {
                var id=  online.getAttribute(""data-id"")
                if (id==userid) {
                    online.innerHTML=""is online""
                }
            })
           console.log(user2)
   
        })
        Connection.on(""UserDisConnected"", function (id) {
            var userid = id.toString()
            var user = document.getElementById(userid)
            user.classList.remove(""online_icon"")
            user.classList.add(""ofline_icon"")
            var is_onlines = document.querySelectorAll("".is_online"")
            is_onlines.forEach(online => {
                va");
                WriteLiteral(@"r id = online.getAttribute(""data-id"")
                if (id == userid) {
                    online.innerHTML = ""is ofline""
                }
            })
            console.log(user2)
        })
        var btn = document.getElementById(""btn"")
        $(document).on(""click"", ""#btn"", function (e) {
            var body = document.querySelector("".msg_card_body"")
            var ussser = document.getElementById(""message_admin_user"").getAttribute(""data-id"")
            e.preventDefault()
            var text = document.getElementById(""textarea"").value
            document.getElementById(""textarea"").value=""""
            var msglist = document.getElementById(""msglist"")
            var divv = document.createElement(""div"")
          
            divv.classList.add(""d-flex"")
            divv.classList.add(""justify-content-end"")
            divv.classList.add(""mb-4"")
            divv.innerHTML = `
                    <div class=""msg_cotainer_send"">
                       ${text}
            ");
                WriteLiteral(@"            <span class=""msg_time""></span>
                    </div>
                  <div class=""img_cont_msg"">
                    <img src=""https://localhost:44378/assets/image/cdbe7be1-6efd-473c-9f5d-1104414be4a0logo.svg"""" class=""rounded-circle user_img_msg"">
                    </div>
`
            msglist.appendChild(divv)
            body.scrollTop = body.scrollHeight;

            Connection.invoke(""SendMessageToBussines"", text, ussser)
            
        })

        var users = document.querySelectorAll("".user-list"")
        console.log(users)
        users.forEach(user =>
        user.addEventListener(""click"", function (e) {
                e.preventDefault()
                users.forEach(use => {
                    use.classList.remove(""active1"")
                })
                user.classList.add(""active1"")
                var image = user.children[0].children[0].children[0].getAttribute(""src"")
                var Nameel = user.children[0].children[1].children[0]
   ");
                WriteLiteral(@"             var name = Nameel.innerHTML
                var userid=user.getAttribute(""data-id"")
                var messages = document.getElementById(""user_messages"")
                var admin = document.getElementById(""Admin"").innerHTML
                var area = document.querySelector("".area_message"")
                area.classList.remove(""d-none"")
                messages.innerHTML = `

     
                <div id=""message_admin_user"" data-id=""${userid}"" class=""card-header msg_head"">
                    <div class=""d-flex bd-highlight"">
                        <div class=""img_cont"">
                            <img src=""${image}"" class=""rounded-circle user_img"">
                            <span id=""isonline"" class=""""></span>
                        </div>
                        <div class=""user_info"">
                            <span>Chat with ${name}</span>

                        </div>
                   
                    </div>
                    <span id=""action_menu_b");
                WriteLiteral(@"tn""><i class=""fas fa-ellipsis-v""></i></span>
                   
                </div>
                <div id=""msglist"" class=""card-body msg_card_body"">
                   

                </div>
                <div class=""card-footer"">
                    <div class=""input-group"">
                        <div class=""input-group-append"">
                            <span class=""input-group-text attach_btn""><i class=""fas fa-paperclip""></i></span>
                        </div>
                        <textarea id=""textarea"" name="""" class=""form-control type_msg"" placeholder=""Type your message...""></textarea>
                        <div id=""btn"" class=""input-group-append"">
                            <span class=""input-group-text send_btn""><i class=""fas fa-location-arrow""></i></span>
                        </div>
                    </div>
                </div>
           
`

                $.ajax({
                    url: ""/admin/chat/getmessage"",
                    data: {
   ");
                WriteLiteral(@"                     userid: userid,
                        admin:admin
                    },
                    dataType: 'json',
                    type: ""post"",
                    success: function (data) {
                        console.log(data)
                        var messagelist = document.getElementById(""msglist"")
                    
                     
                    
                        $.map(data, function (val, i) {
                            
                            
                            if (val.appUserId == userid) {
                                var Recive = this.document.createElement(""div"")
                                Recive.classList.add(""d-flex"")
                                Recive.classList.add(""justify-content-start"")
                                Recive.classList.add(""mb-4"")
                                Recive.innerHTML =
                                    `
                                      <div class=""img_cont_ms");
                WriteLiteral(@"g"">
                           <img src=""https://localhost:44378${image}"" class=""rounded-circle user_img_msg"">
                       </div>
                       <div class=""msg_cotainer"">
                          ${val.text}
                           <span class=""msg_time"">${val.date.substring(11, 16)},</span>
                       </div>
                                         `
                                messagelist.appendChild(Recive)
                            } else {
                                var Send = this.document.createElement(""div"")
                                Send.classList.add(""d-flex"")
                                Send.classList.add(""justify-content-end"")
                                Send.classList.add(""mb-4"")
                                Send.innerHTML =
                                    `
                           <div class=""msg_cotainer_send"">
                           ${val.text}
                           <span class=""msg_time_send"">${v");
                WriteLiteral(@"al.date.substring(11, 16)}, Today</span>
                        </div>
                       <div class=""img_cont_msg"">
                             <img src=""/assets/image/cdbe7be1-6efd-473c-9f5d-1104414be4a0logo.svg"" class=""rounded-circle user_img_msg"">
                       </div>
                                 `
                                messagelist.appendChild(Send)
                            }

                            

                        })


                    },
                    error: function (status) {
                        console.log(status)
                    }
                })
            })
        )
        
     
      
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChatVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
