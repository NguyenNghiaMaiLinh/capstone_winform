
namespace dental_sys.view
{
    partial class CreateClassVersion
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
            this.Create = new Guna.UI2.WinForms.Guna2Button();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.CreatedDateTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CommitHashTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VersionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DescriptionRichBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Create.BorderRadius = 5;
            this.Create.BorderThickness = 1;
            this.Create.CheckedState.Parent = this.Create;
            this.Create.CustomImages.Parent = this.Create;
            this.Create.FillColor = System.Drawing.Color.Transparent;
            this.Create.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Create.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Create.HoverState.ForeColor = System.Drawing.Color.White;
            this.Create.HoverState.Parent = this.Create;
            this.Create.Location = new System.Drawing.Point(338, 471);
            this.Create.Name = "Create";
            this.Create.ShadowDecoration.Parent = this.Create;
            this.Create.Size = new System.Drawing.Size(84, 30);
            this.Create.TabIndex = 2;
            this.Create.Text = "Create";
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.FillColor = System.Drawing.Color.Transparent;
            this.CloseBtn.HoverState.Parent = this.CloseBtn;
            this.CloseBtn.IconColor = System.Drawing.Color.Gray;
            this.CloseBtn.Location = new System.Drawing.Point(418, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(37, 41);
            this.CloseBtn.TabIndex = 14;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2Panel2);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(16, 58);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(406, 407);
            this.guna2ShadowPanel1.TabIndex = 98;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel2.Location = new System.Drawing.Point(19, 32);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(363, 341);
            this.guna2Panel2.TabIndex = 74;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CreatedDateTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CommitHashTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.VersionTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionRichBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 341);
            this.tableLayoutPanel1.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 239);
            this.label5.TabIndex = 120;
            this.label5.Text = "Description";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreatedDateTextBox
            // 
            this.CreatedDateTextBox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CreatedDateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreatedDateTextBox.DefaultText = "";
            this.CreatedDateTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CreatedDateTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CreatedDateTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreatedDateTextBox.DisabledState.Parent = this.CreatedDateTextBox;
            this.CreatedDateTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreatedDateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatedDateTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreatedDateTextBox.FocusedState.Parent = this.CreatedDateTextBox;
            this.CreatedDateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CreatedDateTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreatedDateTextBox.HoverState.Parent = this.CreatedDateTextBox;
            this.CreatedDateTextBox.Location = new System.Drawing.Point(112, 72);
            this.CreatedDateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreatedDateTextBox.Name = "CreatedDateTextBox";
            this.CreatedDateTextBox.PasswordChar = '\0';
            this.CreatedDateTextBox.PlaceholderText = "Created Date";
            this.CreatedDateTextBox.ReadOnly = true;
            this.CreatedDateTextBox.SelectedText = "";
            this.CreatedDateTextBox.ShadowDecoration.Parent = this.CreatedDateTextBox;
            this.CreatedDateTextBox.Size = new System.Drawing.Size(247, 26);
            this.CreatedDateTextBox.TabIndex = 119;
            // 
            // CommitHashTextBox
            // 
            this.CommitHashTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommitHashTextBox.DefaultText = "";
            this.CommitHashTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CommitHashTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CommitHashTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CommitHashTextBox.DisabledState.Parent = this.CommitHashTextBox;
            this.CommitHashTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CommitHashTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommitHashTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CommitHashTextBox.FocusedState.Parent = this.CommitHashTextBox;
            this.CommitHashTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CommitHashTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CommitHashTextBox.HoverState.Parent = this.CommitHashTextBox;
            this.CommitHashTextBox.Location = new System.Drawing.Point(112, 38);
            this.CommitHashTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CommitHashTextBox.Name = "CommitHashTextBox";
            this.CommitHashTextBox.PasswordChar = '\0';
            this.CommitHashTextBox.PlaceholderText = "Commit Hash";
            this.CommitHashTextBox.SelectedText = "";
            this.CommitHashTextBox.ShadowDecoration.Parent = this.CommitHashTextBox;
            this.CommitHashTextBox.Size = new System.Drawing.Size(247, 26);
            this.CommitHashTextBox.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 34);
            this.label4.TabIndex = 116;
            this.label4.Text = "Created Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 34);
            this.label3.TabIndex = 115;
            this.label3.Text = "Commit Hash";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 34);
            this.label2.TabIndex = 114;
            this.label2.Text = "Version";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VersionTextBox
            // 
            this.VersionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VersionTextBox.DefaultText = "";
            this.VersionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.VersionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.VersionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VersionTextBox.DisabledState.Parent = this.VersionTextBox;
            this.VersionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VersionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VersionTextBox.FocusedState.Parent = this.VersionTextBox;
            this.VersionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.VersionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VersionTextBox.HoverState.Parent = this.VersionTextBox;
            this.VersionTextBox.Location = new System.Drawing.Point(112, 4);
            this.VersionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VersionTextBox.Name = "VersionTextBox";
            this.VersionTextBox.PasswordChar = '\0';
            this.VersionTextBox.PlaceholderText = "Version";
            this.VersionTextBox.ReadOnly = true;
            this.VersionTextBox.SelectedText = "";
            this.VersionTextBox.ShadowDecoration.Parent = this.VersionTextBox;
            this.VersionTextBox.Size = new System.Drawing.Size(247, 26);
            this.VersionTextBox.TabIndex = 117;
            // 
            // DescriptionRichBox
            // 
            this.DescriptionRichBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionRichBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionRichBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DescriptionRichBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DescriptionRichBox.Location = new System.Drawing.Point(111, 105);
            this.DescriptionRichBox.Name = "DescriptionRichBox";
            this.DescriptionRichBox.Size = new System.Drawing.Size(249, 233);
            this.DescriptionRichBox.TabIndex = 121;
            this.DescriptionRichBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(131, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 90;
            this.label1.Text = "Class version";
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
            // CreateClassVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateClassVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile";
            this.Deactivate += new System.EventHandler(this.Profile_Deactivate);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.Leave += new System.EventHandler(this.Profile_Leave);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Create;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBtn;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox CreatedDateTextBox;
        private Guna.UI2.WinForms.Guna2TextBox CommitHashTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox VersionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox DescriptionRichBox;
    }
}