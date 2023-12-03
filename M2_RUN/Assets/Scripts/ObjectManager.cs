using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [SerializeField]private CubeDatabase _databaseObj;
    public int _lvl = 0;
    // Update is called once per frame
    void Update()
    {
        LevlCheck();
    }

    private ScriptableCube LevlCheck()
    {
        for (int i = 0; i < _databaseObj._getCube.Count; i++)
        {
            Debug.Log($"{_databaseObj._getCube[i]}");
            if(_databaseObj._getCube[i].LevelCube == _lvl)
            {
                return _databaseObj._getCube[i];     
            }
        }
        return null;
    }
}
//using UnityEngine;

//public class ObjectManager : MonoBehaviour
//{
//    [SerializeField] private CubeDatabase _databaseObj;
//    public int _lvl = 0;

//    // Update is called once per frame
//    void Update()
//    {
//        LevlCheck();
//    }

//    private ScriptableCube LevlCheck()
//    {
//        for (int i = 0; i < _databaseObj._getCube.Count; i++)
//        {
//            Debug.Log($"{_databaseObj._getCube[i]}");
//            if (_databaseObj._getCube[i].LevelCube == _lvl)
//            {
//                return _databaseObj._getCube[i];
//            }
//        }

//        // If no matching cube is found, return null after the loop
//        return null;
//    }
//}