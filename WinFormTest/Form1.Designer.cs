using System;

namespace WinFormTest
{
    partial class FrmEmp
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
            this.lblname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbldesign = new System.Windows.Forms.Label();
            this.txtdesig = new System.Windows.Forms.TextBox();
            this.lblAddr = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(22, 83);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(84, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Employee Name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(148, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Employee ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(148, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(128, 20);
            this.txtId.TabIndex = 3;
            // 
            // lbldesign
            // 
            this.lbldesign.AutoSize = true;
            this.lbldesign.Location = new System.Drawing.Point(25, 137);
            this.lbldesign.Name = "lbldesign";
            this.lbldesign.Size = new System.Drawing.Size(63, 13);
            this.lbldesign.TabIndex = 4;
            this.lbldesign.Text = "Designation";
            // 
            // txtdesig
            // 
            this.txtdesig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdesig.Location = new System.Drawing.Point(148, 137);
            this.txtdesig.Name = "txtdesig";
            this.txtdesig.Size = new System.Drawing.Size(100, 20);
            this.txtdesig.TabIndex = 5;
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(28, 198);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(45, 13);
            this.lblAddr.TabIndex = 6;
            this.lblAddr.Text = "Address";
            // 
            // txtAddr
            // 
            this.txtAddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddr.Location = new System.Drawing.Point(148, 190);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(100, 20);
            this.txtAddr.TabIndex = 7;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save.Location = new System.Drawing.Point(148, 259);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
           // this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEdit.Location = new System.Drawing.Point(229, 259);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Delete.Location = new System.Drawing.Point(310, 259);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // FrmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 435);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.txtdesig);
            this.Controls.Add(this.lbldesign);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblname);
            this.Name = "FrmEmp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbldesign;
        private System.Windows.Forms.TextBox txtdesig;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button Delete;
        private EventHandler lblId_Click;
    }
}

