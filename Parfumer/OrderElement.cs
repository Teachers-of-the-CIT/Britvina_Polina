//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parfumer
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderElement
    {
        public int Id { get; set; }
        public int Id_Order { get; set; }
        public Nullable<int> Id_User { get; set; }
        public int Quantity { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
    }
}
