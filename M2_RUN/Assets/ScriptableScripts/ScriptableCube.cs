using System;
using UnityEngine;

[Flags]
public enum CubeGenTwoByTwo
{
    LowerLeft = 1 << 0,
    LowerRight = 1 << 1,
    UpperLeft = 1 << 2,
    UpperRight = 1 << 3,
}

[Flags]
public enum CubeGenThreeByThree
{
    LowerLeft = 1 << 0,
    LowerCenter = 1 << 1,
    LowerRight = 1 << 2,
    MiddleLeft = 1 << 3,
    MiddleCenter = 1 << 4,
    MiddleRight = 1 << 5,
    UpperLeft = 1 << 6,
    UpperCenter = 1 << 7,
    UpperRight = 1 << 8,
}

[CreateAssetMenu(fileName = "CubeGeneration", menuName = "Cube/NewCube")]
public class ScriptableCube : ScriptableObject
{
    [SerializeField] private int _levelCube;
    [SerializeField] private GameObject _cubePrefab;

    [SerializeField] private CubeGenTwoByTwo _visualCubeTwoByTwo;
    [SerializeField] private CubeGenThreeByThree _visualCubeThreeByThree;

    public int LevelCube => _levelCube;
    public GameObject CubePrefab => _cubePrefab;
    public CubeGenTwoByTwo VisualTwoByTwo => _visualCubeTwoByTwo;
    public CubeGenThreeByThree VisualThreeByThree => _visualCubeThreeByThree;
}

