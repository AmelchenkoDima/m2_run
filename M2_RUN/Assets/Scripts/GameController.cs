
using UnityEngine;

public class GameController : MonoBehaviour
{ 
    [SerializeField] private RoadGenerator _roadGenerator;
    [SerializeField] private MovementObj _movementObj;
    [SerializeField] private SpawnObjManager _spawnObjManagerPlayer;
    [SerializeField] private SpawnObjManager _spawnObjManagerCube;


    void Start()
    {
        _movementObj.ResetMovment();
        _roadGenerator.ResetLevel();
        _spawnObjManagerPlayer.ResetLvl();
        _spawnObjManagerCube.ResetLvl();
    }
}
