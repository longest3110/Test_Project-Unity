using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectManager : MonoBehaviour {
	idioms_master idioms_master;

	private void Awake() {
		idioms_master = Resources.Load<idioms_master>("idioms_master");
	}

	public List<Dictionary<string, object>> GetTable() {
		List<Dictionary<string, object>> output = new List<Dictionary<string, object>>(); 

		for(int i = 0 ; i < 100 ; i++) {
			Dictionary<string, object> temp = new Dictionary<string, object>();

			temp.Add("id", idioms_master.Data[i].id);
			temp.Add("grade", idioms_master.Data[i].grade);
			temp.Add("left_kanji", idioms_master.Data[i].left_kanji);
			temp.Add("right_kanji", idioms_master.Data[i].right_kanji);

			output.Add(temp);
		}

		return output;
	}

}
