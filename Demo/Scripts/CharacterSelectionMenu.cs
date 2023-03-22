namespace ShizoGames.MenuManagement.Demo
{
    public sealed class CharacterSelectionMenu : Menu
    {
        public void Button_Back()
        {
            MenuViewer.OpenLastMenu();
        }
        
        public void Button_Game()
        {
            MenuViewer.OpenMenu<GameMenu>();
        }
    }
}