#pragma checksum "C:\Users\er\Desktop\MVC\CoreDemo\CoreDemo\Views\Shared\Partial3.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1a998f0090c1c5493bfcf3d1587f75522ec4e0876adc42a59fe8c3098c676d48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial3), @"mvc.1.0.view", @"/Views/Shared/Partial3.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\er\Desktop\MVC\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\er\Desktop\MVC\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1a998f0090c1c5493bfcf3d1587f75522ec4e0876adc42a59fe8c3098c676d48", @"/Views/Shared/Partial3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Partial3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <!--footer-->
<footer>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">
                <h3>Hakkımızda</h3>
                <p style=""text-align:justify;"">Merhaba, ben Yunus Emre Turhan. Web tasarım ve kodlama alanında full-stack developer olarak çalışıyorum. Hem arka uç (back-end) hem de ön yüz (front-end) geliştirme becerilerimle, web uygulamaları ve dinamik siteler oluşturmaktan büyük keyif alıyorum. Teknolojiye olan ilgim, kendimi sürekli güncel tutmam ve yenilikleri yakından takip etmem sayesinde, her geçen gün daha da donanımlı hale geliyorum....</p>
                <div class=""read"">
                    <a href=""/About/Index/"" class=""btn btn-primary read-m"">Daha Fazla</a>
                </div>
            </div>
            <div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">

               ");
            Write(
#nullable restore
#line 14 "C:\Users\er\Desktop\MVC\CoreDemo\CoreDemo\Views\Shared\Partial3.cshtml"
                await Component.InvokeAsync("BlogLast3Post")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </div>\r\n            ");
            Write(
#nullable restore
#line 16 "C:\Users\er\Desktop\MVC\CoreDemo\CoreDemo\Views\Shared\Partial3.cshtml"
             await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"
          
            </div>
        </div>
        <!-- footer -->
        <div class=""footer-cpy text-center"">
            <div class=""footer-social"">
                <div class=""copyrighttop"">
                    <ul>
                        <li class=""mx-3"">
                            <a class=""linkedin"" href=""https://www.linkedin.com/in/yunus-emre-turhan-57619525b/"">
                                <i class=""fab fa-linkedin""></i>
                                <span>Linked In</span>
                            </a>
                        </li>

                        <li class=""mx-3"">
                      
                        </li>
                        <li>
                            <a class=""linkedin"" href=""#"">
                                <i class=""fab fa-instagram""></i>
                                <span>INSTAGRAM</span>
                            </a>
                        </li>
                    </ul>

                </div>
            </div>
");
            WriteLiteral("            <div class=\"w3layouts-agile-copyrightbottom\">\r\n                <p>\r\n                    © ");
            Write(
#nullable restore
#line 47 "C:\Users\er\Desktop\MVC\CoreDemo\CoreDemo\Views\Shared\Partial3.cshtml"
                       DateTime.Now.Year

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" Tüm Hakları Saklıdır | Tasarlayan\r\n                    <a href=\"https://www.learnhist.com.tr/info\">Yetis</a>\r\n                </p>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <!-- //footer -->\r\n\r\n\r\n    </div>\r\n</footer>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
