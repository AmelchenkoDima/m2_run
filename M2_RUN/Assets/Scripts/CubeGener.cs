using System.Collections.Generic;
using UnityEngine;

public class CubeGridGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private Vector3 _spawnPosition = Vector3.zero;
    [SerializeField] private List<Color> _colors = new List<Color> { Color.blue, Color.red, Color.green, Color.yellow };

    private int[][] visibility = new int[][]
    {
        new int[] { 1, 1, 1 },
        new int[] { 1, 0, 1 },
        new int[] { 1, 1, 1 }
    };

    private void Start()
    {
        GenerateBlocks();
    }

    private void GenerateBlocks()
    {
        for (int y = 0; y < visibility.Length; y++)
        {
            for (int x = 0; x < visibility[y].Length; x++)
            {
                if (visibility[y][x] == 1)
                {
                    Vector3 position = _spawnPosition + new Vector3(x, -y, 0);
                    GameObject newCube = Instantiate(_cubePrefab, position, Quaternion.identity, transform);

                    Renderer cubeRenderer = newCube.GetComponent<Renderer>();
                    cubeRenderer.material.color = _colors[Random.Range(0, _colors.Count)];
                }
            }
        }
    }
}
