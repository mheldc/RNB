using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CA_Turnstile
{
    class CAGlobals
    {
        // Database Settings
        public static string DefaultHost = "";
        public static string DefaultDatabase = "";
        public static string LoginUID = "";
        public static string LoginPWD = "";
        public static int DefaultPort = 3306;

        // COM port settings
        public static int DefaultCOMPort = -1;
        public static int DefaultBaudRate = -1;
        public static int DefaultDataBits = -1;
        public static int DefaultStopBits = -1;
        public static int DefaultParityBits = -1;
        public static int DefaultHandshake = -1;
        public static int DefaultDelay = -1;
        public static int ScanDelay = -1;
        public static string COMPortName = "";
        public static string BaudRateName = "";
        public static string DataBitName = "";
        public static string StopBitName = "";
        public static string HandshakeName = "";
        public static string ParityName = "";
        public static string DelayName = "";
        public static string COMSettingsFile = Application.StartupPath + @"\CATOCom.conf";
        public static int GateDirection = 0;

        // License
        public static string LicenseKey = "";

        public enum LKType
        {
            Validation = 0,
            Registration = 1
        }
    }

    class CADatabase
    {
        public MySqlConnection MyDbOpen(string host, string db, string lid, string lpw, int port = 3306) 
        {
            MySqlConnection myDb = new MySqlConnection(String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};", host, port, db, lid, lpw));
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

        public DataTable GetResults(MySqlConnection cn, string cmdtext, ArrayList sparams = null)
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

        public int ExecSQL(MySqlConnection cn, string cmdtext, ArrayList sparams = null)
        {
            int AffectedDbRows = 0;
            try
            {
                using(MySqlCommand cm = new MySqlCommand(cmdtext, cn))
                {
                    if(sparams != null)
                    {
                        cm.CreateParameter();
                        foreach(MySqlParameter mysp in sparams)
                        {
                            cm.Parameters.Add(mysp);
                        }
                    }
                    AffectedDbRows =  cm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while running/executing SQL query " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return AffectedDbRows;
        }
    }

    class CaligrapyEncryption
    {
        public const string EncryptionKey = "rasCtbuovcwsxdytze1a2f3A4g5b6h7r8i9i0j!l@k#R$l%e^m&s*n(o)o-r=p_t+q";
        public String EncryptText(string s)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(s);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
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

        public String DecryptText(string s)
        {
            byte[] cipherBytes = Convert.FromBase64String(s);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
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
    }
}
