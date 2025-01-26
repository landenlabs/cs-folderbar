namespace FolderBar_NS
{
    partial class LookDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookDialog));
            this.group = new System.Windows.Forms.GroupBox();
            this.fontBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.fgColorBtn = new FolderBar_NS.ColorButton();
            this.bgColorBtn = new FolderBar_NS.ColorButton();
            this.textLayoutCombo = new System.Windows.Forms.ComboBox();
            this.imageLayoutCombo = new System.Windows.Forms.ComboBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthNum = new System.Windows.Forms.NumericUpDown();
            this.loadImageBtn = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.TextBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.group.SuspendLayout();
            this.flowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNum)).BeginInit();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.fontBtn);
            this.group.Controls.Add(this.previewBtn);
            this.group.Controls.Add(this.textBox);
            this.group.Controls.Add(this.flowLayout);
            this.group.Controls.Add(this.lengthLabel);
            this.group.Controls.Add(this.lengthNum);
            this.group.Controls.Add(this.loadImageBtn);
            this.group.Controls.Add(this.imageBox);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Margin = new System.Windows.Forms.Padding(0);
            this.group.MinimumSize = new System.Drawing.Size(0, 152);
            this.group.Name = "group";
            this.group.Padding = new System.Windows.Forms.Padding(2);
            this.group.Size = new System.Drawing.Size(359, 152);
            this.group.TabIndex = 7;
            this.group.TabStop = false;
            this.group.Text = "____Top Look";
            // 
            // fontBtn
            // 
            this.fontBtn.Location = new System.Drawing.Point(8, 93);
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(45, 20);
            this.fontBtn.TabIndex = 13;
            this.fontBtn.Text = "Font";
            this.fontBtn.UseVisualStyleBackColor = true;
            this.fontBtn.Click += new System.EventHandler(this.fontBtn_Click);
            // 
            // previewBtn
            // 
            this.previewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.previewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.previewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previewBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.previewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previewBtn.Location = new System.Drawing.Point(69, 46);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(282, 43);
            this.previewBtn.TabIndex = 12;
            this.previewBtn.Text = "text";
            this.previewBtn.UseVisualStyleBackColor = false;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(54, 95);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(297, 20);
            this.textBox.TabIndex = 8;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // flowLayout
            // 
            this.flowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayout.Controls.Add(this.fgColorBtn);
            this.flowLayout.Controls.Add(this.bgColorBtn);
            this.flowLayout.Controls.Add(this.textLayoutCombo);
            this.flowLayout.Controls.Add(this.imageLayoutCombo);
            this.flowLayout.Location = new System.Drawing.Point(6, 116);
            this.flowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(345, 24);
            this.flowLayout.TabIndex = 11;
            // 
            // fgColorBtn
            // 
            this.fgColorBtn.Color = System.Drawing.Color.Black;
            this.fgColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("fgColorBtn.Image")));
            this.fgColorBtn.Location = new System.Drawing.Point(1, 1);
            this.fgColorBtn.Margin = new System.Windows.Forms.Padding(1);
            this.fgColorBtn.Name = "fgColorBtn";
            this.fgColorBtn.Size = new System.Drawing.Size(60, 23);
            this.fgColorBtn.TabIndex = 5;
            this.fgColorBtn.Text = "Fg";
            this.fgColorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fgColorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.fgColorBtn.UseVisualStyleBackColor = true;
            // 
            // bgColorBtn
            // 
            this.bgColorBtn.Color = System.Drawing.Color.Empty;
            this.bgColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("bgColorBtn.Image")));
            this.bgColorBtn.Location = new System.Drawing.Point(63, 1);
            this.bgColorBtn.Margin = new System.Windows.Forms.Padding(1);
            this.bgColorBtn.Name = "bgColorBtn";
            this.bgColorBtn.Size = new System.Drawing.Size(60, 23);
            this.bgColorBtn.TabIndex = 6;
            this.bgColorBtn.Text = "Bg";
            this.bgColorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bgColorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bgColorBtn.UseVisualStyleBackColor = true;
            // 
            // textLayoutCombo
            // 
            this.textLayoutCombo.FormattingEnabled = true;
            this.textLayoutCombo.Items.AddRange(new object[] {
            "MiddleLeft",
            "MiddleCenter",
            "MiddleRight"});
            this.textLayoutCombo.Location = new System.Drawing.Point(125, 1);
            this.textLayoutCombo.Margin = new System.Windows.Forms.Padding(1);
            this.textLayoutCombo.Name = "textLayoutCombo";
            this.textLayoutCombo.Size = new System.Drawing.Size(80, 21);
            this.textLayoutCombo.TabIndex = 7;
            this.textLayoutCombo.Text = "MiddleCenter";
            this.textLayoutCombo.SelectedIndexChanged += new System.EventHandler(this.textLayoutCombo_SelectedIndexChanged);
            // 
            // imageLayoutCombo
            // 
            this.imageLayoutCombo.FormattingEnabled = true;
            this.imageLayoutCombo.Items.AddRange(new object[] {
            "Zoom",
            "Stretch",
            "Center",
            "None"});
            this.imageLayoutCombo.Location = new System.Drawing.Point(207, 1);
            this.imageLayoutCombo.Margin = new System.Windows.Forms.Padding(1);
            this.imageLayoutCombo.Name = "imageLayoutCombo";
            this.imageLayoutCombo.Size = new System.Drawing.Size(80, 21);
            this.imageLayoutCombo.TabIndex = 10;
            this.imageLayoutCombo.Text = "Tile";
            this.imageLayoutCombo.SelectedIndexChanged += new System.EventHandler(this.imageLayoutCombo_SelectedIndexChanged);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(6, 52);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(41, 13);
            this.lengthLabel.TabIndex = 4;
            this.lengthLabel.Text = " Height";
            this.lengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthNum
            // 
            this.lengthNum.Location = new System.Drawing.Point(9, 68);
            this.lengthNum.Name = "lengthNum";
            this.lengthNum.Size = new System.Drawing.Size(56, 20);
            this.lengthNum.TabIndex = 3;
            this.lengthNum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // loadImageBtn
            // 
            this.loadImageBtn.Location = new System.Drawing.Point(9, 19);
            this.loadImageBtn.Name = "loadImageBtn";
            this.loadImageBtn.Size = new System.Drawing.Size(26, 20);
            this.loadImageBtn.TabIndex = 1;
            this.loadImageBtn.Text = "...";
            this.loadImageBtn.UseVisualStyleBackColor = true;
            this.loadImageBtn.Click += new System.EventHandler(this.loadImageBtn_Click);
            // 
            // imageBox
            // 
            this.imageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.imageBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.imageBox.Location = new System.Drawing.Point(40, 18);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(311, 20);
            this.imageBox.TabIndex = 0;
            this.imageBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.imageBox_PreviewKeyDown);
            this.imageBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.imageBox_KeyUp);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "icon.png";
            this.openFileDialog.Filter = "Png|*.png|Jpeg|*.jpg|Any|*.*";
            this.openFileDialog.Title = "Load Look Image";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Location = new System.Drawing.Point(12, 4);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 14;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // LookDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.group);
            this.Name = "LookDialog";
            this.Size = new System.Drawing.Size(359, 152);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.flowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lengthNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private ColorButton bgColorBtn;
        private ColorButton fgColorBtn;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.NumericUpDown lengthNum;
        private System.Windows.Forms.Button loadImageBtn;
        private System.Windows.Forms.TextBox imageBox;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox textLayoutCombo;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.ComboBox imageLayoutCombo;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.Button fontBtn;
        private System.Windows.Forms.CheckBox checkBox;
    }
}
