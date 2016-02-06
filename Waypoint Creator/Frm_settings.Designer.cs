﻿namespace Frm_waypoint
{
    partial class frm_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Settings));
            this.groupSQL = new System.Windows.Forms.GroupBox();
            this.chkBoxUDB = new System.Windows.Forms.CheckBox();
            this.chkBoxTDB = new System.Windows.Forms.CheckBox();
            this.groupGraph = new System.Windows.Forms.GroupBox();
            this.chkBoxSpline = new System.Windows.Forms.CheckBox();
            this.chkBoxLine = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupColours = new System.Windows.Forms.GroupBox();
            this.btnPointColour = new System.Windows.Forms.Button();
            this.btnLineColour = new System.Windows.Forms.Button();
            this.btnBackColour = new System.Windows.Forms.Button();
            this.btnTitleColour = new System.Windows.Forms.Button();
            this.picBoxPointColour = new System.Windows.Forms.PictureBox();
            this.picBoxLineColour = new System.Windows.Forms.PictureBox();
            this.picBoxBackColour = new System.Windows.Forms.PictureBox();
            this.picBoxTitleColour = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnDefault = new System.Windows.Forms.Button();
            this.chkBoxObject = new System.Windows.Forms.CheckBox();
            this.chkBoxVehicle = new System.Windows.Forms.CheckBox();
            this.groupSQL.SuspendLayout();
            this.groupGraph.SuspendLayout();
            this.groupColours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPointColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLineColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitleColour)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSQL
            // 
            this.groupSQL.Controls.Add(this.chkBoxUDB);
            this.groupSQL.Controls.Add(this.chkBoxTDB);
            this.groupSQL.Location = new System.Drawing.Point(12, 12);
            this.groupSQL.Name = "groupSQL";
            this.groupSQL.Size = new System.Drawing.Size(168, 68);
            this.groupSQL.TabIndex = 5;
            this.groupSQL.TabStop = false;
            this.groupSQL.Text = "SQL Output Format";
            // 
            // chkBoxUDB
            // 
            this.chkBoxUDB.AutoSize = true;
            this.chkBoxUDB.Location = new System.Drawing.Point(6, 42);
            this.chkBoxUDB.Name = "chkBoxUDB";
            this.chkBoxUDB.Size = new System.Drawing.Size(98, 17);
            this.chkBoxUDB.TabIndex = 3;
            this.chkBoxUDB.Text = "UDB Database";
            this.chkBoxUDB.UseVisualStyleBackColor = true;
            // 
            // chkBoxTDB
            // 
            this.chkBoxTDB.AutoSize = true;
            this.chkBoxTDB.Location = new System.Drawing.Point(6, 19);
            this.chkBoxTDB.Name = "chkBoxTDB";
            this.chkBoxTDB.Size = new System.Drawing.Size(97, 17);
            this.chkBoxTDB.TabIndex = 2;
            this.chkBoxTDB.Text = "TDB Database";
            this.chkBoxTDB.UseVisualStyleBackColor = true;
            // 
            // groupGraph
            // 
            this.groupGraph.Controls.Add(this.chkBoxSpline);
            this.groupGraph.Controls.Add(this.chkBoxLine);
            this.groupGraph.Location = new System.Drawing.Point(12, 86);
            this.groupGraph.Name = "groupGraph";
            this.groupGraph.Size = new System.Drawing.Size(168, 68);
            this.groupGraph.TabIndex = 6;
            this.groupGraph.TabStop = false;
            this.groupGraph.Text = "Point Graphing";
            // 
            // chkBoxSpline
            // 
            this.chkBoxSpline.AutoSize = true;
            this.chkBoxSpline.Location = new System.Drawing.Point(6, 42);
            this.chkBoxSpline.Name = "chkBoxSpline";
            this.chkBoxSpline.Size = new System.Drawing.Size(98, 17);
            this.chkBoxSpline.TabIndex = 6;
            this.chkBoxSpline.Text = "Linetype Spline";
            this.chkBoxSpline.UseVisualStyleBackColor = true;
            // 
            // chkBoxLine
            // 
            this.chkBoxLine.AutoSize = true;
            this.chkBoxLine.Location = new System.Drawing.Point(6, 19);
            this.chkBoxLine.Name = "chkBoxLine";
            this.chkBoxLine.Size = new System.Drawing.Size(81, 17);
            this.chkBoxLine.TabIndex = 5;
            this.chkBoxLine.Text = "Show Lines";
            this.chkBoxLine.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(249, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOKClick);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCancel.Location = new System.Drawing.Point(249, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelClick);
            // 
            // groupColours
            // 
            this.groupColours.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupColours.Controls.Add(this.btnPointColour);
            this.groupColours.Controls.Add(this.btnLineColour);
            this.groupColours.Controls.Add(this.btnBackColour);
            this.groupColours.Controls.Add(this.btnTitleColour);
            this.groupColours.Controls.Add(this.picBoxPointColour);
            this.groupColours.Controls.Add(this.picBoxLineColour);
            this.groupColours.Controls.Add(this.picBoxBackColour);
            this.groupColours.Controls.Add(this.picBoxTitleColour);
            this.groupColours.Location = new System.Drawing.Point(188, 12);
            this.groupColours.Name = "groupColours";
            this.groupColours.Size = new System.Drawing.Size(136, 142);
            this.groupColours.TabIndex = 9;
            this.groupColours.TabStop = false;
            this.groupColours.Text = "Graph Colours";
            // 
            // btnPointColour
            // 
            this.btnPointColour.Location = new System.Drawing.Point(41, 22);
            this.btnPointColour.Name = "btnPointColour";
            this.btnPointColour.Size = new System.Drawing.Size(85, 23);
            this.btnPointColour.TabIndex = 12;
            this.btnPointColour.Text = "Point Colour";
            this.btnPointColour.UseVisualStyleBackColor = true;
            this.btnPointColour.Click += new System.EventHandler(this.btnPointColour_Click);
            // 
            // btnLineColour
            // 
            this.btnLineColour.Location = new System.Drawing.Point(41, 51);
            this.btnLineColour.Name = "btnLineColour";
            this.btnLineColour.Size = new System.Drawing.Size(85, 23);
            this.btnLineColour.TabIndex = 13;
            this.btnLineColour.Text = "Line Colour";
            this.btnLineColour.UseVisualStyleBackColor = true;
            this.btnLineColour.Click += new System.EventHandler(this.btnLineColour_Click);
            // 
            // btnBackColour
            // 
            this.btnBackColour.Location = new System.Drawing.Point(41, 80);
            this.btnBackColour.Name = "btnBackColour";
            this.btnBackColour.Size = new System.Drawing.Size(85, 23);
            this.btnBackColour.TabIndex = 15;
            this.btnBackColour.Text = "Back Colour";
            this.btnBackColour.UseVisualStyleBackColor = true;
            this.btnBackColour.Click += new System.EventHandler(this.btnBackColour_Click);
            // 
            // btnTitleColour
            // 
            this.btnTitleColour.Location = new System.Drawing.Point(41, 109);
            this.btnTitleColour.Name = "btnTitleColour";
            this.btnTitleColour.Size = new System.Drawing.Size(85, 23);
            this.btnTitleColour.TabIndex = 17;
            this.btnTitleColour.Text = "Title Colour";
            this.btnTitleColour.UseVisualStyleBackColor = true;
            this.btnTitleColour.Click += new System.EventHandler(this.btnTitleColour_Click);
            // 
            // picBoxPointColour
            // 
            this.picBoxPointColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxPointColour.Location = new System.Drawing.Point(6, 22);
            this.picBoxPointColour.Name = "picBoxPointColour";
            this.picBoxPointColour.Size = new System.Drawing.Size(23, 23);
            this.picBoxPointColour.TabIndex = 0;
            this.picBoxPointColour.TabStop = false;
            // 
            // picBoxLineColour
            // 
            this.picBoxLineColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxLineColour.Location = new System.Drawing.Point(6, 51);
            this.picBoxLineColour.Name = "picBoxLineColour";
            this.picBoxLineColour.Size = new System.Drawing.Size(23, 23);
            this.picBoxLineColour.TabIndex = 2;
            this.picBoxLineColour.TabStop = false;
            // 
            // picBoxBackColour
            // 
            this.picBoxBackColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxBackColour.Location = new System.Drawing.Point(6, 80);
            this.picBoxBackColour.Name = "picBoxBackColour";
            this.picBoxBackColour.Size = new System.Drawing.Size(23, 23);
            this.picBoxBackColour.TabIndex = 14;
            this.picBoxBackColour.TabStop = false;
            // 
            // picBoxTitleColour
            // 
            this.picBoxTitleColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxTitleColour.Location = new System.Drawing.Point(6, 109);
            this.picBoxTitleColour.Name = "picBoxTitleColour";
            this.picBoxTitleColour.Size = new System.Drawing.Size(23, 23);
            this.picBoxTitleColour.TabIndex = 16;
            this.picBoxTitleColour.TabStop = false;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(18, 216);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(117, 23);
            this.btnDefault.TabIndex = 10;
            this.btnDefault.Text = "Reset Default Values";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // chkBoxObject
            // 
            this.chkBoxObject.AutoSize = true;
            this.chkBoxObject.Location = new System.Drawing.Point(18, 166);
            this.chkBoxObject.Name = "chkBoxObject";
            this.chkBoxObject.Size = new System.Drawing.Size(218, 17);
            this.chkBoxObject.TabIndex = 11;
            this.chkBoxObject.Text = "Get spline waypoints from Object Update";
            this.chkBoxObject.UseVisualStyleBackColor = true;
            // 
            // chkBoxVehicle
            // 
            this.chkBoxVehicle.AutoSize = true;
            this.chkBoxVehicle.Location = new System.Drawing.Point(18, 190);
            this.chkBoxVehicle.Name = "chkBoxVehicle";
            this.chkBoxVehicle.Size = new System.Drawing.Size(201, 17);
            this.chkBoxVehicle.TabIndex = 12;
            this.chkBoxVehicle.Text = "Get spline waypoints for Vehicle only!";
            this.chkBoxVehicle.UseVisualStyleBackColor = true;
            // 
            // frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 254);
            this.ControlBox = false;
            this.Controls.Add(this.chkBoxVehicle);
            this.Controls.Add(this.chkBoxObject);
            this.Controls.Add(this.groupSQL);
            this.Controls.Add(this.groupGraph);
            this.Controls.Add(this.groupColours);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Settings";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Frm_settings_Load);
            this.groupSQL.ResumeLayout(false);
            this.groupSQL.PerformLayout();
            this.groupGraph.ResumeLayout(false);
            this.groupGraph.PerformLayout();
            this.groupColours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPointColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLineColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitleColour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSQL;
        private System.Windows.Forms.CheckBox chkBoxUDB;
        private System.Windows.Forms.CheckBox chkBoxTDB;
        private System.Windows.Forms.GroupBox groupGraph;
        private System.Windows.Forms.CheckBox chkBoxSpline;
        private System.Windows.Forms.CheckBox chkBoxLine;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupColours;
        private System.Windows.Forms.PictureBox picBoxLineColour;
        private System.Windows.Forms.PictureBox picBoxPointColour;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnLineColour;
        private System.Windows.Forms.Button btnPointColour;
        private System.Windows.Forms.Button btnTitleColour;
        private System.Windows.Forms.PictureBox picBoxTitleColour;
        private System.Windows.Forms.Button btnBackColour;
        private System.Windows.Forms.PictureBox picBoxBackColour;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.CheckBox chkBoxObject;
        private System.Windows.Forms.CheckBox chkBoxVehicle;
    }
}