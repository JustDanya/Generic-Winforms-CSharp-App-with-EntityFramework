//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PM01
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attachments
    {
        public int ID { get; set; }
        public string File_name { get; set; }
        public int Tech_ID { get; set; }
    
        public virtual Tech Tech { get; set; }
    }
}
