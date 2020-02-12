using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Parallel
{
    public partial class Form1 : Form
    {
        Usuari usuari = new Usuari();
        Stopwatch stopWatch = new Stopwatch();
        List<Usuari> usuaris;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            stopWatch.Restart();

            foreach (Usuari user in usuaris)
            {
                Parallel.Invoke(
                    () => usuari.comprova_dni(user.dni),
                    () => usuari.comprova_nom(user.Name),
                    () => usuari.comprova_mail(user.email)
                );
            }

            stopWatch.Stop();

            tempsParallel.Text = stopWatch.ElapsedMilliseconds.ToString("n2");
        }

        private void btnNoParallel_Click(object sender, EventArgs e)
        {
            stopWatch.Restart();

            foreach (Usuari user in usuaris) {

                usuari.comprova_dni(user.dni);
                usuari.comprova_nom(user.Name);
                usuari.comprova_mail(user.email);

            }

            stopWatch.Stop();

            tempsNoParallel.Text = stopWatch.ElapsedMilliseconds.ToString("n2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string json = File.ReadAllText("people.json");
            usuaris = JsonConvert.DeserializeObject<List<Usuari>>(json);
        }
    }
}
