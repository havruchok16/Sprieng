//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dictionary
    {
        public int DictionaryId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Word { get; set; }
        public string Translate { get; set; }
        public Dictionary()
        {

        }
        public Dictionary(int userid, string word, string translate)
        {
            this.UserId = userid;
            this.Word = word;
            this.Translate = translate;
        }
        public virtual User User { get; set; }
    }
}
