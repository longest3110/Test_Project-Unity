using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeGenerator : MonoBehaviour {

	[SerializeField]
	DBManager dbManager;

	[SerializeField]
	ScriptableObjectManager scriptableObjectManager;

	[SerializeField]
	RowNode rowNode;

	private void Start() {
		List<Dictionary<string, object>> data = scriptableObjectManager.GetTable();

		// カラム名の追加
		RowNode columnRow = Instantiate(rowNode, rowNode.transform.parent);
		foreach(string column in dbManager.GetColumnName()) {
			columnRow.AddColumnNode(column);
		}
		columnRow.gameObject.SetActive(true);

		foreach(Dictionary<string, object> row in data) {
			RowNode newRow = Instantiate(rowNode, rowNode.transform.parent);
			foreach(string column in dbManager.GetColumnName()) {
				newRow.AddColumnNode(row[column].ToString());
			}
			newRow.gameObject.SetActive(true);
		}
	}
}
