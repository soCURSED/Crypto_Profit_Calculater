namespace calculate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textEnter = new System.Windows.Forms.TextBox();
            this.textOut = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textProfit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textFinal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.buttonCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("TheSans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.ForeColor = System.Drawing.Color.Black;
            this.buttonCalculate.Location = new System.Drawing.Point(137, 171);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(110, 45);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "CALCULATE";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("TheSans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(137, 399);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 45);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textEnter
            // 
            this.textEnter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEnter.Font = new System.Drawing.Font("TheSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEnter.Location = new System.Drawing.Point(207, 49);
            this.textEnter.Multiline = true;
            this.textEnter.Name = "textEnter";
            this.textEnter.PlaceholderText = "42156";
            this.textEnter.Size = new System.Drawing.Size(160, 31);
            this.textEnter.TabIndex = 1;
            this.textEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textEnter.TextChanged += new System.EventHandler(this.textEnter_TextChanged);
            // 
            // textOut
            // 
            this.textOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOut.Font = new System.Drawing.Font("TheSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textOut.Location = new System.Drawing.Point(12, 49);
            this.textOut.Multiline = true;
            this.textOut.Name = "textOut";
            this.textOut.PlaceholderText = "51000";
            this.textOut.Size = new System.Drawing.Size(160, 31);
            this.textOut.TabIndex = 2;
            this.textOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textOut.TextChanged += new System.EventHandler(this.textOut_TextChanged);
            // 
            // textPrice
            // 
            this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrice.Font = new System.Drawing.Font("TheSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPrice.Location = new System.Drawing.Point(101, 111);
            this.textPrice.Multiline = true;
            this.textPrice.Name = "textPrice";
            this.textPrice.PlaceholderText = " 1500";
            this.textPrice.Size = new System.Drawing.Size(181, 31);
            this.textPrice.TabIndex = 3;
            this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPrice.TextChanged += new System.EventHandler(this.textPrice_TextChanged);
            // 
            // textProfit
            // 
            this.textProfit.BackColor = System.Drawing.Color.SlateGray;
            this.textProfit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProfit.Cursor = System.Windows.Forms.Cursors.Default;
            this.textProfit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textProfit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textProfit.Location = new System.Drawing.Point(12, 256);
            this.textProfit.Multiline = true;
            this.textProfit.Name = "textProfit";
            this.textProfit.ReadOnly = true;
            this.textProfit.Size = new System.Drawing.Size(146, 27);
            this.textProfit.TabIndex = 0;
            this.textProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textProfit.TextChanged += new System.EventHandler(this.textProfit_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("TheSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "PROFIT %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("TheSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(266, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "PROFIT";
            // 
            // textTotal
            // 
            this.textTotal.BackColor = System.Drawing.Color.SlateGray;
            this.textTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.textTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTotal.Location = new System.Drawing.Point(224, 256);
            this.textTotal.Multiline = true;
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(146, 27);
            this.textTotal.TabIndex = 0;
            this.textTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTotal.TextChanged += new System.EventHandler(this.textTotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("TheSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(266, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("TheSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(74, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("TheSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(166, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "USD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(22, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 2);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(22, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 2);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("TheSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(166, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "TOTAL";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textFinal
            // 
            this.textFinal.BackColor = System.Drawing.Color.SlateGray;
            this.textFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFinal.Cursor = System.Windows.Forms.Cursors.Default;
            this.textFinal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textFinal.Location = new System.Drawing.Point(124, 341);
            this.textFinal.Multiline = true;
            this.textFinal.Name = "textFinal";
            this.textFinal.ReadOnly = true;
            this.textFinal.Size = new System.Drawing.Size(146, 27);
            this.textFinal.TabIndex = 9;
            this.textFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textFinal.TextChanged += new System.EventHandler(this.textFinal_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("TheSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(5, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "INFO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(384, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textFinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textProfit);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.textEnter);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCalculate;
        private Button buttonClear;
        private TextBox textEnter;
        private TextBox textOut;
        private TextBox textPrice;
        private TextBox textProfit;
        private Label label4;
        private Label label5;
        private TextBox textTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel3;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textFinal;
        private Button button1;
    }
}