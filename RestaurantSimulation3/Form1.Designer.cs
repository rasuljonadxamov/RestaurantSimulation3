namespace RestaurantSimulation3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1           = new System.Windows.Forms.Label();
            this.label2           = new System.Windows.Forms.Label();
            this.nudChicken       = new System.Windows.Forms.NumericUpDown();
            this.nudEgg           = new System.Windows.Forms.NumericUpDown();
            this.cmbDrink         = new System.Windows.Forms.ComboBox();
            this.btnReceive       = new System.Windows.Forms.Button();
            this.btnSend          = new System.Windows.Forms.Button();
            this.label3           = new System.Windows.Forms.Label();
            this.eggQuality       = new System.Windows.Forms.TextBox();
            this.label4           = new System.Windows.Forms.Label();
            this.txtResults       = new System.Windows.Forms.TextBox();
            this.txtCustomerName  = new System.Windows.Forms.TextBox();
            this.groupBox1        = new System.Windows.Forms.GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.nudChicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEgg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // label1 – "How many chicken?"
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name     = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text     = "How many chicken?";

            // label2 – "How many egg?"
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name     = "label2";
            this.label2.TabIndex = 1;
            this.label2.Text     = "How many egg?";

            // nudChicken
            this.nudChicken.Location = new System.Drawing.Point(167, 36);
            this.nudChicken.Name     = "nudChicken";
            this.nudChicken.Size     = new System.Drawing.Size(44, 20);
            this.nudChicken.TabIndex = 2;

            // nudEgg
            this.nudEgg.Location = new System.Drawing.Point(167, 76);
            this.nudEgg.Name     = "nudEgg";
            this.nudEgg.Size     = new System.Drawing.Size(44, 20);
            this.nudEgg.TabIndex = 3;

            // cmbDrink
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Location          = new System.Drawing.Point(287, 53);
            this.cmbDrink.Name              = "cmbDrink";
            this.cmbDrink.Size              = new System.Drawing.Size(121, 21);
            this.cmbDrink.TabIndex          = 4;

            // btnReceive
            this.btnReceive.Location              = new System.Drawing.Point(38, 113);
            this.btnReceive.Name                  = "btnReceive";
            this.btnReceive.Size                  = new System.Drawing.Size(252, 30);
            this.btnReceive.TabIndex              = 5;
            this.btnReceive.Text                  = "Receive this request from:";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click                 += new System.EventHandler(this.btnReceive_Click);

            // txtCustomerName
            this.txtCustomerName.Location  = new System.Drawing.Point(296, 113);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name      = "txtCustomerName";
            this.txtCustomerName.Size      = new System.Drawing.Size(112, 30);
            this.txtCustomerName.TabIndex  = 6;

            // groupBox1 – Menu
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudChicken);
            this.groupBox1.Controls.Add(this.nudEgg);
            this.groupBox1.Controls.Add(this.cmbDrink);
            this.groupBox1.Controls.Add(this.btnReceive);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name     = "groupBox1";
            this.groupBox1.Size     = new System.Drawing.Size(587, 165);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop  = false;
            this.groupBox1.Text     = "Menu";

            // label3 – "Egg Quality:"
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name     = "label3";
            this.label3.TabIndex = 8;
            this.label3.Text     = "Egg Quality:";

            // eggQuality
            this.eggQuality.Location = new System.Drawing.Point(99, 202);
            this.eggQuality.Name     = "eggQuality";
            this.eggQuality.Size     = new System.Drawing.Size(49, 20);
            this.eggQuality.TabIndex = 9;

            // btnSend
            this.btnSend.Location               = new System.Drawing.Point(152, 240);
            this.btnSend.Name                   = "btnSend";
            this.btnSend.Size                   = new System.Drawing.Size(336, 30);
            this.btnSend.TabIndex               = 10;
            this.btnSend.Text                   = "Send all Customer requests to the Cook";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click                  += new System.EventHandler(this.btnSend_Click);

            // label4 – "Results"
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 295);
            this.label4.Name     = "label4";
            this.label4.TabIndex = 11;
            this.label4.Text     = "Results";

            // txtResults
            this.txtResults.BackColor = System.Drawing.SystemColors.Info;
            this.txtResults.Location  = new System.Drawing.Point(47, 320);
            this.txtResults.Multiline = true;
            this.txtResults.Name      = "txtResults";
            this.txtResults.ReadOnly  = true;
            this.txtResults.Size      = new System.Drawing.Size(549, 172);
            this.txtResults.TabIndex  = 12;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(611, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eggQuality);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResults);
            this.Name = "Form1";
            this.Text = "My Restaurant";

            ((System.ComponentModel.ISupportInitialize)(this.nudChicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEgg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label          label1;
        private System.Windows.Forms.Label          label2;
        private System.Windows.Forms.NumericUpDown  nudChicken;
        private System.Windows.Forms.NumericUpDown  nudEgg;
        private System.Windows.Forms.ComboBox       cmbDrink;
        private System.Windows.Forms.Button         btnReceive;
        private System.Windows.Forms.Button         btnSend;
        private System.Windows.Forms.Label          label3;
        private System.Windows.Forms.TextBox        eggQuality;
        private System.Windows.Forms.Label          label4;
        private System.Windows.Forms.TextBox        txtResults;
        private System.Windows.Forms.TextBox        txtCustomerName;
        private System.Windows.Forms.GroupBox       groupBox1;
    }
}
