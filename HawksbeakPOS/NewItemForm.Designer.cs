namespace HawksbeakPOS
{
    partial class NewItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItemForm));
            this.NewUPC_Label = new System.Windows.Forms.Label();
            this.NewProdDescr_Label = new System.Windows.Forms.Label();
            this.NewPricePerUnit_Label = new System.Windows.Forms.Label();
            this.NewQuantity_Label = new System.Windows.Forms.Label();
            this.NewUPC_TextBox = new System.Windows.Forms.TextBox();
            this.NewProdDescr_TextBox = new System.Windows.Forms.TextBox();
            this.NewItemPrice_TextBox = new System.Windows.Forms.TextBox();
            this.NewItemQuantity_TextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewUPC_Label
            // 
            this.NewUPC_Label.AutoSize = true;
            this.NewUPC_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUPC_Label.Location = new System.Drawing.Point(28, 27);
            this.NewUPC_Label.Name = "NewUPC_Label";
            this.NewUPC_Label.Size = new System.Drawing.Size(132, 24);
            this.NewUPC_Label.TabIndex = 0;
            this.NewUPC_Label.Text = "New Item UPC";
            // 
            // NewProdDescr_Label
            // 
            this.NewProdDescr_Label.AutoSize = true;
            this.NewProdDescr_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProdDescr_Label.Location = new System.Drawing.Point(28, 77);
            this.NewProdDescr_Label.Name = "NewProdDescr_Label";
            this.NewProdDescr_Label.Size = new System.Drawing.Size(188, 24);
            this.NewProdDescr_Label.TabIndex = 1;
            this.NewProdDescr_Label.Text = "New Item Description";
            // 
            // NewPricePerUnit_Label
            // 
            this.NewPricePerUnit_Label.AutoSize = true;
            this.NewPricePerUnit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPricePerUnit_Label.Location = new System.Drawing.Point(28, 123);
            this.NewPricePerUnit_Label.Name = "NewPricePerUnit_Label";
            this.NewPricePerUnit_Label.Size = new System.Drawing.Size(137, 24);
            this.NewPricePerUnit_Label.TabIndex = 2;
            this.NewPricePerUnit_Label.Text = "New Item Price";
            // 
            // NewQuantity_Label
            // 
            this.NewQuantity_Label.AutoSize = true;
            this.NewQuantity_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewQuantity_Label.Location = new System.Drawing.Point(28, 169);
            this.NewQuantity_Label.Name = "NewQuantity_Label";
            this.NewQuantity_Label.Size = new System.Drawing.Size(162, 24);
            this.NewQuantity_Label.TabIndex = 3;
            this.NewQuantity_Label.Text = "New Item Quantity";
            // 
            // NewUPC_TextBox
            // 
            this.NewUPC_TextBox.BackColor = System.Drawing.Color.White;
            this.NewUPC_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUPC_TextBox.Location = new System.Drawing.Point(227, 27);
            this.NewUPC_TextBox.Name = "NewUPC_TextBox";
            this.NewUPC_TextBox.ReadOnly = true;
            this.NewUPC_TextBox.Size = new System.Drawing.Size(337, 29);
            this.NewUPC_TextBox.TabIndex = 4;
            this.NewUPC_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewUPC_TextBox_KeyPress);
            // 
            // NewProdDescr_TextBox
            // 
            this.NewProdDescr_TextBox.BackColor = System.Drawing.Color.White;
            this.NewProdDescr_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProdDescr_TextBox.Location = new System.Drawing.Point(227, 77);
            this.NewProdDescr_TextBox.Name = "NewProdDescr_TextBox";
            this.NewProdDescr_TextBox.ReadOnly = true;
            this.NewProdDescr_TextBox.Size = new System.Drawing.Size(337, 29);
            this.NewProdDescr_TextBox.TabIndex = 5;
            this.NewProdDescr_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewProdDescr_TextBox_KeyPress);
            // 
            // NewItemPrice_TextBox
            // 
            this.NewItemPrice_TextBox.BackColor = System.Drawing.Color.White;
            this.NewItemPrice_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewItemPrice_TextBox.Location = new System.Drawing.Point(227, 120);
            this.NewItemPrice_TextBox.Name = "NewItemPrice_TextBox";
            this.NewItemPrice_TextBox.ReadOnly = true;
            this.NewItemPrice_TextBox.Size = new System.Drawing.Size(337, 29);
            this.NewItemPrice_TextBox.TabIndex = 6;
            this.NewItemPrice_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewItemPrice_TextBox_KeyPress);
            // 
            // NewItemQuantity_TextBox
            // 
            this.NewItemQuantity_TextBox.BackColor = System.Drawing.Color.White;
            this.NewItemQuantity_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewItemQuantity_TextBox.Location = new System.Drawing.Point(227, 164);
            this.NewItemQuantity_TextBox.Name = "NewItemQuantity_TextBox";
            this.NewItemQuantity_TextBox.ReadOnly = true;
            this.NewItemQuantity_TextBox.Size = new System.Drawing.Size(337, 29);
            this.NewItemQuantity_TextBox.TabIndex = 7;
            this.NewItemQuantity_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewItemQuantity_TextBox_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(246, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 284);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.NewItemQuantity_TextBox);
            this.Controls.Add(this.NewItemPrice_TextBox);
            this.Controls.Add(this.NewProdDescr_TextBox);
            this.Controls.Add(this.NewUPC_TextBox);
            this.Controls.Add(this.NewQuantity_Label);
            this.Controls.Add(this.NewPricePerUnit_Label);
            this.Controls.Add(this.NewProdDescr_Label);
            this.Controls.Add(this.NewUPC_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewItemForm";
            this.Text = "Add New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewUPC_Label;
        private System.Windows.Forms.Label NewProdDescr_Label;
        private System.Windows.Forms.Label NewPricePerUnit_Label;
        private System.Windows.Forms.Label NewQuantity_Label;
        private System.Windows.Forms.TextBox NewUPC_TextBox;
        private System.Windows.Forms.TextBox NewProdDescr_TextBox;
        private System.Windows.Forms.TextBox NewItemPrice_TextBox;
        private System.Windows.Forms.TextBox NewItemQuantity_TextBox;
        private System.Windows.Forms.Button btnAdd;
    }
}