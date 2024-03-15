using Market.Models;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Market.ViewModels
{
    public class AuthorizationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _login;
        private string _password;

        public string LoginCommand
        {
            get { return _login; }
            set
            {
                _login = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LoginCommand)));
            }
        }

        public string PasswordCommand
        {
            get { return _password; }
            set
            {
                _password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PasswordCommand)));
            }
        }

        public ICommand EntranceCommand { get; set; }

        public AuthorizationViewModel()
        {
            EntranceCommand = new RelayCommand(Enter);
        }

        private void Enter(object obj)
        {
            // Проверяем, что логин и пароль соответствуют требуемым
            if (LoginCommand == "admin" && PasswordCommand == "admin") // Пример для демонстрации
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                // Закрываем окно авторизации
                Application.Current.Windows[0].Close(); // Предполагается, что это окно авторизации (индекс 0)
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
