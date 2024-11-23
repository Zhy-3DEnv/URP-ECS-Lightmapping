using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PingPongMovement))]
public class PingPongMovementEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // 显示默认的Inspector属性
        DrawDefaultInspector();

        // 获取PingPongMovement脚本对象
        PingPongMovement movementScript = (PingPongMovement)target;

        // 添加按钮以将当前位置保存为点A
        if (GUILayout.Button("Set Current Position as Point A"))
        {
            Undo.RecordObject(movementScript, "Set Point A");
            movementScript.pointA = movementScript.transform.position;
            EditorUtility.SetDirty(movementScript);
        }

        // 添加按钮以将当前位置保存为点B
        if (GUILayout.Button("Set Current Position as Point B"))
        {
            Undo.RecordObject(movementScript, "Set Point B");
            movementScript.pointB = movementScript.transform.position;
            EditorUtility.SetDirty(movementScript);
        }
    }
}
