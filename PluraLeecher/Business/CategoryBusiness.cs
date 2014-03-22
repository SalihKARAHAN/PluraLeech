using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using PluraLeecher.Abstraction;

namespace PluraLeecher.Business
{
    public class CategoryBusiness : ICategoryBusiness
    {
        private HtmlDocument _htmlDocument;
        private HtmlNode _htmlNode;

        public CategoryBusiness()
        {
            _htmlDocument = new HtmlDocument();
        }

        public IList<string> Categories(string pageHtml)
        {
            _htmlDocument.LoadHtml(pageHtml);
            _htmlNode = _htmlDocument.DocumentNode;

        }
    }
}
