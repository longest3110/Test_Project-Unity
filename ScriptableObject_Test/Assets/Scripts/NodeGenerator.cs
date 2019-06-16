using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeGenerator : MonoBehaviour {

	[SerializeField]
	DBManager dbManager;

	[SerializeField]
	RowNode rowNode;

	private void Start() {
		DataTable data = dbManager.GetTable();

		// カラム名の追加
		RowNode columnRow = Instantiate(rowNode, rowNode.transform.parent);
		foreach(string column in data.Columns) {
			columnRow.AddColumnNode(column);
		}
		columnRow.gameObject.SetActive(true);


		// foreach(DataRow row in data.Rows) {
		// 	string s = "";
		// 	foreach(string column in data.Columns) {
		// 		s += (row[column].ToString() + ", ");
		// 	}

		// 	Debug.Log(s);
		// }
	}
}
