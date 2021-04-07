using System;
using System.Windows.Forms;


namespace Activation
{
    public partial class ActivateMenu : UserControl
    {
        public ActivateMenu()
        {
            InitializeComponent();
        }

        // ------------------------------------ Events ------------------------------------ //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 菜单栏 获取机器码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void toolStripMenuItemMachineCode_Click(object sender, EventArgs e)
        {
            try
            {
                string machineCode = MachineCode.GetMachineCode();

                if (MessageBox.Show("您的机器码为: " + machineCode + "\n单击确定后自动复制至粘贴板，请将该机器码发送给码农！", "Info", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Clipboard.SetDataObject(machineCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 菜单栏 载入注册码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void toolStripMenuItemSetRegCode_Click(object sender, EventArgs e)
        {
            try
            {
                // 弹出命令配置窗口
                SubForm.InputRegCodeForm inputRegCodeForm = new SubForm.InputRegCodeForm();
                if (inputRegCodeForm.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("注册码写入完毕，请重启软件！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 菜单栏 获取注册码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void toolStripMenuItemGetRegCode_Click(object sender, EventArgs e)
        {
            try
            {
                // 弹出命令配置窗口
                SubForm.RegisterForm registerForm = new SubForm.RegisterForm();
                if (registerForm.ShowDialog(this) == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ---------------------------------- Attributes ---------------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// ContextMenuStrip
        /// </summary>
        public ContextMenuStrip ContextMenuStripActive
        {
            get
            {
                return contextMenuStripActive;
            }
        }
    }
}
