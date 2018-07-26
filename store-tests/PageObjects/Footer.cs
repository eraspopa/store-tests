namespace store_tests.PageObjects
{
    public class Footer : BaseSection
    {
        public Footer(string css = "footer.site-footer") : base(css)
        {
        }

        public string CopyrightText => Scope.FindCss(".site-footer p").Text;

        public string SocialLink(string icon)
        {
            return Scope.FindXPath($"//a[i[contains(@class,'fa-{icon}')]]")["href"];
        }
    }
}