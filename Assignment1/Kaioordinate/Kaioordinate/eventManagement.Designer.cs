namespace Kaioordinate
{
    partial class eventManagementFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eventManagementFrm));
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.datepickerDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.cmboxLocation = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtboxEventName = new System.Windows.Forms.TextBox();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxEventNameShow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxEventID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.lstboxEventName = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 40;
            this.btnCancel.Location = new System.Drawing.Point(339, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 48);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "  CANCEL";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // datepickerDate
            // 
            this.datepickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepickerDate.Location = new System.Drawing.Point(179, 162);
            this.datepickerDate.Name = "datepickerDate";
            this.datepickerDate.Size = new System.Drawing.Size(313, 28);
            this.datepickerDate.TabIndex = 32;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 40;
            this.btnSave.Location = new System.Drawing.Point(181, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 48);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "   SAVE";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmboxLocation
            // 
            this.cmboxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxLocation.FormattingEnabled = true;
            this.cmboxLocation.Location = new System.Drawing.Point(179, 94);
            this.cmboxLocation.Name = "cmboxLocation";
            this.cmboxLocation.Size = new System.Drawing.Size(313, 30);
            this.cmboxLocation.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(61, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Event Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(81, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Event Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.datepickerDate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cmboxLocation);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtboxEventName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(377, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 290);
            this.panel1.TabIndex = 39;
            this.panel1.Visible = false;
            // 
            // txtboxEventName
            // 
            this.txtboxEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEventName.Location = new System.Drawing.Point(179, 28);
            this.txtboxEventName.Name = "txtboxEventName";
            this.txtboxEventName.Size = new System.Drawing.Size(313, 28);
            this.txtboxEventName.TabIndex = 21;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDate.Location = new System.Drawing.Point(538, 226);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.ReadOnly = true;
            this.txtboxDate.Size = new System.Drawing.Size(313, 28);
            this.txtboxDate.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(405, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Event Date";
            // 
            // txtboxLocation
            // 
            this.txtboxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLocation.Location = new System.Drawing.Point(538, 158);
            this.txtboxLocation.Name = "txtboxLocation";
            this.txtboxLocation.ReadOnly = true;
            this.txtboxLocation.Size = new System.Drawing.Size(313, 28);
            this.txtboxLocation.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(421, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Locatioin";
            // 
            // txtboxEventNameShow
            // 
            this.txtboxEventNameShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEventNameShow.Location = new System.Drawing.Point(538, 90);
            this.txtboxEventNameShow.Name = "txtboxEventNameShow";
            this.txtboxEventNameShow.ReadOnly = true;
            this.txtboxEventNameShow.Size = new System.Drawing.Size(313, 28);
            this.txtboxEventNameShow.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(392, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Event Name";
            // 
            // txtboxEventID
            // 
            this.txtboxEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEventID.Location = new System.Drawing.Point(538, 22);
            this.txtboxEventID.Name = "txtboxEventID";
            this.txtboxEventID.ReadOnly = true;
            this.txtboxEventID.Size = new System.Drawing.Size(313, 28);
            this.txtboxEventID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(426, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Event ID";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 80;
            this.btnReturn.Location = new System.Drawing.Point(821, 339);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 140);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "\r\n\r\n\r\n\r\n\r\nRETURN";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 80;
            this.btnDelete.Location = new System.Drawing.Point(636, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 140);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "\r\n\r\n\r\n\r\n\r\nDELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 80;
            this.btnUpdate.Location = new System.Drawing.Point(483, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 140);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "\r\n\r\n\r\n\r\n\r\nUPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 80;
            this.btnAdd.Location = new System.Drawing.Point(330, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 140);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "\r\n\r\n\r\n\r\n\r\nADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.SquareCaretDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 80;
            this.btnDown.Location = new System.Drawing.Point(177, 339);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(140, 140);
            this.btnDown.TabIndex = 22;
            this.btnDown.Text = "\r\n\r\n\r\n\r\n\r\nDOWN";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 80;
            this.btnUp.Location = new System.Drawing.Point(24, 339);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(140, 140);
            this.btnUp.TabIndex = 21;
            this.btnUp.Text = "\r\n\r\n\r\n\r\n\r\nUP";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lstboxEventName
            // 
            this.lstboxEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxEventName.FormattingEnabled = true;
            this.lstboxEventName.ItemHeight = 22;
            this.lstboxEventName.Location = new System.Drawing.Point(20, 22);
            this.lstboxEventName.Name = "lstboxEventName";
            this.lstboxEventName.Size = new System.Drawing.Size(336, 268);
            this.lstboxEventName.TabIndex = 20;
            // 
            // eventManagementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxEventNameShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxEventID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lstboxEventName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eventManagementFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Management";
            this.Load += new System.EventHandler(this.eventManagementFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.DateTimePicker datepickerDate;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.ComboBox cmboxLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxEventNameShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxEventID;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnUp;
        private System.Windows.Forms.ListBox lstboxEventName;
        private System.Windows.Forms.TextBox txtboxEventName;
    }
}