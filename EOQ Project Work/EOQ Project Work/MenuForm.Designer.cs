namespace EOQ_Project_Work
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            visualizeButton = new Button();
            addEditButton = new Button();
            deleteButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(visualizeButton, 0, 0);
            tableLayoutPanel1.Controls.Add(addEditButton, 1, 0);
            tableLayoutPanel1.Controls.Add(deleteButton, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(651, 128);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // visualizeButton
            // 
            visualizeButton.BackColor = SystemColors.ActiveCaption;
            visualizeButton.Dock = DockStyle.Fill;
            visualizeButton.Font = new Font("Calibri", 13F);
            visualizeButton.Location = new Point(3, 20);
            visualizeButton.Margin = new Padding(3, 20, 3, 20);
            visualizeButton.Name = "visualizeButton";
            visualizeButton.Size = new Size(211, 88);
            visualizeButton.TabIndex = 1;
            visualizeButton.Text = "📄Visualizza";
            visualizeButton.UseVisualStyleBackColor = false;
            visualizeButton.Click += visualizeButton_Click;
            // 
            // addEditButton
            // 
            addEditButton.BackColor = Color.FromArgb(104, 183, 108);
            addEditButton.Dock = DockStyle.Fill;
            addEditButton.Font = new Font("Calibri", 13F);
            addEditButton.Location = new Point(220, 20);
            addEditButton.Margin = new Padding(3, 20, 3, 20);
            addEditButton.Name = "addEditButton";
            addEditButton.Size = new Size(211, 88);
            addEditButton.TabIndex = 2;
            addEditButton.Text = "➕Aggiungi/Modifica";
            addEditButton.UseVisualStyleBackColor = false;
            addEditButton.Click += addEditButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.Font = new Font("Calibri", 13F);
            deleteButton.Location = new Point(437, 20);
            deleteButton.Margin = new Padding(3, 20, 3, 20);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(211, 88);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "✖ Elimina";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 128);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MenuForm";
            Text = "PegasoMarket® Management";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button visualizeButton;
        private Button addEditButton;
        private Button deleteButton;
    }
}