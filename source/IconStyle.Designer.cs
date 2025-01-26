namespace FolderBar_NS
{
    partial class IconStyle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.widthNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.heightNum = new System.Windows.Forms.NumericUpDown();
            this.depthGrp = new System.Windows.Forms.GroupBox();
            this.depth32 = new System.Windows.Forms.RadioButton();
            this.depth24 = new System.Windows.Forms.RadioButton();
            this.depth8 = new System.Windows.Forms.RadioButton();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).BeginInit();
            this.depthGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // widthNum
            // 
            this.widthNum.Location = new System.Drawing.Point(49, 45);
            this.widthNum.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.widthNum.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.widthNum.Name = "widthNum";
            this.widthNum.Size = new System.Drawing.Size(68, 20);
            this.widthNum.TabIndex = 1;
            this.widthNum.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height:";
            // 
            // heightNum
            // 
            this.heightNum.Location = new System.Drawing.Point(179, 45);
            this.heightNum.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.heightNum.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.heightNum.Name = "heightNum";
            this.heightNum.Size = new System.Drawing.Size(68, 20);
            this.heightNum.TabIndex = 3;
            this.heightNum.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // depthGrp
            // 
            this.depthGrp.Controls.Add(this.depth32);
            this.depthGrp.Controls.Add(this.depth24);
            this.depthGrp.Controls.Add(this.depth8);
            this.depthGrp.Location = new System.Drawing.Point(6, 71);
            this.depthGrp.Name = "depthGrp";
            this.depthGrp.Size = new System.Drawing.Size(126, 49);
            this.depthGrp.TabIndex = 5;
            this.depthGrp.TabStop = false;
            this.depthGrp.Text = "Depth:";
            // 
            // depth32
            // 
            this.depth32.AutoSize = true;
            this.depth32.Checked = true;
            this.depth32.Location = new System.Drawing.Point(86, 19);
            this.depth32.Name = "depth32";
            this.depth32.Size = new System.Drawing.Size(37, 17);
            this.depth32.TabIndex = 2;
            this.depth32.TabStop = true;
            this.depth32.Text = "32";
            this.depth32.UseVisualStyleBackColor = true;
            // 
            // depth24
            // 
            this.depth24.AutoSize = true;
            this.depth24.Location = new System.Drawing.Point(43, 19);
            this.depth24.Name = "depth24";
            this.depth24.Size = new System.Drawing.Size(37, 17);
            this.depth24.TabIndex = 1;
            this.depth24.Text = "24";
            this.depth24.UseVisualStyleBackColor = true;
            // 
            // depth8
            // 
            this.depth8.AutoSize = true;
            this.depth8.Location = new System.Drawing.Point(6, 19);
            this.depth8.Name = "depth8";
            this.depth8.Size = new System.Drawing.Size(31, 17);
            this.depth8.TabIndex = 0;
            this.depth8.Text = "8";
            this.depth8.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.title.BackColor = System.Drawing.Color.Silver;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(3, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(353, 32);
            this.title.TabIndex = 6;
            this.title.Text = "Icon Style";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IconStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title);
            this.Controls.Add(this.depthGrp);
            this.Controls.Add(this.heightNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthNum);
            this.Controls.Add(this.label1);
            this.Name = "IconStyle";
            this.Size = new System.Drawing.Size(359, 152);
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).EndInit();
            this.depthGrp.ResumeLayout(false);
            this.depthGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown widthNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown heightNum;
        private System.Windows.Forms.GroupBox depthGrp;
        private System.Windows.Forms.RadioButton depth32;
        private System.Windows.Forms.RadioButton depth24;
        private System.Windows.Forms.RadioButton depth8;
        private System.Windows.Forms.Label title;
    }
}
