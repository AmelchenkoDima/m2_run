
using System;
using System.Collections.Generic;
using UnityEngine;

public class CheckCubes : MonoBehaviour
{
    public MovementObj _movementObj;
    public RoadGenerator _roadGenerator;
    public SpawnObjManager _spawnObj;
    public SpawnObjManager _spawnPlayer;
    private SpawnObjManager _spawnObjManager;


    void Start()
    {
        _spawnObjManager = GetComponent<SpawnObjManager>();
    }

    // Update is called once per frame
    private void Update()
    {
        LevelCheck();
    }

    private void LevelCheck()
    {
        if (_spawnObj._cubeObjList.Count == 0)
        {
            //_spawnObjManager._lvl += 1;
            Debug.Log($"{_spawnObj._cubeObjList.Count}");
            Debug.Log($"{_spawnObjManager._lvl}");
        }
        Debug.Log($"{_spawnObj._cubeObjList.Count}");
    }

    public void OnTriggerEnter(Collider other) //листы _spawnObj._cubeObjList и _spawnPlayer._playerObjList не очищаются. 
    {
        List<int> _objList = new List<int>();
        _movementObj._maxSpeed = 0f;

        for (int i = 0; i < _spawnObj._cubeObjList.Count; i++)
        {
            if (_spawnObj._cubeObjList[i].GetComponent<Renderer>().sharedMaterial == _spawnPlayer._playerObjList[i].GetComponent<Renderer>().sharedMaterial)
            {
                _objList.Add(i);
            }
            else _roadGenerator._maxSpeed = 0f;
        }

        foreach (int i in _objList)
        {
            Destroy(_spawnObj._cubeObjList[i]);
            Destroy(_spawnPlayer._playerObjList[i]);
        }

       
    }
}
