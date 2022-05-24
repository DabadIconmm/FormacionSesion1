using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Entidades
{
    public class Familia
    {
        [Key] //indicas a Id (o cualquier campo con otro nombre) que es la Key de la tabla en BBDD
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
