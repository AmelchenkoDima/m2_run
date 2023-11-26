using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CubeGeneration", menuName = "Cube/Datadase")]
public class CubeDatabase2 : ScriptableObject, ISerializationCallbackReceiver
{
    public ScriptableCube2[] CubeBase2;
    public List<ScriptableCube2> GetCube2;

    //public ScriptableCube3[] CubeBase3;
    //public List<ScriptableCube3> GetCube3;
    public void OnAfterDeserialize()
    {
        GetCube2 = new List<ScriptableCube2>();
        //GetCube3 = new List<ScriptableCube3>();
    }

    public void OnBeforeSerialize()
    {
        for (int i = 0; i < CubeBase2.Length; i++)
        {
            GetCube2.Add(CubeBase2[i]);   
        }

            //for (int i = 0; i < CubeBase3.Length; i++)
        //{
            //GetCube3.Add(CubeBase3[i]);
            //if (i == CubeBase3.Length) return;
        //}
    }
}
