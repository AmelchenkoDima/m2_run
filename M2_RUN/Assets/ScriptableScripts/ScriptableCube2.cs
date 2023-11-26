using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Flags]
public enum CubeGeneration2
{
    UpperLeft = 1 << 0,
    UpperRight = 1 << 1,
    LowerLeft = 1 << 2,
    LowerRight = 1 << 3,
}

[CreateAssetMenu(fileName = "CubeGeneration", menuName = "Cube/NewCobe2")]
public class ScriptableCube2 : ScriptableObject
{
    public int LevelCube;
    public GameObject CubePrefab;


    public CubeGeneration2 VisualizeCube2;

    public Cube2 CreateCube()
    {
        Cube2 newCube = new Cube2(this);
        return newCube;
    }

    public void CubePositionGeneranor()
    {
        Vector3 cubePosition = Vector3.zero;
        switch (VisualizeCube2)
        {
            case CubeGeneration2.LowerLeft:
                cubePosition += new Vector3(-0.251f,0.25f,0f);
                GameObject cubeObject1 = Instantiate(CubePrefab, cubePosition, Quaternion.identity);
                break;
            case CubeGeneration2.LowerRight:
                cubePosition += new Vector3(0.251f, 0.25f, 0f);
                GameObject cubeObject2 = Instantiate(CubePrefab, cubePosition, Quaternion.identity);
                break;
            case CubeGeneration2.UpperLeft:
                cubePosition += new Vector3(-0.251f, 0.76f, 0f);
                GameObject cubeObject3 = Instantiate(CubePrefab, cubePosition, Quaternion.identity);
                break;

            case CubeGeneration2.UpperRight:
                cubePosition += new Vector3(0.251f, 0.76f, 0f);
                GameObject cubeObject4 = Instantiate(CubePrefab, cubePosition, Quaternion.identity);
                break;
        }
    }
}

[System.Serializable]
public class Cube2
{
    public int LevelCube;
    public GameObject CubeObject;

    public CubeGeneration2 VisualizeCube2;

    public Cube2(ScriptableCube2 cube)
    {
        LevelCube = cube.LevelCube;
        CubeObject = cube.CubePrefab;

        VisualizeCube2 = cube.VisualizeCube2;
    }
}

