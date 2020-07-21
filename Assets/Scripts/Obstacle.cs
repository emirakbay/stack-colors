using UnityEngine;
using System.Collections;
public class Obstacle : MonoBehaviour
{
    public Colors color;
    public IEnumerator AnimationCoroutine(Vector3 target)
    {
        while (Vector3.Distance(target, transform.localPosition) > 0.1f)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, target, 0.125f);
            yield return null;
        }

        transform.localPosition = target;
    }
    public void Animate(Vector3 target)
    {
        StartCoroutine(AnimationCoroutine(target));
    }
}

public enum Colors { Red, Green, Blue};