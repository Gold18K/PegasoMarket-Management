namespace EOQ_Project_Work
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            goBackButton = new Button();
            editButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 10F);
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 75);
            label1.TabIndex = 0;
            label1.Text = "La combinazione alimento/anno è già presente nel database, vuoi modificarne i valori?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(goBackButton, 1, 0);
            tableLayoutPanel1.Controls.Add(editButton, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 87);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(276, 64);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.FromArgb(255, 245, 159);
            goBackButton.Cursor = Cursors.Hand;
            goBackButton.Dock = DockStyle.Fill;
            goBackButton.Font = new Font("Calibri", 9F);
            goBackButton.Location = new Point(148, 10);
            goBackButton.Margin = new Padding(10);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(118, 44);
            goBackButton.TabIndex = 3;
            goBackButton.Text = "🔙Torna indietro";
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += goBackButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.FromArgb(104, 183, 108);
            editButton.Cursor = Cursors.Hand;
            editButton.Dock = DockStyle.Fill;
            editButton.Font = new Font("Calibri", 9F);
            editButton.ForeColor = SystemColors.ControlText;
            editButton.Location = new Point(10, 10);
            editButton.Margin = new Padding(10);
            editButton.Name = "editButton";
            editButton.Size = new Size(118, 44);
            editButton.TabIndex = 1;
            editButton.Text = "✔️ Modifica";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 157);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditForm";
            Text = "PegasoMarket® Management";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button goBackButton;
        private Button editButton;
    }
}