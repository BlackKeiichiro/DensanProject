using UnityEngine;
using UnityEditor;
using System.Collections;

public class CreateObject : EditorWindow {
	//private GameObject parent;
    private GameObject prefab;
    private int num = 0;
	private float posx = 0;
	
	[MenuItem("GameObject/CreateObject")]
	static void Init()
	{
		EditorWindow.GetWindow<CreateObject>(true,"CreateObject");
		
	}
	void OnEnable(){
		//Selection.gameObjectsは関数ごとに存在している・・・？
		if(Selection.gameObjects.Length > 0){
			//parent = Selection.gameObjects[0];
		}
	}	
	void OnSelectionChange()
	{
		if(Selection.gameObjects.Length > 0){
			prefab = Selection.gameObjects[0];
			Repaint();
		}
	}
	void OnGUI()
	{
		try{
			prefab = EditorGUILayout.ObjectField("Prefub",prefab,typeof(GameObject),true) as GameObject;
            num = int.Parse(EditorGUILayout.TextField("Number", num.ToString()));
			posx = int.Parse(EditorGUILayout.TextField("Position x",posx.ToString()));
            GUILayout.Label("", EditorStyles.boldLabel);
			if(GUILayout.Button("Create")){
				Creation(num);
			}
		}catch(System.FormatException){}
	}
	
	private void Creation(int num){
		if(prefab == null)return;
		float posz = 0;
		Vector3 pos = Vector3.zero;
		while(num > 0){
			posz += 3;
			num--;
			pos = new Vector3(posx,5,posz);
			GameObject localobj = Instantiate(prefab,pos,Quaternion.identity) as GameObject;
        	Undo.RegisterCreatedObjectUndo(localobj, "CreateObject");
		}
	}
}
