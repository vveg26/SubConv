using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SubConv
{
    public partial class SubConv : Form
    {
        public SubConv()
        {
            InitializeComponent();
        }

        private void buttonConv_Click(object sender, EventArgs e)
        {
            //编码
            string sourceUrl = richTextBoxUrl.Text;
            sourceUrl=sourceUrl.Replace("\n", "|");
            string encodeUrl = HttpUtility.UrlEncode(sourceUrl ,Encoding.UTF8);

            //转换类型
            string type = "clash";
            string ed = ".yaml";

            string filename = textBoxFilename.Text;
            
            //类型选择
            if(comboBoxType.Text == "clash")
            {
                type = "clash";
                ed = ".yaml";
            }else if(comboBoxType.Text == "base64")
            {
                type = "mixed";
                ed = ".txt";
            }

            //配置文件

            string filenamefull = filename + ed;
            string encodefilenamefull = HttpUtility.UrlEncode(filenamefull, Encoding.UTF8);
            
            string configUrl = $"http://127.0.0.1:25500/sub?target={type}&url={encodeUrl}";

            if (checkBoxUpload.Checked)
            {
                configUrl = configUrl + $"&upload=true&upload_path={encodefilenamefull}";
            }

            //订阅转换
            //System.Diagnostics.Process.Start(configUrl);
            textBox1.Text = configUrl;

            
            using (var client = new WebClient())
            {
                client.DownloadFile(configUrl, Application.StartupPath+@"\profiles\"+filenamefull);
                System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath + @"\profiles");

            }
           



        }

        private void SubConv_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            Process p = Process.Start(Application.StartupPath+@"\subconverter\subconverter.exe");

            
        }

        bool textboxHasText = false;
        private void richTextBoxUrl_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                richTextBoxUrl.Text = "";            //为空
            richTextBoxUrl.ForeColor = Color.Black;       //颜色
        }

        private void richTextBoxUrl_Leave(object sender, EventArgs e)
        {
            if (richTextBoxUrl.Text == "")
            {

                richTextBoxUrl.Text = "支持订阅或ss/ssr/vmess链接,多个订阅或链接每行一个或用 | 分隔";
                richTextBoxUrl.ForeColor = Color.LightGray;   //颜色            
                textboxHasText = false;
            }
            else
                textboxHasText = true;

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gisttoken配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = Process.Start(Application.StartupPath + @"\subconverter\gistconf.ini");
            
        }

        private void 使用前必读ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = Process.Start(Application.StartupPath + @"\ReadMe.md");
        }
    }
}
