﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;

namespace App
{
    class Setting
    {
        public enum AfterAction
        {
            Shutdown = 5,
            Restart = 4,
            Sleep = 3,
            Lock = 2,
            Exit = 1,
            None = 0
        }
        private DateTime _timeSetter;
        private AfterAction _afterAction;
        private bool _cleanAfter;
        private bool _dataExport;
        private bool _isSetTime;
        private string _saveDownloadPath;
        private string _exportPath;
        public DateTime timeSetter
        {
            get
            {
                return _timeSetter;
            }
            set
            {
                _timeSetter = value;
            }
        }
        public AfterAction afterAction
        {
            get
            {
                return _afterAction;
            }
            set
            {
                _afterAction = value;
            }
        }
        public bool cleanAfter
        {
            get
            {
                return _cleanAfter;
            }
            set
            {
                _cleanAfter = value;
            }
        }
        public bool dataExport
        {
            get
            {
                return _dataExport;
            }
            set
            {
                _dataExport = value;
            }
        }
        public string saveDownloadPath
        {
            get
            {
                return _saveDownloadPath;
            }
            set
            {
                _saveDownloadPath = value;
            }
        }
        public bool isSetTime
        {
            get
            {
                return _isSetTime;
            }
            set
            {
                _isSetTime = value;
            }
        }
        public string exportPath
        {
            get
            {
                return _exportPath;
            }
            set
            {
                _exportPath = value;
            }
        }

        public Setting(DateTime dateTime)
        {
            //importSetting();
            _timeSetter = dateTime;
            this._afterAction = AfterAction.None;
            this._cleanAfter = false;
            this._dataExport = false;
            this._saveDownloadPath = @"C:\autoStudent";
            this._exportPath = String.Empty;
        }

        // For Lock
        [DllImport("user32")]
        public static extern void LockWorkStation();

        // For Sleep
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        public void RunAfterAction()
        {
            switch (afterAction)
            {
                case AfterAction.Exit:
                    Application.Exit();
                    break;
                case AfterAction.Shutdown:
                    Process.Start("shutdown", "/s /t 0");
                    break;
                case AfterAction.Restart:
                    Process.Start("shutdown", "/r /t 0");
                    break;
                case AfterAction.Lock:
                    LockWorkStation();
                    break;
                case AfterAction.Sleep:
                    SetSuspendState(false, true, true);
                    break;
            }
        }

        public bool RunCleanAction(string downloadFolderPath)
        {
            if (cleanAfter)
            {
                if (Directory.Exists(downloadFolderPath))
                {
                    try
                    {
                        Directory.Delete(downloadFolderPath);
                        return true;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Không có quyền xóa thư mục tạm thời");
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Lỗi xóa thư mục tạm thời");
                    }
                    catch { }
                }
            }
            return false;
        }

        public bool RunDataExport(List<Package> dataList, string pathSaveExport)
        {
            if (dataExport && dataList != null)
            {
                if (Directory.Exists(pathSaveExport))
                {
                    string data = "";
                    string filePath = pathSaveExport + @"\AutoStudentDataExport.AS";
                    string passExport = DataAccess.Instance.GetPassCry();
                    try
                    {
                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                        }
                        foreach (var item in dataList)
                        {
                            data += $"{item.Name}\n";
                        }
                        using (StreamWriter sw = File.CreateText(filePath))
                        {
                            string encrypt = Cryptography.Encrypt(data, passExport);
                            sw.Write(encrypt);
                        }
                        return true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Lỗi lưu file");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Không có quyền lưu ở thư mục chọn");
                    }
                }
                else MessageBox.Show("Lỗi đường dẫn lưu file");
            }
            else MessageBox.Show("Chưa có gì để export");
            return false;
        }

    }
}