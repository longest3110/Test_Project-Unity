using System.Collections.Generic;
using UnityEngine;
using　UnityEditor;

public class GameManager : MonoBehaviour {

	[SerializeField]
	DBManager dbManager;

	[ContextMenu("Generate")]
	public void GenerateScriptableObject() {
		idioms_master new_idioms_master = new idioms_master();
		new_idioms_master.Data = new List<idioms_master.idioms_master_data>();

		foreach(DataRow row in dbManager.GetData().Rows) {
			idioms_master.idioms_master_data newData = new idioms_master.idioms_master_data();

			newData.id = (int)row["id"];
			newData.grade = (int)row["grade"];
			newData.left_kanji = (string)row["left_kanji"];
			newData.right_kanji = (string)row["right_kanji"];

			new_idioms_master.Data.Add(newData);
		}

		AssetDatabase.CreateAsset(new_idioms_master, "Assets/Resources/idioms_master.asset");
	}
}
