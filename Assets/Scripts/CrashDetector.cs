using UnityEngine;
using UnityEngine.SceneManagement;

// ReSharper disable CheckNamespace
// ReSharper disable ConvertToConstant.Local
// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float _secondsToReloadSceneAfterCrash = 0.5f;
    private const string GroundTag = "Ground";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != GroundTag)
        {
            return;
        }

        Invoke(nameof(ReloadScene), _secondsToReloadSceneAfterCrash);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
