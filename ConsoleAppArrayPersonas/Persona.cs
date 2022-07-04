namespace ConsoleAppArrayPersonas
{
    public class Persona
    {
        public string Nombre { get; set; }
        public override string ToString()
        {
            return $"{Nombre}";
        }

        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Persona))
            {
                return false;
            }

            return this.Nombre == ((Persona) obj).Nombre;
        }
    }
}
