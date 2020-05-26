namespace PreParcial2POO
{
    public class User
    {
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public bool admin { get; set; }

        public User()
        {
            usuario = "";
            contrasena = "";
            admin = false;
        } 
    }
}