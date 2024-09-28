using UnityEngine;
using System.Collections;

public class Flicker : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public float secondsBetweenFlicker;
    public float flickerRate;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        StartFlickering(secondsBetweenFlicker, flickerRate); // Blink for x seconds, toggling every x seconds
    }

    private IEnumerator FlickerCoroutine(float blinkerTime, float flickerTime)
    {
        float elapsedTime = 0f;

        while (elapsedTime < blinkerTime)
        {
            // Toggle the alpha channel between 0 and 1
            Color color = spriteRenderer.color;
            color.a = (color.a == 0) ? 1 : 0; // Toggle alpha
            spriteRenderer.color = color;

            // Wait for the blink interval
            yield return new WaitForSeconds(flickerTime);

            elapsedTime += flickerTime; // Increment elapsed time
        }

        // Reset alpha to fully visible after blinking
        Color finalColor = spriteRenderer.color;
        finalColor.a = 1;
        spriteRenderer.color = finalColor;

    }

    // Call this method to start blinking
    public void StartFlickering(float duration, float interval)
    {
        StartCoroutine(FlickerCoroutine(duration, interval));
    }



}
