using UnityEngine;
using UnityEngine.SceneManagement;

namespace Shared
{
    public class PrototypeSwitcher : MonoBehaviour
    {
        public static PrototypeSwitcher instance;
        [SerializeField]
        private GameObject menu;
        void Awake()
        {
            if (instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        public int prototypeIndex;

        public void LoadNext()
        {
            prototypeIndex++;
            SceneManager.LoadScene(prototypeIndex);
        }
        public void LoadPrevious()
        {
            prototypeIndex--;
            SceneManager.LoadScene(prototypeIndex);
        }
        public void LoadMenu()
        {
            prototypeIndex = 0;
            SceneManager.LoadScene(prototypeIndex);
            instance = null;
            Destroy(gameObject);
        }
        public void toggleMenu()
        {
            menu.SetActive(!menu.activeInHierarchy);
        }
    }
}
