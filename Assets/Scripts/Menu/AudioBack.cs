using UnityEngine;
using UnityEngine.UI;

public class AudioBack : MonoBehaviour
{
    private Button btn;
    private AudioSource audioSource;
    private AudioClip sonido;

    private void Awake()
    {
        btn = GetComponent<Button>();
        audioSource = GetComponent<AudioSource>();

        // Cargar el clip desde Resources
        sonido = Resources.Load<AudioClip>("interface");

        btn.onClick.AddListener(() => {
            Debug.Log("Botón presionado");
            if (sonido != null && audioSource != null)
                audioSource.PlayOneShot(sonido);
            else
                Debug.LogWarning("No se pudo reproducir el sonido.");
        });
    }
}
