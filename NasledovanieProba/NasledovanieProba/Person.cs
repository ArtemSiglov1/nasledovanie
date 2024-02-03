using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovanieProba
{
    /// <summary>
    /// Базовый Класс описывающий человека
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// поле описывающее фамилию
        /// </summary>
        string surname;
        /// <summary>
        /// поле описывающее имя
        /// </summary>
        string name;
        /// <summary>
        /// поле описывающее отчество
        /// </summary>
        string otchestvo;
        
        /// <summary>
        /// свойство для поля фамилии
        /// </summary>
        public string Surname { get => (surname=="")? "Не расспознано" : surname; set => surname = value; }
       /// <summary>
       /// свойство для поля имени
       /// </summary>
        public string Name { get => (name=="")?"Не расспознано":name; set => name = value; }
        /// <summary>
        /// свойство для поля отчества
        /// </summary>
        public string Otchestvo { get => (otchestvo == "") ? "Не расспознано" : otchestvo; set => otchestvo = value; }
      /// <summary>
      /// конструктор по умолчанию
      /// </summary>
        public Person() {  }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="surname">фамилия</param>
        /// <param name="name">имя</param>
        /// <param name="otchestvo">отчество</param>
        public Person(string surname, string name, string otchestvo)
        {
            Surname = surname;
            Name = name;
            Otchestvo = otchestvo;
            
        }
        /// <summary>
        /// Метод для вывода информации о человеке
        /// </summary>
        /// <returns>Фамилию, имя, отчество</returns>
        public override string ToString()
        {
            return $" Фамилия-{surname}\n Имя-{name}\n Отчество-{otchestvo}";
        }
    }
}
