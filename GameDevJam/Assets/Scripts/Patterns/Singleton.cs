using UnityEngine;
using System.Collections;


namespace Patterns {
    public class Singleton<T> : MonoBehaviour where T : Component {
        private static T _instance;

        public static T Instance {
            get {
                //Check
                if (_instance == null) {
                    //Checks to see if there is already an instantiation of specific singleton.
                    var objs = FindObjectsOfType(typeof(T)) as T[];
                    if (objs.Length > 0)
                        _instance = objs[0];
                    if (objs.Length > 1)
                    {
                        Debug.Log("There is more than one " + typeof(T).Name + " in the scene.");
                    }
                    //Creates instance if none exists.
                    if (_instance == null)
                    {
                        GameObject obj = new GameObject();
                        obj.hideFlags = HideFlags.HideAndDontSave;
                        _instance = obj.AddComponent<T>();
                    }
                }

                return _instance;
            }
        }
    }

    /// <summary>
    /// USE WHEN SINGLETON NEEDS TO PERSIST THROUGH LEVEL LOADS
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingletonPersistent<T> : MonoBehaviour
        where T : Component
    {
        public static T Instance { get; private set; }

        public virtual void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}