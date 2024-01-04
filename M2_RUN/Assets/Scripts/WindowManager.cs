using System.Collections;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    [SerializeField] private GameObject _ui;
    [SerializeField] private GameObject _restartWindow;
    private GameObject _settingsWindow;

    [SerializeField] private RoadGenerator _roadGenerator;
    [SerializeField] private MovementObj _movementObj;


    public void OpenRestartWindow()
    {
        _ui.SetActive(false);
        _restartWindow.SetActive(true);
    }


    public void OpenSettingsWindow()
    {
        _ui.SetActive(false);
        _settingsWindow.SetActive(true);

        _movementObj.maxSpeed = 0;
        _movementObj.ResetSpeed();

        _roadGenerator.maxSpeed = 0;
        _roadGenerator.ResetSpeed();
    }


    public void ÑloseSettingsWindow()
    {
        _ui.SetActive(true);
        _settingsWindow.SetActive(false);

        _movementObj.maxSpeed = 0;
        _movementObj.ResetSpeed();

        _roadGenerator.maxSpeed = 10;
        _roadGenerator.ResetSpeed();
    }
}
