namespace Lab2
{
    partial class CoinCollectionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.ColumnCombo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.radioButtonDOM = new System.Windows.Forms.RadioButton();
            this.radioButtonSAX = new System.Windows.Forms.RadioButton();
            this.radioButtonLINQ = new System.Windows.Forms.RadioButton();
            this.buttonHtml = new System.Windows.Forms.Button();
            this.buttonINFO = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGrid, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.88889F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 450);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCombo,
            this.ColumnText});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.Size = new System.Drawing.Size(494, 295);
            this.dataGrid.TabIndex = 22;
            this.dataGrid.Text = "dataGridView1";
            // 
            // ColumnCombo
            // 
            this.ColumnCombo.HeaderText = "Parameters";
            this.ColumnCombo.MinimumWidth = 6;
            this.ColumnCombo.Name = "ColumnCombo";
            this.ColumnCombo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCombo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnText
            // 
            this.ColumnText.HeaderText = "Names";
            this.ColumnText.MinimumWidth = 6;
            this.ColumnText.Name = "ColumnText";
            this.ColumnText.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonReset, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonDOM, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonSAX, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonLINQ, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonHtml, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonINFO, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 304);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 143);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Location = new System.Drawing.Point(3, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 65);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReset.Location = new System.Drawing.Point(3, 74);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(137, 66);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // radioButtonDOM
            // 
            this.radioButtonDOM.AutoSize = true;
            this.radioButtonDOM.Location = new System.Drawing.Point(146, 3);
            this.radioButtonDOM.Name = "radioButtonDOM";
            this.radioButtonDOM.Size = new System.Drawing.Size(65, 24);
            this.radioButtonDOM.TabIndex = 2;
            this.radioButtonDOM.TabStop = true;
            this.radioButtonDOM.Text = "DOM";
            this.radioButtonDOM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSAX
            // 
            this.radioButtonSAX.AutoSize = true;
            this.radioButtonSAX.Location = new System.Drawing.Point(263, 3);
            this.radioButtonSAX.Name = "radioButtonSAX";
            this.radioButtonSAX.Size = new System.Drawing.Size(57, 24);
            this.radioButtonSAX.TabIndex = 3;
            this.radioButtonSAX.TabStop = true;
            this.radioButtonSAX.Text = "SAX";
            this.radioButtonSAX.UseVisualStyleBackColor = true;
            // 
            // radioButtonLINQ
            // 
            this.radioButtonLINQ.AutoSize = true;
            this.radioButtonLINQ.Location = new System.Drawing.Point(388, 3);
            this.radioButtonLINQ.Name = "radioButtonLINQ";
            this.radioButtonLINQ.Size = new System.Drawing.Size(63, 24);
            this.radioButtonLINQ.TabIndex = 4;
            this.radioButtonLINQ.TabStop = true;
            this.radioButtonLINQ.Text = "LINQ";
            this.radioButtonLINQ.UseVisualStyleBackColor = true;
            // 
            // buttonHtml
            // 
            this.buttonHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHtml.Location = new System.Drawing.Point(263, 74);
            this.buttonHtml.Name = "buttonHtml";
            this.buttonHtml.Size = new System.Drawing.Size(119, 66);
            this.buttonHtml.TabIndex = 5;
            this.buttonHtml.Text = "To HTML";
            this.buttonHtml.UseVisualStyleBackColor = true;
            this.buttonHtml.Click += new System.EventHandler(this.buttonHtml_Click);
            // 
            // buttonINFO
            // 
            this.buttonINFO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonINFO.Location = new System.Drawing.Point(388, 74);
            this.buttonINFO.Name = "buttonINFO";
            this.buttonINFO.Size = new System.Drawing.Size(103, 66);
            this.buttonINFO.TabIndex = 6;
            this.buttonINFO.Text = "INFO";
            this.buttonINFO.UseVisualStyleBackColor = true;
            this.buttonINFO.Click += new System.EventHandler(this.buttonINFO_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 450);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CoinCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CoinCollectionForm";
            this.Text = "CoinCollection";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RadioButton radioButtonDOM;
        private System.Windows.Forms.RadioButton radioButtonSAX;
        private System.Windows.Forms.RadioButton radioButtonLINQ;
        private System.Windows.Forms.Button buttonHtml;
        private System.Windows.Forms.Button buttonINFO;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnText;
    }
}