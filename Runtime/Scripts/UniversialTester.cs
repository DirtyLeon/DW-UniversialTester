using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DirtyWorks.Tools
{
    #if UNITY_EDITOR
    public class UniversialTester : MonoBehaviour
    {
        public List<UEventTest> ueventList;
    }

    [System.Serializable]
    public class UEventTest
    {
        public string name = "Test";
        public UEvent testEvent;
        public void InvokeEvents() => testEvent.unityEvent.Invoke();
    }

    [System.Serializable]
    public class UEvent
    {
        public UnityEvent unityEvent;
    }
    #endif
}
