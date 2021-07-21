#pragma checksum "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a94947ee4d7e8ee48438a507e85221345ae503e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_ProjectTasks), @"mvc.1.0.view", @"/Views/Task/ProjectTasks.cshtml")]
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
#line 1 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\_ViewImports.cshtml"
using ProjectWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\_ViewImports.cshtml"
using ProjectWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a94947ee4d7e8ee48438a507e85221345ae503e", @"/Views/Task/ProjectTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771972434ccc2479eca7aebeef0a6a25a5d7fa00", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_ProjectTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectWebApp.Models.Task>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
  
	ViewData["Title"] = "ProjectTasks";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!doctype html>\r\n<html lang=\"en\">\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a94947ee4d7e8ee48438a507e85221345ae503e4657", async() => {
                WriteLiteral(@"
	<meta charset=""utf-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">

	<link rel=""stylesheet"" href=""//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">
	<link rel=""stylesheet"" href=""/resources/demos/style.css"">

	<style>
		#sortable1, #sortable2, #sortable3 {
			border: 1px solid #eee;
			width: 340px;
			min-height: 40px;
			list-style-type: none;
			margin: 0;
			padding: 5px 0 0 0;
			float: left;
			margin-right: 10px;
		}

			#sortable1 li, #sortable2 li, #sortable3 li {
				margin: 0 5px 5px 5px;
				padding: 5px;
				font-size: 2.5em;
				width: 330px;
				color: dodgerblue;
			}


			* {
			margin: 0;
			padding: 0;
			box-sizing: border-box;    
		  }
		  .container {
			  max-width: 1200px;
			  min-width: 650px;
			  margin: 0 auto;
			  padding: 50px;      
		  }
 
		  .chart {
			  display: grid;
			  border: 2px solid #000;
			  position: relative;
			  overflow: hidden;  
		  }
		  .chart-row {
			display: grid;      ");
                WriteLiteral(@"
			  grid-template-columns: 50px 1fr;
			  
		  }

		  .chart-period {
			
			background-color:  #708090 !important;
			border-bottom: 2px solid #000; 
			grid-template-columns: 50px repeat(12, 1fr);
		  }
		  .chart-lines {
			position: absolute;
			height: 100%;
			width: 100%;
			background-color: transparent;
			grid-template-columns: 50px repeat(12, 1fr);
		  }
		  .chart-period > span {    
			text-align: center;
				font-size: 13px;
				align-self: center;
				font-weight: bold;
			padding: 15px 0;    
		  }
		  .chart-lines > span {
			display: block;
			border-right: 1px solid rgba(0, 0, 0, 0.3);
		  }
 
		  .chart-row-item {
			
			border: 1px solid  #000;
			border-top: 0;
			border-left: 0;      
			padding: 20px 0;
			font-size: 15px;
			font-weight: bold;
			text-align: center;
		  } 

		  .chart-row-bars {
			list-style: none;
				display: grid;
				padding: 15px 0;
				margin: 0;
				grid-template-columns: repeat(12, 1fr);
				grid-gap: 10px 0;
	");
                WriteLiteral(@"			border-bottom: 1px solid  #000;
		  }
		  li {
			font-weight: 450;
				text-align: left;
				font-size: 15px;
				min-height: 15px;
				
				padding: 5px 15px;
				color: #fff;
				overflow: hidden;
				position: relative;
				cursor: pointer;
				border-radius: 15px;
		  }
		  ul .chart-li-one {
			grid-column: 1/2; 
			background-color:#588BAE;
		  }
		  ul .chart-li-two-a {
			grid-column: 2/2; 
			background-color: #0080FF;
		  }
		  ul .chart-li-two-b {
			grid-column: 2/4; 
			background-color:#4682B4;
		  } 
		  ul .chart-li-three {
			grid-column: 3/5; 
			background-color:#57A0D3;
		  }
		  ul .chart-li-four {
			grid-column: 3/9; 
			background-color:#0E4D92;
		  }
		  ul .chart-li-five {
			grid-column: 7/10; 
			background-color:#4F97A3;
		  }
		  ul .chart-li-six {
			grid-column: 10/12; 
			background-color:#73C2FB;
		  }
		  ul .chart-li-seven {
			grid-column: 12/12; 
			background-color:#0080FF;
		  }



	</style>

");
                DefineSection("Scripts", async() => {
                    WriteLiteral(@"

		<script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
		<script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
		<script>
			$(function () {

				$(""#sortable1, #sortable2, #sortable3"").sortable({
					connectWith: "".connectedSortable""

				}).disableSelection();
			});
		</script>

		<script>
			$(function () {
				$(""#sortable1, #sortable2, #sortable3"").sortable({
					items: ""li:not(.ui-state-disabled)""
				});
				$(""#sortable1 li, #sortable2 li, #sortable3 li"").disableSelection();
			});
		</script>



	");
                }
                );
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
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a94947ee4d7e8ee48438a507e85221345ae503e9482", async() => {
                WriteLiteral("\r\n\t<h1>KANBAN BOARD</h1>\r\n\r\n\t<p>\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a94947ee4d7e8ee48438a507e85221345ae503e9784", async() => {
                    WriteLiteral("Create New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t</p>\r\n\r\n\r\n\t<ul id=\"sortable1\" class=\"connectedSortable\">\r\n\r\n\t\t<li class=\"ui-state-default ui-state-disabled\"> TO DO </li>\r\n\r\n\r\n");
#nullable restore
#line 202 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
         foreach (var item in Model.Where(i => i.todo))
		{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<li class=\"ui-state-default\">\r\n\t\t\t\t");
#nullable restore
#line 205 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t</li>\r\n");
#nullable restore
#line 207 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"

		}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t</ul>\r\n\r\n\r\n\t<ul id=\"sortable2\" class=\"connectedSortable\">\r\n\t\t<li class=\"ui-state-default ui-state-disabled\"> IN PROCESS </li>\r\n\r\n");
#nullable restore
#line 216 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
         foreach (var item in Model.Where(i => i.process))
		{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<li class=\"ui-state-default\">\r\n\t\t\t\t");
#nullable restore
#line 219 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t</li>\r\n");
#nullable restore
#line 221 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
		}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t</ul>\r\n\r\n\r\n\r\n\t<ul id=\"sortable3\" class=\"connectedSortable\">\r\n\t\t<li class=\"ui-state-default ui-state-disabled\"> DONE </li>\r\n\r\n");
#nullable restore
#line 229 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
         foreach (var item in Model.Where(i => i.done))
		{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<li class=\"ui-state-default\">\r\n\t\t\t\t");
#nullable restore
#line 232 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t</li>\r\n");
#nullable restore
#line 234 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
		}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t</ul>\r\n\r\n\r\n\r\n\t<table class=\"table\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 244 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 247 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
               Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 250 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
               Write(Html.DisplayNameFor(model => model.todo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 253 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
               Write(Html.DisplayNameFor(model => model.process));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 256 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
               Write(Html.DisplayNameFor(model => model.done));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th></th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
#nullable restore
#line 262 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
             foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 266 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 269 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Project.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 272 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
                   Write(Html.DisplayFor(modelItem => item.todo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 275 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
                   Write(Html.DisplayFor(modelItem => item.process));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 278 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
                   Write(Html.DisplayFor(modelItem => item.done));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a94947ee4d7e8ee48438a507e85221345ae503e17545", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 281 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
                                               WriteLiteral(item.Id);

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
                WriteLiteral(" |\r\n\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a94947ee4d7e8ee48438a507e85221345ae503e19818", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 282 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
                                                 WriteLiteral(item.Id);

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
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 285 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Task\ProjectTasks.cshtml"
			}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"		</tbody>
	</table>

	<div class=""container"">
		<div class=""chart"">
			<div class=""chart-row chart-period"">
				<div class=""chart-row-item""></div>
				<span>January</span><span>February</span><span>March</span>
				<span>April</span><span>May</span><span>June</span>
				<span>July</span><span>August</span><span>September</span>
				<span>October</span><span>November</span><span>December</span>
			</div>
			<div class=""chart-row chart-lines"">
				<span></span><span></span><span></span>
				<span></span><span></span><span></span>
				<span></span><span></span><span></span>
				<span></span><span></span><span></span>
			</div>
			<div class=""chart-row"">
				<div class=""chart-row-item"">1</div>
				<ul class=""chart-row-bars"">
					<li class=""chart-li-one"">Planning</li>
				</ul>
			</div>
			<div class=""chart-row"">
				<div class=""chart-row-item"">2</div>
				<ul class=""chart-row-bars"">
					<li class=""chart-li-two-a"">Design of materials</li>
					<li class=""chart-li-two-b"">Analysis of ");
                WriteLiteral(@"CR strategy</li>
				</ul>
			</div>
			<div class=""chart-row"">
				<div class=""chart-row-item"">3</div>
				<ul class=""chart-row-bars"">
					<li class=""chart-li-three"">HR teambuildings</li>
				</ul>
			</div>
			<div class=""chart-row"">
				<div class=""chart-row-item"">4</div>
				<ul class=""chart-row-bars"">
					<li class=""chart-li-four"">Knowedge Transfer</li>
				</ul>
			</div>
			<div class=""chart-row"">
				<div class=""chart-row-item"">5</div>
				<ul class=""chart-row-bars"">
					<li class=""chart-li-five"">Meetup with participants</li>
				</ul>
			</div>
			<div class=""chart-row"">
				<div class=""chart-row-item"">6</div>
				<ul class=""chart-row-bars"">
					<li class=""chart-li-six"">Final preparation</li>
				</ul>
			</div>
			<div class=""chart-row"">
				<div class=""chart-row-item"">7</div>
				<ul class=""chart-row-bars"">
					<li class=""chart-li-seven"">Event</li>
				</ul>
			</div>

		</div>

	</div>



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectWebApp.Models.Task>> Html { get; private set; }
    }
}
#pragma warning restore 1591
