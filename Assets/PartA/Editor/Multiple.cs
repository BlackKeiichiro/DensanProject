using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(ItemInstantiate))]
public class Multiple : Editor {
	/*public override void OnInspectorGUI(){
		ItemInstantiate targetScript = target as ItemInstantiate;
		EditorGUI.BeginChangeCheck();
		EditorGUILayout.BeginHorizontal();
		EditorGUILayout.LabelField("Script：ItemInstantiate");
		foreach(int _getnum in targetScript.num){
			EditorGUILayout.IntField(_getnum);
			//EditorGUILayout.LabelField("");
		} 
		EditorGUILayout.LabelField(targetScript.num.ToString());
		EditorGUILayout.EndHorizontal();
	}*/
}
