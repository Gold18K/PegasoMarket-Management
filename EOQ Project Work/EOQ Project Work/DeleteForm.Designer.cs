namespace EOQ_Project_Work
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            comboBoxYear = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            foodsComboBox = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            goBackButton = new Button();
            deleteButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxYear
            // 
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(167, 42);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(63, 28);
            comboBoxYear.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 9;
            label2.Text = "Seleziona l'anno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 8;
            label1.Text = "Seleziona l'alimento:";
            // 
            // foodsComboBox
            // 
            foodsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            foodsComboBox.FormattingEnabled = true;
            foodsComboBox.Location = new Point(167, 6);
            foodsComboBox.Name = "foodsComboBox";
            foodsComboBox.Size = new Size(151, 28);
            foodsComboBox.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(goBackButton, 1, 0);
            tableLayoutPanel1.Controls.Add(deleteButton, 0, 0);
            tableLayoutPanel1.Location = new Point(-1, 76);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(331, 64);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.FromArgb(255, 245, 159);
            goBackButton.Cursor = Cursors.Hand;
            goBackButton.Dock = DockStyle.Fill;
            goBackButton.Font = new Font("Calibri", 9F);
            goBackButton.Location = new Point(175, 10);
            goBackButton.Margin = new Padding(10);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(146, 44);
            goBackButton.TabIndex = 3;
            goBackButton.Text = "🔙Torna indietro";
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += gobackbutton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.Font = new Font("Calibri", 9F);
            deleteButton.ForeColor = SystemColors.ControlText;
            deleteButton.Location = new Point(10, 10);
            deleteButton.Margin = new Padding(10);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(145, 44);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "✖ Elimina";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 145);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(comboBoxYear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(foodsComboBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DeleteForm";
            Text = "PegasoMarket® Management";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxYear;
        private Label label2;
        private Label label1;
        private ComboBox foodsComboBox;
        private Button deleteButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button goBackButton;
    }
}