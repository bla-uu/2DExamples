using System.Collections;
using UnityEngine;

public class Toaster : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Message with a GameObject name.
        Debug.Log("Press lever");
        StartCoroutine(ToastCoroutine());
    }

    IEnumerator ToastCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Toasting at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Popped at timestamp : " + Time.time);
    }
}
