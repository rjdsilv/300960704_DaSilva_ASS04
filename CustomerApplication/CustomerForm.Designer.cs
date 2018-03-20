namespace CustomerApplication
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomersGridView = new System.Windows.Forms.DataGridView();
            this.AllCustomersButton = new System.Windows.Forms.Button();
            this.CanadianCustomersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.CustomersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CustomersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomersGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomersGridView.EnableHeadersVisualStyles = false;
            this.CustomersGridView.Location = new System.Drawing.Point(0, 0);
            this.CustomersGridView.Name = "CustomersGridView";
            this.CustomersGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.CustomersGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CustomersGridView.Size = new System.Drawing.Size(1751, 579);
            this.CustomersGridView.TabIndex = 0;
            // 
            // AllCustomersButton
            // 
            this.AllCustomersButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AllCustomersButton.ForeColor = System.Drawing.Color.Black;
            this.AllCustomersButton.Location = new System.Drawing.Point(0, 622);
            this.AllCustomersButton.Name = "AllCustomersButton";
            this.AllCustomersButton.Size = new System.Drawing.Size(1751, 36);
            this.AllCustomersButton.TabIndex = 1;
            this.AllCustomersButton.Text = "Search All Existing Customers";
            this.AllCustomersButton.UseVisualStyleBackColor = true;
            this.AllCustomersButton.Click += new System.EventHandler(this.AllCustomersButton_Click);
            // 
            // CanadianCustomersButton
            // 
            this.CanadianCustomersButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CanadianCustomersButton.ForeColor = System.Drawing.Color.Black;
            this.CanadianCustomersButton.Location = new System.Drawing.Point(0, 586);
            this.CanadianCustomersButton.Name = "CanadianCustomersButton";
            this.CanadianCustomersButton.Size = new System.Drawing.Size(1751, 36);
            this.CanadianCustomersButton.TabIndex = 2;
            this.CanadianCustomersButton.Text = "Search Canadian Customers";
            this.CanadianCustomersButton.UseVisualStyleBackColor = true;
            this.CanadianCustomersButton.Click += new System.EventHandler(this.CanadianCustomersButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1751, 658);
            this.Controls.Add(this.CanadianCustomersButton);
            this.Controls.Add(this.AllCustomersButton);
            this.Controls.Add(this.CustomersGridView);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Search";
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersGridView;
        private System.Windows.Forms.Button AllCustomersButton;
        private System.Windows.Forms.Button CanadianCustomersButton;
    }
}

