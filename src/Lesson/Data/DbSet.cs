using Lesson.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson.Data
{
    public class DbSet<T> : List<T>
        where T : BaseEntity<int> // Bütün claslar BaseEntity<int> classindan törəsin
    {

        public bool Create(T Entity)
        {
            if (ContainesById(Entity.Id))
            {
                return false;
            }
            else
            {
                Add(Entity);
                return true;
            }
        }


        public bool Delete(T Entity)
        {
            if (Contains(Entity))
            {
                Remove(Entity);
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool Update(T Entity) // Burda Id Update edəcəyi elmentin idsini göndərir qalan datani isə yenisi göndərilir.
        {
            var data = FirstOrDefault(Entity.Id);  // Gödərilən idyə uyğun datani tapir.

            if (data != null) // əgər sözü gedən data varsa 
            {
                if (Delete(data)) // Silecek
                {
                    return Create(Entity); // Dəyişdirilmiş datanı bura əlavə edəcək
                }
                else
                    return false; 
            }

            return false;
        }

        public bool ContainesById(int id) // Contains methodu ilə eynidir. Posta Idə görə işləyir.
        {
            foreach (var item in this)
            {
                if (item.Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        public T FirstOrDefault(int id)  //  Əgər bu idli elemet möcudrsa mənə geri qyatar amma yoxdursa null
        {
            foreach (var item in this)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }


    }
}
