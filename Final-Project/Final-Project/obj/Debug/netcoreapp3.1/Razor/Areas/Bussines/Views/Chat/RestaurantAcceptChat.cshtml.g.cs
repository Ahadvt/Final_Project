#pragma checksum "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Chat\RestaurantAcceptChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "705b1073e6ead96807ca6c83d55cbe1e1f1c850b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Bussines_Views_Chat_RestaurantAcceptChat), @"mvc.1.0.view", @"/Areas/Bussines/Views/Chat/RestaurantAcceptChat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"705b1073e6ead96807ca6c83d55cbe1e1f1c850b", @"/Areas/Bussines/Views/Chat/RestaurantAcceptChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adad1f849b9d6b0784f5010f749081b4609c39f7", @"/Areas/Bussines/Views/_ViewImports.cshtml")]
    public class Areas_Bussines_Views_Chat_RestaurantAcceptChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChatVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/image/cdbe7be1-6efd-473c-9f5d-1104414be4a0logo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle user_img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Chat\RestaurantAcceptChat.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->

<!DOCTYPE html>
<html>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "705b1073e6ead96807ca6c83d55cbe1e1f1c850b5542", async() => {
                WriteLiteral(@"
    <title>Chat</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.5.0/css/all.css"" integrity=""sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU"" crossorigin=""anonymous"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.css"">
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.js""></script>
    <style>
        	body,html{
			height: 100%;
			margin: 0;
			background: #7F7FD5;
	       background: -webkit-linear-gradient(to right, #91EAE4, #86A8E7, #7F");
                WriteLiteral(@"7FD5);
	        background: linear-gradient(to right, #91EAE4, #86A8E7, #7F7FD5);
		}

		.chat{
			margin-top: auto;
			margin-bottom: auto;
		}
		.card{
			height: 500px;
			border-radius: 15px !important;
			background-color: rgba(0,0,0,0.4) !important;
		}
		.contacts_body{
			padding:  0.75rem 0 !important;
			overflow-y: auto;
			white-space: nowrap;
		}
		.msg_card_body{
			overflow-y: auto;
		}
		.card-header{
			border-radius: 15px 15px 0 0 !important;
			border-bottom: 0 !important;
		}
	 .card-footer{
		border-radius: 0 0 15px 15px !important;
			border-top: 0 !important;
	}
		.container{
			align-content: center;
		}
		.search{
			border-radius: 15px 0 0 15px !important;
			background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color:white !important;
		}
		.search:focus{
		     box-shadow:none !important;
           outline:0px !important;
		}
		.type_msg{
			background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			colo");
                WriteLiteral(@"r:white !important;
			height: 60px !important;
			overflow-y: auto;
		}
			.type_msg:focus{
		     box-shadow:none !important;
           outline:0px !important;
		}
		.attach_btn{
	border-radius: 15px 0 0 15px !important;
	background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color: white !important;
			cursor: pointer;
		}
		.send_btn{
	border-radius: 0 15px 15px 0 !important;
	background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color: white !important;
			cursor: pointer;
		}
		.search_btn{
			border-radius: 0 15px 15px 0 !important;
			background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color: white !important;
			cursor: pointer;
		}
		.contacts{
			list-style: none;
			padding: 0;
		}
		.contacts li{
			width: 100% !important;
			padding: 5px 10px;
			margin-bottom: 15px !important;
		}
	.active{
			background-color: rgba(0,0,0,0.3);
	}
		.user_img{
			height: 70px;
			width: 70px;
			border:1.5px s");
                WriteLiteral(@"olid #f5f6fa;

		}
		.user_img_msg{
			height: 40px;
			width: 40px;
			border:1.5px solid #f5f6fa;

		}
	.img_cont{
			position: relative;
			height: 70px;
			width: 70px;
	}
	.img_cont_msg{
			height: 40px;
			width: 40px;
	}
	.online_icon{
		position: absolute;
		height: 15px;
		width:15px;
		background-color: #4cd137;
		border-radius: 50%;
		bottom: 0.2em;
		right: 0.4em;
		border:1.5px solid white;
	}
	.offline{
		background-color: #c23616 !important;
	}
	.user_info{
		margin-top: auto;
		margin-bottom: auto;
		margin-left: 15px;
	}
	.user_info span{
		font-size: 20px;
		color: white;
	}
	.user_info p{
	font-size: 10px;
	color: rgba(255,255,255,0.6);
	}
	.video_cam{
		margin-left: 50px;
		margin-top: 5px;
	}
	.video_cam span{
		color: white;
		font-size: 20px;
		cursor: pointer;
		margin-right: 20px;
	}
	.msg_cotainer{
		margin-top: auto;
		margin-bottom: auto;
		margin-left: 10px;
		border-radius: 25px;
		background-color: #82ccdd;
		padding: 1");
                WriteLiteral(@"0px;
		position: relative;
	}
	.msg_cotainer_send{
		margin-top: auto;
		margin-bottom: auto;
		margin-right: 10px;
		border-radius: 25px;
		background-color: #78e08f;
		padding: 10px;
		position: relative;
	}
	.msg_time{
		position: absolute;
		left: 0;
		bottom: -15px;
		color: rgba(255,255,255,0.5);
		font-size: 10px;
	}
	.msg_time_send{
		position: absolute;
		right:0;
		bottom: -15px;
		color: rgba(255,255,255,0.5);
		font-size: 10px;
	}
	.msg_head{
		position: relative;
	}
	#action_menu_btn{
		position: absolute;
		right: 10px;
		top: 10px;
		color: white;
		cursor: pointer;
		font-size: 20px;
	}
	.action_menu{
		z-index: 1;
		position: absolute;
		padding: 15px 0;
		background-color: rgba(0,0,0,0.5);
		color: white;
		border-radius: 15px;
		top: 30px;
		right: 15px;
		display: none;
	}
	.action_menu ul{
		list-style: none;
		padding: 0;
	margin: 0;
	}
	.action_menu ul li{
		width: 100%;
		padding: 10px 15px;
		margin-bottom: 5px;
	}
	.action_men");
                WriteLiteral("u ul li i{\r\n\t\tpadding-right: 10px;\r\n\r\n\t}\r\n\t.action_menu ul li:hover{\r\n\t\tcursor: pointer;\r\n\t\tbackground-color: rgba(0,0,0,0.2);\r\n\t}\r\n\t");
                WriteLiteral("@media(max-width: 576px){\r\n\t.contacts_card{\r\n\t\tmargin-bottom: 15px !important;\r\n\t}\r\n\t}\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!--Coded With Love By Mutiullah Samim-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "705b1073e6ead96807ca6c83d55cbe1e1f1c850b12190", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid h-100\">\r\n        <div class=\"row justify-content-center h-100\">\r\n     <div id=\"user-id\" style=\"display:none\">");
#nullable restore
#line 251 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Chat\RestaurantAcceptChat.cshtml"
                                       Write(Model.User.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n     <div id=\"res-image\" style=\"display:none\">");
#nullable restore
#line 252 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Chat\RestaurantAcceptChat.cshtml"
                                         Write(Model.Restuorant.Image);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
            <div class=""col-md-12 col-xl-6 chat"">
                <div class=""card"">
                    <div class=""card-header msg_head"">
                        <div class=""d-flex bd-highlight"">
                            <div class=""img_cont"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "705b1073e6ead96807ca6c83d55cbe1e1f1c850b13552", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                <span class=""online_icon""></span>
                            </div>
                            <div class=""user_info"">
                                <span>Chat with Khalid</span>
                                <p>1767 Messages</p>
                            </div>
                            <div class=""video_cam"">
                                <span><i class=""fas fa-video""></i></span>
                                <span><i class=""fas fa-phone""></i></span>
                            </div>
                        </div>
                        <span id=""action_menu_btn""><i class=""fas fa-ellipsis-v""></i></span>
                        <div class=""action_menu"">
                            <ul>
                                <li><i class=""fas fa-user-circle""></i> View profile</li>
                                <li><i class=""fas fa-users""></i> Add to close friends</li>
                                <li><i class=""fas fa-plus""></i> Add to group</li>");
                WriteLiteral(@"
                                <li><i class=""fas fa-ban""></i> Block</li>
                            </ul>
                        </div>
                    </div>
                    <div id=""msglist"" class=""card-body msg_card_body"">
                      
                 
                    </div>
                    <div class=""card-footer"">
                        <div class=""input-group"">
                            <div class=""input-group-append"">
                                <span class=""input-group-text attach_btn""><i class=""fas fa-paperclip""></i></span>
                            </div>
                            <textarea id=""textarea""");
                BeginWriteAttribute("name", " name=\"", 8166, "\"", 8173, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control type_msg"" placeholder=""Type your message...""></textarea>
                            <div id=""btn"" class=""input-group-append"">
                                <span class=""input-group-text send_btn""><i class=""fas fa-location-arrow""></i></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
	<script>
        $(document).ready(function () {
            $('#action_menu_btn').click(function () {
                $('.action_menu').toggle();
            });
        });
	</script>


	");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "705b1073e6ead96807ca6c83d55cbe1e1f1c850b17296", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
		var btn = document.getElementById(""btn"")
        btn.addEventListener(""click"", function (e) {
			e.preventDefault()
			var text = document.getElementById(""textarea"").value
			document.getElementById(""textarea"").value = """"
            var msglist = document.getElementById(""msglist"")
            var divv = document.createElement(""div"")
            var im = document.getElementById(""res-image"").innerHTML
            divv.classList.add(""d-flex"")
            divv.classList.add(""justify-content-end"")
            divv.classList.add(""mb-4"")
            divv.innerHTML = `
                    <div class=""msg_cotainer_send"">
                       ${text}
                        <span class=""msg_time""></span>
                    </div>
                  <div class=""img_cont_msg"">
                    <img src=""https://localhost:44378/assets/image/${im}"""" class=""rounded-circle user");
                WriteLiteral(@"_img_msg"">
                    </div>
`
            msglist.appendChild(divv)
			Connection.invoke(""SendMessageToAdmin"", text)

		})
        Connection.on(""recivemessageinres"", function (data) {

            var msglist = document.getElementById(""msglist"")

            var divv = document.createElement(""div"")
            console.log(divv)
            divv.classList.add(""d-flex"")
            divv.classList.add(""justify-content-start"")
            divv.classList.add(""mb-4"")
            divv.innerHTML = `
            <div class=""img_cont_msg"">
                    <img src=""/assets/image/cdbe7be1-6efd-473c-9f5d-1104414be4a0logo.svg"" class=""rounded-circle user_img_msg"">
                    </div>
                    <div class=""msg_cotainer"">
                       ${data.text}
                        <span class=""msg_time"">${data.date}</span>
                    </div>
`

            msglist.appendChild(divv)

		})

        $.ajax({
            url: ""/bussines/chat/getmessage"",
   ");
                WriteLiteral(@"       
            dataType: 'json',
            type: ""post"",
            success: function (data) {
                console.log(data)
                var messagelist = document.getElementById(""msglist"")
		        var userid=document.getElementById(""user-id"").innerHTML
                var imageee=document.getElementById(""res-image"").innerHTML
                $.map(data, function (val, i) {

                    const d = new Date();
                 
					
                    if (val.reciveUserId == userid) {
                        var Recive = this.document.createElement(""div"")
                        Recive.classList.add(""d-flex"")
                        Recive.classList.add(""justify-content-start"")
                        Recive.classList.add(""mb-4"")
                        Recive.innerHTML =
                            `
                                      <div class=""img_cont_msg"">
                           <img src=""https://localhost:44378/assets/image/cdbe7be1-6efd-473c-9f5d-1");
                WriteLiteral(@"104414be4a0logo.svg"" class=""rounded-circle user_img_msg"">
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
                           <span class=""msg_time_send"">${val.date.substring(11, 16)}</span>
                        </div>
                       <div class=""img_cont_msg"">
");
                WriteLiteral(@"                             <img src=""https://localhost:44378/assets/image/${imageee}"" class=""rounded-circle user_img_msg"">
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
	</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
