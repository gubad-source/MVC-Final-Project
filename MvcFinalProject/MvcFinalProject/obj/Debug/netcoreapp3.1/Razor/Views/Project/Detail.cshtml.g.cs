#pragma checksum "C:\Users\qubad\Desktop\MVC-Final-Project\MvcFinalProject\MvcFinalProject\Views\Project\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30a95ce40f894f319f56a051adf4aee306b67157"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Detail), @"mvc.1.0.view", @"/Views/Project/Detail.cshtml")]
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
#line 1 "C:\Users\qubad\Desktop\MVC-Final-Project\MvcFinalProject\MvcFinalProject\Views\_ViewImports.cshtml"
using MvcFinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\qubad\Desktop\MVC-Final-Project\MvcFinalProject\MvcFinalProject\Views\_ViewImports.cshtml"
using MvcFinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a95ce40f894f319f56a051adf4aee306b67157", @"/Views/Project/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f9c9683c7b6099ad856e908e31edd77f1908840", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Hero", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/hero-bg7.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("project"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded shadow-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\qubad\Desktop\MVC-Final-Project\MvcFinalProject\MvcFinalProject\Views\Project\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30a95ce40f894f319f56a051adf4aee306b671574925", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!--project details section start-->
<section class=""project-details-section ptb-100"">
    <div class=""container"">
        <div class=""row justify-content-between"">
            <div class=""col-md-12 col-lg-8"">
                <div class=""img-wrap mb-md-4 mb-lg-0"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30a95ce40f894f319f56a051adf4aee306b671576341", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-md-12 col-lg-4"">
                <!--all services list-->
                <aside class=""widget widget-categories"">
                    <div class=""widget-title"">
                        <h5>All Services</h5>
                    </div>
                    <ul class=""all-service-list"">
                        <li><a href=""#"">Financial Services Consulting</a></li>
                        <li><a href=""#"">Consumer Product Consulting</a></li>
                        <li><a href=""#"">Global Consumer insights</a></li>
                        <li><a href=""#"">Independent contractor</a></li>
                        <li><a href=""#"">Creative Idea Development</a></li>
                        <li><a href=""#"">Social Media Marketing</a></li>
                    </ul>
                </aside>
            </div>
        </div>

        <!--project details row start-->
        <div class=""row mt-5"">
            <div class=""col-md-12"">
 ");
            WriteLiteral(@"               <div class=""project-details-content"">
                    <h5>Project Description</h5>
                    <p>
                        Synergistically syndicate frictionless architectures via global e-services. Assertively
                        pontificate adaptive e-tailers rather than cross-unit results. Assertively engineer top-line
                        portals through one-to-one growth strategies. Efficiently.
                    </p>
                    <p>
                        Proactively reinvent standards compliant applications before timely ROI. Uniquely negotiate
                        installed base results rather than resource-leveling e-markets. Continually plagiarize
                        magnetic technologies vis-a-vis synergistic infomediaries. Globally communicate progressive
                        users without resource maximizing growth strategies. Objectively evolve enterprise.
                    </p>
                    <p>Collaboratively conceptua");
            WriteLiteral(@"lize flexible best practices via cooperative methodologies. Assertively negotiate an expanded array of alignments with 24/365 ""outside the box"" thinking. Assertively enable fully researched vortals rather than alternative niche markets.</p>
                </div>
            </div>
        </div>
        <div class=""row mt-5"">
            <div class=""col-md-6"">
                <div class=""project-details-feature"">
                    <ul class=""list-unstyled tech-feature-list"">
                        <li class=""py-1"">
                            <span class=""ti-check-box mr-2 color-secondary""></span><strong>Foreclosure</strong>
                            consultant Human resource consulting
                        </li>
                        <li class=""py-1"">
                            <span class=""ti-check-box mr-2 color-secondary""></span><strong>Corporate</strong>
                            Immigration consultant, Information consulting
                        </li>
                   ");
            WriteLiteral(@"     <li class=""py-1""><span class=""ti-check-box mr-2 color-secondary""></span><strong>SEO</strong> Optimization Creative consultant</li>
                        <li class=""py-1""><span class=""ti-check-box mr-2 color-secondary""></span><strong>Rapidiously</strong> conceptualize strategic before communities</li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""project-details-feature"">
                    <ul class=""list-unstyled tech-feature-list"">
                        <li class=""py-1"">
                            <span class=""ti-check-box mr-2 color-secondary""></span><strong>Consultant</strong>
                            pharmacist Creative consultant
                        </li>
                        <li class=""py-1"">
                            <span class=""ti-check-box mr-2 color-secondary""></span><strong>Monotonectally</strong>
                            customize B2B core competencies
                   ");
            WriteLiteral(@"     </li>
                        <li class=""py-1""><span class=""ti-check-box mr-2 color-secondary""></span><strong>Immigration</strong> consultant, Information consulting</li>
                        <li class=""py-1""><span class=""ti-check-box mr-2 color-secondary""></span><strong>Consultant</strong> pharmacist Creative consultant</li>
                    </ul>
                </div>
            </div>
        </div>
        <!--project details row end-->
    </div>
</section>
<!--project details section end-->
<!--call to action section start-->
<section class=""call-to-action py-5 gray-light-bg"">
    <div class=""container"">
        <div class=""row justify-content-around align-items-center"">
            <div class=""col-md-7"">
                <div class=""subscribe-content"">
                    <h3 class=""mb-1"">Consulting Agency for Your Business</h3>
                    <p>Rapidiously engage fully tested e-commerce with progressive architectures.</p>
                </div>
            </div>
            WriteLiteral(@"
            <div class=""col-md-4"">
                <div class=""action-btn text-lg-right text-sm-left"">
                    <a href=""#"" class=""btn secondary-solid-btn"">Become a Client</a>
                </div>
            </div>
        </div>
    </div>
</section>
<!--call to action section end-->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591