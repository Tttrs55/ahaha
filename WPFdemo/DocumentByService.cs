//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFdemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class DocumentByService
    {
        public int ID { get; set; }
        public int ClientServiceID { get; set; }
        public string DocumentPath { get; set; }
    
        public virtual ClientService ClientService { get; set; }
    }
}
