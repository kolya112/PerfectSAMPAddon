using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using System.Threading;
using INIManager;
using UnkovSAMPAPI;

namespace PerfectSAMPPatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HubManager settings = new HubManager(Application.StartupPath + @"\common\settings.ini"); // Инициализируем переменную settings для управления файлом settings.ini
        }

        private void start_Click(object sender, EventArgs e)
        {
            HubManager settings1 = new HubManager(Application.StartupPath + @"\common\settings.ini"); // Инициализируем переменную settings для управления файлом settings.ini
            string mypath = settings1.GetString("main", "path"); // Получение из настроек путь к samp.exe
            string adress = settings1.GetString("main", "adress"); // Получение из настроек IP:порт
            string nick = settings1.GetString("main", "nick"); // Получение из настроек ника
            using (RegistryKey checknick = Registry.CurrentUser.OpenSubKey(@"Software\SAMP", true)) // Инициализация реестра с разделом SAMP
            {
                if (checknick != null) // Проверка существование на раздел SAMP в реестре
                {
                    if (checknick.GetValue("PlayerName") != null) // Проверка на существования PlayerName переменной в реестре, разделе SAMP
                    {
                        checknick.SetValue("PlayerName", nick); // Приравниваем переменную nick из settings.ini в реестр, раздел SAMP
                    }
                }
            }
            //MessageBox.Show("Debug code: 1");
            Process.Start(mypath, adress); // Запускаем игру
            Thread.Sleep(30000); // Программа засыпает на 30 секунд

            var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
            if (runningProcs.Count(p => p.ProcessName.Contains("gta_sa")) > 0) // Проверяем, запущен ли процесс GTA SA на компьютере
            {
                // Запускаем патчи для SAMP
                Thread one = new Thread(one1);
                //one.Start();
                Process process = Process.GetProcessesByName("gta_sa")[0];
                IntPtr processHandle = SAMPAPI.OpenProcess(0x1F0FFF, false, process.Id);

                //int bytesWritten = 0;
                int bytesReading = 0;
                //byte[] buffer = Encoding.Unicode.GetBytes("It works!\0");
                byte[] buffer = new byte[30]; //'Hello World!' takes 12*2 bytes because of Unicode
                // '\0' marks the end of string

                // replace 0x0046A3B8 with your address
                //SAMPAPI.WriteProcessMemory((int)processHandle, 0x0046A3B8, buffer, buffer.Length, ref bytesWritten);
                SAMPAPI.ReadProcessMemory((int)processHandle, 0xB7CE50, buffer, buffer.Length, ref bytesReading);
                API.AddChatMessage(Encoding.Unicode.GetString(buffer) + "(" + bytesReading.ToString() + "bytes)");
                /*Thread two = new Thread(two2);
                two.Start();
                Thread three = new Thread(three3);
                three.Start();
                Thread four = new Thread(four4);
                four.Start();
                Thread five = new Thread(five5);
                five.Start();*/
            }
            else
            {

            }
        }

        private void getSAMPscreens_Click(object sender, EventArgs e)
        {

        }

        private void getgameclient_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {

        }

        public static void one1()
        {
            do
            {
                if (API.GetFrameRate() < 10)
                {
                    
                }
                API.AddChatMessage("[SAMPPatch] Система обнаружила, что у Вас очень маленький FPS, закройте другие процессы.");
                if (API.GetFrameRate() > 10)
                {

                }
            }
            while (true);
        }

        public static void two2()
        {
            do
            {

            }
            while (true);
        }

        public static void three3()
        {
            do
            {

            }
            while (true);
        }

        public static void four4()
        {
            do
            {

            }
            while (true);
        }

        public static void five5()
        {
            do
            {

            }
            while (true);
        }
    }
}
