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
    private ScriptableCube _scriptableCube;
    [HideInInspector] public List<GameObject> _objList = new List<GameObject>();
    [SerializeField] private Cube _cube;
    public int _lvl = 0;
   


    void Start()
    {
        LevelCheck();
        InstObjTwoByTwo();
        InstObjThreeByThree();
    }

    private void LevelCheck()
    {
        if(_cube == Cube.PlayerCube)
        {
            LevelCheckPlayerCube();
        }
        else LevelCheckCube();
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
            GameObject boxLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.250f, 0.25f, 0f), Quaternion.identity);
            boxLowerLeft.transform.SetParent(transform);
            _objList.Add(boxLowerLeft);
        }

        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.UpperLeft) != 0)
        {
            GameObject boxUpperLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.250f, 0.751f, 0f), Quaternion.identity);
            boxUpperLeft.transform.SetParent(transform);
            _objList.Add(boxUpperLeft);
        }

        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.LowerRight) != 0)
        {
            GameObject boxLowerRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.250f, 0.25f, 0f), Quaternion.identity);
            boxLowerRight.transform.SetParent(transform);
            _objList.Add(boxLowerRight);
        }

        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.UpperRight) != 0)
        {
            GameObject boxUpperRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.250f, 0.751f, 0f), Quaternion.identity);
            boxUpperRight.transform.SetParent(transform);
            _objList.Add(boxUpperRight);
        }
    }

    public void InstObjThreeByThree()
    {
        if((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.LowerLeft) != 0)
        {
            GameObject boxLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.501f,0.25f,0f), Quaternion.identity);
            boxLowerLeft.transform.SetParent(transform);
            _objList.Add(boxLowerLeft);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.LowerCenter) != 0)
        {
            GameObject boxLowerCenter = Instantiate(_scriptableCube.CubePrefab, new Vector3(0f, 0.25f, 0f), Quaternion.identity);
            boxLowerCenter.transform.SetParent(transform);
            _objList.Add(boxLowerCenter);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.LowerRight) != 0)
        {
            GameObject boxLowerRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.501f, 0.25f, 0f), Quaternion.identity);
            boxLowerRight.transform.SetParent(transform);
            _objList.Add(boxLowerRight);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.MiddleLeft) != 0)
        {
            GameObject boxMiddleLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.501f, 0.751f, 0f), Quaternion.identity);
            boxMiddleLeft.transform.SetParent(transform);
            _objList.Add(boxMiddleLeft);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.MiddleCenter) != 0)
        {
            GameObject boxMiddleCenter = Instantiate(_scriptableCube.CubePrefab, new Vector3(0f, 0.751f, 0f), Quaternion.identity);
            boxMiddleCenter.transform.SetParent(transform);
            _objList.Add(boxMiddleCenter);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.MiddleRight) != 0)
        {
            GameObject boxMiddleRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.501f, 0.751f, 0f), Quaternion.identity);
            boxMiddleRight.transform.SetParent(transform);
            _objList.Add(boxMiddleRight);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.UpperLeft) != 0)
        {
            GameObject boxUpperLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.501f, 1.251f, 0f), Quaternion.identity);
            boxUpperLeft.transform.SetParent(transform);
            _objList.Add(boxUpperLeft);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.UpperCenter) != 0)
        {
            GameObject boxUpperCenter = Instantiate(_scriptableCube.CubePrefab, new Vector3(0f, 1.251f, 0f), Quaternion.identity);
            boxUpperCenter.transform.SetParent(transform);
            _objList.Add(boxUpperCenter);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.UpperRight) != 0)
        {
            GameObject boxUpperRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.501f, 1.251f, 0f), Quaternion.identity);
            boxUpperRight.transform.SetParent(transform);
            _objList.Add(boxUpperRight);
        }
    }
}
