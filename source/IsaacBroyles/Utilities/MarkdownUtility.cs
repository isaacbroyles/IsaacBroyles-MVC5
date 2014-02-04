using MarkdownSharp;

namespace IsaacBroyles.Utilities
{
    public class MarkdownUtility : IFormatter
    {
        public MarkdownUtility()
        {
            markdown = new Markdown();
        }

        public string Transform(string mdText)
        {
            return markdown.Transform(mdText);
        }

        private Markdown markdown;
    }
}