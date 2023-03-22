namespace ShizoGames.MenuManagement.Demo
{
    public sealed class SettingsMenu : Menu
    {
        public void Button_Back()
        {
            MenuViewer.OpenLastMenu();
        }
    }
}