using UnityEngine;

public class BoxDetection : MonoBehaviour
{
    int counter = 0;
    [SerializeField] DisplayBoxCounter displayBoxCounter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            counter++;
            displayBoxCounter.UpdateBoxCounter(counter);
        }
    }
     private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            counter--;
            displayBoxCounter.UpdateBoxCounter(counter);
        }
    }
  
}
