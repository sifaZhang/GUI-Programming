namespace Kaioordinate
{
    partial class locationManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_address = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBox_locationName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.iconButton_cancel = new FontAwesome.Sharp.IconButton();
            this.iconButton_save = new FontAwesome.Sharp.IconButton();
            this.txtBox_addressShow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_locationNameShow = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_locationID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton_return = new FontAwesome.Sharp.IconButton();
            this.iconButton_delete = new FontAwesome.Sharp.IconButton();
            this.iconButton_update = new FontAwesome.Sharp.IconButton();
            this.iconButton_add = new FontAwesome.Sharp.IconButton();
            this.iconButton_down = new FontAwesome.Sharp.IconButton();
            this.iconButton_up = new FontAwesome.Sharp.IconButton();
            this.listBox_locationName = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBox_address);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtBox_locationName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.iconButton_cancel);
            this.panel1.Controls.Add(this.iconButton_save);
            this.panel1.Location = new System.Drawing.Point(701, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 580);
            this.panel1.TabIndex = 87;
            this.panel1.Visible = false;
            // 
            // txtBox_address
            // 
            this.txtBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_address.Location = new System.Drawing.Point(338, 199);
            this.txtBox_address.Multiline = true;
            this.txtBox_address.Name = "txtBox_address";
            this.txtBox_address.Size = new System.Drawing.Size(669, 212);
            this.txtBox_address.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(149, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 42);
            this.label12.TabIndex = 51;
            this.label12.Text = "Address";
            // 
            // txtBox_locationName
            // 
            this.txtBox_locationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_locationName.Location = new System.Drawing.Point(338, 86);
            this.txtBox_locationName.Name = "txtBox_locationName";
            this.txtBox_locationName.Size = new System.Drawing.Size(669, 49);
            this.txtBox_locationName.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(36, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(269, 42);
            this.label11.TabIndex = 47;
            this.label11.Text = "Location Name";
            // 
            // iconButton_cancel
            // 
            this.iconButton_cancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_cancel.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton_cancel.IconColor = System.Drawing.Color.Black;
            this.iconButton_cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_cancel.IconSize = 100;
            this.iconButton_cancel.Location = new System.Drawing.Point(709, 461);
            this.iconButton_cancel.Name = "iconButton_cancel";
            this.iconButton_cancel.Size = new System.Drawing.Size(280, 100);
            this.iconButton_cancel.TabIndex = 46;
            this.iconButton_cancel.Text = "  CANCEL";
            this.iconButton_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_cancel.UseVisualStyleBackColor = true;
            this.iconButton_cancel.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton_save
            // 
            this.iconButton_save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_save.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButton_save.IconColor = System.Drawing.Color.Black;
            this.iconButton_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_save.IconSize = 100;
            this.iconButton_save.Location = new System.Drawing.Point(338, 464);
            this.iconButton_save.Name = "iconButton_save";
            this.iconButton_save.Size = new System.Drawing.Size(280, 100);
            this.iconButton_save.TabIndex = 45;
            this.iconButton_save.Text = "   SAVE";
            this.iconButton_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_save.UseVisualStyleBackColor = true;
            this.iconButton_save.Click += new System.EventHandler(this.iconButton_save_Click);
            // 
            // txtBox_addressShow
            // 
            this.txtBox_addressShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_addressShow.Location = new System.Drawing.Point(1076, 324);
            this.txtBox_addressShow.Multiline = true;
            this.txtBox_addressShow.Name = "txtBox_addressShow";
            this.txtBox_addressShow.Size = new System.Drawing.Size(669, 199);
            this.txtBox_addressShow.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(886, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 42);
            this.label3.TabIndex = 85;
            this.label3.Text = "Address";
            // 
            // txtBox_locationNameShow
            // 
            this.txtBox_locationNameShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_locationNameShow.Location = new System.Drawing.Point(1076, 182);
            this.txtBox_locationNameShow.Name = "txtBox_locationNameShow";
            this.txtBox_locationNameShow.Size = new System.Drawing.Size(669, 49);
            this.txtBox_locationNameShow.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(773, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 42);
            this.label8.TabIndex = 77;
            this.label8.Text = "Location Name";
            // 
            // txtBox_locationID
            // 
            this.txtBox_locationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_locationID.Location = new System.Drawing.Point(1076, 40);
            this.txtBox_locationID.Name = "txtBox_locationID";
            this.txtBox_locationID.Size = new System.Drawing.Size(669, 49);
            this.txtBox_locationID.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(836, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 42);
            this.label1.TabIndex = 75;
            this.label1.Text = "Location ID";
            // 
            // iconButton_return
            // 
            this.iconButton_return.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton_return.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_return.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.iconButton_return.IconColor = System.Drawing.Color.Black;
            this.iconButton_return.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_return.IconSize = 150;
            this.iconButton_return.Location = new System.Drawing.Point(1518, 641);
            this.iconButton_return.Name = "iconButton_return";
            this.iconButton_return.Size = new System.Drawing.Size(280, 280);
            this.iconButton_return.TabIndex = 74;
            this.iconButton_return.Text = "\r\n\r\n\r\n\r\n\r\nRETURN";
            this.iconButton_return.UseVisualStyleBackColor = false;
            this.iconButton_return.Click += new System.EventHandler(this.iconButton_reture_Click);
            // 
            // iconButton_delete
            // 
            this.iconButton_delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton_delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton_delete.IconColor = System.Drawing.Color.Black;
            this.iconButton_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_delete.IconSize = 150;
            this.iconButton_delete.Location = new System.Drawing.Point(1210, 641);
            this.iconButton_delete.Name = "iconButton_delete";
            this.iconButton_delete.Size = new System.Drawing.Size(280, 280);
            this.iconButton_delete.TabIndex = 73;
            this.iconButton_delete.Text = "\r\n\r\n\r\n\r\n\r\nDELETE";
            this.iconButton_delete.UseVisualStyleBackColor = false;
            this.iconButton_delete.Click += new System.EventHandler(this.iconButton_delete_Click);
            // 
            // iconButton_update
            // 
            this.iconButton_update.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton_update.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_update.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton_update.IconColor = System.Drawing.Color.Black;
            this.iconButton_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_update.IconSize = 150;
            this.iconButton_update.Location = new System.Drawing.Point(919, 641);
            this.iconButton_update.Name = "iconButton_update";
            this.iconButton_update.Size = new System.Drawing.Size(280, 280);
            this.iconButton_update.TabIndex = 72;
            this.iconButton_update.Text = "\r\n\r\n\r\n\r\n\r\nUPDATE";
            this.iconButton_update.UseVisualStyleBackColor = false;
            this.iconButton_update.Click += new System.EventHandler(this.iconButton_update_Click);
            // 
            // iconButton_add
            // 
            this.iconButton_add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton_add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton_add.IconColor = System.Drawing.Color.Black;
            this.iconButton_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_add.IconSize = 150;
            this.iconButton_add.Location = new System.Drawing.Point(629, 641);
            this.iconButton_add.Name = "iconButton_add";
            this.iconButton_add.Size = new System.Drawing.Size(280, 280);
            this.iconButton_add.TabIndex = 71;
            this.iconButton_add.Text = "\r\n\r\n\r\n\r\n\r\nADD";
            this.iconButton_add.UseVisualStyleBackColor = false;
            this.iconButton_add.Click += new System.EventHandler(this.iconButton_add_Click);
            // 
            // iconButton_down
            // 
            this.iconButton_down.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton_down.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_down.IconChar = FontAwesome.Sharp.IconChar.SquareCaretDown;
            this.iconButton_down.IconColor = System.Drawing.Color.Black;
            this.iconButton_down.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_down.IconSize = 150;
            this.iconButton_down.Location = new System.Drawing.Point(310, 641);
            this.iconButton_down.Name = "iconButton_down";
            this.iconButton_down.Size = new System.Drawing.Size(280, 280);
            this.iconButton_down.TabIndex = 70;
            this.iconButton_down.Text = "\r\n\r\n\r\n\r\n\r\nDOWN";
            this.iconButton_down.UseVisualStyleBackColor = false;
            this.iconButton_down.Click += new System.EventHandler(this.iconButton_down_Click);
            // 
            // iconButton_up
            // 
            this.iconButton_up.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton_up.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_up.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.iconButton_up.IconColor = System.Drawing.Color.Black;
            this.iconButton_up.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_up.IconSize = 150;
            this.iconButton_up.Location = new System.Drawing.Point(20, 641);
            this.iconButton_up.Name = "iconButton_up";
            this.iconButton_up.Size = new System.Drawing.Size(280, 280);
            this.iconButton_up.TabIndex = 69;
            this.iconButton_up.Text = "\r\n\r\n\r\n\r\n\r\nUP";
            this.iconButton_up.UseVisualStyleBackColor = false;
            this.iconButton_up.Click += new System.EventHandler(this.iconButton_up_Click);
            // 
            // listBox_locationName
            // 
            this.listBox_locationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_locationName.FormattingEnabled = true;
            this.listBox_locationName.ItemHeight = 42;
            this.listBox_locationName.Location = new System.Drawing.Point(20, 40);
            this.listBox_locationName.Name = "listBox_locationName";
            this.listBox_locationName.Size = new System.Drawing.Size(670, 550);
            this.listBox_locationName.TabIndex = 68;
            // 
            // locationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 970);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBox_addressShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_locationNameShow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBox_locationID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton_return);
            this.Controls.Add(this.iconButton_delete);
            this.Controls.Add(this.iconButton_update);
            this.Controls.Add(this.iconButton_add);
            this.Controls.Add(this.iconButton_down);
            this.Controls.Add(this.iconButton_up);
            this.Controls.Add(this.listBox_locationName);
            this.Name = "locationManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location Management";
            this.Load += new System.EventHandler(this.locationManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBox_address;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBox_locationName;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton iconButton_cancel;
        private FontAwesome.Sharp.IconButton iconButton_save;
        private System.Windows.Forms.TextBox txtBox_addressShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_locationNameShow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBox_locationID;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton_return;
        private FontAwesome.Sharp.IconButton iconButton_delete;
        private FontAwesome.Sharp.IconButton iconButton_update;
        private FontAwesome.Sharp.IconButton iconButton_add;
        private FontAwesome.Sharp.IconButton iconButton_down;
        private FontAwesome.Sharp.IconButton iconButton_up;
        private System.Windows.Forms.ListBox listBox_locationName;
    }
}