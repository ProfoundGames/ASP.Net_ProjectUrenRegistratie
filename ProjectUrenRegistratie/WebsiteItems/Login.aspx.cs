using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace ProjectUrenRegistratie.WebsiteItems
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UrenRegistratieEntities1 EntityModel = new UrenRegistratieEntities1();

            string userStr = txtUsername.Text.ToLower();
            string passwordStr = CalculateHashedPassword(txtPassword.Text);

            var Gebruiker = from g in EntityModel.Users
                            where g.passwrd == passwordStr && g.username == userStr
                            select new { ID = g.userId, naam = g.firstname, achternaam = g.lastname, rechten = g.permission, foto = g.photo };

            if (Gebruiker.Any())
            {
                var UserIDGetter = (from uID in Gebruiker
                                    select uID.ID);

                foreach (int uID in UserIDGetter)
                {
                    userId = uID;
                }

                #region MOTD
                var LoggedUser = (from LogUse in Gebruiker
                                  select LogUse.naam);

                foreach (string logUserName in LoggedUser)
                {
                    //Met javascript doen
                    //MessageBox.Show("Welcome" + " " + logUserName + "\n Have a nice day.");
                }
                #endregion

                //van hier moet je dus ingelogt zijn
            }
            else
            {
                // wachtwoord/user name is fout 
            }

        }

        private static string CalculateHashedPassword(string clearpwd)
        {
            using (var sha = SHA256.Create())
            {
                //dit hier asap fixen
                var computedHash = sha.ComputeHash(Encoding.Unicode.GetBytes(clearpwd));

                return Convert.ToBase64String(computedHash);
            }
        }
    }
}