using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoText : MonoBehaviour
{
    public List<TextInfos<string,int>> t = new List<TextInfos<string, int>>();


}
[System.Serializable] 
public class TextInfos<T,K>
{
    //public string name = T.ToString();
}