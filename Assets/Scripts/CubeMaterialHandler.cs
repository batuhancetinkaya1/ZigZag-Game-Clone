using UnityEngine;
using System.Collections.Generic;

public class CubeMaterialHandler : MonoBehaviour
{
    [SerializeField] private Material material;
    [SerializeField] private List<Color> colors = new List<Color>();
    [SerializeField] private float colorChangeSpeed = 2f;

    private float lerpTime = 0f;
    private int lastIndex = 0;
    private int nextIndex = 1;
    private int previousIndex = -1;

    private void Update()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        lerpTime += Time.deltaTime * colorChangeSpeed;
        material.color = Color.Lerp(colors[lastIndex], colors[nextIndex], lerpTime);

        if (lerpTime >= 1f)
        {
            lerpTime = 0f;
            previousIndex = lastIndex;
            lastIndex = nextIndex;

            // Son 2 renk hariç rastgele renk seç
            int randomIndex;
            do
            {
                randomIndex = Random.Range(0, colors.Count);
            } while (randomIndex == lastIndex || randomIndex == previousIndex);

            nextIndex = randomIndex;
        }
    }
}