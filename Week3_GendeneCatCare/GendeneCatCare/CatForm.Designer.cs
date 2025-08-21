namespace GendeneCatCare
{
    partial class CatForm
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
            this.lstCats = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnUpdateCat = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblCatID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.txtDateofBirth = new System.Windows.Forms.TextBox();
            this.txtNeutered = new System.Windows.Forms.TextBox();
            this.lblNeutered = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddBreed = new System.Windows.Forms.Label();
            this.lblAddGender = new System.Windows.Forms.Label();
            this.lblAddDateOfBirth = new System.Windows.Forms.Label();
            this.lblAddNeutered = new System.Windows.Forms.Label();
            this.lblAddOwnerID = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddBreed = new System.Windows.Forms.TextBox();
            this.dtpAddDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cboAddGender = new System.Windows.Forms.ComboBox();
            this.cboAddOwnerID = new System.Windows.Forms.ComboBox();
            this.cboAddOwnerName = new System.Windows.Forms.ComboBox();
            this.cbxAddNeutered = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.pnlAddCat = new System.Windows.Forms.Panel();
            this.pnlAddCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCats
            // 
            this.lstCats.FormattingEnabled = true;
            this.lstCats.ItemHeight = 25;
            this.lstCats.Location = new System.Drawing.Point(18, 37);
            this.lstCats.Name = "lstCats";
            this.lstCats.Size = new System.Drawing.Size(373, 454);
            this.lstCats.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(13, 556);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(156, 38);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(175, 556);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(156, 38);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(337, 556);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(156, 38);
            this.btnAddCat.TabIndex = 3;
            this.btnAddCat.Text = "Add Cat";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnUpdateCat
            // 
            this.btnUpdateCat.Location = new System.Drawing.Point(499, 556);
            this.btnUpdateCat.Name = "btnUpdateCat";
            this.btnUpdateCat.Size = new System.Drawing.Size(156, 38);
            this.btnUpdateCat.TabIndex = 4;
            this.btnUpdateCat.Text = "Update Cat";
            this.btnUpdateCat.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Location = new System.Drawing.Point(661, 556);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(156, 38);
            this.btnDeleteCat.TabIndex = 5;
            this.btnDeleteCat.Text = "Delete Cat";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(661, 627);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(156, 38);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.Location = new System.Drawing.Point(466, 40);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(77, 25);
            this.lblCatID.TabIndex = 7;
            this.lblCatID.Text = "Cat ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(469, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(454, 250);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 25);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender:";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(468, 180);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(75, 25);
            this.lblBreed.TabIndex = 9;
            this.lblBreed.Text = "Breed:";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(437, 460);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(106, 25);
            this.lblOwnerID.TabIndex = 12;
            this.lblOwnerID.Text = "Owner ID:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(414, 320);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(129, 25);
            this.lblDateOfBirth.TabIndex = 11;
            this.lblDateOfBirth.Text = "DateOfBirth:";
            // 
            // txtCatID
            // 
            this.txtCatID.Location = new System.Drawing.Point(564, 37);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(173, 31);
            this.txtCatID.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(564, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 31);
            this.txtName.TabIndex = 14;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(564, 247);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(173, 31);
            this.txtGender.TabIndex = 16;
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(564, 177);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(173, 31);
            this.txtBreed.TabIndex = 15;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(564, 457);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(173, 31);
            this.txtOwnerID.TabIndex = 18;
            this.txtOwnerID.TextChanged += new System.EventHandler(this.txtOwnerID_TextChanged);
            // 
            // txtDateofBirth
            // 
            this.txtDateofBirth.Location = new System.Drawing.Point(564, 317);
            this.txtDateofBirth.Name = "txtDateofBirth";
            this.txtDateofBirth.Size = new System.Drawing.Size(173, 31);
            this.txtDateofBirth.TabIndex = 17;
            // 
            // txtNeutered
            // 
            this.txtNeutered.Location = new System.Drawing.Point(564, 387);
            this.txtNeutered.Name = "txtNeutered";
            this.txtNeutered.Size = new System.Drawing.Size(173, 31);
            this.txtNeutered.TabIndex = 21;
            // 
            // lblNeutered
            // 
            this.lblNeutered.AutoSize = true;
            this.lblNeutered.Location = new System.Drawing.Point(437, 390);
            this.lblNeutered.Name = "lblNeutered";
            this.lblNeutered.Size = new System.Drawing.Size(106, 25);
            this.lblNeutered.TabIndex = 20;
            this.lblNeutered.Text = "Neutered:";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(743, 463);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(0, 25);
            this.lblOwnerName.TabIndex = 22;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(90, 23);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(74, 25);
            this.lblAddName.TabIndex = 0;
            this.lblAddName.Text = "Name:";
            // 
            // lblAddBreed
            // 
            this.lblAddBreed.AutoSize = true;
            this.lblAddBreed.Location = new System.Drawing.Point(89, 96);
            this.lblAddBreed.Name = "lblAddBreed";
            this.lblAddBreed.Size = new System.Drawing.Size(75, 25);
            this.lblAddBreed.TabIndex = 1;
            this.lblAddBreed.Text = "Breed:";
            // 
            // lblAddGender
            // 
            this.lblAddGender.AutoSize = true;
            this.lblAddGender.Location = new System.Drawing.Point(75, 169);
            this.lblAddGender.Name = "lblAddGender";
            this.lblAddGender.Size = new System.Drawing.Size(89, 25);
            this.lblAddGender.TabIndex = 2;
            this.lblAddGender.Text = "Gender:";
            // 
            // lblAddDateOfBirth
            // 
            this.lblAddDateOfBirth.AutoSize = true;
            this.lblAddDateOfBirth.Location = new System.Drawing.Point(35, 242);
            this.lblAddDateOfBirth.Name = "lblAddDateOfBirth";
            this.lblAddDateOfBirth.Size = new System.Drawing.Size(129, 25);
            this.lblAddDateOfBirth.TabIndex = 3;
            this.lblAddDateOfBirth.Text = "DateOfBirth:";
            // 
            // lblAddNeutered
            // 
            this.lblAddNeutered.AutoSize = true;
            this.lblAddNeutered.Location = new System.Drawing.Point(58, 315);
            this.lblAddNeutered.Name = "lblAddNeutered";
            this.lblAddNeutered.Size = new System.Drawing.Size(106, 25);
            this.lblAddNeutered.TabIndex = 4;
            this.lblAddNeutered.Text = "Neutered:";
            // 
            // lblAddOwnerID
            // 
            this.lblAddOwnerID.AutoSize = true;
            this.lblAddOwnerID.Location = new System.Drawing.Point(58, 388);
            this.lblAddOwnerID.Name = "lblAddOwnerID";
            this.lblAddOwnerID.Size = new System.Drawing.Size(106, 25);
            this.lblAddOwnerID.TabIndex = 5;
            this.lblAddOwnerID.Text = "Owner ID:";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(216, 23);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(260, 31);
            this.txtAddName.TabIndex = 20;
            // 
            // txtAddBreed
            // 
            this.txtAddBreed.Location = new System.Drawing.Point(216, 94);
            this.txtAddBreed.Name = "txtAddBreed";
            this.txtAddBreed.Size = new System.Drawing.Size(260, 31);
            this.txtAddBreed.TabIndex = 21;
            // 
            // dtpAddDateOfBirth
            // 
            this.dtpAddDateOfBirth.Location = new System.Drawing.Point(216, 238);
            this.dtpAddDateOfBirth.Name = "dtpAddDateOfBirth";
            this.dtpAddDateOfBirth.Size = new System.Drawing.Size(260, 31);
            this.dtpAddDateOfBirth.TabIndex = 22;
            // 
            // cboAddGender
            // 
            this.cboAddGender.FormattingEnabled = true;
            this.cboAddGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboAddGender.Location = new System.Drawing.Point(216, 165);
            this.cboAddGender.Name = "cboAddGender";
            this.cboAddGender.Size = new System.Drawing.Size(260, 33);
            this.cboAddGender.TabIndex = 23;
            this.cboAddGender.Text = "Male";
            // 
            // cboAddOwnerID
            // 
            this.cboAddOwnerID.FormattingEnabled = true;
            this.cboAddOwnerID.Location = new System.Drawing.Point(216, 378);
            this.cboAddOwnerID.Name = "cboAddOwnerID";
            this.cboAddOwnerID.Size = new System.Drawing.Size(132, 33);
            this.cboAddOwnerID.TabIndex = 24;
            // 
            // cboAddOwnerName
            // 
            this.cboAddOwnerName.FormattingEnabled = true;
            this.cboAddOwnerName.Location = new System.Drawing.Point(369, 378);
            this.cboAddOwnerName.Name = "cboAddOwnerName";
            this.cboAddOwnerName.Size = new System.Drawing.Size(132, 33);
            this.cboAddOwnerName.TabIndex = 25;
            // 
            // cbxAddNeutered
            // 
            this.cbxAddNeutered.AutoSize = true;
            this.cbxAddNeutered.Location = new System.Drawing.Point(216, 309);
            this.cbxAddNeutered.Name = "cbxAddNeutered";
            this.cbxAddNeutered.Size = new System.Drawing.Size(28, 27);
            this.cbxAddNeutered.TabIndex = 26;
            this.cbxAddNeutered.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(63, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 38);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.Location = new System.Drawing.Point(339, 445);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(156, 38);
            this.btnSaveCat.TabIndex = 28;
            this.btnSaveCat.Text = "Save Cat";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // pnlAddCat
            // 
            this.pnlAddCat.Controls.Add(this.btnSaveCat);
            this.pnlAddCat.Controls.Add(this.btnCancel);
            this.pnlAddCat.Controls.Add(this.cbxAddNeutered);
            this.pnlAddCat.Controls.Add(this.cboAddOwnerName);
            this.pnlAddCat.Controls.Add(this.cboAddOwnerID);
            this.pnlAddCat.Controls.Add(this.cboAddGender);
            this.pnlAddCat.Controls.Add(this.dtpAddDateOfBirth);
            this.pnlAddCat.Controls.Add(this.txtAddBreed);
            this.pnlAddCat.Controls.Add(this.txtAddName);
            this.pnlAddCat.Controls.Add(this.lblAddOwnerID);
            this.pnlAddCat.Controls.Add(this.lblAddNeutered);
            this.pnlAddCat.Controls.Add(this.lblAddDateOfBirth);
            this.pnlAddCat.Controls.Add(this.lblAddGender);
            this.pnlAddCat.Controls.Add(this.lblAddBreed);
            this.pnlAddCat.Controls.Add(this.lblAddName);
            this.pnlAddCat.Location = new System.Drawing.Point(849, 12);
            this.pnlAddCat.Name = "pnlAddCat";
            this.pnlAddCat.Size = new System.Drawing.Size(536, 508);
            this.pnlAddCat.TabIndex = 19;
            this.pnlAddCat.Visible = false;
            // 
            // CatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 704);
            this.Controls.Add(this.pnlAddCat);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.txtNeutered);
            this.Controls.Add(this.lblNeutered);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.txtDateofBirth);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCatID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteCat);
            this.Controls.Add(this.btnUpdateCat);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstCats);
            this.Name = "CatForm";
            this.Text = "Cat Maintenance";
            this.pnlAddCat.ResumeLayout(false);
            this.pnlAddCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCats;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button btnUpdateCat;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblCatID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.TextBox txtDateofBirth;
        private System.Windows.Forms.TextBox txtNeutered;
        private System.Windows.Forms.Label lblNeutered;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddBreed;
        private System.Windows.Forms.Label lblAddGender;
        private System.Windows.Forms.Label lblAddDateOfBirth;
        private System.Windows.Forms.Label lblAddNeutered;
        private System.Windows.Forms.Label lblAddOwnerID;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddBreed;
        private System.Windows.Forms.DateTimePicker dtpAddDateOfBirth;
        private System.Windows.Forms.ComboBox cboAddGender;
        private System.Windows.Forms.ComboBox cboAddOwnerID;
        private System.Windows.Forms.ComboBox cboAddOwnerName;
        private System.Windows.Forms.CheckBox cbxAddNeutered;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveCat;
        private System.Windows.Forms.Panel pnlAddCat;
    }
}