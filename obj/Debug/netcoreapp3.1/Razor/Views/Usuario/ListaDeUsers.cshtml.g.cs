#pragma checksum "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\Usuario\ListaDeUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "706b9d8bd49560a74a11898a4dd721dc2daec93b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListaDeUsers), @"mvc.1.0.view", @"/Views/Usuario/ListaDeUsers.cshtml")]
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
#line 1 "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"706b9d8bd49560a74a11898a4dd721dc2daec93b", @"/Views/Usuario/ListaDeUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListaDeUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Usuário Cadastrados no Sistema</h1>\r\n\r\n<p class=\"text-danger\">");
#nullable restore
#line 5 "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\Usuario\ListaDeUsers.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr class=\"col-md-12\">\r\n            <th scope=\"row\">Nome</th>\r\n            <th scope=\"row\">Login</th>\r\n            <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\Usuario\ListaDeUsers.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\Usuario\ListaDeUsers.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\Usuario\ListaDeUsers.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\Usuario\ListaDeUsers.cshtml"
                 if(u.Tipo==Usuario.ADMIN)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 25 "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\Usuario\ListaDeUsers.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padrão</td>\r\n");
#nullable restore
#line 29 "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\Usuario\ListaDeUsers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 733, "\"", 759, 2);
            WriteAttributeValue("", 740, "editarUser?id=", 740, 14, true);
#nullable restore
#line 31 "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\Usuario\ListaDeUsers.cshtml"
WriteAttributeValue("", 754, u.Id, 754, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 800, "\"", 827, 2);
            WriteAttributeValue("", 807, "ExcluirUser?id=", 807, 15, true);
#nullable restore
#line 32 "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\Usuario\ListaDeUsers.cshtml"
WriteAttributeValue("", 822, u.Id, 822, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\LesteOFF (Eduardo)\Desktop\Bliblioteca\Biblioteca\Views\Usuario\ListaDeUsers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<a href=\"RegistrarUser\">Registar Novo Usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
