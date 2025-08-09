namespace Kaioordinate
{
    partial class registration
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
            this.iconButton_reture = new FontAwesome.Sharp.IconButton();
            this.iconButton_delete = new FontAwesome.Sharp.IconButton();
            this.iconButton_add = new FontAwesome.Sharp.IconButton();
            this.dgEvent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgWhanau = new System.Windows.Forms.DataGridView();
            this.dgRegistration = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_preparation = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWhanau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton_reture
            // 
            this.iconButton_reture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton_reture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_reture.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.iconButton_reture.IconColor = System.Drawing.Color.Black;
            this.iconButton_reture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_reture.IconSize = 150;
            this.iconButton_reture.Location = new System.Drawing.Point(1574, 898);
            this.iconButton_reture.Name = "iconButton_reture";
            this.iconButton_reture.Size = new System.Drawing.Size(280, 280);
            this.iconButton_reture.TabIndex = 49;
            this.iconButton_reture.Text = "\r\n\r\n\r\n\r\n\r\nRETURN";
            this.iconButton_reture.UseVisualStyleBackColor = false;
            this.iconButton_reture.Click += new System.EventHandler(this.iconButton_reture_Click);
            // 
            // iconButton_delete
            // 
            this.iconButton_delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton_delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton_delete.IconColor = System.Drawing.Color.Black;
            this.iconButton_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_delete.IconSize = 150;
            this.iconButton_delete.Location = new System.Drawing.Point(1255, 898);
            this.iconButton_delete.Name = "iconButton_delete";
            this.iconButton_delete.Size = new System.Drawing.Size(280, 280);
            this.iconButton_delete.TabIndex = 48;
            this.iconButton_delete.Text = "\r\n\r\n\r\n\r\n\r\nDELETE";
            this.iconButton_delete.UseVisualStyleBackColor = false;
            this.iconButton_delete.Click += new System.EventHandler(this.iconButton_delete_Click);
            // 
            // iconButton_add
            // 
            this.iconButton_add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton_add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton_add.IconColor = System.Drawing.Color.Black;
            this.iconButton_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_add.IconSize = 150;
            this.iconButton_add.Location = new System.Drawing.Point(969, 898);
            this.iconButton_add.Name = "iconButton_add";
            this.iconButton_add.Size = new System.Drawing.Size(280, 280);
            this.iconButton_add.TabIndex = 47;
            this.iconButton_add.Text = "\r\n\r\n\r\n\r\n\r\nADD";
            this.iconButton_add.UseVisualStyleBackColor = false;
            this.iconButton_add.Click += new System.EventHandler(this.iconButton_add_Click);
            // 
            // dgEvent
            // 
            this.dgEvent.AllowUserToAddRows = false;
            this.dgEvent.AllowUserToDeleteRows = false;
            this.dgEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvent.Location = new System.Drawing.Point(24, 64);
            this.dgEvent.Name = "dgEvent";
            this.dgEvent.ReadOnly = true;
            this.dgEvent.RowHeadersWidth = 82;
            this.dgEvent.RowTemplate.Height = 33;
            this.dgEvent.Size = new System.Drawing.Size(885, 509);
            this.dgEvent.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(372, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 42);
            this.label1.TabIndex = 51;
            this.label1.Text = "Events";
            // 
            // dgWhanau
            // 
            this.dgWhanau.AllowUserToAddRows = false;
            this.dgWhanau.AllowUserToDeleteRows = false;
            this.dgWhanau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWhanau.Location = new System.Drawing.Point(969, 64);
            this.dgWhanau.Name = "dgWhanau";
            this.dgWhanau.RowHeadersWidth = 82;
            this.dgWhanau.RowTemplate.Height = 33;
            this.dgWhanau.Size = new System.Drawing.Size(885, 509);
            this.dgWhanau.TabIndex = 52;
            // 
            // dgRegistration
            // 
            this.dgRegistration.AllowUserToAddRows = false;
            this.dgRegistration.AllowUserToDeleteRows = false;
            this.dgRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistration.Location = new System.Drawing.Point(24, 669);
            this.dgRegistration.Name = "dgRegistration";
            this.dgRegistration.ReadOnly = true;
            this.dgRegistration.RowHeadersWidth = 82;
            this.dgRegistration.RowTemplate.Height = 33;
            this.dgRegistration.Size = new System.Drawing.Size(885, 509);
            this.dgRegistration.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1277, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 42);
            this.label2.TabIndex = 54;
            this.label2.Text = "Whanau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(372, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 42);
            this.label3.TabIndex = 55;
            this.label3.Text = "Registrations";
            // 
            // checkBox_preparation
            // 
            this.checkBox_preparation.AutoSize = true;
            this.checkBox_preparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_preparation.ForeColor = System.Drawing.Color.White;
            this.checkBox_preparation.Location = new System.Drawing.Point(969, 743);
            this.checkBox_preparation.Name = "checkBox_preparation";
            this.checkBox_preparation.Size = new System.Drawing.Size(469, 46);
            this.checkBox_preparation.TabIndex = 56;
            this.checkBox_preparation.Text = "Kai Preparation Assistant";
            this.checkBox_preparation.UseVisualStyleBackColor = true;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1887, 1224);
            this.Controls.Add(this.checkBox_preparation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgRegistration);
            this.Controls.Add(this.dgWhanau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEvent);
            this.Controls.Add(this.iconButton_reture);
            this.Controls.Add(this.iconButton_delete);
            this.Controls.Add(this.iconButton_add);
            this.Name = "registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Maintenance";
            this.Load += new System.EventHandler(this.registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWhanau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton_reture;
        private FontAwesome.Sharp.IconButton iconButton_delete;
        private FontAwesome.Sharp.IconButton iconButton_add;
        private System.Windows.Forms.DataGridView dgEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgWhanau;
        private System.Windows.Forms.DataGridView dgRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_preparation;
    }
}