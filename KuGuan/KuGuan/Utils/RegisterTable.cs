using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    class RegisterTable
    {
        public static Boolean isRegistered(String name)
        {
            Boolean isRegistered = false;
            try
            {
                RegistryKey hkml = Registry.LocalMachine;
                RegistryKey software = hkml.OpenSubKey("SOFTWARE", false);
                RegistryKey aimdir = software.OpenSubKey("kucunguanli", false);
                if (aimdir != null)
                {
                    String [] names = aimdir.GetValueNames();
                    if (names.Contains(name))
                        isRegistered = true;
                }
            }
            catch { }
            return isRegistered;
        }

        public static String GetRegisterData(String name)
        {
            string registData = "";
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey software = hkml.OpenSubKey("SOFTWARE", false);

            RegistryKey aimdir = software.OpenSubKey("kucunguanli", false);

            registData = aimdir.GetValue(name).ToString();
            return registData; 
 
        }

        public static Boolean WriteRegisterData(String name,String value)
        {
            Boolean f = false;
            try
            {
                RegistryKey hkml = Registry.LocalMachine;
                RegistryKey software = hkml.OpenSubKey("SOFTWARE", true);

                RegistryKey aimdir = software.CreateSubKey("kucunguanli");
                aimdir.SetValue(name, value);
                f = true;
            }
            catch { }

            return f;

        }
    
    
    }
}
