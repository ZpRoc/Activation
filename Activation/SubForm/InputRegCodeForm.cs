using System;
using System.IO;
using System.Windows.Forms;


namespace Activation.SubForm
{
    public partial class InputRegCodeForm : Form
    {
        public InputRegCodeForm()
        {
            InitializeComponent();
        }

        // ------------------------------------ Events ------------------------------------ //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 确定 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                // 将注册码写入 ket.txt 文件
                FileStream fs   = new FileStream(@"key.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(textBoxRegCode.Text);
                sw.Flush();
                sw.Close();
                fs.Close();

                // 关闭窗体并返回
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 取消 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // 关闭窗体并返回
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 窗体快捷键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputRegCodeForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // 回车按键，直接点击确定
                if (e.KeyCode == Keys.Enter)
                {
                    buttonOK_Click(null, null);
                }
                // Esc 直接关闭窗口
                else if (e.KeyCode == Keys.Escape)
                {
                    buttonCancel_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
