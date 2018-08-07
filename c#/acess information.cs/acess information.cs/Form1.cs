using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace acess_information.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text =openFileDialog1.FileName;
                FileInfo finfo = new FileInfo(textBox1.Text);
                string strctime, strlatime, strlwtime,strname, strfname, strdname, strisread;
                long length;
                strctime = finfo.CreationTime.ToShortDateString();
                strlatime = finfo.LastAccessTime.ToShortDateString();
                strlwtime = finfo.LastWriteTime.ToShortDateString();
                strname = finfo.Name;
                strfname = finfo.FullName;
                strdname = finfo.DirectoryName;
                strisread = finfo.IsReadOnly.ToString();
                length = finfo.Length;
                MessageBox.Show("文件信息\n创建时间："+strctime+"\n上次访问时间："+strlatime+"\n上次写入文件："+strlwtime+"\n文件名："+strname+"\n完整目录："+strfname+"\n完整路径："+strdname+"\n是否只读："+strisread+"\n文件长度："+length);

            }
        }
    }
}
