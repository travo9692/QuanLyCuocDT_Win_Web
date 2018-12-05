using QuanLyDT.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDT.Repository.ADO
{
    public class DataProvider
    {
        #region Singleton Pattern

        private static DataProvider instance;



        /// <summary>
        /// kiểm tra xem đã tạo đối tượng DataProvider nào trước đó hay chưa.
        /// Nếu chưa thì tạo mới, nếu có rồi thì trả về đối tượng đó lun.
        /// </summary>
        public static DataProvider Instane
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }


        }


        /// <summary>
        /// private constructor để ngăn việc tạo đối tượng từ bên ngoài
        /// </summary>
        private DataProvider() { }


        #endregion


        #region Global Parameters

        /// <summary>
        /// Biến dùng để kết nối đến db
        /// </summary>
        private SqlConnection connection;

        /// <summary>
        /// Connection String dùng để kết nối db
        /// </summary>
        private string connectionString = LibraryParameter.connectionstring;


        /// <summary>
        /// Biến thực hiện câu lệnh sql
        /// </summary>
        SqlCommand sqlCommand;

        #endregion



        #region Methods


        /// <summary>
        /// Hàm excutescalar trả về giá trị là kết quả của số dòng đúng của câu truy vấn query
        /// </summary>
        /// <param name="query">là câu truy vấn sql</param>
        /// <param name="values">là các dữ liệu được đưa vào trong store procedure</param>
        /// <returns></returns>
        public int ExecuteScalar(string query, object[] values = null)
        {
            // Biến lưu kết quả trả về
            object data = 0;


            //Khối lệnh using nhằm đảm bảo connection lun được đóng 
            //sau khi thực hiện xong truy vấn
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                sqlCommand = new SqlCommand(query, connection);


                /*
                 * Kiểm tra xem dữ liệu đưa vào có tồn tại hay không
                 * Nếu có thì cắt chuỗi query và tìm các @parameter chứa trong đo
                 * sau đó dùng hàm addwithvalue để add value từ mảng values vào từng para
                 */
                if (values != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, values[i++]);
                        }
                    }
                }

                //thực thi truy vấn
                data = sqlCommand.ExecuteScalar();

                connection.Close();
            }

            return (int)data;
        }


        /// <summary>
        /// Hàm ExcuteNonQuery trả về số hàng affect bởi câu lệnh update, delete
        /// </summary>
        /// <param name="query">Câu lệnh sql</param>
        /// <param name="values">Mảng giá trị cho tham số truyền vào  câu lệnh sql</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string query, object[] values = null)
        {
            int row = 0;
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                sqlCommand = new SqlCommand(query, connection);

                if (values != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, values[i++]);
                        }
                    }
                }

                row = sqlCommand.ExecuteNonQuery();
                connection.Close();
            }

            return row;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public DataTable ExecuteReader(string query, object[] values = null)
        {
            DataTable table = new DataTable();

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                sqlCommand = new SqlCommand(query, connection);
                if (values != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, values[i++]);
                        }
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(table);
                connection.Close();
            }

            return table;

        }


        #endregion

        //static public void TaoFiletext()
        //{

        //    DateTime start = new DateTime(2017, 1, 1);
        //    int range = (DateTime.Today - start).Days;

        //    Random a = new Random();
        //    String filepath = "D:\\test.txt";
        //    FileStream fs = new FileStream(filepath, FileMode.Create);
        //    StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);

        //    for (int i = 1; i <= 100; i++)
        //    {
        //        int id = a.Next(9);
        //        int b = a.Next(10);
        //        int c = a.Next(60);
        //        TimeSpan d = new System.TimeSpan(0, b, c, 0);
        //        DateTime TGBD = start.AddDays(a.Next(range)).AddHours(a.Next(0, 24)).AddMinutes(a.Next(0, 60)).AddSeconds(a.Next(0, 60));

        //        DateTime TGKT = TGBD.Add(d);
        //        sWriter.WriteLine(id + "\t" + TGBD.ToString("yyyy/MM/dd HH:mm:ss") + "\t" + TGKT.ToString("yyyy/MM/dd HH:mm:ss"));


        //    }

        //    sWriter.Flush();


        //    fs.Close();
        //    Console.ReadKey();
        //    Console.ReadLine();
        //}

        //static public void GhiFiletext()
        //{
        //    try
        //    {
        //        QLCDTContext db = new QLCDTContext();

        //        string[] lines = File.ReadAllLines(@"D:\test.txt");

        //        String filepath = "D:\\tinhcuoc.txt";
        //        FileStream fs = new FileStream(filepath, FileMode.Create);
        //        StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
        //        List<string> id = new List<string>();
        //        List<DateTime> tgbd = new List<DateTime>();
        //        List<DateTime> tgkt = new List<DateTime>();
        //        List<double> sophut7h23h = new List<double>();
        //        List<double> sophut23h7h = new List<double>();

        //        foreach (string s in lines)
        //        {
        //            string[] temp = s.Split('\t');
        //            id.Add(temp[0]);

        //            DateTime timebatdau = DateTime.ParseExact(temp[1], "yyyy/MM/dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
        //            DateTime timeketthuc = DateTime.ParseExact(temp[2], "yyyy/MM/dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

        //            DateTime time23h = new DateTime(timebatdau.Year, timebatdau.Month, timebatdau.Day, 23, 0, 0);
        //            DateTime time7h = new DateTime(timebatdau.Year, timebatdau.Month, timebatdau.Day, 7, 0, 0);

        //            tgbd.Add(timebatdau);
        //            tgkt.Add(timeketthuc);

        //            if (timebatdau.Day == timeketthuc.Day)
        //            {


        //                if (timebatdau.Hour >= 7 && timeketthuc.Hour < 23)
        //                {
        //                    sophut7h23h.Add((timeketthuc - timebatdau).TotalMinutes);
        //                    sophut23h7h.Add(0);
        //                }


        //                if (timebatdau.Hour >= 23 && timeketthuc.Hour == 23)
        //                {
        //                    sophut23h7h.Add((timeketthuc - timebatdau).TotalMinutes);
        //                    sophut7h23h.Add(0);
        //                }


        //                if (timebatdau.Hour >= 0 && timeketthuc.Hour < 7)
        //                {
        //                    sophut23h7h.Add((timeketthuc - timebatdau).TotalMinutes);
        //                    sophut7h23h.Add(0);
        //                }


        //                if (timebatdau.Hour < 23 && timeketthuc.Hour == 23)
        //                {
        //                    sophut7h23h.Add((time23h - timebatdau).TotalMinutes);
        //                    sophut23h7h.Add((timeketthuc - time23h).TotalMinutes);
        //                }


        //                if (timebatdau.Hour < 7 && timeketthuc.Hour >= 7)
        //                {
        //                    sophut23h7h.Add((time7h - timebatdau).TotalMinutes);
        //                    sophut7h23h.Add((timeketthuc - time7h).TotalMinutes);
        //                }
        //            }
        //            else
        //            {

        //                if (timebatdau.Hour >= 23 && timeketthuc.Hour < 7)
        //                {
        //                    sophut23h7h.Add((timeketthuc - timebatdau).TotalMinutes);
        //                    sophut7h23h.Add(0);
        //                }


        //                if (timebatdau.Hour < 23 && timeketthuc.Hour < 7)
        //                {
        //                    sophut7h23h.Add((time23h - timebatdau).TotalMinutes);
        //                    sophut23h7h.Add((timeketthuc - time23h).TotalMinutes);
        //                }
        //            }

        //        }

        //        for (int i = 0; i < sophut7h23h.Count; i++)
        //        {
        //            sWriter.Write(id[i]);
        //            sWriter.Write("\t");
        //            sWriter.Write(sophut7h23h[i]);
        //            sWriter.Write("\t");
        //            sWriter.Write(sophut23h7h[i]);
        //            sWriter.WriteLine();

        //        }

        //        for (int i = 0; i < sophut7h23h.Count; i++)
        //        {
        //            ChiTietSuDung ctsd = new ChiTietSuDung();
        //            ctsd.IDSIM = id[i];
        //            ctsd.TGBD = tgbd[i];
        //            ctsd.TGKT = tgkt[i];
        //            ctsd.SoPhut7h23h = (decimal)sophut7h23h[i];
        //            ctsd.SoPhut23h7h = (decimal)sophut23h7h[i];

        //            db.ChiTietSuDungs.Add(ctsd);
        //            db.SaveChanges();

        //        }

        //        sWriter.Flush();
        //        fs.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

    }
}