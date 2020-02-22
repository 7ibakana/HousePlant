namespace HousePlant
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
            this.chkSouthFacing = new System.Windows.Forms.CheckBox();
            this.trkTemp = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.InkHousePlantInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSouthFacing
            // 
            this.chkSouthFacing.AutoSize = true;
            this.chkSouthFacing.Location = new System.Drawing.Point(37, 39);
            this.chkSouthFacing.Name = "chkSouthFacing";
            this.chkSouthFacing.Size = new System.Drawing.Size(202, 17);
            this.chkSouthFacing.TabIndex = 0;
            this.chkSouthFacing.Text = "Do you have a south-facing window?";
            this.chkSouthFacing.UseVisualStyleBackColor = true;
            this.chkSouthFacing.CheckedChanged += new System.EventHandler(this.HouseConditionsChanged);
            // 
            // trkTemp
            // 
            this.trkTemp.Location = new System.Drawing.Point(55, 118);
            this.trkTemp.Maximum = 90;
            this.trkTemp.Minimum = 50;
            this.trkTemp.Name = "trkTemp";
            this.trkTemp.Size = new System.Drawing.Size(218, 45);
            this.trkTemp.TabIndex = 4;
            this.trkTemp.Value = 50;
            this.trkTemp.Scroll += new System.EventHandler(this.trkTemp_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "How warm is your home?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Location = new System.Drawing.Point(165, 182);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(108, 13);
            this.lblSuggestion.TabIndex = 10;
            this.lblSuggestion.Text = "Plan Suggestion here";
            this.lblSuggestion.Click += new System.EventHandler(this.lblSuggestion_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(296, 130);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(29, 13);
            this.lblTemp.TabIndex = 11;
            this.lblTemp.Text = "50°F";
            // 
            // InkHousePlantInfo
            // 
            this.InkHousePlantInfo.AutoSize = true;
            this.InkHousePlantInfo.Location = new System.Drawing.Point(270, 217);
            this.InkHousePlantInfo.Name = "InkHousePlantInfo";
            this.InkHousePlantInfo.Size = new System.Drawing.Size(100, 13);
            this.InkHousePlantInfo.TabIndex = 12;
            this.InkHousePlantInfo.TabStop = true;
            this.InkHousePlantInfo.Text = "houseplant411.com";
            this.InkHousePlantInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InkHousePlantInfo_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(382, 239);
            this.Controls.Add(this.InkHousePlantInfo);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblSuggestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkTemp);
            this.Controls.Add(this.chkSouthFacing);
            this.Name = "Form1";
            this.Text = "Houseplant Suggestions";
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSouthFacing;
        private System.Windows.Forms.TrackBar trkTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.LinkLabel InkHousePlantInfo;
    }
}

