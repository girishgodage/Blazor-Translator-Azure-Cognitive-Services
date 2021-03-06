#pragma checksum "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca28cbac580dc01abcb6d4f95f9518416b184b62"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTranslator.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\_Imports.razor"
using BlazorTranslator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\_Imports.razor"
using BlazorTranslator.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
using BlazorTranslator.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
using BlazorTranslator.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/translator")]
    public partial class Translator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Multilanguage translator using Microsoft Translator API Cognitive Service</h3>\r\n<hr>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-6");
            __builder.OpenElement(7, "select");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                                                inputLanguage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputLanguage = __value, inputLanguage));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", true);
            __builder.AddContent(13, "-- Select input language --");
            __builder.CloseElement();
#nullable restore
#line 13 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                 foreach (KeyValuePair
                <string, LanguageDetails>
                    lang in LanguageList)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "option");
            __builder.AddAttribute(15, "value", 
#nullable restore
#line 17 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                                    lang.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, 
#nullable restore
#line 17 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                                               lang.Value.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "textarea");
            __builder.AddAttribute(19, "placeholder", "Enter text to translate");
            __builder.AddAttribute(20, "class", "form-control translation-box");
            __builder.AddAttribute(21, "rows", "5");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                                                                                                                  inputText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputText = __value, inputText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-md-6");
            __builder.OpenElement(27, "select");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                                                    SelectLanguage

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", true);
            __builder.AddContent(32, "-- Select target language --");
            __builder.CloseElement();
#nullable restore
#line 25 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                 foreach (KeyValuePair
                <string, LanguageDetails>
                    lang in LanguageList)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", 
#nullable restore
#line 29 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                                    lang.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, 
#nullable restore
#line 29 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                                               lang.Value.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 30 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "textarea");
            __builder.AddAttribute(38, "disabled", true);
            __builder.AddAttribute(39, "class", "form-control translation-box");
            __builder.AddAttribute(40, "rows", "5");
            __builder.AddContent(41, 
#nullable restore
#line 32 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                                                                              outputText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "text-center");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "class", "btn btn-primary btn-lg");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
                                                         Translate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Translate");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\DotnetProjects\BlazorTranslator\BlazorTranslator\Pages\Translator.razor"
       
        private TranslationResult[] translations;
        private AvailableLanguage availableLanguages;
        private string outputLanguage { get; set; }
        private string inputLanguage { get; set; }
        string inputText { get; set; }
        string outputText { get; set; }
        private Dictionary<string, LanguageDetails>
        LanguageList = new Dictionary<string, LanguageDetails>();

        protected override async Task OnInitializedAsync()
        {
            availableLanguages = await translationService.GetAvailableLanguages();
            LanguageList = availableLanguages.Translation;
        }
        private void SelectLanguage(ChangeEventArgs langEvent)
        {
            this.outputLanguage = langEvent.Value.ToString();
        }
        private async Task Translate()
        {
            if (!string.IsNullOrEmpty(outputLanguage))
            {
                translations = await translationService.GetTranslatation(this.inputText, this.outputLanguage);
                outputText = translations[0].Translations[0].Text;
                inputLanguage = translations[0].DetectedLanguage.Language;
            }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TranslationService translationService { get; set; }
    }
}
#pragma warning restore 1591
