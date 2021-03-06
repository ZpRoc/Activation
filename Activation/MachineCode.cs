using System;
using System.Management;


namespace Activation
{
    /// <summary>
    /// SecretKey:
    ///     加密/解密
    /// Function:
    ///     public static string GetMachineCode()
    ///     
    ///     public string GetCpuInfo()
    ///     public string GetHDid()
    ///     public string GetMoAddress()
    /// Variable:
    ///     None. 
    /// Note:
    ///     None. 
    /// </summary>
    public class MachineCode
    {
        static MachineCode machineCode;

        // -------------------------------- GetMachineCode -------------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 获取机器码
        /// </summary>
        /// <returns>机器码 = CPU 序列号 + 硬盘 ID + 网卡硬件地址</returns>
        public static string GetMachineCode()
        {
            string machineCodeString = string.Empty;

            if (machineCode == null)
            {
                machineCode = new MachineCode();
            }

            machineCodeString = "PC." + machineCode.GetCpuInfo() + "." +
                                machineCode.GetHDid() + "." +
                                machineCode.GetMoAddress();

            return machineCodeString;
        }

        // ---------------------------------- Functions ----------------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 获取 CPU 序列号   
        /// </summary>
        /// <returns>CPU 序列号</returns>
        public string GetCpuInfo()
        {
            string cpuInfo = "";
            try
            {
                using (ManagementClass cimobject = new ManagementClass("Win32_Processor"))
                {
                    ManagementObjectCollection moc = cimobject.GetInstances();

                    foreach (ManagementObject mo in moc)
                    {
                        cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                        mo.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return cpuInfo.ToString();
        }

        /// <summary>
        /// 获取硬盘 ID
        /// </summary>
        /// <returns>硬盘 ID</returns>
        public string GetHDid()
        {
            string HDid = "";
            try
            {
                using (ManagementClass cimobject1 = new ManagementClass("Win32_DiskDrive"))
                {
                    ManagementObjectCollection moc1 = cimobject1.GetInstances();
                    foreach (ManagementObject mo in moc1)
                    {
                        HDid = (string)mo.Properties["Model"].Value;
                        mo.Dispose();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return HDid.ToString();
        }

        /// <summary>
        /// 获取网卡硬件地址
        /// </summary>
        /// <returns>网卡硬件地址</returns>
        public string GetMoAddress()
        {
            string MoAddress = "";
            try
            {
                using (ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration"))
                {
                    ManagementObjectCollection moc2 = mc.GetInstances();
                    foreach (ManagementObject mo in moc2)
                    {
                        if ((bool)mo["IPEnabled"] == true)
                            MoAddress = mo["MacAddress"].ToString();
                        mo.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return MoAddress.ToString();
        }
    }
}
