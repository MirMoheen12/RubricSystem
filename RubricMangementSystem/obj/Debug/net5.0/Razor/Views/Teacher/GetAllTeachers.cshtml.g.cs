#pragma checksum "F:\RubricSyst\RubricSyst\RubricMangementSystem\Views\Teacher\GetAllTeachers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df9126580a02833d2cda61730c096bd826fa2f3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_GetAllTeachers), @"mvc.1.0.view", @"/Views/Teacher/GetAllTeachers.cshtml")]
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
#line 1 "F:\RubricSyst\RubricSyst\RubricMangementSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\RubricSyst\RubricSyst\RubricMangementSystem\Views\_ViewImports.cshtml"
using RubricMangementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\RubricSyst\RubricSyst\RubricMangementSystem\Views\_ViewImports.cshtml"
using RubricMangementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df9126580a02833d2cda61730c096bd826fa2f3a", @"/Views/Teacher/GetAllTeachers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"991d2c75fc5531d6b401dee52ec2a7dfccc46d37", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_GetAllTeachers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RubricsystemModel.Model.Teacher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePaper", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\RubricSyst\RubricSyst\RubricMangementSystem\Views\Teacher\GetAllTeachers.cshtml"
  
    ViewData["Title"] = "GetAllTeachers";
    Layout = "~/Views/Shared/_TeacherTheme.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""nk-content "">
    <div class=""container-fluid"">
        <div class=""nk-content-inner"">
            <div class=""nk-content-body"">
                <div class=""components-preview wide-md mx-auto"">
                    <div class=""nk-block nk-block-lg"">

                        <div class=""card card-preview"">
                            <div class=""card-inner"">
                                <table class=""datatable-init table"">
                                    <thead>
                                        <tr>
                                            <th>
                                                Name
                                            </th>

                                            <th>
                                                Department
                                            </th>
                                            <th>
                                                Class
                                            </th>
   ");
            WriteLiteral(@"                                         <th>
                                                Section
                                            </th>
                                            <th>
                                                Actions
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 41 "F:\RubricSyst\RubricSyst\RubricMangementSystem\Views\Teacher\GetAllTeachers.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 45 "F:\RubricSyst\RubricSyst\RubricMangementSystem\Views\Teacher\GetAllTeachers.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 49 "F:\RubricSyst\RubricSyst\RubricMangementSystem\Views\Teacher\GetAllTeachers.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 52 "F:\RubricSyst\RubricSyst\RubricMangementSystem\Views\Teacher\GetAllTeachers.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Class));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 56 "F:\RubricSyst\RubricSyst\RubricMangementSystem\Views\Teacher\GetAllTeachers.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Section));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n\r\n\r\n                                                <td>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df9126580a02833d2cda61730c096bd826fa2f3a7810", async() => {
                WriteLiteral("Create Paper");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "F:\RubricSyst\RubricSyst\RubricMangementSystem\Views\Teacher\GetAllTeachers.cshtml"
                                                                                  WriteLiteral(item.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 67 "F:\RubricSyst\RubricSyst\RubricMangementSystem\Views\Teacher\GetAllTeachers.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div><!-- .card-preview -->
                    </div> <!-- nk-block -->
                    <!-- nk-block -->

                </div><!-- .components-preview -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RubricsystemModel.Model.Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591