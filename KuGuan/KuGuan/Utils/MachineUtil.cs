using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace Utils
{
    public class Machine
    {
        private String cpuId;
        public String CpuId { get { return this.cpuId; } }
        public Machine()
        {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            cpuId = null;
            foreach (ManagementObject mo in moc)
            {
                try
                {
                    cpuId = mo.Properties["ProcessorId"].Value.ToString();
                }
                catch(Exception){}
                break;
            }
        }

        public Byte[] CpuId2Byte(String id)
        {
            return Encoding.ASCII.GetBytes(id);
        }
    }
}
