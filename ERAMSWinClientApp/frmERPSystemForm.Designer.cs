
namespace ERAMSWinClientApp
{
    partial class frmERPSystemForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCreditCardMS = new System.Windows.Forms.Button();
            this.btnVehicleInventoryMS = new System.Windows.Forms.Button();
            this.btnCRM = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnFinanceOperationsMS = new System.Windows.Forms.Button();
            this.btnMarketingMS = new System.Windows.Forms.Button();
            this.btnCustomerFieldServicesMS = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(229, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(378, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enterprise Resource Planning (ERP) System Portal";
            // 
            // btnCreditCardMS
            // 
            this.btnCreditCardMS.Location = new System.Drawing.Point(206, 67);
            this.btnCreditCardMS.Name = "btnCreditCardMS";
            this.btnCreditCardMS.Size = new System.Drawing.Size(435, 34);
            this.btnCreditCardMS.TabIndex = 1;
            this.btnCreditCardMS.Text = "Credit Card Management System";
            this.btnCreditCardMS.UseVisualStyleBackColor = true;
            this.btnCreditCardMS.Click += new System.EventHandler(this.btnCreditCardMS_Click);
            // 
            // btnVehicleInventoryMS
            // 
            this.btnVehicleInventoryMS.Location = new System.Drawing.Point(206, 107);
            this.btnVehicleInventoryMS.Name = "btnVehicleInventoryMS";
            this.btnVehicleInventoryMS.Size = new System.Drawing.Size(435, 38);
            this.btnVehicleInventoryMS.TabIndex = 2;
            this.btnVehicleInventoryMS.Text = "Vehicle Inventory Management System (Coming Soon)";
            this.btnVehicleInventoryMS.UseVisualStyleBackColor = true;
            this.btnVehicleInventoryMS.Click += new System.EventHandler(this.btnVehicleInventoryMS_Click);
            // 
            // btnCRM
            // 
            this.btnCRM.Location = new System.Drawing.Point(206, 151);
            this.btnCRM.Name = "btnCRM";
            this.btnCRM.Size = new System.Drawing.Size(435, 35);
            this.btnCRM.TabIndex = 4;
            this.btnCRM.Text = "Customer Relationship Management (CRM) System ";
            this.btnCRM.UseVisualStyleBackColor = true;
            this.btnCRM.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHR
            // 
            this.btnHR.Location = new System.Drawing.Point(206, 192);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(435, 35);
            this.btnHR.TabIndex = 5;
            this.btnHR.Text = "Human Resource Management System (Coming Soon)";
            this.btnHR.UseVisualStyleBackColor = true;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // btnFinanceOperationsMS
            // 
            this.btnFinanceOperationsMS.Location = new System.Drawing.Point(206, 233);
            this.btnFinanceOperationsMS.Name = "btnFinanceOperationsMS";
            this.btnFinanceOperationsMS.Size = new System.Drawing.Size(435, 35);
            this.btnFinanceOperationsMS.TabIndex = 6;
            this.btnFinanceOperationsMS.Text = "Finance && Operations Managment System (Coming Soon)";
            this.btnFinanceOperationsMS.UseVisualStyleBackColor = true;
            // 
            // btnMarketingMS
            // 
            this.btnMarketingMS.Location = new System.Drawing.Point(206, 274);
            this.btnMarketingMS.Name = "btnMarketingMS";
            this.btnMarketingMS.Size = new System.Drawing.Size(435, 35);
            this.btnMarketingMS.TabIndex = 7;
            this.btnMarketingMS.Text = "Marketing Management System (Coming Soon)";
            this.btnMarketingMS.UseVisualStyleBackColor = true;
            this.btnMarketingMS.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCustomerFieldServicesMS
            // 
            this.btnCustomerFieldServicesMS.Location = new System.Drawing.Point(206, 315);
            this.btnCustomerFieldServicesMS.Name = "btnCustomerFieldServicesMS";
            this.btnCustomerFieldServicesMS.Size = new System.Drawing.Size(435, 35);
            this.btnCustomerFieldServicesMS.TabIndex = 8;
            this.btnCustomerFieldServicesMS.Text = "Customer && Field Services Management System (Coming Soon)";
            this.btnCustomerFieldServicesMS.UseVisualStyleBackColor = true;
            this.btnCustomerFieldServicesMS.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(435, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = " Exit ERP";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmERPSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCustomerFieldServicesMS);
            this.Controls.Add(this.btnMarketingMS);
            this.Controls.Add(this.btnFinanceOperationsMS);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnCRM);
            this.Controls.Add(this.btnVehicleInventoryMS);
            this.Controls.Add(this.btnCreditCardMS);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmERPSystemForm";
            this.Text = "Enterprise Resource Planning (ERP) System Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreditCardMS;
        private System.Windows.Forms.Button btnCRM;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnFinanceOperationsMS;
        private System.Windows.Forms.Button btnMarketingMS;
        private System.Windows.Forms.Button btnCustomerFieldServicesMS;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnVehicleInventoryMS;
    }
}