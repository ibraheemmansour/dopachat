
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DopaChat.Data
{

using System;
    using System.Collections.Generic;
    
public partial class User
{

    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Nickname { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public string Description { get; set; }

    public string Languages { get; set; }

    public string Country { get; set; }

    public string Keywords { get; set; }

    public Nullable<int> CityId { get; set; }



    public virtual City City { get; set; }

}

}
