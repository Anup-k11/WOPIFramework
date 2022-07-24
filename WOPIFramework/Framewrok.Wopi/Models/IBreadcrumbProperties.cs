using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framewrok.Wopi.Models
{
    internal interface IBreadcrumbProperties
    {
        string BreadcrumbBrandName { get; set; }
        Uri BreadcrumbBrandUrl { get; set; }
        string BreadcrumbDocName { get; set; }
        string BreadcrumbFolderName { get; set; }
        Uri BreadcrumbFolderUrl { get; set; }
    }
}
