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

namespace True_POS_Activator
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
            Application.Run(new frmActivate());
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