using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Awake()
    {
        EventFactor.AddListener(EventType.Refresh_Text, RefreshText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDisable()
    {
        EventFactor.RemoveListener(EventType.Refresh_Text, RefreshText);
    }
    void RefreshText()
    {
        text.text = "任务完成";
    }
}
