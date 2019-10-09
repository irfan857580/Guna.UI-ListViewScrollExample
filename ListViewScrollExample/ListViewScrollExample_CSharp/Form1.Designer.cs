namespace ListViewScrollExample_CSharp
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
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
            this.ListView1.Location = new System.Drawing.Point(27, 51);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(611, 352);
            this.ListView1.TabIndex = 3;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.Resize += new System.EventHandler(this.ListView1_Resize);
            // 
            // GunaVScrollBar1
            // 
            this.GunaVScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaVScrollBar1.LargeChange = 10;
            this.GunaVScrollBar1.Location = new System.Drawing.Point(644, 51);
            this.GunaVScrollBar1.Maximum = 100;
            this.GunaVScrollBar1.Name = "GunaVScrollBar1";
            this.GunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.GunaVScrollBar1.Size = new System.Drawing.Size(10, 200);
            this.GunaVScrollBar1.TabIndex = 2;
            this.GunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.GunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.GunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 454);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.GunaVScrollBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal Guna.UI.WinForms.GunaVScrollBar GunaVScrollBar1;
    }
}

