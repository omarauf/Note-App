using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Note
    {
        public string note { get; set; }
        public int note_id { get; set; }
        public string note_title { get; set; }
        public string tag { get; set; }

        public override string ToString()
        {
            //return "note: " + note_title + ", " + "note id: " + note_id + "Tag: " + tag;
            return note_title;
        }
    }
}
