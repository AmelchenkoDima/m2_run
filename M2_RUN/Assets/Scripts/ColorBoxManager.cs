
using UnityEngine;


public class ColorBoxManager : MonoBehaviour
{
    public enum Cube // Выбор для определения типа префаба 
    {
        PlayerCube = 0,
        Cube = 1,
    }


    public enum ColorBox // Выбор цвета материала 
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        Yellow = 3,
    }

    private int _colorNumBox;

    [SerializeField] private Cube _cube;
    [SerializeField] private ColorBox _colorBox;

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
        switch (_colorBox) // Присвоение материала префабу 
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

    private void RandomColorBox() // Рандомная генерация цвета 
    {
        _colorNumBox = Random.Range(0, 4);
        _colorBox = (ColorBox)_colorNumBox;
    }
    

    private void OnMouseDown() // Смена цвета по клику с проверкой типа префаба 
    {   if(_cube == Cube.PlayerCube)
        {
            _colorNumBox += 1;
            if (_colorNumBox == 4)
            {
                _colorNumBox = 0;
            }
            _colorBox = (ColorBox)_colorNumBox;
        }
    }

}
