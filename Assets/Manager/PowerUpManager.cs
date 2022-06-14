using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public int maxPowerUpAmount;

    public Transform spawnArea;

    public Vector2 powerUpAreaMin;

    public Vector2 powerUpAreaMax;

    private List<GameObject> powerUpList;

    public List<GameObject> powerUpTemplateList;

    public int spawnInterval;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        powerUpList = new List<GameObject>();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            generateRandomPowerUp();
            timer -= spawnInterval;
        }
    }

    public void generateRandomPowerUp()
    {
        generateRandomPowerUp(new Vector2(Random
                .Range(powerUpAreaMin.x, powerUpAreaMax.x),
            Random.Range(powerUpAreaMin.y, powerUpAreaMax.y)));
    }

    public void generateRandomPowerUp(Vector2 position)
    {
        if (powerUpList.Count >= maxPowerUpAmount)
        {
            return;
        }
        if (
            position.x < powerUpAreaMin.x ||
            position.x > powerUpAreaMax.x ||
            position.y < powerUpAreaMin.y ||
            position.y > powerUpAreaMax.y
        )
        {
            return;
        }

        int randomIndex = Random.Range(0, powerUpTemplateList.Count);

        GameObject powerUp =
            Instantiate(powerUpTemplateList[randomIndex],
            new Vector3(position.x,
                position.y,
                powerUpTemplateList[randomIndex].transform.position.z),
            Quaternion.identity,
            spawnArea);
        powerUp.SetActive(true);
        powerUpList.Add (powerUp);
    }

    public void removePowerUp(GameObject powerUp)
    {
        powerUpList.Remove (powerUp);
        Destroy (powerUp);
    }

    public void removerAllPowerUp()
    {
        while (powerUpList.Count > 0)
        {
            removePowerUp(powerUpList[0]);
        }
    }
}
