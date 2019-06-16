using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager : MonoBehaviour {
	SqliteDatabase sqlDB;

	private void Awake() {
		sqlDB = new SqliteDatabase("newKanjiMaster.db");
	}

	public List<List<string>> GetTable() {
		List<List<string>> output = new List<List<string>>(); 
		DataTable data = sqlDB.ExecuteQuery("select * from idioms_master limit 100");

		foreach (DataRow row in data.Rows) {
			List<string> temp = new List<string>();
			foreach(string column in data.Columns) {
				temp.Add(row[column].ToString());
			}
			output.Add(temp);
		}

		return output;
	}

	public List<string> GetColumnName() {
		return sqlDB.ExecuteQuery("select * from idioms_master limit 1").Columns;
	}
}
