namespace Kaioordinate
{
    partial class registrationFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationFrm));
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.dgEvent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgWhanau = new System.Windows.Forms.DataGridView();
            this.dgRegistration = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckboxPreparation = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWhanau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 80;
            this.btnReturn.Location = new System.Drawing.Point(787, 431);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 134);
            this.btnReturn.TabIndex = 49;
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
            this.btnDelete.Location = new System.Drawing.Point(628, 431);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 134);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "\r\n\r\n\r\n\r\n\r\nDELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 80;
            this.btnAdd.Location = new System.Drawing.Point(484, 431);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 134);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "\r\n\r\n\r\n\r\n\r\nADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgEvent
            // 
            this.dgEvent.AllowUserToAddRows = false;
            this.dgEvent.AllowUserToDeleteRows = false;
            this.dgEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvent.Location = new System.Drawing.Point(12, 31);
            this.dgEvent.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgEvent.Name = "dgEvent";
            this.dgEvent.ReadOnly = true;
            this.dgEvent.RowHeadersWidth = 82;
            this.dgEvent.RowTemplate.Height = 33;
            this.dgEvent.Size = new System.Drawing.Size(442, 244);
            this.dgEvent.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Events";
            // 
            // dgWhanau
            // 
            this.dgWhanau.AllowUserToAddRows = false;
            this.dgWhanau.AllowUserToDeleteRows = false;
            this.dgWhanau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWhanau.Location = new System.Drawing.Point(484, 31);
            this.dgWhanau.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgWhanau.Name = "dgWhanau";
            this.dgWhanau.RowHeadersWidth = 82;
            this.dgWhanau.RowTemplate.Height = 33;
            this.dgWhanau.Size = new System.Drawing.Size(442, 244);
            this.dgWhanau.TabIndex = 52;
            // 
            // dgRegistration
            // 
            this.dgRegistration.AllowUserToAddRows = false;
            this.dgRegistration.AllowUserToDeleteRows = false;
            this.dgRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistration.Location = new System.Drawing.Point(12, 321);
            this.dgRegistration.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgRegistration.Name = "dgRegistration";
            this.dgRegistration.ReadOnly = true;
            this.dgRegistration.RowHeadersWidth = 82;
            this.dgRegistration.RowTemplate.Height = 33;
            this.dgRegistration.Size = new System.Drawing.Size(442, 244);
            this.dgRegistration.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(638, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Whanau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(186, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Registrations";
            // 
            // ckboxPreparation
            // 
            this.ckboxPreparation.AutoSize = true;
            this.ckboxPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxPreparation.ForeColor = System.Drawing.Color.White;
            this.ckboxPreparation.Location = new System.Drawing.Point(484, 357);
            this.ckboxPreparation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ckboxPreparation.Name = "ckboxPreparation";
            this.ckboxPreparation.Size = new System.Drawing.Size(234, 28);
            this.ckboxPreparation.TabIndex = 56;
            this.ckboxPreparation.Text = "Kai Preparation Assistant";
            this.ckboxPreparation.UseVisualStyleBackColor = true;
            // 
            // registrationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 585);
            this.Controls.Add(this.ckboxPreparation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgRegistration);
            this.Controls.Add(this.dgWhanau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEvent);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "registrationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Maintenance";
            this.Load += new System.EventHandler(this.registrationFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWhanau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.DataGridView dgEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgWhanau;
        private System.Windows.Forms.DataGridView dgRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckboxPreparation;
    }
}