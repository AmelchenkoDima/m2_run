using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour
{
    [Flags]
    public enum CubeGeneration2
    {
        UpperLeft = 1 << 0,
        UpperRight = 1 << 1,
        LowerLeft = 1 << 2,
        LowerRight = 1 << 3,
    }
    public bool UpperLeft = false;
    public bool UpperRight = false;
    public bool LowerLeft = false;
    public bool LowerRight = false;

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

        //Vector3 cubePosition = Vector3.zero;
        if (LowerLeft == true)//VisualizeCube2 == CubeGeneration2.LowerLeft)
        {
            //cubePosition += new Vector3(-0.251f, 0.25f, 0f);
            GameObject cubeLowerLeft = Instantiate(CubePrefab, new Vector3(-0.250f, 0.25f, 0f), Quaternion.identity);
            _cubeList.Add(cubeLowerLeft);
        }
        if (LowerRight == true)//VisualizeCube2 == CubeGeneration2.LowerRight) 
        {
            //cubePosition += new Vector3(0.251f, 0.25f, 0f);
            GameObject cubeLowerRight = Instantiate(CubePrefab, new Vector3(0.250f, 0.25f, 0f), Quaternion.identity);
            _cubeList.Add(cubeLowerRight);
        }
        if (UpperLeft == true)//VisualizeCube2 == CubeGeneration2.UpperLeft)
        {
            //cubePosition += new Vector3(-0.251f, 0.76f, 0f);
            GameObject cubeUpperLeft = Instantiate(CubePrefab, new Vector3(-0.250f, 0.76f, 0f), Quaternion.identity);
            _cubeList.Add(cubeUpperLeft);
        }
        if (UpperRight == true)//VisualizeCube2 == CubeGeneration2.UpperRight) 
        {
            //cubePosition += new Vector3(0.251f, 0.76f, 0f);
            GameObject cubeUpperRight = Instantiate(CubePrefab, new Vector3(0.250f, 0.76f, 0f), Quaternion.identity);
            _cubeList.Add(cubeUpperRight);
        }

        //switch (VisualizeCube2)
        //{
        //    case CubeGeneration2.LowerLeft:
        //        cubePosition += new Vector3(-0.251f, 0.25f, 0f);
        //        GameObject cubeObject1 = Instantiate(CubePrefab, cubePosition, Quaternion.identity);
        //        break;
        //    case CubeGeneration2.LowerRight:
        //        cubePosition += new Vector3(0.251f, 0.25f, 0f);
        //        GameObject cubeObject2 = Instantiate(CubePrefab, cubePosition, Quaternion.identity);
        //        break;
        //    case CubeGeneration2.UpperLeft:
        //        cubePosition += new Vector3(-0.251f, 0.76f, 0f);
        //        GameObject cubeObject3 = Instantiate(CubePrefab, cubePosition, Quaternion.identity);
        //        break;

        //    case CubeGeneration2.UpperRight:
        //        cubePosition += new Vector3(0.251f, 0.76f, 0f);
        //        GameObject cubeObject4 = Instantiate(CubePrefab, cubePosition, Quaternion.identity);
        //        break;
        //}
    }
}
