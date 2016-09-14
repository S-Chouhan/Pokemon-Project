namespace projectPokemon
{
    partial class pokemonForm
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
            this.lblAlert = new System.Windows.Forms.Label();
            this.btnAmount = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtChamanderNoOfQty = new System.Windows.Forms.TextBox();
            this.txtSquirtleNoOfQty = new System.Windows.Forms.TextBox();
            this.txtPikachuNoOfQty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Location = new System.Drawing.Point(103, 232);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(0, 13);
            this.lblAlert.TabIndex = 29;
            // 
            // btnAmount
            // 
            this.btnAmount.Location = new System.Drawing.Point(80, 188);
            this.btnAmount.Name = "btnAmount";
            this.btnAmount.Size = new System.Drawing.Size(189, 23);
            this.btnAmount.TabIndex = 28;
            this.btnAmount.Text = "Calculate";
            this.btnAmount.UseVisualStyleBackColor = true;
            this.btnAmount.Click += new System.EventHandler(this.btnAmount_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(50, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 23);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Pokemon On Sale";
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Location = new System.Drawing.Point(54, 301);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(80, 13);
            this.lblAmountToPay.TabIndex = 26;
            this.lblAmountToPay.Text = "Amount To Pay";
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Location = new System.Drawing.Point(158, 298);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.ReadOnly = true;
            this.txtAmountToPay.Size = new System.Drawing.Size(129, 20);
            this.txtAmountToPay.TabIndex = 25;
            this.txtAmountToPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(91, 274);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 24;
            this.lblDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(165, 271);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(57, 20);
            this.txtDiscount.TabIndex = 21;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChamanderNoOfQty
            // 
            this.txtChamanderNoOfQty.Location = new System.Drawing.Point(165, 146);
            this.txtChamanderNoOfQty.Name = "txtChamanderNoOfQty";
            this.txtChamanderNoOfQty.Size = new System.Drawing.Size(57, 20);
            this.txtChamanderNoOfQty.TabIndex = 20;
            this.txtChamanderNoOfQty.Text = "0";
            this.txtChamanderNoOfQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSquirtleNoOfQty
            // 
            this.txtSquirtleNoOfQty.Location = new System.Drawing.Point(165, 109);
            this.txtSquirtleNoOfQty.Name = "txtSquirtleNoOfQty";
            this.txtSquirtleNoOfQty.Size = new System.Drawing.Size(57, 20);
            this.txtSquirtleNoOfQty.TabIndex = 19;
            this.txtSquirtleNoOfQty.Text = "0";
            this.txtSquirtleNoOfQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPikachuNoOfQty
            // 
            this.txtPikachuNoOfQty.Location = new System.Drawing.Point(165, 71);
            this.txtPikachuNoOfQty.Name = "txtPikachuNoOfQty";
            this.txtPikachuNoOfQty.Size = new System.Drawing.Size(57, 20);
            this.txtPikachuNoOfQty.TabIndex = 18;
            this.txtPikachuNoOfQty.Text = "0";
            this.txtPikachuNoOfQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pokemonForm
            // 
            this.AcceptButton = this.btnAmount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 374);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.btnAmount);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAmountToPay);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtChamanderNoOfQty);
            this.Controls.Add(this.txtSquirtleNoOfQty);
            this.Controls.Add(this.txtPikachuNoOfQty);
            this.Name = "pokemonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pokemonForm";
            this.Load += new System.EventHandler(this.pokemonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Button btnAmount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtChamanderNoOfQty;
        private System.Windows.Forms.TextBox txtSquirtleNoOfQty;
        private System.Windows.Forms.TextBox txtPikachuNoOfQty;
    }
}