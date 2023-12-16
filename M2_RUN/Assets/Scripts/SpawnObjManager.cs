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

    [HideInInspector] public List<GameObject> _cubeObjList = new List<GameObject>();
    [HideInInspector] public List<GameObject> _playerObjList = new List<GameObject>();

    public Transform _transformObj;
    public int _lvl = 0;

    private ScriptableCube _scriptableCube;


    void Start()
    {
        ResetLvl();
    }

    void Update()
    {
        if (_transformObj.childCount == 0)
        {
            _lvl += 1;
            CheckEnumCube();
        }
    }

    private void ResetLvl()
    {
        while (_transformObj.childCount > 0)
        {
            Destroy(_transformObj.GetChild(0));
            _cubeObjList.RemoveAt(0);
            _playerObjList.RemoveAt(0);
        }
        _lvl += 1;
        CheckEnumCube();
    }

    private void CheckEnumCube()
    {
        if (_cube == Cube.PlayerCube)
        { 
            LevelCheckPlayerCube();
        }
        else LevelCheckCube();

    }

    private void LevelCheckPlayerCube()
    {
        for (int i = 0; i < _databaseObj._playerGetCube.Count; i++)
        {
            if (_databaseObj._playerGetCube[i].LevelCube == _lvl)
            {
                _scriptableCube = _databaseObj._playerGetCube[i];
                
            }
        }

        InstObjTwoByTwo();
        InstObjThreeByThree();
    }

    private void LevelCheckCube()
    {
        for (int i = 0; i < _databaseObj._getCube.Count; i++)
        {
            if (_databaseObj._getCube[i].LevelCube == _lvl)
            {
                _scriptableCube = _databaseObj._getCube[i];
                
            }
        }

        InstObjTwoByTwo();
        InstObjThreeByThree();
    }

    public void InstObjTwoByTwo()
    {
        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.LowerLeft) != 0)
        {
            GameObject boxLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.250f, 0.25f, _transformObj.position.z), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxLowerLeft);
            }
            else _cubeObjList.Add(boxLowerLeft);
        }

        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.UpperLeft) != 0)
        {
            GameObject boxUpperLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.250f, 0.751f, _transformObj.position.z), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxUpperLeft);
            }
            else _cubeObjList.Add(boxUpperLeft);
        }

        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.LowerRight) != 0)
        {
            GameObject boxLowerRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.250f, 0.25f, _transformObj.position.z), Quaternion.identity, _transformObj);

            if( _cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxLowerRight);
            }
            else _cubeObjList.Add(boxLowerRight);
        }

        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.UpperRight) != 0)
        {
            GameObject boxUpperRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.250f, 0.751f, _transformObj.position.z), Quaternion.identity, _transformObj);

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
            GameObject boxLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.501f,0.25f, _transformObj.position.z), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxLowerLeft);
            }
            else _cubeObjList.Add(boxLowerLeft);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.LowerCenter) != 0)
        {
            GameObject boxLowerCenter = Instantiate(_scriptableCube.CubePrefab, new Vector3(0f, 0.25f, _transformObj.position.z), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxLowerCenter);
            }
            else _cubeObjList.Add(boxLowerCenter);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.LowerRight) != 0)
        {
            GameObject boxLowerRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.501f, 0.25f, _transformObj.position.z), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxLowerRight);
            }
            else _cubeObjList.Add(boxLowerRight);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.MiddleLeft) != 0)
        {
            GameObject boxMiddleLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.501f, 0.751f, _transformObj.position.z), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxMiddleLeft);
            }
            else _cubeObjList.Add(boxMiddleLeft);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.MiddleCenter) != 0)
        {
            GameObject boxMiddleCenter = Instantiate(_scriptableCube.CubePrefab, new Vector3(0f, 0.751f, _transformObj.position.z), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxMiddleCenter);
            }
            else _cubeObjList.Add(boxMiddleCenter);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.MiddleRight) != 0)
        {
            GameObject boxMiddleRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.501f, 0.751f, _transformObj.position.z), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxMiddleRight);
            }
            else _cubeObjList.Add(boxMiddleRight);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.UpperLeft) != 0)
        {
            GameObject boxUpperLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.501f, 1.251f, _transformObj.position.z), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxUpperLeft);
            }
            else _cubeObjList.Add(boxUpperLeft);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.UpperCenter) != 0)
        {
            GameObject boxUpperCenter = Instantiate(_scriptableCube.CubePrefab, new Vector3(0f, 1.251f, _transformObj.position.z), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxUpperCenter);
            }
            else _cubeObjList.Add(boxUpperCenter);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.UpperRight) != 0)
        {
            GameObject boxUpperRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.501f, 1.251f, _transformObj.position.z), Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(boxUpperRight);
            }
            else _cubeObjList.Add(boxUpperRight);
        }
    }
}
