using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer (typeof (EntityMethodPair))]
public class EntityMethodDrawer : PropertyDrawer {
	
	private float extraHeight = 20.0f;  
	private int tempIndex = 0;

    public override void OnGUI (Rect pos, SerializedProperty prop, GUIContent label) {		
	
        SerializedProperty target = prop.FindPropertyRelative ("target");
        SerializedProperty method = prop.FindPropertyRelative ("method");
		SerializedProperty index = prop.FindPropertyRelative ("index");
						
		EditorGUI.BeginProperty (pos, label, prop) ;
		
		//EditorGUI.BeginChangeCheck();
		// make it a bit more right
		EditorGUI.indentLevel ++;
		
		// original object entity field
		EditorGUI.PropertyField (pos, target, true);		
		//obj = (Entity)EditorGUI.ObjectField (new Rect(pos.x, pos.y, pos.width, pos.height - extraHeight), "Target", obj, typeof(Entity));
				
		// 2nd line
		pos.y += 16;
		pos.height = 16+5;	
		
		// get the methods
		string[] methods = {Entity.noFunctionString + Random.value};			
		Entity tempEnt = (Entity)target.serializedObject.targetObject;

		if (tempEnt != null){
			methods = tempEnt.GetMethodList ();
		}		
		
		// to save the choosen index so it will not be always 0
		tempIndex = Mathf.Min ((int)index.intValue, methods.Length) ;				

		// drop down list for the methods
		index.intValue = EditorGUI.Popup(pos,"Method", tempIndex, methods);	
		method.stringValue = methods[tempIndex];
		
		EditorGUI.EndProperty ();
				
    }
	
	// make it a bit higher so it will look good
	public override float GetPropertyHeight(SerializedProperty prop, GUIContent label) {
		

		return base.GetPropertyHeight(prop, label) + extraHeight;
		
	}
	
}
