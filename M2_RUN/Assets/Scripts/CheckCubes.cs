using System.Collections.Generic;
using UnityEngine;

public class CheckCubes : MonoBehaviour
{
    [SerializeField] private MovementObj _movementObj;
    [SerializeField] private RoadGenerator _roadGenerator;
    [SerializeField] private SpawnObjManager _cube;
    [SerializeField] private SpawnObjManager _player;


    public void OnTriggerEnter(Collider other) 
    {
        List<int> _objList = new List<int>();
        _movementObj.StartStopMovment(_movementObj.maxSpeed = 0f);


        for (int i = 0; i < _player._playerObjList.Count; i++)
        {
            if (_cube._cubeObjList[i].GetComponent<Renderer>().sharedMaterial == _player._playerObjList[i].GetComponent<Renderer>().sharedMaterial)
            {
                _objList.Add(i);
            }
            _roadGenerator.StartStopMovament(_roadGenerator.maxSpeed = 0f);
            _movementObj.StartStopMovment(_movementObj.maxSpeed = 0f);
        }


        foreach (int i in _objList)
        {
            Destroy(_cube._cubeObjList[i]);
            Destroy(_player._playerObjList[i]);
        }
    }
}
