namespace Task.Notification
{
    public class HtmlComposite : IHtmlComponent
    {
        private readonly IHtmlComponent[] _childrenComponents;
        private readonly string _tag;

        public HtmlComposite(string tag, 
                             IHtmlComponent[] childrenComponents)
        {
            _childrenComponents = childrenComponents;
            _tag = tag;
        }

        public string GetHtml()
        {
            var html = $"<{_tag}>";

            foreach (var childComponent in _childrenComponents)
                html += childComponent.GetHtml();

            html += $"</{_tag}>";

            return html;
        }
    }
}