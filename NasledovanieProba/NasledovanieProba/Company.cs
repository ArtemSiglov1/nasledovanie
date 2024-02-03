using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovanieProba
{
    /// <summary>
    /// Наследуемый класс описывающий работника компании
    /// </summary>
    internal class Microsoft:Person
    {
        /// <summary>
        /// постоянное поле описывающее название компании
        /// </summary>
        const string nameCompany = "Microsoft";
        /// <summary>
        /// поле описывающее должность
        /// </summary>
        string dol;
        /// <summary>
        /// поле описывающее оклад 
        /// </summary>
        int oklad;
        /// <summary>
        /// поле описывающее дату начала работы
        /// </summary>
        DateTime startJob;
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Microsoft() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="surname">фамилия</param>
        /// <param name="name">имя</param>
        /// <param name="otchestvo">отчество</param>
        /// <param name="dol">должность</param>
        /// <param name="oklad">оклад</param>
        /// <param name="startJob">начало работы</param>
        public Microsoft(string surname,string name,string otchestvo,string dol, int oklad, DateTime startJob):base (surname,name,otchestvo) 
        {
            this.Dol = dol;
            this.Oklad = oklad;
            this.StartJob = startJob;
        }
        /// <summary>
        /// свойство поля должности
        /// </summary>

        public string Dol { get => dol; set => dol = value; }
        /// <summary>
        /// свойство поля оклад 
        /// </summary>
        public int Oklad { get => oklad; set => oklad = value; }
        /// <summary>
        /// свойство поля начала работы
        /// </summary>
        public DateTime StartJob { get => startJob; set => startJob = value; }
        /// <summary>
        /// метод для вывода информации о работнике
        /// </summary>
        /// <returns>метод вывода из базового класса, место работы, должность, оклад, дата начала работы</returns>
        public override string ToString()
        {
            return$"{base.ToString()}\n Место работы-{nameCompany}\n Должность-{Dol}\n Оклад-{Oklad}\n Дата начала работы-{StartJob.ToShortDateString()}\n";
        }
    }
}
