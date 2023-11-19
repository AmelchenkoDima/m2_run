using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorBoxGenerator : MonoBehaviour
{
    public enum ColorBox
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        Yellow = 3,
    }

    public ColorBox _colorBox;
    [HideInInspector]public int _colorNumBox;

    [SerializeField] private Material _RedMaterial;
    [SerializeField] private Material _GreenMaterial;
    [SerializeField] private Material _BlueMaterial;
    [SerializeField] private Material _YellowMaterial;


    // Start is called before the first frame update
    void Start()
    {
        RandomColorBox();
    }

    // Update is called once per frame
    void Update()
    {
        switch (_colorBox)
        {
            case ColorBox.Red:
                gameObject.GetComponent<Renderer>().material = _RedMaterial;
                break;

            case ColorBox.Green:
                gameObject.GetComponent<Renderer>().material = _GreenMaterial;
                break;

            case ColorBox.Blue:
                gameObject.GetComponent<Renderer>().material = _BlueMaterial;
                break;

            case ColorBox.Yellow:
                gameObject.GetComponent<Renderer>().material = _YellowMaterial;
                break;
        }
    }

    private void RandomColorBox()
    {
        _colorNumBox = Random.Range(0, 4);
        _colorBox = (ColorBox)_colorNumBox;
    }
}
