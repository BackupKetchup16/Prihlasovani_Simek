using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace Prihlasovani
{
    // Základní třída pro uživatele
    [XmlInclude(typeof(Admin))]
    public class User
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        public User() { } //prazdný konstruktor

        public User(string username, string password)
        {
            Username = username;
            PasswordHash = HashPassword(password);
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }

    // Administrátor dědící od uživatele
    public class Admin : User
    {
        public Admin() : base() { }
        public Admin(string username, string password) : base(username, password) { }
    }

    //Serializace
    public static class DataService
    {
        private static string filePath = "users.xml";

        public static void SaveUsers(List<User> users)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, users);
            }
        }

        public static List<User> LoadUsers()
        {
            if (!File.Exists(filePath)) return new List<User>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (List<User>)serializer.Deserialize(fs);
            }
        }
    }
}