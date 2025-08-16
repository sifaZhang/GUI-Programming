namespace Kaioordinate
{
    partial class kaiManagementFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kaiManagementFrm));
            this.lstboxKaiName = new System.Windows.Forms.ListBox();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxKaiID = new System.Windows.Forms.TextBox();
            this.txtboxEvent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxKaiNameShow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxPreparation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxTme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericTime = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.ckboxPreparation = new System.Windows.Forms.CheckBox();
            this.cmboxEvent = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxKaiName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lstboxKaiName
            // 
            this.lstboxKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxKaiName.FormattingEnabled = true;
            this.lstboxKaiName.ItemHeight = 42;
            this.lstboxKaiName.Location = new System.Drawing.Point(12, 40);
            this.lstboxKaiName.Name = "lstboxKaiName";
            this.lstboxKaiName.Size = new System.Drawing.Size(670, 550);
            this.lstboxKaiName.TabIndex = 0;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 150;
            this.btnUp.Location = new System.Drawing.Point(31, 659);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(280, 280);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "\r\n\r\n\r\n\r\n\r\nUP";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.SquareCaretDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 150;
            this.btnDown.Location = new System.Drawing.Point(327, 659);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(280, 280);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "\r\n\r\n\r\n\r\n\r\nDOWN";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 150;
            this.btnAdd.Location = new System.Drawing.Point(654, 659);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(280, 280);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "\r\n\r\n\r\n\r\n\r\nADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 150;
            this.btnUpdate.Location = new System.Drawing.Point(950, 659);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(280, 280);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "\r\n\r\n\r\n\r\n\r\nUPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 150;
            this.btnDelete.Location = new System.Drawing.Point(1246, 659);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(280, 280);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "\r\n\r\n\r\n\r\n\r\nDELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 150;
            this.btnReturn.Location = new System.Drawing.Point(1573, 659);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(280, 280);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "\r\n\r\n\r\n\r\n\r\nRETURN";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(922, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kai ID";
            // 
            // txtboxKaiID
            // 
            this.txtboxKaiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxKaiID.Location = new System.Drawing.Point(1064, 40);
            this.txtboxKaiID.Name = "txtboxKaiID";
            this.txtboxKaiID.ReadOnly = true;
            this.txtboxKaiID.Size = new System.Drawing.Size(669, 49);
            this.txtboxKaiID.TabIndex = 8;
            // 
            // txtboxEvent
            // 
            this.txtboxEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEvent.Location = new System.Drawing.Point(1064, 140);
            this.txtboxEvent.Name = "txtboxEvent";
            this.txtboxEvent.ReadOnly = true;
            this.txtboxEvent.Size = new System.Drawing.Size(669, 49);
            this.txtboxEvent.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(926, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Event";
            // 
            // txtboxKaiNameShow
            // 
            this.txtboxKaiNameShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxKaiNameShow.Location = new System.Drawing.Point(1064, 240);
            this.txtboxKaiNameShow.Name = "txtboxKaiNameShow";
            this.txtboxKaiNameShow.ReadOnly = true;
            this.txtboxKaiNameShow.Size = new System.Drawing.Size(669, 49);
            this.txtboxKaiNameShow.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(859, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kai Name";
            // 
            // txtboxPreparation
            // 
            this.txtboxPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPreparation.Location = new System.Drawing.Point(1064, 340);
            this.txtboxPreparation.Name = "txtboxPreparation";
            this.txtboxPreparation.ReadOnly = true;
            this.txtboxPreparation.Size = new System.Drawing.Size(669, 49);
            this.txtboxPreparation.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(808, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "Preparation?";
            // 
            // txtboxTme
            // 
            this.txtboxTme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTme.Location = new System.Drawing.Point(1064, 440);
            this.txtboxTme.Name = "txtboxTme";
            this.txtboxTme.ReadOnly = true;
            this.txtboxTme.Size = new System.Drawing.Size(669, 49);
            this.txtboxTme.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(737, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 42);
            this.label5.TabIndex = 15;
            this.label5.Text = "Preparation Time";
            // 
            // txtboxQuantity
            // 
            this.txtboxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxQuantity.Location = new System.Drawing.Point(1064, 540);
            this.txtboxQuantity.Name = "txtboxQuantity";
            this.txtboxQuantity.ReadOnly = true;
            this.txtboxQuantity.Size = new System.Drawing.Size(669, 49);
            this.txtboxQuantity.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(746, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 42);
            this.label6.TabIndex = 17;
            this.label6.Text = "Serving Quantity";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericTime);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.numericQuantity);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.ckboxPreparation);
            this.panel1.Controls.Add(this.cmboxEvent);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtboxKaiName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(705, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 605);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // numericTime
            // 
            this.numericTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTime.Location = new System.Drawing.Point(406, 313);
            this.numericTime.Name = "numericTime";
            this.numericTime.Size = new System.Drawing.Size(669, 49);
            this.numericTime.TabIndex = 35;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 100;
            this.btnCancel.Location = new System.Drawing.Point(777, 487);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(280, 100);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "   CANCEL";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numericQuantity
            // 
            this.numericQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuantity.Location = new System.Drawing.Point(406, 411);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(669, 49);
            this.numericQuantity.TabIndex = 33;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 100;
            this.btnSave.Location = new System.Drawing.Point(406, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 100);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "   SAVE";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ckboxPreparation
            // 
            this.ckboxPreparation.AutoSize = true;
            this.ckboxPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxPreparation.Location = new System.Drawing.Point(406, 237);
            this.ckboxPreparation.Name = "ckboxPreparation";
            this.ckboxPreparation.Size = new System.Drawing.Size(28, 27);
            this.ckboxPreparation.TabIndex = 27;
            this.ckboxPreparation.UseVisualStyleBackColor = true;
            // 
            // cmboxEvent
            // 
            this.cmboxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxEvent.FormattingEnabled = true;
            this.cmboxEvent.Location = new System.Drawing.Point(406, 40);
            this.cmboxEvent.Name = "cmboxEvent";
            this.cmboxEvent.Size = new System.Drawing.Size(669, 50);
            this.cmboxEvent.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(61, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(294, 42);
            this.label11.TabIndex = 25;
            this.label11.Text = "Serving Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(112, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 42);
            this.label10.TabIndex = 24;
            this.label10.Text = "Prepare Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(123, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 42);
            this.label9.TabIndex = 23;
            this.label9.Text = "Preparation?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(241, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 42);
            this.label8.TabIndex = 22;
            this.label8.Text = "Event";
            // 
            // txtboxKaiName
            // 
            this.txtboxKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxKaiName.Location = new System.Drawing.Point(406, 139);
            this.txtboxKaiName.Name = "txtboxKaiName";
            this.txtboxKaiName.Size = new System.Drawing.Size(669, 49);
            this.txtboxKaiName.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(174, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 42);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kai Name";
            // 
            // kaiManagementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1875, 966);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtboxQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxTme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxPreparation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxKaiNameShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxKaiID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lstboxKaiName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kaiManagementFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kai Management";
            this.Load += new System.EventHandler(this.kaiManagementFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxKaiName;
        private FontAwesome.Sharp.IconButton btnUp;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxKaiID;
        private System.Windows.Forms.TextBox txtboxEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxKaiNameShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxPreparation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxTme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxKaiName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckboxPreparation;
        private System.Windows.Forms.ComboBox cmboxEvent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.NumericUpDown numericTime;
    }
}