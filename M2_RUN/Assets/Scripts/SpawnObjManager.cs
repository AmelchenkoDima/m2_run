using System.Collections.Generic;
using UnityEngine;

public class SpawnObjManager : MonoBehaviour
{
    public enum Cube // Выбор для определения типа префаба 
    {
        PlayerCube = 0,
        Cube = 1,
    }

    [SerializeField] private CubeDatabase _databaseObj;
    [SerializeField] private Cube _cube;
    [SerializeField] private Transform _transformObj;
    [HideInInspector] public List<GameObject> _cubeObjList = new List<GameObject>();
    [HideInInspector] public List<GameObject> _playerObjList = new List<GameObject>();
    public int _lvl = 0;
    private ScriptableCube _scriptableCube;
   


    void Start()
    {
        LevelCheck();
        InstObjTwoByTwo();
        InstObjThreeByThree();
    }

    private void LevelCheck()
    {
        if (_cubeObjList.Count == 0)
        {
            if (_cube == Cube.PlayerCube)
            {
                LevelCheckPlayerCube();
            }
            else LevelCheckCube();
        }
    }

    private ScriptableCube LevelCheckPlayerCube()
    {
        for (int i = 0; i < _databaseObj._playerGetCube.Count; i++)
        {
            if (_databaseObj._playerGetCube[i].LevelCube == _lvl)
            {
                _scriptableCube = _databaseObj._playerGetCube[i];
                return _scriptableCube;
            }
        }
        return null;
    }

    private ScriptableCube LevelCheckCube()
    {
        for (int i = 0; i < _databaseObj._getCube.Count; i++)
        {
            if (_databaseObj._getCube[i].LevelCube == _lvl)
            {
                _scriptableCube = _databaseObj._getCube[i];
                return _scriptableCube;
            }
        }
        return null;
    }

    public void InstObjTwoByTwo()
    {
        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.LowerLeft) != 0)
        {
            GameObject boxLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.250f, 0.25f, 0f), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxLowerLeft);
            }
            else _cubeObjList.Add(boxLowerLeft);
        }

        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.UpperLeft) != 0)
        {
            GameObject boxUpperLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.250f, 0.751f, 0f), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxUpperLeft);
            }
            else _cubeObjList.Add(boxUpperLeft);
        }

        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.LowerRight) != 0)
        {
            GameObject boxLowerRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.250f, 0.25f, 0f), Quaternion.identity, _transformObj);

            if( _cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxLowerRight);
            }
            else _cubeObjList.Add(boxLowerRight);
        }

        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.UpperRight) != 0)
        {
            GameObject boxUpperRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.250f, 0.751f, 0f), Quaternion.identity, _transformObj);

            if ( _cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxUpperRight);
            }
            else _cubeObjList.Add(boxUpperRight);
        }
    }

    public void InstObjThreeByThree()
    {
        if((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.LowerLeft) != 0)
        {
            GameObject boxLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.501f,0.25f,0f), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxLowerLeft);
            }
            else _cubeObjList.Add(boxLowerLeft);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.LowerCenter) != 0)
        {
            GameObject boxLowerCenter = Instantiate(_scriptableCube.CubePrefab, new Vector3(0f, 0.25f, 0f), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxLowerCenter);
            }
            else _cubeObjList.Add(boxLowerCenter);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.LowerRight) != 0)
        {
            GameObject boxLowerRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.501f, 0.25f, 0f), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxLowerRight);
            }
            else _cubeObjList.Add(boxLowerRight);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.MiddleLeft) != 0)
        {
            GameObject boxMiddleLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.501f, 0.751f, 0f), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxMiddleLeft);
            }
            else _cubeObjList.Add(boxMiddleLeft);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.MiddleCenter) != 0)
        {
            GameObject boxMiddleCenter = Instantiate(_scriptableCube.CubePrefab, new Vector3(0f, 0.751f, 0f), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxMiddleCenter);
            }
            else _cubeObjList.Add(boxMiddleCenter);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.MiddleRight) != 0)
        {
            GameObject boxMiddleRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.501f, 0.751f, 0f), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxMiddleRight);
            }
            else _cubeObjList.Add(boxMiddleRight);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.UpperLeft) != 0)
        {
            GameObject boxUpperLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.501f, 1.251f, 0f), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxUpperLeft);
            }
            else _cubeObjList.Add(boxUpperLeft);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.UpperCenter) != 0)
        {
            GameObject boxUpperCenter = Instantiate(_scriptableCube.CubePrefab, new Vector3(0f, 1.251f, 0f), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxUpperCenter);
            }
            else _cubeObjList.Add(boxUpperCenter);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.UpperRight) != 0)
        {
            GameObject boxUpperRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.501f, 1.251f, 0f), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxUpperRight);
            }
            else _cubeObjList.Add(boxUpperRight);
        }
    }
}
