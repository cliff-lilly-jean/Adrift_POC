using UnityEngine;
using System.Collections;

public class Flicker : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public float secondsBetweenFlicker; // Total time to flicker
    public float flickerRate; // Duration of each flicker

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Call this method to start flickering
    public void StartFlickering(float duration, float interval)
    {
        secondsBetweenFlicker = duration;
        flickerRate = interval;
        StartCoroutine(FlickerCoroutine());
    }

    private IEnumerator FlickerCoroutine()
    {
        float elapsedTime = 0f;

        while (elapsedTime < secondsBetweenFlicker)
        {
            // Toggle the alpha channel
            Color color = spriteRenderer.color;
            color.a = (color.a == 0) ? 1 : 0; // Toggle alpha
            spriteRenderer.color = color;

            // Wait for the blink interval
            yield return new WaitForSeconds(flickerRate);

            elapsedTime += flickerRate; // Increment elapsed time
        }

        // Reset alpha to fully visible after blinking
        Color finalColor = spriteRenderer.color;
        finalColor.a = 1;
        spriteRenderer.color = finalColor;
    }
}
