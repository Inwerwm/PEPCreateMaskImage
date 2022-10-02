
namespace CreateMaskImage
{
    partial class FormControl
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
            this.listBoxMaterials = new System.Windows.Forms.ListBox();
            this.ContentsArea = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReload = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.tableLayoutColor = new System.Windows.Forms.TableLayoutPanel();
            this.panelMaskColor = new System.Windows.Forms.Panel();
            this.labelMaskColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.panelBaseColor = new System.Windows.Forms.Panel();
            this.labelGradientEndPosition = new System.Windows.Forms.Label();
            this.numericGradientEndPosition = new System.Windows.Forms.NumericUpDown();
            this.labelGradientStartPosition = new System.Windows.Forms.Label();
            this.numericGradientStartPosition = new System.Windows.Forms.NumericUpDown();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.ContentsArea.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.tableLayoutColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGradientEndPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGradientStartPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMaterials
            // 
            this.listBoxMaterials.DisplayMember = "Name";
            this.listBoxMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMaterials.FormattingEnabled = true;
            this.listBoxMaterials.ItemHeight = 15;
            this.listBoxMaterials.Location = new System.Drawing.Point(4, 4);
            this.listBoxMaterials.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMaterials.Name = "listBoxMaterials";
            this.listBoxMaterials.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMaterials.Size = new System.Drawing.Size(236, 331);
            this.listBoxMaterials.TabIndex = 0;
            this.listBoxMaterials.ValueMember = "Name";
            // 
            // ContentsArea
            // 
            this.ContentsArea.ColumnCount = 2;
            this.ContentsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContentsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContentsArea.Controls.Add(this.buttonReload, 0, 1);
            this.ContentsArea.Controls.Add(this.listBoxMaterials, 0, 0);
            this.ContentsArea.Controls.Add(this.panelSettings, 1, 0);
            this.ContentsArea.Controls.Add(this.buttonExecute, 1, 1);
            this.ContentsArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentsArea.Location = new System.Drawing.Point(0, 0);
            this.ContentsArea.Margin = new System.Windows.Forms.Padding(4);
            this.ContentsArea.Name = "ContentsArea";
            this.ContentsArea.RowCount = 2;
            this.ContentsArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContentsArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ContentsArea.Size = new System.Drawing.Size(489, 389);
            this.ContentsArea.TabIndex = 1;
            // 
            // buttonReload
            // 
            this.buttonReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReload.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonReload.Location = new System.Drawing.Point(3, 342);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(238, 44);
            this.buttonReload.TabIndex = 3;
            this.buttonReload.Text = "再読込";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.tableLayoutColor);
            this.panelSettings.Controls.Add(this.labelGradientEndPosition);
            this.panelSettings.Controls.Add(this.numericGradientEndPosition);
            this.panelSettings.Controls.Add(this.labelGradientStartPosition);
            this.panelSettings.Controls.Add(this.numericGradientStartPosition);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(248, 4);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(4);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(237, 331);
            this.panelSettings.TabIndex = 1;
            // 
            // tableLayoutColor
            // 
            this.tableLayoutColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutColor.ColumnCount = 2;
            this.tableLayoutColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutColor.Controls.Add(this.panelMaskColor, 1, 1);
            this.tableLayoutColor.Controls.Add(this.labelMaskColor, 1, 0);
            this.tableLayoutColor.Controls.Add(this.labelBaseColor, 0, 0);
            this.tableLayoutColor.Controls.Add(this.panelBaseColor, 0, 1);
            this.tableLayoutColor.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutColor.Name = "tableLayoutColor";
            this.tableLayoutColor.RowCount = 2;
            this.tableLayoutColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutColor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutColor.Size = new System.Drawing.Size(230, 139);
            this.tableLayoutColor.TabIndex = 5;
            // 
            // panelMaskColor
            // 
            this.panelMaskColor.BackColor = System.Drawing.Color.Black;
            this.panelMaskColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMaskColor.Location = new System.Drawing.Point(120, 25);
            this.panelMaskColor.Margin = new System.Windows.Forms.Padding(5);
            this.panelMaskColor.Name = "panelMaskColor";
            this.panelMaskColor.Size = new System.Drawing.Size(105, 109);
            this.panelMaskColor.TabIndex = 7;
            // 
            // labelMaskColor
            // 
            this.labelMaskColor.AutoSize = true;
            this.labelMaskColor.Location = new System.Drawing.Point(118, 0);
            this.labelMaskColor.Name = "labelMaskColor";
            this.labelMaskColor.Size = new System.Drawing.Size(46, 15);
            this.labelMaskColor.TabIndex = 6;
            this.labelMaskColor.Text = "マスク色";
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AutoSize = true;
            this.labelBaseColor.Location = new System.Drawing.Point(3, 0);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(43, 15);
            this.labelBaseColor.TabIndex = 4;
            this.labelBaseColor.Text = "基本色";
            // 
            // panelBaseColor
            // 
            this.panelBaseColor.BackColor = System.Drawing.Color.White;
            this.panelBaseColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBaseColor.Location = new System.Drawing.Point(5, 25);
            this.panelBaseColor.Margin = new System.Windows.Forms.Padding(5);
            this.panelBaseColor.Name = "panelBaseColor";
            this.panelBaseColor.Size = new System.Drawing.Size(105, 109);
            this.panelBaseColor.TabIndex = 5;
            // 
            // labelGradientEndPosition
            // 
            this.labelGradientEndPosition.AutoSize = true;
            this.labelGradientEndPosition.Location = new System.Drawing.Point(4, 54);
            this.labelGradientEndPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGradientEndPosition.Name = "labelGradientEndPosition";
            this.labelGradientEndPosition.Size = new System.Drawing.Size(115, 15);
            this.labelGradientEndPosition.TabIndex = 3;
            this.labelGradientEndPosition.Text = "グラデーション終了座標";
            // 
            // numericGradientEndPosition
            // 
            this.numericGradientEndPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericGradientEndPosition.DecimalPlaces = 7;
            this.numericGradientEndPosition.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericGradientEndPosition.Location = new System.Drawing.Point(4, 73);
            this.numericGradientEndPosition.Margin = new System.Windows.Forms.Padding(4);
            this.numericGradientEndPosition.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericGradientEndPosition.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericGradientEndPosition.Name = "numericGradientEndPosition";
            this.numericGradientEndPosition.Size = new System.Drawing.Size(230, 23);
            this.numericGradientEndPosition.TabIndex = 2;
            // 
            // labelGradientStartPosition
            // 
            this.labelGradientStartPosition.AutoSize = true;
            this.labelGradientStartPosition.Location = new System.Drawing.Point(4, 8);
            this.labelGradientStartPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGradientStartPosition.Name = "labelGradientStartPosition";
            this.labelGradientStartPosition.Size = new System.Drawing.Size(115, 15);
            this.labelGradientStartPosition.TabIndex = 1;
            this.labelGradientStartPosition.Text = "グラデーション開始座標";
            // 
            // numericGradientStartPosition
            // 
            this.numericGradientStartPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericGradientStartPosition.DecimalPlaces = 7;
            this.numericGradientStartPosition.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericGradientStartPosition.Location = new System.Drawing.Point(4, 27);
            this.numericGradientStartPosition.Margin = new System.Windows.Forms.Padding(4);
            this.numericGradientStartPosition.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericGradientStartPosition.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericGradientStartPosition.Name = "numericGradientStartPosition";
            this.numericGradientStartPosition.Size = new System.Drawing.Size(230, 23);
            this.numericGradientStartPosition.TabIndex = 0;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExecute.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonExecute.Location = new System.Drawing.Point(247, 342);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(239, 44);
            this.buttonExecute.TabIndex = 2;
            this.buttonExecute.Text = "作成";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 389);
            this.Controls.Add(this.ContentsArea);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormControl";
            this.Text = "マスク画像を作成";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormControl_FormClosing);
            this.ContentsArea.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.tableLayoutColor.ResumeLayout(false);
            this.tableLayoutColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGradientEndPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGradientStartPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMaterials;
        private System.Windows.Forms.TableLayoutPanel ContentsArea;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Label labelGradientEndPosition;
        private System.Windows.Forms.NumericUpDown numericGradientEndPosition;
        private System.Windows.Forms.Label labelGradientStartPosition;
        private System.Windows.Forms.NumericUpDown numericGradientStartPosition;
        private System.Windows.Forms.Panel panelMaskColor;
        private System.Windows.Forms.Label labelMaskColor;
        private System.Windows.Forms.Panel panelBaseColor;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonReload;
    }
}