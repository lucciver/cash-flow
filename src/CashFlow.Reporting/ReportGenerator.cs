using System.IO;
using System.Threading.Tasks;

namespace CashFlow.Reporting
{
    internal sealed class ReportGenerator : IReportGenerator
    {
        public Task<Stream> GeneratePdf(
            string bodyTemplate,
            string headerTemplate = null,
            string footerTemplate = null,
            object templateData = null,
            PageMargins margins = null,
            PageFormat format = PageFormat.A4,
            PageOrientation orientation = PageOrientation.Portrait)
        {
            throw new System.NotImplementedException();
        }
    }
}