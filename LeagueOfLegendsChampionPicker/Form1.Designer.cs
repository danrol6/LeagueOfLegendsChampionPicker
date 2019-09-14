namespace LeagueOfLegendsChampionPicker
{
    partial class MainForm
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
            this.btnChampionPicker = new System.Windows.Forms.Button();
            this.lblChampionPicked = new System.Windows.Forms.Label();
            this.picChampionPic = new System.Windows.Forms.PictureBox();
            this.tabControls = new System.Windows.Forms.TabControl();
            this.tabPickAChampion = new System.Windows.Forms.TabPage();
            this.grpboxYourChampionPool = new System.Windows.Forms.GroupBox();
            this.tabChampionPool = new System.Windows.Forms.TabPage();
            this.grpboxChampionPool = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChampionPic)).BeginInit();
            this.tabControls.SuspendLayout();
            this.tabPickAChampion.SuspendLayout();
            this.tabChampionPool.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChampionPicker
            // 
            this.btnChampionPicker.Location = new System.Drawing.Point(401, 219);
            this.btnChampionPicker.Name = "btnChampionPicker";
            this.btnChampionPicker.Size = new System.Drawing.Size(152, 37);
            this.btnChampionPicker.TabIndex = 0;
            this.btnChampionPicker.Text = "Pick A Champion";
            this.btnChampionPicker.UseVisualStyleBackColor = true;
            this.btnChampionPicker.Click += new System.EventHandler(this.btnChampionPicker_Click);
            // 
            // lblChampionPicked
            // 
            this.lblChampionPicked.AutoSize = true;
            this.lblChampionPicked.Location = new System.Drawing.Point(658, 259);
            this.lblChampionPicked.Name = "lblChampionPicked";
            this.lblChampionPicked.Size = new System.Drawing.Size(117, 17);
            this.lblChampionPicked.TabIndex = 1;
            this.lblChampionPicked.Text = "Champion Picked";
            this.lblChampionPicked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picChampionPic
            // 
            this.picChampionPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picChampionPic.Location = new System.Drawing.Point(594, 16);
            this.picChampionPic.Name = "picChampionPic";
            this.picChampionPic.Size = new System.Drawing.Size(240, 240);
            this.picChampionPic.TabIndex = 2;
            this.picChampionPic.TabStop = false;
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.tabPickAChampion);
            this.tabControls.Controls.Add(this.tabChampionPool);
            this.tabControls.Location = new System.Drawing.Point(12, 12);
            this.tabControls.Name = "tabControls";
            this.tabControls.SelectedIndex = 0;
            this.tabControls.Size = new System.Drawing.Size(881, 629);
            this.tabControls.TabIndex = 3;
            // 
            // tabPickAChampion
            // 
            this.tabPickAChampion.AutoScroll = true;
            this.tabPickAChampion.Controls.Add(this.grpboxYourChampionPool);
            this.tabPickAChampion.Controls.Add(this.btnChampionPicker);
            this.tabPickAChampion.Controls.Add(this.picChampionPic);
            this.tabPickAChampion.Controls.Add(this.lblChampionPicked);
            this.tabPickAChampion.Location = new System.Drawing.Point(4, 25);
            this.tabPickAChampion.Name = "tabPickAChampion";
            this.tabPickAChampion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPickAChampion.Size = new System.Drawing.Size(873, 600);
            this.tabPickAChampion.TabIndex = 0;
            this.tabPickAChampion.Text = "Pick a Champion";
            this.tabPickAChampion.UseVisualStyleBackColor = true;
            // 
            // grpboxYourChampionPool
            // 
            this.grpboxYourChampionPool.AutoSize = true;
            this.grpboxYourChampionPool.Location = new System.Drawing.Point(6, 294);
            this.grpboxYourChampionPool.Name = "grpboxYourChampionPool";
            this.grpboxYourChampionPool.Size = new System.Drawing.Size(838, 300);
            this.grpboxYourChampionPool.TabIndex = 3;
            this.grpboxYourChampionPool.TabStop = false;
            this.grpboxYourChampionPool.Text = "Your Champion Pool";
            // 
            // tabChampionPool
            // 
            this.tabChampionPool.AutoScroll = true;
            this.tabChampionPool.Controls.Add(this.grpboxChampionPool);
            this.tabChampionPool.Location = new System.Drawing.Point(4, 25);
            this.tabChampionPool.Name = "tabChampionPool";
            this.tabChampionPool.Padding = new System.Windows.Forms.Padding(3);
            this.tabChampionPool.Size = new System.Drawing.Size(873, 600);
            this.tabChampionPool.TabIndex = 2;
            this.tabChampionPool.Text = "Champion Pool";
            this.tabChampionPool.UseVisualStyleBackColor = true;
            // 
            // grpboxChampionPool
            // 
            this.grpboxChampionPool.AutoSize = true;
            this.grpboxChampionPool.Location = new System.Drawing.Point(6, 249);
            this.grpboxChampionPool.Name = "grpboxChampionPool";
            this.grpboxChampionPool.Size = new System.Drawing.Size(861, 345);
            this.grpboxChampionPool.TabIndex = 0;
            this.grpboxChampionPool.TabStop = false;
            this.grpboxChampionPool.Text = "Champion Pool";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 653);
            this.Controls.Add(this.tabControls);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League Random Champion Pick";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChampionPic)).EndInit();
            this.tabControls.ResumeLayout(false);
            this.tabPickAChampion.ResumeLayout(false);
            this.tabPickAChampion.PerformLayout();
            this.tabChampionPool.ResumeLayout(false);
            this.tabChampionPool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChampionPicker;
        private System.Windows.Forms.Label lblChampionPicked;
        private System.Windows.Forms.PictureBox picChampionPic;
        private System.Windows.Forms.TabControl tabControls;
        private System.Windows.Forms.TabPage tabPickAChampion;
        private System.Windows.Forms.GroupBox grpboxYourChampionPool;
        private System.Windows.Forms.TabPage tabChampionPool;
        private System.Windows.Forms.GroupBox grpboxChampionPool;
    }
}

