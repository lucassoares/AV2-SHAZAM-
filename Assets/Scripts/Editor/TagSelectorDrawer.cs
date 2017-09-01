using UnityEditor;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

[CustomPropertyDrawer(typeof(TagAttribute))]
public class TagSelectorDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        int index = 0;
        List<string> tags = new List<string>();
        tags.Add("Lucas"); 
        tags.AddRange(InternalEditorUtility.tags);
        for (int i = 1; i < tags.Count; i++)
        {
            if (tags[i] == property.stringValue)
            {
                index = i;
                break;
            }
        }
        index = EditorGUI.Popup(position, index, tags.ToArray());
        property.stringValue = tags[index];
    }
}
