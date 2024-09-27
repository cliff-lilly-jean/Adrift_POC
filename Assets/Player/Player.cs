using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private string playerName;
    public GameObject[] childPrefabs; // Array of prefabs to instantiate

    void Start()
    {
        // Example of adding multiple children at runtime
        foreach (var prefab in childPrefabs)
        {
            AddChild(prefab);
        }
    }

    public void AddChild(GameObject prefab)
    {
        // Instantiate the child prefab
        GameObject child = Instantiate(prefab);

        // Set the parent of the instantiated prefab
        child.transform.SetParent(transform, false); // 'false' keeps local scale/rotation intact

        // Optionally, you can set the position or other properties
        child.transform.localPosition = Vector3.zero; // Position it relative to the parent
    }


}
