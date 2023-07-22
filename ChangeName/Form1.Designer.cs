
namespace ChangeName
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ChangeNameBtn = new System.Windows.Forms.Button();
            this.textBoxWS = new System.Windows.Forms.TextBox();
            this.weishuweiming = new System.Windows.Forms.Label();
            this.textNameInput = new System.Windows.Forms.TextBox();
            this.tishinewname = new System.Windows.Forms.Label();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.xiahuaxian = new System.Windows.Forms.Label();
            this.checkXHX = new System.Windows.Forms.CheckBox();
            this.pictureBoxGif = new System.Windows.Forms.PictureBox();
            this.textBoxKzm = new System.Windows.Forms.TextBox();
            this.kzmlaber = new System.Windows.Forms.Label();
            this.xiugaikzm = new System.Windows.Forms.Label();
            this.checkBoxKzm = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearKzm = new System.Windows.Forms.CheckBox();
            this.checkFileOrFolder = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChooseFileOrFolder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeNameBtn
            // 
            this.ChangeNameBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.ChangeNameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeNameBtn.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChangeNameBtn.Location = new System.Drawing.Point(337, 291);
            this.ChangeNameBtn.Name = "ChangeNameBtn";
            this.ChangeNameBtn.Size = new System.Drawing.Size(400, 44);
            this.ChangeNameBtn.TabIndex = 0;
            this.ChangeNameBtn.Text = "一键修改";
            this.ChangeNameBtn.UseVisualStyleBackColor = false;
            this.ChangeNameBtn.Click += new System.EventHandler(this.ChangeBtn);
            // 
            // textBoxWS
            // 
            this.textBoxWS.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxWS.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxWS.Location = new System.Drawing.Point(443, 80);
            this.textBoxWS.Name = "textBoxWS";
            this.textBoxWS.Size = new System.Drawing.Size(74, 30);
            this.textBoxWS.TabIndex = 1;
            this.textBoxWS.Text = "1";
            this.textBoxWS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weishuweiming
            // 
            this.weishuweiming.BackColor = System.Drawing.Color.Yellow;
            this.weishuweiming.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.weishuweiming.Location = new System.Drawing.Point(338, 79);
            this.weishuweiming.Name = "weishuweiming";
            this.weishuweiming.Size = new System.Drawing.Size(99, 30);
            this.weishuweiming.TabIndex = 3;
            this.weishuweiming.Text = "尾数位数:";
            this.weishuweiming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textNameInput
            // 
            this.textNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textNameInput.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNameInput.Location = new System.Drawing.Point(337, 254);
            this.textNameInput.Name = "textNameInput";
            this.textNameInput.Size = new System.Drawing.Size(400, 31);
            this.textNameInput.TabIndex = 4;
            // 
            // tishinewname
            // 
            this.tishinewname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tishinewname.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tishinewname.Location = new System.Drawing.Point(338, 221);
            this.tishinewname.Name = "tishinewname";
            this.tishinewname.Size = new System.Drawing.Size(179, 30);
            this.tishinewname.TabIndex = 5;
            this.tishinewname.Text = "请输入新的文件名:";
            this.tishinewname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectBtn
            // 
            this.SelectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectBtn.BackgroundImage")));
            this.SelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectBtn.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectBtn.Image = ((System.Drawing.Image)(resources.GetObject("SelectBtn.Image")));
            this.SelectBtn.Location = new System.Drawing.Point(337, 27);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(400, 44);
            this.SelectBtn.TabIndex = 6;
            this.SelectBtn.Text = "点击选择文件夹(拖拽文件夹到此处也可)";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectFolder);
            // 
            // labelMsg
            // 
            this.labelMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelMsg.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMsg.Location = new System.Drawing.Point(560, 127);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(83, 30);
            this.labelMsg.TabIndex = 2;
            this.labelMsg.Text = "null";
            this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xiahuaxian
            // 
            this.xiahuaxian.BackColor = System.Drawing.Color.Aqua;
            this.xiahuaxian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xiahuaxian.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xiahuaxian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xiahuaxian.Location = new System.Drawing.Point(560, 82);
            this.xiahuaxian.Name = "xiahuaxian";
            this.xiahuaxian.Size = new System.Drawing.Size(83, 30);
            this.xiahuaxian.TabIndex = 8;
            this.xiahuaxian.Text = "下划线:";
            this.xiahuaxian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkXHX
            // 
            this.checkXHX.AutoSize = true;
            this.checkXHX.Location = new System.Drawing.Point(649, 94);
            this.checkXHX.Name = "checkXHX";
            this.checkXHX.Size = new System.Drawing.Size(15, 14);
            this.checkXHX.TabIndex = 9;
            this.checkXHX.UseVisualStyleBackColor = true;
            this.checkXHX.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBoxGif
            // 
            this.pictureBoxGif.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGif.Image")));
            this.pictureBoxGif.Location = new System.Drawing.Point(443, 331);
            this.pictureBoxGif.Name = "pictureBoxGif";
            this.pictureBoxGif.Size = new System.Drawing.Size(178, 117);
            this.pictureBoxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGif.TabIndex = 10;
            this.pictureBoxGif.TabStop = false;
            // 
            // textBoxKzm
            // 
            this.textBoxKzm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxKzm.Location = new System.Drawing.Point(439, 149);
            this.textBoxKzm.Name = "textBoxKzm";
            this.textBoxKzm.Size = new System.Drawing.Size(78, 26);
            this.textBoxKzm.TabIndex = 11;
            // 
            // kzmlaber
            // 
            this.kzmlaber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kzmlaber.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kzmlaber.Location = new System.Drawing.Point(338, 146);
            this.kzmlaber.Name = "kzmlaber";
            this.kzmlaber.Size = new System.Drawing.Size(95, 30);
            this.kzmlaber.TabIndex = 12;
            this.kzmlaber.Text = "扩展名:";
            this.kzmlaber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xiugaikzm
            // 
            this.xiugaikzm.BackColor = System.Drawing.Color.Lime;
            this.xiugaikzm.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xiugaikzm.Location = new System.Drawing.Point(338, 113);
            this.xiugaikzm.Name = "xiugaikzm";
            this.xiugaikzm.Size = new System.Drawing.Size(122, 30);
            this.xiugaikzm.TabIndex = 13;
            this.xiugaikzm.Text = "修改扩展名:";
            this.xiugaikzm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxKzm
            // 
            this.checkBoxKzm.AutoSize = true;
            this.checkBoxKzm.Location = new System.Drawing.Point(466, 129);
            this.checkBoxKzm.Name = "checkBoxKzm";
            this.checkBoxKzm.Size = new System.Drawing.Size(15, 14);
            this.checkBoxKzm.TabIndex = 14;
            this.checkBoxKzm.UseVisualStyleBackColor = true;
            this.checkBoxKzm.CheckedChanged += new System.EventHandler(this.checkBoxKzm_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(338, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "清除扩展名:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearKzm
            // 
            this.ClearKzm.AutoSize = true;
            this.ClearKzm.Location = new System.Drawing.Point(466, 196);
            this.ClearKzm.Name = "ClearKzm";
            this.ClearKzm.Size = new System.Drawing.Size(15, 14);
            this.ClearKzm.TabIndex = 18;
            this.ClearKzm.UseVisualStyleBackColor = true;
            this.ClearKzm.CheckedChanged += new System.EventHandler(this.ClearKzm_CheckedChanged);
            // 
            // checkFileOrFolder
            // 
            this.checkFileOrFolder.AutoSize = true;
            this.checkFileOrFolder.Location = new System.Drawing.Point(298, 80);
            this.checkFileOrFolder.Name = "checkFileOrFolder";
            this.checkFileOrFolder.Size = new System.Drawing.Size(15, 14);
            this.checkFileOrFolder.TabIndex = 19;
            this.checkFileOrFolder.UseVisualStyleBackColor = true;
            this.checkFileOrFolder.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(30, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "选择修改子文件夹名或文件名";
            // 
            // ChooseFileOrFolder
            // 
            this.ChooseFileOrFolder.AutoSize = true;
            this.ChooseFileOrFolder.BackColor = System.Drawing.Color.IndianRed;
            this.ChooseFileOrFolder.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChooseFileOrFolder.Location = new System.Drawing.Point(72, 73);
            this.ChooseFileOrFolder.Name = "ChooseFileOrFolder";
            this.ChooseFileOrFolder.Size = new System.Drawing.Size(220, 21);
            this.ChooseFileOrFolder.TabIndex = 21;
            this.ChooseFileOrFolder.Text = "默认修改“文件”模式";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChooseFileOrFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkFileOrFolder);
            this.Controls.Add(this.ClearKzm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxKzm);
            this.Controls.Add(this.xiugaikzm);
            this.Controls.Add(this.kzmlaber);
            this.Controls.Add(this.textBoxKzm);
            this.Controls.Add(this.checkXHX);
            this.Controls.Add(this.weishuweiming);
            this.Controls.Add(this.xiahuaxian);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.tishinewname);
            this.Controls.Add(this.textBoxWS);
            this.Controls.Add(this.ChangeNameBtn);
            this.Controls.Add(this.textNameInput);
            this.Controls.Add(this.pictureBoxGif);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量修改指定文件夹或文件夹内文件名字~versions 4.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeNameBtn;
        private System.Windows.Forms.TextBox textBoxWS;
        private System.Windows.Forms.Label weishuweiming;
        private System.Windows.Forms.TextBox textNameInput;
        private System.Windows.Forms.Label tishinewname;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Label xiahuaxian;
        private System.Windows.Forms.CheckBox checkXHX;
        private System.Windows.Forms.PictureBox pictureBoxGif;
        private System.Windows.Forms.TextBox textBoxKzm;
        private System.Windows.Forms.Label kzmlaber;
        private System.Windows.Forms.Label xiugaikzm;
        private System.Windows.Forms.CheckBox checkBoxKzm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ClearKzm;
        private System.Windows.Forms.CheckBox checkFileOrFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ChooseFileOrFolder;
    }
}

