namespace WikiNotes
{
    partial class frmWiki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWiki));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtJump = new System.Windows.Forms.TextBox();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.SystemColors.Window;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tlpMain.Controls.Add(this.rtbMain, 0, 0);
            this.tlpMain.Controls.Add(this.panel1, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpMain.Size = new System.Drawing.Size(539, 391);
            this.tlpMain.TabIndex = 1;
            // 
            // rtbMain
            // 
            this.rtbMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlpMain.SetColumnSpan(this.rtbMain, 2);
            this.rtbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMain.Location = new System.Drawing.Point(6, 6);
            this.rtbMain.Margin = new System.Windows.Forms.Padding(6);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(527, 334);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            this.rtbMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMain_KeyDown);
            this.rtbMain.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.OnLinkClicked);
            this.rtbMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            this.rtbMain.TextChanged += new System.EventHandler(this.rtbMain_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.txtJump);
            this.panel1.Controls.Add(this.btnPreviousPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 349);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(533, 39);
            this.panel1.TabIndex = 4;
            // 
            // txtJump
            // 
            this.txtJump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJump.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtJump.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtJump.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtJump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJump.ForeColor = System.Drawing.Color.White;
            this.txtJump.Location = new System.Drawing.Point(347, 8);
            this.txtJump.Name = "txtJump";
            this.txtJump.Size = new System.Drawing.Size(182, 21);
            this.txtJump.TabIndex = 3;
            this.txtJump.WordWrap = false;
            this.txtJump.TextChanged += new System.EventHandler(this.txtJump_TextChanged);
            this.txtJump.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnJumpEntered);
            this.txtJump.Leave += new System.EventHandler(this.OnLeavingSearchbox);
            this.txtJump.Enter += new System.EventHandler(this.OnEnteringSearchbox);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.AutoSize = true;
            this.btnPreviousPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPreviousPage.BackgroundImage")));
            this.btnPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreviousPage.Enabled = false;
            this.btnPreviousPage.Location = new System.Drawing.Point(2, 8);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnPreviousPage.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousPage.TabIndex = 2;
            this.btnPreviousPage.Text = "Previous";
            this.btnPreviousPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // frmWiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 391);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWiki";
            this.tlpMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.TextBox txtJump;
        private System.Windows.Forms.Panel panel1;
    }
}

