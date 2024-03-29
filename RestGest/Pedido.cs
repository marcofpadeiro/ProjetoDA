//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            this.ItemMenus = new HashSet<ItemMenu>();
            this.Pagamentos = new HashSet<Pagamento>();
        }
    
        public int Id { get; set; }
        public decimal ValorTotal { get; set; }
        public int TrabalhadorId { get; set; }
        public int ClienteId { get; set; }
        public int RestauranteId { get; set; }
        public int EstadoId { get; set; }
        public int PagamentoId { get; set; }
    
        public virtual Trabalhador Trabalhador { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Restaurante Restaurante { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemMenu> ItemMenus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagamento> Pagamentos { get; set; }
        public override string ToString()
        {
            return this.Id + "- " + this.Cliente.Nome + " - " + this.ValorTotal + "�";
        }
    }
}
