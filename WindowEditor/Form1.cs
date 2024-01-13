using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowEditor
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr FindWindow(string className, string windowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);


        public Form1()
        {
            InitializeComponent();
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.newWindowTitleTextBox.Text))
            {
                MessageBox.Show("Новый заголовок не может быть пустым!");
                return;
            }

            IntPtr hWnd = FindWindow(null, this.windowTitleTextBox.Text);

            if (hWnd != IntPtr.Zero)
            {
                SendMessage(hWnd, 0x000C, 0, this.newWindowTitleTextBox.Text);

                MessageBox.Show("Окно успешно переименовано");
            }
            else
            {
                MessageBox.Show("Окно не найдено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = FindWindow(null, this.windowTitleTextBox.Text);

            if (hWnd != IntPtr.Zero)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Необходимо подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    SendMessage(hWnd, 0x0010, 0, "Пока");
                }
            }
            else
            {
                MessageBox.Show("Окно не найдено");
            }
        }
    }
}
