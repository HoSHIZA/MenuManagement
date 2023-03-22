namespace ShizoGames.MenuManagement.Demo
{
    public sealed class GameMenu : Menu
    {
        public void Button_Back()
        {
            MenuViewer.OpenLastMenu();
        }
    }
}