//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nguoidung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nguoidung()
        {
            this.Donhangs = new HashSet<Donhang>();
        }
    
        public int MaNguoiDung { get; set; }
        public string Hoten { get; set; }
        public string Email { get; set; }
        public string Dienthoai { get; set; }
        public string Matkhau { get; set; }
        public Nullable<int> IDQuyen { get; set; }
        public string Diachi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donhang> Donhangs { get; set; }
        public virtual PhanQuyen PhanQuyen { get; set; }
    }
}
