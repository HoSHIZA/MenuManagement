namespace ShizoGames.MenuManagement.Demo
{
    public sealed class MainMenu : Menu
    {
        public void Button_CharacterSelection()
        {
            MenuViewer.OpenMenu<CharacterSelectionMenu>();
        }
        
        public void Button_Settings()
        {
            MenuViewer.OpenMenu<SettingsMenu>();
        }
    }
}