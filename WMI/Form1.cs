using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace WMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ObjectQuery sQuery = new ObjectQuery("SELECT * FROM Win32_LogicalDisk");

            ManagementObjectSearcher mOs = new ManagementObjectSearcher(sQuery);
            ManagementObjectCollection coll = mOs.Get();

            foreach (ManagementObject obj in coll)
            {
                foreach (PropertyData data in obj.Properties)
	            {
                    richTextBox1.AppendText(data.Name + " " + Environment.NewLine);
	            }
            }
        }
    }
}
