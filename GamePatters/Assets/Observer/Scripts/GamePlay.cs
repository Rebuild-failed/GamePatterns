using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventFactor.Notify(EventType.Refresh_Text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
