using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeGenerator : MonoBehaviour {

	[SerializeField]
	DBManager dbManager;

	[SerializeField]
	RowNode rowNode;

	private void Start() {
		List<List<string>> data = dbManager.GetTable();

		// カラム名の追加
		RowNode columnRow = Instantiate(rowNode, rowNode.transform.parent);
		foreach(string column in dbManager.GetColumnName()) {
			columnRow.AddColumnNode(column);
		}
		columnRow.gameObject.SetActive(true);


		foreach(List<string> row in data) {
			RowNode newRow = Instantiate(rowNode, rowNode.transform.parent);
			foreach(string column in row) {
				newRow.AddColumnNode(column);
			}
			newRow.gameObject.SetActive(true);
		}
	}
}
