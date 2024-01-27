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
    [SerializeField] private ParticleSystemController _particleSystemControllet;
    
    [HideInInspector] public List<GameObject> _cubeList = new List<GameObject>();
    [HideInInspector] public List<GameObject> _playerList = new List<GameObject>();

    [HideInInspector] public int lvl = 0;

    public Transform _transformObj;

    private ScriptableCube _scriptableCube;


    public void UpLvl()
    {
        if (_transformObj.childCount == 0)
        {
            lvl += 1;

            if (_cube == Cube.PlayerCube)
            {
                _playerList.Clear();
            }
            else
            {
                _cubeList.Clear();
            }

            CheckEnumCube();

            _movementObj.ResetPosition();
            _roadGenerator.ResetSpeed();
        }
    }


    public void ResetLvl()
    {
        while (_transformObj.childCount > 0)
        {
            Destroy(_transformObj.GetChild(0));
            if (_cube == Cube.PlayerCube)
            {
                _playerList.RemoveAt(0);
            }
            else
            {
                _cubeList.RemoveAt(0);
            }
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
        GenerateFigureToo(_scriptableCube.VisualTwoByTwo, CubeGenTwoByTwo.LowerLeft, new Vector3(-0.180f, 0.18f, _transformObj.position.z));
        GenerateFigureToo(_scriptableCube.VisualTwoByTwo, CubeGenTwoByTwo.UpperLeft, new Vector3(-0.180f, 0.540f, _transformObj.position.z));
        GenerateFigureToo(_scriptableCube.VisualTwoByTwo, CubeGenTwoByTwo.LowerRight, new Vector3(0.180f, 0.18f, _transformObj.position.z));
        GenerateFigureToo(_scriptableCube.VisualTwoByTwo, CubeGenTwoByTwo.UpperRight, new Vector3(0.180f, 0.540f, _transformObj.position.z));
    }


    private void InstObjThreeByThree()
    {
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.LowerLeft, new Vector3(-0.360f, 0.18f, _transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.LowerCenter, new Vector3(0f, 0.18f, _transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.LowerRight, new Vector3(0.360f, 0.18f, _transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.MiddleLeft, new Vector3(-0.360f, 0.540f, _transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.MiddleCenter, new Vector3(0f, 0.540f, _transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.MiddleRight, new Vector3(0.360f, 0.540f, _transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.UpperLeft, new Vector3(-0.360f, 0.900f, _transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.UpperCenter, new Vector3(0f, 0.900f, _transformObj.position.z));
        GenerateFigureThree(_scriptableCube.VisualThreeByThree, CubeGenThreeByThree.UpperRight, new Vector3(0.360f, 0.900f, _transformObj.position.z));
    }


    private void GenerateFigureToo(CubeGenTwoByTwo scriptableVisualFigure, CubeGenTwoByTwo visualPositionFigure, Vector3 pos)
    {
        if ((scriptableVisualFigure & visualPositionFigure) != 0)
        {
            GameObject cube = Instantiate(_scriptableCube.CubePrefab, pos, Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerList.Add(cube);
            }
            else
            {
                _cubeList.Add(cube);
            }
        }
    }

    private void GenerateFigureThree(CubeGenThreeByThree scriptableVisualFigure, CubeGenThreeByThree visualPositionFigure, Vector3 pos)
    {
        if ((scriptableVisualFigure & visualPositionFigure) != 0)
        {
            GameObject cube = Instantiate(_scriptableCube.CubePrefab, pos, Quaternion.identity, _transformObj);

            if (_cube == Cube.PlayerCube)
            {
                _playerList.Add(cube);
            }
            else
            {
                _cubeList.Add(cube);
            }
        }
    }
}
