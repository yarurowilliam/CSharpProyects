using ENTITY;
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRAESTRUCTURA
{
    public class PDF
    {
        string RutePDF;

        public PDF(string rutePDF)
        {
            RutePDF = rutePDF;
        }

        public void GuardarPdf(IList<Conductor> conductores)
        {
            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);
            FileStream fileStream = new FileStream(@RutePDF, FileMode.Create);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fileStream);

            var titleFont = FontFactory.GetFont("Arial", 12, Font.BOLD);
            var titleFontBlue = FontFactory.GetFont("Arial", 14, Font.NORMAL, BaseColor.BLUE);
            var boldTableFont = FontFactory.GetFont("Arial", 8, Font.BOLD);
            var bodyFont = FontFactory.GetFont("Arial", 8, Font.NORMAL);
            var EmailFont = FontFactory.GetFont("Arial", 8, Font.NORMAL, BaseColor.BLUE);
            BaseColor TabelHeaderBackGroundColor = WebColors.GetRGBColor("#EEEEEE");

            Rectangle pageSize = writer.PageSize;

            pdfDoc.AddTitle("JOAN MOTORS");
            pdfDoc.AddCreator("Michael Catalan y WIlliam Yaruro");
            pdfDoc.Open();

            #region Top table

            // Create the header table 
            PdfPTable headertable = new PdfPTable(3);
            headertable.HorizontalAlignment = 0;
            headertable.WidthPercentage = 100;
            headertable.SetWidths(new float[] { 100f, 320f, 100f });  // then set the column's __relative__ widths
            headertable.DefaultCell.Border = Rectangle.NO_BORDER;
            //headertable.DefaultCell.Border = Rectangle.BOX; //for testing           

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Users\WILLIAM ANDRES\Desktop\Proyecto V7 (EntityReady2)\Materiales_Iconos\Logo.png");
            logo.ScaleToFit(267, 189);

            {
                PdfPCell pdfCelllogo = new PdfPCell(logo);
                pdfCelllogo.Border = Rectangle.NO_BORDER;
                pdfCelllogo.BorderColorBottom = new BaseColor(System.Drawing.Color.Black);
                pdfCelllogo.BorderWidthBottom = 1f;
                headertable.AddCell(pdfCelllogo);
            }

            {
                PdfPCell middlecell = new PdfPCell();
                middlecell.Border = Rectangle.NO_BORDER;
                middlecell.BorderColorBottom = new BaseColor(System.Drawing.Color.Black);
                middlecell.BorderWidthBottom = 1f;
                headertable.AddCell(middlecell);
            }

            {
                PdfPTable nested = new PdfPTable(1);
                nested.DefaultCell.Border = Rectangle.NO_BORDER;
                PdfPCell nextPostCell1 = new PdfPCell(new Phrase("Joan Motors", titleFont));
                nextPostCell1.Border = Rectangle.NO_BORDER;
                nested.AddCell(nextPostCell1);
                PdfPCell nextPostCell2 = new PdfPCell(new Phrase("Valledupar-Cesar", bodyFont));
                nextPostCell2.Border = Rectangle.NO_BORDER;
                nested.AddCell(nextPostCell2);
                PdfPCell nextPostCell3 = new PdfPCell(new Phrase("(+57) 3226427638", bodyFont));
                nextPostCell3.Border = Rectangle.NO_BORDER;
                nested.AddCell(nextPostCell3);
                PdfPCell nextPostCell4 = new PdfPCell(new Phrase("CasaStark@LannisterFck.com", EmailFont));
                nextPostCell4.Border = Rectangle.NO_BORDER;
                nested.AddCell(nextPostCell4);
                nested.AddCell("");
                PdfPCell nesthousing = new PdfPCell(nested);
                nesthousing.Border = Rectangle.NO_BORDER;
                nesthousing.BorderColorBottom = new BaseColor(System.Drawing.Color.Black);
                nesthousing.BorderWidthBottom = 1f;
                nesthousing.Rowspan = 5;
                nesthousing.PaddingBottom = 10f;
                headertable.AddCell(nesthousing);
            }

            PdfPTable Invoicetable = new PdfPTable(3);
            Invoicetable.HorizontalAlignment = 0;
            Invoicetable.WidthPercentage = 100;
            Invoicetable.SetWidths(new float[] { 100f, 320f, 100f });  // then set the column's __relative__ widths
            Invoicetable.DefaultCell.Border = Rectangle.NO_BORDER;

            {
                PdfPTable nested = new PdfPTable(1);
                nested.DefaultCell.Border = Rectangle.NO_BORDER;
                PdfPCell nextPostCell1 = new PdfPCell(new Phrase("Liquidaciones Presentadas a:", bodyFont));
                nextPostCell1.Border = Rectangle.NO_BORDER;
                nested.AddCell(nextPostCell1);
                PdfPCell nextPostCell2 = new PdfPCell(new Phrase("Anya Bolaño", titleFont));
                nextPostCell2.Border = Rectangle.NO_BORDER;
                nested.AddCell(nextPostCell2);
                PdfPCell nextPostCell3 = new PdfPCell(new Phrase("Valledupar, Cesar, Colombia", bodyFont));
                nextPostCell3.Border = Rectangle.NO_BORDER;
                nested.AddCell(nextPostCell3);
                PdfPCell nextPostCell4 = new PdfPCell(new Phrase("nolose@unicesar.edu.co", EmailFont));
                nextPostCell4.Border = Rectangle.NO_BORDER;
                nested.AddCell(nextPostCell4);
                nested.AddCell("");
                PdfPCell nesthousing = new PdfPCell(nested);
                nesthousing.Border = Rectangle.NO_BORDER;

                nesthousing.Rowspan = 5;
                nesthousing.PaddingBottom = 10f;
                Invoicetable.AddCell(nesthousing);
            }

            {
                PdfPCell middlecell = new PdfPCell();
                middlecell.Border = Rectangle.NO_BORDER;

                Invoicetable.AddCell(middlecell);
            }

            {
                PdfPTable nested = new PdfPTable(1);
                nested.DefaultCell.Border = Rectangle.NO_BORDER;
                PdfPCell nextPostCell1 = new PdfPCell(new Phrase("Liquidacion:", titleFontBlue));
                nextPostCell1.Border = Rectangle.NO_BORDER;
                nested.AddCell(nextPostCell1);
                PdfPCell nextPostCell2 = new PdfPCell(new Phrase("Fecha de Liquidacion: " + DateTime.Now.ToShortDateString(), bodyFont));
                nextPostCell2.Border = Rectangle.NO_BORDER;
                nested.AddCell(nextPostCell2);
                nested.AddCell("");
                PdfPCell nesthousing = new PdfPCell(nested);
                nesthousing.Border = Rectangle.NO_BORDER;

                nesthousing.Rowspan = 5;
                nesthousing.PaddingBottom = 10f;
                Invoicetable.AddCell(nesthousing);
            }

            pdfDoc.Add(headertable);
            Invoicetable.PaddingTop = 10f;

            pdfDoc.Add(Invoicetable);

            #endregion

            //Create body table
            pdfDoc.Add(LlenarTabla(conductores));
            pdfDoc.Close();


        }

        private PdfPTable LlenarTabla(IList<Conductor> conductores)
        {
            BaseColor TabelHeaderBackGroundColor = WebColors.GetRGBColor("#EEEEEE");
            var boldTableFont = FontFactory.GetFont("Arial", 8, Font.BOLD);

            PdfPTable itemTable = new PdfPTable(5);

            itemTable.HorizontalAlignment = 0;
            itemTable.WidthPercentage = 100;
            itemTable.SetWidths(new float[] { 10, 10, 10, 10, 10 });
            itemTable.SpacingAfter = 40;
            itemTable.DefaultCell.Border = Rectangle.BOX;

            PdfPCell cellNit = new PdfPCell(new Phrase("IDENTIFICACION", boldTableFont));
            cellNit.BackgroundColor = TabelHeaderBackGroundColor;
            cellNit.HorizontalAlignment = Element.ALIGN_CENTER;
            itemTable.AddCell(cellNit);

            PdfPCell cellMes = new PdfPCell(new Phrase("NOMBRE", boldTableFont));
            cellMes.BackgroundColor = TabelHeaderBackGroundColor;
            cellMes.HorizontalAlignment = Element.ALIGN_CENTER;
            itemTable.AddCell(cellMes);

            PdfPCell cellVigencia = new PdfPCell(new Phrase("TELEFONO", boldTableFont));
            cellVigencia.BackgroundColor = TabelHeaderBackGroundColor;
            cellVigencia.HorizontalAlignment = Element.ALIGN_CENTER;
            itemTable.AddCell(cellVigencia);

            PdfPCell cellTipo = new PdfPCell(new Phrase("DIRECCION", boldTableFont));
            cellTipo.BackgroundColor = TabelHeaderBackGroundColor;
            cellTipo.HorizontalAlignment = Element.ALIGN_CENTER;
            itemTable.AddCell(cellTipo);

            PdfPCell cellValorImpuesto = new PdfPCell(new Phrase("ESTADO", boldTableFont));
            cellValorImpuesto.BackgroundColor = TabelHeaderBackGroundColor;
            cellValorImpuesto.HorizontalAlignment = Element.ALIGN_CENTER;
            itemTable.AddCell(cellValorImpuesto);


            foreach (Conductor conductor in conductores)
            {
                itemTable.AddCell(conductor.Identificacion);
                itemTable.AddCell(conductor.Nombre);
                itemTable.AddCell(conductor.Telefono);
                itemTable.AddCell(conductor.Direccion);
                itemTable.AddCell(conductor.Estado);


            }

            return itemTable;
        }


    }
}
