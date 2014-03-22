using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PluraLeecher.Abstraction
{
    public interface ICategoryBusiness
    {
        IList<string> Categories(string pageHtml);
    }
}
