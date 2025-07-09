namespace EOQ_Project_Work
{
    partial class VisualizzaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizzaForm));
            foodsComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxYearSx = new ComboBox();
            comboBoxYearDx = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            gobackbutton = new Button();
            visualizeButton = new Button();
            label4 = new Label();
            chartEOQ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            listEOQ = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartEOQ).BeginInit();
            SuspendLayout();
            // 
            // foodsComboBox
            // 
            foodsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            foodsComboBox.FormattingEnabled = true;
            foodsComboBox.Location = new Point(167, 17);
            foodsComboBox.Name = "foodsComboBox";
            foodsComboBox.Size = new Size(151, 28);
            foodsComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 1;
            label1.Text = "Seleziona l'alimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(275, 21);
            label2.TabIndex = 2;
            label2.Text = "Seleziona il periodo di riferimento: dal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F);
            label3.Location = new Point(362, 60);
            label3.Name = "label3";
            label3.Size = new Size(22, 21);
            label3.TabIndex = 4;
            label3.Text = "al";
            // 
            // comboBoxYearSx
            // 
            comboBoxYearSx.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYearSx.FormattingEnabled = true;
            comboBoxYearSx.Location = new Point(293, 57);
            comboBoxYearSx.Name = "comboBoxYearSx";
            comboBoxYearSx.Size = new Size(63, 28);
            comboBoxYearSx.TabIndex = 5;
            // 
            // comboBoxYearDx
            // 
            comboBoxYearDx.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYearDx.FormattingEnabled = true;
            comboBoxYearDx.Location = new Point(390, 57);
            comboBoxYearDx.Name = "comboBoxYearDx";
            comboBoxYearDx.Size = new Size(63, 28);
            comboBoxYearDx.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(gobackbutton, 1, 0);
            tableLayoutPanel1.Controls.Add(visualizeButton, 0, 0);
            tableLayoutPanel1.Location = new Point(1, 91);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(520, 64);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // gobackbutton
            // 
            gobackbutton.BackColor = Color.FromArgb(255, 245, 159);
            gobackbutton.Cursor = Cursors.Hand;
            gobackbutton.Dock = DockStyle.Fill;
            gobackbutton.Font = new Font("Calibri", 12F);
            gobackbutton.Location = new Point(270, 10);
            gobackbutton.Margin = new Padding(10);
            gobackbutton.Name = "gobackbutton";
            gobackbutton.Size = new Size(240, 44);
            gobackbutton.TabIndex = 3;
            gobackbutton.Text = "🔙Torna indietro";
            gobackbutton.UseVisualStyleBackColor = false;
            gobackbutton.Click += goBackButton_Click;
            // 
            // visualizeButton
            // 
            visualizeButton.BackColor = SystemColors.ActiveCaption;
            visualizeButton.Cursor = Cursors.Hand;
            visualizeButton.Dock = DockStyle.Fill;
            visualizeButton.Font = new Font("Calibri", 12F);
            visualizeButton.ForeColor = SystemColors.ControlText;
            visualizeButton.Location = new Point(10, 10);
            visualizeButton.Margin = new Padding(10);
            visualizeButton.Name = "visualizeButton";
            visualizeButton.Size = new Size(240, 44);
            visualizeButton.TabIndex = 1;
            visualizeButton.Text = "📄Visualizza EOQs";
            visualizeButton.UseVisualStyleBackColor = false;
            visualizeButton.Click += visualizeButton_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(12, 155);
            label4.MaximumSize = new Size(0, 2);
            label4.Name = "label4";
            label4.Size = new Size(485, 2);
            label4.TabIndex = 4;
            // 
            // chartEOQ
            // 
            chartEOQ.BackColor = SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            chartEOQ.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartEOQ.Legends.Add(legend1);
            chartEOQ.Location = new Point(12, 169);
            chartEOQ.Name = "chartEOQ";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartEOQ.Series.Add(series1);
            chartEOQ.Size = new Size(499, 248);
            chartEOQ.TabIndex = 8;
            chartEOQ.Text = "chart1";
            // 
            // listEOQ
            // 
            listEOQ.BackColor = SystemColors.Control;
            listEOQ.BorderStyle = BorderStyle.None;
            listEOQ.Font = new Font("Calibri", 10F);
            listEOQ.FormattingEnabled = true;
            listEOQ.ItemHeight = 21;
            listEOQ.Location = new Point(390, 219);
            listEOQ.Name = "listEOQ";
            listEOQ.Size = new Size(131, 147);
            listEOQ.TabIndex = 9;
            // 
            // VisualizzaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 429);
            Controls.Add(listEOQ);
            Controls.Add(chartEOQ);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(comboBoxYearDx);
            Controls.Add(label4);
            Controls.Add(comboBoxYearSx);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(foodsComboBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VisualizzaForm";
            Text = "PegasoMarket® Management";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartEOQ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox foodsComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxYearSx;
        private ComboBox comboBoxYearDx;
        private TableLayoutPanel tableLayoutPanel1;
        private Button visualizeButton;
        private Button gobackbutton;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEOQ;
        private ListBox listEOQ;
    }
}