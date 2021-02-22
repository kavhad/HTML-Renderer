using System;
using HtmlRendererCore.Core;
using PdfSharpCore;
using Xunit;

namespace HtmlRendererCore.PdfSharp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestRender()
        {
            PdfGenerator.GeneratePdf(@"
                <html>
                <head></head>
                <body>
                    <div class=""red-alert"">Hello!</div>
                    <img src=""https://i2.wp.com/katzenworld.co.uk/wp-content/uploads/2014/07/cat1-1.jpg"" /></body>
                </html>", PageSize.A4, 10,
                PdfGenerator.ParseStyleSheet(".red-alert {border:red 2px solid;}")).Save("c:\\temp\\test.pdf");
        }
    }
}