using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChangeName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.MaximizeBox = false;//使最大化窗口失效
                                     //下一句用来禁止对窗口大小进行拖拽
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            InitializeComponent();
            //透明背景
            TouMingBg();

            ///gif
            pictureBoxGif.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxGif.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        int num = 0;//文件名后面的数字
        string newname;
        string foldPath;
        string kzm;//扩展名



        private void TouMingBg()
        {
            ///设置透明
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Blue;
            this.TransparencyKey = BackColor;

        }
        private void SelectFolder(object sender, EventArgs e)
        {
            SelectFileFolder();
        }
        /// <summary>
        /// 选择文件夹选择路径
        /// </summary>
        private void SelectFileFolder()
        {
            #region
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径(文件夹即可)";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = dialog.SelectedPath;
                SelectBtn.Text = foldPath;
                //MessageBox.Show("你选择的地址是" + foldPath);
                MessageBox.Show(null, "你选择的地址是" + foldPath, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                //DirectoryInfo theFolder = new DirectoryInfo(foldPath);
                //theFolder 包含文件路径
                //FileInfo[] dirInfo = theFolder.GetFiles();
                ////遍历文件夹                
                //foreach (FileInfo file in dirInfo)
                //{
                //    MessageBox.Show(file.ToString());
                //}
            }
            #endregion

        }


        private void ChangeBtn(object sender, EventArgs e)//执行按钮
        {
            num = 0;//文件名后面的数字

            string new_Name = NewNameFun(); //新的文件名

            string weishuNum = WeishuFun();

            kzm = KuoZhanMing();

            if (foldPath == null)
            {
                //MessageBox.Show("     输入或选择有误！！！");
                MessageBox.Show(null, "输入或选择有误！！！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] files = Directory.GetFiles(@foldPath, ".", SearchOption.AllDirectories);
                // 获取目标文件夹中的所有子文件夹
                string[] subDirectories = Directory.GetDirectories(foldPath);

                if (kzm != null)//使用了新的扩展名
                {
                    if (textNameInput.Text == null || textNameInput.Text == "")//新名字空，只修改扩展
                    {
                        if (checkFileOrFolder.Checked)
                        {
                            // 遍历并修改每个文件夹的名称
                            foreach (string subDirectory in subDirectories)
                            {
                                num++;
                                DirectoryInfo directoryInfo = new DirectoryInfo(subDirectory);
                                string newPath = Path.Combine(directoryInfo.Parent.FullName, directoryInfo.Parent.FullName) + kzm;
                                directoryInfo.MoveTo(newPath);
                            }
                        }
                        else
                        {
                            foreach (string s in files)
                            {
                                num++;
                                File.Move(s, Path.GetDirectoryName(s) + "\\" + GetTheName(s) + kzm);
                            }
                        }
                    }
                    else
                    {
                        if (checkFileOrFolder.Checked)
                        {
                            // 遍历并修改每个文件夹的名称
                            foreach (string subDirectory in subDirectories)
                            {
                                num++;
                                DirectoryInfo directoryInfo = new DirectoryInfo(subDirectory);
                                string newPath = Path.Combine(directoryInfo.Parent.FullName, new_Name) + num.ToString(weishuNum) + kzm;
                                directoryInfo.MoveTo(newPath);
                            }
                        }
                        else
                        {

                            foreach (string s in files)//新名字和扩展名都改
                            {
                                num++;
                                File.Move(s, Path.GetDirectoryName(s) + "\\" + new_Name + num.ToString(weishuNum) + kzm);
                            }
                        }
                    }
                }
                else if (ClearKzm.Checked)//清除扩展名
                {
                    if (checkFileOrFolder.Checked)
                    {

                    }
                    else
                    {
                        foreach (string s in files)
                        {
                            num++;
                            File.Move(s, Path.GetDirectoryName(s) + "\\" + GetTheName(s));
                        }

                    }
                }
                else if (textNameInput.Text != null && textNameInput.Text != "")
                {

                    if (checkFileOrFolder.Checked)
                    {
                        // 遍历并修改每个文件夹的名称
                        foreach (string subDirectory in subDirectories)
                        {
                            num++;
                            DirectoryInfo directoryInfo = new DirectoryInfo(subDirectory);
                            string newPath = Path.Combine(directoryInfo.Parent.FullName, new_Name) + num.ToString(weishuNum);
                            directoryInfo.MoveTo(newPath);
                        }
                    }
                    else
                    {

                        foreach (string s in files)//保持扩展名不变只修改名字
                        {
                            num++;
                            File.Move(s, Path.GetDirectoryName(s) + "\\" + new_Name + num.ToString(weishuNum) + Path.GetExtension(s));
                        }
                    }
                }
                else
                {
                    MessageBox.Show(null, " 输入或选择有误~", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TiShiMSG();
        }
        //修改完成提示信息
        private static async Task TiShiMSG()
        {
            await DisplayMessageBoxAsync("      已经修改成功啦...");
            // 可以在这里编写程序的其他逻辑
            // ...

            Console.ReadLine();
        }
        private static async Task DisplayMessageBoxAsync(string message)
        {
            await Task.Run(() =>
            {
                MessageBox.Show(message);
            });
        }


        private void LivenessTask(Task t)
        {
            //继续执行的操作
            MessageBox.Show(null, " 已经修改完毕~", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 扩展名
        /// </summary>
        public string KuoZhanMing()
        {

            if (textBoxKzm.Text != null && textBoxKzm.Text != "勾选可用" && textBoxKzm.Text != "" && checkBoxKzm.Checked)
            {
                kzm = "." + textBoxKzm.Text;
                return kzm;
            }

            return null;
        }

        /// <summary>
        /// 文件名尾数位数设置
        /// </summary>
        /// <returns></returns>
        public string WeishuFun()
        {

            string weiShuStr = textBoxWS.Text;
            string str = "D" + weiShuStr;
            return str;

        }
        /// <summary>
        /// 处理新名字
        /// </summary>
        /// <returns></returns>
        public string NewNameFun()
        {
            if (textNameInput.Text == null && textNameInput.Text == "")
            {
                return null;//如果没有输入新名字那就继续旧名字
            }
            if (checkXHX.Checked)//是否添加下划线
            {
                newname = textNameInput.Text + "_";
            }
            else
            {
                newname = textNameInput.Text;
            }

            return newname;
        }

        public static string GetTheName(string str)
        {
            string st = Path.GetFileNameWithoutExtension(str);
            return st;
        }

        public static string Get000(string str)
        {
            string st = GetTheName(str).Substring(0, GetTheName(str).Length - 3);
            return st;
        }



        /// <summary>
        /// 下划线CTRL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkXHX.Checked)
            {
                labelMsg.Text = "true";
            }
            else
            {
                labelMsg.Text = "false";
            }
        }

        /// <summary>
        /// 修改文件夹名字还是修改文件名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkFileOrFolder.Checked)
            {
                ChooseFileOrFolder.Text = "修改“文件夹”模式";
            }
            else
            {
                ChooseFileOrFolder.Text = "修改“文件”模式";
            }
        }


        /// <summary>
        /// 窗体载入时调用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxKzm.Text = "勾选可用";
            textBoxKzm.Enabled = false;
        }

        private void checkBoxKzm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKzm.Checked)
            {
                textBoxKzm.Text = "";
                textBoxKzm.Enabled = true;
                ClearKzm.Checked = false;
            }
            else
            {
                textBoxKzm.Text = "勾选可用";
                textBoxKzm.Enabled = false;
            }
        }

        /// <summary>
        /// 清除扩展名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearKzm_CheckedChanged(object sender, EventArgs e)
        {

            if (ClearKzm.Checked)
            {
                checkBoxKzm.Checked = false;
                textBoxKzm.Text = "勾选可用";
                textNameInput.Text = "清除扩展名时不需要输入";
                textNameInput.Enabled = false;
            }
            else if (textNameInput.Text == "清除扩展名时不需要输入")
            {
                textNameInput.Text = "";
                textNameInput.Enabled = true;
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string pathTemp = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (File.Exists(pathTemp))//判断托转进来的是文件还是文件夹

            {
                // 是文件
                //MessageBox.Show("请拖拽文件夹！！！");
                MessageBox.Show(null, "请拖拽文件夹！！！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Directory.Exists(pathTemp))

            {
                // 是文件夹
                //MessageBox.Show("文件夹");
                foldPath = pathTemp;
                SelectBtn.Text = foldPath;

            }

            else

            {
                // 都不是
                //MessageBox.Show("请拖拽文件夹！！！");
                MessageBox.Show(null, "请拖拽文件夹！！！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


    }
}
