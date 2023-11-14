using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [DisplayName(displayName: "Cinema Logo")]
        public string Logo { get; set; }
        [DisplayName(displayName: "Cinema Name")]
        public string Name { get; set; }
        [DisplayName(displayName: "Description")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
