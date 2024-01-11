using System.Collections.Generic;
using UnityEngine;

public class CheckCubes : MonoBehaviour
{
    [SerializeField] private MovementObj _movementObj;
    [SerializeField] private RoadGenerator _roadGenerator;
    [SerializeField] private WindowManager _windowManager;
    [SerializeField] private ParticleSystemController _particleSystemControllet;

    [SerializeField] private SpawnObjManager _cube;
    [SerializeField] private SpawnObjManager _player;


    public void OnTriggerEnter(Collider other) 
    {
        List<int> _objList = new List<int>();
        _movementObj.StartStopMovement(_movementObj.maxSpeed = 0f);


        for (int i = 0; i < _player._playerList.Count; i++)
        {
            if (_cube._cubeList[i].GetComponent<Renderer>().sharedMaterial == _player._playerList[i].GetComponent<Renderer>().sharedMaterial)
            {
                _objList.Add(i);
            }
            _roadGenerator.StartStopMovement(_roadGenerator.maxSpeed = 0f);
            _movementObj.StartStopMovement(_movementObj.maxSpeed = 0f);
        }

        Debug.Log($"{_objList.Count}");


        foreach (int i in _objList)
        {
            _particleSystemControllet.PlayParticleEffect(_cube._cubeList[i].transform.position, _cube._cubeList[i].GetComponent<Renderer>().sharedMaterial);
            Destroy(_cube._cubeList[i]);
            Destroy(_player._playerList[i]);
        }

        if (_player._playerList.Count != 0) // нужно подумать над проверкой и вероятно нужна будет карутина 
        {
            _windowManager.OpenRestartWindow();
        }
    }
}
