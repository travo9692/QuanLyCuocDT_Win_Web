using QuanLyDT.Infrastructure;
using QuanLyDT.Model.DTO;
using QuanLyDT.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDT.Winform
{
    public partial class Form1 : Form
    {
        private ChiTietSuDung ctsd;
        private LibraryService libraryService;
        public Form1()
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string[] lines = File.ReadAllLines(@"D:\test.txt");

                String filepath = "D:\\tinhcuoc.txt";
                FileStream fs = new FileStream(filepath, FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                List<string> id = new List<string>();
                List<DateTime> tgbd = new List<DateTime>();
                List<DateTime> tgkt = new List<DateTime>();
                List<double> sophut7h23h = new List<double>();
                List<double> sophut23h7h = new List<double>();

                foreach (string s in lines)
                {
                    string[] temp = s.Split('\t');
                    id.Add(temp[0]);

                    DateTime timebatdau = DateTime.ParseExact(temp[1], "yyyy/MM/dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    DateTime timeketthuc = DateTime.ParseExact(temp[2], "yyyy/MM/dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                    DateTime time23h = new DateTime(timebatdau.Year, timebatdau.Month, timebatdau.Day, 23, 0, 0);
                    DateTime time7h = new DateTime(timebatdau.Year, timebatdau.Month, timebatdau.Day, 7, 0, 0);

                    tgbd.Add(timebatdau);
                    tgkt.Add(timeketthuc);

                    if (timebatdau.Day == timeketthuc.Day)
                    {


                        if (timebatdau.Hour >= 7 && timeketthuc.Hour < 23)
                        {
                            sophut7h23h.Add((timeketthuc - timebatdau).TotalMinutes);
                            sophut23h7h.Add(0);
                        }


                        if (timebatdau.Hour >= 23 && timeketthuc.Hour == 23)
                        {
                            sophut23h7h.Add((timeketthuc - timebatdau).TotalMinutes);
                            sophut7h23h.Add(0);
                        }


                        if (timebatdau.Hour >= 0 && timeketthuc.Hour < 7)
                        {
                            sophut23h7h.Add((timeketthuc - timebatdau).TotalMinutes);
                            sophut7h23h.Add(0);
                        }


                        if (timebatdau.Hour < 23 && timeketthuc.Hour == 23)
                        {
                            sophut7h23h.Add((time23h - timebatdau).TotalMinutes);
                            sophut23h7h.Add((timeketthuc - time23h).TotalMinutes);
                        }


                        if (timebatdau.Hour < 7 && timeketthuc.Hour >= 7)
                        {
                            sophut23h7h.Add((time7h - timebatdau).TotalMinutes);
                            sophut7h23h.Add((timeketthuc - time7h).TotalMinutes);
                        }
                    }
                    else
                    {

                        if (timebatdau.Hour >= 23 && timeketthuc.Hour < 7)
                        {
                            sophut23h7h.Add((timeketthuc - timebatdau).TotalMinutes);
                            sophut7h23h.Add(0);
                        }


                        if (timebatdau.Hour < 23 && timeketthuc.Hour < 7)
                        {
                            sophut7h23h.Add((time23h - timebatdau).TotalMinutes);
                            sophut23h7h.Add((timeketthuc - time23h).TotalMinutes);
                        }
                    }

                }

                for (int i = 0; i < sophut7h23h.Count; i++)
                {
                    sWriter.Write(id[i]);
                    sWriter.Write("\t");
                    sWriter.Write(sophut7h23h[i]);
                    sWriter.Write("\t");
                    sWriter.Write(sophut23h7h[i]);
                    sWriter.WriteLine();

                }

                bool result;
                for (int i = 0; i < sophut7h23h.Count; i++)
                {
                    ChiTietSuDung ctsd = new ChiTietSuDung();
                    ctsd.IDSIM = int.Parse(id[i]);
                    ctsd.TGBD = tgbd[i];
                    ctsd.TGKT = tgkt[i];
                    ctsd.SoPhut7h23h = (decimal)sophut7h23h[i];
                    ctsd.SoPhut23h7h = (decimal)sophut23h7h[i];


                    result = libraryService.ThemChiTietSuDung(ctsd);

                }
                
                Console.ReadKey();
                Console.ReadLine();


                sWriter.Flush();
                fs.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime start = new DateTime(2017, 1, 1);
            int range = (DateTime.Today - start).Days;

            Random a = new Random();
            String filepath = "D:\\test.txt";
            textBox1.Text = "D:\\test.txt";
            FileStream fs = new FileStream(filepath, FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);

            for (int i = 1; i <= 100; i++)
            {
                int id = a.Next(9);
                int b = a.Next(10);
                int c = a.Next(60);
                TimeSpan d = new System.TimeSpan(0, b, c, 0);
                DateTime TGBD = start.AddDays(a.Next(range)).AddHours(a.Next(0, 24)).AddMinutes(a.Next(0, 60)).AddSeconds(a.Next(0, 60));

                DateTime TGKT = TGBD.Add(d);
                sWriter.WriteLine(id + "\t" + TGBD.ToString("yyyy/MM/dd HH:mm:ss") + "\t" + TGKT.ToString("yyyy/MM/dd HH:mm:ss"));


            }

            sWriter.Flush();


            fs.Close();
        }
    }
}
