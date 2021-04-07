namespace Activation
{
    partial class ActivateMenu
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStripActive = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemMachineCode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetRegCode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorActive1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemGetRegCode = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripActive
            // 
            this.contextMenuStripActive.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.contextMenuStripActive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMachineCode,
            this.toolStripMenuItemSetRegCode,
            this.toolStripSeparatorActive1,
            this.toolStripMenuItemGetRegCode});
            this.contextMenuStripActive.Name = "contextMenuStrip1";
            this.contextMenuStripActive.Size = new System.Drawing.Size(181, 110);
            this.contextMenuStripActive.Text = "激活";
            // 
            // toolStripMenuItemMachineCode
            // 
            this.toolStripMenuItemMachineCode.Image = global::Activation.Properties.Resources.locked;
            this.toolStripMenuItemMachineCode.Name = "toolStripMenuItemMachineCode";
            this.toolStripMenuItemMachineCode.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItemMachineCode.Text = "获取机器码";
            this.toolStripMenuItemMachineCode.Click += new System.EventHandler(this.toolStripMenuItemMachineCode_Click);
            // 
            // toolStripMenuItemSetRegCode
            // 
            this.toolStripMenuItemSetRegCode.Image = global::Activation.Properties.Resources.unlocked;
            this.toolStripMenuItemSetRegCode.Name = "toolStripMenuItemSetRegCode";
            this.toolStripMenuItemSetRegCode.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItemSetRegCode.Text = "载入注册码";
            this.toolStripMenuItemSetRegCode.Click += new System.EventHandler(this.toolStripMenuItemSetRegCode_Click);
            // 
            // toolStripSeparatorActive1
            // 
            this.toolStripSeparatorActive1.Name = "toolStripSeparatorActive1";
            this.toolStripSeparatorActive1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItemGetRegCode
            // 
            this.toolStripMenuItemGetRegCode.Image = global::Activation.Properties.Resources.key;
            this.toolStripMenuItemGetRegCode.Name = "toolStripMenuItemGetRegCode";
            this.toolStripMenuItemGetRegCode.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItemGetRegCode.Text = "获取注册码";
            this.toolStripMenuItemGetRegCode.Click += new System.EventHandler(this.toolStripMenuItemGetRegCode_Click);
            // 
            // ActivateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ActivateMenu";
            this.Size = new System.Drawing.Size(256, 256);
            this.contextMenuStripActive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripActive;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMachineCode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetRegCode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGetRegCode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorActive1;
    }
}
