using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace NosBreakPatcher
{
    public class Patcher
    { //HttpClient instead of WebClient
        public string filename;
        public readonly ResourceManager rm = new ResourceManager("NosBreakPatcher.Resources.Strings", Assembly.GetExecutingAssembly());



        private async void Updater(object sender, EventArgs e)
        {
            try
            {
                #region Instanciations
                var c = new HttpClient();
                var s = await c.GetAsync(rm.GetString("WEB_URL"));
                s.EnsureSuccessStatusCode();
                var newVersion = await s.Content.ReadAsStringAsync();
                var oldVersion = new Version(Application.ProductVersion);
                #endregion

                if (newVersion != oldVersion.ToString())
                {
                    c.Timeout = TimeSpan.FromMinutes(5);
                }
            }
            catch (HttpRequestException e)
            {

            }




        }
    }
}
