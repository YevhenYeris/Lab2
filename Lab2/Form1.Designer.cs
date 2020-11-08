namespace Lab2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.comboBoxComposition = new System.Windows.Forms.ComboBox();
            this.comboBoxEdge = new System.Windows.Forms.ComboBox();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.labelShape = new System.Windows.Forms.Label();
            this.labelComposition = new System.Windows.Forms.Label();
            this.labelEdge = new System.Windows.Forms.Label();
            this.labelTheme = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonDOM = new System.Windows.Forms.RadioButton();
            this.radioButtonSAX = new System.Windows.Forms.RadioButton();
            this.radioButtonLINQ = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonToHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCountry, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxType, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxYear, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxValue, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCurrency, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxShape, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxComposition, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxEdge, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxTheme, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.labelCountry, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelType, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelYear, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelValue, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelCurrency, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelShape, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelComposition, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelEdge, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.labelTheme, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.892326F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.892326F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.892326F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.892326F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.892326F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.892326F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.892326F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.004831F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.28986F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.20738F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 450);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(3, 39);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(169, 28);
            this.comboBoxCountry.Sorted = true;
            this.comboBoxCountry.TabIndex = 0;
            this.comboBoxCountry.Text = "Усі";
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Обігова",
            "Тематична"});
            this.comboBoxType.Location = new System.Drawing.Point(3, 67);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(169, 28);
            this.comboBoxType.Sorted = true;
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.Text = "Усі";
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            this.comboBoxType.DropDownStyleChanged += new System.EventHandler(this.comboBoxType_DropDownStyleChanged);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(3, 95);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(169, 28);
            this.comboBoxYear.Sorted = true;
            this.comboBoxYear.TabIndex = 2;
            this.comboBoxYear.Text = "Усі";
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(3, 123);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(169, 28);
            this.comboBoxValue.Sorted = true;
            this.comboBoxValue.TabIndex = 3;
            this.comboBoxValue.Text = "Усі";
            this.comboBoxValue.SelectedIndexChanged += new System.EventHandler(this.comboBoxValue_SelectedIndexChanged);
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(3, 151);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(169, 28);
            this.comboBoxCurrency.Sorted = true;
            this.comboBoxCurrency.TabIndex = 4;
            this.comboBoxCurrency.Text = "Усі";
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Location = new System.Drawing.Point(3, 179);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(169, 28);
            this.comboBoxShape.Sorted = true;
            this.comboBoxShape.TabIndex = 5;
            this.comboBoxShape.Text = "Усі";
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxShape_SelectedIndexChanged);
            // 
            // comboBoxComposition
            // 
            this.comboBoxComposition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxComposition.FormattingEnabled = true;
            this.comboBoxComposition.Location = new System.Drawing.Point(3, 207);
            this.comboBoxComposition.Name = "comboBoxComposition";
            this.comboBoxComposition.Size = new System.Drawing.Size(169, 28);
            this.comboBoxComposition.Sorted = true;
            this.comboBoxComposition.TabIndex = 6;
            this.comboBoxComposition.Text = "Усі";
            this.comboBoxComposition.SelectedIndexChanged += new System.EventHandler(this.comboBoxComposition_SelectedIndexChanged);
            // 
            // comboBoxEdge
            // 
            this.comboBoxEdge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxEdge.FormattingEnabled = true;
            this.comboBoxEdge.Location = new System.Drawing.Point(3, 235);
            this.comboBoxEdge.Name = "comboBoxEdge";
            this.comboBoxEdge.Size = new System.Drawing.Size(169, 28);
            this.comboBoxEdge.Sorted = true;
            this.comboBoxEdge.TabIndex = 7;
            this.comboBoxEdge.Text = "Усі";
            this.comboBoxEdge.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdge_SelectedIndexChanged);
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Location = new System.Drawing.Point(3, 264);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(169, 28);
            this.comboBoxTheme.Sorted = true;
            this.comboBoxTheme.TabIndex = 8;
            this.comboBoxTheme.Text = "Усі";
            this.comboBoxTheme.Visible = false;
            this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountry.Location = new System.Drawing.Point(178, 36);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(169, 28);
            this.labelCountry.TabIndex = 10;
            this.labelCountry.Text = "Країна";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelType.Location = new System.Drawing.Point(178, 64);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(169, 28);
            this.labelType.TabIndex = 11;
            this.labelType.Text = "Тип";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelYear.Location = new System.Drawing.Point(178, 92);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(169, 28);
            this.labelYear.TabIndex = 12;
            this.labelYear.Text = "Рік";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValue.Location = new System.Drawing.Point(178, 120);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(169, 28);
            this.labelValue.TabIndex = 13;
            this.labelValue.Text = "Номінал";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrency.Location = new System.Drawing.Point(178, 148);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(169, 28);
            this.labelCurrency.TabIndex = 14;
            this.labelCurrency.Text = "Валютна одиниця";
            // 
            // labelShape
            // 
            this.labelShape.AutoSize = true;
            this.labelShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelShape.Location = new System.Drawing.Point(178, 176);
            this.labelShape.Name = "labelShape";
            this.labelShape.Size = new System.Drawing.Size(169, 28);
            this.labelShape.TabIndex = 15;
            this.labelShape.Text = "Форма";
            // 
            // labelComposition
            // 
            this.labelComposition.AutoSize = true;
            this.labelComposition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelComposition.Location = new System.Drawing.Point(178, 204);
            this.labelComposition.Name = "labelComposition";
            this.labelComposition.Size = new System.Drawing.Size(169, 28);
            this.labelComposition.TabIndex = 16;
            this.labelComposition.Text = "Сплав";
            // 
            // labelEdge
            // 
            this.labelEdge.AutoSize = true;
            this.labelEdge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEdge.Location = new System.Drawing.Point(178, 232);
            this.labelEdge.Name = "labelEdge";
            this.labelEdge.Size = new System.Drawing.Size(169, 29);
            this.labelEdge.TabIndex = 17;
            this.labelEdge.Text = "Гурт";
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTheme.Location = new System.Drawing.Point(178, 261);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(169, 84);
            this.labelTheme.TabIndex = 18;
            this.labelTheme.Text = "Тема";
            this.labelTheme.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtonDOM, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonSAX, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonLINQ, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(178, 348);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 99);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // radioButtonDOM
            // 
            this.radioButtonDOM.AutoSize = true;
            this.radioButtonDOM.Location = new System.Drawing.Point(3, 3);
            this.radioButtonDOM.Name = "radioButtonDOM";
            this.radioButtonDOM.Size = new System.Drawing.Size(65, 24);
            this.radioButtonDOM.TabIndex = 0;
            this.radioButtonDOM.TabStop = true;
            this.radioButtonDOM.Text = "DOM";
            this.radioButtonDOM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSAX
            // 
            this.radioButtonSAX.AutoSize = true;
            this.radioButtonSAX.Location = new System.Drawing.Point(3, 35);
            this.radioButtonSAX.Name = "radioButtonSAX";
            this.radioButtonSAX.Size = new System.Drawing.Size(57, 24);
            this.radioButtonSAX.TabIndex = 1;
            this.radioButtonSAX.TabStop = true;
            this.radioButtonSAX.Text = "SAX";
            this.radioButtonSAX.UseVisualStyleBackColor = true;
            // 
            // radioButtonLINQ
            // 
            this.radioButtonLINQ.AutoSize = true;
            this.radioButtonLINQ.Location = new System.Drawing.Point(3, 67);
            this.radioButtonLINQ.Name = "radioButtonLINQ";
            this.radioButtonLINQ.Size = new System.Drawing.Size(63, 24);
            this.radioButtonLINQ.TabIndex = 2;
            this.radioButtonLINQ.TabStop = true;
            this.radioButtonLINQ.Text = "LINQ";
            this.radioButtonLINQ.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 348);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(169, 99);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Застосувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 44);
            this.button3.TabIndex = 10;
            this.button3.Text = "Скинути";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(175, 27);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonToHtml});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // buttonToHtml
            // 
            this.buttonToHtml.Name = "buttonToHtml";
            this.buttonToHtml.Size = new System.Drawing.Size(141, 26);
            this.buttonToHtml.Text = "ToHtml";
            this.buttonToHtml.Click += new System.EventHandler(this.buttonToHtml_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(446, 450);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.ComboBox comboBoxComposition;
        private System.Windows.Forms.ComboBox comboBoxEdge;
        private System.Windows.Forms.ComboBox comboBoxTheme;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label labelShape;
        private System.Windows.Forms.Label labelComposition;
        private System.Windows.Forms.Label labelEdge;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonDOM;
        private System.Windows.Forms.RadioButton radioButtonSAX;
        private System.Windows.Forms.RadioButton radioButtonLINQ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem buttonToHtml;
    }
}

