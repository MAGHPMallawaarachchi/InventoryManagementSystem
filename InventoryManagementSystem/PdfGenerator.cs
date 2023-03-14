using InventoryManagementSystem.DataModels;
using System.Configuration;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using iText.Layout.Properties;
using Image = iText.Layout.Element.Image;

namespace InventoryManagementSystem
{
    internal class PdfGenerator
    {
        private readonly MongoConnector _mongoConnector;

        public PdfGenerator()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        public async void GeneratePdf(Invoice invoice)
        {
            string filePath = @"C:\Users\Hasini\OneDrive\Documents\invoices";
            string outputPath = $"{filePath}\\{"KAP-" + invoice.sequence}.pdf";

            // create a new PDF document
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(outputPath));

            // create a new document instance using the PDF document
            Document document = new Document(pdfDoc);

            // add an image to the document
            Image logo = new Image(ImageDataFactory.Create(@"C:\Users\Hasini\OneDrive\Desktop\github\InventoryManagementSystem\InventoryManagementSystem\Resources\logo.png"));
            logo.SetWidth(UnitValue.CreatePercentValue(8));
            document.Add(logo);

            // add the company DETAILS to the document
            Paragraph companyName = new Paragraph("KAMAL AUTO PARTS (PVT) LTD");
            companyName.SetFontSize(18);
            document.Add(companyName);

            var companyAddress = new Paragraph("NO. 101/50, ANIYAKANDA WATTA, NAGODA, KANDANA, 11320.\nPhone: 011-2248131 / 071-9509700\nE-mail: kamalautoparts@gmail.com");
            document.Add(companyAddress);

            // add a title to the document
            Paragraph title = new Paragraph("INVOICE");
            title.SetFontSize(30);
            document.Add(title);

            // add the invoice number to the document
            Paragraph invoiceNumber = new Paragraph("KAP-"+invoice.sequence);
            invoiceNumber.SetFontSize(18);
            document.Add(invoiceNumber);

            // add the invoice number and date to the document
            Paragraph invoiceInfo = new Paragraph($"Invoice Number: KAP-{invoice.sequence}\nDate: {invoice.date.ToShortDateString()}\nTime: {invoice.time}\n\n");
            document.Add(invoiceInfo);

            // add the customer information to the document
            var customer = await _mongoConnector.GetByCustomerID(invoice.customer_id);
            Paragraph customerInfo = new Paragraph($"Customer: {customer.name}\nAddress: {customer.address}\nCity: {customer.city}\nPhone: {customer.phone_no}\n\n");
            document.Add(customerInfo);

            // create a table to hold the line items
            Table table = new Table(new float[] { 1, 2, 2, 4, 1, 2, 2 })
                .UseAllAvailableWidth();

            // add the table headers
            table.AddHeaderCell("NO");
            table.AddHeaderCell("Part No");
            table.AddHeaderCell("Brand");
            table.AddHeaderCell("Description");
            table.AddHeaderCell("Qty");
            table.AddHeaderCell("U/Price");
            table.AddHeaderCell("Amount");

            // add the line items to the table
            for (int i = 0; i < invoice.items.Count; i++)
            {
                InvoiceItem? invoice_item = invoice.items[i];

                var current_item = await _mongoConnector.GetByPartNumber(invoice_item.part_number);

                table.AddCell((i + 1).ToString());
                table.AddCell(invoice_item.part_number.ToString());
                table.AddCell(current_item.brand);
                table.AddCell(current_item.description);
                table.AddCell(invoice_item.quantity.ToString());
                table.AddCell(current_item.unit_price.ToString());
                table.AddCell(invoice_item.revenue.ToString());
            }

            // add the table to the document
            document.Add(table);

            // add the invoice number and date to the document
            Paragraph total = new Paragraph($"Total: Rs.{invoice.total_revenue}\n\n");
            document.Add(total);

            // close the document
            document.Close();
        }
    }
}
