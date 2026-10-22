using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DirtyWorks.Tools
{
    public class UniversialTester : MonoBehaviour
    {
#if UNITY_EDITOR
        public List<UEventTest> ueventList;
#endif
    }

    [System.Serializable]
    public class UEventTest
    {
#if UNITY_EDITOR
        public string name = "Test";
        public UEvent testEvent;
        public void InvokeEvents() => testEvent.unityEvent.Invoke();
#endif
    }

    [System.Serializable]
    public class UEvent
    {
#if UNITY_EDITOR
        public UnityEvent unityEvent;
#endif
    }
}
