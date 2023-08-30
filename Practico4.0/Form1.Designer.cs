namespace Practico4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BGenerarFuncion = new System.Windows.Forms.Button();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.TDesde = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.THasta = new System.Windows.Forms.TextBox();
            this.LListNum = new System.Windows.Forms.Label();
            this.BNumPares = new System.Windows.Forms.Button();
            this.BNumImp = new System.Windows.Forms.Button();
            this.BNumPrimos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // BGenerarFuncion
            // 
            this.BGenerarFuncion.BackColor = System.Drawing.SystemColors.Control;
            this.BGenerarFuncion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGenerarFuncion.Location = new System.Drawing.Point(53, 138);
            this.BGenerarFuncion.Name = "BGenerarFuncion";
            this.BGenerarFuncion.Size = new System.Drawing.Size(124, 23);
            this.BGenerarFuncion.TabIndex = 0;
            this.BGenerarFuncion.Text = "Generar función";
            this.BGenerarFuncion.UseVisualStyleBackColor = false;
            this.BGenerarFuncion.Click += new System.EventHandler(this.BGenerarFuncion_Click);
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(24, 40);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(38, 13);
            this.LDesde.TabIndex = 1;
            this.LDesde.Text = "Desde";
            this.LDesde.Click += new System.EventHandler(this.label1_Click);
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(24, 88);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(35, 13);
            this.LHasta.TabIndex = 2;
            this.LHasta.Text = "Hasta";
            // 
            // TDesde
            // 
            this.TDesde.Location = new System.Drawing.Point(77, 40);
            this.TDesde.Name = "TDesde";
            this.TDesde.Size = new System.Drawing.Size(100, 20);
            this.TDesde.TabIndex = 3;
            this.TDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDesde_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(202, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 225);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(77, 88);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(100, 20);
            this.THasta.TabIndex = 5;
            this.THasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.THasta_KeyPress);
            // 
            // LListNum
            // 
            this.LListNum.AutoSize = true;
            this.LListNum.Location = new System.Drawing.Point(272, 47);
            this.LListNum.Name = "LListNum";
            this.LListNum.Size = new System.Drawing.Size(89, 13);
            this.LListNum.TabIndex = 6;
            this.LListNum.Text = "Lista de Números";
            // 
            // BNumPares
            // 
            this.BNumPares.Location = new System.Drawing.Point(53, 177);
            this.BNumPares.Name = "BNumPares";
            this.BNumPares.Size = new System.Drawing.Size(124, 23);
            this.BNumPares.TabIndex = 7;
            this.BNumPares.Text = "Numeros Pares";
            this.BNumPares.UseVisualStyleBackColor = true;
            this.BNumPares.Click += new System.EventHandler(this.BNumPares_Click);
            // 
            // BNumImp
            // 
            this.BNumImp.Location = new System.Drawing.Point(53, 218);
            this.BNumImp.Name = "BNumImp";
            this.BNumImp.Size = new System.Drawing.Size(124, 23);
            this.BNumImp.TabIndex = 8;
            this.BNumImp.Text = "Numeros Impares";
            this.BNumImp.UseVisualStyleBackColor = true;
            this.BNumImp.Click += new System.EventHandler(this.BNumImp_Click);
            // 
            // BNumPrimos
            // 
            this.BNumPrimos.Location = new System.Drawing.Point(53, 258);
            this.BNumPrimos.Name = "BNumPrimos";
            this.BNumPrimos.Size = new System.Drawing.Size(124, 23);
            this.BNumPrimos.TabIndex = 9;
            this.BNumPrimos.Text = "Numeros Primos";
            this.BNumPrimos.UseVisualStyleBackColor = true;
            this.BNumPrimos.Click += new System.EventHandler(this.BNumPrimos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.BNumPrimos);
            this.panel1.Controls.Add(this.BGenerarFuncion);
            this.panel1.Controls.Add(this.BNumImp);
            this.panel1.Controls.Add(this.LDesde);
            this.panel1.Controls.Add(this.BNumPares);
            this.panel1.Controls.Add(this.LHasta);
            this.panel1.Controls.Add(this.LListNum);
            this.panel1.Controls.Add(this.TDesde);
            this.panel1.Controls.Add(this.THasta);
            this.panel1.Location = new System.Drawing.Point(47, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 398);
            this.panel1.TabIndex = 10;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(473, 40);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "Grafico de datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 442);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BGenerarFuncion;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.TextBox TDesde;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox THasta;
        private System.Windows.Forms.Label LListNum;
        private System.Windows.Forms.Button BNumPares;
        private System.Windows.Forms.Button BNumImp;
        private System.Windows.Forms.Button BNumPrimos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

