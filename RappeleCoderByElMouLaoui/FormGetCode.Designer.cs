namespace RappeleCoderByElMouLaoui
{
    partial class FormGetCode
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_nameCode = new System.Windows.Forms.ComboBox();
            this.cbx_langage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.نسخToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Code :";
            // 
            // cbx_nameCode
            // 
            this.cbx_nameCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_nameCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_nameCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_nameCode.FormattingEnabled = true;
            this.cbx_nameCode.Location = new System.Drawing.Point(107, 16);
            this.cbx_nameCode.Name = "cbx_nameCode";
            this.cbx_nameCode.Size = new System.Drawing.Size(453, 21);
            this.cbx_nameCode.TabIndex = 1;
            this.cbx_nameCode.SelectedIndexChanged += new System.EventHandler(this.cbx_nameCode_SelectedIndexChanged);
            this.cbx_nameCode.TextChanged += new System.EventHandler(this.cbx_nameCode_TextChanged);
            // 
            // cbx_langage
            // 
            this.cbx_langage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_langage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_langage.FormattingEnabled = true;
            this.cbx_langage.Location = new System.Drawing.Point(691, 18);
            this.cbx_langage.Name = "cbx_langage";
            this.cbx_langage.Size = new System.Drawing.Size(89, 21);
            this.cbx_langage.TabIndex = 3;
            this.cbx_langage.SelectedIndexChanged += new System.EventHandler(this.cbx_langage_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name Longage :";
            // 
            // txt_code
            // 
            this.txt_code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_code.ContextMenuStrip = this.contextMenuStrip1;
            this.txt_code.Location = new System.Drawing.Point(0, 51);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(780, 349);
            this.txt_code.TabIndex = 4;
            this.txt_code.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.نسخToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 48);
            // 
            // نسخToolStripMenuItem
            // 
            this.نسخToolStripMenuItem.Name = "نسخToolStripMenuItem";
            this.نسخToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.نسخToolStripMenuItem.Text = "نسخ";
            this.نسخToolStripMenuItem.Click += new System.EventHandler(this.نسخToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // FormGetCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 396);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.cbx_langage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_nameCode);
            this.Controls.Add(this.label1);
            this.Name = "FormGetCode";
            this.Text = "FormGetCode";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_nameCode;
        private System.Windows.Forms.ComboBox cbx_langage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_code;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem نسخToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
    }
}