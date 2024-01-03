using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public TMP_Text _counterText;
    [HideInInspector] public int pathCount = 0;

    public void IncrementCounter()
    {
        pathCount += 5;
        _counterText.text = pathCount.ToString();
    }
}
