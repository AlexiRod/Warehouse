using System;
using System.Collections.Generic;
using System.Text;

namespace WareHouse
{
    [Serializable]
    public class Section
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public List<Section> Sections { get; set; }
        public List<Ware> Wares { get; set; }

        public Section() { }
        public Section(string name, int code = 0)
        {
            Sections = new List<Section>();
            Wares = new List<Ware>();
            Name = name;
            Code = code;
        }

        public void AddSection(Section section)
        {
            Sections.Add(section);
        }
        public void RemoveSection(Section section)
        {
            foreach (var item in Sections)
                if (item.Name == section.Name)
                {
                    Sections.Remove(item);
                    return;
                }
        }

        public bool ContainsSection(string name)
        {
            foreach (var section in Sections)
                if (section.Name == name)
                    return true;
            return false;
        }

    }
}
