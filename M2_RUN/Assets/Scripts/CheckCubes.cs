using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCubes : MonoBehaviour
{
    [SerializeField] private MovementObj _movementObj;
    [SerializeField] private RoadGenerator _roadGenerator;
    [SerializeField] private WindowManager _windowManager;
    [SerializeField] private Counter _counter;
    [SerializeField] private ParticleSystemController _particleSystemControllet;

    [SerializeField] private SpawnObjManager _cube;
    [SerializeField] private SpawnObjManager _player;

    private float delayInSeconds = 0.2f;


    IEnumerator ShowElementWithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);

        if (_player._transformObj.childCount == 0)
        {
            _player.UpLvl();
            _cube.UpLvl();
        }
        else
        {
            _counter.TransferText();
            _windowManager.OpenRestartWindow();
        }
    }


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

        foreach (int i in _objList)
        {
            _particleSystemControllet.PlayParticleEffect(_cube._cubeList[i].transform.position, _cube._cubeList[i].GetComponent<Renderer>().sharedMaterial);
            _particleSystemControllet.PlayParticleEffect(_player._playerList[i].transform.position, _player._playerList[i].GetComponent<Renderer>().sharedMaterial);

            Destroy(_cube._cubeList[i]);
            Destroy(_player._playerList[i]);
        }

        StartCoroutine(ShowElementWithDelay());
    }
}
