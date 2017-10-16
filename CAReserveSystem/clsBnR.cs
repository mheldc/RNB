using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BNRLibrary
{
    public class G {
        // Salt
        public static string EncryptionKey = "rasCtbuovcwsxdytze1a2f3A4g5b6h7r8i9i0j!l@k#R$l%e^m&s*n(o)o-r=p_t+q";
        public static string MotherboardSerial = CaligrapySecurity.GetMBoardSerial();
        public static string HarddriveSerial = CaligrapySecurity.GetHDDSerial();
        public static string LicenseKey = CaligrapySecurity.EncryptText(MotherboardSerial + HarddriveSerial, EncryptionKey);
        public static string PLicenseKey;

        // Database Variables
        //public static string DefaultHost = "localhost", DefaultDb = "careserve", DefaultId = "root", DefaultPw = "";
        public static string DefaultHost, DefaultDb, DefaultId, DefaultPw;
        public static int DefaultPort = 3306;

        // User Variables
        public static string CurrentUserName, CurrentUserRole;
        public static int CurrentUserId, CurrentRoleId;
        public static bool AllowSignIn = false, AllowBooking = false, AllowReservation = false, AllowInventory = false, AllowCashiering = false, AllowSetup = false, AllowReports = false;
        public static string CompanyName;
        public static byte[] CompanyLogo;

        // Booking Objects
        public static Int32 SelectedBID = 0;
        public static Int32 SelectedGID = 0;
        public static DataTable GuestInfo = null;
        public static bool WithPaymentsUnpaid = false;
        public static Int32 PassToIssue = 0;

        // Global Objects
        public static DataTable dt = null;
        public static DataRow rw;
        public static MySqlConnection cn = null;
        public static MySqlCommand cm = null;
        public static MySqlDataAdapter da = null;
        public static ArrayList spArr = null;
        public static int AffectedDbRows = 0;
        public static bool SignInFlag = true;

        public static string Qry = "";

        public static string LogPath = "";
        public static string DbConfig = Application.StartupPath + "\\Db.conf";
        public static string LiConfig = Application.StartupPath + "\\Lic.conf";

        public static int ReportType = 0;
    }

    public class CaligrapySecurity
    {
        public static String EncryptText(string s, string ek)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(s);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(ek, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    s = Convert.ToBase64String(ms.ToArray());
                }
            }
            return s;
        }

        public static String DecryptText(string s, string ek)
        {
            byte[] cipherBytes = Convert.FromBase64String(s);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(ek, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    s = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return s;
        }

        public static String GetMBoardSerial()
        {
            string s = "";
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
            foreach (ManagementObject mo in mbs.Get())
            {
                s = mo["SerialNumber"].ToString();
            }
            return s;
        }

        public static String GetHDDSerial()
        {
            string s = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            foreach (ManagementObject hd in mos.Get())
            {
                if (hd["Tag"].ToString() == "\\\\.\\PHYSICALDRIVE0")
                {
                    s = hd["SerialNumber"].ToString().Trim();
                }
            }
            return s;
        }
    }

    public class MyDb
    {
        public static MySqlConnection Open(string host, string db, string lid, string lpw)
        {
            MySqlConnection myDb = new MySqlConnection(String.Format("Server={0};Database={1};Uid={2};Pwd={3};", host, db, lid, lpw));
            try
            {
                myDb.Open();
                return myDb;
            }
            catch (Exception ex)
            {
                myDb = null;
                MessageBox.Show("Error connecting to database server. /n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return myDb;
            }
        }

        public static MySqlConnection Open(string host, string db, string lid, string lpw, int port)
        {
            MySqlConnection myDb = new MySqlConnection(String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};", host, port,db, lid, lpw));
            try
            {
                myDb.Open();
                return myDb;
            }
            catch (Exception ex)
            {
                myDb = null;
                MessageBox.Show("Error connecting to database server. /n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return myDb;
            }
        }

        public static DataTable GetResults(MySqlConnection cn, string cmdtext, ArrayList sparams = null)
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlCommand cm = new MySqlCommand(cmdtext, cn))
                {
                    if (sparams != null)
                    {
                        cm.CreateParameter();
                        foreach (MySqlParameter mysp in sparams)
                        {
                            cm.Parameters.Add(mysp);
                        }
                    }

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cm))
                    {
                        da.Fill(dt);
                    }

                    if (dt.Rows.Count == 0) { dt = null; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while executing query /n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }

        public static int ExecSQL(MySqlConnection cn, string cmdtext, ArrayList sparams = null)
        {
            int AffectedRows = 0;
            MySqlTransaction trn = cn.BeginTransaction();
            try
            {
                using (MySqlCommand cm = new MySqlCommand(cmdtext, cn))
                {
                    if (sparams != null)
                    {
                        cm.CreateParameter();
                        foreach (MySqlParameter mysp in sparams)
                        {
                            cm.Parameters.Add(mysp);
                        }
                    }
                    Logging.Activity("Executing/running query [" + cmdtext + "] ...");
                    AffectedRows = cm.ExecuteNonQuery();
                    trn.Commit();
                    Logging.Activity("Executing/running query [" + cmdtext + "] ... Done");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while running/executing SQL query " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logging.Activity("Error occured while running/executing SQL query [" + cmdtext + "] due to " + ex.Message);
                trn.Rollback();
            }
            return AffectedRows;
        }

        public static void LoadDataToComboBox(ComboBox obj, string vm, string dm, string cmdtext, MySqlConnection cn, ArrayList sparams = null)
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlCommand cm = new MySqlCommand(cmdtext, cn))
                {
                    if (sparams != null)
                    {
                        cm.CreateParameter();
                        foreach (MySqlParameter mysp in sparams)
                        {
                            cm.Parameters.Add(mysp);
                        }
                    }

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cm))
                    {
                        da.Fill(dt);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        obj.ValueMember = vm;
                        obj.DisplayMember = dm;
                        obj.DataSource = dt;                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while executing query /n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }
        }
    }

    public class Logging
    {
        public static void Activity(string a)
        {
            G.LogPath = Application.StartupPath + "\\Logs-" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            using(StreamWriter sw = new StreamWriter(G.LogPath, true))
            {
                sw.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss") + ": " + a);
            }
        }
    }

    public class Settings
    {
        public static void Load()
        {
            if (File.Exists(G.DbConfig))
            {
                int lnum = 1;
                using (StreamReader sr = new StreamReader(G.DbConfig))
                {
                    while (sr.EndOfStream == false)
                    {
                        if (lnum == 1) { G.DefaultHost =  CaligrapySecurity.DecryptText(sr.ReadLine(), G.EncryptionKey); }
                        else if (lnum == 2) { G.DefaultDb = CaligrapySecurity.DecryptText(sr.ReadLine(), G.EncryptionKey); }
                        else if (lnum == 3) { G.DefaultPort = Convert.ToInt16(sr.ReadLine()); }
                        else if (lnum == 4) { G.DefaultId = CaligrapySecurity.DecryptText(sr.ReadLine(), G.EncryptionKey); }
                        else if (lnum == 5) {G.DefaultPw = CaligrapySecurity.DecryptText(sr.ReadLine(), G.EncryptionKey); }
                        else { }
                        lnum++;
                    }
                }
            }

            if (File.Exists(G.LiConfig))
            {
                using(StreamReader sr = new StreamReader(G.LiConfig))
                {
                    while(sr.EndOfStream == false)
                    {
                        G.PLicenseKey = sr.ReadLine().ToString();
                    }
                }
            }
        }
    }

}
