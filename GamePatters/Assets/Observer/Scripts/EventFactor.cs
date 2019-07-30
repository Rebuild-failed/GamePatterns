using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EventType
{
    Refresh_Text
}
public delegate void EventDelegate();
public class EventFactor : MonoBehaviour
{
    private static Dictionary<EventType, EventDelegate> eventCenter = new Dictionary<EventType, EventDelegate>();

    public static void AddListener(EventType eventType, EventDelegate eventDelegate)
    {
        if(eventCenter.ContainsKey(eventType))
        {
            eventCenter[eventType] += eventDelegate;
        }
        else
        {
            eventCenter.Add(eventType, eventDelegate);
        }
        
    }
    public static void RemoveListener(EventType eventType, EventDelegate eventDelegate)
    {
        if (eventCenter.ContainsKey(eventType))
        {
            eventCenter[eventType] -= eventDelegate;
        }
    }
    public static void Notify(EventType eventType)
    {
        EventDelegate eventDelegate;
        if (eventCenter.TryGetValue(eventType, out eventDelegate))
        {
            eventDelegate();
        }
    }
}
