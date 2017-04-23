using System;
using System.Data.OleDb;
using NLog;
using VerifilerCore;

namespace VerifilerACCDB {
	/// <summary>
	/// By trying to establish the OleDbConnection, we can quickly
	/// determine, whether the source .accdb file is corrupted or not. 
	/// 
	/// The error code produced by this validation is Error.Corrupted.
	/// </summary>
	public class ACCDBValidator : FormatSpecificValidator {

		public override int ErrorCode { get; set; } = Error.Corrupted;

		private static readonly Logger logger = LogManager.GetCurrentClassLogger();

		public override void Setup() {
			Name = "Access database files Verification";
			RelevantExtensions.Add(".accdb");
			Enable();
		}

		public override void ValidateFile(string file) {
			OleDbConnection connection = null;
			try {
				logger.Debug("Trying to establish connection via OleDbConnection for file {0}", file);
				connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file + ";Persist Security Info=False;");
				connection.Open();
				connection.Close();
				logger.Debug("Connection established");
			} catch (Exception e) {
				logger.Error("Unable to establish connection, reporting error");
				ReportAsError(e.Message);
				GC.Collect();
			} finally {
				if (connection != null) {
					connection.Close();
				}
			}
		}
	}
}
