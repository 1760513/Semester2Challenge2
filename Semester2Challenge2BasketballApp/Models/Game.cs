//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Semester2Challenge2BasketballApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        public int GameID { get; set; }
        public System.DateTime DateandTime { get; set; }
        public string Location { get; set; }
        public int PlayerID { get; set; }
        public string FeePayer { get; set; }
        public decimal Fee { get; set; }
        public bool Forfeit { get; set; }
    
        public virtual Player Player { get; set; }
    }
}
