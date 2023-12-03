using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [Flags]
    public enum CubeGeneration2
    {
        LowerLeft = 1 << 0,
        LowerRight = 1 << 1,
        UpperLeft = 1 << 2,
        UpperRight = 1 << 3,
    }
    //public bool UpperLeft = false;
    //public bool UpperRight = false;
    //public bool LowerLeft = false;
    //public bool LowerRight = false;

    public int LevelCube;
    public GameObject CubePrefab;
    
    private List<GameObject> _cubeList = new List<GameObject>();


    public CubeGeneration2 VisualizeCube2;

    // Start is called before the first frame update
    void Start()
    {
        
        CubePositionGeneranor();
        
    }

    public void CubePositionGeneranor()
    {
        if ((VisualizeCube2 & CubeGeneration2.LowerLeft) != 0)
        {
            GameObject cubeLowerLeft = Instantiate(CubePrefab, new Vector3(-0.250f, 0.25f, 0f), Quaternion.identity);
            _cubeList.Add(cubeLowerLeft);
        }

        if ((VisualizeCube2 & CubeGeneration2.UpperLeft) != 0)
        {
            GameObject cubeUpperLeft = Instantiate(CubePrefab, new Vector3(-0.250f, 0.76f, 0f), Quaternion.identity);
            _cubeList.Add(cubeUpperLeft);
        }

        if ((VisualizeCube2 & CubeGeneration2.LowerRight) != 0) 
        {
            GameObject cubeLowerRight = Instantiate(CubePrefab, new Vector3(0.250f, 0.25f, 0f), Quaternion.identity);
            _cubeList.Add(cubeLowerRight);
        }

        if ((VisualizeCube2 & CubeGeneration2.UpperRight) != 0) 
        {
            GameObject cubeUpperRight = Instantiate(CubePrefab, new Vector3(0.250f, 0.76f, 0f), Quaternion.identity);
            _cubeList.Add(cubeUpperRight);
        }

        //switch (VisualizeCube2)
        //{
        //    case CubeGeneration2.LowerLeft:

        //        GameObject cubeObject1 = Instantiate(CubePrefab, new Vector3(-0.251f, 0.25f, 0f), Quaternion.identity);
        //        break;
        //    case CubeGeneration2.LowerRight:
        //        GameObject cubeObject2 = Instantiate(CubePrefab, new Vector3(0.251f, 0.25f, 0f), Quaternion.identity);
        //        break;
        //    case CubeGeneration2.UpperLeft:
        //        GameObject cubeObject3 = Instantiate(CubePrefab, new Vector3(-0.251f, 0.76f, 0f), Quaternion.identity);
        //        break;

        //    case CubeGeneration2.UpperRight:
        //        GameObject cubeObject4 = Instantiate(CubePrefab, new Vector3(0.251f, 0.76f, 0f), Quaternion.identity);
        //        break;
        //}
    }
}
