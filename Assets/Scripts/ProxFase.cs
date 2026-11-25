using UnityEngine;
using UnityEngine.SceneManagement;

public class ProxFase : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bolinha"))
        {
            TrocarProximaCena();
        }

        
    }

    private void TrocarProximaCena()
    {
        int cenaAtualIndex = SceneManager.GetActiveScene().buildIndex;
        int proximaCenaIndex = (cenaAtualIndex + 1) % SceneManager.sceneCountInBuildSettings;

        SceneManager.LoadScene(proximaCenaIndex);
    }


}
