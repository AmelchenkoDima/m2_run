using System.Collections.Generic;
using UnityEngine;

public class CheckCubes : MonoBehaviour
{
    public MovementObj _movementObj;
    public RoadGenerator _roadGenerator;
    public SpawnObjManager _spawnObj;
    public SpawnObjManager _spawnPlayer;


    private void Update()
    {
        LevelCheck();
    }

    private void LevelCheck()
    {
        //if (_spawnObj._transformObj.childCount == 0)
        //{
        //    _spawnObj._cubeObjList.Clear(); //лист _spawnObj._cubeObjList не очищатся. 
        //    Debug.Log("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        //}
        if (_spawnPlayer._transformObj.childCount == 0)
        {   
            _movementObj.ResetPosition();
            _roadGenerator.ResetSpeed();
            //_spawnPlayer._playerObjList.Clear();
        }
        Debug.Log($" _spawnPlayer {_spawnPlayer._playerObjList.Count}");
        Debug.Log($" _spawnObj {_spawnObj._cubeObjList.Count}");
    }

    public void OnTriggerEnter(Collider other) 
    {
        List<int> _objList = new List<int>();
        _movementObj._maxSpeed = 0f;

        for (int i = 0; i < _spawnPlayer._playerObjList.Count; i++)
        {
            if (_spawnObj._cubeObjList[i].GetComponent<Renderer>().sharedMaterial == _spawnPlayer._playerObjList[i].GetComponent<Renderer>().sharedMaterial)
            {
                _objList.Add(i);
            }
            _roadGenerator._maxSpeed = 0f;
            _movementObj._maxSpeed = 0f;
        }

        foreach (int i in _objList)
        {
            Destroy(_spawnObj._cubeObjList[i]);
            Destroy(_spawnPlayer._playerObjList[i]);
        }
    }
}
