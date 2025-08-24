using UnityEngine;
using UnityEngine.SceneManagement;

namespace Shared
{
    public class Menu : MonoBehaviour
    {
        public void LoadScene(int index)
        {
            SceneManager.LoadScene(index);
        }
    }
}
