using System.Windows.Forms;

namespace Pickle
{
    public static class Pick
    {
        public static string GetFile(string title, string folder, string filter = "\"PR files (*.pr)|*.pr|P files (*.p)|*.p|All files (*.*)|*.*\"", int index = 1)
        {
            OpenFileDialog getter = new()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = title,
                FilterIndex = index,
                Filter = filter,
                InitialDirectory = folder,
                ShowHelp = false,
                ShowPinnedPlaces = false
            };

            getter.ShowDialog();
            return getter.FileName;
        }
    }
}
