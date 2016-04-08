using HandlebarsDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.Email.Provider
{
    public static class EmailTemplateRender
    {
        public static string Compile<T>(string html, T data) where T : new()
        {
            var compiledHtml = Handlebars.Compile(html);
            return compiledHtml(data);
        }
    }
}
