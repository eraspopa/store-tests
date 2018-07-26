using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coypu;

namespace store_tests.PageObjects
{
    public class Header:BaseSection
    {
        public Header(string css= "div.header") : base(css)
        {
            
        }

        public void ClickHeaderLink(string link) => Scope
            .FindXPath($"//a[i[contains(@class, 'fa-{link}')]]").Click();

    }
}
