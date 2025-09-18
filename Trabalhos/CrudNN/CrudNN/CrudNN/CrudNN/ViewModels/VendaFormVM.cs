using System.ComponentModel.DataAnnotations;
namespace CrudNN.ViewModels;
public class VendaFormVM
{
    [Required]
    public int ClienteId { get; set; }
    public List<VendaItemVM> Itens { get; set; } = new();
}