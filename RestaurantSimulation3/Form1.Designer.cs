namespace RestaurantSimulation3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudChicken = new System.Windows.Forms.NumericUpDown();
            this.nudEgg = new System.Windows.Forms.NumericUpDown();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnServe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudChicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEgg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many chicken?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "How man egg?";
            // 
            // nudChicken
            // 
            this.nudChicken.Location = new System.Drawing.Point(173, 39);
            this.nudChicken.Name = "nudChicken";
            this.nudChicken.Size = new System.Drawing.Size(44, 20);
            this.nudChicken.TabIndex = 2;
            // 
            // nudEgg
            // 
            this.nudEgg.Location = new System.Drawing.Point(173, 79);
            this.nudEgg.Name = "nudEgg";
            this.nudEgg.Size = new System.Drawing.Size(44, 20);
            this.nudEgg.TabIndex = 3;
            // 
            // cmbDrink
            // 
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Location = new System.Drawing.Point(293, 56);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(121, 21);
            this.cmbDrink.TabIndex = 4;
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(152, 131);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(336, 30);
            this.btnReceive.TabIndex = 5;
            this.btnReceive.Text = "Receive this request from a Customer";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(152, 210);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(336, 30);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send all Customer requests to the Cook";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnServe
            // 
            this.btnServe.Location = new System.Drawing.Point(152, 293);
            this.btnServe.Name = "btnServe";
            this.btnServe.Size = new System.Drawing.Size(336, 30);
            this.btnServe.TabIndex = 7;
            this.btnServe.Text = "Serve prepared food to the Customers";
            this.btnServe.UseVisualStyleBackColor = true;
            this.btnServe.Click += new System.EventHandler(this.btnServe_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "How man egg?";
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.Info;
            this.txtResults.Location = new System.Drawing.Point(117, 430);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(569, 126);
            this.txtResults.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnServe);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.cmbDrink);
            this.Controls.Add(this.nudEgg);
            this.Controls.Add(this.nudChicken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudChicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEgg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudChicken;
        private System.Windows.Forms.NumericUpDown nudEgg;
        private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnServe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResults;
    }
}

