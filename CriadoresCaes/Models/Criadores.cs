using System.ComponentModel.DataAnnotations;

namespace CriadorDeCaes.Models
{

    /// <summary>
    /// dados dos criadores dos cães
    /// </summary>
    public class Criadores
    {

        public Criadores()
        {
            // inicializar a lista de animais do criador
            ListaAnimais = new HashSet<Animais>();
            // inicializar a lista de Raças que o Criador cria
            ListaRacas = new HashSet<Racas>();
        }


        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do criador
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [StringLength(50)]
        public string Nome { get; set; }

        /// <summary>
        /// nome pelo qual o criador é conhecido no 
        /// negócio de venda de cães
        /// </summary>
        [Display(Name = "Nome Comercial")]
        [StringLength(50)]
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada do criador
        /// </summary>
        [StringLength(60)]
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal da morada do criador
        /// </summary>
        [Display(Name = "Código Postal")]
        [RegularExpression("[1-9][0-9]{3}-[0-9]{3}( ){1,3}[A-Z -ÇÀÁÉÍÓÚÂÊÎÔÛ]+",
                         ErrorMessage = "O {0} deve ter o formato XXXX-XXX NOME DA TERRA")]
        [StringLength(20)]
        public string CodPostal { get; set; }

        /// <summary>
        /// Telemóvel do criador
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [Display(Name = "Telemóvel")]
        [StringLength(9, MinimumLength = 9,
                    ErrorMessage = "Deve escrever {1} dígitos no número {0}.")]
        [RegularExpression("9[1236][0-9]{7}")] // exemplo com indicativo internacional: ((+|00)[0-9]{2,5})?[0-9]{5,9}
        public string Telemovel { get; set; }

        /// <summary>
        /// Email do criador
        /// </summary>
        [EmailAddress]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        public string Email { get; set; }

        // *********************************************

        /// <summary>
        /// Lista dos animais propriedade do Criador
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }

        /// <summary>
        /// Lista dos raças que o criador cria
        /// (concretização do relacionamento M-N)
        /// </summary>
        public ICollection<Racas> ListaRacas { get; set; }

    }
}