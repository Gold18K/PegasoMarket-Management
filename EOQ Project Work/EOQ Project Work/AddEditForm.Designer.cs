namespace EOQ_Project_Work
{
    partial class AddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditForm));
            label1 = new Label();
            textBoxFood = new TextBox();
            label2 = new Label();
            textBoxYear = new TextBox();
            textBoxAnnualDemand = new TextBox();
            label3 = new Label();
            textBoxSetupCost = new TextBox();
            label4 = new Label();
            textBoxMaintenanceCost = new TextBox();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            goBackButton = new Button();
            addButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 3;
            label1.Text = "Alimento:";
            // 
            // textBoxFood
            // 
            textBoxFood.Font = new Font("Calibri", 10F);
            textBoxFood.Location = new Point(225, 6);
            textBoxFood.Name = "textBoxFood";
            textBoxFood.Size = new Size(145, 28);
            textBoxFood.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F);
            label2.Location = new Point(22, 45);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 5;
            label2.Text = "Anno:";
            // 
            // textBoxYear
            // 
            textBoxYear.Font = new Font("Calibri", 10F);
            textBoxYear.Location = new Point(225, 42);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(145, 28);
            textBoxYear.TabIndex = 6;
            // 
            // textBoxAnnualDemand
            // 
            textBoxAnnualDemand.Font = new Font("Calibri", 10F);
            textBoxAnnualDemand.Location = new Point(225, 79);
            textBoxAnnualDemand.Name = "textBoxAnnualDemand";
            textBoxAnnualDemand.Size = new Size(145, 28);
            textBoxAnnualDemand.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F);
            label3.Location = new Point(22, 82);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 7;
            label3.Text = "Domanda annua:";
            // 
            // textBoxSetupCost
            // 
            textBoxSetupCost.Font = new Font("Calibri", 10F);
            textBoxSetupCost.Location = new Point(225, 115);
            textBoxSetupCost.Name = "textBoxSetupCost";
            textBoxSetupCost.Size = new Size(145, 28);
            textBoxSetupCost.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10F);
            label4.Location = new Point(22, 118);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 9;
            label4.Text = "Costo setup:";
            // 
            // textBoxMaintenanceCost
            // 
            textBoxMaintenanceCost.Font = new Font("Calibri", 10F);
            textBoxMaintenanceCost.Location = new Point(225, 151);
            textBoxMaintenanceCost.Name = "textBoxMaintenanceCost";
            textBoxMaintenanceCost.Size = new Size(145, 28);
            textBoxMaintenanceCost.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 10F);
            label5.Location = new Point(22, 154);
            label5.Name = "label5";
            label5.Size = new Size(163, 21);
            label5.TabIndex = 11;
            label5.Text = "Costo mantenimento:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(goBackButton, 1, 0);
            tableLayoutPanel1.Controls.Add(addButton, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 185);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(368, 64);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.FromArgb(255, 245, 159);
            goBackButton.Cursor = Cursors.Hand;
            goBackButton.Dock = DockStyle.Fill;
            goBackButton.Font = new Font("Calibri", 9F);
            goBackButton.Location = new Point(194, 10);
            goBackButton.Margin = new Padding(10);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(164, 44);
            goBackButton.TabIndex = 3;
            goBackButton.Text = "🔙Torna indietro";
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += gobackbutton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(104, 183, 108);
            addButton.Cursor = Cursors.Hand;
            addButton.Dock = DockStyle.Fill;
            addButton.Font = new Font("Calibri", 9F);
            addButton.ForeColor = SystemColors.ControlText;
            addButton.Location = new Point(10, 10);
            addButton.Margin = new Padding(10);
            addButton.Name = "addButton";
            addButton.Size = new Size(164, 44);
            addButton.TabIndex = 1;
            addButton.Text = "➕Aggiungi/Modifica";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 255);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(textBoxMaintenanceCost);
            Controls.Add(label5);
            Controls.Add(textBoxSetupCost);
            Controls.Add(label4);
            Controls.Add(textBoxAnnualDemand);
            Controls.Add(label3);
            Controls.Add(textBoxYear);
            Controls.Add(label2);
            Controls.Add(textBoxFood);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddEditForm";
            Text = "PegasoMarket® Management";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFood;
        private Label label2;
        private TextBox textBoxYear;
        private TextBox textBoxAnnualDemand;
        private Label label3;
        private TextBox textBoxSetupCost;
        private Label label4;
        private TextBox textBoxMaintenanceCost;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Button goBackButton;
        private Button addButton;
    }
}