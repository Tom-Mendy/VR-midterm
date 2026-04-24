using UnityEngine;
using TMPro;

public class DisplayBoxCounter : MonoBehaviour
{
    TMP_Text boxCounter;

    private void Start()
    {
        boxCounter = GetComponent<TMP_Text>();
    }

    public void UpdateBoxCounter(int count)
    {
        boxCounter.text = $"Boxes: {count}";
    }

}
