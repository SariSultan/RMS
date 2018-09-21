using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Calcium_RMS.BackupManager
{
    public static class DatabaseBackupManager
    {
        public static ProgressBar __ProgressBar{ get;  set;}

        public static void ProgressEventHandler(object sender, PercentCompleteEventArgs e)
        {
            if (__ProgressBar!=null)
            {
                __ProgressBar.Value = e.Percent;                
            }            
        }

        public static bool BackupDataBase(string SaveAsPath, SqlConnection aSqlConnection)
        {
            try
            {
                aSqlConnection.Open();
                string DatabaseName = aSqlConnection.Database;
                ServerConnection __ServerConnection = new ServerConnection(aSqlConnection);
                Server __Server = new Server(__ServerConnection);
                BackupDeviceItem __BackUpDeciveItem = new BackupDeviceItem(SaveAsPath, DeviceType.File);
                // Create the backup informaton
                Backup __Backup = new Backup();
                __Backup.Devices.Add(__BackUpDeciveItem);
                __Backup.Action = BackupActionType.Database;
               // __Backup.CompressionOption = BackupCompressionOptions.On;
                __Backup.BackupSetDescription = "CALCIUM RMS V1.00 Database Backup";
                __Backup.BackupSetName = "RMS V1.00 Full Database Backup";
                __Backup.Database = DatabaseName;
                __Backup.ExpirationDate = DateTime.Now.AddHours(24);
                __Backup.LogTruncation = BackupTruncateLogType.Truncate;

                if (__ProgressBar != null)
                {
                    __ProgressBar.Value = 0;
                    __ProgressBar.Maximum = 100;
                    __ProgressBar.Value = 10;

                    __Backup.PercentCompleteNotification = 10;
                    __Backup.PercentComplete += new PercentCompleteEventHandler(ProgressEventHandler);
                }
                // Run the backup
                 __Backup.SqlBackup(__Server);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                aSqlConnection.Close();
            }
        }

        public static bool RestoreDatabse(string BackupPath, SqlConnection aSqlConnection)
        {
            try
            {
                aSqlConnection.Open();
                string DatabaseName = aSqlConnection.Database.ToString();

                ServerConnection __ServerConnection = new ServerConnection(aSqlConnection);
                Server __Server = new Server(__ServerConnection);

                aSqlConnection.ChangeDatabase("master");

                // Create backup device item for the backup
                BackupDeviceItem __BackUpDeciveItem = new BackupDeviceItem(BackupPath, DeviceType.File);

                // Create the restore object
                Restore __Restore = new Restore();
                __Restore.Devices.Add(__BackUpDeciveItem);
                __Restore.NoRecovery = false;
                __Restore.ReplaceDatabase = true;
                __Restore.Database = DatabaseName;

                if (__ProgressBar!=null)
                {
                  __ProgressBar.Value = 0;
                __ProgressBar.Maximum = 100;
                __ProgressBar.Value = 10;

                __Restore.PercentCompleteNotification = 10;
                __Restore.ReplaceDatabase = true;
                __Restore.PercentComplete += new PercentCompleteEventHandler(ProgressEventHandler);  
                }
                // Restore the database
                __Restore.SqlRestore(__Server);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { aSqlConnection.Close(); }
        }

        public static bool VerifyDatabaseBackup(string BackupPath, SqlConnection aSqlConnection)
        {
            Restore rest = new Restore();
            string fileName = BackupPath;

            ServerConnection __ServerConnection = new ServerConnection(aSqlConnection);
            Server __Server = new Server(__ServerConnection);
            try
            {
                rest.Devices.AddDevice(fileName, DeviceType.File);
                bool verifySuccessful = rest.SqlVerify(__Server);
                if (verifySuccessful)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SmoException exSMO)
            {
                throw new Exception(exSMO.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                aSqlConnection.Close();
            }
        }

    }
}
