using System.Linq;

namespace store_tests.PageObjects
{
    public class Main : BaseSection
    {
        private const string Css = "main.content-wrapper";

        public Main(string css = Css) : base(css)
        {
        }

        public int NumberOfComments => Scope.FindAllCss("div.container blockquote").Count();
        public string QuoteText => Scope.FindCss(".site-content q").Text;

        public string LastComment => Scope.FindCss("div.container blockquote:last-child p").Text;
        public string LastCommentAuthor => Scope.FindCss("div.container blockquote:last-child cite").Text;

        public void ClickFeedbackLink(string link)
        {
            Scope.FindXPath($"//p[@class='thank'][.='{link}']").Click();
        }

        public void ClickButton(string button)
        {
            Scope.FindXPath($"//input[@value='{button}']").Click();
        }

        public void FillInName(string name)
        {
            Scope.FindCss("input#Name").FillInWith(name);
        }

        public void FillInEmail(string email)
        {
            Scope.FindCss("input#Email").FillInWith(email);
        }

        public void FillInComment(string comment)
        {
            Scope.FindCss("input#Comment").FillInWith(comment);
        }

        public void LeaveComment(string name, string email, string comment)
        {
            Scope.FindCss("input#Name").FillInWith(name);
            Scope.FindCss("input#Email").FillInWith(email);
            Scope.FindCss("input#Comment").FillInWith(comment);
        }

        public string ErrorMessage(string field)
        {
            return Scope
                .FindXPath($"//span[contains(@class,'text-danger')]/span[@for='{field}']").Text;
        }
    }
}