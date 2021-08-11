using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.apache.pdfbox.pdfviewer;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using Xceed.Words.NET;

namespace ConvertPdfToWord
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PDF files |*.pdf" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            PDDocument doc = PDDocument.load(textBox1.Text);
            PDFTextStripper stripper = new PDFTextStripper();
            richTextBox1.Text = (stripper.getText(doc));
            var docName = Path.GetFileNameWithoutExtension(textBox1.Text) + ".docx";
            var worddoc = DocX.Create(docName);
            worddoc.InsertParagraph(richTextBox1.Text);
            worddoc.Save();
            Process.Start(docName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbPath_Click(object sender, EventArgs e)
        {

        }
    }
}
