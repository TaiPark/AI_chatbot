namespace AIRobot
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnSend = new CCWin.SkinControl.SkinButton();
            this.btnClose = new CCWin.SkinControl.SkinButton();
            this.picRobot = new CCWin.SkinControl.SkinPictureBox();
            this.btnChange = new CCWin.SkinControl.SkinButton();
            this.rbE = new CCWin.SkinControl.SkinRadioButton();
            this.rbCE = new CCWin.SkinControl.SkinRadioButton();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.picPhoto = new CCWin.SkinControl.SkinPictureBox();
            this.lbName = new CCWin.SkinControl.SkinLabel();
            this.lbSign = new CCWin.SkinControl.SkinLabel();
            this.lbMyName = new CCWin.SkinControl.SkinLabel();
            this.tbReceive = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRobot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnSend.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSend.DownBack = null;
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSend.Location = new System.Drawing.Point(506, 562);
            this.btnSend.MouseBack = null;
            this.btnSend.Name = "btnSend";
            this.btnSend.NormlBack = null;
            this.btnSend.Size = new System.Drawing.Size(79, 32);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.SlateGray;
            this.btnClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClose.DownBack = null;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(421, 562);
            this.btnClose.MouseBack = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormlBack = null;
            this.btnClose.Size = new System.Drawing.Size(79, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picRobot
            // 
            this.picRobot.BackColor = System.Drawing.Color.Transparent;
            this.picRobot.Image = ((System.Drawing.Image)(resources.GetObject("picRobot.Image")));
            this.picRobot.Location = new System.Drawing.Point(485, 112);
            this.picRobot.Name = "picRobot";
            this.picRobot.Size = new System.Drawing.Size(145, 366);
            this.picRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRobot.TabIndex = 5;
            this.picRobot.TabStop = false;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnChange.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnChange.DownBack = null;
            this.btnChange.Font = new System.Drawing.Font("Trajan Pro 3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.Window;
            this.btnChange.Location = new System.Drawing.Point(591, 562);
            this.btnChange.MouseBack = null;
            this.btnChange.Name = "btnChange";
            this.btnChange.NormlBack = null;
            this.btnChange.Size = new System.Drawing.Size(28, 32);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "↓";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // rbE
            // 
            this.rbE.AutoSize = true;
            this.rbE.BackColor = System.Drawing.Color.Transparent;
            this.rbE.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rbE.DownBack = null;
            this.rbE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbE.Location = new System.Drawing.Point(148, 611);
            this.rbE.MouseBack = null;
            this.rbE.Name = "rbE";
            this.rbE.NormlBack = null;
            this.rbE.SelectedDownBack = null;
            this.rbE.SelectedMouseBack = null;
            this.rbE.SelectedNormlBack = null;
            this.rbE.Size = new System.Drawing.Size(128, 21);
            this.rbE.TabIndex = 7;
            this.rbE.TabStop = true;
            this.rbE.Text = "按Enter键发送信息";
            this.rbE.UseVisualStyleBackColor = false;
            this.rbE.Visible = false;
            this.rbE.Click += new System.EventHandler(this.rbE_Click);
            // 
            // rbCE
            // 
            this.rbCE.AutoSize = true;
            this.rbCE.BackColor = System.Drawing.Color.Transparent;
            this.rbCE.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rbCE.DownBack = null;
            this.rbCE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbCE.Location = new System.Drawing.Point(384, 611);
            this.rbCE.MouseBack = null;
            this.rbCE.Name = "rbCE";
            this.rbCE.NormlBack = null;
            this.rbCE.SelectedDownBack = null;
            this.rbCE.SelectedMouseBack = null;
            this.rbCE.SelectedNormlBack = null;
            this.rbCE.Size = new System.Drawing.Size(157, 21);
            this.rbCE.TabIndex = 8;
            this.rbCE.TabStop = true;
            this.rbCE.Text = "按Ctrl+Enter键发送信息";
            this.rbCE.UseVisualStyleBackColor = false;
            this.rbCE.Visible = false;
            this.rbCE.Click += new System.EventHandler(this.rbCE_Click);
            // 
            // tbSend
            // 
            this.tbSend.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSend.Location = new System.Drawing.Point(37, 497);
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(548, 34);
            this.tbSend.TabIndex = 9;
            this.tbSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSend_KeyDown);
            // 
            // picPhoto
            // 
            this.picPhoto.BackColor = System.Drawing.Color.Transparent;
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picPhoto.Image")));
            this.picPhoto.Location = new System.Drawing.Point(37, 40);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(60, 56);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 10;
            this.picPhoto.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.BorderColor = System.Drawing.Color.White;
            this.lbName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbName.Location = new System.Drawing.Point(114, 40);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(117, 28);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "南理工小紫";
            // 
            // lbSign
            // 
            this.lbSign.AutoSize = true;
            this.lbSign.BackColor = System.Drawing.Color.Transparent;
            this.lbSign.BorderColor = System.Drawing.Color.White;
            this.lbSign.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSign.Location = new System.Drawing.Point(116, 79);
            this.lbSign.Name = "lbSign";
            this.lbSign.Size = new System.Drawing.Size(260, 17);
            this.lbSign.TabIndex = 12;
            this.lbSign.Text = "进德 修业 志道 鼎新，欢迎和小紫一起聊天呀！";
            // 
            // lbMyName
            // 
            this.lbMyName.AutoSize = true;
            this.lbMyName.BackColor = System.Drawing.Color.Transparent;
            this.lbMyName.BorderColor = System.Drawing.Color.White;
            this.lbMyName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMyName.Location = new System.Drawing.Point(503, 40);
            this.lbMyName.Name = "lbMyName";
            this.lbMyName.Size = new System.Drawing.Size(0, 17);
            this.lbMyName.TabIndex = 13;
            this.lbMyName.Visible = false;
            // 
            // tbReceive
            // 
            this.tbReceive.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbReceive.ForeColor = System.Drawing.Color.SlateBlue;
            this.tbReceive.Location = new System.Drawing.Point(37, 112);
            this.tbReceive.Multiline = true;
            this.tbReceive.Name = "tbReceive";
            this.tbReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReceive.Size = new System.Drawing.Size(442, 366);
            this.tbReceive.TabIndex = 14;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(653, 641);
            this.Controls.Add(this.tbReceive);
            this.Controls.Add(this.lbMyName);
            this.Controls.Add(this.lbSign);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.rbCE);
            this.Controls.Add(this.rbE);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.picRobot);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.EffectBack = System.Drawing.Color.MediumPurple;
            this.EffectWidth = 3;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Radius = 40;
            this.RoundStyle = CCWin.SkinClass.RoundStyle.BottomRight;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "聊天机器人";
            this.TitleCenter = true;
            this.TitleColor = System.Drawing.Color.GhostWhite;
            ((System.ComponentModel.ISupportInitialize)(this.picRobot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnSend;
        private CCWin.SkinControl.SkinButton btnClose;
        private CCWin.SkinControl.SkinPictureBox picRobot;
        private CCWin.SkinControl.SkinButton btnChange;
        private CCWin.SkinControl.SkinRadioButton rbE;
        private CCWin.SkinControl.SkinRadioButton rbCE;
        private System.Windows.Forms.TextBox tbSend;
        private CCWin.SkinControl.SkinPictureBox picPhoto;
        private CCWin.SkinControl.SkinLabel lbName;
        private CCWin.SkinControl.SkinLabel lbSign;
        private CCWin.SkinControl.SkinLabel lbMyName;
        private System.Windows.Forms.TextBox tbReceive;
    }
}

