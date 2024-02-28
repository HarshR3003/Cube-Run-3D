using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManage gameManage;

    private void OnTriggerEnter()
    {
        gameManage.CompleteLevel();
    }
}
