using UnityEngine;
using UnityEngine.SceneManagement;

// ReSharper disable CheckNamespace
// ReSharper disable ConvertToConstant.Local
// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float _secondsToReloadSceneAfterFinish = 0.5f;

    private const string PlayerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != PlayerTag)
        {
            return;
        }

        Invoke(nameof(ReloadScene), _secondsToReloadSceneAfterFinish);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
