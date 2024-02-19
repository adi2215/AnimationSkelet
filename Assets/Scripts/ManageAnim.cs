using UnityEngine;

public class ManageAnim : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void JumpPlay()
    {
        anim.Play("Jump");
    }

    public void IdlePlay()
    {
        anim.Play("Idle");
    }
}
