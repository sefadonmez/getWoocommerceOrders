namespace getWoocommerceOrders
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.btnGetOrders = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxOrderDetails = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOrderDetailsBilling = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOrderDetailsShipping = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1194, 170);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.SelectionChanged += new System.EventHandler(this.dataGridViewOrders_SelectionChanged);
            // 
            // btnGetOrders
            // 
            this.btnGetOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetOrders.Location = new System.Drawing.Point(1112, 8);
            this.btnGetOrders.Name = "btnGetOrders";
            this.btnGetOrders.Size = new System.Drawing.Size(104, 52);
            this.btnGetOrders.TabIndex = 1;
            this.btnGetOrders.Text = "All Get Orders";
            this.btnGetOrders.UseVisualStyleBackColor = true;
            this.btnGetOrders.Click += new System.EventHandler(this.btnGetOrders_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnGetOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 72);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOrderDetails
            // 
            this.richTextBoxOrderDetails.Location = new System.Drawing.Point(12, 211);
            this.richTextBoxOrderDetails.Name = "richTextBoxOrderDetails";
            this.richTextBoxOrderDetails.Size = new System.Drawing.Size(256, 189);
            this.richTextBoxOrderDetails.TabIndex = 3;
            this.richTextBoxOrderDetails.Text = "";
            // 
            // richTextBoxOrderDetailsBilling
            // 
            this.richTextBoxOrderDetailsBilling.Location = new System.Drawing.Point(274, 211);
            this.richTextBoxOrderDetailsBilling.Name = "richTextBoxOrderDetailsBilling";
            this.richTextBoxOrderDetailsBilling.Size = new System.Drawing.Size(256, 189);
            this.richTextBoxOrderDetailsBilling.TabIndex = 4;
            this.richTextBoxOrderDetailsBilling.Text = "";
            // 
            // richTextBoxOrderDetailsShipping
            // 
            this.richTextBoxOrderDetailsShipping.Location = new System.Drawing.Point(536, 211);
            this.richTextBoxOrderDetailsShipping.Name = "richTextBoxOrderDetailsShipping";
            this.richTextBoxOrderDetailsShipping.Size = new System.Drawing.Size(256, 189);
            this.richTextBoxOrderDetailsShipping.TabIndex = 5;
            this.richTextBoxOrderDetailsShipping.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 639);
            this.Controls.Add(this.richTextBoxOrderDetailsShipping);
            this.Controls.Add(this.richTextBoxOrderDetailsBilling);
            this.Controls.Add(this.richTextBoxOrderDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button btnGetOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxOrderDetails;
        private System.Windows.Forms.RichTextBox richTextBoxOrderDetailsBilling;
        private System.Windows.Forms.RichTextBox richTextBoxOrderDetailsShipping;
    }
}

