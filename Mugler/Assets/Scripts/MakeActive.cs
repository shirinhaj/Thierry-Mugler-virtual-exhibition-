using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeActive : MonoBehaviour
{
    public GameObject PanelGameObj;

    // Start is called before the first frame update

    public void Open()
    {
        PanelGameObj.SetActive(true);
    }

    public void Close()
    {
        PanelGameObj.SetActive(false);
    }

}
