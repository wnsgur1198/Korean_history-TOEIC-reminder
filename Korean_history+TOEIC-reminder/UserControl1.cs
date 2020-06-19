using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Korean_history_TOEIC_reminder
{
    public partial class UserControl1 : Form
    {
        // 진입점에 적합한 정적 'Main'방법을 포함하지 않습니다
        /* 소스참고 <https://www.it-swarm.dev/ko/c%23/%EC%A7%84%EC%9E%85-%EC%A0%90%EC%9
        7%90-%EC%A0%81%ED%95%A9%ED%95%9C-%EC%A0%95%EC%A0%81-%27%EB%A9%94%EC%9D%B8%27%EB
        %B0%A9%EB%B2%95%EC%9D%84-%ED%8F%AC%ED%95%A8%ED%95%98%EC%A7%80-%
        EC%95%8A%EC%8A%B5%EB%8B%88%EB%8B%A4/942281366/> */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserControl1());
        }

        string toeiclink = "https://appexam.ybmnet.co.kr/toeic/info/receipt_schedule.asp";
        string khistorylink = "http://www.historyexam.go.kr/pageLink.do?link=examSchedule";

        public UserControl1()
        {
            InitializeComponent();

            // 토익 링크 지정
            toeicLink.Text = toeiclink;

            // 토익 크롤링 시작
            crowl_toeic();

            // 한국사시험 링크 지정
            khistoryLink.Text = khistorylink;

            // 토익 크롤링 시작
            crowl_khistory();
        }

        public DataGridView ToeicResult
        {
            get { return this.toeicResult; }
            set { this.toeicResult = value; }
        }

        public DataGridView kHistoryResult
        {
            get { return this.khistoryResult; }
            set { this.khistoryResult = value; }
        }

        private void crowl_toeic()
        {
            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                AParser c1 = new AParser();
                c1.ExecuteDemo(toeiclink, ToeicResult);
            }
        }

        private void crowl_khistory()
        {
            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                AParser c1 = new AParser();
                c1.ExecuteDemo2(khistorylink, kHistoryResult);
            }
        }

        private void toeicLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink_toeicLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink_toeicLink()
        {
            toeicLink.LinkVisited = true;
            System.Diagnostics.Process.Start(toeiclink);
        }

        private void khistoryLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink_khistoryLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink_khistoryLink()
        {
            toeicLink.LinkVisited = true;
            System.Diagnostics.Process.Start(khistorylink);
        }
    }

    // html 한글 인코딩 <http://egloos.zum.com/sjc333/v/3023174>
    public class AParser
    {
        public void ExecuteDemo(string sitesource, DataGridView toeicResult)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sitesource);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //초반 부분에서 charset확인
            int len = 1024;
            byte[] barr = new byte[len];
            Stream stream = response.GetResponseStream();
            int read_size = stream.Read(barr, 0, (int)len);
            string data = Encoding.UTF8.GetString(barr);
            var encod = doc.DetectEncodingHtml(data);

            if (encod == null) encod = Encoding.UTF8;//default

            //나머지 읽기
            int total_size = read_size;
            while (read_size > 0)
            {
                byte[] barr2 = new byte[total_size * 2];
                for (int a = 0; a < total_size; a++) barr2[a] = barr[a];//복사
                read_size = stream.Read(barr, 0, total_size);
                for (int a = 0; a < read_size; a++) barr2[total_size + a] = barr[a];//복사
                total_size += read_size;
                barr = barr2;
            }

            string convstr = Encoding.Unicode.GetString(Encoding.Convert(encod, Encoding.Unicode, barr));
            doc.LoadHtml(convstr);
            response.Close();

            foreach (HtmlNode body in doc.DocumentNode.SelectNodes("//body"))
            {

                foreach (HtmlNode table in body.SelectNodes("//table[@class = 'table_info_print']"))
                {
                    int colCnt = 0;
                    foreach (HtmlNode th in table.SelectNodes("//th[@class = 'str']"))
                    {
                        if (colCnt == 4) break;
                        toeicResult.Columns[colCnt++].HeaderText = th.InnerText;
                    }

                    colCnt = 0;
                    List<string> rowList = new List<string>();
                    foreach (HtmlNode td in table.SelectNodes("//td[@class = 'str']"))
                    {
                        string filtered1 = Regex.Replace(td.InnerText, "[A-Za-z;]", "");
                        string filtered2 = Regex.Replace(filtered1, "[&]", " ");
                        filtered2 = filtered2.Replace("\t", "");

                        //Console.WriteLine("Row: " + filtered2 + ", Rows: " + toeicResult.Rows.Count);

                        if (colCnt < 4)
                        {
                            rowList.Add(filtered2);
                            colCnt++;

                            if(colCnt == 4)
                            {
                                toeicResult.Rows.Add(rowList.ToArray());
                                rowList.Clear();
                                colCnt = 0;
                            }
                        }

                    }

                }
            }

        }

        public void ExecuteDemo2(string sitesource, DataGridView khistoryResult)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sitesource);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //초반 부분에서 charset확인
            int len = 1024;
            byte[] barr = new byte[len];
            Stream stream = response.GetResponseStream();
            int read_size = stream.Read(barr, 0, (int)len);
            string data = Encoding.UTF8.GetString(barr);
            var encod = doc.DetectEncodingHtml(data);

            if (encod == null) encod = Encoding.UTF8;//default

            //나머지 읽기
            int total_size = read_size;
            while (read_size > 0)
            {
                byte[] barr2 = new byte[total_size * 2];
                for (int a = 0; a < total_size; a++) barr2[a] = barr[a];//복사
                read_size = stream.Read(barr, 0, total_size);
                for (int a = 0; a < read_size; a++) barr2[total_size + a] = barr[a];//복사
                total_size += read_size;
                barr = barr2;
            }

            string convstr = Encoding.Unicode.GetString(Encoding.Convert(encod, Encoding.Unicode, barr));
            doc.LoadHtml(convstr);
            response.Close();

            int cnt = 0; int cnt_limit = 20;

            foreach (HtmlNode body in doc.DocumentNode.SelectNodes("//body"))
            {
                if (cnt == cnt_limit) break;
                foreach (HtmlNode table in body.SelectNodes("//table[@summary = '6개등급(1급~6급)']"))
                {
                    if (cnt == cnt_limit) break;

                    int colCnt = 0;
                    foreach (HtmlNode th in table.SelectNodes("//th"))
                    {
                        if (colCnt == 4) break;
                        khistoryResult.Columns[colCnt++].HeaderText = th.InnerText;
                    }

                    colCnt = 0;
                    List<string> rowList = new List<string>();
                    foreach (HtmlNode td in table.SelectNodes("//tbody//td"))
                    {
                        if (cnt == cnt_limit) break;
                        //Console.WriteLine("Row: " + td.InnerText + ", Rows: " + khistoryResult.Rows.Count);

                        if (colCnt < 4)
                        {
                            rowList.Add(td.InnerText);
                            colCnt++;

                            if (colCnt == 4)
                            {
                                khistoryResult.Rows.Add(rowList.ToArray());
                                rowList.Clear();
                                colCnt = 0;
                            }
                        }
                        cnt++;
                    }
                    
                }
            }

        }

    }

}
