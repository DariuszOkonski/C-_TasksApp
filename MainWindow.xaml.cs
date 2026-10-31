using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTodoButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText = this.ToDoInput.Text;

            if (!string.IsNullOrEmpty(todoText))
            {
                //TextBlock todoItem = new TextBlock
                //{
                //    Text = todoText,
                //    Margin = new Thickness(10),
                //    Foreground = new SolidColorBrush(Colors.White),
                //};
                TextBlock todoItem = new TextBlock();
                todoItem.Text = todoText;
                todoItem.Margin = new Thickness(10);
                todoItem.Foreground = new SolidColorBrush(Colors.White);

                this.TodoList.Children.Add(todoItem);

                this.ToDoInput.Clear();
            }
        }

    }
}