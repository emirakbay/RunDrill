using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;

    private Robot robot;

    public float fillSpeed = 0.5f;

    public Transform player;

    public Transform endLine;

    public float maxDistance;

    public static ProgressBar Instance;

    private void Start()
    {
        maxDistance = LevelGenerator.Instance.distanceFromGround;

        robot = FindObjectOfType<Robot>();
    }

    private void Update()
    {
        if (player.position.y <= maxDistance && player.position.y <= endLine.position.y)
        {
            float distance = 1 - (PlayerMovement.Instance.getDistance() / maxDistance);
            SetProgress(distance);
        }

        if (robot.dead)
        {
            gameObject.SetActive(false);
        }
    }

    private void Awake()
    {
        if (Instance = null)
        {
            Instance = this;
        }

        slider = GetComponent<Slider>();
    }

    public void SetProgress(float newProgress)
    {
        slider.value = newProgress;
    }
}
