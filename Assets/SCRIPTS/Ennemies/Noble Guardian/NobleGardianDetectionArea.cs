using System.Collections;
using UnityEngine;

public class NobleGardianDetectionArea : MonoBehaviour
{
    public NobleGuardian nobleGuardian;

    private GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // D�tection de l'entr�e du joueur dans la zone
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && PlayerMovement.instance.canBeDetected)
        {
            nobleGuardian.DetectPlayer(true);
        }
    }
}
