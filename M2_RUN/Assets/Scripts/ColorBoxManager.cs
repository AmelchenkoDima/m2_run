
using UnityEngine;


public class ColorBoxManager : MonoBehaviour
{
    public enum Cube
    {
        PlayerCube = 0,
        Cube = 1,
    }


    public enum ColorBox
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        Yellow = 3,
    }

    private int _colorNumBox;

    [SerializeField] private Cube _cube;
    [SerializeField] private ColorBox _colorBox;

    [SerializeField] private Material _redMaterial;
    [SerializeField] private Material _greenMaterial;
    [SerializeField] private Material _blueMaterial;
    [SerializeField] private Material _yellowMaterial;


    private void Start()
    {
        RandomColorBox();
    }


    private void AssignmentColor()
    {
        switch (_colorBox)
        {
            case ColorBox.Red:
                gameObject.GetComponent<Renderer>().material = _redMaterial;
                break;

            case ColorBox.Green:
                gameObject.GetComponent<Renderer>().material = _greenMaterial;
                break;

            case ColorBox.Blue:
                gameObject.GetComponent<Renderer>().material = _blueMaterial;
                break;

            case ColorBox.Yellow:
                gameObject.GetComponent<Renderer>().material = _yellowMaterial;
                break;
        }
    }


    public void RandomColorBox()
    {
        _colorNumBox = Random.Range(0, 4);
        _colorBox = (ColorBox)_colorNumBox;

        AssignmentColor();
    }


    private void OnMouseDown()
    {   if(_cube == Cube.PlayerCube)
        {
            _colorNumBox += 1;
            if (_colorNumBox == 4)
            {
                _colorNumBox = 0;
            }
            _colorBox = (ColorBox)_colorNumBox;

            AssignmentColor();
        }
    }

}
