using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _420practice.Models
{
    public class FighterInfoEntry
    {
        public List<FighterGetSet> SeedDatabase()
        {
            var list = new List<FighterGetSet>();
            list.Add(new FighterGetSet { FighterName = "GSP", Id = 1,Weight=170,Camp="tristar" });
            list.Add(new FighterGetSet { FighterName = "DC", Id = 2, Weight = 205, Camp = "AKA" });
            return list;

        }
        //public interface IFighterData
        //{
        //    IEnumerable<FighterInfoEntry> GetAll(); 
        //}
    }
}