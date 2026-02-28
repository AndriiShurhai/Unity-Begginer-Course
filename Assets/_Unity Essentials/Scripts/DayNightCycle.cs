using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Settings")]
    [Tooltip("How many real-time seconds a full in-game day lasts.")]
    [SerializeField] private float dayDurationInSeconds = 120f;

    private float rotationSpeed;

    private void Start()
    {
        CalculateRotationSpeed();
    }

    private void Update()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }

    private void OnValidate()
    {
        // Recalculate if value changes in Inspector
        CalculateRotationSpeed();
    }

    private void CalculateRotationSpeed()
    {
        if (dayDurationInSeconds <= 0.01f)
            dayDurationInSeconds = 0.01f;

        // 360 degrees divided by total seconds = degrees per second
        rotationSpeed = 360f / dayDurationInSeconds;
    }
}