using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField] private GameObject _ragdoll;
    [SerializeField] private GameObject _animatedModel;

    private bool _dead;

    public static Robot Instance;

    private void Awake()
    {
        if (Instance = null)
        {
            Instance = this;
        }

        _ragdoll.gameObject.SetActive(false);

        _dead = false;
    }

    private void CopyTransformData(Transform sourceTransform, Transform destinationTransform)
    {
        if (sourceTransform.childCount != destinationTransform.childCount)
        {
            Debug.LogWarning("Invalid transform copy, they need to match transform hierarchies");
            return;
        }

        for (int i = 0; i < sourceTransform.childCount; i++)
        {
            var source = sourceTransform.GetChild(i);
            var destination = destinationTransform.GetChild(i);
            destination.position = source.position;
            destination.rotation = source.rotation;

            CopyTransformData(source, destination);
        }

    }

    public void ToggleDead()
    {
        _dead = !_dead;

        if (_dead)
        {
            CopyTransformData(_animatedModel.transform, _ragdoll.transform);
            _ragdoll.gameObject.SetActive(true);
            _animatedModel.gameObject.SetActive(false);
        }
    }
}
