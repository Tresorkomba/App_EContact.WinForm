using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_EContact.WinForm.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string NomComplet { get; set; }
        public DateTime DateNaiss { get; set; }
        public string Email { get; set; }
        public string Sexe { get; set; }
        public string Tel { get; set; }
        public string urlPhoto { get; set; }

        public Contact(string nomComplet, DateTime dateNaiss, string email, string sexe, string tel, string urlPhoto)
        {
            NomComplet = nomComplet;
            DateNaiss = dateNaiss;
            Email = email;
            Sexe = sexe;
            Tel = tel;
            this.urlPhoto = urlPhoto;
        }
        public Contact ()
        {

        }
}
