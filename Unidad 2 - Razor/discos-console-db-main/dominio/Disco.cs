using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dominio
{
    public class Disco
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El titulo es obligatoria")]
        public string Titulo { get; set; }

        [DisplayName("Fecha de lanzamiento")]
        [Required(ErrorMessage = "La fecha de lanzamiento es obligatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime FechaLanzamiento { get; set; }

        [DisplayName("Cantidad de canciones")]
        [Required(ErrorMessage = "La cantidad de canciones es obligatoria")]
        public int CantidadCanciones { get; set; }

        [DisplayName("Arte de tapa")]
        [Required(ErrorMessage = "La URL de imagén es obligatoria")]
        public string UrlTapa { get; set; }

        public Estilo Estilo { get; set; }
        public TipoEdicion TipoEdicion { get; set; }
    }
}
