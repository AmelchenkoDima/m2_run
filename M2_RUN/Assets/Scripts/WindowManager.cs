using Unity.VisualScripting;
using UnityEngine;


public class WindowManager : MonoBehaviour
{
    [SerializeField] private GameObject _ui;
    [SerializeField] private GameObject _restartWindow;
    [SerializeField] private GameObject _settingsWindow;

    [SerializeField] private RoadGenerator _roadGenerator;
    [SerializeField] private MovementObj _movementObj;



    public void OpenRestartWindow()
    {
        _ui.SetActive(false);
        _restartWindow.SetActive(true);
    }


    public void OpenSettingsWindowGameScene()
    {
        _ui.SetActive(false);
        _settingsWindow.SetActive(true);  

        _movementObj.StartStopMovement(_movementObj.maxSpeed = 0f);

        _roadGenerator.StartStopMovement(_roadGenerator.maxSpeed = 0f);

    }


    public void ÑloseSettingsWindowGameScene()
    {
        _ui.SetActive(true);
        
        _settingsWindow.SetActive(false);

        _movementObj.ResetSpeed();

        _roadGenerator.ResetSpeed();
    }


    public void OpenSettingsWindowMainScene()
    {
        _settingsWindow.SetActive(true);
        _ui.SetActive(false);

    }


    public void ÑloseSettingsWindowMainScene()
    {
        _ui.SetActive(true);
        _settingsWindow.SetActive(false);

    }
}
