using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ファイル名、メニュー表示名、表示順を指定
[CreateAssetMenu(fileName = "idioms_master", menuName = "ScriptableObject/idioms_master")]
public class idioms_master : ScriptableObject {

    public List<idioms_master_data> Data;

    [System.Serializable]
    public class idioms_master_data {
        public int id;
        public int grade;
        public string left_kanji;
        public string right_kanji;
    }
}
