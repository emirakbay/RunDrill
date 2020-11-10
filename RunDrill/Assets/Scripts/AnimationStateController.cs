using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;
    private int isBreakingHash;
    private int isFinishedHash;

    private AnimatedRobotCollision animatedRobot;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isBreakingHash = Animator.StringToHash("isBreaking");
        isFinishedHash = Animator.StringToHash("isFinished");

        animatedRobot = GetComponentInChildren<AnimatedRobotCollision>();

    }

    // Update is called once per frame
    void Update()
    {
        bool mouseButton = Input.GetMouseButton(0);

        bool isBreaking = animator.GetBool(isBreakingHash);

        bool isFinished = animator.GetBool(isFinishedHash);

        if (mouseButton && !isBreaking)
        {
            animator.SetBool(isBreakingHash, true);
        }

        if (!mouseButton && isBreaking)
        {
            animator.SetBool(isBreakingHash, false);
        }

        if (animatedRobot.isFinished)
        {
            animator.SetBool(isFinishedHash, true);
        }
    }
}
