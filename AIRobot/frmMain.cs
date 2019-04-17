using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Threading;
using System.Media;
using System.Net.Http;



namespace AIRobot
{
    public partial class FrmMain : CCSkinMain
    {
        HttpWebResponse Response = null;

        public FrmMain(string str)
        {
            InitializeComponent();
            lbMyName.Text = str;
            getAccessToken();
            rbE.Checked = true;
        }

        private static String clientId = "ZEPPRrujRMzv3GDXfLAEbQim";
        private static String clientSecret = "3XEPh2KcQyovnGFPAj018W9gHrsAsnyG";


        private void getRobotTalk()
        {
            string APIKEY = "6d86acc1ccd14425a75bea89f19fa613";
            string message = tbSend.Text;
            string INFO = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(message));
            string getURL = "http://www.tuling123.com/openapi/api?key=" + APIKEY + "&info=" + INFO;
            HttpWebRequest MyRequest = (HttpWebRequest)HttpWebRequest.Create(getURL);
            HttpWebResponse MyResponse = (HttpWebResponse)MyRequest.GetResponse();
            Response = MyResponse;
            using (Stream MyStream = MyResponse.GetResponseStream())
            {
                long ProgMaximum = MyResponse.ContentLength;
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = MyStream.Read(by, 0, by.Length);
                Encoding encoding = Encoding.UTF8;
                string result = "";
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    result += encoding.GetString(by, 0, osize);
                    long ProgValue = totalDownloadedByte;
                    osize = MyStream.Read(by, 0, by.Length);
                }

                JsonReader reader = new JsonTextReader(new StringReader(result));
                while (reader.Read())
                {
                    if (reader.Path == "text" && reader.Value.ToString() != "text")
                    {
                        result = reader.Value.ToString();
                        getUserTalk();
                        tbReceive.Text += "-南理工小紫   " + DateTime.Now.ToString() + " : \r\n";
                        tbReceive.Text += reader.Value.ToString() + "\r\n";
                        tbReceive.SelectionStart = tbReceive.Text.Length;
                        tbReceive.ScrollToCaret();
                    } 
                }
            }
        }

        private void getUserTalk()
        {
            tbReceive.Text += "-"+ lbMyName.Text.ToString() +"   " + DateTime.Now.ToString() + " : \r\n";
            tbReceive.Text += tbSend.Text + "\r\n";
            tbSend.Clear();
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            getRobotTalk();
        }

        private void tbSend_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && rbE.Checked == true)
            {
                getRobotTalk();
            }
            else if((e.Control == true && e.KeyCode == Keys.Enter ) && rbCE.Checked == true)
            {
                getRobotTalk();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (btnChange.Text == "↓")
            {
                rbE.Visible = true;
                rbCE.Visible = true;
                btnChange.Text = "↑";
            }
            else
            {
                rbE.Visible = false;
                rbCE.Visible = false;
                btnChange.Text = "↓";
            }
        }

        private void rbCE_Click(object sender, EventArgs e)
        {
            if (rbCE.Checked == true)
                rbE.Checked = false;
        }

        private void rbE_Click(object sender, EventArgs e)
        {
            if (rbE.Checked == true)
                rbCE.Checked = false;
        }

        public String getAccessToken()
        {
            String authHost = "https://aip.baidubce.com/oauth/2.0/token";
            HttpClient client = new HttpClient();
            List<KeyValuePair<String, String>> paraList = new List<KeyValuePair<string, string>>();
            paraList.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            paraList.Add(new KeyValuePair<string, string>("client_id", clientId));
            paraList.Add(new KeyValuePair<string, string>("client_secret", clientSecret));

            HttpResponseMessage response = client.PostAsync(authHost, new FormUrlEncodedContent(paraList)).Result;
            String result = response.Content.ReadAsStringAsync().Result;

            return result;
        }

        public static void CallToChildThread()
        {

        }

        private void getRobotSpeak(string readervalue)
        {
            var API_KEY = "dkdLZdH306a2dEquuoBZHIrx";
            var SECRET_KEY = "k3r6ROeXUMgHpfe6z5DzgD2bzk3knQRb";
            var client = new Baidu.Aip.Speech.Tts(API_KEY, SECRET_KEY);

            ThreadStart childref = new ThreadStart(CallToChildThread);
            Thread childThread = new Thread(childref);
            childThread.Start();
            var option = new Dictionary<string, object>()
            {
                {"spd", 5 },
                {"vol", 6 },
                {"per", 4 }
            };
            var result = client.Synthesis(readervalue, option);
            if (result.Success)
            {
                File.WriteAllBytes(@"..\Data\tmp.wav", result.Data);
                SoundPlayer sound = new SoundPlayer(@"..\Data\tmp.wav");
                sound.Play();
            }
            childThread.Abort();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
