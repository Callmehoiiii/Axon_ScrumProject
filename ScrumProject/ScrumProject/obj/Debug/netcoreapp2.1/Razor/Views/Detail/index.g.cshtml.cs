#pragma checksum "C:\Users\Phong Linh\Desktop\ScrumProject\ScrumProject\Views\Detail\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bec40aa91eab4f0b76e77dc1d7853f57ed26502"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Detail_index), @"mvc.1.0.view", @"/Views/Detail/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Detail/index.cshtml", typeof(AspNetCore.Views_Detail_index))]
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
#line 1 "C:\Users\Phong Linh\Desktop\ScrumProject\ScrumProject\Views\_ViewImports.cshtml"
using ScrumProject;

#line default
#line hidden
#line 2 "C:\Users\Phong Linh\Desktop\ScrumProject\ScrumProject\Views\_ViewImports.cshtml"
using ScrumProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bec40aa91eab4f0b76e77dc1d7853f57ed26502", @"/Views/Detail/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7e9e2dc6b73540410acf4262e8a87fefde5b282", @"/Views/_ViewImports.cshtml")]
    public class Views_Detail_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ScrumProject.Models.House>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand js-scroll-trigger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Homepage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Phong Linh\Desktop\ScrumProject\ScrumProject\Views\Detail\index.cshtml"
  

Layout = null;


#line default
#line hidden
            BeginContext(67, 57, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    <!DOCTYPE html>\r\n    <html lang=\"en\">\r\n\r\n    ");
            EndContext();
            BeginContext(124, 1236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e80006521ea4184b68193a42bc2c9cd", async() => {
                BeginContext(130, 1223, true);
                WriteLiteral(@"

        <meta charset=""utf-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
        <meta name=""description"" content="""">
        <meta name=""author"" content="""">

        <title>Agency - Start Bootstrap Theme</title>

        <!-- Bootstrap core CSS -->
        <link href=""vendor/bootstrap/css/bootstrap.css"" rel=""stylesheet"">

        <!-- Custom fonts for this template -->
        <link href=""vendor/fontawesome-free/css/all.css"" rel=""stylesheet"" type=""text/css"">
        <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,700"" rel=""stylesheet"" type=""text/css"">
        <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css'>
        <link href='https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic' rel='stylesheet'
            type='text/css'>
        <link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700' rel='stylesheet'
         ");
                WriteLiteral("   type=\'text/css\'>\r\n\r\n        <!-- Custom styles for this template -->\r\n        <link href=\"css/agency.css\" rel=\"stylesheet\">\r\n        <link href=\"css/font-awesome.min.css\" rel=\"stylesheet\">\r\n\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(1360, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(1368, 8484, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df49bc0e217d479aa712145561f2362b", async() => {
                BeginContext(1388, 168, true);
                WriteLiteral("\r\n\r\n        <!-- Navigation -->\r\n        <nav class=\"navbar navbar-expand-lg navbar-dark fixed-top\" id=\"mainNav\">\r\n            <div class=\"container\">\r\n                ");
                EndContext();
                BeginContext(1556, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "636a37bd8c604e28ac618ad1c7c7e59c", async() => {
                    BeginContext(1624, 20, true);
                    WriteLiteral("Student Accomodation");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1648, 1318, true);
                WriteLiteral(@"
                <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse""
                    data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false""
                    aria-label=""Toggle navigation"">
                    Menu
                    <i class=""fas fa-bars""></i>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                    <ul class=""navbar-nav text-uppercase ml-auto"">
                        <li class=""nav-item"">
                            <a class=""nav-link js-scroll-trigger"" href=""#"">Trang chủ</a>
                        </li>

                        <li class=""nav-item"">
                            <a class=""nav-link js-scroll-trigger"" href=""#about"">Về chúng tôi</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link js-scroll-trigger"" href=""#team"">Đội ngũ</a>
                      ");
                WriteLiteral(@"  </li>
                        <li class=""nav-item"">
                            <a class=""nav-link js-scroll-trigger"" href=""#contact"">Liên hệ</a>
                        </li>

                    </ul>

                </div>

            </div>
            <div>
                ");
                EndContext();
                BeginContext(2966, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b8ac9f3799c466fbd98b5cd0446df86", async() => {
                    BeginContext(3030, 9, true);
                    WriteLiteral("Đăng nhập");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3043, 6802, true);
                WriteLiteral(@"
            </div>
        </nav>

        <section>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-8"">
                        <div class=""text-center"">
                            <img src=""./img/houses/10.jpg"" class=""rounded detailHouse"">
                        </div>
                    </div>

                    <div class=""col-4 info-House"">
                        <div class=""row"">

                        </div>
                        <h4><i class=""fa fa-user""></i> Nguyễn Văn A</h4>
                        <p class=""inf-footer""> 12 Vo Van Ngan, Thu Duc </p>
                        <hr>
                        </hr>
                        <div class=""btn btn-primary"" id=""phoneShow"">Xem số điện thoại</div>
                        <h3 class=""phone "" id=""phones"">0353030643</h3>
                        <br><br><br><br><br><br><br>

                        <img src=""./img/caution.png"" class=""rounded"" style=""width: 100%;");
                WriteLiteral(@" height: 60px;"">

                    </div>


                </div>

                <div class=""row"">
                    <div class=""col-8"">
                        <br>
                        <h3>Nhà cho thuê 12 Vo Van Ngan, Thu Duc</h3>
                        <div class=""card-text-price"">
                            2.000.000 đ
                        </div>
                        <div class=""inf-footer"">8 x 4 m</div>
                        <br>
                        <p class=""description"">
                            Cần xoay vốn làm ăn nên tôi muốn bán căn nhà 1 trệt 1 lầu vừa mới xây xong trên đường Đinh
                            Đức Thiện cách chợ Bình Chánh 3km
                            -nhà nằm khu dân cư đông đúc, an ninh, có vỉa hè cây xanh thoáng mát
                            Đường trước nhà 10m, ko ngập nước, nhà có 4 phòng ngủ 3 wc sân trước sân sau, phòng khách
                            phòng bếp
                            - chỉ cần thanh toán trước cho t");
                WriteLiteral(@"ôi 900 triệu nhận nhà ở, phần còn lại tôi cho trả chậm
                            Sổ hồng riêng bao sang tên công chứng ngay
                        </p>
                        <br>
                        <div class=""row"">
                            <div class=""col-6"">
                                <i class=""fa fa-map"" aria-hidden=""true"" style=""margin-right: 1em;""></i>Diện tích: 8m x
                                8m
                            </div>
                            <div class=""col-6"">
                                <i class=""fa fa-toilet-paper"" aria-hidden=""true"" style=""margin-right: 1em;""></i>Số nhà vệ sinh: 2
                            </div>
                        </div>
                        <br>
                        <div class=""row"">
                            <div class=""col-6"">
                                <i class=""fa fa-wind"" aria-hidden=""true"" style=""margin-right: 1em;""></i>Máy lạnh: Có
                            </div>
                            ");
                WriteLiteral(@"<div class=""col-6"">
                                <i class=""fa fa-home"" aria-hidden=""true"" style=""margin-right: 1em;""></i>Loại căn hộ: Nhà
                            </div>
                        </div>
                        <br>
                        <div class=""row"">
                            <div class=""col-6"">
                                <i class=""fa fa-scroll"" aria-hidden=""true"" style=""margin-right: 1em;""></i>Giấy tờ pháp lý: Đã có sổ đỏ/sổ hồng
                            </div>
                            <div class=""col-6"">
                                <i class=""fa fa-key"" aria-hidden=""true"" style=""margin-right: 1em;""></i>Số phòng ngủ: 4 phòng
                            </div>
                        </div>
                        

                    </div>
                </div>
                <br>
                <div class=""row"">
                    <div class=""col-8"">
                        <div class=""inf-footer"">
                           <i class=""fa ");
                WriteLiteral(@"fa-map-marker-alt"" style=""margin-right: 1em;""></i>Địa chỉ: 12 Vo Van Ngan, Thu Duc
                        </div>
                    </div>
                </div>
            </div>
        </section>



        <!-- Footer -->
        <footer>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <span class=""copyright"">Copyright &copy; CL-Five Team 2019</span>
                    </div>
                    <div class=""col-md-4"">
                        <ul class=""list-inline social-buttons"">
                            <li class=""list-inline-item"">
                                <a href=""#"" class=""linkSocialFooter"" style=""display:flex"">
                                    <i class=""fab fa-twitter""></i>
                                </a>
                            </li>
                            <li class=""list-inline-item"">
                                <a href=""#"" class=""linkSocialFooter"" sty");
                WriteLiteral(@"le=""display:flex"">
                                    <i class=""fab fa-facebook-f""></i>
                                </a>
                            </li>
                            <li class=""list-inline-item"">
                                <a href=""#"" class=""linkSocialFooter"" style=""display:flex"">
                                    <i class=""fab fa-linkedin-in""></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                    <div class=""col-md-4"">
                        <ul class=""list-inline quicklinks"">
                            <li class=""list-inline-item"">
                                <a href=""#"">Privacy Policy</a>
                            </li>
                            <li class=""list-inline-item"">
                                <a href=""#"">Terms of Use</a>
                            </li>
                        </ul>
                    </div>
                </div>
   ");
                WriteLiteral(@"         </div>
        </footer>




        <!-- Bootstrap core JavaScript -->
        <script src=""vendor/jquery/jquery.min.js""></script>
        <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

        <!-- Plugin JavaScript -->
        <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>

        <!-- Contact form JavaScript -->
        <script src=""js/jqBootstrapValidation.js""></script>
        <script src=""js/contact_me.js""></script>

        <!-- Custom scripts for this template -->
        <script src=""js/agency.js""></script>
        <script src=""js/sweetalert2.all.min.js""></script>

    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9852, 15, true);
            WriteLiteral("\r\n\r\n    </html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ScrumProject.Models.House>> Html { get; private set; }
    }
}
#pragma warning restore 1591
