
namespace ERAMSWinClientApp
{
    partial class frmCreditCardRegistrationMS
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.tbadrl1 = new System.Windows.Forms.TextBox();
            this.tbadrl2 = new System.Windows.Forms.TextBox();
            this.tbcity = new System.Windows.Forms.TextBox();
            this.cbstate = new System.Windows.Forms.ComboBox();
            this.tbzip = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.txtCreditCardLimit = new System.Windows.Forms.TextBox();
            this.txtCreditCardAvailableCredit = new System.Windows.Forms.TextBox();
            this.cbcas = new System.Windows.Forms.ComboBox();
            this.cbccmbn = new System.Windows.Forms.ComboBox();
            this.cbcibn = new System.Windows.Forms.ComboBox();
            this.cbcncn = new System.Windows.Forms.ComboBox();
            this.cbcpmscn = new System.Windows.Forms.ComboBox();
            this.tbcon = new System.Windows.Forms.TextBox();
            this.tbccn = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.caclbl = new System.Windows.Forms.Label();
            this.ccllbl = new System.Windows.Forms.Label();
            this.ctrlbl = new System.Windows.Forms.Label();
            this.ziplbl = new System.Windows.Forms.Label();
            this.stlbl = new System.Windows.Forms.Label();
            this.ctylbl = new System.Windows.Forms.Label();
            this.adrl2lbl = new System.Windows.Forms.Label();
            this.adrl1lbl = new System.Windows.Forms.Label();
            this.explbl = new System.Windows.Forms.Label();
            this.ccmbnlbl = new System.Windows.Forms.Label();
            this.cibnlbl = new System.Windows.Forms.Label();
            this.cncnlbl = new System.Windows.Forms.Label();
            this.cpmsclbl = new System.Windows.Forms.Label();
            this.conlbl = new System.Windows.Forms.Label();
            this.ccnlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clickReglbl = new System.Windows.Forms.Label();
            this.regbtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clrbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit Card Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpExpDate);
            this.groupBox1.Controls.Add(this.tbadrl1);
            this.groupBox1.Controls.Add(this.tbadrl2);
            this.groupBox1.Controls.Add(this.tbcity);
            this.groupBox1.Controls.Add(this.cbstate);
            this.groupBox1.Controls.Add(this.tbzip);
            this.groupBox1.Controls.Add(this.cbCountry);
            this.groupBox1.Controls.Add(this.txtCreditCardLimit);
            this.groupBox1.Controls.Add(this.txtCreditCardAvailableCredit);
            this.groupBox1.Controls.Add(this.cbcas);
            this.groupBox1.Controls.Add(this.cbccmbn);
            this.groupBox1.Controls.Add(this.cbcibn);
            this.groupBox1.Controls.Add(this.cbcncn);
            this.groupBox1.Controls.Add(this.cbcpmscn);
            this.groupBox1.Controls.Add(this.tbcon);
            this.groupBox1.Controls.Add(this.tbccn);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.caclbl);
            this.groupBox1.Controls.Add(this.ccllbl);
            this.groupBox1.Controls.Add(this.ctrlbl);
            this.groupBox1.Controls.Add(this.ziplbl);
            this.groupBox1.Controls.Add(this.stlbl);
            this.groupBox1.Controls.Add(this.ctylbl);
            this.groupBox1.Controls.Add(this.adrl2lbl);
            this.groupBox1.Controls.Add(this.adrl1lbl);
            this.groupBox1.Controls.Add(this.explbl);
            this.groupBox1.Controls.Add(this.ccmbnlbl);
            this.groupBox1.Controls.Add(this.cibnlbl);
            this.groupBox1.Controls.Add(this.cncnlbl);
            this.groupBox1.Controls.Add(this.cpmsclbl);
            this.groupBox1.Controls.Add(this.conlbl);
            this.groupBox1.Controls.Add(this.ccnlbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 556);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.CustomFormat = " ";
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDate.Location = new System.Drawing.Point(323, 250);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(171, 22);
            this.dtpExpDate.TabIndex = 32;
            // 
            // tbadrl1
            // 
            this.tbadrl1.Location = new System.Drawing.Point(323, 285);
            this.tbadrl1.Name = "tbadrl1";
            this.tbadrl1.Size = new System.Drawing.Size(170, 22);
            this.tbadrl1.TabIndex = 31;
            this.tbadrl1.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // tbadrl2
            // 
            this.tbadrl2.Location = new System.Drawing.Point(323, 313);
            this.tbadrl2.Name = "tbadrl2";
            this.tbadrl2.Size = new System.Drawing.Size(170, 22);
            this.tbadrl2.TabIndex = 30;
            this.tbadrl2.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // tbcity
            // 
            this.tbcity.Location = new System.Drawing.Point(323, 338);
            this.tbcity.Name = "tbcity";
            this.tbcity.Size = new System.Drawing.Size(170, 22);
            this.tbcity.TabIndex = 29;
            this.tbcity.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // cbstate
            // 
            this.cbstate.FormattingEnabled = true;
            this.cbstate.Location = new System.Drawing.Point(323, 363);
            this.cbstate.Name = "cbstate";
            this.cbstate.Size = new System.Drawing.Size(170, 24);
            this.cbstate.TabIndex = 28;
            this.cbstate.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // tbzip
            // 
            this.tbzip.Location = new System.Drawing.Point(323, 392);
            this.tbzip.Name = "tbzip";
            this.tbzip.Size = new System.Drawing.Size(170, 22);
            this.tbzip.TabIndex = 27;
            this.tbzip.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(323, 420);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(170, 24);
            this.cbCountry.TabIndex = 26;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // txtCreditCardLimit
            // 
            this.txtCreditCardLimit.Location = new System.Drawing.Point(323, 458);
            this.txtCreditCardLimit.Name = "txtCreditCardLimit";
            this.txtCreditCardLimit.Size = new System.Drawing.Size(171, 22);
            this.txtCreditCardLimit.TabIndex = 25;
            this.txtCreditCardLimit.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtCreditCardAvailableCredit
            // 
            this.txtCreditCardAvailableCredit.Location = new System.Drawing.Point(323, 486);
            this.txtCreditCardAvailableCredit.Name = "txtCreditCardAvailableCredit";
            this.txtCreditCardAvailableCredit.Size = new System.Drawing.Size(170, 22);
            this.txtCreditCardAvailableCredit.TabIndex = 24;
            this.txtCreditCardAvailableCredit.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cbcas
            // 
            this.cbcas.FormattingEnabled = true;
            this.cbcas.Location = new System.Drawing.Point(323, 513);
            this.cbcas.Name = "cbcas";
            this.cbcas.Size = new System.Drawing.Size(170, 24);
            this.cbcas.TabIndex = 23;
            this.cbcas.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // cbccmbn
            // 
            this.cbccmbn.FormattingEnabled = true;
            this.cbccmbn.Location = new System.Drawing.Point(323, 219);
            this.cbccmbn.Name = "cbccmbn";
            this.cbccmbn.Size = new System.Drawing.Size(170, 24);
            this.cbccmbn.TabIndex = 22;
            this.cbccmbn.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cbcibn
            // 
            this.cbcibn.FormattingEnabled = true;
            this.cbcibn.Location = new System.Drawing.Point(323, 192);
            this.cbcibn.Name = "cbcibn";
            this.cbcibn.Size = new System.Drawing.Size(170, 24);
            this.cbcibn.TabIndex = 21;
            this.cbcibn.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cbcncn
            // 
            this.cbcncn.FormattingEnabled = true;
            this.cbcncn.Location = new System.Drawing.Point(323, 164);
            this.cbcncn.Name = "cbcncn";
            this.cbcncn.Size = new System.Drawing.Size(170, 24);
            this.cbcncn.TabIndex = 20;
            this.cbcncn.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbcpmscn
            // 
            this.cbcpmscn.FormattingEnabled = true;
            this.cbcpmscn.Location = new System.Drawing.Point(323, 114);
            this.cbcpmscn.Name = "cbcpmscn";
            this.cbcpmscn.Size = new System.Drawing.Size(170, 24);
            this.cbcpmscn.TabIndex = 19;
            this.cbcpmscn.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbcon
            // 
            this.tbcon.Location = new System.Drawing.Point(323, 81);
            this.tbcon.Name = "tbcon";
            this.tbcon.Size = new System.Drawing.Size(171, 22);
            this.tbcon.TabIndex = 18;
            // 
            // tbccn
            // 
            this.tbccn.Location = new System.Drawing.Point(323, 51);
            this.tbccn.Name = "tbccn";
            this.tbccn.Size = new System.Drawing.Size(171, 22);
            this.tbccn.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 522);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(147, 17);
            this.label18.TabIndex = 16;
            this.label18.Text = "Card Activation Status";
            // 
            // caclbl
            // 
            this.caclbl.AutoSize = true;
            this.caclbl.Location = new System.Drawing.Point(6, 492);
            this.caclbl.Name = "caclbl";
            this.caclbl.Size = new System.Drawing.Size(140, 17);
            this.caclbl.TabIndex = 15;
            this.caclbl.Text = "Card Available Credit";
            // 
            // ccllbl
            // 
            this.ccllbl.AutoSize = true;
            this.ccllbl.Location = new System.Drawing.Point(6, 458);
            this.ccllbl.Name = "ccllbl";
            this.ccllbl.Size = new System.Drawing.Size(112, 17);
            this.ccllbl.TabIndex = 14;
            this.ccllbl.Text = "Credit Card Limit";
            // 
            // ctrlbl
            // 
            this.ctrlbl.AutoSize = true;
            this.ctrlbl.Location = new System.Drawing.Point(6, 429);
            this.ctrlbl.Name = "ctrlbl";
            this.ctrlbl.Size = new System.Drawing.Size(57, 17);
            this.ctrlbl.TabIndex = 13;
            this.ctrlbl.Text = "Country";
            this.ctrlbl.Click += new System.EventHandler(this.label15_Click);
            // 
            // ziplbl
            // 
            this.ziplbl.AutoSize = true;
            this.ziplbl.Location = new System.Drawing.Point(6, 398);
            this.ziplbl.Name = "ziplbl";
            this.ziplbl.Size = new System.Drawing.Size(65, 17);
            this.ziplbl.TabIndex = 12;
            this.ziplbl.Text = "Zip Code";
            // 
            // stlbl
            // 
            this.stlbl.AutoSize = true;
            this.stlbl.Location = new System.Drawing.Point(6, 372);
            this.stlbl.Name = "stlbl";
            this.stlbl.Size = new System.Drawing.Size(41, 17);
            this.stlbl.TabIndex = 11;
            this.stlbl.Text = "State";
            this.stlbl.Click += new System.EventHandler(this.label13_Click);
            // 
            // ctylbl
            // 
            this.ctylbl.AutoSize = true;
            this.ctylbl.Location = new System.Drawing.Point(6, 343);
            this.ctylbl.Name = "ctylbl";
            this.ctylbl.Size = new System.Drawing.Size(31, 17);
            this.ctylbl.TabIndex = 10;
            this.ctylbl.Text = "City";
            // 
            // adrl2lbl
            // 
            this.adrl2lbl.AutoSize = true;
            this.adrl2lbl.Location = new System.Drawing.Point(6, 313);
            this.adrl2lbl.Name = "adrl2lbl";
            this.adrl2lbl.Size = new System.Drawing.Size(103, 17);
            this.adrl2lbl.TabIndex = 9;
            this.adrl2lbl.Text = "Address Line 2";
            // 
            // adrl1lbl
            // 
            this.adrl1lbl.AutoSize = true;
            this.adrl1lbl.Location = new System.Drawing.Point(6, 283);
            this.adrl1lbl.Name = "adrl1lbl";
            this.adrl1lbl.Size = new System.Drawing.Size(103, 17);
            this.adrl1lbl.TabIndex = 8;
            this.adrl1lbl.Text = "Address Line 1";
            this.adrl1lbl.Click += new System.EventHandler(this.adrl1lbl_Click);
            // 
            // explbl
            // 
            this.explbl.AutoSize = true;
            this.explbl.Location = new System.Drawing.Point(6, 249);
            this.explbl.Name = "explbl";
            this.explbl.Size = new System.Drawing.Size(104, 17);
            this.explbl.TabIndex = 7;
            this.explbl.Text = "Expiration Date";
            // 
            // ccmbnlbl
            // 
            this.ccmbnlbl.AutoSize = true;
            this.ccmbnlbl.Location = new System.Drawing.Point(6, 219);
            this.ccmbnlbl.Name = "ccmbnlbl";
            this.ccmbnlbl.Size = new System.Drawing.Size(245, 17);
            this.ccmbnlbl.TabIndex = 6;
            this.ccmbnlbl.Text = "Card Corporate Merchant Bank Name";
            // 
            // cibnlbl
            // 
            this.cibnlbl.AutoSize = true;
            this.cibnlbl.Location = new System.Drawing.Point(6, 192);
            this.cibnlbl.Name = "cibnlbl";
            this.cibnlbl.Size = new System.Drawing.Size(163, 17);
            this.cibnlbl.TabIndex = 5;
            this.cibnlbl.Text = "Card Issuing Bank Name";
            // 
            // cncnlbl
            // 
            this.cncnlbl.AutoSize = true;
            this.cncnlbl.Location = new System.Drawing.Point(6, 164);
            this.cncnlbl.Name = "cncnlbl";
            this.cncnlbl.Size = new System.Drawing.Size(197, 17);
            this.cncnlbl.TabIndex = 4;
            this.cncnlbl.Text = "Card Network Company Name";
            // 
            // cpmsclbl
            // 
            this.cpmsclbl.AutoSize = true;
            this.cpmsclbl.Location = new System.Drawing.Point(6, 114);
            this.cpmsclbl.Name = "cpmsclbl";
            this.cpmsclbl.Size = new System.Drawing.Size(179, 34);
            this.cpmsclbl.TabIndex = 3;
            this.cpmsclbl.Text = "Card Processing Merchant \r\nService Company Name";
            // 
            // conlbl
            // 
            this.conlbl.AutoSize = true;
            this.conlbl.Location = new System.Drawing.Point(6, 81);
            this.conlbl.Name = "conlbl";
            this.conlbl.Size = new System.Drawing.Size(124, 17);
            this.conlbl.TabIndex = 2;
            this.conlbl.Text = "Card Owner Name";
            // 
            // ccnlbl
            // 
            this.ccnlbl.AutoSize = true;
            this.ccnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccnlbl.Location = new System.Drawing.Point(6, 56);
            this.ccnlbl.Name = "ccnlbl";
            this.ccnlbl.Size = new System.Drawing.Size(156, 17);
            this.ccnlbl.TabIndex = 1;
            this.ccnlbl.Text = "Credit Card Number ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Credit Card Information ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clickReglbl);
            this.groupBox2.Controls.Add(this.regbtn);
            this.groupBox2.Location = new System.Drawing.Point(569, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 556);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // clickReglbl
            // 
            this.clickReglbl.AutoSize = true;
            this.clickReglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickReglbl.Location = new System.Drawing.Point(6, 20);
            this.clickReglbl.Name = "clickReglbl";
            this.clickReglbl.Size = new System.Drawing.Size(184, 34);
            this.clickReglbl.TabIndex = 1;
            this.clickReglbl.Text = "Click Register to submit \r\nthe Credit Card";
            this.clickReglbl.Click += new System.EventHandler(this.clickReglbl_Click);
            // 
            // regbtn
            // 
            this.regbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbtn.Location = new System.Drawing.Point(36, 57);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(99, 29);
            this.regbtn.TabIndex = 0;
            this.regbtn.Text = "Register";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clrbtn);
            this.groupBox3.Controls.Add(this.exitbtn);
            this.groupBox3.Location = new System.Drawing.Point(25, 609);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(763, 42);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // clrbtn
            // 
            this.clrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrbtn.Location = new System.Drawing.Point(34, 13);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(75, 23);
            this.clrbtn.TabIndex = 1;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(524, 13);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 0;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // frmCreditCardRegistrationMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 658);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmCreditCardRegistrationMS";
            this.Text = "frmCreditCardRegistrationMS";
            this.Load += new System.EventHandler(this.frmCreditCardRegistrationMS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ctrlbl;
        private System.Windows.Forms.Label ziplbl;
        private System.Windows.Forms.Label stlbl;
        private System.Windows.Forms.Label ctylbl;
        private System.Windows.Forms.Label adrl2lbl;
        private System.Windows.Forms.Label adrl1lbl;
        private System.Windows.Forms.Label explbl;
        private System.Windows.Forms.Label ccmbnlbl;
        private System.Windows.Forms.Label cibnlbl;
        private System.Windows.Forms.Label cncnlbl;
        private System.Windows.Forms.Label cpmsclbl;
        private System.Windows.Forms.Label conlbl;
        private System.Windows.Forms.Label ccnlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label caclbl;
        private System.Windows.Forms.Label ccllbl;
        private System.Windows.Forms.TextBox tbadrl1;
        private System.Windows.Forms.TextBox tbadrl2;
        private System.Windows.Forms.TextBox tbcity;
        private System.Windows.Forms.ComboBox cbstate;
        private System.Windows.Forms.TextBox tbzip;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.TextBox txtCreditCardLimit;
        private System.Windows.Forms.TextBox txtCreditCardAvailableCredit;
        private System.Windows.Forms.ComboBox cbcas;
        private System.Windows.Forms.ComboBox cbccmbn;
        private System.Windows.Forms.ComboBox cbcibn;
        private System.Windows.Forms.ComboBox cbcncn;
        private System.Windows.Forms.ComboBox cbcpmscn;
        private System.Windows.Forms.TextBox tbcon;
        private System.Windows.Forms.TextBox tbccn;
        private System.Windows.Forms.Label clickReglbl;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
    }
}