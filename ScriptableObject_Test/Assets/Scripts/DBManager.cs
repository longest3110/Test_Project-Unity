using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager : MonoBehaviour {
	SqliteDatabase sqlDB;

	private void Awake() {
		sqlDB = new SqliteDatabase("newKanjiMaster.db");
	}

	public List<Dictionary<string, object>> GetTable() {
		List<Dictionary<string, object>> output = new List<Dictionary<string, object>>(); 
		DataTable data = sqlDB.ExecuteQuery("select * from idioms_master limit 100");

		foreach (DataRow row in data.Rows) {
			Dictionary<string, object> temp = new Dictionary<string, object>();
			foreach(string column in data.Columns) {
				temp.Add(column, row[column]);
			}
			output.Add(temp);
		}

		return output;
	}

	public List<string> GetColumnName() {
		return sqlDB.ExecuteQuery("select * from idioms_master limit 1").Columns;
	}

	public DataTable GetData() {
		return sqlDB.ExecuteQuery("select * from idioms_master");
	}
}
