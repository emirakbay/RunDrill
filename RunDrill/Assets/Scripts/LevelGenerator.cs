using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Texture2D map;

    public ColorToPrefab[] colorToPrefabs;

    public float distanceFromGround;

    public static LevelGenerator Instance;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        GenerateLevel();
    }

    void GenerateLevel()
    {
        for (int z = 0; z < map.width; z++)
        {
            for (int y = 0; y < map.height; y++)
            {
                GenerateObject(z, y);
            }
        }
    }

    void GenerateObject(int z, int y)
    {
        Color pixelColor = map.GetPixel(z, y);

        if (pixelColor.a == 0)
        {
            // Transparent pixel
        }

        foreach (ColorToPrefab colorMapping in colorToPrefabs)
        {
            if (colorMapping.color.Equals(pixelColor))
            {
                Vector3 position = new Vector3(0, y, z);
                GameObject go = Instantiate(colorMapping.prefab, position, Quaternion.identity, transform);

                if (colorMapping.color.Equals(Color.blue))
                {
                    FollowPlayer.Instance.SetupFollowPlayer(go.transform);
                    distanceFromGround = Vector3.Distance(go.transform.position, new Vector3(0, 0, 0));
                }
            }
        }
    }
}
