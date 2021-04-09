using dental_sys.Controls;

namespace dental_sys
{
    partial class ImportData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.PicturePanel = new dental_sys.Controls.PicturePanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelText = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ImageText = new System.Windows.Forms.Label();
            this.ImageNumber = new System.Windows.Forms.Label();
            this.TopTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImportLabelDirBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ImportDirBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ImportLabelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ImportDataBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SendBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BottomTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ClearAllInValidFileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NextBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PreviousBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TrainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FileDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TopTableLayoutPanel.SuspendLayout();
            this.BottomTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.PicturePanel);
            this.splitContainer.Panel1.Controls.Add(this.guna2Panel1);
            this.splitContainer.Panel1.Controls.Add(this.BottomTableLayoutPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.FileDataGridView);
            this.splitContainer.Size = new System.Drawing.Size(1560, 935);
            this.splitContainer.SplitterDistance = 1086;
            this.splitContainer.TabIndex = 1;
            // 
            // PicturePanel
            // 
            this.PicturePanel.AutoScroll = true;
            this.PicturePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicturePanel.CtrlKeyDown = true;
            this.PicturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicturePanel.Drag = false;
            this.PicturePanel.Image = null;
            this.PicturePanel.Location = new System.Drawing.Point(0, 104);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(1086, 758);
            this.PicturePanel.TabIndex = 83;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel2);
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel1.Controls.Add(this.TopTableLayoutPanel);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1086, 104);
            this.guna2Panel1.TabIndex = 81;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.LabelText, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelNumber, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(274, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(186, 38);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelText.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.LabelText.Location = new System.Drawing.Point(96, 0);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(87, 38);
            this.LabelText.TabIndex = 4;
            this.LabelText.Text = "Label files";
            this.LabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.LabelNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LabelNumber.Location = new System.Drawing.Point(3, 0);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(87, 38);
            this.LabelNumber.TabIndex = 3;
            this.LabelNumber.Text = "76";
            this.LabelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ImageText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ImageNumber, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 38);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ImageText
            // 
            this.ImageText.AutoSize = true;
            this.ImageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageText.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.ImageText.Location = new System.Drawing.Point(104, 0);
            this.ImageText.Name = "ImageText";
            this.ImageText.Size = new System.Drawing.Size(95, 38);
            this.ImageText.TabIndex = 2;
            this.ImageText.Text = "Images";
            this.ImageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageNumber
            // 
            this.ImageNumber.AutoSize = true;
            this.ImageNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.ImageNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ImageNumber.Location = new System.Drawing.Point(3, 0);
            this.ImageNumber.Name = "ImageNumber";
            this.ImageNumber.Size = new System.Drawing.Size(95, 38);
            this.ImageNumber.TabIndex = 1;
            this.ImageNumber.Text = "76";
            this.ImageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopTableLayoutPanel
            // 
            this.TopTableLayoutPanel.ColumnCount = 5;
            this.TopTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayoutPanel.Controls.Add(this.ImportLabelDirBtn, 2, 0);
            this.TopTableLayoutPanel.Controls.Add(this.ImportDirBtn, 3, 0);
            this.TopTableLayoutPanel.Controls.Add(this.ImportLabelBtn, 0, 0);
            this.TopTableLayoutPanel.Controls.Add(this.ImportDataBtn, 1, 0);
            this.TopTableLayoutPanel.Controls.Add(this.SendBtn, 4, 0);
            this.TopTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TopTableLayoutPanel.Location = new System.Drawing.Point(0, 58);
            this.TopTableLayoutPanel.Name = "TopTableLayoutPanel";
            this.TopTableLayoutPanel.RowCount = 1;
            this.TopTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TopTableLayoutPanel.Size = new System.Drawing.Size(1086, 46);
            this.TopTableLayoutPanel.TabIndex = 1;
            // 
            // ImportLabelDirBtn
            // 
            this.ImportLabelDirBtn.BackColor = System.Drawing.Color.Transparent;
            this.ImportLabelDirBtn.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImportLabelDirBtn.BorderThickness = 1;
            this.ImportLabelDirBtn.CheckedState.Parent = this.ImportLabelDirBtn;
            this.ImportLabelDirBtn.CustomImages.Parent = this.ImportLabelDirBtn;
            this.ImportLabelDirBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportLabelDirBtn.FillColor = System.Drawing.Color.Transparent;
            this.ImportLabelDirBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportLabelDirBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImportLabelDirBtn.HoverState.Parent = this.ImportLabelDirBtn;
            this.ImportLabelDirBtn.Image = ((System.Drawing.Image)(resources.GetObject("ImportLabelDirBtn.Image")));
            this.ImportLabelDirBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ImportLabelDirBtn.ImageOffset = new System.Drawing.Point(3, 0);
            this.ImportLabelDirBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.ImportLabelDirBtn.Location = new System.Drawing.Point(437, 3);
            this.ImportLabelDirBtn.Name = "ImportLabelDirBtn";
            this.ImportLabelDirBtn.ShadowDecoration.Parent = this.ImportLabelDirBtn;
            this.ImportLabelDirBtn.Size = new System.Drawing.Size(211, 40);
            this.ImportLabelDirBtn.TabIndex = 85;
            this.ImportLabelDirBtn.Text = "Label Dir";
            this.ImportLabelDirBtn.TextOffset = new System.Drawing.Point(1, 2);
            this.ImportLabelDirBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ImportLabelDirBtn.Click += new System.EventHandler(this.ImportLabelDirBtn_Click);
            // 
            // ImportDirBtn
            // 
            this.ImportDirBtn.BackColor = System.Drawing.Color.Transparent;
            this.ImportDirBtn.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImportDirBtn.BorderThickness = 1;
            this.ImportDirBtn.CheckedState.Parent = this.ImportDirBtn;
            this.ImportDirBtn.CustomImages.Parent = this.ImportDirBtn;
            this.ImportDirBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportDirBtn.FillColor = System.Drawing.Color.Transparent;
            this.ImportDirBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportDirBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImportDirBtn.HoverState.Parent = this.ImportDirBtn;
            this.ImportDirBtn.Image = ((System.Drawing.Image)(resources.GetObject("ImportDirBtn.Image")));
            this.ImportDirBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ImportDirBtn.ImageOffset = new System.Drawing.Point(3, 0);
            this.ImportDirBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.ImportDirBtn.Location = new System.Drawing.Point(654, 3);
            this.ImportDirBtn.Name = "ImportDirBtn";
            this.ImportDirBtn.ShadowDecoration.Parent = this.ImportDirBtn;
            this.ImportDirBtn.Size = new System.Drawing.Size(211, 40);
            this.ImportDirBtn.TabIndex = 84;
            this.ImportDirBtn.Text = "Image Dir";
            this.ImportDirBtn.TextOffset = new System.Drawing.Point(1, 2);
            this.ImportDirBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ImportDirBtn.Click += new System.EventHandler(this.ImportDirBtn_Click);
            // 
            // ImportLabelBtn
            // 
            this.ImportLabelBtn.BackColor = System.Drawing.Color.Transparent;
            this.ImportLabelBtn.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImportLabelBtn.BorderThickness = 1;
            this.ImportLabelBtn.CheckedState.Parent = this.ImportLabelBtn;
            this.ImportLabelBtn.CustomImages.Parent = this.ImportLabelBtn;
            this.ImportLabelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportLabelBtn.FillColor = System.Drawing.Color.Transparent;
            this.ImportLabelBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportLabelBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImportLabelBtn.HoverState.Parent = this.ImportLabelBtn;
            this.ImportLabelBtn.Image = ((System.Drawing.Image)(resources.GetObject("ImportLabelBtn.Image")));
            this.ImportLabelBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ImportLabelBtn.ImageOffset = new System.Drawing.Point(3, 0);
            this.ImportLabelBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.ImportLabelBtn.Location = new System.Drawing.Point(3, 3);
            this.ImportLabelBtn.Name = "ImportLabelBtn";
            this.ImportLabelBtn.ShadowDecoration.Parent = this.ImportLabelBtn;
            this.ImportLabelBtn.Size = new System.Drawing.Size(211, 40);
            this.ImportLabelBtn.TabIndex = 80;
            this.ImportLabelBtn.Text = "Label";
            this.ImportLabelBtn.TextOffset = new System.Drawing.Point(1, 2);
            this.ImportLabelBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ImportLabelBtn.Click += new System.EventHandler(this.ImportLabelBtn_Click);
            // 
            // ImportDataBtn
            // 
            this.ImportDataBtn.BackColor = System.Drawing.Color.Transparent;
            this.ImportDataBtn.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImportDataBtn.BorderThickness = 1;
            this.ImportDataBtn.CheckedState.Parent = this.ImportDataBtn;
            this.ImportDataBtn.CustomImages.Parent = this.ImportDataBtn;
            this.ImportDataBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportDataBtn.FillColor = System.Drawing.Color.Transparent;
            this.ImportDataBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportDataBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImportDataBtn.HoverState.Parent = this.ImportDataBtn;
            this.ImportDataBtn.Image = ((System.Drawing.Image)(resources.GetObject("ImportDataBtn.Image")));
            this.ImportDataBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ImportDataBtn.ImageOffset = new System.Drawing.Point(3, 0);
            this.ImportDataBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.ImportDataBtn.Location = new System.Drawing.Point(220, 3);
            this.ImportDataBtn.Name = "ImportDataBtn";
            this.ImportDataBtn.ShadowDecoration.Parent = this.ImportDataBtn;
            this.ImportDataBtn.Size = new System.Drawing.Size(211, 40);
            this.ImportDataBtn.TabIndex = 82;
            this.ImportDataBtn.Text = "Image";
            this.ImportDataBtn.TextOffset = new System.Drawing.Point(1, 2);
            this.ImportDataBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ImportDataBtn.Click += new System.EventHandler(this.ImportDataBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.Transparent;
            this.SendBtn.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SendBtn.BorderThickness = 1;
            this.SendBtn.CheckedState.Parent = this.SendBtn;
            this.SendBtn.CustomImages.Parent = this.SendBtn;
            this.SendBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendBtn.FillColor = System.Drawing.Color.Transparent;
            this.SendBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SendBtn.HoverState.Parent = this.SendBtn;
            this.SendBtn.Image = global::dental_sys.Properties.Resources.send;
            this.SendBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SendBtn.ImageOffset = new System.Drawing.Point(3, 0);
            this.SendBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.SendBtn.Location = new System.Drawing.Point(871, 3);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.ShadowDecoration.Parent = this.SendBtn;
            this.SendBtn.Size = new System.Drawing.Size(212, 40);
            this.SendBtn.TabIndex = 83;
            this.SendBtn.Text = "Send";
            this.SendBtn.TextOffset = new System.Drawing.Point(1, 2);
            this.SendBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // BottomTableLayoutPanel
            // 
            this.BottomTableLayoutPanel.ColumnCount = 4;
            this.BottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottomTableLayoutPanel.Controls.Add(this.ClearAllInValidFileBtn, 0, 0);
            this.BottomTableLayoutPanel.Controls.Add(this.NextBtn, 0, 0);
            this.BottomTableLayoutPanel.Controls.Add(this.PreviousBtn, 0, 0);
            this.BottomTableLayoutPanel.Controls.Add(this.TrainBtn, 3, 0);
            this.BottomTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomTableLayoutPanel.Location = new System.Drawing.Point(0, 862);
            this.BottomTableLayoutPanel.Name = "BottomTableLayoutPanel";
            this.BottomTableLayoutPanel.RowCount = 1;
            this.BottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.BottomTableLayoutPanel.Size = new System.Drawing.Size(1086, 73);
            this.BottomTableLayoutPanel.TabIndex = 79;
            // 
            // ClearAllInValidFileBtn
            // 
            this.ClearAllInValidFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearAllInValidFileBtn.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClearAllInValidFileBtn.BorderThickness = 1;
            this.ClearAllInValidFileBtn.CheckedState.Parent = this.ClearAllInValidFileBtn;
            this.ClearAllInValidFileBtn.CustomImages.Parent = this.ClearAllInValidFileBtn;
            this.ClearAllInValidFileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearAllInValidFileBtn.FillColor = System.Drawing.Color.Transparent;
            this.ClearAllInValidFileBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllInValidFileBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearAllInValidFileBtn.HoverState.Parent = this.ClearAllInValidFileBtn;
            this.ClearAllInValidFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("ClearAllInValidFileBtn.Image")));
            this.ClearAllInValidFileBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClearAllInValidFileBtn.ImageOffset = new System.Drawing.Point(3, 0);
            this.ClearAllInValidFileBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.ClearAllInValidFileBtn.Location = new System.Drawing.Point(545, 3);
            this.ClearAllInValidFileBtn.Name = "ClearAllInValidFileBtn";
            this.ClearAllInValidFileBtn.ShadowDecoration.Parent = this.ClearAllInValidFileBtn;
            this.ClearAllInValidFileBtn.Size = new System.Drawing.Size(265, 52);
            this.ClearAllInValidFileBtn.TabIndex = 89;
            this.ClearAllInValidFileBtn.Text = "Clear all invalid file";
            this.ClearAllInValidFileBtn.TextOffset = new System.Drawing.Point(1, 2);
            this.ClearAllInValidFileBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ClearAllInValidFileBtn.Click += new System.EventHandler(this.ClearAllInValidFileBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextBtn.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NextBtn.BorderThickness = 1;
            this.NextBtn.CheckedState.Parent = this.NextBtn;
            this.NextBtn.CustomImages.Parent = this.NextBtn;
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.NextBtn.FillColor = System.Drawing.Color.Transparent;
            this.NextBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NextBtn.HoverState.Parent = this.NextBtn;
            this.NextBtn.Image = ((System.Drawing.Image)(resources.GetObject("NextBtn.Image")));
            this.NextBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NextBtn.ImageOffset = new System.Drawing.Point(3, 0);
            this.NextBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.NextBtn.Location = new System.Drawing.Point(274, 3);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.ShadowDecoration.Parent = this.NextBtn;
            this.NextBtn.Size = new System.Drawing.Size(265, 52);
            this.NextBtn.TabIndex = 88;
            this.NextBtn.Text = "Next";
            this.NextBtn.TextOffset = new System.Drawing.Point(1, 2);
            this.NextBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.BackColor = System.Drawing.Color.Transparent;
            this.PreviousBtn.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PreviousBtn.BorderThickness = 1;
            this.PreviousBtn.CheckedState.Parent = this.PreviousBtn;
            this.PreviousBtn.CustomImages.Parent = this.PreviousBtn;
            this.PreviousBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PreviousBtn.FillColor = System.Drawing.Color.Transparent;
            this.PreviousBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PreviousBtn.HoverState.Parent = this.PreviousBtn;
            this.PreviousBtn.Image = ((System.Drawing.Image)(resources.GetObject("PreviousBtn.Image")));
            this.PreviousBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PreviousBtn.ImageOffset = new System.Drawing.Point(3, 0);
            this.PreviousBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.PreviousBtn.Location = new System.Drawing.Point(3, 3);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.ShadowDecoration.Parent = this.PreviousBtn;
            this.PreviousBtn.Size = new System.Drawing.Size(265, 52);
            this.PreviousBtn.TabIndex = 87;
            this.PreviousBtn.Text = "Previous";
            this.PreviousBtn.TextOffset = new System.Drawing.Point(1, 2);
            this.PreviousBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // TrainBtn
            // 
            this.TrainBtn.BackColor = System.Drawing.Color.Transparent;
            this.TrainBtn.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TrainBtn.BorderThickness = 1;
            this.TrainBtn.CheckedState.Parent = this.TrainBtn;
            this.TrainBtn.CustomImages.Parent = this.TrainBtn;
            this.TrainBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TrainBtn.FillColor = System.Drawing.Color.Transparent;
            this.TrainBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TrainBtn.HoverState.Parent = this.TrainBtn;
            this.TrainBtn.Image = ((System.Drawing.Image)(resources.GetObject("TrainBtn.Image")));
            this.TrainBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TrainBtn.ImageOffset = new System.Drawing.Point(3, 0);
            this.TrainBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.TrainBtn.Location = new System.Drawing.Point(816, 3);
            this.TrainBtn.Name = "TrainBtn";
            this.TrainBtn.ShadowDecoration.Parent = this.TrainBtn;
            this.TrainBtn.Size = new System.Drawing.Size(267, 52);
            this.TrainBtn.TabIndex = 86;
            this.TrainBtn.Text = "Train";
            this.TrainBtn.TextOffset = new System.Drawing.Point(1, 2);
            this.TrainBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // FileDataGridView
            // 
            this.FileDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.FileDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.FileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.FileDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FileDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.FileDataGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FileDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.FileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDataGridView.EnableHeadersVisualStyles = false;
            this.FileDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.FileDataGridView.Location = new System.Drawing.Point(0, 0);
            this.FileDataGridView.MultiSelect = false;
            this.FileDataGridView.Name = "FileDataGridView";
            this.FileDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.FileDataGridView.RowHeadersVisible = false;
            this.FileDataGridView.RowTemplate.DividerHeight = 5;
            this.FileDataGridView.RowTemplate.Height = 40;
            this.FileDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileDataGridView.Size = new System.Drawing.Size(470, 935);
            this.FileDataGridView.StandardTab = true;
            this.FileDataGridView.TabIndex = 5;
            this.FileDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.FileDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FileDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FileDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FileDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FileDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FileDataGridView.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.FileDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.FileDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.FileDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FileDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FileDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.FileDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FileDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.FileDataGridView.ThemeStyle.ReadOnly = true;
            this.FileDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FileDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FileDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.FileDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FileDataGridView.ThemeStyle.RowsStyle.Height = 40;
            this.FileDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FileDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.FileDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FileDataGridView_CellClick);
            this.FileDataGridView.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.FileDataGridView_ColumnAdded);
            this.FileDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FileDataGridView_ColumnHeaderMouseDoubleClick);
            // 
            // ImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1560, 935);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ImportData";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.ImportData_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImportData_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ImportData_KeyUp);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TopTableLayoutPanel.ResumeLayout(false);
            this.BottomTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel TopTableLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button ImportLabelBtn;
        private Guna.UI2.WinForms.Guna2Button ImportDataBtn;
        private Guna.UI2.WinForms.Guna2Button SendBtn;
        private Guna.UI2.WinForms.Guna2DataGridView FileDataGridView;
        private System.Windows.Forms.TableLayoutPanel BottomTableLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button ImportDirBtn;
        private Guna.UI2.WinForms.Guna2Button ImportLabelDirBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ImageText;
        private System.Windows.Forms.Label ImageNumber;
        private Guna.UI2.WinForms.Guna2Button TrainBtn;
        private PicturePanel PicturePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Label LabelNumber;
        private Guna.UI2.WinForms.Guna2Button ClearAllInValidFileBtn;
        private Guna.UI2.WinForms.Guna2Button NextBtn;
        private Guna.UI2.WinForms.Guna2Button PreviousBtn;
    }
}