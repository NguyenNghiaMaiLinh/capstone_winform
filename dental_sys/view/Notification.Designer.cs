
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.CloseBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.NotificationGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.NextPageBtn = new System.Windows.Forms.PictureBox();
            this.NotificationPageNumber = new System.Windows.Forms.Label();
            this.PreviousPageBtn = new System.Windows.Forms.PictureBox();
            this.NotificationNumberTable = new System.Windows.Forms.TableLayoutPanel();
            this.NotificationText = new System.Windows.Forms.Label();
            this.NotificationNumber = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextPageBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousPageBtn)).BeginInit();
            this.NotificationNumberTable.SuspendLayout();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.NotificationGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.NotificationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotificationGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.NotificationGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotificationGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.NotificationGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotificationGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.NotificationGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NotificationGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.NotificationGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotificationGridView.EnableHeadersVisualStyles = false;
            this.NotificationGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.NotificationGridView.Location = new System.Drawing.Point(0, 0);
            this.NotificationGridView.Name = "NotificationGridView";
            this.NotificationGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotificationGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.NotificationGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.NotificationGridView_RowStateChanged);
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
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 531);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(439, 44);
            this.tableLayoutPanel4.TabIndex = 99;
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
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(112, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(213, 38);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // NextPageBtn
            // 
            this.NextPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPageBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.NextPageBtn.Image = ((System.Drawing.Image)(resources.GetObject("NextPageBtn.Image")));
            this.NextPageBtn.Location = new System.Drawing.Point(162, 3);
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
            this.NotificationPageNumber.Location = new System.Drawing.Point(56, 0);
            this.NotificationPageNumber.Name = "NotificationPageNumber";
            this.NotificationPageNumber.Size = new System.Drawing.Size(100, 38);
            this.NotificationPageNumber.TabIndex = 10;
            this.NotificationPageNumber.Text = "23/10";
            this.NotificationPageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviousPageBtn
            // 
            this.PreviousPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.PreviousPageBtn.Image = ((System.Drawing.Image)(resources.GetObject("PreviousPageBtn.Image")));
            this.PreviousPageBtn.Location = new System.Drawing.Point(16, 3);
            this.PreviousPageBtn.Name = "PreviousPageBtn";
            this.PreviousPageBtn.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.PreviousPageBtn.Size = new System.Drawing.Size(34, 32);
            this.PreviousPageBtn.TabIndex = 7;
            this.PreviousPageBtn.TabStop = false;
            this.PreviousPageBtn.Click += new System.EventHandler(this.PreviousPageBtn_Click);
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
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 575);
            this.Controls.Add(this.NotificationNumberTable);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile";
            this.Deactivate += new System.EventHandler(this.Profile_Deactivate);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NotificationGridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextPageBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousPageBtn)).EndInit();
            this.NotificationNumberTable.ResumeLayout(false);
            this.NotificationNumberTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox CloseBtn;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView NotificationGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox NextPageBtn;
        private System.Windows.Forms.Label NotificationPageNumber;
        private System.Windows.Forms.PictureBox PreviousPageBtn;
        private System.Windows.Forms.TableLayoutPanel NotificationNumberTable;
        private System.Windows.Forms.Label NotificationText;
        private System.Windows.Forms.Label NotificationNumber;
    }
}