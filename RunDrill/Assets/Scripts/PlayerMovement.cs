using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;

    public static PlayerMovement Instance;

    private Robot robot;

    private AnimatedRobotCollision animatedRobot;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        robot = GetComponentInParent<Robot>();
        animatedRobot = GetComponentInChildren<AnimatedRobotCollision>();
    }

    private void FixedUpdate()
    {
        if (robot.dead || animatedRobot.isFinished)
            return;

        else
            MovePlayer();
    }

    private void MovePlayer()
    {
        transform.position = transform.position + Vector3.forward * speed;
    }

    public float getDistance()
    {
        var animatedRb = gameObject.transform.GetChild(0).GetComponent<Rigidbody>();

        return animatedRb.worldCenterOfMass.y - 0.75f;
    }
}
