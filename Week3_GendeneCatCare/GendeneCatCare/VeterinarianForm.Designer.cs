namespace GendeneCatCare
{
    partial class VeterinarianForm
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
            this.lstVeterinarians = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnUpdateVeterinarian = new System.Windows.Forms.Button();
            this.btnAddVeterinarian = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteVeterinarian = new System.Windows.Forms.Button();
            this.lblVeterinarianNo = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblVeterinarianID = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstVeterinarians
            // 
            this.lstVeterinarians.FormattingEnabled = true;
            this.lstVeterinarians.ItemHeight = 25;
            this.lstVeterinarians.Location = new System.Drawing.Point(61, 67);
            this.lstVeterinarians.Name = "lstVeterinarians";
            this.lstVeterinarians.Size = new System.Drawing.Size(489, 579);
            this.lstVeterinarians.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(61, 718);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(160, 55);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(273, 718);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(160, 55);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnUpdateVeterinarian
            // 
            this.btnUpdateVeterinarian.Location = new System.Drawing.Point(752, 718);
            this.btnUpdateVeterinarian.Name = "btnUpdateVeterinarian";
            this.btnUpdateVeterinarian.Size = new System.Drawing.Size(235, 55);
            this.btnUpdateVeterinarian.TabIndex = 4;
            this.btnUpdateVeterinarian.Text = "Update Veterinarian";
            this.btnUpdateVeterinarian.UseVisualStyleBackColor = true;
            this.btnUpdateVeterinarian.Click += new System.EventHandler(this.btnUpdateVeterinarian_Click);
            // 
            // btnAddVeterinarian
            // 
            this.btnAddVeterinarian.Location = new System.Drawing.Point(485, 718);
            this.btnAddVeterinarian.Name = "btnAddVeterinarian";
            this.btnAddVeterinarian.Size = new System.Drawing.Size(215, 55);
            this.btnAddVeterinarian.TabIndex = 3;
            this.btnAddVeterinarian.Text = "Add Veterinarian";
            this.btnAddVeterinarian.UseVisualStyleBackColor = true;
            this.btnAddVeterinarian.Click += new System.EventHandler(this.btnAddVeterinarian_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1116, 800);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 55);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteVeterinarian
            // 
            this.btnDeleteVeterinarian.Location = new System.Drawing.Point(1039, 718);
            this.btnDeleteVeterinarian.Name = "btnDeleteVeterinarian";
            this.btnDeleteVeterinarian.Size = new System.Drawing.Size(234, 55);
            this.btnDeleteVeterinarian.TabIndex = 5;
            this.btnDeleteVeterinarian.Text = "Delete Veterinarian";
            this.btnDeleteVeterinarian.UseVisualStyleBackColor = true;
            this.btnDeleteVeterinarian.Click += new System.EventHandler(this.btnDeleteVeterinarian_Click);
            // 
            // lblVeterinarianNo
            // 
            this.lblVeterinarianNo.AutoSize = true;
            this.lblVeterinarianNo.Location = new System.Drawing.Point(641, 101);
            this.lblVeterinarianNo.Name = "lblVeterinarianNo";
            this.lblVeterinarianNo.Size = new System.Drawing.Size(160, 25);
            this.lblVeterinarianNo.TabIndex = 7;
            this.lblVeterinarianNo.Text = "Veterinarian ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(680, 233);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(121, 25);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(679, 365);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 25);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(738, 497);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(63, 25);
            this.lblRate.TabIndex = 10;
            this.lblRate.Text = "Rate:";
            // 
            // lblVeterinarianID
            // 
            this.lblVeterinarianID.AutoSize = true;
            this.lblVeterinarianID.Location = new System.Drawing.Point(867, 101);
            this.lblVeterinarianID.Name = "lblVeterinarianID";
            this.lblVeterinarianID.Size = new System.Drawing.Size(0, 25);
            this.lblVeterinarianID.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(867, 227);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 31);
            this.txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(867, 359);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 31);
            this.txtFirstName.TabIndex = 13;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(867, 491);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 31);
            this.txtRate.TabIndex = 14;
            // 
            // VeterinarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 886);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblVeterinarianID);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblVeterinarianNo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVeterinarian);
            this.Controls.Add(this.btnUpdateVeterinarian);
            this.Controls.Add(this.btnAddVeterinarian);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstVeterinarians);
            this.Name = "VeterinarianForm";
            this.Text = "Veterinarian Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVeterinarians;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnUpdateVeterinarian;
        private System.Windows.Forms.Button btnAddVeterinarian;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteVeterinarian;
        private System.Windows.Forms.Label lblVeterinarianNo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblVeterinarianID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtRate;
    }
}