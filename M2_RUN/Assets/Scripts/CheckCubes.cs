
using System.Collections.Generic;
using UnityEngine;

public class CheckCubes : MonoBehaviour
{
    //[SerializeField] private GameObject _playerGameObject;
    //[SerializeField] private GameObject _cubeGameObject;
    //[SerializeField] private BoxCollider _boxCollider;
    public MovementObj _movementObj;
    public RoadGenerator _roadGenerator;
    public SpawnObjManager _spawnObj;
    public SpawnObjManager _spawnPlayer;


    void Start()
    {   
        
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(_movementObj._maxSpeed);
    }

    public void OnTriggerEnter(Collider other)
    {
        _movementObj._maxSpeed = 3f;

        List<GameObject> objectsToRemove = new List<GameObject>();

        foreach (GameObject box in _spawnObj._cubeObjList)
        {
            foreach (GameObject boxPlayer in _spawnPlayer._playerObjList)
            {
                if (boxPlayer.GetComponent<Renderer>().material == box.GetComponent<Renderer>().material)
                {
                    //objectsToRemove.Add(box);
                    //objectsToRemove.Add(boxPlayer);
                    Debug.Log($"Player: {boxPlayer.GetComponent<Renderer>().material}");
                    Debug.Log($"Cube: {box.GetComponent<Renderer>().material}");
                }
            }
        }

        foreach (GameObject obj in objectsToRemove)
        {
            _spawnObj._cubeObjList.Remove(obj);
            _spawnPlayer._playerObjList.Remove(obj);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        _movementObj._maxSpeed = 0f;
        _roadGenerator._maxSpeed = 0f;
    }
}
