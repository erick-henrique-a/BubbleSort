namespace trabalho
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.medio_btn = new System.Windows.Forms.Button();
            this.pior_btn = new System.Windows.Forms.Button();
            this.melhor_btn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // medio_btn
            // 
            this.medio_btn.Location = new System.Drawing.Point(581, 138);
            this.medio_btn.Name = "medio_btn";
            this.medio_btn.Size = new System.Drawing.Size(177, 58);
            this.medio_btn.TabIndex = 0;
            this.medio_btn.Text = "medio";
            this.medio_btn.UseVisualStyleBackColor = true;
            this.medio_btn.Click += new System.EventHandler(this.medio_Click);
            // 
            // pior_btn
            // 
            this.pior_btn.Location = new System.Drawing.Point(581, 202);
            this.pior_btn.Name = "pior_btn";
            this.pior_btn.Size = new System.Drawing.Size(177, 46);
            this.pior_btn.TabIndex = 2;
            this.pior_btn.Text = "pior";
            this.pior_btn.UseVisualStyleBackColor = true;
            this.pior_btn.Click += new System.EventHandler(this.pior_Click);
            // 
            // melhor_btn
            // 
            this.melhor_btn.Location = new System.Drawing.Point(581, 76);
            this.melhor_btn.Name = "melhor_btn";
            this.melhor_btn.Size = new System.Drawing.Size(177, 56);
            this.melhor_btn.TabIndex = 3;
            this.melhor_btn.Text = "melhor";
            this.melhor_btn.UseVisualStyleBackColor = true;
            this.melhor_btn.Click += new System.EventHandler(this.melhor_click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(27, 48);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(493, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.melhor_btn);
            this.Controls.Add(this.pior_btn);
            this.Controls.Add(this.medio_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button medio_btn;
        private System.Windows.Forms.Button pior_btn;
        private System.Windows.Forms.Button melhor_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

