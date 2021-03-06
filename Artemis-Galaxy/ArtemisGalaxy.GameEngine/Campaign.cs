//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtemisGalaxy.GameEngine
{
    using System;
    using System.Collections.Generic;
    
    public partial class Campaign
    {
        public Campaign()
        {
            this.CampaignEnrollments = new HashSet<CampaignEnrollment>();
            this.Sectors = new HashSet<Sector>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public short maxPlayers { get; set; }
        public string sectorMapDirectory { get; set; }
        public int mapSizeX { get; set; }
        public int mapSizeY { get; set; }
        public System.DateTime startDate { get; set; }
        public System.DateTime endDate { get; set; }
        public bool active { get; set; }
    
        public virtual ICollection<CampaignEnrollment> CampaignEnrollments { get; set; }
        public virtual ICollection<Sector> Sectors { get; set; }
    }
}
