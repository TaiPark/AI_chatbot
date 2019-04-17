namespace AIRobot
{
    partial class logIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logIn));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.btnReset = new CCWin.SkinControl.SkinButton();
            this.btnAbout = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.SlateBlue;
            this.skinLabel1.Location = new System.Drawing.Point(133, 145);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(180, 28);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "请问你叫什么吖？";
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.BackgroundImage")));
            this.skinPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinPictureBox1.Location = new System.Drawing.Point(47, 127);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(67, 63);
            this.skinPictureBox1.TabIndex = 1;
            this.skinPictureBox1.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.tbName.Location = new System.Drawing.Point(62, 249);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(230, 33);
            this.tbName.TabIndex = 2;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DownBack = null;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOK.Location = new System.Drawing.Point(102, 322);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(143, 32);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BaseColor = System.Drawing.Color.SlateGray;
            this.btnReset.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnReset.DownBack = null;
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReset.Location = new System.Drawing.Point(102, 378);
            this.btnReset.MouseBack = null;
            this.btnReset.Name = "btnReset";
            this.btnReset.NormlBack = null;
            this.btnReset.Size = new System.Drawing.Size(143, 32);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BaseColor = System.Drawing.Color.SlateGray;
            this.btnAbout.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAbout.DownBack = null;
            this.btnAbout.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAbout.Location = new System.Drawing.Point(102, 435);
            this.btnAbout.MouseBack = null;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.NormlBack = null;
            this.btnAbout.Size = new System.Drawing.Size(143, 32);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(355, 533);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.skinLabel1);
            this.MaximizeBox = false;
            this.Name = "logIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "··南理工小紫··";
            this.TitleCenter = true;
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private System.Windows.Forms.TextBox tbName;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinButton btnReset;
        private CCWin.SkinControl.SkinButton btnAbout;
    }
}