#pragma checksum "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb048114417c4a32f4e2c9f3e5ad207a7c4fe1ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb048114417c4a32f4e2c9f3e5ad207a7c4fe1ea", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shared_Traveling.ViewModels.Home.LoginVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("45"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/home.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/particlesjs/2.2.2/particles.min.js""></script>
<div class=""container"">
    <form action=""/Home/Login"" method=""post"">
        <div class=""row"">
            <div class=""col-md-6 mx-auto"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <center>
                                    <a href=""https://icons8.com/icon/SHo9iDefm73R/test-account""></a>
                                    <img src=""https://img.icons8.com/ios-glyphs/90/000000/user-male-circle.png"" width=""100"" />
                                </center>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <center>
                                    <h3>Login</h3>
                                </center>");
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <center>
                                    <hr />
                                </center>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <label>Username:</label>
                                <div class=""form-group"">
                                    <!--<asp:TextBox class=""form-control"" ID=""TextBox1"" placeholder=""Username"" runat=""server""></asp:TextBox>-->
                                    ");
#nullable restore
#line 41 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Login.cshtml"
                               Write(Html.TextBoxFor(m => m.Username, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 42 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Login.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Username, null, new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <label>Password:</label>\r\n                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 46 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Login.cshtml"
                               Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 47 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Login.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Password, null, new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                ");
#nullable restore
#line 49 "D:\Shared_Traveling\Shared_Traveling\Shared_Traveling\Views\Home\Login.cshtml"
                           Write(Html.ValidationMessage("AuthenticationFailed", null, new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <div class=""form-group"">
                                    <input class=""btn btn-primary btn-block btn-lg"" type=""submit"" name=""Login"" value=""Login"" />
                                </div>
                                <div class=""form-group"">
                                    <a href=""/Home/SignUp"">
                                        <input class=""btn btn-primary btn-block btn-lg"" id=""Button2"" type=""button"" value=""Sign Up"" />
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <a class=""button"" href=""/Home/Index"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb048114417c4a32f4e2c9f3e5ad207a7c4fe1ea8062", async() => {
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
                </a>
                <br /><br />
            </div>
        </div>
    </form>
    <script>
        window.
            onload
            = function () {
                Particles.
                    init
                    ({
                        selector:
                            '.background'
                    });
            };
        var particles = Particles.init({
            selector: '.background',
            color: ['#DA0463', '#404B69', '#DBEDF3'],
            connectParticles: true
        });
    </script>

</div>
<canvas class=""background""></canvas>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shared_Traveling.ViewModels.Home.LoginVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
