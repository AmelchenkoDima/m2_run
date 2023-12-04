using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CubeGeneration", menuName = "Cube/Datadase")]
public class CubeDatabase : ScriptableObject, ISerializationCallbackReceiver
{
    public ScriptableCube[] _playerCubeBase;
    public List<ScriptableCube> _playerGetCube;

    public ScriptableCube[] _cubeBase;
    public List<ScriptableCube> _getCube;


    public void OnBeforeSerialize()
    {
        _playerGetCube = new List<ScriptableCube>();
        _getCube = new List<ScriptableCube>();
    }

    public void OnAfterDeserialize()
    {
        for (int i = 0; i < _playerCubeBase.Length; i++)
        {
            _playerGetCube.Add(_playerCubeBase[i]);
        }

        for (int i = 0; i < _cubeBase.Length; i++)
        {
            _getCube.Add(_cubeBase[i]);
        }
    }
}
