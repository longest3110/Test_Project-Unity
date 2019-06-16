using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager : MonoBehaviour {
	SqliteDatabase sqlDB;

	private void Awake() {
		sqlDB = new SqliteDatabase("newKanjiMaster.db");
	}

	public DataTable GetTable() {
		return sqlDB.ExecuteQuery("select * from idioms_master");
	}
}
