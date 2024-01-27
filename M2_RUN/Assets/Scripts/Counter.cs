using System.Collections;
using TMPro;
using UnityEngine;


public class Counter : MonoBehaviour
{
    [SerializeField] private GameObject _ui;
    [SerializeField] private TMP_Text _counterTextUI;
    [SerializeField] private TMP_Text _counterTextRestsrtWindow;

    [HideInInspector] public int pathCount = 0;

    private float delayInSeconds = 0.1f;


    IEnumerator ShowUIElementWithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);

        if (_ui.activeSelf == false)
        {

        }
    }

    public void IncrementCounter()
    {
        pathCount += 5;
        _counterTextUI.text = pathCount.ToString();
    }

    public void TransferText()
    {
        _counterTextUI.text = _counterTextRestsrtWindow.text;
        _counterTextRestsrtWindow.text = pathCount.ToString();
    }
}
