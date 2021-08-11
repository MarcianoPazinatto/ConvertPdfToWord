
namespace ConvertPdfToWord
{
    partial class Converter
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSelectPdfFile = new System.Windows.Forms.Button();
            this.btnConvertToWord = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSelectPdfFile
            // 
            this.btSelectPdfFile.Location = new System.Drawing.Point(572, 18);
            this.btSelectPdfFile.Name = "btSelectPdfFile";
            this.btSelectPdfFile.Padding = new System.Windows.Forms.Padding(10);
            this.btSelectPdfFile.Size = new System.Drawing.Size(105, 39);
            this.btSelectPdfFile.TabIndex = 0;
            this.btSelectPdfFile.Text = "Select PDF file";
            this.btSelectPdfFile.UseVisualStyleBackColor = true;
            this.btSelectPdfFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConvertToWord
            // 
            this.btnConvertToWord.Location = new System.Drawing.Point(347, 400);
            this.btnConvertToWord.Name = "btnConvertToWord";
            this.btnConvertToWord.Size = new System.Drawing.Size(108, 38);
            this.btnConvertToWord.TabIndex = 1;
            this.btnConvertToWord.Text = "Convert to Word";
            this.btnConvertToWord.UseVisualStyleBackColor = true;
            this.btnConvertToWord.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 20);
            this.textBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 331);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.Location = new System.Drawing.Point(126, 28);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(40, 17);
            this.lbPath.TabIndex = 4;
            this.lbPath.Text = "path:";
            this.lbPath.Click += new System.EventHandler(this.lbPath_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConvertToWord);
            this.Controls.Add(this.btSelectPdfFile);
            this.Name = "Converter";
            this.Text = "PDF to Word Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSelectPdfFile;
        private System.Windows.Forms.Button btnConvertToWord;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbPath;
    }
}

