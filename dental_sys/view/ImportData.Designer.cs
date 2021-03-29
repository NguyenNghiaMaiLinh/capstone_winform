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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.BottomTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NextBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PreviousBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TopTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImportLabelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ImportDataBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SendBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FileDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PicturePanel = new dental_sys.Controls.PicturePanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.BottomTableLayoutPanel.SuspendLayout();
            this.TopTableLayoutPanel.SuspendLayout();
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
            this.splitContainer.Panel1.Controls.Add(this.BottomTableLayoutPanel);
            this.splitContainer.Panel1.Controls.Add(this.TopTableLayoutPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.FileDataGridView);
            this.splitContainer.Size = new System.Drawing.Size(1560, 935);
            this.splitContainer.SplitterDistance = 1086;
            this.splitContainer.TabIndex = 1;
            // 
            // BottomTableLayoutPanel
            // 
            this.BottomTableLayoutPanel.ColumnCount = 4;
            this.BottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottomTableLayoutPanel.Controls.Add(this.NextBtn, 2, 0);
            this.BottomTableLayoutPanel.Controls.Add(this.PreviousBtn, 1, 0);
            this.BottomTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomTableLayoutPanel.Location = new System.Drawing.Point(0, 862);
            this.BottomTableLayoutPanel.Name = "BottomTableLayoutPanel";
            this.BottomTableLayoutPanel.RowCount = 1;
            this.BottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BottomTableLayoutPanel.Size = new System.Drawing.Size(1086, 73);
            this.BottomTableLayoutPanel.TabIndex = 79;
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
            this.NextBtn.Location = new System.Drawing.Point(545, 3);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.ShadowDecoration.Parent = this.NextBtn;
            this.NextBtn.Size = new System.Drawing.Size(265, 52);
            this.NextBtn.TabIndex = 84;
            this.NextBtn.Text = "Next";
            this.NextBtn.TextOffset = new System.Drawing.Point(1, 2);
            this.NextBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
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
            this.PreviousBtn.Location = new System.Drawing.Point(274, 3);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.ShadowDecoration.Parent = this.PreviousBtn;
            this.PreviousBtn.Size = new System.Drawing.Size(265, 52);
            this.PreviousBtn.TabIndex = 83;
            this.PreviousBtn.Text = "Previous";
            this.PreviousBtn.TextOffset = new System.Drawing.Point(1, 2);
            this.PreviousBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // TopTableLayoutPanel
            // 
            this.TopTableLayoutPanel.ColumnCount = 3;
            this.TopTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTableLayoutPanel.Controls.Add(this.ImportLabelBtn, 0, 0);
            this.TopTableLayoutPanel.Controls.Add(this.ImportDataBtn, 1, 0);
            this.TopTableLayoutPanel.Controls.Add(this.SendBtn, 2, 0);
            this.TopTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TopTableLayoutPanel.Name = "TopTableLayoutPanel";
            this.TopTableLayoutPanel.RowCount = 1;
            this.TopTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TopTableLayoutPanel.Size = new System.Drawing.Size(1086, 46);
            this.TopTableLayoutPanel.TabIndex = 1;
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
            this.ImportLabelBtn.Size = new System.Drawing.Size(356, 40);
            this.ImportLabelBtn.TabIndex = 80;
            this.ImportLabelBtn.Text = "Import Label";
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
            this.ImportDataBtn.Location = new System.Drawing.Point(365, 3);
            this.ImportDataBtn.Name = "ImportDataBtn";
            this.ImportDataBtn.ShadowDecoration.Parent = this.ImportDataBtn;
            this.ImportDataBtn.Size = new System.Drawing.Size(356, 40);
            this.ImportDataBtn.TabIndex = 82;
            this.ImportDataBtn.Text = "Import Data";
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
            this.SendBtn.Location = new System.Drawing.Point(727, 3);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.ShadowDecoration.Parent = this.SendBtn;
            this.SendBtn.Size = new System.Drawing.Size(356, 40);
            this.SendBtn.TabIndex = 83;
            this.SendBtn.Text = "Send";
            this.SendBtn.TextOffset = new System.Drawing.Point(1, 2);
            this.SendBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // FileDataGridView
            // 
            this.FileDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.FileDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.FileDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FileDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FileDataGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FileDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.FileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDataGridView.EnableHeadersVisualStyles = false;
            this.FileDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.FileDataGridView.Location = new System.Drawing.Point(0, 0);
            this.FileDataGridView.Name = "FileDataGridView";
            this.FileDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            // 
            // PicturePanel
            // 
            this.PicturePanel.AutoScroll = true;
            this.PicturePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicturePanel.Location = new System.Drawing.Point(0, 46);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(1086, 816);
            this.PicturePanel.TabIndex = 80;
            // 
            // ImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1560, 935);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportData";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.ImportData_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.BottomTableLayoutPanel.ResumeLayout(false);
            this.TopTableLayoutPanel.ResumeLayout(false);
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
        private PicturePanel PicturePanel;
        private System.Windows.Forms.TableLayoutPanel BottomTableLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button NextBtn;
        private Guna.UI2.WinForms.Guna2Button PreviousBtn;
    }
}