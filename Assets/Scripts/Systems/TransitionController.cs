using UnityEngine;

using System.Collections;

public class TransitionController : MonoBehaviour
{
    public static TransitionController Instance { get; private set; }

    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private float defaultDuration = 0.5f;
    [SerializeField] private bool keepAcrossScenes = true;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;

        if (keepAcrossScenes) DontDestroyOnLoad(this.gameObject);

        if (!canvasGroup) canvasGroup = GetComponentInChildren<CanvasGroup>(true);

        if (canvasGroup) canvasGroup.alpha = 1f;
    }

    IEnumerator Fade(float from, float to, float duration)
    {
        
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
