using System.Collections.Generic;
using UnityEngine;


public class SpawnObjManager : MonoBehaviour
{
    public enum Cube
    {
        PlayerCube = 0,
        Cube = 1,
    }

    [SerializeField] private CubeDatabase _databaseObj;
    [SerializeField] private Cube _cube;
    [SerializeField] private MovementObj _movementObj;
    [SerializeField] private RoadGenerator _roadGenerator;

    [HideInInspector] public List<GameObject> _cubeObjList = new List<GameObject>();
    [HideInInspector] public List<GameObject> _playerObjList = new List<GameObject>();

    public Transform transformObj;
    public int lvl = 0;

    private ScriptableCube _scriptableCube;


    void Update()
    {
        if (transformObj.childCount == 0)
        {
            lvl += 1;
            _cubeObjList.Clear();
            _playerObjList.Clear();
            CheckEnumCube();
            _movementObj.ResetPosition();
            _roadGenerator.ResetSpeed();
        }
    }


    public void ResetLvl()
    {
        while (transformObj.childCount > 0)
        {
            Destroy(transformObj.GetChild(0));
            _cubeObjList.RemoveAt(0);
            _playerObjList.RemoveAt(0);
        }
        lvl += 1;
        CheckEnumCube();
    }


    private void CheckEnumCube()
    {
        if (_cube == Cube.PlayerCube)
        {
            LevelCheckPlayerCube();
        }
        else
        {
            LevelCheckCube();
        }

    }


    private void LevelCheckPlayerCube()
    {
        for (int i = 0; i < _databaseObj._playerGetCube.Count; i++)
        {
            if (_databaseObj._playerGetCube[i].LevelCube == lvl)
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
            if (_databaseObj._getCube[i].LevelCube == lvl)
            {
                _scriptableCube = _databaseObj._getCube[i];   
            }
        }

        InstObjTwoByTwo();
        InstObjThreeByThree();
    }


    private void InstObjTwoByTwo()
    {
        GenerateFigureToo(_scriptableCube.VisualTwoByTwo, CubeGenTwoByTwo.LowerLeft, new Vector3(-0.250f, 0.25f, transformObj.position.z));
        GenerateFigureToo(_scriptableCube.VisualTwoByTwo, CubeGenTwoByTwo.UpperLeft, new Vector3(-0.250f, 0.751f, transformObj.position.z));
        GenerateFigureToo(_scriptableCube.VisualTwoByTwo, CubeGenTwoByTwo.LowerRight, new Vector3(0.250f, 0.25f, transformObj.position.z));
        GenerateFigureToo(_scriptableCube.VisualTwoByTwo, CubeGenTwoByTwo.UpperRight, new Vector3(0.250f, 0.751f, transformObj.position.z));
    }


    private void InstObjThreeByThree()
    {
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.LowerLeft, new Vector3(-0.501f, 0.25f, transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.LowerCenter, new Vector3(0f, 0.25f, transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.LowerRight, new Vector3(0.501f, 0.25f, transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.MiddleLeft, new Vector3(-0.501f, 0.751f, transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.MiddleCenter, new Vector3(0f, 0.751f, transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.MiddleRight, new Vector3(0.501f, 0.751f, transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.UpperLeft, new Vector3(-0.501f, 1.251f, transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.UpperCenter, new Vector3(0f, 1.251f, transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.UpperRight, new Vector3(0.501f, 1.251f, transformObj.position.z));
    }


    private void GenerateFigureToo(CubeGenTwoByTwo scriptableVisualFigure, CubeGenTwoByTwo visualPositionFigure, Vector3 pos)
    {
        if ((scriptableVisualFigure & visualPositionFigure) != 0)
        {
            GameObject cube = Instantiate(_scriptableCube.CubePrefab, pos, Quaternion.identity, transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(cube);
            }
            else
            {
                _cubeObjList.Add(cube);
            }
        }
    }

    private void GenerateFigureThree(CubeGenThreeByThree scriptableVisualFigure, CubeGenThreeByThree visualPositionFigure, Vector3 pos)
    {
        if ((scriptableVisualFigure & visualPositionFigure) != 0)
        {
            GameObject cube = Instantiate(_scriptableCube.CubePrefab, pos, Quaternion.identity, transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerObjList.Add(cube);
            }
            else
            {
                _cubeObjList.Add(cube);
            }
        }
    }
}
