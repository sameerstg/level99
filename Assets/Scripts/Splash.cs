using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Splash : MonoBehaviour
{
    public float time = 8f;
    public UnityEvent callback;
    public void OnEnable()
    {
        StartCoroutine(Routine());
    }
    public IEnumerator Routine()
    {
        yield return new WaitForSeconds(time);
        callback?.Invoke();
    }
}
