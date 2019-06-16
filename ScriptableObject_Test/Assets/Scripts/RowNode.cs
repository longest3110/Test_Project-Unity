using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RowNode : MonoBehaviour {
	[SerializeField]
	Text columnNode;

	public void AddColumnNode(string value) {
		Text addNode = Instantiate(columnNode, columnNode.transform.parent);
		addNode.text = value;
		addNode.gameObject.SetActive(true);
	}

}
