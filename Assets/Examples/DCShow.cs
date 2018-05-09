using System.Collections.Generic;
using UnityEngine;

public class DCShow : MonoBehaviour
{


    List<Hud> list = new List<Hud>();

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            var hud = new Hud("赵子龙" + i, i/10f);
            hud.name = "item" + i;
            hud.transform.position = new Vector3(0, -4 + i, i / 10f);
            list.Add(hud);
        }
    }

}
