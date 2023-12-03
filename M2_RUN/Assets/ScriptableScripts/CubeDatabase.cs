using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CubeGeneration", menuName = "Cube/Datadase")]
public class CubeDatabase : ScriptableObject, ISerializationCallbackReceiver
{
    public ScriptableCube[] _cubeBase;
    public List<ScriptableCube> _getCube;

    public void OnBeforeSerialize()
    {
        _getCube = new List<ScriptableCube>();
    }

    public void OnAfterDeserialize()
    {
        for (int i = 0; i < _cubeBase.Length; i++)
        {
            _getCube.Add(_cubeBase[i]);
        }
    }
}
