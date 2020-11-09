using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    int isBreakingHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isBreakingHash = Animator.StringToHash("isBreaking");
    }

    // Update is called once per frame
    void Update()
    {
        bool mouseButton = Input.GetMouseButton(0);

        bool isBreaking = animator.GetBool(isBreakingHash);

        if (mouseButton && !isBreaking)
        {
            animator.SetBool(isBreakingHash, true);
        }

        if (!mouseButton && isBreaking)
        {
            animator.SetBool(isBreakingHash, false);
        }
    }
}
