using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_EContact.WinForm.Models
{
    public static class DBContact
    {
        public static List<Contact> lstContacts;

        // Ajouter un contact à la liste des contacts
        public static int AddContact(Contact c)
        {
            if (lstContacts == null)
            {
                lstContacts = new List<Contact>();
            }
            c.Id = lstContacts.Any() ? lstContacts.Max(x => x.Id) + 1 : 100; // Lambda Expressions
            lstContacts.Add(c);

            return c.Id;
        }
        // Récuperer la liste des contacts
        public static List<Contact> GetListContacs()
        {
            return lstContacts;
        }
        // Supprimer un contact
        public static void DeleteContact(int IdContact)
        {
            int index = lstContacts.FindIndex(x => x.Id == IdContact);
            lstContacts.RemoveAt(index);

        }

        // Modifier un contact
        public static void UpdateContact(Contact c)
        {
            Contact rech =lstContacts.FirstOrDefault(x => x.Id == c.Id);
            rech.NomComplet = c.NomComplet;
            rech.DateNaiss = c.DateNaiss;
            rech.LieuNaiss = c.LieuNaiss;
            rech.Email = c.Email;
            rech.Sexe = c.Sexe;
            rech.Tel = c.Tel;
            rech.Photo = c.Photo;
        }
        //Chercher par nom
        public static List<Contact> SearchContact(string name)
        {
            List<Contact> res = lstContacts.Where(x => x.NomComplet.ToLower().Contains(name.ToLower())).ToList();
            return res;
        }
}
}
