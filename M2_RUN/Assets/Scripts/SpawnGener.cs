using UnityEngine;

public class SpawnGener : MonoBehaviour
{

    [HideInInspector] public ScriptableCube _scriptableCube;

    void Start()
    {
        InstObjTwoByTwo();
        InstObjThreeByThree();
    }

    private void InstObjTwoByTwo()
    {
        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.LowerLeft) != 0)
        {
            GameObject cubeLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.250f, 0.25f, 0f), Quaternion.identity);
        }

        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.UpperLeft) != 0)
        {
            GameObject cubeUpperLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.250f, 0.76f, 0f), Quaternion.identity);
        }

        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.LowerRight) != 0)
        {
            GameObject cubeLowerRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.250f, 0.25f, 0f), Quaternion.identity);
        }

        if ((_scriptableCube.VisualTwoByTwo & CubeGenTwoByTwo.UpperRight) != 0)
        {
            GameObject cubeUpperRight = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.250f, 0.76f, 0f), Quaternion.identity);
        }
    }

    private void InstObjThreeByThree()
    {
        if((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.LowerLeft) != 0)
        {
            GameObject cubeLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.501f,0.25f,0f), Quaternion.identity);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.LowerCenter) != 0)
        {
            GameObject cubeLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(0f, 0.25f, 0f), Quaternion.identity);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.LowerRight) != 0)
        {
            GameObject cubeLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.501f, 0.25f, 0f), Quaternion.identity);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.MiddleLeft) != 0)
        {
            GameObject cubeLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.501f, 0.751f, 0f), Quaternion.identity);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.MiddleCenter) != 0)
        {
            GameObject cubeLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(0f, 0.751f, 0f), Quaternion.identity);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.MiddleRight) != 0)
        {
            GameObject cubeLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.501f, 0.751f, 0f), Quaternion.identity);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.UpperLeft) != 0)
        {
            GameObject cubeLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(-0.501f, 1.251f, 0f), Quaternion.identity);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.UpperCenter) != 0)
        {
            GameObject cubeLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(0f, 1.251f, 0f), Quaternion.identity);
        }

        if ((_scriptableCube.VisualThreeByThree & CubeGenThreeByThree.UpperRight) != 0)
        {
            GameObject cubeLowerLeft = Instantiate(_scriptableCube.CubePrefab, new Vector3(0.501f, 1.251f, 0f), Quaternion.identity);
        }
    }
}
