//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Лопушок
{
    using System;
    using System.Collections.Generic;
    
    public partial class Продукты
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Продукты()
        {
            this.Материалы_продуктов = new HashSet<Материалы_продуктов>();
        }
    
        public int ИД { get; set; }
        public string Наименование_продукции { get; set; }
        public string Артикул { get; set; }
        public decimal Минимальная_стоимость_для_агента { get; set; }
        public string Изображение { get; set; }
        public int Количество_человек_для_производства { get; set; }
        public int Номер_цеха_для_производства { get; set; }
        public Nullable<int> Тип_продукции { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Материалы_продуктов> Материалы_продуктов { get; set; }
        public virtual Тип_продукции Тип_продукции1 { get; set; }
    }
}
