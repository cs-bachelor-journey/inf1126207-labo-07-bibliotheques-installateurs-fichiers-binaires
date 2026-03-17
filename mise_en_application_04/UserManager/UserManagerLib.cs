using System.Runtime.Serialization.Formatters.Binary;

namespace UserManagerLib;

public class UserManagerLib
{
    private const string filepath = "UserManager.bin";
    public static List<Utilisateur> LoadUsers(string path)
    {
        FileStream fs = new FileStream(path, FileMode.Open) ;
            BinaryFormatter formatter = new BinaryFormatter();

    }
}