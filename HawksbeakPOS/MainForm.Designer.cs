namespace HawksbeakPOS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UPC_Prompt = new System.Windows.Forms.Label();
            this.UPC_Label = new System.Windows.Forms.Label();
            this.Product_Display = new System.Windows.Forms.TableLayoutPanel();
            this.lblPPU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductDescription_Label = new System.Windows.Forms.Label();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.Date_Label = new System.Windows.Forms.Label();
            this.Time_Label = new System.Windows.Forms.Label();
            this.Product_Display.SuspendLayout();
            this.SuspendLayout();
            // 
            // UPC_Prompt
            // 
            this.UPC_Prompt.AutoSize = true;
            this.UPC_Prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPC_Prompt.Location = new System.Drawing.Point(12, 9);
            this.UPC_Prompt.Name = "UPC_Prompt";
            this.UPC_Prompt.Size = new System.Drawing.Size(226, 24);
            this.UPC_Prompt.TabIndex = 0;
            this.UPC_Prompt.Text = "Enter UPC / Scan Product";
            // 
            // UPC_Label
            // 
            this.UPC_Label.AutoSize = true;
            this.UPC_Label.BackColor = System.Drawing.SystemColors.Window;
            this.UPC_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPC_Label.Location = new System.Drawing.Point(244, 9);
            this.UPC_Label.MinimumSize = new System.Drawing.Size(400, 0);
            this.UPC_Label.Name = "UPC_Label";
            this.UPC_Label.Size = new System.Drawing.Size(400, 24);
            this.UPC_Label.TabIndex = 1;
            // 
            // Product_Display
            // 
            this.Product_Display.BackColor = System.Drawing.Color.White;
            this.Product_Display.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Product_Display.ColumnCount = 4;
            this.Product_Display.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.69231F));
            this.Product_Display.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.30769F));
            this.Product_Display.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.Product_Display.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.Product_Display.Controls.Add(this.lblPPU, 2, 1);
            this.Product_Display.Controls.Add(this.label2, 2, 0);
            this.Product_Display.Controls.Add(this.label1, 1, 0);
            this.Product_Display.Controls.Add(this.label3, 3, 0);
            this.Product_Display.Controls.Add(this.ProductDescription_Label, 0, 0);
            this.Product_Display.Controls.Add(this.lblProductDesc, 0, 1);
            this.Product_Display.Controls.Add(this.lblSubtotal, 3, 1);
            this.Product_Display.Controls.Add(this.lblQuantity, 1, 1);
            this.Product_Display.Location = new System.Drawing.Point(16, 59);
            this.Product_Display.Name = "Product_Display";
            this.Product_Display.RowCount = 2;
            this.Product_Display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Product_Display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 585F));
            this.Product_Display.Size = new System.Drawing.Size(980, 628);
            this.Product_Display.TabIndex = 2;
            // 
            // lblPPU
            // 
            this.lblPPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPU.Location = new System.Drawing.Point(511, 42);
            this.lblPPU.Name = "lblPPU";
            this.lblPPU.Size = new System.Drawing.Size(196, 585);
            this.lblPPU.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price Per Unit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(714, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subtotal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductDescription_Label
            // 
            this.ProductDescription_Label.AutoSize = true;
            this.ProductDescription_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductDescription_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDescription_Label.Location = new System.Drawing.Point(4, 1);
            this.ProductDescription_Label.Name = "ProductDescription_Label";
            this.ProductDescription_Label.Size = new System.Drawing.Size(387, 40);
            this.ProductDescription_Label.TabIndex = 4;
            this.ProductDescription_Label.Text = "Product Description";
            this.ProductDescription_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDesc.Location = new System.Drawing.Point(4, 42);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(387, 585);
            this.lblProductDesc.TabIndex = 8;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(714, 42);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(260, 585);
            this.lblSubtotal.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(398, 42);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(106, 585);
            this.lblQuantity.TabIndex = 9;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Label.Location = new System.Drawing.Point(786, 9);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(48, 24);
            this.Date_Label.TabIndex = 3;
            this.Date_Label.Text = "Date";
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.Time_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Label.Location = new System.Drawing.Point(798, 33);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(53, 24);
            this.Time_Label.TabIndex = 4;
            this.Time_Label.Text = "Time";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Time_Label);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Product_Display);
            this.Controls.Add(this.UPC_Label);
            this.Controls.Add(this.UPC_Prompt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HawksbeakPOS";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Pressed);
            this.Product_Display.ResumeLayout(false);
            this.Product_Display.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UPC_Prompt;
        private System.Windows.Forms.Label UPC_Label;
        private System.Windows.Forms.TableLayoutPanel Product_Display;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductDescription_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPPU;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductDesc;
    }
}

