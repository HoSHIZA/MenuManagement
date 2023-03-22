using UnityEngine;

namespace ShizoGames.MenuManagement.Demo
{
    [RequireComponent(typeof(MenuViewer<>))]
    public class MenuViewerTestBehaviour : MonoBehaviour
    {
        private MenuViewer _menuViewer;

        private void Awake()
        {
            _menuViewer = GetComponent<MenuViewer>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                _menuViewer.CloseAllMenus(destroy: true);
                _menuViewer.OpenMenu<MainMenu>();
            }
            
            if (Input.GetKeyDown(KeyCode.Z))
            {
                _menuViewer.OpenLastMenu();
            }
            
            if (Input.GetKeyDown(KeyCode.X))
            {
                _menuViewer.CloseCurrentMenu();
            }
        }
    }
}