

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using POS_Management;

/* =================About Developer============================
-- Author:		<Sopheaktra>
-- Create date: <2016-01-08>
-- Description:	<Create Classes such : General, Activation,
-- Setting( For database connection) and DBAccess(Accessing to Database's tables)>
-- And some Methods in POS_Management
-- =============================================
 */


namespace POS_Management
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmServer());
        }
    }
}
static class General
{
    public static bool b;
    [DllImport("advapi32.dll", EntryPoint = "RegOpenKeyExA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    public static extern long RegOpenKeyEx(long hKey, string lpSubKey, long ulOptions, long samDesired, long phkResult);
    [DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    public static extern long RegCloseKey(long hKey);
    [DllImport("advapi32.dll", EntryPoint = "RegCreateKeyA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    public static extern long RegCreateKey(long hKey, string lpSubKey, long phkResult);
    [DllImport("advapi32.dll", EntryPoint = "RegDeleteKeyA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    public static extern long RegDeleteKey(long hKey, string lpSubKey);
    [DllImport("advapi32.dll", EntryPoint = "RegQueryValueExA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    public static extern long RegQueryValueEx(long hKey, string lpValueName, long lpReserved, long lpType, string lpData, long lpcbData);
    [DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    public static extern long RegQueryValueExA(long hKey, string lpValueName, long lpReserved, long lpType, ref long lpData, long lpcbData);
    [DllImport("advapi32.dll", EntryPoint = "RegSetValueExA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    public static extern long RegSetValueEx(long hKey, string lpValueName, long Reserved, long dwType, string lpData, long cbData);
    [DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    public static extern long RegSetValueExA(long hKey, string lpValueName, long Reserved, long dwType, ref long lpData, long cbData);
    [DllImport("advapi32.dll", EntryPoint = "RegSetValueExA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    public static extern long RegSetValueExB(long hKey, string lpValueName, long Reserved, long dwType, ref byte lpData, long cbData);

    const Boolean DisplayErrorMsg = false;
    public static string ErrorMsg(long lErrorCode)
    {

        //If an error does accurr, and the user wants error messages displayed, then
        //display one of the following error messages
        string GetErrorMsg = null;
        switch (lErrorCode)
        {
            case 1009:
            case 1015:
                GetErrorMsg = "The Registry Database is corrupt!";
                break;
            case 2:
            case 1010:
                GetErrorMsg = "Bad Key Name";
                break;
            case 1011:
                GetErrorMsg = "Can't Open Key";
                break;
            case 4:
            case 1012:
                GetErrorMsg = "Can't Read Key";
                break;
            case 5:
                GetErrorMsg = "Access to this key is denied";
                break;
            case 1013:
                GetErrorMsg = "Can't Write Key";
                break;
            case 8:
            case 14:
                GetErrorMsg = "Out of memory";
                break;
            case 87:
                GetErrorMsg = "Invalid Parameter";
                break;
            case 234:
                GetErrorMsg = "There is more data than the buffer has been allocated to hold.";
                break;
            default:
                GetErrorMsg = "Undefined Error Code:  " + Conversion.Str(lErrorCode);
                break;
        }
        return GetErrorMsg;
    }

    public static string GetStringValue(string SubKey, string Entry)
    {
        string functionReturnValue = null;
        try
        {
            Registry.LocalMachine.OpenSubKey(SubKey, Microsoft.Win32.RegistryKeyPermissionCheck.Default, System.Security.AccessControl.RegistryRights.ReadKey);
            string sValue = (string)Registry.GetValue(SubKey, Entry, null);

            if ((sValue != null))
            {
                sValue = Strings.Trim(sValue);
                functionReturnValue = Strings.Left(sValue, Strings.Len(sValue) - 1);
                //return the value to the user
            }
            else
            {
                functionReturnValue = "Error";
                //return Error to the user
                //if the user wants errors displayed then
                if (DisplayErrorMsg == true)
                {

                    //tell the user what was wrong
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            functionReturnValue = "Error";
            //return Error to the user
        }
        return functionReturnValue;
    }

    public static void CreateKey(string SubKey)
    {
        try
        {
            Registry.LocalMachine.CreateSubKey(SubKey, Microsoft.Win32.RegistryKeyPermissionCheck.Default, Microsoft.Win32.RegistryOptions.None);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    public static void SetStringValue(string SubKey, string Entry, string Value)
    {
        try
        {
            Registry.LocalMachine.OpenSubKey(SubKey, Microsoft.Win32.RegistryKeyPermissionCheck.Default, System.Security.AccessControl.RegistryRights.WriteKey);
            Registry.SetValue(SubKey, Entry, Value);

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    //---Function get Error by ErrorProvider

    public static void CheckNotEmptyControl(params Control[] Ctrl)
    {
        foreach (Control ct in Ctrl)
        {
            if (ct.Text.Length <= 0)
            {
                b = false;
                break; // TODO: might not be correct. Was : Exit For
            }
            else
            {
                b = true;
            }
        }
        if (!b)
        {
            Interaction.MsgBox("please check require data...");
        }
    }

    public static void DisableControl(params Control[] Ctrl)
    {
        foreach (Control obj in Ctrl)
        {
            obj.Enabled = false;
        }
    }
    public static void EnableControl(params Control[] Ctrl)
    {
        foreach (Control obj in Ctrl)
        {
            obj.Enabled = true;
        }
    }
    public static void SaveRegistry(string RegKey)
    {
        General.CreateKey("SOFTWARE\\True_POS\\ProductID");
        General.SetStringValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\True_POS\\ProductID", "RegisterKey", RegKey);
    }
}
static class Activatation
{

    public static string EncryptRegisterKey(string RegisterKey)
    {
        dynamic CharKey = null;
        dynamic Rnumber = null;
        dynamic LenRegisterKey = null;
        dynamic I = null;
        dynamic ASCkey = null;
        dynamic SResult = null;
        dynamic CASCkey = null;
        dynamic[] RnumberLast = new dynamic[20];
        dynamic[] LenChar = new dynamic[20];
        dynamic LResult = null;

        ////get length of the RegisterKey
        LenRegisterKey = Strings.Len(RegisterKey);
        for (I = 1; I <= LenRegisterKey; I++)
        {
            CharKey = Strings.Mid(RegisterKey, I, 1);
            VBMath.Randomize();
            Rnumber = Conversion.Int(9 * VBMath.Rnd() + 1);
            ASCkey = Strings.Asc(CharKey);
            RnumberLast[I] = Rnumber;
            CASCkey = CASCkey + ASCkey;
            LResult = Conversion.Val(ASCkey) + Conversion.Val(Rnumber);
            SResult = (string)SResult + (Conversion.Val(ASCkey) + Conversion.Val(Rnumber));
            LenChar[I] = Strings.Len(LResult);
            //MsgBox LenChar(I)
        }

        ////put random number at last
        for (I = 1; I <= LenRegisterKey; I++)
        {
            SResult = (string)SResult + LenChar[I] + RnumberLast[I];
        }

        VBMath.Randomize();
        Rnumber = Conversion.Int(9 * VBMath.Rnd() + 1);
        dynamic LEN1 = null;
        LEN1 = Strings.Len(Strings.Len(RegisterKey) + Rnumber) + 1;

        return LEN1 + SResult + (Strings.Len(RegisterKey) + Rnumber) + Rnumber;
    }

    public static string GetDriveSerialNumber()
    {
        try
        {
            dynamic fso;
            dynamic Drv = null;
            dynamic Driveserial = null;
            //Create a FileSystemObject object
            fso = Interaction.CreateObject("Scripting.FileSystemObject");
            //Assign the current drive letter if not specified
            if (!string.IsNullOrEmpty(""))
            {
                Drv = fso.GetDrive("");
            }
            else
            {


                var requiredPath = Path.GetDirectoryName(Path.GetDirectoryName(
                System.IO.Path.GetDirectoryName(
                      System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));


                Drv = fso.GetDrive(fso.GetDriveName(System.AppDomain.CurrentDomain.BaseDirectory));
            }


            if (Drv.IsReady())
            {
                Driveserial = Math.Abs(Drv.SerialNumber);
                //"Drive Not Ready!"
            }
            else
            {
                Driveserial = -1;
            }

            //Clean up
            Drv = null;
            fso = null;

            return (string)Convert.ToString(Driveserial);



        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return "";
        }
    }

    public static Object DescrypRegisterKey(string EncryptKey)
    {
        //Dim FCut
        //Dim LCut
        dynamic LenReg = null;
        dynamic[] AscChar = new dynamic[20];
        dynamic[] Rnumber = new dynamic[20];
        dynamic[] LenAscChar = new dynamic[20];
        dynamic SResult = null;
        dynamic I = null;
        dynamic StrRnumber = null;
        dynamic WEncrypt = null;
        dynamic StartLocation = null;
        dynamic StrLast = null;
        dynamic j = 0;
        dynamic k = 0;

        ////get the last digit need to cut
        //FCut = Mid(EncryptKey, 1, 1)
        //If FCut > 3 Then
        //    FCut = 3
        //End If
        //'//get the last string
        //LCut = Right(EncryptKey, FCut)

        ////get the last string
        StrLast = Strings.Mid(EncryptKey, 2, 32);

        ////get the number of register key
        //Mid(LCut, 1, 1) 
        LenReg = 8;
        //Val(Mid(LCut, 1, Len(LCut) - 1)) - Val(Right(LCut, 1))

        ////get Rnumber , lenascchar
        StrRnumber = Strings.Right(StrLast, LenReg * 2);

        ////get Rnumber
        for (I = 1; I <= LenReg * 2; I++)
        {
            if (I % 2 == 0)
            {
                k = k + 1;
                Rnumber[k] = Strings.Mid(StrRnumber, I, 1);
            }
            else
            {
                j = j + 1;
                LenAscChar[j] = Strings.Mid(StrRnumber, I, 1);
            }
        }
        ////get char acii
        WEncrypt = Strings.Mid(StrLast, 1, Strings.Len(StrLast) - (LenReg * 2));
        StartLocation = 1;

        for (I = 1; I <= Convert.ToInt32(LenReg); I++)
        {
            ////case I=1 mean get first ascii of char
            int Len = 0;
            if (Convert.ToInt32(LenAscChar[I]) > 2)
            {
                if (Convert.ToString(LenAscChar[I]).Length > 2)
                    Len = 3;
                else

                    Len = 2;
            }
            else
            {
                Len = 2;
            }
            AscChar[I] = Conversion.Val(Strings.Mid(WEncrypt, StartLocation, Len)) - Conversion.Val(Rnumber[I]);
            StartLocation = StartLocation + Len;
            //SResult = SResult +(string) Convert.ToChar(AscChar[I]);
            int temp;
            temp = Convert.ToInt16(AscChar[I]);
            // SResult = SResult + temp.ToString();
            SResult = (string)SResult + Strings.Chr(temp);
        }

        return SResult;
    }
}
static class Setting
{
    //Setup the DB Connection before start of the application
    public static SqlConnection cn;
    public static string DBName;
    public static string DBPwd;
    public static string UserID;
    public static string UserName="";
    public static string UserPwd;
    public static string HostAddress;
    public static string DBUser;
    public static string DBPort="";
    public static string DetpName="";
    public static string DeptId="";

    public static Image newImage;
    public const long ERRID_DBPATH_NOT_FOUND = -2147467259;
    public const string REG_APPNAME = "True POS";
    public const string REG_SECTION_DBSETTING = "DBSettings";
    public const string REG_KEY_DBName = "DBName";
    public const string REG_KEY_DBUSER = "DBUser";
    public const string REG_KEY_DBPWD = "DBPwd";
    public const string REG_KEY_PORT = "DBPort";
    public const string REG_KEY_HOST = "DBHost";
    public const string REG_KEY_UID = "UID";
    public const string REG_KEY_UPWD = "UserPwd";
    public const string SYSADMIN_ACCOUNT = "SysAdmin";
    public const string REG_KEY_POSNAME = "POSName";

    public static string GetDBName()
    {

        return Interaction.GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_DBName);

    }

    public static string GetDBPassword()
    {

        return Interaction.GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_DBPWD);

    }

    public static string GetDBUser()
    {

        return Interaction.GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_DBUSER);

    }

    public static string GetDBHost()
    {

        return Interaction.GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_HOST);

    }

    public static string GetDBPort()
    {

        return Interaction.GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_PORT);

    }

    public static string GetUserID()
    {

        return Interaction.GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_UID);

    }

    public static string GetUserPassword()
    {

        return Interaction.GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_UPWD);

    }
    //set the DB setting and logged in user settings

    public static void SetDBName(string sNewName)
    {
        Interaction.SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_DBName, sNewName);

    }



    public static void SetDBUser(string sNewUser)
    {
        Interaction.SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_DBUSER, sNewUser);

    }


    public static void SetDBPassword(string sNewPwd)
    {
        Interaction.SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_DBPWD, sNewPwd);

    }


    public static void SetDBHost(string sNewHost)
    {
        Interaction.SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_HOST, sNewHost);

    }


    public static void SetDBPort(string sNewPwd)
    {
        Interaction.SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_PORT, sNewPwd);

    }


    public static void SetUserID(string sNewUID)
    {
        Interaction.SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_UID, sNewUID);

    }


    public static void SetUserPassword(string sNewPwd)
    {
        Interaction.SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_UPWD, sNewPwd);

    }


    public static void SetPOSName(string sNewName)
    {
        Interaction.SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_POSNAME, sNewName);

    }

    public static string GetPOSName()
    {

        return Interaction.GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_POSNAME);

    }

    public static void SetLogo(Image NewLogo)
    {
        newImage = NewLogo;
    }

    public static void GetLogo(ref Image newLogo)
    {
        newLogo = newImage;
    }
    //To Connect to Access Database'
    public static Boolean Connect()
    {
        try
        {
            DBPwd = GetDBPassword();
            DBName = GetDBName();
            DBUser = GetDBUser();
            HostAddress = GetDBHost();
            //DBPort = GetDBPort();
            UserID = GetUserID();
            UserPwd = GetUserPassword();
            cn = new SqlConnection();
            
            // .ConnectionString = "DATABASE= hospital; SERVER= localhost; user id= root password= 123; port= 3306; charset=utf8"
            cn.ConnectionString = "DATABASE=" + DBName + ";" + "SERVER=" + HostAddress + ";user id=" + DBUser + ";" + "password=" + DBPwd;
            cn.Open();
            if (cn.State != ConnectionState.Open)
            {
                //Interaction.MsgBox("Connection is failed", Constants.vbInformation);
                return false;
            }
            return true;
        }catch (Exception)
        {
            return false;
        }
    }

    internal static Image BinarytoImage( byte[] imageByteArray)
    {
        Image newImage = null;
        MemoryStream Ms = default(MemoryStream);
        if (imageByteArray.GetUpperBound(0) > 0)
        {
            Ms = new MemoryStream(imageByteArray);
            newImage = Image.FromStream(Ms);
            Ms = null;
        }
        return newImage;
    }

    internal static byte[] ImageToBinary( Image NewImage)
    {
        try
        {
            byte[] ImageByteArray = null;
            MemoryStream ReadImage = new MemoryStream();
            NewImage.Save(ReadImage, System.Drawing.Imaging.ImageFormat.Png);
            ImageByteArray = new byte[Convert.ToInt32(ReadImage.Length - 1) + 1];
            ReadImage.Position = 0;
            ReadImage.Read(ImageByteArray, 0, Convert.ToInt32(ReadImage.Length));
            return ImageByteArray;
        }catch(Exception ex){
            MessageBox.Show(ex.Message);
            return null;
        }
    }
    public static bool ValidateEmail(string mail)
    {
        System.Text.RegularExpressions.Regex email = new System.Text.RegularExpressions.Regex("\\S+@\\S+\\.\\S+");

        if (email.IsMatch(mail))
        {
        }
        else
        {
            Interaction.MsgBox("The Email is Not Valid", MsgBoxStyle.Critical, "Invalid Email");
            return false;
        }
        return true;
    }
    public static string ToProper(string Str)
    {
        string OutStr = string.Empty;
        // Used For Holding Each Word Separated By A Space
        string[] Words = Strings.Split(Str, " ");
        // Loop Through All The Words In The String
        int A, B = 0;
        for (A = 0; A <= Words.GetUpperBound(0); A++)
        {
            // Retrieve The Word In The Words Array For Processing
            string TempWord = Words[A];
            // Loop Through All The Characters In The String
            for (B = 0; B <= TempWord.Length - 1; B++)
            {
                if (B == 0)
                {
                    // Make The First Character Uppercase
                    OutStr += char.ToUpper(TempWord[B]);
                }
                else
                {
                    // Make The Other Characters Lowercase
                    OutStr += char.ToLower(TempWord[B]);
                }
                // Add Spaces If Any Are Necessary
                if (A != Words.GetUpperBound(0) & B == TempWord.Length - 1)
                {
                    OutStr += " ";
                }
            }
        }
        // Return Formatted String
        return OutStr;
    }
  
}
static class DBAccess
{
    private static SqlCommand cmd = new SqlCommand();
    private static SqlDataAdapter da = new SqlDataAdapter();
    private static DataTable dt = new DataTable();
    public class OperationGet
    {
        public static DataTable Get_by_Procedure(string stp_name, dynamic[] para ,params dynamic[] cond)
        {
            try
            {
                cmd = new SqlCommand();
                dt = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stp_name;

                if (cond != null && cond.Length > 0)
                {
                    for (Int32 i = 0; i < cond.Length; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter(para[i], cond.GetValue(i)));
                    }
                }
                cmd.Connection = Setting.cn;
                 //   Setting.Connect();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // Fill the DataSet using default values for DataTable names, etc
                da.Fill(dt);

                return dt;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataTable Get_by_direct(string tbname, string fields, string cond)
        {
            try
            {
                dt = new DataTable();
                string sqltext;
                sqltext = "select " + fields + " from " + tbname + " where " + cond;
                da = new SqlDataAdapter(sqltext, Setting.cn);
                da.Fill(dt);
                da.Dispose();
                return dt;
            }
            catch (Exception e) { MessageBox.Show(e.Message); return null; }
        }

    }
    public class OperationInsert
    {
        public static Boolean Insert_by_Procedure(string stp_name, dynamic[] para, params dynamic[] values)
        {
            try
            {
                cmd = new SqlCommand();
                dt = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stp_name;

                if (values != null && values.Length > 0)
                {
                    for (Int32 i = 0; i < values.Length; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter(para[i], values.GetValue(i)));
                    }
                }
                cmd.Connection = Setting.cn;
                //   Setting.Connect();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //MessageBox.Show("Cannot insert data!");
                return false;
            }
        }
        public static Boolean Insert_by_Procedure_with_image(string stp_name, dynamic[] para, string imgField ,Object Imag, params dynamic[] values)
        {
            try
            {
                cmd = new SqlCommand();
                dt = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stp_name;

                if (values != null && values.Length > 0)
                {
                    for (Int32 i = 0; i < values.Length; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter(para[i], values.GetValue(i)));
                    }
                }
                cmd.Parameters.Add(new SqlParameter(imgField,Imag));
                cmd.Connection = Setting.cn;
                //   Setting.Connect();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //MessageBox.Show("Cannot insert data!");
                return false;
            }
        }
        public static Boolean Insert_by_direct(string tbname,dynamic[] fields, params dynamic[] values)
        {
            try
            {
                string field = "", flds = "";
                string val = "", value="";
                string str = "";
                for (int i = 0; i <= fields.Length-1; i++)
                {
                    field =field+ fields[i] + ",";
                    val = val+"@"+fields[i] + ",";
                }
                flds = Strings.Left(field, Strings.Len(field) - 1);
                value = Strings.Left(val, Strings.Len(val) - 1);
                str = "insert into " + tbname + "(" + flds + ")values(" + value + ")";
                using (cmd = new SqlCommand(str, Setting.cn))
                    {
                        for (int j = 0; j <= fields.Length-1; j++)
                        {
                            cmd.Parameters.AddWithValue(fields[j], values[j]);
                        }
                    }
                cmd.ExecuteNonQuery();
                return true;
            }
            
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public static int Insert_by_direct_return_id(string tbname, dynamic[] fields, params dynamic[] values)
        {
            try
            {
                string field = "", flds = "";
                string val = "", value = "";
                string str = "";
                for (int i = 0; i <= fields.Length - 1; i++)
                {
                    field = field + fields[i] + ",";
                    val = val + "@" + fields[i] + ",";
                }
                flds = Strings.Left(field, Strings.Len(field) - 1);
                value = Strings.Left(val, Strings.Len(val) - 1);
                str = "insert into " + tbname + "(" + flds + ") values(" + value + ") ;SELECT SCOPE_IDENTITY()";
                using (cmd = new SqlCommand(str, Setting.cn))
                {
                    for (int j = 0; j <= fields.Length - 1; j++)
                    {
                        cmd.Parameters.AddWithValue(fields[j], values[j]);
                    }
                }
                
                int newId = Convert.ToInt32(cmd.ExecuteScalar());
                return newId;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public static Boolean Insert_by_direct_with_Image(string tbname, string imgField, Object imgVal, dynamic[] fields,params dynamic[] values)
        {
            try
            {
                string field = "", flds = "";
                string val = "", value="";
                string str = "";
                for (int i = 0; i <= fields.Length-1; i++)
                {
                    field =field+ fields[i] + ",";
                    val = val+"@"+fields[i] + ",";
                }
                flds = Strings.Left(field, Strings.Len(field) - 1);
                value = Strings.Left(val, Strings.Len(val) - 1);
                str = "insert into " + tbname + "(" + flds + ")values(" + value + ")";
                using (cmd = new SqlCommand(str, Setting.cn))
                    {
                        for (int j = 0; j <= fields.Length-1; j++)
                        {
                            cmd.Parameters.AddWithValue(fields[j], values[j]);
                        }
                    if(imgVal!=null)
                        cmd.Parameters.AddWithValue("@"+imgField, imgVal);
                    }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
    public class OperationDelete
    {
        public static Boolean Delete_by_Procedure(string stp_name, dynamic[] para, params dynamic[] cond)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stp_name;

                if (cond != null && cond.Length > 0)
                {
                    for (Int32 i = 0; i < cond.Length; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter(para[i], cond.GetValue(i)));
                    }
                }
                cmd.Connection = Setting.cn;
                cmd.ExecuteNonQuery();
                return true ;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static Boolean Delete_by_direct(string tbname, string cond)
        {
            try
            {
                cmd = new SqlCommand();
                string sqltext;
                sqltext = "delete from " + tbname + " where" + cond;
                cmd = new SqlCommand(sqltext, Setting.cn);
                cmd.ExecuteNonQuery();
                return true;
            }catch (Exception e){
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
    public class OperationUpdate
    {
        public static Boolean Update_by_Procedure(string stp_name, dynamic[] para, params dynamic[] values)
        {
            try
            {
                cmd = new SqlCommand();
                dt = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stp_name;

                if (values != null && values.Length > 0)
                {
                    for (Int32 i = 0; i < values.Length; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter(para[i], values.GetValue(i)));
                    }
                }
                cmd.Connection = Setting.cn;
                //   Setting.Connect();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //MessageBox.Show("Cannot insert data!");
                return false;
            }
        }
        public static Boolean Update_by_direct(string tbname, dynamic[] fields,string cond,params dynamic[] values)
        {
            try
            {
                string field = "", flds = "";
                string val = "";
                string str = "";
                for (int i = 0; i <= fields.Length-1; i++)
                {
                    
                    val = fields[i] + "=@" + fields[i] + ",";
                    field = field + val;
                }
                flds = Strings.Left(field, Strings.Len(field) - 1);
                str = "Update " + tbname + " set " + flds + " where "+ cond;
                using (cmd = new SqlCommand(str, Setting.cn))
                    {
                        for (int j = 0; j <= fields.Length-1; j++)
                        {
                            cmd.Parameters.AddWithValue("@"+fields[j], values[j]);
                        }
                    }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
    
}