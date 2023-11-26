using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Flags]
public enum CubeGeneration3
{
    UpperLeft = 1 << 0,
    UpperCenter = 1 << 1,
    UpperRight = 1 << 2,
    MiddleLeft = 1 << 3,
    MiddleCenter = 1 << 4,
    MiddleRight = 1 << 5,
    LowerLeft = 1 << 6,
    LowerCenter = 1 << 7,
    LowerRight = 1 << 8,
}


[CreateAssetMenu(fileName = "CubeGeneration", menuName = "Cube/NewCobe3")]
public class ScriptableCube3 : ScriptableObject
{
    public int LevelCube;
    public GameObject CubePrefab;


    public CubeGeneration3 VisualizeCube3;

    public Cube3 CreateCube()
    {
        Cube3 newCube = new Cube3(this);
        return newCube;
    }
}

[System.Serializable]
public class Cube3
{
    public int LevelCube;
    public GameObject CubeObject;

    public CubeGeneration3 VisualizeCube3;

    public Cube3(ScriptableCube3 cube)
    {
        LevelCube = cube.LevelCube;
        CubeObject = cube.CubePrefab;

        VisualizeCube3 = cube.VisualizeCube3;
    }
}

