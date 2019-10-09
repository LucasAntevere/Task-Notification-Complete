namespace Task.Notification
{
    public class HtmlLeaf : IHtmlComponent
    {
        private readonly string _innerText;
        private readonly string _tag;

        public HtmlLeaf(string tag,
                        string innerText)
        {
            _innerText = innerText;
            _tag = tag;
        }

        public string GetHtml()
        {
            return $"<{_tag}>" + _innerText + $"</{_tag}>";
        }
    }
}