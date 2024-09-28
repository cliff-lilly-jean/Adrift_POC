using UnityEngine;
using System.Collections;

public class Blink : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float seconds;
    public float toggle;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        StartBlinking(seconds, toggle); // Blink for 5 seconds, toggling every 0.5 seconds
    }

    private IEnumerator BlinkerCoroutine(float blinkerTime, float blinkInterval)
    {
        float elapsedTime = 0f;

        while (elapsedTime < blinkerTime)
        {
            // Toggle the alpha channel between 0 and 1
            Color color = spriteRenderer.color;
            color.a = (color.a == 0) ? 1 : 0; // Toggle alpha
            spriteRenderer.color = color;

            Debug.Log("Blink!");

            // Wait for the blink interval
            yield return new WaitForSeconds(blinkInterval);

            elapsedTime += blinkInterval; // Increment elapsed time
        }

        // Reset alpha to fully visible after blinking
        Color finalColor = spriteRenderer.color;
        finalColor.a = 1;
        spriteRenderer.color = finalColor;

        Debug.Log("Blinking done");
    }

    // Call this method to start blinking
    public void StartBlinking(float duration, float interval)
    {
        StartCoroutine(BlinkerCoroutine(duration, interval));
    }



}
