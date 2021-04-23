using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_18
{
    public partial class MainForm : Form
    {
        private string FolderName = "Folder_";
        private string TestDirectoryName = "Lab_18 Fedorenko Max Test";
        private const int NumberSubFolders = 100;
        private int SubFoldersCount = 0;
        private DirectoryInfo dirInfo;

        public MainForm()
        {
            InitializeComponent();
            dirInfo = new DirectoryInfo(
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + TestDirectoryName);

            
        }

        private void DeleteFolders()
        {
            foreach (var folder in dirInfo.GetDirectories())
            {
                folder.Delete(true);
            }
        }
        private void ShowMaxNumberSubFolder()
        {
            string path = "D:";
            int count = 0;

            try
            {
                while (true)
                {
                    path += @"\" + 'a';
                    count++;
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Максимальное количество папок " + count);
            }

            Directory.Delete(@"D:\a",true);
        }
        private void DeleteDeepFolders(DirectoryInfo dir)
        {
            if (dir.GetDirectories().Length > 0)
            {
                DeleteDeepFolders(dir.GetDirectories()[0]);
            }
            dir.Delete(true);
        }
        private void CreateSubFolders(DirectoryInfo dir)
        {
            try
            {
                if (SubFoldersCount == NumberSubFolders)
                    return;

                dir.CreateSubdirectory(FolderName + SubFoldersCount++);
                CreateSubFolders(dir.GetDirectories()[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("Максимальное количество папок " + SubFoldersCount);
            }
        }

        private void CreateFolder_Click(object sender, EventArgs e)
        {
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            for (int i = 0; i < 100; i++)
            {
                dirInfo.CreateSubdirectory(FolderName + i);
            }

            MessageBox.Show("Было создано 100 папок в папку \"Lab_18 Fedorenko Max Test\" на рабочем столе. " +
                "После нажатия кнопки \"Ок\" эти папки удаляться");

            if (dirInfo.Exists)
            {
                DeleteFolders();
            }

            dirInfo.Delete(true);
        }
        private void CreateSubFolder_Click(object sender, EventArgs e)
        {
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            else
            {
                DeleteFolders();
            }

            CreateSubFolders(dirInfo);
        }
        private void CheckMaxSubFolders_Click(object sender, EventArgs e)
        {
            ShowMaxNumberSubFolder();
        }
    }
}