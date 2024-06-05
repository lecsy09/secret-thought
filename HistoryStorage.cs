using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secret_thoughts
{
    internal class HistoryStorage
    {
      public static List<Tuple<string,string,string>> UserDiary = new List<Tuple<string, string, string>>();
        public static void NoteEditor_AddedToUserDiary(string title, string today, string notes)
        {
            UserDiary.Add(new Tuple<string, string, string>(title, today, notes));

        }
        public static void RemoveItem(string title, string today, string notes)
        {
            var UserIndex = UserDiary.FindIndex(ph => ph.Item1.Equals(title) && ph.Item2.Equals(today) && ph.Item3.Equals(notes));  
            UserDiary.Remove(UserDiary[UserIndex]);
        }
    }
}
