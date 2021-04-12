
namespace dental_sys.view
{
    partial class Notification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.CloseBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.NotificationGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.NotificationNumberTable = new System.Windows.Forms.TableLayoutPanel();
            this.NotificationText = new System.Windows.Forms.Label();
            this.NotificationNumber = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DownloadWeightBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.NextPageBtn = new System.Windows.Forms.PictureBox();
            this.NotificationPageNumber = new System.Windows.Forms.Label();
            this.PreviousPageBtn = new System.Windows.Forms.PictureBox();
            this.UpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationGridView)).BeginInit();
            this.NotificationNumberTable.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextPageBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousPageBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.FillColor = System.Drawing.Color.Transparent;
            this.CloseBtn.HoverState.Parent = this.CloseBtn;
            this.CloseBtn.IconColor = System.Drawing.Color.Gray;
            this.CloseBtn.Location = new System.Drawing.Point(403, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(37, 41);
            this.CloseBtn.TabIndex = 14;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.NotificationGridView);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(16, 58);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(406, 454);
            this.guna2ShadowPanel1.TabIndex = 98;
            // 
            // NotificationGridView
            // 
            this.NotificationGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.NotificationGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.NotificationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotificationGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.NotificationGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotificationGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.NotificationGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotificationGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.NotificationGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NotificationGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.NotificationGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotificationGridView.EnableHeadersVisualStyles = false;
            this.NotificationGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.NotificationGridView.Location = new System.Drawing.Point(0, 0);
            this.NotificationGridView.MultiSelect = false;
            this.NotificationGridView.Name = "NotificationGridView";
            this.NotificationGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotificationGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.NotificationGridView.RowHeadersVisible = false;
            this.NotificationGridView.RowTemplate.DividerHeight = 5;
            this.NotificationGridView.RowTemplate.Height = 40;
            this.NotificationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NotificationGridView.Size = new System.Drawing.Size(406, 454);
            this.NotificationGridView.StandardTab = true;
            this.NotificationGridView.TabIndex = 4;
            this.NotificationGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.NotificationGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.NotificationGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.NotificationGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.NotificationGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.NotificationGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.NotificationGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.NotificationGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.NotificationGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.NotificationGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.NotificationGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.NotificationGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.NotificationGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.NotificationGridView.ThemeStyle.ReadOnly = true;
            this.NotificationGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.NotificationGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.NotificationGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.NotificationGridView.ThemeStyle.RowsStyle.Height = 40;
            this.NotificationGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NotificationGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.NotificationGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotificationGridView_CellClick);
            this.NotificationGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotificationGridView_RowLeave);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.TransparentWhileDrag = true;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // NotificationNumberTable
            // 
            this.NotificationNumberTable.ColumnCount = 2;
            this.NotificationNumberTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NotificationNumberTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NotificationNumberTable.Controls.Add(this.NotificationText, 0, 0);
            this.NotificationNumberTable.Controls.Add(this.NotificationNumber, 0, 0);
            this.NotificationNumberTable.Location = new System.Drawing.Point(16, 0);
            this.NotificationNumberTable.Name = "NotificationNumberTable";
            this.NotificationNumberTable.RowCount = 1;
            this.NotificationNumberTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NotificationNumberTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.NotificationNumberTable.Size = new System.Drawing.Size(191, 55);
            this.NotificationNumberTable.TabIndex = 100;
            // 
            // NotificationText
            // 
            this.NotificationText.AutoSize = true;
            this.NotificationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotificationText.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.NotificationText.Location = new System.Drawing.Point(98, 0);
            this.NotificationText.Name = "NotificationText";
            this.NotificationText.Size = new System.Drawing.Size(90, 55);
            this.NotificationText.TabIndex = 4;
            this.NotificationText.Text = "Notifications";
            this.NotificationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotificationNumber
            // 
            this.NotificationNumber.AutoSize = true;
            this.NotificationNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotificationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.NotificationNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NotificationNumber.Location = new System.Drawing.Point(3, 0);
            this.NotificationNumber.Name = "NotificationNumber";
            this.NotificationNumber.Size = new System.Drawing.Size(89, 55);
            this.NotificationNumber.TabIndex = 3;
            this.NotificationNumber.Text = "76";
            this.NotificationNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel4.Controls.Add(this.DownloadWeightBtn, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.UpdateButton, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 531);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(439, 44);
            this.tableLayoutPanel4.TabIndex = 101;
            // 
            // DownloadWeightBtn
            // 
            this.DownloadWeightBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DownloadWeightBtn.BorderRadius = 5;
            this.DownloadWeightBtn.BorderThickness = 1;
            this.DownloadWeightBtn.CheckedState.Parent = this.DownloadWeightBtn;
            this.DownloadWeightBtn.CustomImages.Parent = this.DownloadWeightBtn;
            this.DownloadWeightBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownloadWeightBtn.Enabled = false;
            this.DownloadWeightBtn.FillColor = System.Drawing.Color.Transparent;
            this.DownloadWeightBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DownloadWeightBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DownloadWeightBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DownloadWeightBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.DownloadWeightBtn.HoverState.Parent = this.DownloadWeightBtn;
            this.DownloadWeightBtn.Location = new System.Drawing.Point(330, 3);
            this.DownloadWeightBtn.Name = "DownloadWeightBtn";
            this.DownloadWeightBtn.ShadowDecoration.Parent = this.DownloadWeightBtn;
            this.DownloadWeightBtn.Size = new System.Drawing.Size(86, 38);
            this.DownloadWeightBtn.TabIndex = 4;
            this.DownloadWeightBtn.Text = "Download Weight";
            this.DownloadWeightBtn.Click += new System.EventHandler(this.DownloadWeightBtn_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.NextPageBtn, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.NotificationPageNumber, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.PreviousPageBtn, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(20, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(161, 38);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // NextPageBtn
            // 
            this.NextPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPageBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.NextPageBtn.Image = ((System.Drawing.Image)(resources.GetObject("NextPageBtn.Image")));
            this.NextPageBtn.Location = new System.Drawing.Point(123, 3);
            this.NextPageBtn.Name = "NextPageBtn";
            this.NextPageBtn.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.NextPageBtn.Size = new System.Drawing.Size(35, 32);
            this.NextPageBtn.TabIndex = 11;
            this.NextPageBtn.TabStop = false;
            this.NextPageBtn.Click += new System.EventHandler(this.NextPageBtn_Click);
            // 
            // NotificationPageNumber
            // 
            this.NotificationPageNumber.AutoSize = true;
            this.NotificationPageNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotificationPageNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.NotificationPageNumber.Location = new System.Drawing.Point(43, 0);
            this.NotificationPageNumber.Name = "NotificationPageNumber";
            this.NotificationPageNumber.Size = new System.Drawing.Size(74, 38);
            this.NotificationPageNumber.TabIndex = 10;
            this.NotificationPageNumber.Text = "23/10";
            this.NotificationPageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviousPageBtn
            // 
            this.PreviousPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.PreviousPageBtn.Image = ((System.Drawing.Image)(resources.GetObject("PreviousPageBtn.Image")));
            this.PreviousPageBtn.Location = new System.Drawing.Point(3, 3);
            this.PreviousPageBtn.Name = "PreviousPageBtn";
            this.PreviousPageBtn.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.PreviousPageBtn.Size = new System.Drawing.Size(34, 32);
            this.PreviousPageBtn.TabIndex = 7;
            this.PreviousPageBtn.TabStop = false;
            this.PreviousPageBtn.Click += new System.EventHandler(this.PreviousPageBtn_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UpdateButton.BorderRadius = 5;
            this.UpdateButton.BorderThickness = 1;
            this.UpdateButton.CheckedState.Parent = this.UpdateButton;
            this.UpdateButton.CustomImages.Parent = this.UpdateButton;
            this.UpdateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateButton.FillColor = System.Drawing.Color.Transparent;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UpdateButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UpdateButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.HoverState.Parent = this.UpdateButton;
            this.UpdateButton.Location = new System.Drawing.Point(221, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.ShadowDecoration.Parent = this.UpdateButton;
            this.UpdateButton.Size = new System.Drawing.Size(86, 38);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Delete All Read";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 575);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.NotificationNumberTable);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile";
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NotificationGridView)).EndInit();
            this.NotificationNumberTable.ResumeLayout(false);
            this.NotificationNumberTable.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextPageBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousPageBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox CloseBtn;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView NotificationGridView;
        private System.Windows.Forms.TableLayoutPanel NotificationNumberTable;
        private System.Windows.Forms.Label NotificationText;
        private System.Windows.Forms.Label NotificationNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox NextPageBtn;
        private System.Windows.Forms.Label NotificationPageNumber;
        private System.Windows.Forms.PictureBox PreviousPageBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateButton;
        private Guna.UI2.WinForms.Guna2Button DownloadWeightBtn;
    }
}