using System;
using System.Windows.Forms;


namespace Activation.SubForm
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            comboBoxTime.SelectedIndex = 0;
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
                // 判断密码是否正确
                string PASSWORD = "1012" + DateTime.Now.Hour.ToString("#00") + DateTime.Now.Minute.ToString("#00");
                if (textBoxPassword.Text != PASSWORD)
                {
                    MessageBox.Show("密码错误！");
                    return;
                }

                // 获取授权时间
                int days = Convert.ToInt32(comboBoxTime.Text.Split(' ')[0]);

                // 获取注册码
                SecretKey sk = new SecretKey();
                string str_reg = sk.Encrypt(textBoxCode.Text, DateTime.Now.AddDays(days).ToString("yyyyMMdd"));

                // 显示与复制
                if (MessageBox.Show("您的注册码为: " + str_reg + "\n单击确定后自动复制至粘贴板，请将该注册码发送给用户！", "警告", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Clipboard.SetDataObject(str_reg);
                }
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
        private void RegisterForm_KeyDown(object sender, KeyEventArgs e)
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
